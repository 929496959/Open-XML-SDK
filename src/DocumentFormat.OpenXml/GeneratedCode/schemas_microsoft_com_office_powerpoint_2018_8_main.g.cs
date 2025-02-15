﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.PowerPoint.Comment
{
    /// <summary>
    /// <para>Defines the TextBodyType Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:txBody.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.BodyProperties" /> <c>&lt;a:bodyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.ListStyle" /> <c>&lt;a:lstStyle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Drawing.Paragraph" /> <c>&lt;a:p></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:txBody")]
    public partial class TextBodyType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextBodyType class.
        /// </summary>
        public TextBodyType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextBodyType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextBodyType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextBodyType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:txBody");
            builder.Availability = FileFormatVersions.Office2021;
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextBodyType>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Presentation.Extension" /> <c>&lt;p:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:extLst")]
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
            builder.SetSchema("p188:extLst");
            builder.Availability = FileFormatVersions.Office2021;
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
    /// <para>Defines the CommentUnknownAnchor Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:unknownAnchor.</para>
    /// </summary>
    [SchemaAttr("p188:unknownAnchor")]
    public partial class CommentUnknownAnchor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentUnknownAnchor class.
        /// </summary>
        public CommentUnknownAnchor() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:unknownAnchor");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentUnknownAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the AuthorList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:authorLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Author" /> <c>&lt;p188:author></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:authorLst")]
    public partial class AuthorList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the AuthorList class.
        /// </summary>
        public AuthorList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AuthorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AuthorList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AuthorList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AuthorList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AuthorList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AuthorList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:authorLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Author>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Author), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AuthorList>(deep);

        internal AuthorList(PowerPointAuthorsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the PowerPointAuthorsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(PowerPointAuthorsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the PowerPointAuthorsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(PowerPointAuthorsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the PowerPointAuthorsPart associated with this element.
        /// </summary>
        public PowerPointAuthorsPart? PowerPointAuthorsPart
        {
            get => OpenXmlPart as PowerPointAuthorsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the CommentList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:cmLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Comment" /> <c>&lt;p188:cm></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:cmLst")]
    public partial class CommentList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentList class.
        /// </summary>
        public CommentList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:cmLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Comment>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Comment), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentList>(deep);

        internal CommentList(PowerPointCommentPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the PowerPointCommentPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(PowerPointCommentPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the PowerPointCommentPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(PowerPointCommentPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the PowerPointCommentPart associated with this element.
        /// </summary>
        public PowerPointCommentPart? PowerPointCommentPart
        {
            get => OpenXmlPart as PowerPointCommentPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the CommentRelationship Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:commentRel.</para>
    /// </summary>
    [SchemaAttr("p188:commentRel")]
    public partial class CommentRelationship : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentRelationship class.
        /// </summary>
        public CommentRelationship() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
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
            builder.SetSchema("p188:commentRel");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<CommentRelationship>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentRelationship>(deep);
    }

    /// <summary>
    /// <para>Defines the Author Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:author.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList" /> <c>&lt;p188:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:author")]
    public partial class Author : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Author class.
        /// </summary>
        public Author() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Author class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Author(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Author class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Author(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Author class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Author(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>initials, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: initials</para>
        /// </summary>
        [SchemaAttr("initials")]
        public StringValue? Initials
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: userId</para>
        /// </summary>
        [SchemaAttr("userId")]
        public StringValue? UserId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>providerId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: providerId</para>
        /// </summary>
        [SchemaAttr("providerId")]
        public StringValue? ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:author");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList>();
            builder.AddElement<Author>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("initials", a => a.Initials)
                .AddAttribute("userId", a => a.UserId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("providerId", a => a.ProviderId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p188:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p188 = http://schemas.microsoft.com/office/powerpoint/2018/8/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Author>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentReply Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:reply.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType" /> <c>&lt;p188:txBody></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList" /> <c>&lt;p188:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:reply")]
    public partial class CommentReply : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentReply class.
        /// </summary>
        public CommentReply() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReply class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentReply(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReply class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentReply(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReply class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentReply(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>authorId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: authorId</para>
        /// </summary>
        [SchemaAttr("authorId")]
        public StringValue? AuthorId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>status, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: status</para>
        /// </summary>
        [SchemaAttr("status")]
        public EnumValue<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentStatus>? Status
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentStatus>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>created, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: created</para>
        /// </summary>
        [SchemaAttr("created")]
        public DateTimeValue? Created
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tags, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: tags</para>
        /// </summary>
        [SchemaAttr("tags")]
        public ListValue<StringValue>? Tags
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>likes, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: likes</para>
        /// </summary>
        [SchemaAttr("likes")]
        public ListValue<StringValue>? Likes
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:reply");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList>();
            builder.AddElement<CommentReply>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("authorId", a => a.AuthorId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("status", a => a.Status, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("created", a => a.Created, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("tags", a => a.Tags)
                .AddAttribute("likes", a => a.Likes);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2021)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType), 0, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
                    }
                }
            };
        }

        /// <summary>
        /// <para>TextBodyType.</para>
        /// <para>Represents the following element tag in the schema: p188:txBody.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p188 = http://schemas.microsoft.com/office/powerpoint/2018/8/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType? TextBodyType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: p188:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:p188 = http://schemas.microsoft.com/office/powerpoint/2018/8/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentReply>(deep);
    }

    /// <summary>
    /// <para>Defines the Point2DType Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:pos.</para>
    /// </summary>
    [SchemaAttr("p188:pos")]
    public partial class Point2DType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Point2DType class.
        /// </summary>
        public Point2DType() : base()
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
            builder.SetSchema("p188:pos");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<Point2DType>()
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Point2DType>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentReplyList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:replyLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentReply" /> <c>&lt;p188:reply></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:replyLst")]
    public partial class CommentReplyList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentReplyList class.
        /// </summary>
        public CommentReplyList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReplyList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentReplyList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReplyList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CommentReplyList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CommentReplyList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CommentReplyList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("p188:replyLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentReply>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentReply), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentReplyList>(deep);
    }

    /// <summary>
    /// <para>Defines the Comment Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is p188:cm.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Point2DType" /> <c>&lt;p188:pos></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType" /> <c>&lt;p188:txBody></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.DeMkLstDrawingElementMonikerList" /> <c>&lt;oac:deMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.TableCellMonikerList" /> <c>&lt;oac:tcMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.TableColumnMonikerList" /> <c>&lt;oac:gridColMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.TableRowMonikerList" /> <c>&lt;oac:trMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.TextBodyMonikerList" /> <c>&lt;oac:txBodyMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Drawing.Command.TextCharRangeMonikerList" /> <c>&lt;oac:txMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList" /> <c>&lt;p188:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentReplyList" /> <c>&lt;p188:replyLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentUnknownAnchor" /> <c>&lt;p188:unknownAnchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Presentation.Command.MainMasterMonikerList" /> <c>&lt;pc:sldMasterMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideLayoutMonikerList" /> <c>&lt;pc:sldLayoutMkLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList" /> <c>&lt;pc:sldMkLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("p188:cm")]
    public partial class Comment : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Comment class.
        /// </summary>
        public Comment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comment(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comment(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comment class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Comment(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>authorId, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: authorId</para>
        /// </summary>
        [SchemaAttr("authorId")]
        public StringValue? AuthorId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>status, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: status</para>
        /// </summary>
        [SchemaAttr("status")]
        public EnumValue<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentStatus>? Status
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentStatus>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>created, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: created</para>
        /// </summary>
        [SchemaAttr("created")]
        public DateTimeValue? Created
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tags, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: tags</para>
        /// </summary>
        [SchemaAttr("tags")]
        public ListValue<StringValue>? Tags
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>likes, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: likes</para>
        /// </summary>
        [SchemaAttr("likes")]
        public ListValue<StringValue>? Likes
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>startDate, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: startDate</para>
        /// </summary>
        [SchemaAttr("startDate")]
        public DateTimeValue? StartDate
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dueDate, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: dueDate</para>
        /// </summary>
        [SchemaAttr("dueDate")]
        public DateTimeValue? DueDate
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>assignedTo, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: assignedTo</para>
        /// </summary>
        [SchemaAttr("assignedTo")]
        public ListValue<StringValue>? AssignedTo
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>complete, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: complete</para>
        /// </summary>
        [SchemaAttr("complete")]
        public Int32Value? Complete
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>priority, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: priority</para>
        /// </summary>
        [SchemaAttr("priority")]
        public UInt32Value? Priority
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2021 and later.</para>
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
            builder.SetSchema("p188:cm");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Point2DType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.DeMkLstDrawingElementMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.TableCellMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.TableColumnMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.TableRowMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.TextBodyMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Drawing.Command.TextCharRangeMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentReplyList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentUnknownAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Presentation.Command.MainMasterMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideLayoutMonikerList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList>();
            builder.AddElement<Comment>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("authorId", a => a.AuthorId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("status", a => a.Status, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("created", a => a.Created, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("tags", a => a.Tags)
                .AddAttribute("likes", a => a.Likes)
                .AddAttribute("startDate", a => a.StartDate)
                .AddAttribute("dueDate", a => a.DueDate)
                .AddAttribute("assignedTo", a => a.AssignedTo)
                .AddAttribute("complete", a => a.Complete, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100000L) });
                })
                .AddAttribute("priority", a => a.Priority, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
                })
                .AddAttribute("title", a => a.Title);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2021)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideMonikerList), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Presentation.Command.SlideLayoutMonikerList), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Presentation.Command.MainMasterMonikerList), 1, 1, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.DeMkLstDrawingElementMonikerList), 0, 0, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.TextBodyMonikerList), 0, 0, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.TextCharRangeMonikerList), 0, 0, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.TableCellMonikerList), 0, 0, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.TableRowMonikerList), 0, 0, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Drawing.Command.TableColumnMonikerList), 0, 0, version: FileFormatVersions.Office2016),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentUnknownAnchor), 1, 1, version: FileFormatVersions.Office2021)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.Point2DType), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.CommentReplyList), 0, 1, version: FileFormatVersions.Office2021),
                new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2021)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.TextBodyType), 0, 1, version: FileFormatVersions.Office2021),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.PowerPoint.Comment.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Comment>(deep);
    }

    /// <summary>
    /// Defines the CommentStatus enumeration.
    /// </summary>
    public enum CommentStatus
    {
        /// <summary>
        /// active.
        /// <para>When the item is serialized out as xml, its value is "active".</para>
        /// </summary>
        [EnumString("active")]
        Active,
        /// <summary>
        /// resolved.
        /// <para>When the item is serialized out as xml, its value is "resolved".</para>
        /// </summary>
        [EnumString("resolved")]
        Resolved,
        /// <summary>
        /// closed.
        /// <para>When the item is serialized out as xml, its value is "closed".</para>
        /// </summary>
        [EnumString("closed")]
        Closed
    }
}