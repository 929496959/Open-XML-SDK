﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments
{
    /// <summary>
    /// <para>Defines the PersonList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:personList.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList" /> <c>&lt;xltc:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Person" /> <c>&lt;xltc:person></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc:personList")]
    public partial class PersonList : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the PersonList class.
        /// </summary>
        public PersonList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersonList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PersonList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersonList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PersonList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersonList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PersonList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc:personList");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Person>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Person), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PersonList>(deep);

        internal PersonList(WorkbookPersonPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WorkbookPersonPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WorkbookPersonPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WorkbookPersonPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WorkbookPersonPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WorkbookPersonPart associated with this element.
        /// </summary>
        public WorkbookPersonPart? WorkbookPersonPart
        {
            get => OpenXmlPart as WorkbookPersonPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ThreadedComments Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:ThreadedComments.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList" /> <c>&lt;xltc:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComment" /> <c>&lt;xltc:threadedComment></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc:ThreadedComments")]
    public partial class ThreadedComments : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedComments class.
        /// </summary>
        public ThreadedComments() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComments(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComments(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComments class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadedComments(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc:ThreadedComments");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComment>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedComment), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedComments>(deep);

        internal ThreadedComments(WorksheetThreadedCommentsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WorksheetThreadedCommentsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WorksheetThreadedCommentsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WorksheetThreadedCommentsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WorksheetThreadedCommentsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WorksheetThreadedCommentsPart associated with this element.
        /// </summary>
        public WorksheetThreadedCommentsPart? WorksheetThreadedCommentsPart
        {
            get => OpenXmlPart as WorksheetThreadedCommentsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Person Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:person.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList" /> <c>&lt;xltc:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc:person")]
    public partial class Person : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Person class.
        /// </summary>
        public Person() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Person(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Person(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Person class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Person(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>displayName, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: displayName</para>
        /// </summary>
        [SchemaAttr("displayName")]
        public StringValue? DisplayName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: userId</para>
        /// </summary>
        [SchemaAttr("userId")]
        public StringValue? UserId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>providerId, this property is only available in Office 2019 and later.</para>
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
            builder.SetSchema("xltc:person");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList>();
            builder.AddElement<Person>()
                .AddAttribute("displayName", a => a.DisplayName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("userId", a => a.UserId)
                .AddAttribute("providerId", a => a.ProviderId);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xltc:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Person>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc:extLst")]
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
            builder.SetSchema("xltc:extLst");
            builder.Availability = FileFormatVersions.Office2019;
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

    /// <summary>
    /// <para>Defines the ThreadedComment Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:threadedComment.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList" /> <c>&lt;xltc:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentText" /> <c>&lt;xltc:text></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentMentions" /> <c>&lt;xltc:mentions></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc:threadedComment")]
    public partial class ThreadedComment : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedComment class.
        /// </summary>
        public ThreadedComment() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComment(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComment class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedComment(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedComment class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadedComment(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dT, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: dT</para>
        /// </summary>
        [SchemaAttr("dT")]
        public DateTimeValue? DT
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>personId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: personId</para>
        /// </summary>
        [SchemaAttr("personId")]
        public StringValue? PersonId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>parentId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: parentId</para>
        /// </summary>
        [SchemaAttr("parentId")]
        public StringValue? ParentId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>done, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: done</para>
        /// </summary>
        [SchemaAttr("done")]
        public BooleanValue? Done
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc:threadedComment");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentText>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentMentions>();
            builder.AddElement<ThreadedComment>()
                .AddAttribute("ref", a => a.Ref)
                .AddAttribute("dT", a => a.DT)
                .AddAttribute("personId", a => a.PersonId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("parentId", a => a.ParentId, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("done", a => a.Done);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentText), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentMentions), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>ThreadedCommentText.</para>
        /// <para>Represents the following element tag in the schema: xltc:text.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentText? ThreadedCommentText
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentText>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ThreadedCommentMentions.</para>
        /// <para>Represents the following element tag in the schema: xltc:mentions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentMentions? ThreadedCommentMentions
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ThreadedCommentMentions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xltc:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xltc = http://schemas.microsoft.com/office/spreadsheetml/2018/threadedcomments
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedComment>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadedCommentText Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:text.</para>
    /// </summary>
    [SchemaAttr("xltc:text")]
    public partial class ThreadedCommentText : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedCommentText class.
        /// </summary>
        public ThreadedCommentText() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentText class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ThreadedCommentText(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc:text");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedCommentText>(deep);
    }

    /// <summary>
    /// <para>Defines the ThreadedCommentMentions Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:mentions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Mention" /> <c>&lt;xltc:mention></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xltc:mentions")]
    public partial class ThreadedCommentMentions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class.
        /// </summary>
        public ThreadedCommentMentions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedCommentMentions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ThreadedCommentMentions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ThreadedCommentMentions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ThreadedCommentMentions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc:mentions");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Mention>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.Mention), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ThreadedCommentMentions>(deep);
    }

    /// <summary>
    /// <para>Defines the Mention Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xltc:mention.</para>
    /// </summary>
    [SchemaAttr("xltc:mention")]
    public partial class Mention : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Mention class.
        /// </summary>
        public Mention() : base()
        {
        }

        /// <summary>
        /// <para>mentionpersonId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: mentionpersonId</para>
        /// </summary>
        [SchemaAttr("mentionpersonId")]
        public StringValue? MentionpersonId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mentionId, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: mentionId</para>
        /// </summary>
        [SchemaAttr("mentionId")]
        public StringValue? MentionId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>startIndex, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: startIndex</para>
        /// </summary>
        [SchemaAttr("startIndex")]
        public UInt32Value? StartIndex
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>
        [SchemaAttr("length")]
        public UInt32Value? Length
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xltc:mention");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<Mention>()
                .AddAttribute("mentionpersonId", a => a.MentionpersonId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("mentionId", a => a.MentionId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("startIndex", a => a.StartIndex, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("length", a => a.Length, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Mention>(deep);
    }
}