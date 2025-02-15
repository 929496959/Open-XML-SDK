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
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Diagram12
{
    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1612:spPr.</para>
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
    [SchemaAttr("dgm1612:spPr")]
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
            builder.SetSchema("dgm1612:spPr");
            builder.Availability = FileFormatVersions.Office2019;
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
    /// <para>Defines the TextListStyleType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1612:lstStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties" /> <c>&lt;a:defPPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties" /> <c>&lt;a:lvl1pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties" /> <c>&lt;a:lvl2pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties" /> <c>&lt;a:lvl3pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties" /> <c>&lt;a:lvl4pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties" /> <c>&lt;a:lvl5pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties" /> <c>&lt;a:lvl6pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties" /> <c>&lt;a:lvl7pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties" /> <c>&lt;a:lvl8pPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties" /> <c>&lt;a:lvl9pPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dgm1612:lstStyle")]
    public partial class TextListStyleType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextListStyleType class.
        /// </summary>
        public TextListStyleType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextListStyleType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextListStyleType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextListStyleType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextListStyleType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm1612:lstStyle");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Default Paragraph Style.</para>
        /// <para>Represents the following element tag in the schema: a:defPPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties? DefaultParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.DefaultParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 1 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl1pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties? Level1ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level1ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 2 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl2pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties? Level2ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level2ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 3 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl3pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties? Level3ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level3ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 4 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl4pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties? Level4ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level4ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 5 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl5pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties? Level5ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level5ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 6 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl6pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties? Level6ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level6ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 7 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl7pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties? Level7ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level7ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 8 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl8pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties? Level8ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level8ParagraphProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List Level 9 Text Style.</para>
        /// <para>Represents the following element tag in the schema: a:lvl9pPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties? Level9ParagraphProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.Level9ParagraphProperties>();
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextListStyleType>(deep);
    }
}