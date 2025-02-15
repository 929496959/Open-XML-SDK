﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.InkML
{
    /// <summary>
    /// <para>Defines the Ink Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:ink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Annotation" /> <c>&lt;inkml:annotation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.AnnotationXml" /> <c>&lt;inkml:annotationXML></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Context" /> <c>&lt;inkml:context></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Definitions" /> <c>&lt;inkml:definitions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Trace" /> <c>&lt;inkml:trace></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceGroup" /> <c>&lt;inkml:traceGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceView" /> <c>&lt;inkml:traceView></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:ink")]
    public partial class Ink : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Ink class.
        /// </summary>
        public Ink() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ink(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ink(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ink class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Ink(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>documentID</para>
        /// <para>Represents the following attribute in the schema: documentID</para>
        /// </summary>
        [SchemaAttr("documentID")]
        public StringValue? DocumentId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:ink");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Annotation>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.AnnotationXml>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Context>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Definitions>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Trace>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceGroup>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceView>();
            builder.AddElement<Ink>()
                .AddAttribute("documentID", a => a.DocumentId, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Definitions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Context), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Trace), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceGroup), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceView), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ink>(deep);
    }

    /// <summary>
    /// <para>Defines the Bind Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:bind.</para>
    /// </summary>
    [SchemaAttr("inkml:bind")]
    public partial class Bind : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Bind class.
        /// </summary>
        public Bind() : base()
        {
        }

        /// <summary>
        /// <para>source</para>
        /// <para>Represents the following attribute in the schema: source</para>
        /// </summary>
        [SchemaAttr("source")]
        public StringValue? Source
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        [SchemaAttr("target")]
        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>column</para>
        /// <para>Represents the following attribute in the schema: column</para>
        /// </summary>
        [SchemaAttr("column")]
        public StringValue? Column
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>variable</para>
        /// <para>Represents the following attribute in the schema: variable</para>
        /// </summary>
        [SchemaAttr("variable")]
        public StringValue? Variable
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:bind");
            builder.AddElement<Bind>()
                .AddAttribute("source", a => a.Source)
                .AddAttribute("target", a => a.Target)
                .AddAttribute("column", a => a.Column)
                .AddAttribute("variable", a => a.Variable);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Bind>(deep);
    }

    /// <summary>
    /// <para>Defines the Table Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:table.</para>
    /// </summary>
    [SchemaAttr("inkml:table")]
    public partial class Table : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Table class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Table(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>apply</para>
        /// <para>Represents the following attribute in the schema: apply</para>
        /// </summary>
        [SchemaAttr("apply")]
        public EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues>? Apply
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TableApplyValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>interpolation</para>
        /// <para>Represents the following attribute in the schema: interpolation</para>
        /// </summary>
        [SchemaAttr("interpolation")]
        public EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues>? Interpolation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TableInterpolationValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:table");
            builder.AddElement<Table>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("apply", a => a.Apply)
                .AddAttribute("interpolation", a => a.Interpolation);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Table>(deep);
    }

    /// <summary>
    /// <para>Defines the Matrix Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:matrix.</para>
    /// </summary>
    [SchemaAttr("inkml:matrix")]
    public partial class Matrix : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Matrix class.
        /// </summary>
        public Matrix() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Matrix class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Matrix(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:matrix");
            builder.AddElement<Matrix>()
                .AddAttribute("xml:id", a => a.Id);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Matrix>(deep);
    }

    /// <summary>
    /// <para>Defines the Mapping Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:mapping.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Bind" /> <c>&lt;inkml:bind></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Mapping" /> <c>&lt;inkml:mapping></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Matrix" /> <c>&lt;inkml:matrix></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Table" /> <c>&lt;inkml:table></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:mapping")]
    public partial class Mapping : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Mapping class.
        /// </summary>
        public Mapping() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mapping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mapping(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mapping class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Mapping(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Mapping class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Mapping(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.MappingTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mappingRef</para>
        /// <para>Represents the following attribute in the schema: mappingRef</para>
        /// </summary>
        [SchemaAttr("mappingRef")]
        public StringValue? MappingRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:mapping");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Bind>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Mapping>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Matrix>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Table>();
            builder.AddElement<Mapping>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("type", a => a.Type)
                .AddAttribute("mappingRef", a => a.MappingRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Bind), 0, 0),
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Table), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Matrix), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 0, 0)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mapping>(deep);
    }

    /// <summary>
    /// <para>Defines the Channel Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:channel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Mapping" /> <c>&lt;inkml:mapping></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:channel")]
    public partial class Channel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Channel class.
        /// </summary>
        public Channel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Channel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Channel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Channel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Channel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Channel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Channel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.ChannelDataTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>default</para>
        /// <para>Represents the following attribute in the schema: default</para>
        /// </summary>
        [SchemaAttr("default")]
        public StringValue? Default
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>min</para>
        /// <para>Represents the following attribute in the schema: min</para>
        /// </summary>
        [SchemaAttr("min")]
        public DecimalValue? Min
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>max</para>
        /// <para>Represents the following attribute in the schema: max</para>
        /// </summary>
        [SchemaAttr("max")]
        public DecimalValue? Max
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>orientation</para>
        /// <para>Represents the following attribute in the schema: orientation</para>
        /// </summary>
        [SchemaAttr("orientation")]
        public EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues>? Orientation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.ChannelValueOrientationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>respectTo</para>
        /// <para>Represents the following attribute in the schema: respectTo</para>
        /// </summary>
        [SchemaAttr("respectTo")]
        public StringValue? RespectTo
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        [SchemaAttr("units")]
        public StringValue? Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:channel");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Mapping>();
            builder.AddElement<Channel>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelNameValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("type", a => a.Type)
                .AddAttribute("default", a => a.Default, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DecimalValue>(NumberValidator.Instance);
                        union.AddValidator<BooleanValue>(NumberValidator.Instance);
                    });
                })
                .AddAttribute("min", a => a.Min)
                .AddAttribute("max", a => a.Max)
                .AddAttribute("orientation", a => a.Orientation)
                .AddAttribute("respectTo", a => a.RespectTo, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("units", a => a.Units, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 0, 0)
            };
            builder.AddConstraint(new AttributeValueSetConstraint("inkml:units", true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Channel>(deep);
    }

    /// <summary>
    /// <para>Defines the IntermittentChannels Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:intermittentChannels.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Channel" /> <c>&lt;inkml:channel></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:intermittentChannels")]
    public partial class IntermittentChannels : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class.
        /// </summary>
        public IntermittentChannels() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IntermittentChannels(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public IntermittentChannels(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the IntermittentChannels class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public IntermittentChannels(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:intermittentChannels");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Channel>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Channel), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntermittentChannels>(deep);
    }

    /// <summary>
    /// <para>Defines the ChannelProperty Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:channelProperty.</para>
    /// </summary>
    [SchemaAttr("inkml:channelProperty")]
    public partial class ChannelProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ChannelProperty class.
        /// </summary>
        public ChannelProperty() : base()
        {
        }

        /// <summary>
        /// <para>channel</para>
        /// <para>Represents the following attribute in the schema: channel</para>
        /// </summary>
        [SchemaAttr("channel")]
        public StringValue? Channel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public DecimalValue? Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        [SchemaAttr("units")]
        public StringValue? Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:channelProperty");
            builder.AddElement<ChannelProperty>()
                .AddAttribute("channel", a => a.Channel, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelNameValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardChannelPropertyNameValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("units", a => a.Units, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                });
            builder.AddConstraint(new AttributeValueSetConstraint("inkml:units", true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChannelProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the TraceFormat Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:traceFormat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Channel" /> <c>&lt;inkml:channel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.IntermittentChannels" /> <c>&lt;inkml:intermittentChannels></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:traceFormat")]
    public partial class TraceFormat : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TraceFormat class.
        /// </summary>
        public TraceFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceFormat(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceFormat class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceFormat(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceFormat class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TraceFormat(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:traceFormat");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Channel>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.IntermittentChannels>();
            builder.AddElement<TraceFormat>()
                .AddAttribute("xml:id", a => a.Id);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Channel), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.IntermittentChannels), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the SampleRate Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:sampleRate.</para>
    /// </summary>
    [SchemaAttr("inkml:sampleRate")]
    public partial class SampleRate : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SampleRate class.
        /// </summary>
        public SampleRate() : base()
        {
        }

        /// <summary>
        /// <para>uniform</para>
        /// <para>Represents the following attribute in the schema: uniform</para>
        /// </summary>
        [SchemaAttr("uniform")]
        public BooleanValue? Uniform
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public DecimalValue? Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:sampleRate");
            builder.AddElement<SampleRate>()
                .AddAttribute("uniform", a => a.Uniform)
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SampleRate>(deep);
    }

    /// <summary>
    /// <para>Defines the Latency Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:latency.</para>
    /// </summary>
    [SchemaAttr("inkml:latency")]
    public partial class Latency : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Latency class.
        /// </summary>
        public Latency() : base()
        {
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public DecimalValue? Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:latency");
            builder.AddElement<Latency>()
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Latency>(deep);
    }

    /// <summary>
    /// <para>Defines the ActiveArea Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:activeArea.</para>
    /// </summary>
    [SchemaAttr("inkml:activeArea")]
    public partial class ActiveArea : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ActiveArea class.
        /// </summary>
        public ActiveArea() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public StringValue? Size
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>height</para>
        /// <para>Represents the following attribute in the schema: height</para>
        /// </summary>
        [SchemaAttr("height")]
        public DecimalValue? Height
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>width</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        [SchemaAttr("width")]
        public DecimalValue? Width
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        [SchemaAttr("units")]
        public StringValue? Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:activeArea");
            builder.AddElement<ActiveArea>()
                .AddAttribute("size", a => a.Size)
                .AddAttribute("height", a => a.Height)
                .AddAttribute("width", a => a.Width)
                .AddAttribute("units", a => a.Units, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                });
            builder.AddConstraint(new AttributeValueSetConstraint("inkml:units", true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ActiveArea>(deep);
    }

    /// <summary>
    /// <para>Defines the SourceProperty Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:srcProperty.</para>
    /// </summary>
    [SchemaAttr("inkml:srcProperty")]
    public partial class SourceProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SourceProperty class.
        /// </summary>
        public SourceProperty() : base()
        {
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public DecimalValue? Value
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        [SchemaAttr("units")]
        public StringValue? Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:srcProperty");
            builder.AddElement<SourceProperty>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("units", a => a.Units, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                });
            builder.AddConstraint(new AttributeValueSetConstraint("inkml:units", true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SourceProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the ChannelProperties Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:channelProperties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.ChannelProperty" /> <c>&lt;inkml:channelProperty></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:channelProperties")]
    public partial class ChannelProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChannelProperties class.
        /// </summary>
        public ChannelProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChannelProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChannelProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChannelProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChannelProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChannelProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChannelProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:channelProperties");
            builder.AddChild<DocumentFormat.OpenXml.InkML.ChannelProperty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.ChannelProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChannelProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Annotation Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:annotation.</para>
    /// </summary>
    [SchemaAttr("inkml:annotation")]
    public partial class Annotation : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Annotation class.
        /// </summary>
        public Annotation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Annotation class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Annotation(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>encoding</para>
        /// <para>Represents the following attribute in the schema: encoding</para>
        /// </summary>
        [SchemaAttr("encoding")]
        public StringValue? Encoding
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:annotation");
            builder.AddElement<Annotation>()
                .AddAttribute("type", a => a.Type)
                .AddAttribute("encoding", a => a.Encoding);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Annotation>(deep);
    }

    /// <summary>
    /// <para>Defines the AnnotationXml Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:annotationXML.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.EMMA.Emma" /> <c>&lt;emma:emma></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:annotationXML")]
    public partial class AnnotationXml : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AnnotationXml class.
        /// </summary>
        public AnnotationXml() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnnotationXml class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnnotationXml(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnnotationXml class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AnnotationXml(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AnnotationXml class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AnnotationXml(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public StringValue? Type
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>encoding</para>
        /// <para>Represents the following attribute in the schema: encoding</para>
        /// </summary>
        [SchemaAttr("encoding")]
        public StringValue? Encoding
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>href</para>
        /// <para>Represents the following attribute in the schema: href</para>
        /// </summary>
        [SchemaAttr("href")]
        public StringValue? Href
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:annotationXML");
            builder.AddChild<DocumentFormat.OpenXml.EMMA.Emma>();
            builder.AddElement<AnnotationXml>()
                .AddAttribute("type", a => a.Type)
                .AddAttribute("encoding", a => a.Encoding)
                .AddAttribute("href", a => a.Href, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.EMMA.Emma), 0, 1)
            };
        }

        /// <summary>
        /// <para>Emma.</para>
        /// <para>Represents the following element tag in the schema: emma:emma.</para>
        /// </summary>
        /// <remark>
        /// xmlns:emma = http://www.w3.org/2003/04/emma
        /// </remark>
        public DocumentFormat.OpenXml.EMMA.Emma? Emma
        {
            get => GetElement<DocumentFormat.OpenXml.EMMA.Emma>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AnnotationXml>(deep);
    }

    /// <summary>
    /// <para>Defines the BrushProperty Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:brushProperty.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Annotation" /> <c>&lt;inkml:annotation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.AnnotationXml" /> <c>&lt;inkml:annotationXML></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:brushProperty")]
    public partial class BrushProperty : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BrushProperty class.
        /// </summary>
        public BrushProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BrushProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BrushProperty(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BrushProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BrushProperty(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BrushProperty class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BrushProperty(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public StringValue? Value
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>units</para>
        /// <para>Represents the following attribute in the schema: units</para>
        /// </summary>
        [SchemaAttr("units")]
        public StringValue? Units
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:brushProperty");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Annotation>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.AnnotationXml>();
            builder.AddElement<BrushProperty>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardBrushPropertyNameValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<DecimalValue>(NumberValidator.Instance);
                        union.AddValidator<BooleanValue>(NumberValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.PenTipShapeValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.RasterOperationValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                })
                .AddAttribute("units", a => a.Units, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerLengthUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerTimeUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerMassForceUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerAngleUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.InkML.StandardPerOtherUnitsValues>>(EnumValidator.Instance);
                        union.AddValidator(StringValidator.Instance);
                    });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 0)
            };
            builder.AddConstraint(new AttributeValueSetConstraint("inkml:units", true, new string[] { "dev", "in", "cm", "deg", "rad", "s", "lb", "g" }) { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrushProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the Canvas Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:canvas.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceFormat" /> <c>&lt;inkml:traceFormat></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:canvas")]
    public partial class Canvas : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Canvas class.
        /// </summary>
        public Canvas() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Canvas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Canvas(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Canvas class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Canvas(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Canvas class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Canvas(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>traceFormatRef</para>
        /// <para>Represents the following attribute in the schema: traceFormatRef</para>
        /// </summary>
        [SchemaAttr("traceFormatRef")]
        public StringValue? TraceFormatRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:canvas");
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceFormat>();
            builder.AddElement<Canvas>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("traceFormatRef", a => a.TraceFormatRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 0, 1)
            };
        }

        /// <summary>
        /// <para>TraceFormat.</para>
        /// <para>Represents the following element tag in the schema: inkml:traceFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.TraceFormat? TraceFormat
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.TraceFormat>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Canvas>(deep);
    }

    /// <summary>
    /// <para>Defines the CanvasTransform Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:canvasTransform.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Mapping" /> <c>&lt;inkml:mapping></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:canvasTransform")]
    public partial class CanvasTransform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CanvasTransform class.
        /// </summary>
        public CanvasTransform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CanvasTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CanvasTransform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CanvasTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CanvasTransform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CanvasTransform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CanvasTransform(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invertible</para>
        /// <para>Represents the following attribute in the schema: invertible</para>
        /// </summary>
        [SchemaAttr("invertible")]
        public BooleanValue? Invertible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:canvasTransform");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Mapping>();
            builder.AddElement<CanvasTransform>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("invertible", a => a.Invertible);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 1, 2)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CanvasTransform>(deep);
    }

    /// <summary>
    /// <para>Defines the InkSource Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:inkSource.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.ActiveArea" /> <c>&lt;inkml:activeArea></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.ChannelProperties" /> <c>&lt;inkml:channelProperties></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Latency" /> <c>&lt;inkml:latency></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.SampleRate" /> <c>&lt;inkml:sampleRate></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.SourceProperty" /> <c>&lt;inkml:srcProperty></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceFormat" /> <c>&lt;inkml:traceFormat></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:inkSource")]
    public partial class InkSource : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the InkSource class.
        /// </summary>
        public InkSource() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkSource(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkSource class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public InkSource(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the InkSource class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public InkSource(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>manufacturer</para>
        /// <para>Represents the following attribute in the schema: manufacturer</para>
        /// </summary>
        [SchemaAttr("manufacturer")]
        public StringValue? Manufacturer
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model</para>
        /// <para>Represents the following attribute in the schema: model</para>
        /// </summary>
        [SchemaAttr("model")]
        public StringValue? Model
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>serialNo</para>
        /// <para>Represents the following attribute in the schema: serialNo</para>
        /// </summary>
        [SchemaAttr("serialNo")]
        public StringValue? SerialNo
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>specificationRef</para>
        /// <para>Represents the following attribute in the schema: specificationRef</para>
        /// </summary>
        [SchemaAttr("specificationRef")]
        public StringValue? SpecificationRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:inkSource");
            builder.AddChild<DocumentFormat.OpenXml.InkML.ActiveArea>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.ChannelProperties>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Latency>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.SampleRate>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.SourceProperty>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceFormat>();
            builder.AddElement<InkSource>()
                .AddAttribute("xml:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("manufacturer", a => a.Manufacturer)
                .AddAttribute("model", a => a.Model)
                .AddAttribute("serialNo", a => a.SerialNo)
                .AddAttribute("specificationRef", a => a.SpecificationRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("description", a => a.Description);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.SampleRate), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Latency), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.ActiveArea), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.SourceProperty), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.ChannelProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>TraceFormat.</para>
        /// <para>Represents the following element tag in the schema: inkml:traceFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.TraceFormat? TraceFormat
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.TraceFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SampleRate.</para>
        /// <para>Represents the following element tag in the schema: inkml:sampleRate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.SampleRate? SampleRate
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.SampleRate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Latency.</para>
        /// <para>Represents the following element tag in the schema: inkml:latency.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.Latency? Latency
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.Latency>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ActiveArea.</para>
        /// <para>Represents the following element tag in the schema: inkml:activeArea.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.ActiveArea? ActiveArea
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.ActiveArea>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<InkSource>(deep);
    }

    /// <summary>
    /// <para>Defines the Brush Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:brush.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Annotation" /> <c>&lt;inkml:annotation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.AnnotationXml" /> <c>&lt;inkml:annotationXML></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.BrushProperty" /> <c>&lt;inkml:brushProperty></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:brush")]
    public partial class Brush : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Brush class.
        /// </summary>
        public Brush() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Brush class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Brush(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Brush class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Brush(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Brush class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Brush(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        [SchemaAttr("brushRef")]
        public StringValue? BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:brush");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Annotation>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.AnnotationXml>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.BrushProperty>();
            builder.AddElement<Brush>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("brushRef", a => a.BrushRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.BrushProperty), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Brush>(deep);
    }

    /// <summary>
    /// <para>Defines the Timestamp Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:timestamp.</para>
    /// </summary>
    [SchemaAttr("inkml:timestamp")]
    public partial class Timestamp : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Timestamp class.
        /// </summary>
        public Timestamp() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public DecimalValue? Time
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timestampRef</para>
        /// <para>Represents the following attribute in the schema: timestampRef</para>
        /// </summary>
        [SchemaAttr("timestampRef")]
        public StringValue? TimestampRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeString</para>
        /// <para>Represents the following attribute in the schema: timeString</para>
        /// </summary>
        [SchemaAttr("timeString")]
        public DateTimeValue? TimeString
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeOffset</para>
        /// <para>Represents the following attribute in the schema: timeOffset</para>
        /// </summary>
        [SchemaAttr("timeOffset")]
        public DecimalValue? TimeOffset
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:timestamp");
            builder.AddElement<Timestamp>()
                .AddAttribute("xml:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("time", a => a.Time)
                .AddAttribute("timestampRef", a => a.TimestampRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("timeString", a => a.TimeString)
                .AddAttribute("timeOffset", a => a.TimeOffset);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timestamp>(deep);
    }

    /// <summary>
    /// <para>Defines the Trace Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:trace.</para>
    /// </summary>
    [SchemaAttr("inkml:trace")]
    public partial class Trace : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Trace class.
        /// </summary>
        public Trace() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Trace class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Trace(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TraceTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>continuation</para>
        /// <para>Represents the following attribute in the schema: continuation</para>
        /// </summary>
        [SchemaAttr("continuation")]
        public EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues>? Continuation
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.InkML.TraceContinuationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>priorRef</para>
        /// <para>Represents the following attribute in the schema: priorRef</para>
        /// </summary>
        [SchemaAttr("priorRef")]
        public StringValue? PriorRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        [SchemaAttr("contextRef")]
        public StringValue? ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        [SchemaAttr("brushRef")]
        public StringValue? BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>duration</para>
        /// <para>Represents the following attribute in the schema: duration</para>
        /// </summary>
        [SchemaAttr("duration")]
        public DecimalValue? Duration
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timeOffset</para>
        /// <para>Represents the following attribute in the schema: timeOffset</para>
        /// </summary>
        [SchemaAttr("timeOffset")]
        public DecimalValue? TimeOffset
        {
            get => GetAttribute<DecimalValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:trace");
            builder.AddElement<Trace>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("type", a => a.Type)
                .AddAttribute("continuation", a => a.Continuation)
                .AddAttribute("priorRef", a => a.PriorRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("contextRef", a => a.ContextRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("brushRef", a => a.BrushRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("duration", a => a.Duration)
                .AddAttribute("timeOffset", a => a.TimeOffset);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Trace>(deep);
    }

    /// <summary>
    /// <para>Defines the TraceGroup Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:traceGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Annotation" /> <c>&lt;inkml:annotation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.AnnotationXml" /> <c>&lt;inkml:annotationXML></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Trace" /> <c>&lt;inkml:trace></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceGroup" /> <c>&lt;inkml:traceGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:traceGroup")]
    public partial class TraceGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TraceGroup class.
        /// </summary>
        public TraceGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TraceGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        [SchemaAttr("contextRef")]
        public StringValue? ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        [SchemaAttr("brushRef")]
        public StringValue? BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:traceGroup");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Annotation>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.AnnotationXml>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Trace>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceGroup>();
            builder.AddElement<TraceGroup>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("contextRef", a => a.ContextRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("brushRef", a => a.BrushRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Trace), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceGroup), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the TraceView Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:traceView.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Annotation" /> <c>&lt;inkml:annotation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.AnnotationXml" /> <c>&lt;inkml:annotationXML></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceView" /> <c>&lt;inkml:traceView></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:traceView")]
    public partial class TraceView : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TraceView class.
        /// </summary>
        public TraceView() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceView class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceView(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceView class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TraceView(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TraceView class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TraceView(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        [SchemaAttr("contextRef")]
        public StringValue? ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>traceDataRef</para>
        /// <para>Represents the following attribute in the schema: traceDataRef</para>
        /// </summary>
        [SchemaAttr("traceDataRef")]
        public StringValue? TraceDataRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>from</para>
        /// <para>Represents the following attribute in the schema: from</para>
        /// </summary>
        [SchemaAttr("from")]
        public StringValue? From
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>to</para>
        /// <para>Represents the following attribute in the schema: to</para>
        /// </summary>
        [SchemaAttr("to")]
        public StringValue? To
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:traceView");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Annotation>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.AnnotationXml>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceView>();
            builder.AddElement<TraceView>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("contextRef", a => a.ContextRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("traceDataRef", a => a.TraceDataRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("from", a => a.From)
                .AddAttribute("to", a => a.To);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Annotation), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.AnnotationXml), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceView), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TraceView>(deep);
    }

    /// <summary>
    /// <para>Defines the Context Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:context.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Brush" /> <c>&lt;inkml:brush></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Canvas" /> <c>&lt;inkml:canvas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.CanvasTransform" /> <c>&lt;inkml:canvasTransform></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.InkSource" /> <c>&lt;inkml:inkSource></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Timestamp" /> <c>&lt;inkml:timestamp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceFormat" /> <c>&lt;inkml:traceFormat></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:context")]
    public partial class Context : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Context class.
        /// </summary>
        public Context() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Context class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Context(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Context class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Context(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Context class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Context(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: xml:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:xml=http://www.w3.org/XML/1998/namespace
        /// </remark>
        [SchemaAttr("xml:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>contextRef</para>
        /// <para>Represents the following attribute in the schema: contextRef</para>
        /// </summary>
        [SchemaAttr("contextRef")]
        public StringValue? ContextRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>canvasRef</para>
        /// <para>Represents the following attribute in the schema: canvasRef</para>
        /// </summary>
        [SchemaAttr("canvasRef")]
        public StringValue? CanvasRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>canvasTransformRef</para>
        /// <para>Represents the following attribute in the schema: canvasTransformRef</para>
        /// </summary>
        [SchemaAttr("canvasTransformRef")]
        public StringValue? CanvasTransformRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>traceFormatRef</para>
        /// <para>Represents the following attribute in the schema: traceFormatRef</para>
        /// </summary>
        [SchemaAttr("traceFormatRef")]
        public StringValue? TraceFromatRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>inkSourceRef</para>
        /// <para>Represents the following attribute in the schema: inkSourceRef</para>
        /// </summary>
        [SchemaAttr("inkSourceRef")]
        public StringValue? InkSourceRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>brushRef</para>
        /// <para>Represents the following attribute in the schema: brushRef</para>
        /// </summary>
        [SchemaAttr("brushRef")]
        public StringValue? BrushRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>timestampRef</para>
        /// <para>Represents the following attribute in the schema: timestampRef</para>
        /// </summary>
        [SchemaAttr("timestampRef")]
        public StringValue? TimestampRef
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:context");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Brush>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Canvas>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.CanvasTransform>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.InkSource>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Timestamp>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceFormat>();
            builder.AddElement<Context>()
                .AddAttribute("xml:id", a => a.Id)
                .AddAttribute("contextRef", a => a.ContextRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("canvasRef", a => a.CanvasRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("canvasTransformRef", a => a.CanvasTransformRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("traceFormatRef", a => a.TraceFromatRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("inkSourceRef", a => a.InkSourceRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("brushRef", a => a.BrushRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                })
                .AddAttribute("timestampRef", a => a.TimestampRef, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsUri = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Canvas), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.CanvasTransform), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.InkSource), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Brush), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Timestamp), 0, 1)
            };
        }

        /// <summary>
        /// <para>Canvas.</para>
        /// <para>Represents the following element tag in the schema: inkml:canvas.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.Canvas? Canvas
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.Canvas>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CanvasTransform.</para>
        /// <para>Represents the following element tag in the schema: inkml:canvasTransform.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.CanvasTransform? CanvasTransform
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.CanvasTransform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TraceFormat.</para>
        /// <para>Represents the following element tag in the schema: inkml:traceFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.TraceFormat? TraceFormat
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.TraceFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>InkSource.</para>
        /// <para>Represents the following element tag in the schema: inkml:inkSource.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.InkSource? InkSource
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.InkSource>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Brush.</para>
        /// <para>Represents the following element tag in the schema: inkml:brush.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.Brush? Brush
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.Brush>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Timestamp.</para>
        /// <para>Represents the following element tag in the schema: inkml:timestamp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:inkml = http://www.w3.org/2003/InkML
        /// </remark>
        public DocumentFormat.OpenXml.InkML.Timestamp? Timestamp
        {
            get => GetElement<DocumentFormat.OpenXml.InkML.Timestamp>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Context>(deep);
    }

    /// <summary>
    /// <para>Defines the Definitions Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is inkml:definitions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Brush" /> <c>&lt;inkml:brush></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Canvas" /> <c>&lt;inkml:canvas></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.CanvasTransform" /> <c>&lt;inkml:canvasTransform></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Context" /> <c>&lt;inkml:context></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.InkSource" /> <c>&lt;inkml:inkSource></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Mapping" /> <c>&lt;inkml:mapping></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Timestamp" /> <c>&lt;inkml:timestamp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.Trace" /> <c>&lt;inkml:trace></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceFormat" /> <c>&lt;inkml:traceFormat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceGroup" /> <c>&lt;inkml:traceGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.InkML.TraceView" /> <c>&lt;inkml:traceView></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("inkml:definitions")]
    public partial class Definitions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Definitions class.
        /// </summary>
        public Definitions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Definitions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Definitions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Definitions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Definitions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Definitions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Definitions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("inkml:definitions");
            builder.AddChild<DocumentFormat.OpenXml.InkML.Brush>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Canvas>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.CanvasTransform>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Context>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.InkSource>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Mapping>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Timestamp>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.Trace>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceFormat>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceGroup>();
            builder.AddChild<DocumentFormat.OpenXml.InkML.TraceView>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Brush), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Canvas), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.CanvasTransform), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Context), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.InkSource), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Mapping), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Timestamp), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.Trace), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceGroup), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.InkML.TraceView), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Definitions>(deep);
    }

    /// <summary>
    /// Defines the ChannelDataTypeValues enumeration.
    /// </summary>
    public enum ChannelDataTypeValues
    {
        /// <summary>
        /// integer.
        /// <para>When the item is serialized out as xml, its value is "integer".</para>
        /// </summary>
        [EnumString("integer")]
        Integer,
        /// <summary>
        /// decimal.
        /// <para>When the item is serialized out as xml, its value is "decimal".</para>
        /// </summary>
        [EnumString("decimal")]
        Decimal,
        /// <summary>
        /// boolean.
        /// <para>When the item is serialized out as xml, its value is "boolean".</para>
        /// </summary>
        [EnumString("boolean")]
        Boolean
    }

    /// <summary>
    /// Defines the ChannelValueOrientationValues enumeration.
    /// </summary>
    public enum ChannelValueOrientationValues
    {
        /// <summary>
        /// +ve.
        /// <para>When the item is serialized out as xml, its value is "+ve".</para>
        /// </summary>
        [EnumString("+ve")]
        PlusVe,
        /// <summary>
        /// -ve.
        /// <para>When the item is serialized out as xml, its value is "-ve".</para>
        /// </summary>
        [EnumString("-ve")]
        MinusVe
    }

    /// <summary>
    /// Defines the StandardChannelPropertyNameValues enumeration.
    /// </summary>
    public enum StandardChannelPropertyNameValues
    {
        /// <summary>
        /// threshold.
        /// <para>When the item is serialized out as xml, its value is "threshold".</para>
        /// </summary>
        [EnumString("threshold")]
        Threshold,
        /// <summary>
        /// resolution.
        /// <para>When the item is serialized out as xml, its value is "resolution".</para>
        /// </summary>
        [EnumString("resolution")]
        Resolution,
        /// <summary>
        /// quantization.
        /// <para>When the item is serialized out as xml, its value is "quantization".</para>
        /// </summary>
        [EnumString("quantization")]
        Quantization,
        /// <summary>
        /// noise.
        /// <para>When the item is serialized out as xml, its value is "noise".</para>
        /// </summary>
        [EnumString("noise")]
        Noise,
        /// <summary>
        /// accuracy.
        /// <para>When the item is serialized out as xml, its value is "accuracy".</para>
        /// </summary>
        [EnumString("accuracy")]
        Accuracy,
        /// <summary>
        /// crossCoupling.
        /// <para>When the item is serialized out as xml, its value is "crossCoupling".</para>
        /// </summary>
        [EnumString("crossCoupling")]
        CrossCoupling,
        /// <summary>
        /// skew.
        /// <para>When the item is serialized out as xml, its value is "skew".</para>
        /// </summary>
        [EnumString("skew")]
        Skew,
        /// <summary>
        /// minBandwidth.
        /// <para>When the item is serialized out as xml, its value is "minBandwidth".</para>
        /// </summary>
        [EnumString("minBandwidth")]
        MinBandwidth,
        /// <summary>
        /// peakRate.
        /// <para>When the item is serialized out as xml, its value is "peakRate".</para>
        /// </summary>
        [EnumString("peakRate")]
        PeakRate,
        /// <summary>
        /// distortion.
        /// <para>When the item is serialized out as xml, its value is "distortion".</para>
        /// </summary>
        [EnumString("distortion")]
        Distortion
    }

    /// <summary>
    /// Defines the StandardBrushPropertyNameValues enumeration.
    /// </summary>
    public enum StandardBrushPropertyNameValues
    {
        /// <summary>
        /// width.
        /// <para>When the item is serialized out as xml, its value is "width".</para>
        /// </summary>
        [EnumString("width")]
        Width,
        /// <summary>
        /// height.
        /// <para>When the item is serialized out as xml, its value is "height".</para>
        /// </summary>
        [EnumString("height")]
        Height,
        /// <summary>
        /// color.
        /// <para>When the item is serialized out as xml, its value is "color".</para>
        /// </summary>
        [EnumString("color")]
        Color,
        /// <summary>
        /// transparency.
        /// <para>When the item is serialized out as xml, its value is "transparency".</para>
        /// </summary>
        [EnumString("transparency")]
        Transparency,
        /// <summary>
        /// tip.
        /// <para>When the item is serialized out as xml, its value is "tip".</para>
        /// </summary>
        [EnumString("tip")]
        Tip,
        /// <summary>
        /// rasterOp.
        /// <para>When the item is serialized out as xml, its value is "rasterOp".</para>
        /// </summary>
        [EnumString("rasterOp")]
        RasterOp,
        /// <summary>
        /// antiAliased.
        /// <para>When the item is serialized out as xml, its value is "antiAliased".</para>
        /// </summary>
        [EnumString("antiAliased")]
        AntiAliased,
        /// <summary>
        /// fitToCurve.
        /// <para>When the item is serialized out as xml, its value is "fitToCurve".</para>
        /// </summary>
        [EnumString("fitToCurve")]
        FitToCurve,
        /// <summary>
        /// ignorePressure.
        /// <para>When the item is serialized out as xml, its value is "ignorePressure".</para>
        /// </summary>
        [EnumString("ignorePressure")]
        IgnorePressure
    }

    /// <summary>
    /// Defines the StandardChannelNameValues enumeration.
    /// </summary>
    public enum StandardChannelNameValues
    {
        /// <summary>
        /// X.
        /// <para>When the item is serialized out as xml, its value is "X".</para>
        /// </summary>
        [EnumString("X")]
        XCoordinate,
        /// <summary>
        /// Y.
        /// <para>When the item is serialized out as xml, its value is "Y".</para>
        /// </summary>
        [EnumString("Y")]
        YCoordinate,
        /// <summary>
        /// Z.
        /// <para>When the item is serialized out as xml, its value is "Z".</para>
        /// </summary>
        [EnumString("Z")]
        ZCoordinate,
        /// <summary>
        /// F.
        /// <para>When the item is serialized out as xml, its value is "F".</para>
        /// </summary>
        [EnumString("F")]
        PenTipForce,
        /// <summary>
        /// TP.
        /// <para>When the item is serialized out as xml, its value is "TP".</para>
        /// </summary>
        [EnumString("TP")]
        TangentPressure,
        /// <summary>
        /// BP.
        /// <para>When the item is serialized out as xml, its value is "BP".</para>
        /// </summary>
        [EnumString("BP")]
        ButtonPressure,
        /// <summary>
        /// S.
        /// <para>When the item is serialized out as xml, its value is "S".</para>
        /// </summary>
        [EnumString("S")]
        TipSwitchState,
        /// <summary>
        /// B1.
        /// <para>When the item is serialized out as xml, its value is "B1".</para>
        /// </summary>
        [EnumString("B1")]
        SideButton1State,
        /// <summary>
        /// B2.
        /// <para>When the item is serialized out as xml, its value is "B2".</para>
        /// </summary>
        [EnumString("B2")]
        SideButton2State,
        /// <summary>
        /// B3.
        /// <para>When the item is serialized out as xml, its value is "B3".</para>
        /// </summary>
        [EnumString("B3")]
        SideButton3State,
        /// <summary>
        /// B4.
        /// <para>When the item is serialized out as xml, its value is "B4".</para>
        /// </summary>
        [EnumString("B4")]
        SideButton4State,
        /// <summary>
        /// E.
        /// <para>When the item is serialized out as xml, its value is "E".</para>
        /// </summary>
        [EnumString("E")]
        PenInverted,
        /// <summary>
        /// OTx.
        /// <para>When the item is serialized out as xml, its value is "OTx".</para>
        /// </summary>
        [EnumString("OTx")]
        TiltAlongXAxis,
        /// <summary>
        /// OTy.
        /// <para>When the item is serialized out as xml, its value is "OTy".</para>
        /// </summary>
        [EnumString("OTy")]
        TiltAlongYAxis,
        /// <summary>
        /// OA.
        /// <para>When the item is serialized out as xml, its value is "OA".</para>
        /// </summary>
        [EnumString("OA")]
        PenAzimuthAngle,
        /// <summary>
        /// OE.
        /// <para>When the item is serialized out as xml, its value is "OE".</para>
        /// </summary>
        [EnumString("OE")]
        PenElevationAngle,
        /// <summary>
        /// OR.
        /// <para>When the item is serialized out as xml, its value is "OR".</para>
        /// </summary>
        [EnumString("OR")]
        PexAxisRotation,
        /// <summary>
        /// RP.
        /// <para>When the item is serialized out as xml, its value is "RP".</para>
        /// </summary>
        [EnumString("RP")]
        PitchRotation,
        /// <summary>
        /// RR.
        /// <para>When the item is serialized out as xml, its value is "RR".</para>
        /// </summary>
        [EnumString("RR")]
        RollRotation,
        /// <summary>
        /// RY.
        /// <para>When the item is serialized out as xml, its value is "RY".</para>
        /// </summary>
        [EnumString("RY")]
        YawRotation,
        /// <summary>
        /// C.
        /// <para>When the item is serialized out as xml, its value is "C".</para>
        /// </summary>
        [EnumString("C")]
        ColorValue,
        /// <summary>
        /// CR.
        /// <para>When the item is serialized out as xml, its value is "CR".</para>
        /// </summary>
        [EnumString("CR")]
        RedColorValue,
        /// <summary>
        /// CG.
        /// <para>When the item is serialized out as xml, its value is "CG".</para>
        /// </summary>
        [EnumString("CG")]
        GreenColorValue,
        /// <summary>
        /// CB.
        /// <para>When the item is serialized out as xml, its value is "CB".</para>
        /// </summary>
        [EnumString("CB")]
        BlueColorValue,
        /// <summary>
        /// CC.
        /// <para>When the item is serialized out as xml, its value is "CC".</para>
        /// </summary>
        [EnumString("CC")]
        CyanColorValue,
        /// <summary>
        /// CM.
        /// <para>When the item is serialized out as xml, its value is "CM".</para>
        /// </summary>
        [EnumString("CM")]
        MegentaColorValue,
        /// <summary>
        /// CY.
        /// <para>When the item is serialized out as xml, its value is "CY".</para>
        /// </summary>
        [EnumString("CY")]
        YellowColorValue,
        /// <summary>
        /// CK.
        /// <para>When the item is serialized out as xml, its value is "CK".</para>
        /// </summary>
        [EnumString("CK")]
        BlackColorValue,
        /// <summary>
        /// W.
        /// <para>When the item is serialized out as xml, its value is "W".</para>
        /// </summary>
        [EnumString("W")]
        StrokesWidth,
        /// <summary>
        /// T.
        /// <para>When the item is serialized out as xml, its value is "T".</para>
        /// </summary>
        [EnumString("T")]
        Time,
        /// <summary>
        /// SN.
        /// <para>When the item is serialized out as xml, its value is "SN".</para>
        /// </summary>
        [EnumString("SN")]
        SerialNumber,
        /// <summary>
        /// TW.
        /// <para>When the item is serialized out as xml, its value is "TW".</para>
        /// </summary>
        [EnumString("TW")]
        TouchWidth,
        /// <summary>
        /// TH.
        /// <para>When the item is serialized out as xml, its value is "TH".</para>
        /// </summary>
        [EnumString("TH")]
        TouchHeight,
        /// <summary>
        /// TC.
        /// <para>When the item is serialized out as xml, its value is "TC".</para>
        /// </summary>
        [EnumString("TC")]
        FingerTouch
    }

    /// <summary>
    /// Defines the StandardLengthUnitsValues enumeration.
    /// </summary>
    public enum StandardLengthUnitsValues
    {
        /// <summary>
        /// m.
        /// <para>When the item is serialized out as xml, its value is "m".</para>
        /// </summary>
        [EnumString("m")]
        Meter,
        /// <summary>
        /// cm.
        /// <para>When the item is serialized out as xml, its value is "cm".</para>
        /// </summary>
        [EnumString("cm")]
        Centimeter,
        /// <summary>
        /// mm.
        /// <para>When the item is serialized out as xml, its value is "mm".</para>
        /// </summary>
        [EnumString("mm")]
        Millimeter,
        /// <summary>
        /// in.
        /// <para>When the item is serialized out as xml, its value is "in".</para>
        /// </summary>
        [EnumString("in")]
        Inche,
        /// <summary>
        /// pt.
        /// <para>When the item is serialized out as xml, its value is "pt".</para>
        /// </summary>
        [EnumString("pt")]
        Point,
        /// <summary>
        /// pc.
        /// <para>When the item is serialized out as xml, its value is "pc".</para>
        /// </summary>
        [EnumString("pc")]
        Pica,
        /// <summary>
        /// em.
        /// <para>When the item is serialized out as xml, its value is "em".</para>
        /// </summary>
        [EnumString("em")]
        Em,
        /// <summary>
        /// ex.
        /// <para>When the item is serialized out as xml, its value is "ex".</para>
        /// </summary>
        [EnumString("ex")]
        Ex
    }

    /// <summary>
    /// Defines the StandardPerLengthUnitsValues enumeration.
    /// </summary>
    public enum StandardPerLengthUnitsValues
    {
        /// <summary>
        /// 1/m.
        /// <para>When the item is serialized out as xml, its value is "1/m".</para>
        /// </summary>
        [EnumString("1/m")]
        PerMeter,
        /// <summary>
        /// 1/cm.
        /// <para>When the item is serialized out as xml, its value is "1/cm".</para>
        /// </summary>
        [EnumString("1/cm")]
        PerCentimeter,
        /// <summary>
        /// 1/mm.
        /// <para>When the item is serialized out as xml, its value is "1/mm".</para>
        /// </summary>
        [EnumString("1/mm")]
        PerMillimeter,
        /// <summary>
        /// 1/in.
        /// <para>When the item is serialized out as xml, its value is "1/in".</para>
        /// </summary>
        [EnumString("1/in")]
        PerInche,
        /// <summary>
        /// 1/pt.
        /// <para>When the item is serialized out as xml, its value is "1/pt".</para>
        /// </summary>
        [EnumString("1/pt")]
        PerPoint,
        /// <summary>
        /// 1/pc.
        /// <para>When the item is serialized out as xml, its value is "1/pc".</para>
        /// </summary>
        [EnumString("1/pc")]
        PerPica,
        /// <summary>
        /// 1/em.
        /// <para>When the item is serialized out as xml, its value is "1/em".</para>
        /// </summary>
        [EnumString("1/em")]
        PerEm,
        /// <summary>
        /// 1/ex.
        /// <para>When the item is serialized out as xml, its value is "1/ex".</para>
        /// </summary>
        [EnumString("1/ex")]
        PerEx
    }

    /// <summary>
    /// Defines the StandardTimeUnitsValues enumeration.
    /// </summary>
    public enum StandardTimeUnitsValues
    {
        /// <summary>
        /// s.
        /// <para>When the item is serialized out as xml, its value is "s".</para>
        /// </summary>
        [EnumString("s")]
        Second,
        /// <summary>
        /// ms.
        /// <para>When the item is serialized out as xml, its value is "ms".</para>
        /// </summary>
        [EnumString("ms")]
        Millisecond
    }

    /// <summary>
    /// Defines the StandardPerTimeUnitsValues enumeration.
    /// </summary>
    public enum StandardPerTimeUnitsValues
    {
        /// <summary>
        /// 1/s.
        /// <para>When the item is serialized out as xml, its value is "1/s".</para>
        /// </summary>
        [EnumString("1/s")]
        PerSecond,
        /// <summary>
        /// 1/ms.
        /// <para>When the item is serialized out as xml, its value is "1/ms".</para>
        /// </summary>
        [EnumString("1/ms")]
        PerMillisecond
    }

    /// <summary>
    /// Defines the StandardMassForceUnitsValues enumeration.
    /// </summary>
    public enum StandardMassForceUnitsValues
    {
        /// <summary>
        /// Kg.
        /// <para>When the item is serialized out as xml, its value is "Kg".</para>
        /// </summary>
        [EnumString("Kg")]
        Kilogram,
        /// <summary>
        /// g.
        /// <para>When the item is serialized out as xml, its value is "g".</para>
        /// </summary>
        [EnumString("g")]
        Gram,
        /// <summary>
        /// mg.
        /// <para>When the item is serialized out as xml, its value is "mg".</para>
        /// </summary>
        [EnumString("mg")]
        Milligram,
        /// <summary>
        /// N.
        /// <para>When the item is serialized out as xml, its value is "N".</para>
        /// </summary>
        [EnumString("N")]
        Newton,
        /// <summary>
        /// lb.
        /// <para>When the item is serialized out as xml, its value is "lb".</para>
        /// </summary>
        [EnumString("lb")]
        Pond
    }

    /// <summary>
    /// Defines the StandardPerMassForceUnitsValues enumeration.
    /// </summary>
    public enum StandardPerMassForceUnitsValues
    {
        /// <summary>
        /// 1/Kg.
        /// <para>When the item is serialized out as xml, its value is "1/Kg".</para>
        /// </summary>
        [EnumString("1/Kg")]
        PerKilogram,
        /// <summary>
        /// 1/g.
        /// <para>When the item is serialized out as xml, its value is "1/g".</para>
        /// </summary>
        [EnumString("1/g")]
        PerGram,
        /// <summary>
        /// 1/mg.
        /// <para>When the item is serialized out as xml, its value is "1/mg".</para>
        /// </summary>
        [EnumString("1/mg")]
        PerMilligram,
        /// <summary>
        /// 1/N.
        /// <para>When the item is serialized out as xml, its value is "1/N".</para>
        /// </summary>
        [EnumString("1/N")]
        PerNewton,
        /// <summary>
        /// 1/lb.
        /// <para>When the item is serialized out as xml, its value is "1/lb".</para>
        /// </summary>
        [EnumString("1/lb")]
        PerPond
    }

    /// <summary>
    /// Defines the StandardAngleUnitsValues enumeration.
    /// </summary>
    public enum StandardAngleUnitsValues
    {
        /// <summary>
        /// deg.
        /// <para>When the item is serialized out as xml, its value is "deg".</para>
        /// </summary>
        [EnumString("deg")]
        Degree,
        /// <summary>
        /// rad.
        /// <para>When the item is serialized out as xml, its value is "rad".</para>
        /// </summary>
        [EnumString("rad")]
        Radian
    }

    /// <summary>
    /// Defines the StandardPerAngleUnitsValues enumeration.
    /// </summary>
    public enum StandardPerAngleUnitsValues
    {
        /// <summary>
        /// 1/deg.
        /// <para>When the item is serialized out as xml, its value is "1/deg".</para>
        /// </summary>
        [EnumString("1/deg")]
        PerDegree,
        /// <summary>
        /// 1/rad.
        /// <para>When the item is serialized out as xml, its value is "1/rad".</para>
        /// </summary>
        [EnumString("1/rad")]
        PerRadian
    }

    /// <summary>
    /// Defines the StandardOtherUnitsValues enumeration.
    /// </summary>
    public enum StandardOtherUnitsValues
    {
        /// <summary>
        /// %.
        /// <para>When the item is serialized out as xml, its value is "%".</para>
        /// </summary>
        [EnumString("%")]
        Percentage,
        /// <summary>
        /// dev.
        /// <para>When the item is serialized out as xml, its value is "dev".</para>
        /// </summary>
        [EnumString("dev")]
        DeviceResolution,
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None
    }

    /// <summary>
    /// Defines the StandardPerOtherUnitsValues enumeration.
    /// </summary>
    public enum StandardPerOtherUnitsValues
    {
        /// <summary>
        /// 1/%.
        /// <para>When the item is serialized out as xml, its value is "1/%".</para>
        /// </summary>
        [EnumString("1/%")]
        PerPercentage,
        /// <summary>
        /// 1/dev.
        /// <para>When the item is serialized out as xml, its value is "1/dev".</para>
        /// </summary>
        [EnumString("1/dev")]
        PerDeviceResolution
    }

    /// <summary>
    /// Defines the TraceTypeValues enumeration.
    /// </summary>
    public enum TraceTypeValues
    {
        /// <summary>
        /// penDown.
        /// <para>When the item is serialized out as xml, its value is "penDown".</para>
        /// </summary>
        [EnumString("penDown")]
        PenDown,
        /// <summary>
        /// penUp.
        /// <para>When the item is serialized out as xml, its value is "penUp".</para>
        /// </summary>
        [EnumString("penUp")]
        PenUp,
        /// <summary>
        /// indeterminate.
        /// <para>When the item is serialized out as xml, its value is "indeterminate".</para>
        /// </summary>
        [EnumString("indeterminate")]
        Indeterminate
    }

    /// <summary>
    /// Defines the TraceContinuationValues enumeration.
    /// </summary>
    public enum TraceContinuationValues
    {
        /// <summary>
        /// begin.
        /// <para>When the item is serialized out as xml, its value is "begin".</para>
        /// </summary>
        [EnumString("begin")]
        Begin,
        /// <summary>
        /// end.
        /// <para>When the item is serialized out as xml, its value is "end".</para>
        /// </summary>
        [EnumString("end")]
        End,
        /// <summary>
        /// middle.
        /// <para>When the item is serialized out as xml, its value is "middle".</para>
        /// </summary>
        [EnumString("middle")]
        Middle
    }

    /// <summary>
    /// Defines the RasterOperationValues enumeration.
    /// </summary>
    public enum RasterOperationValues
    {
        /// <summary>
        /// black.
        /// <para>When the item is serialized out as xml, its value is "black".</para>
        /// </summary>
        [EnumString("black")]
        Black,
        /// <summary>
        /// notMergePen.
        /// <para>When the item is serialized out as xml, its value is "notMergePen".</para>
        /// </summary>
        [EnumString("notMergePen")]
        NotMergePen,
        /// <summary>
        /// maskNotPen.
        /// <para>When the item is serialized out as xml, its value is "maskNotPen".</para>
        /// </summary>
        [EnumString("maskNotPen")]
        MaskNotPen,
        /// <summary>
        /// notCopyPen.
        /// <para>When the item is serialized out as xml, its value is "notCopyPen".</para>
        /// </summary>
        [EnumString("notCopyPen")]
        NotCopyPen,
        /// <summary>
        /// maskPenNot.
        /// <para>When the item is serialized out as xml, its value is "maskPenNot".</para>
        /// </summary>
        [EnumString("maskPenNot")]
        MaskPenNot,
        /// <summary>
        /// not.
        /// <para>When the item is serialized out as xml, its value is "not".</para>
        /// </summary>
        [EnumString("not")]
        Not,
        /// <summary>
        /// xOrPen.
        /// <para>When the item is serialized out as xml, its value is "xOrPen".</para>
        /// </summary>
        [EnumString("xOrPen")]
        XOrPen,
        /// <summary>
        /// notMaskPen.
        /// <para>When the item is serialized out as xml, its value is "notMaskPen".</para>
        /// </summary>
        [EnumString("notMaskPen")]
        NotMaskPen,
        /// <summary>
        /// maskPen.
        /// <para>When the item is serialized out as xml, its value is "maskPen".</para>
        /// </summary>
        [EnumString("maskPen")]
        MaskPen,
        /// <summary>
        /// notXOrPen.
        /// <para>When the item is serialized out as xml, its value is "notXOrPen".</para>
        /// </summary>
        [EnumString("notXOrPen")]
        NotXOrPen,
        /// <summary>
        /// noOperation.
        /// <para>When the item is serialized out as xml, its value is "noOperation".</para>
        /// </summary>
        [EnumString("noOperation")]
        NoOperation,
        /// <summary>
        /// mergeNotPen.
        /// <para>When the item is serialized out as xml, its value is "mergeNotPen".</para>
        /// </summary>
        [EnumString("mergeNotPen")]
        MergeNotPen,
        /// <summary>
        /// copyPen.
        /// <para>When the item is serialized out as xml, its value is "copyPen".</para>
        /// </summary>
        [EnumString("copyPen")]
        CopyPen,
        /// <summary>
        /// mergePenNot.
        /// <para>When the item is serialized out as xml, its value is "mergePenNot".</para>
        /// </summary>
        [EnumString("mergePenNot")]
        MergePenNot,
        /// <summary>
        /// mergePen.
        /// <para>When the item is serialized out as xml, its value is "mergePen".</para>
        /// </summary>
        [EnumString("mergePen")]
        MergePen,
        /// <summary>
        /// white.
        /// <para>When the item is serialized out as xml, its value is "white".</para>
        /// </summary>
        [EnumString("white")]
        White
    }

    /// <summary>
    /// Defines the PenTipShapeValues enumeration.
    /// </summary>
    public enum PenTipShapeValues
    {
        /// <summary>
        /// ellipse.
        /// <para>When the item is serialized out as xml, its value is "ellipse".</para>
        /// </summary>
        [EnumString("ellipse")]
        Ellipse,
        /// <summary>
        /// rectangle.
        /// <para>When the item is serialized out as xml, its value is "rectangle".</para>
        /// </summary>
        [EnumString("rectangle")]
        Rectangle,
        /// <summary>
        /// drop.
        /// <para>When the item is serialized out as xml, its value is "drop".</para>
        /// </summary>
        [EnumString("drop")]
        Drop
    }

    /// <summary>
    /// Defines the MappingTypeValues enumeration.
    /// </summary>
    public enum MappingTypeValues
    {
        /// <summary>
        /// identity.
        /// <para>When the item is serialized out as xml, its value is "identity".</para>
        /// </summary>
        [EnumString("identity")]
        Identity,
        /// <summary>
        /// lookup.
        /// <para>When the item is serialized out as xml, its value is "lookup".</para>
        /// </summary>
        [EnumString("lookup")]
        Lookup,
        /// <summary>
        /// affine.
        /// <para>When the item is serialized out as xml, its value is "affine".</para>
        /// </summary>
        [EnumString("affine")]
        Affine,
        /// <summary>
        /// mathml.
        /// <para>When the item is serialized out as xml, its value is "mathml".</para>
        /// </summary>
        [EnumString("mathml")]
        MathML,
        /// <summary>
        /// product.
        /// <para>When the item is serialized out as xml, its value is "product".</para>
        /// </summary>
        [EnumString("product")]
        Product,
        /// <summary>
        /// unknown.
        /// <para>When the item is serialized out as xml, its value is "unknown".</para>
        /// </summary>
        [EnumString("unknown")]
        Unknown
    }

    /// <summary>
    /// Defines the TableApplyValues enumeration.
    /// </summary>
    public enum TableApplyValues
    {
        /// <summary>
        /// absolute.
        /// <para>When the item is serialized out as xml, its value is "absolute".</para>
        /// </summary>
        [EnumString("absolute")]
        Absolute,
        /// <summary>
        /// relative.
        /// <para>When the item is serialized out as xml, its value is "relative".</para>
        /// </summary>
        [EnumString("relative")]
        Relative
    }

    /// <summary>
    /// Defines the TableInterpolationValues enumeration.
    /// </summary>
    public enum TableInterpolationValues
    {
        /// <summary>
        /// floor.
        /// <para>When the item is serialized out as xml, its value is "floor".</para>
        /// </summary>
        [EnumString("floor")]
        Floor,
        /// <summary>
        /// middle.
        /// <para>When the item is serialized out as xml, its value is "middle".</para>
        /// </summary>
        [EnumString("middle")]
        Middle,
        /// <summary>
        /// ceiling.
        /// <para>When the item is serialized out as xml, its value is "ceiling".</para>
        /// </summary>
        [EnumString("ceiling")]
        Ceiling,
        /// <summary>
        /// linear.
        /// <para>When the item is serialized out as xml, its value is "linear".</para>
        /// </summary>
        [EnumString("linear")]
        Linear,
        /// <summary>
        /// cubic.
        /// <para>When the item is serialized out as xml, its value is "cubic".</para>
        /// </summary>
        [EnumString("cubic")]
        Cubic
    }
}