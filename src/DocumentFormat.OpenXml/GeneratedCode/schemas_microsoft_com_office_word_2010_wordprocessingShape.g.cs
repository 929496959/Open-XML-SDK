﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Word.DrawingShape
{
    /// <summary>
    /// <para>Defines the WordprocessingShape Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:wsp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualConnectorProperties" /> <c>&lt;wps:cNvCnPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingProperties" /> <c>&lt;wps:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingShapeProperties" /> <c>&lt;wps:cNvSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList" /> <c>&lt;wps:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.ShapeProperties" /> <c>&lt;wps:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.ShapeStyle" /> <c>&lt;wps:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBodyProperties" /> <c>&lt;wps:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox" /> <c>&lt;wps:linkedTxbx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBoxInfo2" /> <c>&lt;wps:txbx></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:wsp")]
    public partial class WordprocessingShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WordprocessingShape class.
        /// </summary>
        public WordprocessingShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordprocessingShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WordprocessingShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordprocessingShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WordprocessingShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WordprocessingShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WordprocessingShape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>normalEastAsianFlow, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: normalEastAsianFlow</para>
        /// </summary>
        [SchemaAttr("normalEastAsianFlow")]
        public BooleanValue? NormalEastAsianFlow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:wsp");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualConnectorProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.ShapeStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBoxInfo2>();
            builder.AddElement<WordprocessingShape>()
                .AddAttribute("normalEastAsianFlow", a => a.NormalEastAsianFlow);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingProperties), 0, 1, version: FileFormatVersions.Office2010),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingShapeProperties), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualConnectorProperties), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.ShapeProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.ShapeStyle), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBoxInfo2), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.LinkedTextBox), 1, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.TextBodyProperties), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: wps:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wps = http://schemas.microsoft.com/office/word/2010/wordprocessingShape
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WordprocessingShape>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:extLst")]
    public partial class OfficeArtExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class.
        /// </summary>
        public OfficeArtExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeArtExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeArtExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeArtExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeArtExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:cNvPr")]
    public partial class NonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class.
        /// </summary>
        public NonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Application defined unique identifier.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Name compatible with Object Model (non-unique).</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Description of the drawing element.</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        [SchemaAttr("descr")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Flag determining to show or hide this element.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:cNvPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            builder.AddElement<NonVisualDrawingProperties>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("descr", a => a.Description)
                .AddAttribute("hidden", a => a.Hidden)
                .AddAttribute("title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnClick), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HyperlinkOnHover), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Hyperlink associated with clicking or selecting the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkClick.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnClick? HyperlinkOnClick
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink associated with hovering over the element..</para>
        /// <para>Represents the following element tag in the schema: a:hlinkHover.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HyperlinkOnHover? HyperlinkOnHover
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HyperlinkOnHover>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future extension.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:cNvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeLocks" /> <c>&lt;a:spLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:cNvSpPr")]
    public partial class NonVisualDrawingShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class.
        /// </summary>
        public NonVisualDrawingShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualDrawingShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualDrawingShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualDrawingShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Text Box</para>
        /// <para>Represents the following attribute in the schema: txBox</para>
        /// </summary>
        [SchemaAttr("txBox")]
        public BooleanValue? TextBox
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:cNvSpPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            builder.AddElement<NonVisualDrawingShapeProperties>()
                .AddAttribute("txBox", a => a.TextBox);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:spLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ShapeLocks? ShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualDrawingShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualConnectorProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:cNvCnPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.StartConnection" /> <c>&lt;a:stCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EndConnection" /> <c>&lt;a:endCxn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks" /> <c>&lt;a:cxnSpLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:cNvCnPr")]
    public partial class NonVisualConnectorProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorProperties class.
        /// </summary>
        public NonVisualConnectorProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectorProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:cNvCnPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.StartConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EndConnection>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.StartConnection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EndConnection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Connection Shape Locks.</para>
        /// <para>Represents the following element tag in the schema: a:cxnSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks? ConnectionShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Start.</para>
        /// <para>Represents the following element tag in the schema: a:stCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.StartConnection? StartConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.StartConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection End.</para>
        /// <para>Represents the following element tag in the schema: a:endCxn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EndConnection? EndConnection
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EndConnection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:spPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CustomGeometry" /> <c>&lt;a:custGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Outline" /> <c>&lt;a:ln></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetGeometry" /> <c>&lt;a:prstGeom></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Transform2D" /> <c>&lt;a:xfrm></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:spPr")]
    public partial class ShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeProperties class.
        /// </summary>
        public ShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Black and White Mode</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [SchemaAttr("bwMode")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? BlackWhiteMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:spPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CustomGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Outline>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetGeometry>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Transform2D>();
            builder.AddElement<ShapeProperties>()
                .AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Transform2D), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CustomGeometry), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetGeometry), 1, 1)
                    }
                },
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SolidFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GradientFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PatternFill), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupFill), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Outline), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Individual Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeStyle Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:style.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FontReference" /> <c>&lt;a:fontRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LineReference" /> <c>&lt;a:lnRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FillReference" /> <c>&lt;a:fillRef></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectReference" /> <c>&lt;a:effectRef></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:style")]
    public partial class ShapeStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShapeStyle class.
        /// </summary>
        public ShapeStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShapeStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShapeStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShapeStyle(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:style");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FontReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LineReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillReference>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LineReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectReference), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FontReference), 1, 1)
            };
        }

        /// <summary>
        /// <para>LineReference.</para>
        /// <para>Represents the following element tag in the schema: a:lnRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.LineReference? LineReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.LineReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FillReference.</para>
        /// <para>Represents the following element tag in the schema: a:fillRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FillReference? FillReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FillReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>EffectReference.</para>
        /// <para>Represents the following element tag in the schema: a:effectRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.EffectReference? EffectReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.EffectReference>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Font Reference.</para>
        /// <para>Represents the following element tag in the schema: a:fontRef.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.FontReference? FontReference
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.FontReference>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShapeStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBoxInfo2 Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:txbx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList" /> <c>&lt;wps:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Wordprocessing.TextBoxContent" /> <c>&lt;w:txbxContent></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:txbx")]
    public partial class TextBoxInfo2 : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBoxInfo2 class.
        /// </summary>
        public TextBoxInfo2() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBoxInfo2 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBoxInfo2(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBoxInfo2 class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBoxInfo2(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBoxInfo2 class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBoxInfo2(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt16Value? Id
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:txbx");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
            builder.AddElement<TextBoxInfo2>()
                .AddAttribute("id", a => a.Id);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Wordprocessing.TextBoxContent), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>TextBoxContent.</para>
        /// <para>Represents the following element tag in the schema: w:txbxContent.</para>
        /// </summary>
        /// <remark>
        /// xmlns:w = http://schemas.openxmlformats.org/wordprocessingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Wordprocessing.TextBoxContent? TextBoxContent
        {
            get => GetElement<DocumentFormat.OpenXml.Wordprocessing.TextBoxContent>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: wps:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wps = http://schemas.microsoft.com/office/word/2010/wordprocessingShape
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBoxInfo2>(deep);
    }

    /// <summary>
    /// <para>Defines the LinkedTextBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:linkedTxbx.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList" /> <c>&lt;wps:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:linkedTxbx")]
    public partial class LinkedTextBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LinkedTextBox class.
        /// </summary>
        public LinkedTextBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinkedTextBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LinkedTextBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinkedTextBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LinkedTextBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinkedTextBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LinkedTextBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt16Value? Id
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seq, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: seq</para>
        /// </summary>
        [SchemaAttr("seq")]
        public UInt16Value? Sequence
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:linkedTxbx");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
            builder.AddElement<LinkedTextBox>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("seq", a => a.Sequence, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: wps:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:wps = http://schemas.microsoft.com/office/word/2010/wordprocessingShape
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Word.DrawingShape.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinkedTextBox>(deep);
    }

    /// <summary>
    /// <para>Defines the TextBodyProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is wps:bodyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FlatText" /> <c>&lt;a:flatTx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetTextWrap" /> <c>&lt;a:prstTxWarp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Shape3DType" /> <c>&lt;a:sp3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoAutoFit" /> <c>&lt;a:noAutofit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NormalAutoFit" /> <c>&lt;a:normAutofit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeAutoFit" /> <c>&lt;a:spAutoFit></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("wps:bodyPr")]
    public partial class TextBodyProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class.
        /// </summary>
        public TextBodyProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotation</para>
        /// <para>Represents the following attribute in the schema: rot</para>
        /// </summary>
        [SchemaAttr("rot")]
        public Int32Value? Rotation
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Paragraph Spacing</para>
        /// <para>Represents the following attribute in the schema: spcFirstLastPara</para>
        /// </summary>
        [SchemaAttr("spcFirstLastPara")]
        public BooleanValue? UseParagraphSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Vertical Overflow</para>
        /// <para>Represents the following attribute in the schema: vertOverflow</para>
        /// </summary>
        [SchemaAttr("vertOverflow")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>? VerticalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Horizontal Overflow</para>
        /// <para>Represents the following attribute in the schema: horzOverflow</para>
        /// </summary>
        [SchemaAttr("horzOverflow")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>? HorizontalOverflow
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextHorizontalOverflowValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Text</para>
        /// <para>Represents the following attribute in the schema: vert</para>
        /// </summary>
        [SchemaAttr("vert")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>? Vertical
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextVerticalValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Wrapping Type</para>
        /// <para>Represents the following attribute in the schema: wrap</para>
        /// </summary>
        [SchemaAttr("wrap")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>? Wrap
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextWrappingValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Left Inset</para>
        /// <para>Represents the following attribute in the schema: lIns</para>
        /// </summary>
        [SchemaAttr("lIns")]
        public Int32Value? LeftInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top Inset</para>
        /// <para>Represents the following attribute in the schema: tIns</para>
        /// </summary>
        [SchemaAttr("tIns")]
        public Int32Value? TopInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Right Inset</para>
        /// <para>Represents the following attribute in the schema: rIns</para>
        /// </summary>
        [SchemaAttr("rIns")]
        public Int32Value? RightInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Bottom Inset</para>
        /// <para>Represents the following attribute in the schema: bIns</para>
        /// </summary>
        [SchemaAttr("bIns")]
        public Int32Value? BottomInset
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Number of Columns</para>
        /// <para>Represents the following attribute in the schema: numCol</para>
        /// </summary>
        [SchemaAttr("numCol")]
        public Int32Value? ColumnCount
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Space Between Columns</para>
        /// <para>Represents the following attribute in the schema: spcCol</para>
        /// </summary>
        [SchemaAttr("spcCol")]
        public Int32Value? ColumnSpacing
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Columns Right-To-Left</para>
        /// <para>Represents the following attribute in the schema: rtlCol</para>
        /// </summary>
        [SchemaAttr("rtlCol")]
        public BooleanValue? RightToLeftColumns
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>From WordArt</para>
        /// <para>Represents the following attribute in the schema: fromWordArt</para>
        /// </summary>
        [SchemaAttr("fromWordArt")]
        public BooleanValue? FromWordArt
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor</para>
        /// <para>Represents the following attribute in the schema: anchor</para>
        /// </summary>
        [SchemaAttr("anchor")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>? Anchor
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.TextAnchoringTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Anchor Center</para>
        /// <para>Represents the following attribute in the schema: anchorCtr</para>
        /// </summary>
        [SchemaAttr("anchorCtr")]
        public BooleanValue? AnchorCenter
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Force Anti-Alias</para>
        /// <para>Represents the following attribute in the schema: forceAA</para>
        /// </summary>
        [SchemaAttr("forceAA")]
        public BooleanValue? ForceAntiAlias
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Upright</para>
        /// <para>Represents the following attribute in the schema: upright</para>
        /// </summary>
        [SchemaAttr("upright")]
        public BooleanValue? UpRight
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Compatible Line Spacing</para>
        /// <para>Represents the following attribute in the schema: compatLnSpc</para>
        /// </summary>
        [SchemaAttr("compatLnSpc")]
        public BooleanValue? CompatibleLineSpacing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("wps:bodyPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FlatText>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NormalAutoFit>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeAutoFit>();
            builder.AddElement<TextBodyProperties>()
                .AddAttribute("rot", a => a.Rotation)
                .AddAttribute("spcFirstLastPara", a => a.UseParagraphSpacing)
                .AddAttribute("vertOverflow", a => a.VerticalOverflow, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("horzOverflow", a => a.HorizontalOverflow, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("vert", a => a.Vertical, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("wrap", a => a.Wrap, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("lIns", a => a.LeftInset)
                .AddAttribute("tIns", a => a.TopInset)
                .AddAttribute("rIns", a => a.RightInset)
                .AddAttribute("bIns", a => a.BottomInset)
                .AddAttribute("numCol", a => a.ColumnCount, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (16L) });
                })
                .AddAttribute("spcCol", a => a.ColumnSpacing, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L) });
                })
                .AddAttribute("rtlCol", a => a.RightToLeftColumns)
                .AddAttribute("fromWordArt", a => a.FromWordArt)
                .AddAttribute("anchor", a => a.Anchor, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("anchorCtr", a => a.AnchorCenter)
                .AddAttribute("forceAA", a => a.ForceAntiAlias)
                .AddAttribute("upright", a => a.UpRight)
                .AddAttribute("compatLnSpc", a => a.CompatibleLineSpacing);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetTextWrap), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NormalAutoFit), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ShapeAutoFit), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Shape3DType), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FlatText), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Preset Text Shape.</para>
        /// <para>Represents the following element tag in the schema: a:prstTxWarp.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetTextWrap? PresetTextWrap
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetTextWrap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyProperties>(deep);
    }
}