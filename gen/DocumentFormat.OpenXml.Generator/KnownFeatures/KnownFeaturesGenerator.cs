﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Generator.Editor;
using DocumentFormat.OpenXml.Generator.KnownFeatures;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DocumentFormat.OpenXml.Generator.KnownFeatures;

[Generator]
public class KnownFeaturesGenerator : ISourceGenerator
{
    private static readonly DiagnosticDescriptor DuplicateAttribute = new("OOX1000", "Duplicate known features", "Service {0} is already registered for {1}", "KnownFeatures", DiagnosticSeverity.Error, isEnabledByDefault: true);
    private static readonly DiagnosticDescriptor SingleContractForFeature = new("OOX1001", "Duplicate contracts registered", "Can only register a single contract for {0}", "KnownFeatures", DiagnosticSeverity.Error, isEnabledByDefault: true);
    private static readonly DiagnosticDescriptor InvalidFactoryMethod = new("OOX1002", "Invalid factory method", "Method {0} must have no parameters and return {1} type", "KnownFeatures", DiagnosticSeverity.Error, isEnabledByDefault: true);
    private static readonly DiagnosticDescriptor InvalidDelegatedFeatures = new("OOX1003", "Invalid delegated features", "Member {0} must have no parameters if a method and return IFeatureCollection", "KnownFeatures", DiagnosticSeverity.Error, isEnabledByDefault: true);

    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxReceiver is not KnownFeatureReceiver receiver)
        {
            return;
        }

        var knownFeatureSymbol = context.Compilation.GetTypeByMetadataName("DocumentFormat.OpenXml.KnownFeatureAttribute");
        var threadSafe = context.Compilation.GetTypeByMetadataName("DocumentFormat.OpenXml.ThreadSafeAttribute");
        var delegated = context.Compilation.GetTypeByMetadataName("DocumentFormat.OpenXml.DelegatedFeatureAttribute");
        var iFeatures = context.Compilation.GetTypeByMetadataName("DocumentFormat.OpenXml.Features.IFeatureCollection");

        if (knownFeatureSymbol is null)
        {
            return;
        }

        foreach (var node in receiver.Nodes)
        {
            var model = context.Compilation.GetSemanticModel(node.SyntaxTree);
            var contracts = new HashSet<INamedTypeSymbol>(SymbolEqualityComparer.Default);

            if (model.GetDeclaredSymbol(node) is IMethodSymbol method)
            {
                var features = new HashSet<(INamedTypeSymbol Contract, ISymbol Service)>();
                var delegatedFeatures = new List<ISymbol>();
                var isThreadSafe = false;

                foreach (var attribute in method.GetAttributes())
                {
                    if (SymbolEqualityComparer.Default.Equals(attribute.AttributeClass, threadSafe))
                    {
                        isThreadSafe = true;
                    }
                    else if (SymbolEqualityComparer.Default.Equals(attribute.AttributeClass, delegated))
                    {
                        if (attribute.ConstructorArguments[0].Value is string methodName)
                        {
                            var container = attribute.ConstructorArguments[1].Value as INamedTypeSymbol ?? method.ContainingType;
                            var members = container.GetMembers(methodName);

                            if (members.Length == 1 && members[0] is ISymbol delegatedSymbol && IsValidMember(delegatedSymbol))
                            {
                                delegatedFeatures.Add(delegatedSymbol);
                            }
                            else
                            {
                                var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                context.ReportDiagnostic(Diagnostic.Create(InvalidDelegatedFeatures, location, methodName));
                            }

                            bool IsValidMember(ISymbol symbol)
                            {
                                if (symbol is IMethodSymbol delegatedMethod && delegatedMethod.Parameters.Length == 0 && SymbolEqualityComparer.Default.Equals(iFeatures, delegatedMethod.ReturnType))
                                {
                                    return true;
                                }

                                if (symbol is IFieldSymbol field && SymbolEqualityComparer.Default.Equals(iFeatures, field.Type))
                                {
                                    return true;
                                }

                                if (symbol is IPropertySymbol property && SymbolEqualityComparer.Default.Equals(iFeatures, property.Type))
                                {
                                    return true;
                                }

                                return false;
                            }
                        }
                    }
                    else if (SymbolEqualityComparer.Default.Equals(attribute.AttributeClass, knownFeatureSymbol))
                    {
                        if (attribute.ConstructorArguments[0].Value is INamedTypeSymbol contract)
                        {
                            var service = attribute.ConstructorArguments[1].Value as ISymbol ?? contract;

                            if (attribute.NamedArguments.FirstOrDefault(n => string.Equals("Factory", n.Key, StringComparison.Ordinal)).Value.Value is string methodName)
                            {
                                var members = method.ContainingType.GetMembers(methodName);

                                if (members.Length == 1 && members[0] is IMethodSymbol factory && factory.Parameters.Length == 0 && SymbolEqualityComparer.Default.Equals(contract, factory.ReturnType))
                                {
                                    service = factory;
                                }
                                else
                                {
                                    var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                    context.ReportDiagnostic(Diagnostic.Create(InvalidFactoryMethod, location, methodName, contract.ToDisplayString()));
                                    continue;
                                }
                            }

                            if (!contracts.Add(contract))
                            {
                                if (!features.Add((contract, service)))
                                {
                                    var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                    context.ReportDiagnostic(Diagnostic.Create(DuplicateAttribute, location: location, service.ToDisplayString(), contract.ToDisplayString()));
                                }
                                else
                                {
                                    features.Remove((contract, service));
                                    var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                    context.ReportDiagnostic(Diagnostic.Create(SingleContractForFeature, location: location, service.ToDisplayString()));
                                }
                            }
                            else if (!features.Add((contract, service)))
                            {
                                var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                                context.ReportDiagnostic(Diagnostic.Create(DuplicateAttribute, location: location, service.ToDisplayString(), contract.ToDisplayString()));
                            }
                        }
                    }
                }

                var source = method.Build(delegatedFeatures, features, isThreadSafe);

                context.AddSource($"{method.ContainingType.Name}_{method.Name}", source);
            }
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForSyntaxNotifications(() => new KnownFeatureReceiver());
        context.RegisterForPostInitialization(context =>
        {
            var sb = new StringWriter();
            var indented = new IndentedTextWriter(sb);

            const string Source = @"namespace DocumentFormat.OpenXml;

[global::System.Diagnostics.Conditional(""OPENXMLGENERATOR"")]
[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
internal sealed class KnownFeatureAttribute : global::System.Attribute
{
    public KnownFeatureAttribute(global::System.Type contract, global::System.Type? service = null)
    {
    }

    public string? Factory { get; set; }
}

[global::System.Diagnostics.Conditional(""OPENXMLGENERATOR"")]
[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
internal sealed class DelegatedFeatureAttribute : global::System.Attribute
{
    public DelegatedFeatureAttribute(string name, global::System.Type? container = null)
    {
    }
}

[global::System.Diagnostics.Conditional(""OPENXMLGENERATOR"")]
[global::System.AttributeUsage(global::System.AttributeTargets.Method)]
internal sealed class ThreadSafeAttribute : global::System.Attribute
{
}";

            sb.WriteFileHeader();
            sb.WriteLine(Source);

            context.AddSource("KnownFeatureAttribute", sb.ToString());
        });
    }

    private class KnownFeatureReceiver : ISyntaxReceiver
    {
        public List<MethodDeclarationSyntax> Nodes { get; } = new();

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            if (syntaxNode.IsKind(SyntaxKind.MethodDeclaration) && syntaxNode is MethodDeclarationSyntax method)
            {
                foreach (var list in method.AttributeLists)
                {
                    foreach (var attribute in list.Attributes)
                    {
                        if (attribute.Name.ToString().Contains("KnownFeature"))
                        {
                            Nodes.Add(method);
                            return;
                        }
                    }
                }
            }
        }
    }
}
