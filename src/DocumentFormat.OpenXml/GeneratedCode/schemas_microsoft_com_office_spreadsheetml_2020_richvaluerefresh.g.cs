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

namespace DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals
{
    /// <summary>
    /// <para>Defines the RichValueRefreshIntervals Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrvr:refreshIntervals.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals.RichValueRefreshInterval" /> <c>&lt;xlrvr:refreshInterval></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrvr:refreshIntervals")]
    public partial class RichValueRefreshIntervals : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueRefreshIntervals class.
        /// </summary>
        public RichValueRefreshIntervals() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueRefreshIntervals class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueRefreshIntervals(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueRefreshIntervals class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueRefreshIntervals(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueRefreshIntervals class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueRefreshIntervals(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrvr:refreshIntervals");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals.RichValueRefreshInterval>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.RichValueRefreshIntervals.RichValueRefreshInterval), 1, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueRefreshIntervals>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueRefreshInterval Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrvr:refreshInterval.</para>
    /// </summary>
    [SchemaAttr("xlrvr:refreshInterval")]
    public partial class RichValueRefreshInterval : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueRefreshInterval class.
        /// </summary>
        public RichValueRefreshInterval() : base()
        {
        }

        /// <summary>
        /// <para>resourceIdInt, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: resourceIdInt</para>
        /// </summary>
        [SchemaAttr("resourceIdInt")]
        public Int32Value? ResourceIdInt
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>resourceIdStr, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: resourceIdStr</para>
        /// </summary>
        [SchemaAttr("resourceIdStr")]
        public StringValue? ResourceIdStr
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>interval, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: interval</para>
        /// </summary>
        [SchemaAttr("interval")]
        public Int32Value? Interval
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrvr:refreshInterval");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<RichValueRefreshInterval>()
                .AddAttribute("resourceIdInt", a => a.ResourceIdInt)
                .AddAttribute("resourceIdStr", a => a.ResourceIdStr)
                .AddAttribute("interval", a => a.Interval, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueRefreshInterval>(deep);
    }
}