﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.PowerPoint
{
    /// <summary>
    /// <para>Defines the NonVisualContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:nvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualDrawingProperties" /> <c>&lt;p14:cNvPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualInkContentPartProperties" /> <c>&lt;p14:cNvContentPartPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.ApplicationNonVisualDrawingProperties" /> <c>&lt;p14:nvPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:nvContentPartPr")]
    public partial class NonVisualContentPartProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualContentPartProperties class.
        /// </summary>
        public NonVisualContentPartProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualContentPartProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualContentPartProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualContentPartProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:nvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualDrawingProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualInkContentPartProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.ApplicationNonVisualDrawingProperties>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualInkContentPartProperties), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ApplicationNonVisualDrawingProperties), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>NonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: p14:cNvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualDrawingProperties? NonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NonVisualInkContentPartProperties.</para>
        /// <para>Represents the following element tag in the schema: p14:cNvContentPartPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.NonVisualInkContentPartProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ApplicationNonVisualDrawingProperties.</para>
        /// <para>Represents the following element tag in the schema: p14:nvPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.ApplicationNonVisualDrawingProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the Transform2D Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:xfrm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Offset" /> <c>&lt;a:off></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extents" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:xfrm")]
    public partial class Transform2D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Transform2D class.
        /// </summary>
        public Transform2D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Transform2D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Transform2D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Transform2D(string outerXml) : base(outerXml)
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
            builder.SetSchema("p14:xfrm");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Offset>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Extents>();
            builder.AddElement<Transform2D>()
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Transform2D>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionListModify Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.Extension" /> <c>&lt;p:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:extLst")]
    public partial class ExtensionListModify : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionListModify class.
        /// </summary>
        public ExtensionListModify() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionListModify class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionListModify(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionListModify class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionListModify(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionListModify class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionListModify(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Modify</para>
        /// <para>Represents the following attribute in the schema: mod</para>
        /// </summary>
        [SchemaAttr("mod")]
        public BooleanValue? Modify
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Presentation.Extension>();
            builder.AddElement<ExtensionListModify>()
                .AddAttribute("mod", a => a.Modify);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionListModify>(deep);
    }

    /// <summary>
    /// <para>Defines the Media Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:media.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList" /> <c>&lt;p14:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmarkList" /> <c>&lt;p14:bmkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.MediaFade" /> <c>&lt;p14:fade></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.MediaTrim" /> <c>&lt;p14:trim></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:media")]
    public partial class Media : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Media class.
        /// </summary>
        public Media() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Media class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Media(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Media class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Media(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Media class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Media(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Embedded Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:embed</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:embed")]
        public StringValue? Embed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Linked Picture Reference</para>
        /// <para>Represents the following attribute in the schema: r:link</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:link")]
        public StringValue? Link
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:media");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmarkList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaFade>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaTrim>();
            builder.AddElement<Media>()
                .AddAttribute("r:embed", a => a.Embed)
                .AddAttribute("r:link", a => a.Link);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.MediaTrim), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.MediaFade), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmarkList), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
            builder.AddConstraint(new RelationshipExistConstraint("r:link") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new RelationshipExistConstraint("r:embed") { Version = FileFormatVersions.Office2010 });
        }

        /// <summary>
        /// <para>MediaTrim.</para>
        /// <para>Represents the following element tag in the schema: p14:trim.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.MediaTrim? MediaTrim
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaTrim>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MediaFade.</para>
        /// <para>Represents the following element tag in the schema: p14:fade.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.MediaFade? MediaFade
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaFade>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MediaBookmarkList.</para>
        /// <para>Represents the following element tag in the schema: p14:bmkLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmarkList? MediaBookmarkList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmarkList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Media>(deep);
    }

    /// <summary>
    /// <para>Defines the VortexTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:vortex.</para>
    /// </summary>
    [SchemaAttr("p14:vortex")]
    public partial class VortexTransition : SideDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the VortexTransition class.
        /// </summary>
        public VortexTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:vortex");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VortexTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the PanTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:pan.</para>
    /// </summary>
    [SchemaAttr("p14:pan")]
    public partial class PanTransition : SideDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the PanTransition class.
        /// </summary>
        public PanTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:pan");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PanTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the SideDirectionTransitionType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SideDirectionTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SideDirectionTransitionType class.
        /// </summary>
        protected SideDirectionTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<SideDirectionTransitionType>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }
    }

    /// <summary>
    /// <para>Defines the SwitchTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:switch.</para>
    /// </summary>
    [SchemaAttr("p14:switch")]
    public partial class SwitchTransition : LeftRightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the SwitchTransition class.
        /// </summary>
        public SwitchTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:switch");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SwitchTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the FlipTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:flip.</para>
    /// </summary>
    [SchemaAttr("p14:flip")]
    public partial class FlipTransition : LeftRightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the FlipTransition class.
        /// </summary>
        public FlipTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:flip");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FlipTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the FerrisTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:ferris.</para>
    /// </summary>
    [SchemaAttr("p14:ferris")]
    public partial class FerrisTransition : LeftRightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the FerrisTransition class.
        /// </summary>
        public FerrisTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:ferris");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FerrisTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the GalleryTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:gallery.</para>
    /// </summary>
    [SchemaAttr("p14:gallery")]
    public partial class GalleryTransition : LeftRightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the GalleryTransition class.
        /// </summary>
        public GalleryTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:gallery");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GalleryTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the ConveyorTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:conveyor.</para>
    /// </summary>
    [SchemaAttr("p14:conveyor")]
    public partial class ConveyorTransition : LeftRightDirectionTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the ConveyorTransition class.
        /// </summary>
        public ConveyorTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:conveyor");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ConveyorTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the LeftRightDirectionTransitionType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class LeftRightDirectionTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LeftRightDirectionTransitionType class.
        /// </summary>
        protected LeftRightDirectionTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionLeftRightDirectionTypeValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionLeftRightDirectionTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<LeftRightDirectionTransitionType>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }
    }

    /// <summary>
    /// <para>Defines the RippleTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:ripple.</para>
    /// </summary>
    [SchemaAttr("p14:ripple")]
    public partial class RippleTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RippleTransition class.
        /// </summary>
        public RippleTransition() : base()
        {
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public StringValue? Direction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:ripple");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<RippleTransition>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddUnion(union =>
                    {
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionCornerDirectionValues>>(EnumValidator.Instance);
                        union.AddValidator<EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionCenterDirectionTypeValues>>(EnumValidator.Instance);
                    });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RippleTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the HoneycombTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:honeycomb.</para>
    /// </summary>
    [SchemaAttr("p14:honeycomb")]
    public partial class HoneycombTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the HoneycombTransition class.
        /// </summary>
        public HoneycombTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:honeycomb");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HoneycombTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the FlashTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:flash.</para>
    /// </summary>
    [SchemaAttr("p14:flash")]
    public partial class FlashTransition : EmptyType
    {
        /// <summary>
        /// Initializes a new instance of the FlashTransition class.
        /// </summary>
        public FlashTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:flash");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FlashTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the EmptyType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class EmptyType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EmptyType class.
        /// </summary>
        protected EmptyType() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
        }
    }

    /// <summary>
    /// <para>Defines the PrismTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:prism.</para>
    /// </summary>
    [SchemaAttr("p14:prism")]
    public partial class PrismTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PrismTransition class.
        /// </summary>
        public PrismTransition() : base()
        {
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isContent, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isContent</para>
        /// </summary>
        [SchemaAttr("isContent")]
        public BooleanValue? IsContent
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isInverted, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isInverted</para>
        /// </summary>
        [SchemaAttr("isInverted")]
        public BooleanValue? IsInverted
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:prism");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<PrismTransition>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("isContent", a => a.IsContent)
                .AddAttribute("isInverted", a => a.IsInverted);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrismTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the DoorsTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:doors.</para>
    /// </summary>
    [SchemaAttr("p14:doors")]
    public partial class DoorsTransition : OrientationTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the DoorsTransition class.
        /// </summary>
        public DoorsTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:doors");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DoorsTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the WindowTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:window.</para>
    /// </summary>
    [SchemaAttr("p14:window")]
    public partial class WindowTransition : OrientationTransitionType
    {
        /// <summary>
        /// Initializes a new instance of the WindowTransition class.
        /// </summary>
        public WindowTransition() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:window");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WindowTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the OrientationTransitionType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OrientationTransitionType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OrientationTransitionType class.
        /// </summary>
        protected OrientationTransitionType() : base()
        {
        }

        /// <summary>
        /// <para>Transition Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.DirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OrientationTransitionType>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }
    }

    /// <summary>
    /// <para>Defines the GlitterTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:glitter.</para>
    /// </summary>
    [SchemaAttr("p14:glitter")]
    public partial class GlitterTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the GlitterTransition class.
        /// </summary>
        public GlitterTransition() : base()
        {
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionSlideDirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pattern, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pattern</para>
        /// </summary>
        [SchemaAttr("pattern")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionPatternValues>? Pattern
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionPatternValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:glitter");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<GlitterTransition>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("pattern", a => a.Pattern, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GlitterTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the WarpTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:warp.</para>
    /// </summary>
    [SchemaAttr("p14:warp")]
    public partial class WarpTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WarpTransition class.
        /// </summary>
        public WarpTransition() : base()
        {
        }

        /// <summary>
        /// <para>Direction</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:warp");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<WarpTransition>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WarpTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the FlythroughTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:flythrough.</para>
    /// </summary>
    [SchemaAttr("p14:flythrough")]
    public partial class FlythroughTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FlythroughTransition class.
        /// </summary>
        public FlythroughTransition() : base()
        {
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hasBounce, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: hasBounce</para>
        /// </summary>
        [SchemaAttr("hasBounce")]
        public BooleanValue? HasBounce
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:flythrough");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<FlythroughTransition>()
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("hasBounce", a => a.HasBounce);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FlythroughTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the ShredTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:shred.</para>
    /// </summary>
    [SchemaAttr("p14:shred")]
    public partial class ShredTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShredTransition class.
        /// </summary>
        public ShredTransition() : base()
        {
        }

        /// <summary>
        /// <para>pattern, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: pattern</para>
        /// </summary>
        [SchemaAttr("pattern")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionShredPatternValues>? Pattern
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionShredPatternValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TransitionInOutDirectionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:shred");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ShredTransition>()
                .AddAttribute("pattern", a => a.Pattern, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShredTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the RevealTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:reveal.</para>
    /// </summary>
    [SchemaAttr("p14:reveal")]
    public partial class RevealTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevealTransition class.
        /// </summary>
        public RevealTransition() : base()
        {
        }

        /// <summary>
        /// <para>thruBlk, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: thruBlk</para>
        /// </summary>
        [SchemaAttr("thruBlk")]
        public BooleanValue? ThroughBlack
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dir, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dir</para>
        /// </summary>
        [SchemaAttr("dir")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionLeftRightDirectionTypeValues>? Direction
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.PowerPoint.TransitionLeftRightDirectionTypeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:reveal");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<RevealTransition>()
                .AddAttribute("thruBlk", a => a.ThroughBlack)
                .AddAttribute("dir", a => a.Direction, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevealTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the WheelReverseTransition Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:wheelReverse.</para>
    /// </summary>
    [SchemaAttr("p14:wheelReverse")]
    public partial class WheelReverseTransition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WheelReverseTransition class.
        /// </summary>
        public WheelReverseTransition() : base()
        {
        }

        /// <summary>
        /// <para>Spokes</para>
        /// <para>Represents the following attribute in the schema: spokes</para>
        /// </summary>
        [SchemaAttr("spokes")]
        public UInt32Value? Spokes
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:wheelReverse");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<WheelReverseTransition>()
                .AddAttribute("spokes", a => a.Spokes);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WheelReverseTransition>(deep);
    }

    /// <summary>
    /// <para>Defines the BookmarkTarget Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:bmkTgt.</para>
    /// </summary>
    [SchemaAttr("p14:bmkTgt")]
    public partial class BookmarkTarget : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BookmarkTarget class.
        /// </summary>
        public BookmarkTarget() : base()
        {
        }

        /// <summary>
        /// <para>spid, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        [SchemaAttr("spid")]
        public UInt32Value? ShapeId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bmkName, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: bmkName</para>
        /// </summary>
        [SchemaAttr("bmkName")]
        public StringValue? BookmarkName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:bmkTgt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BookmarkTarget>()
                .AddAttribute("spid", a => a.ShapeId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("bmkName", a => a.BookmarkName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BookmarkTarget>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:sectionPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.SectionOld" /> <c>&lt;p14:section></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:sectionPr")]
    public partial class SectionProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionProperties class.
        /// </summary>
        public SectionProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SectionProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:sectionPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.SectionOld>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionOld), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:sectionLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.Section" /> <c>&lt;p14:section></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:sectionLst")]
    public partial class SectionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionList class.
        /// </summary>
        public SectionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SectionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:sectionLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.Section>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.Section), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionList>(deep);
    }

    /// <summary>
    /// <para>Defines the BrowseMode Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:browseMode.</para>
    /// </summary>
    [SchemaAttr("p14:browseMode")]
    public partial class BrowseMode : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BrowseMode class.
        /// </summary>
        public BrowseMode() : base()
        {
        }

        /// <summary>
        /// <para>showStatus, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showStatus</para>
        /// </summary>
        [SchemaAttr("showStatus")]
        public BooleanValue? ShowStatus
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:browseMode");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BrowseMode>()
                .AddAttribute("showStatus", a => a.ShowStatus);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BrowseMode>(deep);
    }

    /// <summary>
    /// <para>Defines the LaserColor Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:laserClr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HslColor" /> <c>&lt;a:hslClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PresetColor" /> <c>&lt;a:prstClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SchemeColor" /> <c>&lt;a:schemeClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage" /> <c>&lt;a:scrgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.RgbColorModelHex" /> <c>&lt;a:srgbClr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.SystemColor" /> <c>&lt;a:sysClr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:laserClr")]
    public partial class LaserColor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LaserColor class.
        /// </summary>
        public LaserColor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LaserColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LaserColor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LaserColor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LaserColor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LaserColor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LaserColor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:laserClr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.HslColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.RgbColorModelHex), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.HslColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SystemColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.SchemeColor), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PresetColor), 1, 1)
                    }
                }
            };
        }

        /// <summary>
        /// <para>RGB Color Model - Percentage Variant.</para>
        /// <para>Represents the following element tag in the schema: a:scrgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage? RgbColorModelPercentage
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RGB Color Model - Hex Variant.</para>
        /// <para>Represents the following element tag in the schema: a:srgbClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.RgbColorModelHex? RgbColorModelHex
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hue, Saturation, Luminance Color Model.</para>
        /// <para>Represents the following element tag in the schema: a:hslClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.HslColor? HslColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.HslColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>System Color.</para>
        /// <para>Represents the following element tag in the schema: a:sysClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SystemColor? SystemColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SystemColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scheme Color.</para>
        /// <para>Represents the following element tag in the schema: a:schemeClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.SchemeColor? SchemeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.SchemeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Preset Color.</para>
        /// <para>Represents the following element tag in the schema: a:prstClr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PresetColor? PresetColor
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PresetColor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LaserColor>(deep);
    }

    /// <summary>
    /// <para>Defines the DefaultImageDpi Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:defaultImageDpi.</para>
    /// </summary>
    [SchemaAttr("p14:defaultImageDpi")]
    public partial class DefaultImageDpi : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DefaultImageDpi class.
        /// </summary>
        public DefaultImageDpi() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:defaultImageDpi");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DefaultImageDpi>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DefaultImageDpi>(deep);
    }

    /// <summary>
    /// <para>Defines the DiscardImageEditData Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:discardImageEditData.</para>
    /// </summary>
    [SchemaAttr("p14:discardImageEditData")]
    public partial class DiscardImageEditData : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DiscardImageEditData class.
        /// </summary>
        public DiscardImageEditData() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:discardImageEditData");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DiscardImageEditData>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiscardImageEditData>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowMediaControls Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:showMediaCtrls.</para>
    /// </summary>
    [SchemaAttr("p14:showMediaCtrls")]
    public partial class ShowMediaControls : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowMediaControls class.
        /// </summary>
        public ShowMediaControls() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public BooleanValue? Val
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:showMediaCtrls");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ShowMediaControls>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowMediaControls>(deep);
    }

    /// <summary>
    /// <para>Defines the LaserTraceList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:laserTraceLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.TracePointList" /> <c>&lt;p14:tracePtLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:laserTraceLst")]
    public partial class LaserTraceList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LaserTraceList class.
        /// </summary>
        public LaserTraceList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LaserTraceList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LaserTraceList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LaserTraceList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LaserTraceList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LaserTraceList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LaserTraceList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:laserTraceLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.TracePointList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.TracePointList), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LaserTraceList>(deep);
    }

    /// <summary>
    /// <para>Defines the CreationId Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:creationId.</para>
    /// </summary>
    [SchemaAttr("p14:creationId")]
    public partial class CreationId : RandomIdType
    {
        /// <summary>
        /// Initializes a new instance of the CreationId class.
        /// </summary>
        public CreationId() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:creationId");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CreationId>(deep);
    }

    /// <summary>
    /// <para>Defines the ModificationId Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:modId.</para>
    /// </summary>
    [SchemaAttr("p14:modId")]
    public partial class ModificationId : RandomIdType
    {
        /// <summary>
        /// Initializes a new instance of the ModificationId class.
        /// </summary>
        public ModificationId() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:modId");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModificationId>(deep);
    }

    /// <summary>
    /// <para>Defines the RandomIdType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class RandomIdType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RandomIdType class.
        /// </summary>
        protected RandomIdType() : base()
        {
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public UInt32Value? Val
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<RandomIdType>()
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }

    /// <summary>
    /// <para>Defines the ShowEventRecordList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:showEvtLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.PlayEventRecord" /> <c>&lt;p14:playEvt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.StopEventRecord" /> <c>&lt;p14:stopEvt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.PauseEventRecord" /> <c>&lt;p14:pauseEvt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.ResumeEventRecord" /> <c>&lt;p14:resumeEvt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.SeekEventRecord" /> <c>&lt;p14:seekEvt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.NullEventRecord" /> <c>&lt;p14:nullEvt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.TriggerEventRecord" /> <c>&lt;p14:triggerEvt></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:showEvtLst")]
    public partial class ShowEventRecordList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowEventRecordList class.
        /// </summary>
        public ShowEventRecordList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowEventRecordList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowEventRecordList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowEventRecordList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ShowEventRecordList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ShowEventRecordList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ShowEventRecordList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:showEvtLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.PlayEventRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.StopEventRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.PauseEventRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.ResumeEventRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.SeekEventRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.NullEventRecord>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.TriggerEventRecord>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.TriggerEventRecord), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.PlayEventRecord), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.StopEventRecord), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.PauseEventRecord), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ResumeEventRecord), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SeekEventRecord), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.NullEventRecord), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <summary>
        /// <para>TriggerEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:triggerEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.TriggerEventRecord? TriggerEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.TriggerEventRecord>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PlayEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:playEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.PlayEventRecord? PlayEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.PlayEventRecord>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>StopEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:stopEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.StopEventRecord? StopEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.StopEventRecord>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PauseEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:pauseEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.PauseEventRecord? PauseEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.PauseEventRecord>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ResumeEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:resumeEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.ResumeEventRecord? ResumeEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.ResumeEventRecord>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SeekEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:seekEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.SeekEventRecord? SeekEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.SeekEventRecord>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NullEventRecord.</para>
        /// <para>Represents the following element tag in the schema: p14:nullEvt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.NullEventRecord? NullEventRecord
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.NullEventRecord>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowEventRecordList>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:cNvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnClick" /> <c>&lt;a:hlinkClick></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.HyperlinkOnHover" /> <c>&lt;a:hlinkHover></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtensionList" /> <c>&lt;a:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:cNvPr")]
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
            builder.SetSchema("p14:cNvPr");
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
    /// <para>Defines the NonVisualInkContentPartProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:cNvContentPartPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList" /> <c>&lt;a14:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks" /> <c>&lt;a14:cpLocks></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:cNvContentPartPr")]
    public partial class NonVisualInkContentPartProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class.
        /// </summary>
        public NonVisualInkContentPartProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualInkContentPartProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NonVisualInkContentPartProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NonVisualInkContentPartProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NonVisualInkContentPartProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>isComment, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isComment</para>
        /// </summary>
        [SchemaAttr("isComment")]
        public BooleanValue? IsComment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:cNvContentPartPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
            builder.AddElement<NonVisualInkContentPartProperties>()
                .AddAttribute("isComment", a => a.IsComment);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ContentPartLocks.</para>
        /// <para>Represents the following element tag in the schema: a14:cpLocks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks? ContentPartLocks
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: a14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a14 = http://schemas.microsoft.com/office/drawing/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualInkContentPartProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ApplicationNonVisualDrawingProperties Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:nvPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AudioFromCD" /> <c>&lt;a:audioCd></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AudioFromFile" /> <c>&lt;a:audioFile></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.WaveAudioFile" /> <c>&lt;a:wavAudioFile></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.QuickTimeFromFile" /> <c>&lt;a:quickTimeFile></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.VideoFromFile" /> <c>&lt;a:videoFile></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtensionList" /> <c>&lt;p:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.CustomerDataList" /> <c>&lt;p:custDataLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.PlaceholderShape" /> <c>&lt;p:ph></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:nvPr")]
    public partial class ApplicationNonVisualDrawingProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class.
        /// </summary>
        public ApplicationNonVisualDrawingProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ApplicationNonVisualDrawingProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationNonVisualDrawingProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ApplicationNonVisualDrawingProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Is a Photo Album</para>
        /// <para>Represents the following attribute in the schema: isPhoto</para>
        /// </summary>
        [SchemaAttr("isPhoto")]
        public BooleanValue? IsPhoto
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Is User Drawn</para>
        /// <para>Represents the following attribute in the schema: userDrawn</para>
        /// </summary>
        [SchemaAttr("userDrawn")]
        public BooleanValue? UserDrawn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:nvPr");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AudioFromCD>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AudioFromFile>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.WaveAudioFile>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.QuickTimeFromFile>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.VideoFromFile>();
            builder.AddChild<DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Presentation.CustomerDataList>();
            builder.AddChild<DocumentFormat.OpenXml.Presentation.PlaceholderShape>();
            builder.AddElement<ApplicationNonVisualDrawingProperties>()
                .AddAttribute("isPhoto", a => a.IsPhoto)
                .AddAttribute("userDrawn", a => a.UserDrawn);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.PlaceholderShape), 0, 1),
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AudioFromCD), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.WaveAudioFile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AudioFromFile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.VideoFromFile), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.CustomerDataList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.ApplicationNonVisualDrawingPropertiesExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Placeholder Shape.</para>
        /// <para>Represents the following element tag in the schema: p:ph.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p = http://schemas.openxmlformats.org/presentationml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Presentation.PlaceholderShape? PlaceholderShape
        {
            get => GetElement<DocumentFormat.OpenXml.Presentation.PlaceholderShape>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationNonVisualDrawingProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the MediaBookmark Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:bmk.</para>
    /// </summary>
    [SchemaAttr("p14:bmk")]
    public partial class MediaBookmark : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MediaBookmark class.
        /// </summary>
        public MediaBookmark() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public StringValue? Time
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:bmk");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MediaBookmark>()
                .AddAttribute("name", a => a.Name)
                .AddAttribute("time", a => a.Time);
            builder.AddConstraint(new UniqueAttributeValueConstraint("p14:name", true, "p14:bmkLst") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new UniqueAttributeValueConstraint("p14:time", true, "p14:bmkLst") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaBookmark>(deep);
    }

    /// <summary>
    /// <para>Defines the MediaTrim Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:trim.</para>
    /// </summary>
    [SchemaAttr("p14:trim")]
    public partial class MediaTrim : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MediaTrim class.
        /// </summary>
        public MediaTrim() : base()
        {
        }

        /// <summary>
        /// <para>st, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        [SchemaAttr("st")]
        public StringValue? Start
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>end, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: end</para>
        /// </summary>
        [SchemaAttr("end")]
        public StringValue? End
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:trim");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MediaTrim>()
                .AddAttribute("st", a => a.Start)
                .AddAttribute("end", a => a.End);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaTrim>(deep);
    }

    /// <summary>
    /// <para>Defines the MediaFade Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:fade.</para>
    /// </summary>
    [SchemaAttr("p14:fade")]
    public partial class MediaFade : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MediaFade class.
        /// </summary>
        public MediaFade() : base()
        {
        }

        /// <summary>
        /// <para>in, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: in</para>
        /// </summary>
        [SchemaAttr("in")]
        public StringValue? InDuration
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>out, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: out</para>
        /// </summary>
        [SchemaAttr("out")]
        public StringValue? OutDuration
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:fade");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MediaFade>()
                .AddAttribute("in", a => a.InDuration)
                .AddAttribute("out", a => a.OutDuration);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaFade>(deep);
    }

    /// <summary>
    /// <para>Defines the MediaBookmarkList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:bmkLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmark" /> <c>&lt;p14:bmk></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:bmkLst")]
    public partial class MediaBookmarkList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MediaBookmarkList class.
        /// </summary>
        public MediaBookmarkList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MediaBookmarkList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MediaBookmarkList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MediaBookmarkList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MediaBookmarkList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MediaBookmarkList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MediaBookmarkList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:bmkLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmark>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.MediaBookmark), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MediaBookmarkList>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.Extension" /> <c>&lt;p:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:extLst")]
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:extLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Presentation.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Presentation.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionOld Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:section.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList" /> <c>&lt;p14:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:section")]
    public partial class SectionOld : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionOld class.
        /// </summary>
        public SectionOld() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionOld class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionOld(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionOld class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionOld(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionOld class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SectionOld(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>slideIdLst, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: slideIdLst</para>
        /// </summary>
        [SchemaAttr("slideIdLst")]
        public ListValue<UInt32Value>? SlideIdList
        {
            get => GetAttribute<ListValue<UInt32Value>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("p14:section");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList>();
            builder.AddElement<SectionOld>()
                .AddAttribute("name", a => a.Name)
                .AddAttribute("slideIdLst", a => a.SlideIdList, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (2147483648L), MinInclusive = (256L) });
                })
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionOld>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionSlideIdListEntry Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:sldId.</para>
    /// </summary>
    [SchemaAttr("p14:sldId")]
    public partial class SectionSlideIdListEntry : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionSlideIdListEntry class.
        /// </summary>
        public SectionSlideIdListEntry() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:sldId");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SectionSlideIdListEntry>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MaxExclusive = (2147483648L), MinInclusive = (256L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionSlideIdListEntry>(deep);
    }

    /// <summary>
    /// <para>Defines the SectionSlideIdList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:sldIdLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdListEntry" /> <c>&lt;p14:sldId></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:sldIdLst")]
    public partial class SectionSlideIdList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SectionSlideIdList class.
        /// </summary>
        public SectionSlideIdList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionSlideIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionSlideIdList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionSlideIdList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SectionSlideIdList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SectionSlideIdList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SectionSlideIdList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:sldIdLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdListEntry>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdListEntry), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SectionSlideIdList>(deep);
    }

    /// <summary>
    /// <para>Defines the Section Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:section.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList" /> <c>&lt;p14:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdList" /> <c>&lt;p14:sldIdLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:section")]
    public partial class Section : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Section class.
        /// </summary>
        public Section() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Section class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Section(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Section class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Section(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Section class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Section(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("p14:section");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdList>();
            builder.AddElement<Section>()
                .AddAttribute("name", a => a.Name)
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdList), 1, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>SectionSlideIdList.</para>
        /// <para>Represents the following element tag in the schema: p14:sldIdLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdList? SectionSlideIdList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.SectionSlideIdList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p14:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p14 = http://schemas.microsoft.com/office/powerpoint/2010/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.PowerPoint.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Section>(deep);
    }

    /// <summary>
    /// <para>Defines the TracePoint Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:tracePt.</para>
    /// </summary>
    [SchemaAttr("p14:tracePt")]
    public partial class TracePoint : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TracePoint class.
        /// </summary>
        public TracePoint() : base()
        {
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public StringValue? Time
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [SchemaAttr("x")]
        public Int64Value? XCoordinate
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        [SchemaAttr("y")]
        public Int64Value? YCoordinate
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:tracePt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TracePoint>()
                .AddAttribute("t", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("x", a => a.XCoordinate, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("y", a => a.YCoordinate, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TracePoint>(deep);
    }

    /// <summary>
    /// <para>Defines the TracePointList Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:tracePtLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.PowerPoint.TracePoint" /> <c>&lt;p14:tracePt></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p14:tracePtLst")]
    public partial class TracePointList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TracePointList class.
        /// </summary>
        public TracePointList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TracePointList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TracePointList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TracePointList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TracePointList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TracePointList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TracePointList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:tracePtLst");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.PowerPoint.TracePoint>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.PowerPoint.TracePoint), 0, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TracePointList>(deep);
    }

    /// <summary>
    /// <para>Defines the TriggerEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:triggerEvt.</para>
    /// </summary>
    [SchemaAttr("p14:triggerEvt")]
    public partial class TriggerEventRecord : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TriggerEventRecord class.
        /// </summary>
        public TriggerEventRecord() : base()
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Presentation.TriggerEventValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Presentation.TriggerEventValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public StringValue? Time
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>objId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: objId</para>
        /// </summary>
        [SchemaAttr("objId")]
        public UInt32Value? ObjectId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:triggerEvt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TriggerEventRecord>()
                .AddAttribute("type", a => a.Type, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("time", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("objId", a => a.ObjectId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TriggerEventRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the PlayEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:playEvt.</para>
    /// </summary>
    [SchemaAttr("p14:playEvt")]
    public partial class PlayEventRecord : MediaPlaybackEventRecordType
    {
        /// <summary>
        /// Initializes a new instance of the PlayEventRecord class.
        /// </summary>
        public PlayEventRecord() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:playEvt");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PlayEventRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the StopEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:stopEvt.</para>
    /// </summary>
    [SchemaAttr("p14:stopEvt")]
    public partial class StopEventRecord : MediaPlaybackEventRecordType
    {
        /// <summary>
        /// Initializes a new instance of the StopEventRecord class.
        /// </summary>
        public StopEventRecord() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:stopEvt");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StopEventRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the PauseEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:pauseEvt.</para>
    /// </summary>
    [SchemaAttr("p14:pauseEvt")]
    public partial class PauseEventRecord : MediaPlaybackEventRecordType
    {
        /// <summary>
        /// Initializes a new instance of the PauseEventRecord class.
        /// </summary>
        public PauseEventRecord() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:pauseEvt");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PauseEventRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the ResumeEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:resumeEvt.</para>
    /// </summary>
    [SchemaAttr("p14:resumeEvt")]
    public partial class ResumeEventRecord : MediaPlaybackEventRecordType
    {
        /// <summary>
        /// Initializes a new instance of the ResumeEventRecord class.
        /// </summary>
        public ResumeEventRecord() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:resumeEvt");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ResumeEventRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the MediaPlaybackEventRecordType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class MediaPlaybackEventRecordType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MediaPlaybackEventRecordType class.
        /// </summary>
        protected MediaPlaybackEventRecordType() : base()
        {
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public StringValue? Time
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>objId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: objId</para>
        /// </summary>
        [SchemaAttr("objId")]
        public UInt32Value? ObjectId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<MediaPlaybackEventRecordType>()
                .AddAttribute("time", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("objId", a => a.ObjectId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }

    /// <summary>
    /// <para>Defines the SeekEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:seekEvt.</para>
    /// </summary>
    [SchemaAttr("p14:seekEvt")]
    public partial class SeekEventRecord : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SeekEventRecord class.
        /// </summary>
        public SeekEventRecord() : base()
        {
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public StringValue? Time
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>objId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: objId</para>
        /// </summary>
        [SchemaAttr("objId")]
        public UInt32Value? ObjectId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seek, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: seek</para>
        /// </summary>
        [SchemaAttr("seek")]
        public StringValue? Seek
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:seekEvt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<SeekEventRecord>()
                .AddAttribute("time", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("objId", a => a.ObjectId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("seek", a => a.Seek, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SeekEventRecord>(deep);
    }

    /// <summary>
    /// <para>Defines the NullEventRecord Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p14:nullEvt.</para>
    /// </summary>
    [SchemaAttr("p14:nullEvt")]
    public partial class NullEventRecord : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NullEventRecord class.
        /// </summary>
        public NullEventRecord() : base()
        {
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public StringValue? Time
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>objId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: objId</para>
        /// </summary>
        [SchemaAttr("objId")]
        public UInt32Value? ObjectId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p14:nullEvt");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<NullEventRecord>()
                .AddAttribute("time", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("objId", a => a.ObjectId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NullEventRecord>(deep);
    }

    /// <summary>
    /// Defines the TransitionPatternValues enumeration.
    /// </summary>
    public enum TransitionPatternValues
    {
        /// <summary>
        /// diamond.
        /// <para>When the item is serialized out as xml, its value is "diamond".</para>
        /// </summary>
        [EnumString("diamond")]
        Diamond,
        /// <summary>
        /// hexagon.
        /// <para>When the item is serialized out as xml, its value is "hexagon".</para>
        /// </summary>
        [EnumString("hexagon")]
        Hexagon
    }

    /// <summary>
    /// Defines the TransitionCenterDirectionTypeValues enumeration.
    /// </summary>
    public enum TransitionCenterDirectionTypeValues
    {
        /// <summary>
        /// center.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center
    }

    /// <summary>
    /// Defines the TransitionShredPatternValues enumeration.
    /// </summary>
    public enum TransitionShredPatternValues
    {
        /// <summary>
        /// strip.
        /// <para>When the item is serialized out as xml, its value is "strip".</para>
        /// </summary>
        [EnumString("strip")]
        Strip,
        /// <summary>
        /// rectangle.
        /// <para>When the item is serialized out as xml, its value is "rectangle".</para>
        /// </summary>
        [EnumString("rectangle")]
        Rectangle
    }

    /// <summary>
    /// Defines the TransitionLeftRightDirectionTypeValues enumeration.
    /// </summary>
    public enum TransitionLeftRightDirectionTypeValues
    {
        /// <summary>
        /// l.
        /// <para>When the item is serialized out as xml, its value is "l".</para>
        /// </summary>
        [EnumString("l")]
        Left,
        /// <summary>
        /// r.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        Right
    }
}