﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2021.OfficeExtLst;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2021.DocumentTasks
{
    /// <summary>
    /// <para>Defines the Tasks Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Tasks.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList" /> <c>&lt;t:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.Task" /> <c>&lt;t:Task></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("t:Tasks")]
    public partial class Tasks : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Tasks class.
        /// </summary>
        public Tasks() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tasks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tasks(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tasks class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tasks(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tasks class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Tasks(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Tasks");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.Task>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.Task), 0, 0, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tasks>(deep);

        internal Tasks(DocumentTasksPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the DocumentTasksPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(DocumentTasksPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the DocumentTasksPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(DocumentTasksPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the DocumentTasksPart associated with this element.
        /// </summary>
        public DocumentTasksPart? DocumentTasksPart
        {
            get => OpenXmlPart as DocumentTasksPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Task Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Task.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList" /> <c>&lt;t:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor" /> <c>&lt;t:Anchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory" /> <c>&lt;t:History></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("t:Task")]
    public partial class Task : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Task class.
        /// </summary>
        public Task() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Task class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Task(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Task class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Task(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Task class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Task(string outerXml) : base(outerXml)
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Task");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory>();
            builder.AddElement<Task>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>TaskAnchor.</para>
        /// <para>Represents the following element tag in the schema: t:Anchor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? TaskAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TaskHistory.</para>
        /// <para>Represents the following element tag in the schema: t:History.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory? TaskHistory
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistory>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: t:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Task>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension" /> <c>&lt;oel:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("t:extLst")]
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
            builder.SetSchema("t:extLst");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.OfficeExtLst.Extension), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskAnchor Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Anchor.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList" /> <c>&lt;t:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor" /> <c>&lt;t:Comment></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("t:Anchor")]
    public partial class TaskAnchor : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskAnchor class.
        /// </summary>
        public TaskAnchor() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskAnchor(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskAnchor class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskAnchor(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskAnchor class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskAnchor(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Anchor");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor), 0, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>CommentAnchor.</para>
        /// <para>Represents the following element tag in the schema: t:Comment.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor? CommentAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.CommentAnchor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: t:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskHistory Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:History.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent" /> <c>&lt;t:Event></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("t:History")]
    public partial class TaskHistory : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskHistory class.
        /// </summary>
        public TaskHistory() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistory(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistory(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistory class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskHistory(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:History");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskHistoryEvent), 0, 0, version: FileFormatVersions.Office2021)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistory>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskHistoryEvent Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Event.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList" /> <c>&lt;t:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor" /> <c>&lt;t:Anchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo" /> <c>&lt;t:Create></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo" /> <c>&lt;t:Delete></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo" /> <c>&lt;t:Priority></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo" /> <c>&lt;t:Progress></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo" /> <c>&lt;t:Schedule></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo" /> <c>&lt;t:SetTitle></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll" /> <c>&lt;t:UnassignAll></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo" /> <c>&lt;t:Undelete></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo" /> <c>&lt;t:Undo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser" /> <c>&lt;t:Attribution></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.AssignTaskUser" /> <c>&lt;t:Assign></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2021.DocumentTasks.UnassignTaskUser" /> <c>&lt;t:Unassign></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("t:Event")]
    public partial class TaskHistoryEvent : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class.
        /// </summary>
        public TaskHistoryEvent() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistoryEvent(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskHistoryEvent(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskHistoryEvent class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskHistoryEvent(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public DateTimeValue? Time
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Event");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.AssignTaskUser>();
            builder.AddChild<DocumentFormat.OpenXml.Office2021.DocumentTasks.UnassignTaskUser>();
            builder.AddElement<TaskHistoryEvent>()
                .AddAttribute("time", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser), 1, 1, version: FileFormatVersions.Office2021),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor), 0, 1, version: FileFormatVersions.Office2021),
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.AssignTaskUser), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.UnassignTaskUser), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskCreateEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskTitleEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskScheduleEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskPriorityEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskDeleteEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndeleteEventInfo), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUnassignAll), 1, 1, version: FileFormatVersions.Office2021),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskUndo), 1, 1, version: FileFormatVersions.Office2021)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2021.DocumentTasks.ExtensionList), 0, 1, version: FileFormatVersions.Office2021)
            };
        }

        /// <summary>
        /// <para>AttributionTaskUser.</para>
        /// <para>Represents the following element tag in the schema: t:Attribution.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser? AttributionTaskUser
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.AttributionTaskUser>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TaskAnchor.</para>
        /// <para>Represents the following element tag in the schema: t:Anchor.</para>
        /// </summary>
        /// <remark>
        /// xmlns:t = http://schemas.microsoft.com/office/tasks/2019/documenttasks
        /// </remark>
        public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor? TaskAnchor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskAnchor>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskHistoryEvent>(deep);
    }

    /// <summary>
    /// <para>Defines the AttributionTaskUser Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Attribution.</para>
    /// </summary>
    [SchemaAttr("t:Attribution")]
    public partial class AttributionTaskUser : OpenXmlTaskUserElement
    {
        /// <summary>
        /// Initializes a new instance of the AttributionTaskUser class.
        /// </summary>
        public AttributionTaskUser() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Attribution");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AttributionTaskUser>(deep);
    }

    /// <summary>
    /// <para>Defines the AssignTaskUser Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Assign.</para>
    /// </summary>
    [SchemaAttr("t:Assign")]
    public partial class AssignTaskUser : OpenXmlTaskUserElement
    {
        /// <summary>
        /// Initializes a new instance of the AssignTaskUser class.
        /// </summary>
        public AssignTaskUser() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Assign");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AssignTaskUser>(deep);
    }

    /// <summary>
    /// <para>Defines the UnassignTaskUser Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Unassign.</para>
    /// </summary>
    [SchemaAttr("t:Unassign")]
    public partial class UnassignTaskUser : OpenXmlTaskUserElement
    {
        /// <summary>
        /// Initializes a new instance of the UnassignTaskUser class.
        /// </summary>
        public UnassignTaskUser() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Unassign");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnassignTaskUser>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlTaskUserElement Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class OpenXmlTaskUserElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlTaskUserElement class.
        /// </summary>
        protected OpenXmlTaskUserElement() : base()
        {
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
        /// <para>userName, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: userName</para>
        /// </summary>
        [SchemaAttr("userName")]
        public StringValue? UserName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userProvider, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: userProvider</para>
        /// </summary>
        [SchemaAttr("userProvider")]
        public StringValue? UserProvider
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<OpenXmlTaskUserElement>()
                .AddAttribute("userId", a => a.UserId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("userName", a => a.UserName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("userProvider", a => a.UserProvider, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }

    /// <summary>
    /// <para>Defines the TaskCreateEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Create.</para>
    /// </summary>
    [SchemaAttr("t:Create")]
    public partial class TaskCreateEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskCreateEventInfo class.
        /// </summary>
        public TaskCreateEventInfo() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Create");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskCreateEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskTitleEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:SetTitle.</para>
    /// </summary>
    [SchemaAttr("t:SetTitle")]
    public partial class TaskTitleEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskTitleEventInfo class.
        /// </summary>
        public TaskTitleEventInfo() : base()
        {
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
            builder.SetSchema("t:SetTitle");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskTitleEventInfo>()
                .AddAttribute("title", a => a.Title, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskTitleEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskScheduleEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Schedule.</para>
    /// </summary>
    [SchemaAttr("t:Schedule")]
    public partial class TaskScheduleEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskScheduleEventInfo class.
        /// </summary>
        public TaskScheduleEventInfo() : base()
        {
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Schedule");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskScheduleEventInfo>()
                .AddAttribute("startDate", a => a.StartDate)
                .AddAttribute("dueDate", a => a.DueDate);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskScheduleEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskProgressEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Progress.</para>
    /// </summary>
    [SchemaAttr("t:Progress")]
    public partial class TaskProgressEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskProgressEventInfo class.
        /// </summary>
        public TaskProgressEventInfo() : base()
        {
        }

        /// <summary>
        /// <para>percentComplete, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: percentComplete</para>
        /// </summary>
        [SchemaAttr("percentComplete")]
        public Int32Value? PercentComplete
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Progress");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskProgressEventInfo>()
                .AddAttribute("percentComplete", a => a.PercentComplete, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (100L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskProgressEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskPriorityEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Priority.</para>
    /// </summary>
    [SchemaAttr("t:Priority")]
    public partial class TaskPriorityEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskPriorityEventInfo class.
        /// </summary>
        public TaskPriorityEventInfo() : base()
        {
        }

        /// <summary>
        /// <para>value, this property is only available in Office 2021 and later.</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public Int32Value? Value
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Priority");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskPriorityEventInfo>()
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (10L) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskPriorityEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskDeleteEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Delete.</para>
    /// </summary>
    [SchemaAttr("t:Delete")]
    public partial class TaskDeleteEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskDeleteEventInfo class.
        /// </summary>
        public TaskDeleteEventInfo() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Delete");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskDeleteEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskUndeleteEventInfo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Undelete.</para>
    /// </summary>
    [SchemaAttr("t:Undelete")]
    public partial class TaskUndeleteEventInfo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskUndeleteEventInfo class.
        /// </summary>
        public TaskUndeleteEventInfo() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Undelete");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskUndeleteEventInfo>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskUnassignAll Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:UnassignAll.</para>
    /// </summary>
    [SchemaAttr("t:UnassignAll")]
    public partial class TaskUnassignAll : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskUnassignAll class.
        /// </summary>
        public TaskUnassignAll() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:UnassignAll");
            builder.Availability = FileFormatVersions.Office2021;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskUnassignAll>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskUndo Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Undo.</para>
    /// </summary>
    [SchemaAttr("t:Undo")]
    public partial class TaskUndo : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskUndo class.
        /// </summary>
        public TaskUndo() : base()
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Undo");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<TaskUndo>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskUndo>(deep);
    }

    /// <summary>
    /// <para>Defines the CommentAnchor Class.</para>
    /// <para>This class is available in Office 2021 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is t:Comment.</para>
    /// </summary>
    [SchemaAttr("t:Comment")]
    public partial class CommentAnchor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CommentAnchor class.
        /// </summary>
        public CommentAnchor() : base()
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

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("t:Comment");
            builder.Availability = FileFormatVersions.Office2021;
            builder.AddElement<CommentAnchor>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CommentAnchor>(deep);
    }
}