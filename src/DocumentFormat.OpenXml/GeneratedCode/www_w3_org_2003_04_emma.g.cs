﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Ink;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.EMMA
{
    /// <summary>
    /// <para>Defines the DerivedFrom Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:derived-from.</para>
    /// </summary>
    [SchemaAttr("emma:derived-from")]
    public partial class DerivedFrom : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DerivedFrom class.
        /// </summary>
        public DerivedFrom() : base()
        {
        }

        /// <summary>
        /// <para>resource</para>
        /// <para>Represents the following attribute in the schema: resource</para>
        /// </summary>
        [SchemaAttr("resource")]
        public StringValue? Resource
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>composite</para>
        /// <para>Represents the following attribute in the schema: composite</para>
        /// </summary>
        [SchemaAttr("composite")]
        public BooleanValue? Composite
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:derived-from");
            builder.AddElement<DerivedFrom>()
                .AddAttribute("resource", a => a.Resource, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("composite", a => a.Composite);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DerivedFrom>(deep);
    }

    /// <summary>
    /// <para>Defines the Info Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:info.</para>
    /// </summary>
    [SchemaAttr("emma:info")]
    public partial class Info : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Info class.
        /// </summary>
        public Info() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Info class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Info(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Info class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Info(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Info class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Info(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:info");
            builder.AddElement<Info>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Info>(deep);
    }

    /// <summary>
    /// <para>Defines the Lattice Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:lattice.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Arc" /> <c>&lt;emma:arc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Node" /> <c>&lt;emma:node></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:lattice")]
    public partial class Lattice : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Lattice class.
        /// </summary>
        public Lattice() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lattice class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Lattice(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lattice class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Lattice(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lattice class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Lattice(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>initial</para>
        /// <para>Represents the following attribute in the schema: initial</para>
        /// </summary>
        [SchemaAttr("initial")]
        public IntegerValue? Initial
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>final</para>
        /// <para>Represents the following attribute in the schema: final</para>
        /// </summary>
        [SchemaAttr("final")]
        public ListValue<DecimalValue>? Final
        {
            get => GetAttribute<ListValue<DecimalValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-uri")]
        public StringValue? TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-anchor-point")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>? TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:lattice");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Arc>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Node>();
            builder.AddElement<Lattice>()
                .AddAttribute("initial", a => a.Initial, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
                })
                .AddAttribute("final", a => a.Final, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("emma:time-ref-uri", a => a.TimeReference)
                .AddAttribute("emma:time-ref-anchor-point", a => a.TimeReferenceAnchorPoint);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Arc), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Node), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lattice>(deep);
    }

    /// <summary>
    /// <para>Defines the Literal Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:literal.</para>
    /// </summary>
    [SchemaAttr("emma:literal")]
    public partial class Literal : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Literal class.
        /// </summary>
        public Literal() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Literal class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Literal(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:literal");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Literal>(deep);
    }

    /// <summary>
    /// <para>Defines the Interpretation Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:interpretation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.DerivedFrom" /> <c>&lt;emma:derived-from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Lattice" /> <c>&lt;emma:lattice></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Literal" /> <c>&lt;emma:literal></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Ink.ContextNode" /> <c>&lt;msink:context></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:interpretation")]
    public partial class Interpretation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Interpretation class.
        /// </summary>
        public Interpretation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interpretation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interpretation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interpretation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Interpretation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Interpretation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Interpretation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:tokens")]
        public StringValue? Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:process")]
        public StringValue? Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:lang")]
        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal")]
        public StringValue? Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal-size")]
        public IntegerValue? SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:media-type")]
        public StringValue? MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:confidence")]
        public DecimalValue? Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:source")]
        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:start")]
        public UInt64Value? Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:end")]
        public UInt64Value? End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-uri")]
        public StringValue? TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-anchor-point")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>? TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:offset-to-start")]
        public IntegerValue? OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:duration")]
        public IntegerValue? Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:medium")]
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>? Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:mode")]
        public ListValue<StringValue>? Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:function")]
        public StringValue? Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:verbal")]
        public BooleanValue? Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:cost")]
        public DecimalValue? Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:grammar-ref")]
        public StringValue? GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-info-ref")]
        public StringValue? EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:model-ref")]
        public StringValue? ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:dialog-turn")]
        public StringValue? DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>no-input</para>
        /// <para>Represents the following attribute in the schema: emma:no-input</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:no-input")]
        public BooleanValue? NoInput
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uninterpreted</para>
        /// <para>Represents the following attribute in the schema: emma:uninterpreted</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:uninterpreted")]
        public BooleanValue? Uninterpreted
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:interpretation");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.DerivedFrom>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Lattice>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Literal>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Ink.ContextNode>();
            builder.AddElement<Interpretation>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("emma:tokens", a => a.Tokens)
                .AddAttribute("emma:process", a => a.Process)
                .AddAttribute("emma:lang", a => a.Language)
                .AddAttribute("emma:signal", a => a.Signal)
                .AddAttribute("emma:signal-size", a => a.SignalSize)
                .AddAttribute("emma:media-type", a => a.MediaType)
                .AddAttribute("emma:confidence", a => a.Confidence, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
                })
                .AddAttribute("emma:source", a => a.Source)
                .AddAttribute("emma:start", a => a.Start)
                .AddAttribute("emma:end", a => a.End)
                .AddAttribute("emma:time-ref-uri", a => a.TimeReference)
                .AddAttribute("emma:time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
                .AddAttribute("emma:offset-to-start", a => a.OffsetToStart)
                .AddAttribute("emma:duration", a => a.Duration)
                .AddAttribute("emma:medium", a => a.Medium)
                .AddAttribute("emma:mode", a => a.Mode)
                .AddAttribute("emma:function", a => a.Function)
                .AddAttribute("emma:verbal", a => a.Verbal)
                .AddAttribute("emma:cost", a => a.Cost, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
                })
                .AddAttribute("emma:grammar-ref", a => a.GrammarRef)
                .AddAttribute("emma:endpoint-info-ref", a => a.EndpointInfoRef)
                .AddAttribute("emma:model-ref", a => a.ModelRef)
                .AddAttribute("emma:dialog-turn", a => a.DialogTurn)
                .AddAttribute("emma:no-input", a => a.NoInput)
                .AddAttribute("emma:uninterpreted", a => a.Uninterpreted);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 0)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Lattice), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Literal), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Ink.ContextNode), 0, 1)
                }
            };
            builder.AddConstraint(new AttributeValuePatternConstraint("emma:id", @"[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeValueSetConstraint("emma:mode", true, new string[] { "ink" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Interpretation>(deep);
    }

    /// <summary>
    /// <para>Defines the OneOf Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:one-of.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.DerivedFrom" /> <c>&lt;emma:derived-from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Group" /> <c>&lt;emma:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Interpretation" /> <c>&lt;emma:interpretation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.OneOf" /> <c>&lt;emma:one-of></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Sequence" /> <c>&lt;emma:sequence></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:one-of")]
    public partial class OneOf : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OneOf class.
        /// </summary>
        public OneOf() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneOf(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneOf class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneOf(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneOf class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OneOf(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>disjunction-type</para>
        /// <para>Represents the following attribute in the schema: disjunction-type</para>
        /// </summary>
        [SchemaAttr("disjunction-type")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues>? DisjunctionType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.DisjunctionTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:tokens")]
        public StringValue? Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:process")]
        public StringValue? Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:lang")]
        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal")]
        public StringValue? Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal-size")]
        public IntegerValue? SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:media-type")]
        public StringValue? MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:confidence")]
        public DecimalValue? Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:source")]
        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:start")]
        public UInt64Value? Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:end")]
        public UInt64Value? End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-uri")]
        public StringValue? TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-anchor-point")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>? TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:offset-to-start")]
        public IntegerValue? OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:duration")]
        public IntegerValue? Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:medium")]
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>? Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:mode")]
        public ListValue<StringValue>? Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:function")]
        public StringValue? Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:verbal")]
        public BooleanValue? Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:cost")]
        public DecimalValue? Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:grammar-ref")]
        public StringValue? GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-info-ref")]
        public StringValue? EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:model-ref")]
        public StringValue? ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:dialog-turn")]
        public StringValue? DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:one-of");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.DerivedFrom>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Group>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Interpretation>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.OneOf>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Sequence>();
            builder.AddElement<OneOf>()
                .AddAttribute("disjunction-type", a => a.DisjunctionType)
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("emma:tokens", a => a.Tokens)
                .AddAttribute("emma:process", a => a.Process)
                .AddAttribute("emma:lang", a => a.Language)
                .AddAttribute("emma:signal", a => a.Signal)
                .AddAttribute("emma:signal-size", a => a.SignalSize)
                .AddAttribute("emma:media-type", a => a.MediaType)
                .AddAttribute("emma:confidence", a => a.Confidence, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
                })
                .AddAttribute("emma:source", a => a.Source)
                .AddAttribute("emma:start", a => a.Start)
                .AddAttribute("emma:end", a => a.End)
                .AddAttribute("emma:time-ref-uri", a => a.TimeReference)
                .AddAttribute("emma:time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
                .AddAttribute("emma:offset-to-start", a => a.OffsetToStart)
                .AddAttribute("emma:duration", a => a.Duration)
                .AddAttribute("emma:medium", a => a.Medium)
                .AddAttribute("emma:mode", a => a.Mode)
                .AddAttribute("emma:function", a => a.Function)
                .AddAttribute("emma:verbal", a => a.Verbal)
                .AddAttribute("emma:cost", a => a.Cost, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
                })
                .AddAttribute("emma:grammar-ref", a => a.GrammarRef)
                .AddAttribute("emma:endpoint-info-ref", a => a.EndpointInfoRef)
                .AddAttribute("emma:model-ref", a => a.ModelRef)
                .AddAttribute("emma:dialog-turn", a => a.DialogTurn);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 0)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
            builder.AddConstraint(new AttributeValueSetConstraint("emma:disjunction-type", true, new string[] { "recognition" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OneOf>(deep);
    }

    /// <summary>
    /// <para>Defines the Group Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.DerivedFrom" /> <c>&lt;emma:derived-from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Group" /> <c>&lt;emma:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.GroupInfo" /> <c>&lt;emma:group-info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Interpretation" /> <c>&lt;emma:interpretation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.OneOf" /> <c>&lt;emma:one-of></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Sequence" /> <c>&lt;emma:sequence></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:group")]
    public partial class Group : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Group(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:tokens")]
        public StringValue? Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:process")]
        public StringValue? Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:lang")]
        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal")]
        public StringValue? Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal-size")]
        public IntegerValue? SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:media-type")]
        public StringValue? MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:confidence")]
        public DecimalValue? Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:source")]
        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:start")]
        public UInt64Value? Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:end")]
        public UInt64Value? End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-uri")]
        public StringValue? TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-anchor-point")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>? TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:offset-to-start")]
        public IntegerValue? OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:duration")]
        public IntegerValue? Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:medium")]
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>? Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:mode")]
        public ListValue<StringValue>? Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:function")]
        public StringValue? Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:verbal")]
        public BooleanValue? Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:cost")]
        public DecimalValue? Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:grammar-ref")]
        public StringValue? GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-info-ref")]
        public StringValue? EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:model-ref")]
        public StringValue? ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:dialog-turn")]
        public StringValue? DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:group");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.DerivedFrom>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Group>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.GroupInfo>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Interpretation>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.OneOf>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Sequence>();
            builder.AddElement<Group>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("emma:tokens", a => a.Tokens)
                .AddAttribute("emma:process", a => a.Process)
                .AddAttribute("emma:lang", a => a.Language)
                .AddAttribute("emma:signal", a => a.Signal)
                .AddAttribute("emma:signal-size", a => a.SignalSize)
                .AddAttribute("emma:media-type", a => a.MediaType)
                .AddAttribute("emma:confidence", a => a.Confidence, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
                })
                .AddAttribute("emma:source", a => a.Source)
                .AddAttribute("emma:start", a => a.Start)
                .AddAttribute("emma:end", a => a.End)
                .AddAttribute("emma:time-ref-uri", a => a.TimeReference)
                .AddAttribute("emma:time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
                .AddAttribute("emma:offset-to-start", a => a.OffsetToStart)
                .AddAttribute("emma:duration", a => a.Duration)
                .AddAttribute("emma:medium", a => a.Medium)
                .AddAttribute("emma:mode", a => a.Mode)
                .AddAttribute("emma:function", a => a.Function)
                .AddAttribute("emma:verbal", a => a.Verbal)
                .AddAttribute("emma:cost", a => a.Cost, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
                })
                .AddAttribute("emma:grammar-ref", a => a.GrammarRef)
                .AddAttribute("emma:endpoint-info-ref", a => a.EndpointInfoRef)
                .AddAttribute("emma:model-ref", a => a.ModelRef)
                .AddAttribute("emma:dialog-turn", a => a.DialogTurn);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 0)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.GroupInfo), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the Sequence Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:sequence.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.DerivedFrom" /> <c>&lt;emma:derived-from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Group" /> <c>&lt;emma:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Interpretation" /> <c>&lt;emma:interpretation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.OneOf" /> <c>&lt;emma:one-of></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Sequence" /> <c>&lt;emma:sequence></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:sequence")]
    public partial class Sequence : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Sequence class.
        /// </summary>
        public Sequence() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sequence class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sequence(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sequence class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Sequence(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Sequence class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Sequence(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tokens</para>
        /// <para>Represents the following attribute in the schema: emma:tokens</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:tokens")]
        public StringValue? Tokens
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>process</para>
        /// <para>Represents the following attribute in the schema: emma:process</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:process")]
        public StringValue? Process
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:lang")]
        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal</para>
        /// <para>Represents the following attribute in the schema: emma:signal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal")]
        public StringValue? Signal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signal-size</para>
        /// <para>Represents the following attribute in the schema: emma:signal-size</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:signal-size")]
        public IntegerValue? SignalSize
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:media-type")]
        public StringValue? MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:confidence")]
        public DecimalValue? Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:source")]
        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:start")]
        public UInt64Value? Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:end")]
        public UInt64Value? End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-uri</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-uri</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-uri")]
        public StringValue? TimeReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time-ref-anchor-point</para>
        /// <para>Represents the following attribute in the schema: emma:time-ref-anchor-point</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:time-ref-anchor-point")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>? TimeReferenceAnchorPoint
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.AnchorPointValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:offset-to-start")]
        public IntegerValue? OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:duration")]
        public IntegerValue? Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:medium")]
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>? Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:mode")]
        public ListValue<StringValue>? Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function</para>
        /// <para>Represents the following attribute in the schema: emma:function</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:function")]
        public StringValue? Function
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>verbal</para>
        /// <para>Represents the following attribute in the schema: emma:verbal</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:verbal")]
        public BooleanValue? Verbal
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:cost")]
        public DecimalValue? Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grammar-ref</para>
        /// <para>Represents the following attribute in the schema: emma:grammar-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:grammar-ref")]
        public StringValue? GrammarRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-info-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-info-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-info-ref")]
        public StringValue? EndpointInfoRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model-ref</para>
        /// <para>Represents the following attribute in the schema: emma:model-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:model-ref")]
        public StringValue? ModelRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dialog-turn</para>
        /// <para>Represents the following attribute in the schema: emma:dialog-turn</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:dialog-turn")]
        public StringValue? DialogTurn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:sequence");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.DerivedFrom>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Group>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Interpretation>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.OneOf>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Sequence>();
            builder.AddElement<Sequence>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("emma:tokens", a => a.Tokens)
                .AddAttribute("emma:process", a => a.Process)
                .AddAttribute("emma:lang", a => a.Language)
                .AddAttribute("emma:signal", a => a.Signal)
                .AddAttribute("emma:signal-size", a => a.SignalSize)
                .AddAttribute("emma:media-type", a => a.MediaType)
                .AddAttribute("emma:confidence", a => a.Confidence, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
                })
                .AddAttribute("emma:source", a => a.Source)
                .AddAttribute("emma:start", a => a.Start)
                .AddAttribute("emma:end", a => a.End)
                .AddAttribute("emma:time-ref-uri", a => a.TimeReference)
                .AddAttribute("emma:time-ref-anchor-point", a => a.TimeReferenceAnchorPoint)
                .AddAttribute("emma:offset-to-start", a => a.OffsetToStart)
                .AddAttribute("emma:duration", a => a.Duration)
                .AddAttribute("emma:medium", a => a.Medium)
                .AddAttribute("emma:mode", a => a.Mode)
                .AddAttribute("emma:function", a => a.Function)
                .AddAttribute("emma:verbal", a => a.Verbal)
                .AddAttribute("emma:cost", a => a.Cost, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
                })
                .AddAttribute("emma:grammar-ref", a => a.GrammarRef)
                .AddAttribute("emma:endpoint-info-ref", a => a.EndpointInfoRef)
                .AddAttribute("emma:model-ref", a => a.ModelRef)
                .AddAttribute("emma:dialog-turn", a => a.DialogTurn);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 0)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.DerivedFrom), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Sequence>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupInfo Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:group-info.</para>
    /// </summary>
    [SchemaAttr("emma:group-info")]
    public partial class GroupInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupInfo class.
        /// </summary>
        public GroupInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:group-info");
            builder.AddElement<GroupInfo>()
                .AddAttribute("ref", a => a.Reference, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the Derivation Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:derivation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Group" /> <c>&lt;emma:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Interpretation" /> <c>&lt;emma:interpretation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.OneOf" /> <c>&lt;emma:one-of></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Sequence" /> <c>&lt;emma:sequence></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:derivation")]
    public partial class Derivation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Derivation class.
        /// </summary>
        public Derivation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Derivation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Derivation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Derivation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Derivation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Derivation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Derivation(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:derivation");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Group>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Interpretation>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.OneOf>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Sequence>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Derivation>(deep);
    }

    /// <summary>
    /// <para>Defines the Grammar Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:grammar.</para>
    /// </summary>
    [SchemaAttr("emma:grammar")]
    public partial class Grammar : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Grammar class.
        /// </summary>
        public Grammar() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:grammar");
            builder.AddElement<Grammar>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("ref", a => a.Reference, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Grammar>(deep);
    }

    /// <summary>
    /// <para>Defines the Model Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:model.</para>
    /// </summary>
    [SchemaAttr("emma:model")]
    public partial class Model : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model class.
        /// </summary>
        public Model() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:model");
            builder.AddElement<Model>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("ref", a => a.Reference, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model>(deep);
    }

    /// <summary>
    /// <para>Defines the EndPointInfo Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:endpoint-info.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.EndPoint" /> <c>&lt;emma:endpoint></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:endpoint-info")]
    public partial class EndPointInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EndPointInfo class.
        /// </summary>
        public EndPointInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPointInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPointInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPointInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPointInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPointInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EndPointInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:endpoint-info");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.EndPoint>();
            builder.AddElement<EndPointInfo>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.EndPoint), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndPointInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the EndPoint Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:endpoint.</para>
    /// </summary>
    [SchemaAttr("emma:endpoint")]
    public partial class EndPoint : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the EndPoint class.
        /// </summary>
        public EndPoint() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPoint(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public EndPoint(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EndPoint class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public EndPoint(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-role</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-role</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-role")]
        public EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues>? EndpointRole
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.EMMA.EndPointRoleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-address</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-address</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-address")]
        public StringValue? EndPointAddress
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>message-id</para>
        /// <para>Represents the following attribute in the schema: emma:message-id</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:message-id")]
        public StringValue? MessageId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>port-num</para>
        /// <para>Represents the following attribute in the schema: emma:port-num</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:port-num")]
        public IntegerValue? PortNumber
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>port-type</para>
        /// <para>Represents the following attribute in the schema: emma:port-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:port-type")]
        public StringValue? PortType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpoint-pair-ref</para>
        /// <para>Represents the following attribute in the schema: emma:endpoint-pair-ref</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:endpoint-pair-ref")]
        public StringValue? EndpointPairRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>service-name</para>
        /// <para>Represents the following attribute in the schema: emma:service-name</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:service-name")]
        public StringValue? ServiceName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>media-type</para>
        /// <para>Represents the following attribute in the schema: emma:media-type</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:media-type")]
        public StringValue? MediaType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:medium")]
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>? Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:mode")]
        public ListValue<StringValue>? Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:endpoint");
            builder.AddElement<EndPoint>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true) });
                })
                .AddAttribute("emma:endpoint-role", a => a.EndpointRole)
                .AddAttribute("emma:endpoint-address", a => a.EndPointAddress)
                .AddAttribute("emma:message-id", a => a.MessageId)
                .AddAttribute("emma:port-num", a => a.PortNumber)
                .AddAttribute("emma:port-type", a => a.PortType)
                .AddAttribute("emma:endpoint-pair-ref", a => a.EndpointPairRef)
                .AddAttribute("emma:service-name", a => a.ServiceName)
                .AddAttribute("emma:media-type", a => a.MediaType)
                .AddAttribute("emma:medium", a => a.Medium)
                .AddAttribute("emma:mode", a => a.Mode);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new AnyParticle(XsdAny.Other, 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EndPoint>(deep);
    }

    /// <summary>
    /// <para>Defines the Node Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:node.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:node")]
    public partial class Node : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Node class.
        /// </summary>
        public Node() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Node(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Node(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Node class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Node(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>node-number</para>
        /// <para>Represents the following attribute in the schema: node-number</para>
        /// </summary>
        [SchemaAttr("node-number")]
        public IntegerValue? NodeNumber
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:confidence")]
        public DecimalValue? Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:cost")]
        public DecimalValue? Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:node");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddElement<Node>()
                .AddAttribute("node-number", a => a.NodeNumber, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
                })
                .AddAttribute("emma:confidence", a => a.Confidence, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
                })
                .AddAttribute("emma:cost", a => a.Cost, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Node>(deep);
    }

    /// <summary>
    /// <para>Defines the Arc Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:arc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:arc")]
    public partial class Arc : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Arc class.
        /// </summary>
        public Arc() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Arc(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Arc(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Arc class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Arc(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>from</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        [SchemaAttr("from")]
        public IntegerValue? From
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>to</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        [SchemaAttr("to")]
        public IntegerValue? To
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start</para>
        /// <para>Represents the following attribute in the schema: emma:start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:start")]
        public UInt64Value? Start
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end</para>
        /// <para>Represents the following attribute in the schema: emma:end</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:end")]
        public UInt64Value? End
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>offset-to-start</para>
        /// <para>Represents the following attribute in the schema: emma:offset-to-start</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:offset-to-start")]
        public IntegerValue? OffsetToStart
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: emma:duration</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:duration")]
        public IntegerValue? Duration
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>confidence</para>
        /// <para>Represents the following attribute in the schema: emma:confidence</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:confidence")]
        public DecimalValue? Confidence
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cost</para>
        /// <para>Represents the following attribute in the schema: emma:cost</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:cost")]
        public DecimalValue? Cost
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lang</para>
        /// <para>Represents the following attribute in the schema: emma:lang</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:lang")]
        public StringValue? Language
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>medium</para>
        /// <para>Represents the following attribute in the schema: emma:medium</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:medium")]
        public ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>? Medium
        {
            get => GetAttribute<ListValue<EnumValue<DocumentFormat.OpenXml.EMMA.MediumValues>>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mode</para>
        /// <para>Represents the following attribute in the schema: emma:mode</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:mode")]
        public ListValue<StringValue>? Mode
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: emma:source</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma=http://www.w3.org/2003/04/emma
        /// </remark>
        [SchemaAttr("emma:source")]
        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:arc");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddElement<Arc>()
                .AddAttribute("from", a => a.From, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
                })
                .AddAttribute("to", a => a.To, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { IsNonNegative = (true) });
                })
                .AddAttribute("emma:start", a => a.Start)
                .AddAttribute("emma:end", a => a.End)
                .AddAttribute("emma:offset-to-start", a => a.OffsetToStart)
                .AddAttribute("emma:duration", a => a.Duration)
                .AddAttribute("emma:confidence", a => a.Confidence, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (1L) });
                })
                .AddAttribute("emma:cost", a => a.Cost, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10000000L) });
                })
                .AddAttribute("emma:lang", a => a.Language)
                .AddAttribute("emma:medium", a => a.Medium)
                .AddAttribute("emma:mode", a => a.Mode)
                .AddAttribute("emma:source", a => a.Source);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Arc>(deep);
    }

    /// <summary>
    /// <para>Defines the Emma Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is emma:emma.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Derivation" /> <c>&lt;emma:derivation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.EndPointInfo" /> <c>&lt;emma:endpoint-info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Grammar" /> <c>&lt;emma:grammar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Group" /> <c>&lt;emma:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Info" /> <c>&lt;emma:info></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Interpretation" /> <c>&lt;emma:interpretation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Model" /> <c>&lt;emma:model></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.OneOf" /> <c>&lt;emma:one-of></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Sequence" /> <c>&lt;emma:sequence></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("emma:emma")]
    public partial class Emma : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Emma class.
        /// </summary>
        public Emma() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Emma class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Emma(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Emma class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Emma(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Emma class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Emma(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>version</para>
        /// <para>Represents the following attribute in the schema: version</para>
        /// </summary>
        [SchemaAttr("version")]
        public StringValue? Version
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("emma:emma");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Derivation>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.EndPointInfo>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Grammar>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Group>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Info>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Interpretation>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Model>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.OneOf>();
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Sequence>();
            builder.AddElement<Emma>()
                .AddAttribute("version", a => a.Version, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 0)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Derivation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Grammar), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Model), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.EndPointInfo), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Info), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Interpretation), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.OneOf), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Group), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Sequence), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Emma>(deep);
    }

    /// <summary>
    /// Defines the EndPointRoleValues enumeration.
    /// </summary>
    public enum EndPointRoleValues
    {
        /// <summary>
        /// source.
        /// <para>When the item is serialized out as xml, its value is "source".</para>
        /// </summary>
        [EnumString("source")]
        Source,
        /// <summary>
        /// sink.
        /// <para>When the item is serialized out as xml, its value is "sink".</para>
        /// </summary>
        [EnumString("sink")]
        Sink,
        /// <summary>
        /// reply-to.
        /// <para>When the item is serialized out as xml, its value is "reply-to".</para>
        /// </summary>
        [EnumString("reply-to")]
        Replyto,
        /// <summary>
        /// router.
        /// <para>When the item is serialized out as xml, its value is "router".</para>
        /// </summary>
        [EnumString("router")]
        Router
    }

    /// <summary>
    /// Defines the MediumValues enumeration.
    /// </summary>
    public enum MediumValues
    {
        /// <summary>
        /// acoustic.
        /// <para>When the item is serialized out as xml, its value is "acoustic".</para>
        /// </summary>
        [EnumString("acoustic")]
        Acoustic,
        /// <summary>
        /// tactile.
        /// <para>When the item is serialized out as xml, its value is "tactile".</para>
        /// </summary>
        [EnumString("tactile")]
        Tactile,
        /// <summary>
        /// visual.
        /// <para>When the item is serialized out as xml, its value is "visual".</para>
        /// </summary>
        [EnumString("visual")]
        Visual
    }

    /// <summary>
    /// Defines the AnchorPointValues enumeration.
    /// </summary>
    public enum AnchorPointValues
    {
        /// <summary>
        /// start.
        /// <para>When the item is serialized out as xml, its value is "start".</para>
        /// </summary>
        [EnumString("start")]
        Start,
        /// <summary>
        /// end.
        /// <para>When the item is serialized out as xml, its value is "end".</para>
        /// </summary>
        [EnumString("end")]
        End
    }

    /// <summary>
    /// Defines the DisjunctionTypeValues enumeration.
    /// </summary>
    public enum DisjunctionTypeValues
    {
        /// <summary>
        /// recognition.
        /// <para>When the item is serialized out as xml, its value is "recognition".</para>
        /// </summary>
        [EnumString("recognition")]
        Recognition,
        /// <summary>
        /// understanding.
        /// <para>When the item is serialized out as xml, its value is "understanding".</para>
        /// </summary>
        [EnumString("understanding")]
        Understanding,
        /// <summary>
        /// multi-device.
        /// <para>When the item is serialized out as xml, its value is "multi-device".</para>
        /// </summary>
        [EnumString("multi-device")]
        Multidevice,
        /// <summary>
        /// multi-process.
        /// <para>When the item is serialized out as xml, its value is "multi-process".</para>
        /// </summary>
        [EnumString("multi-process")]
        Multiprocess
    }
}