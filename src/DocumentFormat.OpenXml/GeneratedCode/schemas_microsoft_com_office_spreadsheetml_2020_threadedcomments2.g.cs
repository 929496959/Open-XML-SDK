﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2
{
    /// <summary>
    /// <para>Defines the XsdunsignedInt Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc2:checksum.</para>
    /// </summary>
    [SchemaAttr("xltc2:checksum")]
    public partial class XsdunsignedInt : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the XsdunsignedInt class.
        /// </summary>
        public XsdunsignedInt() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the XsdunsignedInt class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public XsdunsignedInt(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new UInt32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<UInt32Value>(NumberValidator.Instance);
            builder.SetSchema("xltc2:checksum");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<XsdunsignedInt>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentHyperlink Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc2:hyperlink.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2.ExtensionList" /> <c>&lt;xltc2:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc2:hyperlink")]
    public partial class CommentHyperlink : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentHyperlink class.
        /// </summary>
        public CommentHyperlink() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentHyperlink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentHyperlink(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentHyperlink class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentHyperlink(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentHyperlink class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentHyperlink(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>startIndex, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: startIndex</para>
        /// </summary>
        [SchemaAttr("startIndex")]
        public UInt32Value? StartIndex
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>
        [SchemaAttr("length")]
        public UInt32Value? Length
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>url, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: url</para>
        /// </summary>
        [SchemaAttr("url")]
        public StringValue? Url
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc2:hyperlink");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2.ExtensionList>();
            builder.AddElement<CommentHyperlink>()
                .AddAttribute("startIndex", a => a.StartIndex, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("length", a => a.Length, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("url", a => a.Url, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xltc2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc2 = http://schemas.microsoft.com/office/spreadsheetml/2020/threadedcomments2
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.Excel.ThreadedComments2.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentHyperlink>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc2:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc2:extLst")]
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
            builder.SetSchema("xltc2:extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }
}