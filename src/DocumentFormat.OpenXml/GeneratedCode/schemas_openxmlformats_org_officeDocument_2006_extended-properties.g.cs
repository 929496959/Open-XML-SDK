﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.ExtendedProperties
{
    /// <summary>
    /// <para>Application Specific File Properties.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Properties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature" /> <c>&lt;ap:DigSig></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts" /> <c>&lt;ap:TitlesOfParts></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs" /> <c>&lt;ap:HeadingPairs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList" /> <c>&lt;ap:HLinks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop" /> <c>&lt;ap:ScaleCrop></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate" /> <c>&lt;ap:LinksUpToDate></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.SharedDocument" /> <c>&lt;ap:SharedDoc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged" /> <c>&lt;ap:HyperlinksChanged></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Pages" /> <c>&lt;ap:Pages></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Words" /> <c>&lt;ap:Words></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Characters" /> <c>&lt;ap:Characters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Lines" /> <c>&lt;ap:Lines></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Paragraphs" /> <c>&lt;ap:Paragraphs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Slides" /> <c>&lt;ap:Slides></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Notes" /> <c>&lt;ap:Notes></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.TotalTime" /> <c>&lt;ap:TotalTime></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides" /> <c>&lt;ap:HiddenSlides></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips" /> <c>&lt;ap:MMClips></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces" /> <c>&lt;ap:CharactersWithSpaces></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity" /> <c>&lt;ap:DocSecurity></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Template" /> <c>&lt;ap:Template></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Manager" /> <c>&lt;ap:Manager></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Company" /> <c>&lt;ap:Company></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat" /> <c>&lt;ap:PresentationFormat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase" /> <c>&lt;ap:HyperlinkBase></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.Application" /> <c>&lt;ap:Application></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion" /> <c>&lt;ap:AppVersion></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("ap:Properties")]
    public partial class Properties : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Properties class.
        /// </summary>
        public Properties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Properties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Properties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Properties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Properties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:Properties");
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.SharedDocument>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Pages>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Words>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Characters>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Lines>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Paragraphs>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Slides>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Notes>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.TotalTime>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Template>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Manager>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Company>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.Application>();
            builder.AddChild<DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.All, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Template), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Manager), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Company), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Pages), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Words), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Characters), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Lines), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Paragraphs), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Slides), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Notes), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.TotalTime), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.SharedDocument), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.Application), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity), 0, 1)
            };
        }

        /// <summary>
        /// <para>Name of Document Template.</para>
        /// <para>Represents the following element tag in the schema: ap:Template.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Template? Template
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Template>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Name of Manager.</para>
        /// <para>Represents the following element tag in the schema: ap:Manager.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Manager? Manager
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Manager>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Name of Company.</para>
        /// <para>Represents the following element tag in the schema: ap:Company.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Company? Company
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Company>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Pages.</para>
        /// <para>Represents the following element tag in the schema: ap:Pages.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Pages? Pages
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Pages>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Word Count.</para>
        /// <para>Represents the following element tag in the schema: ap:Words.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Words? Words
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Words>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Characters.</para>
        /// <para>Represents the following element tag in the schema: ap:Characters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Characters? Characters
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Characters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Intended Format of Presentation.</para>
        /// <para>Represents the following element tag in the schema: ap:PresentationFormat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat? PresentationFormat
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Lines.</para>
        /// <para>Represents the following element tag in the schema: ap:Lines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Lines? Lines
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Lines>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Paragraphs.</para>
        /// <para>Represents the following element tag in the schema: ap:Paragraphs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Paragraphs? Paragraphs
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Paragraphs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Slides Metadata Element.</para>
        /// <para>Represents the following element tag in the schema: ap:Slides.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Slides? Slides
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Slides>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Slides Containing Notes.</para>
        /// <para>Represents the following element tag in the schema: ap:Notes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Notes? Notes
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Notes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Edit Time Metadata Element.</para>
        /// <para>Represents the following element tag in the schema: ap:TotalTime.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.TotalTime? TotalTime
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.TotalTime>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Hidden Slides.</para>
        /// <para>Represents the following element tag in the schema: ap:HiddenSlides.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides? HiddenSlides
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Total Number of Multimedia Clips.</para>
        /// <para>Represents the following element tag in the schema: ap:MMClips.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips? MultimediaClips
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Thumbnail Display Mode.</para>
        /// <para>Represents the following element tag in the schema: ap:ScaleCrop.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop? ScaleCrop
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Heading Pairs.</para>
        /// <para>Represents the following element tag in the schema: ap:HeadingPairs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs? HeadingPairs
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Part Titles.</para>
        /// <para>Represents the following element tag in the schema: ap:TitlesOfParts.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts? TitlesOfParts
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Links Up-to-Date.</para>
        /// <para>Represents the following element tag in the schema: ap:LinksUpToDate.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate? LinksUpToDate
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number of Characters (With Spaces).</para>
        /// <para>Represents the following element tag in the schema: ap:CharactersWithSpaces.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces? CharactersWithSpaces
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Shared Document.</para>
        /// <para>Represents the following element tag in the schema: ap:SharedDoc.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.SharedDocument? SharedDocument
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.SharedDocument>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Relative Hyperlink Base.</para>
        /// <para>Represents the following element tag in the schema: ap:HyperlinkBase.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase? HyperlinkBase
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlink List.</para>
        /// <para>Represents the following element tag in the schema: ap:HLinks.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? HyperlinkList
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Hyperlinks Changed.</para>
        /// <para>Represents the following element tag in the schema: ap:HyperlinksChanged.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged? HyperlinksChanged
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Digital Signature.</para>
        /// <para>Represents the following element tag in the schema: ap:DigSig.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature? DigitalSignature
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.DigitalSignature>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Name.</para>
        /// <para>Represents the following element tag in the schema: ap:Application.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.Application? Application
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.Application>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Application Version.</para>
        /// <para>Represents the following element tag in the schema: ap:AppVersion.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion? ApplicationVersion
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Document Security.</para>
        /// <para>Represents the following element tag in the schema: ap:DocSecurity.</para>
        /// </summary>
        /// <remark>
        /// xmlns:ap = http://schemas.openxmlformats.org/officeDocument/2006/extended-properties
        /// </remark>
        public DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity? DocumentSecurity
        {
            get => GetElement<DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Properties>(deep);

        internal Properties(ExtendedFilePropertiesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the ExtendedFilePropertiesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(ExtendedFilePropertiesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the ExtendedFilePropertiesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(ExtendedFilePropertiesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the ExtendedFilePropertiesPart associated with this element.
        /// </summary>
        public ExtendedFilePropertiesPart? ExtendedFilePropertiesPart
        {
            get => OpenXmlPart as ExtendedFilePropertiesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Name of Document Template.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Template.</para>
    /// </summary>
    [SchemaAttr("ap:Template")]
    public partial class Template : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Template class.
        /// </summary>
        public Template() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Template class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Template(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:Template");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Template>(deep);
    }

    /// <summary>
    /// <para>Name of Manager.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Manager.</para>
    /// </summary>
    [SchemaAttr("ap:Manager")]
    public partial class Manager : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Manager class.
        /// </summary>
        public Manager() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Manager class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Manager(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:Manager");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Manager>(deep);
    }

    /// <summary>
    /// <para>Name of Company.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Company.</para>
    /// </summary>
    [SchemaAttr("ap:Company")]
    public partial class Company : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Company class.
        /// </summary>
        public Company() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Company class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Company(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:Company");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Company>(deep);
    }

    /// <summary>
    /// <para>Intended Format of Presentation.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:PresentationFormat.</para>
    /// </summary>
    [SchemaAttr("ap:PresentationFormat")]
    public partial class PresentationFormat : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the PresentationFormat class.
        /// </summary>
        public PresentationFormat() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PresentationFormat class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public PresentationFormat(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:PresentationFormat");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PresentationFormat>(deep);
    }

    /// <summary>
    /// <para>Relative Hyperlink Base.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HyperlinkBase.</para>
    /// </summary>
    [SchemaAttr("ap:HyperlinkBase")]
    public partial class HyperlinkBase : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkBase class.
        /// </summary>
        public HyperlinkBase() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkBase class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HyperlinkBase(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:HyperlinkBase");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkBase>(deep);
    }

    /// <summary>
    /// <para>Application Name.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Application.</para>
    /// </summary>
    [SchemaAttr("ap:Application")]
    public partial class Application : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Application class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Application(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:Application");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Application>(deep);
    }

    /// <summary>
    /// <para>Application Version.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:AppVersion.</para>
    /// </summary>
    [SchemaAttr("ap:AppVersion")]
    public partial class ApplicationVersion : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationVersion class.
        /// </summary>
        public ApplicationVersion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationVersion class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ApplicationVersion(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:AppVersion");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ApplicationVersion>(deep);
    }

    /// <summary>
    /// <para>Total Number of Pages.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Pages.</para>
    /// </summary>
    [SchemaAttr("ap:Pages")]
    public partial class Pages : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Pages class.
        /// </summary>
        public Pages() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Pages class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Pages(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Pages");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Pages>(deep);
    }

    /// <summary>
    /// <para>Word Count.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Words.</para>
    /// </summary>
    [SchemaAttr("ap:Words")]
    public partial class Words : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Words class.
        /// </summary>
        public Words() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Words class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Words(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Words");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Words>(deep);
    }

    /// <summary>
    /// <para>Total Number of Characters.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Characters.</para>
    /// </summary>
    [SchemaAttr("ap:Characters")]
    public partial class Characters : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Characters class.
        /// </summary>
        public Characters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Characters class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Characters(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Characters");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Characters>(deep);
    }

    /// <summary>
    /// <para>Number of Lines.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Lines.</para>
    /// </summary>
    [SchemaAttr("ap:Lines")]
    public partial class Lines : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Lines class.
        /// </summary>
        public Lines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Lines class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Lines(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Lines");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Lines>(deep);
    }

    /// <summary>
    /// <para>Total Number of Paragraphs.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Paragraphs.</para>
    /// </summary>
    [SchemaAttr("ap:Paragraphs")]
    public partial class Paragraphs : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Paragraphs class.
        /// </summary>
        public Paragraphs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Paragraphs class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Paragraphs(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Paragraphs");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Paragraphs>(deep);
    }

    /// <summary>
    /// <para>Slides Metadata Element.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Slides.</para>
    /// </summary>
    [SchemaAttr("ap:Slides")]
    public partial class Slides : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Slides class.
        /// </summary>
        public Slides() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Slides class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Slides(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Slides");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Slides>(deep);
    }

    /// <summary>
    /// <para>Number of Slides Containing Notes.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:Notes.</para>
    /// </summary>
    [SchemaAttr("ap:Notes")]
    public partial class Notes : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Notes class.
        /// </summary>
        public Notes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Notes class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Notes(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:Notes");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Notes>(deep);
    }

    /// <summary>
    /// <para>Total Edit Time Metadata Element.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:TotalTime.</para>
    /// </summary>
    [SchemaAttr("ap:TotalTime")]
    public partial class TotalTime : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the TotalTime class.
        /// </summary>
        public TotalTime() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TotalTime class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public TotalTime(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:TotalTime");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TotalTime>(deep);
    }

    /// <summary>
    /// <para>Number of Hidden Slides.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HiddenSlides.</para>
    /// </summary>
    [SchemaAttr("ap:HiddenSlides")]
    public partial class HiddenSlides : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HiddenSlides class.
        /// </summary>
        public HiddenSlides() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HiddenSlides class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HiddenSlides(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:HiddenSlides");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HiddenSlides>(deep);
    }

    /// <summary>
    /// <para>Total Number of Multimedia Clips.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:MMClips.</para>
    /// </summary>
    [SchemaAttr("ap:MMClips")]
    public partial class MultimediaClips : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the MultimediaClips class.
        /// </summary>
        public MultimediaClips() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MultimediaClips class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public MultimediaClips(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:MMClips");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MultimediaClips>(deep);
    }

    /// <summary>
    /// <para>Number of Characters (With Spaces).</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:CharactersWithSpaces.</para>
    /// </summary>
    [SchemaAttr("ap:CharactersWithSpaces")]
    public partial class CharactersWithSpaces : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the CharactersWithSpaces class.
        /// </summary>
        public CharactersWithSpaces() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CharactersWithSpaces class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public CharactersWithSpaces(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:CharactersWithSpaces");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CharactersWithSpaces>(deep);
    }

    /// <summary>
    /// <para>Document Security.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:DocSecurity.</para>
    /// </summary>
    [SchemaAttr("ap:DocSecurity")]
    public partial class DocumentSecurity : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the DocumentSecurity class.
        /// </summary>
        public DocumentSecurity() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSecurity class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public DocumentSecurity(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new Int32Value { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<Int32Value>(NumberValidator.Instance);
            builder.SetSchema("ap:DocSecurity");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentSecurity>(deep);
    }

    /// <summary>
    /// <para>Thumbnail Display Mode.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:ScaleCrop.</para>
    /// </summary>
    [SchemaAttr("ap:ScaleCrop")]
    public partial class ScaleCrop : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ScaleCrop class.
        /// </summary>
        public ScaleCrop() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ScaleCrop class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ScaleCrop(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema("ap:ScaleCrop");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ScaleCrop>(deep);
    }

    /// <summary>
    /// <para>Links Up-to-Date.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:LinksUpToDate.</para>
    /// </summary>
    [SchemaAttr("ap:LinksUpToDate")]
    public partial class LinksUpToDate : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the LinksUpToDate class.
        /// </summary>
        public LinksUpToDate() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LinksUpToDate class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public LinksUpToDate(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema("ap:LinksUpToDate");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LinksUpToDate>(deep);
    }

    /// <summary>
    /// <para>Shared Document.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:SharedDoc.</para>
    /// </summary>
    [SchemaAttr("ap:SharedDoc")]
    public partial class SharedDocument : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SharedDocument class.
        /// </summary>
        public SharedDocument() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedDocument class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SharedDocument(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema("ap:SharedDoc");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedDocument>(deep);
    }

    /// <summary>
    /// <para>Hyperlinks Changed.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HyperlinksChanged.</para>
    /// </summary>
    [SchemaAttr("ap:HyperlinksChanged")]
    public partial class HyperlinksChanged : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinksChanged class.
        /// </summary>
        public HyperlinksChanged() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinksChanged class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public HyperlinksChanged(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new BooleanValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<BooleanValue>(NumberValidator.Instance);
            builder.SetSchema("ap:HyperlinksChanged");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinksChanged>(deep);
    }

    /// <summary>
    /// <para>Heading Pairs.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HeadingPairs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.VariantTypes.VTVector" /> <c>&lt;vt:vector></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("ap:HeadingPairs")]
    public partial class HeadingPairs : VectorVariantType
    {
        /// <summary>
        /// Initializes a new instance of the HeadingPairs class.
        /// </summary>
        public HeadingPairs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeadingPairs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeadingPairs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeadingPairs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HeadingPairs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HeadingPairs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HeadingPairs(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:HeadingPairs");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HeadingPairs>(deep);
    }

    /// <summary>
    /// <para>Hyperlink List.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:HLinks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.VariantTypes.VTVector" /> <c>&lt;vt:vector></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("ap:HLinks")]
    public partial class HyperlinkList : VectorVariantType
    {
        /// <summary>
        /// Initializes a new instance of the HyperlinkList class.
        /// </summary>
        public HyperlinkList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public HyperlinkList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the HyperlinkList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public HyperlinkList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:HLinks");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HyperlinkList>(deep);
    }

    /// <summary>
    /// <para>Defines the VectorVariantType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.VariantTypes.VTVector" /> <c>&lt;vt:vector></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class VectorVariantType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the VectorVariantType class.
        /// </summary>
        protected VectorVariantType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the VectorVariantType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected VectorVariantType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VectorVariantType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected VectorVariantType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the VectorVariantType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected VectorVariantType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
        }

        /// <summary>
        /// <para>Vector.</para>
        /// <para>Represents the following element tag in the schema: vt:vector.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTVector? VTVector
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Part Titles.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:TitlesOfParts.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.VariantTypes.VTVector" /> <c>&lt;vt:vector></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("ap:TitlesOfParts")]
    public partial class TitlesOfParts : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TitlesOfParts class.
        /// </summary>
        public TitlesOfParts() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlesOfParts class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlesOfParts(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlesOfParts class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlesOfParts(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlesOfParts class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TitlesOfParts(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:TitlesOfParts");
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTVector), 1, 1)
            };
        }

        /// <summary>
        /// <para>Vector.</para>
        /// <para>Represents the following element tag in the schema: vt:vector.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTVector? VTVector
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTVector>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitlesOfParts>(deep);
    }

    /// <summary>
    /// <para>Digital Signature.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is ap:DigSig.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.VariantTypes.VTBlob" /> <c>&lt;vt:blob></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("ap:DigSig")]
    public partial class DigitalSignature : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DigitalSignature class.
        /// </summary>
        public DigitalSignature() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DigitalSignature class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DigitalSignature(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DigitalSignature class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DigitalSignature(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DigitalSignature class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DigitalSignature(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("ap:DigSig");
            builder.AddChild<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.VariantTypes.VTBlob), 1, 1)
            };
        }

        /// <summary>
        /// <para>Binary Blob.</para>
        /// <para>Represents the following element tag in the schema: vt:blob.</para>
        /// </summary>
        /// <remark>
        /// xmlns:vt = http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes
        /// </remark>
        public DocumentFormat.OpenXml.VariantTypes.VTBlob? VTBlob
        {
            get => GetElement<DocumentFormat.OpenXml.VariantTypes.VTBlob>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DigitalSignature>(deep);
    }
}