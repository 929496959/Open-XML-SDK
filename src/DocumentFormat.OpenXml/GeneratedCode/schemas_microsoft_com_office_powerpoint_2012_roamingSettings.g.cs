﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming
{
    /// <summary>
    /// <para>Defines the Key Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pRoam:key.</para>
    /// </summary>
    [SchemaAttr("pRoam:key")]
    public partial class Key : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Key class.
        /// </summary>
        public Key() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Key class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Key(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pRoam:key");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Key>(deep);
    }

    /// <summary>
    /// <para>Defines the Value Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pRoam:value.</para>
    /// </summary>
    [SchemaAttr("pRoam:value")]
    public partial class Value : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Value class.
        /// </summary>
        public Value() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Value(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pRoam:value");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Value>(deep);
    }

    /// <summary>
    /// <para>Defines the RoamingProperty Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is pRoam:props.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key" /> <c>&lt;pRoam:key></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Value" /> <c>&lt;pRoam:value></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("pRoam:props")]
    public partial class RoamingProperty : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RoamingProperty class.
        /// </summary>
        public RoamingProperty() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoamingProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoamingProperty(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoamingProperty class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RoamingProperty(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RoamingProperty class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RoamingProperty(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("pRoam:props");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Value>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Value), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>Key.</para>
        /// <para>Represents the following element tag in the schema: pRoam:key.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pRoam = http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key? Key
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Key>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Value.</para>
        /// <para>Represents the following element tag in the schema: pRoam:value.</para>
        /// </summary>
        /// <remark>
        /// xmlns:pRoam = http://schemas.microsoft.com/office/powerpoint/2012/roamingSettings
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Value? Value
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming.Value>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RoamingProperty>(deep);
    }
}