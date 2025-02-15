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

namespace DocumentFormat.OpenXml.Office2019.Drawing.SVG
{
    /// <summary>
    /// <para>Defines the SVGBlip Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is asvg:svgBlip.</para>
    /// </summary>
    [SchemaAttr("asvg:svgBlip")]
    public partial class SVGBlip : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SVGBlip class.
        /// </summary>
        public SVGBlip() : base()
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
            builder.SetSchema("asvg:svgBlip");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<SVGBlip>()
                .AddAttribute("r:embed", a => a.Embed)
                .AddAttribute("r:link", a => a.Link);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SVGBlip>(deep);
    }
}