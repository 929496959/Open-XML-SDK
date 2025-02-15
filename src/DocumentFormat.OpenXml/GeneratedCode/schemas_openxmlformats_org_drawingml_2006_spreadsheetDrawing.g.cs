﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Drawing.Spreadsheet
{
    /// <summary>
    /// <para>Two Cell Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:twoCellAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData" /> <c>&lt;xdr:clientData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape" /> <c>&lt;xdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame" /> <c>&lt;xdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape" /> <c>&lt;xdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker" /> <c>&lt;xdr:from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ToMarker" /> <c>&lt;xdr:to></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture" /> <c>&lt;xdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape" /> <c>&lt;xdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart" /> <c>&lt;xdr:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:twoCellAnchor")]
    public partial class TwoCellAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class.
        /// </summary>
        public TwoCellAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TwoCellAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TwoCellAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TwoCellAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TwoCellAnchor(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Positioning and Resizing Behaviors</para>
        /// <para>Represents the following attribute in the schema: editAs</para>
        /// </summary>
        [SchemaAttr("editAs")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues>? EditAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.Spreadsheet.EditAsValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:twoCellAnchor");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ToMarker>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart>();
            builder.AddElement<TwoCellAnchor>()
                .AddAttribute("editAs", a => a.EditAs, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ToMarker), 1, 1),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData), 1, 1)
            };
        }

        /// <summary>
        /// <para>Starting Anchor Point.</para>
        /// <para>Represents the following element tag in the schema: xdr:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker? FromMarker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ending Anchor Point.</para>
        /// <para>Represents the following element tag in the schema: xdr:to.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ToMarker? ToMarker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ToMarker>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TwoCellAnchor>(deep);
    }

    /// <summary>
    /// <para>One Cell Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:oneCellAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent" /> <c>&lt;xdr:ext></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData" /> <c>&lt;xdr:clientData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape" /> <c>&lt;xdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame" /> <c>&lt;xdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape" /> <c>&lt;xdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker" /> <c>&lt;xdr:from></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture" /> <c>&lt;xdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape" /> <c>&lt;xdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart" /> <c>&lt;xdr:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:oneCellAnchor")]
    public partial class OneCellAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class.
        /// </summary>
        public OneCellAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneCellAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OneCellAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OneCellAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OneCellAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:oneCellAnchor");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent), 1, 1),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData), 1, 1)
            };
        }

        /// <summary>
        /// <para>FromMarker.</para>
        /// <para>Represents the following element tag in the schema: xdr:from.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker? FromMarker
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.FromMarker>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extent.</para>
        /// <para>Represents the following element tag in the schema: xdr:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent? Extent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OneCellAnchor>(deep);
    }

    /// <summary>
    /// <para>Absolute Anchor Shape Size.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:absoluteAnchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Position" /> <c>&lt;xdr:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent" /> <c>&lt;xdr:ext></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData" /> <c>&lt;xdr:clientData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape" /> <c>&lt;xdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame" /> <c>&lt;xdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape" /> <c>&lt;xdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture" /> <c>&lt;xdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape" /> <c>&lt;xdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart" /> <c>&lt;xdr:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:absoluteAnchor")]
    public partial class AbsoluteAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class.
        /// </summary>
        public AbsoluteAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AbsoluteAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AbsoluteAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AbsoluteAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AbsoluteAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:absoluteAnchor");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Position>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Position), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent), 1, 1),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ClientData), 1, 1)
            };
        }

        /// <summary>
        /// <para>Position.</para>
        /// <para>Represents the following element tag in the schema: xdr:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.Position? Position
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.Position>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Extent.</para>
        /// <para>Represents the following element tag in the schema: xdr:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent? Extent
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.Extent>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AbsoluteAnchor>(deep);
    }

    /// <summary>
    /// <para>Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:sp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties" /> <c>&lt;xdr:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle" /> <c>&lt;xdr:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody" /> <c>&lt;xdr:txBody></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeProperties" /> <c>&lt;xdr:nvSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:sp")]
    public partial class Shape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Shape class.
        /// </summary>
        public Shape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Shape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Shape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Shape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Text Link</para>
        /// <para>Represents the following attribute in the schema: textlink</para>
        /// </summary>
        [SchemaAttr("textlink")]
        public StringValue? TextLink
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Lock Text Flag</para>
        /// <para>Represents the following attribute in the schema: fLocksText</para>
        /// </summary>
        [SchemaAttr("fLocksText")]
        public BooleanValue? LockText
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:sp");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeProperties>();
            builder.AddElement<Shape>()
                .AddAttribute("macro", a => a.Macro)
                .AddAttribute("textlink", a => a.TextLink)
                .AddAttribute("fLocksText", a => a.LockText)
                .AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("xdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Shape.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeProperties? NonVisualShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: xdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle? ShapeStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Text Body.</para>
        /// <para>Represents the following element tag in the schema: xdr:txBody.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody? TextBody
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.TextBody>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Shape>(deep);
    }

    /// <summary>
    /// <para>Group Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:grpSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShapeProperties" /> <c>&lt;xdr:grpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape" /> <c>&lt;xdr:cxnSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame" /> <c>&lt;xdr:graphicFrame></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape" /> <c>&lt;xdr:grpSp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeProperties" /> <c>&lt;xdr:nvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture" /> <c>&lt;xdr:pic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape" /> <c>&lt;xdr:sp></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart" /> <c>&lt;xdr14:contentPart></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:grpSp")]
    public partial class GroupShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShape class.
        /// </summary>
        public GroupShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShape(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:grpSp");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShapeProperties), 1, 1),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Shape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.GraphicFrame), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ConnectionShape), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Picture), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ContentPart), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Group Shape.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeProperties? NonVisualGroupShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Group Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:grpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShapeProperties? GroupShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.GroupShapeProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShape>(deep);
    }

    /// <summary>
    /// <para>Graphic Frame.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:graphicFrame.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Graphic" /> <c>&lt;a:graphic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.Transform" /> <c>&lt;xdr:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameProperties" /> <c>&lt;xdr:nvGraphicFramePr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:graphicFrame")]
    public partial class GraphicFrame : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GraphicFrame class.
        /// </summary>
        public GraphicFrame() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GraphicFrame(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GraphicFrame class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GraphicFrame(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference To Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:graphicFrame");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Graphic>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.Transform>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameProperties>();
            builder.AddElement<GraphicFrame>()
                .AddAttribute("macro", a => a.Macro)
                .AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.Transform), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Graphic), 1, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("xdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Graphic Frame.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>2D Transform for Graphic Frames.</para>
        /// <para>Represents the following element tag in the schema: xdr:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.Transform? Transform
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.Transform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Graphic.</para>
        /// <para>Represents the following element tag in the schema: a:graphic.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Graphic? Graphic
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Graphic>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GraphicFrame>(deep);
    }

    /// <summary>
    /// <para>Connection Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cxnSp.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties" /> <c>&lt;xdr:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle" /> <c>&lt;xdr:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectionShapeProperties" /> <c>&lt;xdr:nvCxnSpPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:cxnSp")]
    public partial class ConnectionShape : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionShape class.
        /// </summary>
        public ConnectionShape() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ConnectionShape(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionShape class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ConnectionShape(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference to Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:cxnSp");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectionShapeProperties>();
            builder.AddElement<ConnectionShape>()
                .AddAttribute("macro", a => a.Macro)
                .AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectionShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle), 0, 1)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("xdr:macro", 0, 256));
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Connection Shape.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectionShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connector Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeStyle.</para>
        /// <para>Represents the following element tag in the schema: xdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle? ShapeStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConnectionShape>(deep);
    }

    /// <summary>
    /// <para>Defines the Picture Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:pic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill" /> <c>&lt;xdr:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties" /> <c>&lt;xdr:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle" /> <c>&lt;xdr:style></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureProperties" /> <c>&lt;xdr:nvPicPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:pic")]
    public partial class Picture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Picture class.
        /// </summary>
        public Picture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Picture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Picture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Picture(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference To Custom Function</para>
        /// <para>Represents the following attribute in the schema: macro</para>
        /// </summary>
        [SchemaAttr("macro")]
        public StringValue? Macro
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Publish to Server Flag</para>
        /// <para>Represents the following attribute in the schema: fPublished</para>
        /// </summary>
        [SchemaAttr("fPublished")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:pic");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureProperties>();
            builder.AddElement<Picture>()
                .AddAttribute("macro", a => a.Macro)
                .AddAttribute("fPublished", a => a.Published);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle), 0, 1)
            };
        }

        /// <summary>
        /// <para>Non-Visual Properties for a Picture.</para>
        /// <para>Represents the following element tag in the schema: xdr:nvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureProperties? NonVisualPictureProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Fill.</para>
        /// <para>Represents the following element tag in the schema: xdr:blipFill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill? BlipFill
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.BlipFill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shape Style.</para>
        /// <para>Represents the following element tag in the schema: xdr:style.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle? ShapeStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ShapeStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Picture>(deep);
    }

    /// <summary>
    /// <para>Defines the ContentPart Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:contentPart.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList" /> <c>&lt;xdr14:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D" /> <c>&lt;xdr14:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties" /> <c>&lt;xdr14:nvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties" /> <c>&lt;xdr14:nvContentPartPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:contentPart")]
    public partial class ContentPart : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContentPart class.
        /// </summary>
        public ContentPart() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContentPart(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContentPart class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContentPart(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:id")]
        public StringValue? RelationshipId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("xdr:contentPart");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties>();
            builder.AddElement<ContentPart>()
                .AddAttribute("r:id", a => a.RelationshipId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ExcelNonVisualContentPartShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr14:nvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties? ExcelNonVisualContentPartShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ExcelNonVisualContentPartShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ApplicationNonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr14:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Transform2D.</para>
        /// <para>Represents the following element tag in the schema: xdr14:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D? Transform2D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.Transform2D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xdr14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr14 = http://schemas.microsoft.com/office/excel/2010/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContentPart>(deep);
    }

    /// <summary>
    /// <para>Worksheet Drawing.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:wsDr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.AbsoluteAnchor" /> <c>&lt;xdr:absoluteAnchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.OneCellAnchor" /> <c>&lt;xdr:oneCellAnchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.TwoCellAnchor" /> <c>&lt;xdr:twoCellAnchor></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:wsDr")]
    public partial class WorksheetDrawing : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class.
        /// </summary>
        public WorksheetDrawing() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetDrawing(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetDrawing(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetDrawing class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WorksheetDrawing(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:wsDr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.AbsoluteAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.OneCellAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.TwoCellAnchor>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 0)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.TwoCellAnchor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.OneCellAnchor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.AbsoluteAnchor), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorksheetDrawing>(deep);

        internal WorksheetDrawing(DrawingsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DrawingsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DrawingsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DrawingsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DrawingsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DrawingsPart associated with this element.
        /// </summary>
        public DrawingsPart? DrawingsPart
        {
            get => OpenXmlPart as DrawingsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeDrawingProperties" /> <c>&lt;xdr:cNvSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties" /> <c>&lt;xdr:cNvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:nvSpPr")]
    public partial class NonVisualShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class.
        /// </summary>
        public NonVisualShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:nvSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Non-Visual Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Connection Non-Visual Shape Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:spPr.</para>
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
    [SchemaAttr("xdr:spPr")]
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
            builder.SetSchema("xdr:spPr");
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
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:style.</para>
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
    [SchemaAttr("xdr:style")]
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
            builder.SetSchema("xdr:style");
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
    /// <para>Shape Text Body.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:txBody.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:txBody")]
    public partial class TextBody : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBody class.
        /// </summary>
        public TextBody() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBody(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBody class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBody(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:txBody");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ListStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Paragraph>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BodyProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ListStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Paragraph), 1, 0)
            };
        }

        /// <summary>
        /// <para>Body Properties.</para>
        /// <para>Represents the following element tag in the schema: a:bodyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.BodyProperties? BodyProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.BodyProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Text List Styles.</para>
        /// <para>Represents the following element tag in the schema: a:lstStyle.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.ListStyle? ListStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.ListStyle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBody>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Connection Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvCxnSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectorShapeDrawingProperties" /> <c>&lt;xdr:cNvCxnSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties" /> <c>&lt;xdr:cNvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:nvCxnSpPr")]
    public partial class NonVisualConnectionShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class.
        /// </summary>
        public NonVisualConnectionShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectionShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectionShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectionShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:nvCxnSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectorShapeDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectorShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Connection Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Connector Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvCxnSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualConnectorShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectionShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Picture.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties" /> <c>&lt;xdr:cNvPicPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties" /> <c>&lt;xdr:cNvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:nvPicPr")]
    public partial class NonVisualPictureProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class.
        /// </summary>
        public NonVisualPictureProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:nvPicPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Picture Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPicPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualPictureDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureProperties>(deep);
    }

    /// <summary>
    /// <para>Picture Fill.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:blipFill.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blip" /> <c>&lt;a:blip></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SourceRectangle" /> <c>&lt;a:srcRect></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Stretch" /> <c>&lt;a:stretch></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Tile" /> <c>&lt;a:tile></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:blipFill")]
    public partial class BlipFill : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BlipFill class.
        /// </summary>
        public BlipFill() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BlipFill(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BlipFill class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BlipFill(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Rotate With Shape</para>
        /// <para>Represents the following attribute in the schema: rotWithShape</para>
        /// </summary>
        [SchemaAttr("rotWithShape")]
        public BooleanValue? RotateWithShape
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:blipFill");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blip>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Stretch>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Tile>();
            builder.AddElement<BlipFill>()
                .AddAttribute("rotWithShape", a => a.RotateWithShape);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blip), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SourceRectangle), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Tile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Stretch), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: a:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Blip? Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Blip>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Source Rectangle.</para>
        /// <para>Represents the following element tag in the schema: a:srcRect.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SourceRectangle? SourceRectangle
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SourceRectangle>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BlipFill>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Graphic Frame.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameDrawingProperties" /> <c>&lt;xdr:cNvGraphicFramePr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties" /> <c>&lt;xdr:cNvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:nvGraphicFramePr")]
    public partial class NonVisualGraphicFrameProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class.
        /// </summary>
        public NonVisualGraphicFrameProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:nvGraphicFramePr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Connection Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvGraphicFramePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGraphicFrameDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameProperties>(deep);
    }

    /// <summary>
    /// <para>2D Transform for Graphic Frames.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Offset" /> <c>&lt;a:off></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extents" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:xfrm")]
    public partial class Transform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        public Transform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform(string outerXml) : base(outerXml)
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
        /// <para>Horizontal Flip</para>
        /// <para>Represents the following attribute in the schema: flipH</para>
        /// </summary>
        [SchemaAttr("flipH")]
        public BooleanValue? HorizontalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Vertical Flip</para>
        /// <para>Represents the following attribute in the schema: flipV</para>
        /// </summary>
        [SchemaAttr("flipV")]
        public BooleanValue? VerticalFlip
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:xfrm");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform>()
                .AddAttribute("rot", a => a.Rotation)
                .AddAttribute("flipH", a => a.HorizontalFlip)
                .AddAttribute("flipV", a => a.VerticalFlip);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Offset), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Extents), 0, 1)
            };
        }

        /// <summary>
        /// <para>Offset.</para>
        /// <para>Represents the following element tag in the schema: a:off.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Offset? Offset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Offset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Extents.</para>
        /// <para>Represents the following element tag in the schema: a:ext.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Extents? Extents
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Extents>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform>(deep);
    }

    /// <summary>
    /// <para>Column).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:col.</para>
    /// </summary>
    [SchemaAttr("xdr:col")]
    public partial class ColumnId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnId class.
        /// </summary>
        public ColumnId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ColumnId(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
            builder.SetSchema("xdr:col");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnId>(deep);
    }

    /// <summary>
    /// <para>Column Offset.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:colOff.</para>
    /// </summary>
    [SchemaAttr("xdr:colOff")]
    public partial class ColumnOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnOffset class.
        /// </summary>
        public ColumnOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ColumnOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int64Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int64Value>(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
            builder.SetSchema("xdr:colOff");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnOffset>(deep);
    }

    /// <summary>
    /// <para>Row Offset.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:rowOff.</para>
    /// </summary>
    [SchemaAttr("xdr:rowOff")]
    public partial class RowOffset : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RowOffset class.
        /// </summary>
        public RowOffset() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowOffset class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RowOffset(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int64Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int64Value>(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
            builder.SetSchema("xdr:rowOff");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowOffset>(deep);
    }

    /// <summary>
    /// <para>Row.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:row.</para>
    /// </summary>
    [SchemaAttr("xdr:row")]
    public partial class RowId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RowId class.
        /// </summary>
        public RowId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RowId(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(new NumberValidator() { MinInclusive = (0L) });
            builder.SetSchema("xdr:row");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowId>(deep);
    }

    /// <summary>
    /// <para>Starting Anchor Point.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:from.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset" /> <c>&lt;xdr:colOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset" /> <c>&lt;xdr:rowOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId" /> <c>&lt;xdr:col></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId" /> <c>&lt;xdr:row></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:from")]
    public partial class FromMarker : MarkerType
    {
        /// <summary>
        /// Initializes a new instance of the FromMarker class.
        /// </summary>
        public FromMarker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromMarker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public FromMarker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the FromMarker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public FromMarker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:from");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FromMarker>(deep);
    }

    /// <summary>
    /// <para>Ending Anchor Point.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:to.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset" /> <c>&lt;xdr:colOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset" /> <c>&lt;xdr:rowOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId" /> <c>&lt;xdr:col></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId" /> <c>&lt;xdr:row></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:to")]
    public partial class ToMarker : MarkerType
    {
        /// <summary>
        /// Initializes a new instance of the ToMarker class.
        /// </summary>
        public ToMarker() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToMarker(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToMarker class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ToMarker(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ToMarker class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ToMarker(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:to");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToMarker>(deep);
    }

    /// <summary>
    /// <para>Defines the MarkerType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset" /> <c>&lt;xdr:colOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset" /> <c>&lt;xdr:rowOff></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId" /> <c>&lt;xdr:col></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId" /> <c>&lt;xdr:row></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class MarkerType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MarkerType class.
        /// </summary>
        protected MarkerType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected MarkerType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected MarkerType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MarkerType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected MarkerType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId>();
        }

        /// <summary>
        /// <para>Column).</para>
        /// <para>Represents the following element tag in the schema: xdr:col.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId? ColumnId
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Column Offset.</para>
        /// <para>Represents the following element tag in the schema: xdr:colOff.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset? ColumnOffset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.ColumnOffset>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row.</para>
        /// <para>Represents the following element tag in the schema: xdr:row.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId? RowId
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.RowId>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Row Offset.</para>
        /// <para>Represents the following element tag in the schema: xdr:rowOff.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset? RowOffset
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.RowOffset>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Client Data.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:clientData.</para>
    /// </summary>
    [SchemaAttr("xdr:clientData")]
    public partial class ClientData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ClientData class.
        /// </summary>
        public ClientData() : base()
        {
        }

        /// <summary>
        /// <para>Locks With Sheet Flag</para>
        /// <para>Represents the following attribute in the schema: fLocksWithSheet</para>
        /// </summary>
        [SchemaAttr("fLocksWithSheet")]
        public BooleanValue? LockWithSheet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Prints With Sheet Flag</para>
        /// <para>Represents the following attribute in the schema: fPrintsWithSheet</para>
        /// </summary>
        [SchemaAttr("fPrintsWithSheet")]
        public BooleanValue? PrintWithSheet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:clientData");
            builder.AddElement<ClientData>()
                .AddAttribute("fLocksWithSheet", a => a.LockWithSheet)
                .AddAttribute("fPrintsWithSheet", a => a.PrintWithSheet);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ClientData>(deep);
    }

    /// <summary>
    /// <para>Defines the Extent Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:ext.</para>
    /// </summary>
    [SchemaAttr("xdr:ext")]
    public partial class Extent : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Extent class.
        /// </summary>
        public Extent() : base()
        {
        }

        /// <summary>
        /// <para>Extent Length</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        [SchemaAttr("cx")]
        public Int64Value? Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Extent Width</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        [SchemaAttr("cy")]
        public Int64Value? Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:ext");
            builder.AddElement<Extent>()
                .AddAttribute("cx", a => a.Cx, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                })
                .AddAttribute("cy", a => a.Cy, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Extent>(deep);
    }

    /// <summary>
    /// <para>Position.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:pos.</para>
    /// </summary>
    [SchemaAttr("xdr:pos")]
    public partial class Position : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Position class.
        /// </summary>
        public Position() : base()
        {
        }

        /// <summary>
        /// <para>X-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [SchemaAttr("x")]
        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Y-Axis Coordinate</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        [SchemaAttr("y")]
        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:pos");
            builder.AddElement<Position>()
                .AddAttribute("x", a => a.X, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("y", a => a.Y, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Position>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:cNvPr")]
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
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
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
        /// <para>descr</para>
        /// <para>Represents the following attribute in the schema: descr</para>
        /// </summary>
        [SchemaAttr("descr")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
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
            builder.SetSchema("xdr:cNvPr");
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
            builder.AddConstraint(new UniqueAttributeValueConstraint("xdr:id", true, null));
        }

        /// <summary>
        /// <para>HyperlinkOnClick.</para>
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
        /// <para>HyperlinkOnHover.</para>
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
        /// <para>NonVisualDrawingPropertiesExtensionList.</para>
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
    /// <para>Connection Non-Visual Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ShapeLocks" /> <c>&lt;a:spLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:cNvSpPr")]
    public partial class NonVisualShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class.
        /// </summary>
        public NonVisualShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualShapeDrawingProperties(string outerXml) : base(outerXml)
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
            builder.SetSchema("xdr:cNvSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ShapeLocks>();
            builder.AddElement<NonVisualShapeDrawingProperties>()
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Connector Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvCxnSpPr.</para>
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
    [SchemaAttr("xdr:cNvCxnSpPr")]
    public partial class NonVisualConnectorShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class.
        /// </summary>
        public NonVisualConnectorShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualConnectorShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualConnectorShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualConnectorShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:cNvCxnSpPr");
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualConnectorShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Picture Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvPicPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PictureLocks" /> <c>&lt;a:picLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:cNvPicPr")]
    public partial class NonVisualPictureDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class.
        /// </summary>
        public NonVisualPictureDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualPictureDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualPictureDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualPictureDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>preferRelativeResize</para>
        /// <para>Represents the following attribute in the schema: preferRelativeResize</para>
        /// </summary>
        [SchemaAttr("preferRelativeResize")]
        public BooleanValue? PreferRelativeResize
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:cNvPicPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            builder.AddElement<NonVisualPictureDrawingProperties>()
                .AddAttribute("preferRelativeResize", a => a.PreferRelativeResize);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>PictureLocks.</para>
        /// <para>Represents the following element tag in the schema: a:picLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PictureLocks? PictureLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PictureLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualPicturePropertiesExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualPictureDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Graphic Frame Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvGraphicFramePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GraphicFrameLocks" /> <c>&lt;a:graphicFrameLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:cNvGraphicFramePr")]
    public partial class NonVisualGraphicFrameDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class.
        /// </summary>
        public NonVisualGraphicFrameDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGraphicFrameDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGraphicFrameDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGraphicFrameDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:cNvGraphicFramePr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Graphic Frame Locks.</para>
        /// <para>Represents the following element tag in the schema: a:graphicFrameLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? GraphicFrameLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GraphicFrameLocks>();
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGraphicFrameDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Group Shape Drawing Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:cNvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupShapeLocks" /> <c>&lt;a:grpSpLocks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:cNvGrpSpPr")]
    public partial class NonVisualGroupShapeDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class.
        /// </summary>
        public NonVisualGroupShapeDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:cNvGrpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.GroupShapeLocks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>GroupShapeLocks.</para>
        /// <para>Represents the following element tag in the schema: a:grpSpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.GroupShapeLocks? GroupShapeLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.GroupShapeLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualGroupDrawingShapePropsExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Non-Visual Properties for a Group Shape.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:nvGrpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeDrawingProperties" /> <c>&lt;xdr:cNvGrpSpPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties" /> <c>&lt;xdr:cNvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:nvGrpSpPr")]
    public partial class NonVisualGroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class.
        /// </summary>
        public NonVisualGroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualGroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualGroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualGroupShapeProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xdr:nvGrpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeDrawingProperties), 1, 1)
            };
        }

        /// <summary>
        /// <para>Connection Non-Visual Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Non-Visual Group Shape Drawing Properties.</para>
        /// <para>Represents the following element tag in the schema: xdr:cNvGrpSpPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xdr = http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Spreadsheet.NonVisualGroupShapeDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupShapeProperties>(deep);
    }

    /// <summary>
    /// <para>Group Shape Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xdr:grpSpPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipFill" /> <c>&lt;a:blipFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectDag" /> <c>&lt;a:effectDag></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.EffectList" /> <c>&lt;a:effectLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GradientFill" /> <c>&lt;a:gradFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.GroupFill" /> <c>&lt;a:grpFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TransformGroup" /> <c>&lt;a:xfrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoFill" /> <c>&lt;a:noFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PatternFill" /> <c>&lt;a:pattFill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Scene3DType" /> <c>&lt;a:scene3d></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SolidFill" /> <c>&lt;a:solidFill></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xdr:grpSpPr")]
    public partial class GroupShapeProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class.
        /// </summary>
        public GroupShapeProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupShapeProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupShapeProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupShapeProperties(string outerXml) : base(outerXml)
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
            builder.SetSchema("xdr:grpSpPr");
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.EffectList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
            builder.AddElement<GroupShapeProperties>()
                .AddAttribute("bwMode", a => a.BlackWhiteMode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TransformGroup), 0, 1),
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
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectList), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.EffectDag), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Scene3DType), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>2D Transform for Grouped Objects.</para>
        /// <para>Represents the following element tag in the schema: a:xfrm.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.TransformGroup? TransformGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.TransformGroup>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupShapeProperties>(deep);
    }

    /// <summary>
    /// Resizing Behaviors
    /// </summary>
    public enum EditAsValues
    {
        /// <summary>
        /// Move and Resize With Anchor Cells.
        /// <para>When the item is serialized out as xml, its value is "twoCell".</para>
        /// </summary>
        [EnumString("twoCell")]
        TwoCell,
        /// <summary>
        /// Move With Cells but Do Not Resize.
        /// <para>When the item is serialized out as xml, its value is "oneCell".</para>
        /// </summary>
        [EnumString("oneCell")]
        OneCell,
        /// <summary>
        /// Do Not Move or Resize With Underlying Rows/Columns.
        /// <para>When the item is serialized out as xml, its value is "absolute".</para>
        /// </summary>
        [EnumString("absolute")]
        Absolute
    }
}