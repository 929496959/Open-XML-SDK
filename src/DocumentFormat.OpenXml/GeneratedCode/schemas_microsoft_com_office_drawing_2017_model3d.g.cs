﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2019.Drawing;
using DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Model3D
{
    /// <summary>
    /// <para>Defines the Model3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:model3d.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties" /> <c>&lt;am3d:spPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PictureAttributionSourceURL" /> <c>&lt;am3d:attrSrcUrl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.AmbientLight" /> <c>&lt;am3d:ambientLight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.DirectionalLight" /> <c>&lt;am3d:dirLight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera" /> <c>&lt;am3d:camera></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster" /> <c>&lt;am3d:raster></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform" /> <c>&lt;am3d:trans></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ObjectViewport" /> <c>&lt;am3d:objViewport></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight" /> <c>&lt;am3d:ptLight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SpotLight" /> <c>&lt;am3d:spotLight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UnknownLight" /> <c>&lt;am3d:unkLight></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.WindowViewport" /> <c>&lt;am3d:winViewport></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:model3d")]
    public partial class Model3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3D class.
        /// </summary>
        public Model3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3D(string outerXml) : base(outerXml)
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
            builder.SetSchema("am3d:model3d");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PictureAttributionSourceURL>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.AmbientLight>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.DirectionalLight>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ObjectViewport>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SpotLight>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UnknownLight>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.WindowViewport>();
            builder.AddElement<Model3D>()
                .AddAttribute("r:embed", a => a.Embed)
                .AddAttribute("r:link", a => a.Link);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PictureAttributionSourceURL), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList), 0, 1, version: FileFormatVersions.Office2019),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ObjectViewport), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.WindowViewport), 1, 1, version: FileFormatVersions.Office2019)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.AmbientLight), 0, 1, version: FileFormatVersions.Office2019),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PointLight), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SpotLight), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.DirectionalLight), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UnknownLight), 1, 1, version: FileFormatVersions.Office2019)
                }
            };
        }

        /// <summary>
        /// <para>ShapeProperties.</para>
        /// <para>Represents the following element tag in the schema: am3d:spPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties? ShapeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ShapeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Model3DCamera.</para>
        /// <para>Represents the following element tag in the schema: am3d:camera.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera? Model3DCamera
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DCamera>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Model3DTransform.</para>
        /// <para>Represents the following element tag in the schema: am3d:trans.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform? Model3DTransform
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DTransform>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Optional source attribution URL describes from whence the 3D model came..</para>
        /// <para>Represents the following element tag in the schema: am3d:attrSrcUrl.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PictureAttributionSourceURL? PictureAttributionSourceURL
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PictureAttributionSourceURL>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Model3DRaster.</para>
        /// <para>Represents the following element tag in the schema: am3d:raster.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster? Model3DRaster
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DRaster>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future Model3D extensions.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList? Model3DExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3D>(deep);
    }

    /// <summary>
    /// <para>Defines the SxRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sx.</para>
    /// </summary>
    [SchemaAttr("am3d:sx")]
    public partial class SxRatio : RatioType
    {
        /// <summary>
        /// Initializes a new instance of the SxRatio class.
        /// </summary>
        public SxRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:sx");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SxRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the SyRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sy.</para>
    /// </summary>
    [SchemaAttr("am3d:sy")]
    public partial class SyRatio : RatioType
    {
        /// <summary>
        /// Initializes a new instance of the SyRatio class.
        /// </summary>
        public SyRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:sy");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SyRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the SzRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sz.</para>
    /// </summary>
    [SchemaAttr("am3d:sz")]
    public partial class SzRatio : RatioType
    {
        /// <summary>
        /// Initializes a new instance of the SzRatio class.
        /// </summary>
        public SzRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:sz");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SzRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the RatioType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class RatioType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RatioType class.
        /// </summary>
        protected RatioType() : base()
        {
        }

        /// <summary>
        /// <para>Numerator</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public Int32Value? Numerator
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Denominator</para>
        /// <para>Represents the following attribute in the schema: d</para>
        /// </summary>
        [SchemaAttr("d")]
        public Int32Value? Denominator
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<RatioType>()
                .AddAttribute("n", a => a.Numerator, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("d", a => a.Denominator, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }

    /// <summary>
    /// <para>Defines the MeterPerModelUnitPositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:meterPerModelUnit.</para>
    /// </summary>
    [SchemaAttr("am3d:meterPerModelUnit")]
    public partial class MeterPerModelUnitPositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the MeterPerModelUnitPositiveRatio class.
        /// </summary>
        public MeterPerModelUnitPositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:meterPerModelUnit");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MeterPerModelUnitPositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the SzPositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:sz.</para>
    /// </summary>
    [SchemaAttr("am3d:sz")]
    public partial class SzPositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the SzPositiveRatio class.
        /// </summary>
        public SzPositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:sz");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SzPositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the IlluminancePositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:illuminance.</para>
    /// </summary>
    [SchemaAttr("am3d:illuminance")]
    public partial class IlluminancePositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the IlluminancePositiveRatio class.
        /// </summary>
        public IlluminancePositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:illuminance");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IlluminancePositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the IntensityPositiveRatio Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:intensity.</para>
    /// </summary>
    [SchemaAttr("am3d:intensity")]
    public partial class IntensityPositiveRatio : OpenXmlPositiveRatioElement
    {
        /// <summary>
        /// Initializes a new instance of the IntensityPositiveRatio class.
        /// </summary>
        public IntensityPositiveRatio() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:intensity");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<IntensityPositiveRatio>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlPositiveRatioElement Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlPositiveRatioElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPositiveRatioElement class.
        /// </summary>
        protected OpenXmlPositiveRatioElement() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public UInt64Value? N
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>d, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: d</para>
        /// </summary>
        [SchemaAttr("d")]
        public UInt64Value? D
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlPositiveRatioElement>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("d", a => a.D, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }

    /// <summary>
    /// <para>Defines the PreTransVector3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:preTrans.</para>
    /// </summary>
    [SchemaAttr("am3d:preTrans")]
    public partial class PreTransVector3D : Vector3DType
    {
        /// <summary>
        /// Initializes a new instance of the PreTransVector3D class.
        /// </summary>
        public PreTransVector3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:preTrans");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PreTransVector3D>(deep);
    }

    /// <summary>
    /// <para>Defines the PostTransVector3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:postTrans.</para>
    /// </summary>
    [SchemaAttr("am3d:postTrans")]
    public partial class PostTransVector3D : Vector3DType
    {
        /// <summary>
        /// Initializes a new instance of the PostTransVector3D class.
        /// </summary>
        public PostTransVector3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:postTrans");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PostTransVector3D>(deep);
    }

    /// <summary>
    /// <para>Defines the UpVector3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:up.</para>
    /// </summary>
    [SchemaAttr("am3d:up")]
    public partial class UpVector3D : Vector3DType
    {
        /// <summary>
        /// Initializes a new instance of the UpVector3D class.
        /// </summary>
        public UpVector3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:up");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UpVector3D>(deep);
    }

    /// <summary>
    /// <para>Defines the Vector3DType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class Vector3DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Vector3DType class.
        /// </summary>
        protected Vector3DType() : base()
        {
        }

        /// <summary>
        /// <para>Distance along X-axis in 3D</para>
        /// <para>Represents the following attribute in the schema: dx</para>
        /// </summary>
        [SchemaAttr("dx")]
        public Int64Value? Dx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance along Y-axis in 3D</para>
        /// <para>Represents the following attribute in the schema: dy</para>
        /// </summary>
        [SchemaAttr("dy")]
        public Int64Value? Dy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Distance along Z-axis in 3D</para>
        /// <para>Represents the following attribute in the schema: dz</para>
        /// </summary>
        [SchemaAttr("dz")]
        public Int64Value? Dz
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<Vector3DType>()
                .AddAttribute("dx", a => a.Dx, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("dy", a => a.Dy, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("dz", a => a.Dz, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                });
        }
    }

    /// <summary>
    /// <para>Defines the Scale3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:scale.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio" /> <c>&lt;am3d:sx></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio" /> <c>&lt;am3d:sy></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio" /> <c>&lt;am3d:sz></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:scale")]
    public partial class Scale3D : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Scale3D class.
        /// </summary>
        public Scale3D() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scale3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scale3D(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scale3D class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Scale3D(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Scale3D class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Scale3D(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:scale");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>SxRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sx.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio? SxRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SxRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SyRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sy.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio? SyRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SyRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SzRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio? SzRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzRatio>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Scale3D>(deep);
    }

    /// <summary>
    /// <para>Defines the Rotate3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:rot.</para>
    /// </summary>
    [SchemaAttr("am3d:rot")]
    public partial class Rotate3D : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Rotate3D class.
        /// </summary>
        public Rotate3D() : base()
        {
        }

        /// <summary>
        /// <para>ax, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ax</para>
        /// </summary>
        [SchemaAttr("ax")]
        public Int32Value? Ax
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ay, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ay</para>
        /// </summary>
        [SchemaAttr("ay")]
        public Int32Value? Ay
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>az, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: az</para>
        /// </summary>
        [SchemaAttr("az")]
        public Int32Value? Az
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:rot");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Rotate3D>()
                .AddAttribute("ax", a => a.Ax)
                .AddAttribute("ay", a => a.Ay)
                .AddAttribute("az", a => a.Az);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Rotate3D>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeArtExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Extension" /> <c>&lt;a:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:extLst")]
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
            builder.SetSchema("am3d:extLst");
            builder.Availability = FileFormatVersions.Office2019;
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
    /// <para>Defines the PosPoint3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:pos.</para>
    /// </summary>
    [SchemaAttr("am3d:pos")]
    public partial class PosPoint3D : OpenXmlPoint3DElement
    {
        /// <summary>
        /// Initializes a new instance of the PosPoint3D class.
        /// </summary>
        public PosPoint3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:pos");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PosPoint3D>(deep);
    }

    /// <summary>
    /// <para>Defines the LookAtPoint3D Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:lookAt.</para>
    /// </summary>
    [SchemaAttr("am3d:lookAt")]
    public partial class LookAtPoint3D : OpenXmlPoint3DElement
    {
        /// <summary>
        /// Initializes a new instance of the LookAtPoint3D class.
        /// </summary>
        public LookAtPoint3D() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:lookAt");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LookAtPoint3D>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlPoint3DElement Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlPoint3DElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPoint3DElement class.
        /// </summary>
        protected OpenXmlPoint3DElement() : base()
        {
        }

        /// <summary>
        /// <para>X-Coordinate in 3D</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [SchemaAttr("x")]
        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Y-Coordinate in 3D</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        [SchemaAttr("y")]
        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Z-Coordinate in 3D</para>
        /// <para>Represents the following attribute in the schema: z</para>
        /// </summary>
        [SchemaAttr("z")]
        public Int64Value? Z
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlPoint3DElement>()
                .AddAttribute("x", a => a.X, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("y", a => a.Y, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("z", a => a.Z, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                });
        }
    }

    /// <summary>
    /// <para>Defines the OrthographicProjection Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:orthographic.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzPositiveRatio" /> <c>&lt;am3d:sz></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:orthographic")]
    public partial class OrthographicProjection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class.
        /// </summary>
        public OrthographicProjection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OrthographicProjection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OrthographicProjection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OrthographicProjection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OrthographicProjection(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:orthographic");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzPositiveRatio>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzPositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>SzPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:sz.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzPositiveRatio? SzPositiveRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.SzPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OrthographicProjection>(deep);
    }

    /// <summary>
    /// <para>Defines the PerspectiveProjection Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:perspective.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:perspective")]
    public partial class PerspectiveProjection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class.
        /// </summary>
        public PerspectiveProjection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PerspectiveProjection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PerspectiveProjection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PerspectiveProjection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PerspectiveProjection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>fov, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: fov</para>
        /// </summary>
        [SchemaAttr("fov")]
        public Int32Value? Fov
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:perspective");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddElement<PerspectiveProjection>()
                .AddAttribute("fov", a => a.Fov, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10800000L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PerspectiveProjection>(deep);
    }

    /// <summary>
    /// <para>Defines the Blip Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:blip.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaBiLevel" /> <c>&lt;a:alphaBiLevel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaCeiling" /> <c>&lt;a:alphaCeiling></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaFloor" /> <c>&lt;a:alphaFloor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaInverse" /> <c>&lt;a:alphaInv></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaModulationEffect" /> <c>&lt;a:alphaMod></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaModulationFixed" /> <c>&lt;a:alphaModFix></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AlphaReplace" /> <c>&lt;a:alphaRepl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BiLevel" /> <c>&lt;a:biLevel></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BlipExtensionList" /> <c>&lt;a:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Blur" /> <c>&lt;a:blur></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ColorChange" /> <c>&lt;a:clrChange></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ColorReplacement" /> <c>&lt;a:clrRepl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Duotone" /> <c>&lt;a:duotone></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.FillOverlay" /> <c>&lt;a:fillOverlay></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Grayscale" /> <c>&lt;a:grayscl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Hsl" /> <c>&lt;a:hsl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.LuminanceEffect" /> <c>&lt;a:lum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.TintEffect" /> <c>&lt;a:tint></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:blip")]
    public partial class Blip : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Blip class.
        /// </summary>
        public Blip() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Blip class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Blip(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Blip class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Blip(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Blip class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Blip(string outerXml) : base(outerXml)
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

        /// <summary>
        /// <para>Compression state for blips.</para>
        /// <para>Represents the following attribute in the schema: cstate</para>
        /// </summary>
        [SchemaAttr("cstate")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>? CompressionState
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlipCompressionValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:blip");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaBiLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaCeiling>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaFloor>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaInverse>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulationEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaModulationFixed>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AlphaReplace>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BiLevel>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.BlipExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Blur>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ColorChange>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.ColorReplacement>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Duotone>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.FillOverlay>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Grayscale>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.Hsl>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.LuminanceEffect>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.TintEffect>();
            builder.AddElement<Blip>()
                .AddAttribute("r:embed", a => a.Embed)
                .AddAttribute("r:link", a => a.Link)
                .AddAttribute("cstate", a => a.CompressionState, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 0)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaBiLevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaCeiling), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaFloor), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaInverse), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationEffect), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AlphaReplace), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BiLevel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Blur), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ColorChange), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.ColorReplacement), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Duotone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.FillOverlay), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Grayscale), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.Hsl), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.LuminanceEffect), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.TintEffect), 1, 1)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.BlipExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Blip>(deep);
    }

    /// <summary>
    /// <para>Defines the ColorType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:clr.</para>
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
    [SchemaAttr("am3d:clr")]
    public partial class ColorType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColorType class.
        /// </summary>
        public ColorType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColorType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColorType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColorType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:clr");
            builder.Availability = FileFormatVersions.Office2019;
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColorType>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DExtension Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:ext.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation" /> <c>&lt;a3danim:embedAnim></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame" /> <c>&lt;a3danim:posterFrame></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:ext")]
    public partial class Model3DExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DExtension class.
        /// </summary>
        public Model3DExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>URI, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: uri</para>
        /// </summary>
        [SchemaAttr("uri")]
        public StringValue? Uri
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:ext");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame>();
            builder.AddElement<Model3DExtension>()
                .AddAttribute("uri", a => a.Uri, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.EmbeddedAnimation), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Animation.Model3D.PosterFrame), 1, 1, version: FileFormatVersions.Office2019),
                new AnyParticle(0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the ShapeProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:spPr.</para>
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
    [SchemaAttr("am3d:spPr")]
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
            builder.SetSchema("am3d:spPr");
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
    /// <para>Defines the Model3DCamera Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:camera.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D" /> <c>&lt;am3d:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D" /> <c>&lt;am3d:lookAt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D" /> <c>&lt;am3d:up></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OrthographicProjection" /> <c>&lt;am3d:orthographic></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PerspectiveProjection" /> <c>&lt;am3d:perspective></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:camera")]
    public partial class Model3DCamera : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DCamera class.
        /// </summary>
        public Model3DCamera() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DCamera class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DCamera(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DCamera class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DCamera(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DCamera class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DCamera(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:camera");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OrthographicProjection>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PerspectiveProjection>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OrthographicProjection), 1, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PerspectiveProjection), 1, 1, version: FileFormatVersions.Office2019)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D? PosPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>UpVector3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:up.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D? UpVector3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.UpVector3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LookAtPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:lookAt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D? LookAtPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DCamera>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DTransform Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:trans.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D" /> <c>&lt;am3d:preTrans></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D" /> <c>&lt;am3d:postTrans></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio" /> <c>&lt;am3d:meterPerModelUnit></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D" /> <c>&lt;am3d:rot></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D" /> <c>&lt;am3d:scale></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:trans")]
    public partial class Model3DTransform : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DTransform class.
        /// </summary>
        public Model3DTransform() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DTransform(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DTransform class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DTransform(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DTransform class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DTransform(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:trans");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>MeterPerModelUnitPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:meterPerModelUnit.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio? MeterPerModelUnitPositiveRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.MeterPerModelUnitPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PreTransVector3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:preTrans.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D? PreTransVector3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PreTransVector3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Scale3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:scale.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D? Scale3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Scale3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Rotate3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:rot.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D? Rotate3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Rotate3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PostTransVector3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:postTrans.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D? PostTransVector3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PostTransVector3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DTransform>(deep);
    }

    /// <summary>
    /// <para>Optional source attribution URL describes from whence the 3D model came..</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:attrSrcUrl.</para>
    /// </summary>
    [SchemaAttr("am3d:attrSrcUrl")]
    public partial class PictureAttributionSourceURL : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PictureAttributionSourceURL class.
        /// </summary>
        public PictureAttributionSourceURL() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: r:id</para>
        /// </summary>
        /// <remark>
        /// xmlns:r=http://schemas.openxmlformats.org/officeDocument/2006/relationships
        /// </remark>
        [SchemaAttr("r:id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:attrSrcUrl");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<PictureAttributionSourceURL>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PictureAttributionSourceURL>(deep);
    }

    /// <summary>
    /// <para>Defines the Model3DRaster Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:raster.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip" /> <c>&lt;am3d:blip></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:raster")]
    public partial class Model3DRaster : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DRaster class.
        /// </summary>
        public Model3DRaster() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DRaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DRaster(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DRaster class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DRaster(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DRaster class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DRaster(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rName, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rName</para>
        /// </summary>
        [SchemaAttr("rName")]
        public StringValue? RName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rVer, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rVer</para>
        /// </summary>
        [SchemaAttr("rVer")]
        public StringValue? RVer
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:raster");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip>();
            builder.AddElement<Model3DRaster>()
                .AddAttribute("rName", a => a.RName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("rVer", a => a.RVer, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>Blip.</para>
        /// <para>Represents the following element tag in the schema: am3d:blip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip? Blip
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Blip>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DRaster>(deep);
    }

    /// <summary>
    /// <para>Future Model3D extensions.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtension" /> <c>&lt;am3d:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:extLst")]
    public partial class Model3DExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class.
        /// </summary>
        public Model3DExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Model3DExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Model3DExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Model3DExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:extLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.Model3DExtension), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Model3DExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the ObjectViewport Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:objViewport.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:objViewport")]
    public partial class ObjectViewport : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ObjectViewport class.
        /// </summary>
        public ObjectViewport() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ObjectViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ObjectViewport(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ObjectViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ObjectViewport(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ObjectViewport class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ObjectViewport(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>viewportSz, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: viewportSz</para>
        /// </summary>
        [SchemaAttr("viewportSz")]
        public Int64Value? ViewportSz
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:objViewport");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddElement<ObjectViewport>()
                .AddAttribute("viewportSz", a => a.ViewportSz, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectViewport>(deep);
    }

    /// <summary>
    /// <para>Defines the WindowViewport Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:winViewport.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:winViewport")]
    public partial class WindowViewport : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WindowViewport class.
        /// </summary>
        public WindowViewport() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WindowViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WindowViewport(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WindowViewport class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WindowViewport(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WindowViewport class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WindowViewport(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:winViewport");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WindowViewport>(deep);
    }

    /// <summary>
    /// <para>Ambient light in a scene.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:ambientLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType" /> <c>&lt;am3d:clr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio" /> <c>&lt;am3d:illuminance></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:ambientLight")]
    public partial class AmbientLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AmbientLight class.
        /// </summary>
        public AmbientLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AmbientLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AmbientLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AmbientLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AmbientLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AmbientLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AmbientLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:ambientLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio>();
            builder.AddElement<AmbientLight>()
                .AddAttribute("enabled", a => a.Enabled);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType? ColorType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IlluminancePositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:illuminance.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio? IlluminancePositiveRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AmbientLight>(deep);
    }

    /// <summary>
    /// <para>Defines the PointLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:ptLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType" /> <c>&lt;am3d:clr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D" /> <c>&lt;am3d:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio" /> <c>&lt;am3d:intensity></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:ptLight")]
    public partial class PointLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PointLight class.
        /// </summary>
        public PointLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PointLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PointLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PointLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rad, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rad</para>
        /// </summary>
        [SchemaAttr("rad")]
        public Int64Value? Rad
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:ptLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio>();
            builder.AddElement<PointLight>()
                .AddAttribute("enabled", a => a.Enabled)
                .AddAttribute("rad", a => a.Rad, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType? ColorType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IntensityPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:intensity.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio? IntensityPositiveRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D? PosPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PointLight>(deep);
    }

    /// <summary>
    /// <para>Defines the SpotLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:spotLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType" /> <c>&lt;am3d:clr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D" /> <c>&lt;am3d:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D" /> <c>&lt;am3d:lookAt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio" /> <c>&lt;am3d:intensity></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:spotLight")]
    public partial class SpotLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SpotLight class.
        /// </summary>
        public SpotLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SpotLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SpotLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SpotLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SpotLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SpotLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SpotLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rad, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: rad</para>
        /// </summary>
        [SchemaAttr("rad")]
        public Int64Value? Rad
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>spotAng, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: spotAng</para>
        /// </summary>
        [SchemaAttr("spotAng")]
        public Int32Value? SpotAng
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:spotLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio>();
            builder.AddElement<SpotLight>()
                .AddAttribute("enabled", a => a.Enabled)
                .AddAttribute("rad", a => a.Rad, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                })
                .AddAttribute("spotAng", a => a.SpotAng, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10800000L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType? ColorType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IntensityPositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:intensity.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio? IntensityPositiveRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IntensityPositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D? PosPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LookAtPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:lookAt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D? LookAtPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SpotLight>(deep);
    }

    /// <summary>
    /// <para>Defines the DirectionalLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:dirLight.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType" /> <c>&lt;am3d:clr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList" /> <c>&lt;am3d:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D" /> <c>&lt;am3d:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D" /> <c>&lt;am3d:lookAt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio" /> <c>&lt;am3d:illuminance></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("am3d:dirLight")]
    public partial class DirectionalLight : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DirectionalLight class.
        /// </summary>
        public DirectionalLight() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectionalLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DirectionalLight(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectionalLight class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DirectionalLight(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectionalLight class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DirectionalLight(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>angularRad, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: angularRad</para>
        /// </summary>
        [SchemaAttr("angularRad")]
        public Int32Value? AngularRad
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:dirLight");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio>();
            builder.AddElement<DirectionalLight>()
                .AddAttribute("enabled", a => a.Enabled)
                .AddAttribute("angularRad", a => a.AngularRad, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (5400000L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ColorType.</para>
        /// <para>Represents the following element tag in the schema: am3d:clr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType? ColorType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.ColorType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>IlluminancePositiveRatio.</para>
        /// <para>Represents the following element tag in the schema: am3d:illuminance.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio? IlluminancePositiveRatio
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.IlluminancePositiveRatio>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PosPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:pos.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D? PosPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.PosPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LookAtPoint3D.</para>
        /// <para>Represents the following element tag in the schema: am3d:lookAt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D? LookAtPoint3D
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.LookAtPoint3D>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OfficeArtExtensionList.</para>
        /// <para>Represents the following element tag in the schema: am3d:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:am3d = http://schemas.microsoft.com/office/drawing/2017/model3d
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList? OfficeArtExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Model3D.OfficeArtExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DirectionalLight>(deep);
    }

    /// <summary>
    /// <para>Defines the UnknownLight Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is am3d:unkLight.</para>
    /// </summary>
    [SchemaAttr("am3d:unkLight")]
    public partial class UnknownLight : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnknownLight class.
        /// </summary>
        public UnknownLight() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("am3d:unkLight");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnknownLight>(deep);
    }
}