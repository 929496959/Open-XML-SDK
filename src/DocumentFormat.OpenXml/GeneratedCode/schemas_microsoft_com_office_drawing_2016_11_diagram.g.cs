﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Drawing.Diagram11
{
    /// <summary>
    /// <para>Defines the NumberDiagramInfoList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1611:autoBuNodeInfoLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo" /> <c>&lt;dgm1611:autoBuNodeInfo></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dgm1611:autoBuNodeInfoLst")]
    public partial class NumberDiagramInfoList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfoList class.
        /// </summary>
        public NumberDiagramInfoList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfoList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberDiagramInfoList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfoList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberDiagramInfoList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfoList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumberDiagramInfoList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm1611:autoBuNodeInfoLst");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.NumberDiagramInfo), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberDiagramInfoList>(deep);
    }

    /// <summary>
    /// <para>Defines the DiagramAutoBullet Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1611:buPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.AutoNumberedBullet" /> <c>&lt;a:buAutoNum></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.PictureBullet" /> <c>&lt;a:buBlip></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.CharacterBullet" /> <c>&lt;a:buChar></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.NoBullet" /> <c>&lt;a:buNone></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dgm1611:buPr")]
    public partial class DiagramAutoBullet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DiagramAutoBullet class.
        /// </summary>
        public DiagramAutoBullet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramAutoBullet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramAutoBullet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramAutoBullet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DiagramAutoBullet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DiagramAutoBullet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DiagramAutoBullet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>prefix, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: prefix</para>
        /// </summary>
        [SchemaAttr("prefix")]
        public StringValue? AutoBulletPrefix
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>leadZeros, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: leadZeros</para>
        /// </summary>
        [SchemaAttr("leadZeros")]
        public BooleanValue? LeadZeros
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm1611:buPr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.PictureBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
            builder.AddChild<DocumentFormat.OpenXml.Drawing.NoBullet>();
            builder.AddElement<DiagramAutoBullet>()
                .AddAttribute("prefix", a => a.AutoBulletPrefix)
                .AddAttribute("leadZeros", a => a.LeadZeros);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.NoBullet), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.AutoNumberedBullet), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.CharacterBullet), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Drawing.PictureBullet), 1, 1)
                }
            };
        }

        /// <summary>
        /// <para>No Bullet.</para>
        /// <para>Represents the following element tag in the schema: a:buNone.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.NoBullet? NoBullet
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.NoBullet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Auto-Numbered Bullet.</para>
        /// <para>Represents the following element tag in the schema: a:buAutoNum.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.AutoNumberedBullet? AutoNumberedBullet
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.AutoNumberedBullet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Character Bullet.</para>
        /// <para>Represents the following element tag in the schema: a:buChar.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.CharacterBullet? CharacterBullet
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.CharacterBullet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Picture Bullet.</para>
        /// <para>Represents the following element tag in the schema: a:buBlip.</para>
        /// </summary>
        /// <remark>
        /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Drawing.PictureBullet? PictureBullet
        {
            get => GetElement<DocumentFormat.OpenXml.Drawing.PictureBullet>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DiagramAutoBullet>(deep);
    }

    /// <summary>
    /// <para>Defines the NumberDiagramInfo Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is dgm1611:autoBuNodeInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet" /> <c>&lt;dgm1611:buPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("dgm1611:autoBuNodeInfo")]
    public partial class NumberDiagramInfo : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfo class.
        /// </summary>
        public NumberDiagramInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberDiagramInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public NumberDiagramInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the NumberDiagramInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public NumberDiagramInfo(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>lvl, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: lvl</para>
        /// </summary>
        [SchemaAttr("lvl")]
        public UInt32Value? Lvl
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ptType, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ptType</para>
        /// </summary>
        [SchemaAttr("ptType")]
        public EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType>? PtType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.STorageType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("dgm1611:autoBuNodeInfo");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
            builder.AddElement<NumberDiagramInfo>()
                .AddAttribute("lvl", a => a.Lvl, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ptType", a => a.PtType, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>DiagramAutoBullet.</para>
        /// <para>Represents the following element tag in the schema: dgm1611:buPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:dgm1611 = http://schemas.microsoft.com/office/drawing/2016/11/diagram
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet? DiagramAutoBullet
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Drawing.Diagram11.DiagramAutoBullet>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NumberDiagramInfo>(deep);
    }

    /// <summary>
    /// Defines the STorageType enumeration.
    /// </summary>
    public enum STorageType
    {
        /// <summary>
        /// sibTrans.
        /// <para>When the item is serialized out as xml, its value is "sibTrans".</para>
        /// </summary>
        [EnumString("sibTrans")]
        SibTrans,
        /// <summary>
        /// parTrans.
        /// <para>When the item is serialized out as xml, its value is "parTrans".</para>
        /// </summary>
        [EnumString("parTrans")]
        ParTrans
    }
}