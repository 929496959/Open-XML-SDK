﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2016.Excel
{
    /// <summary>
    /// <para>Defines the RevExHeaders Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:revHdrs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExHeader" /> <c>&lt;xr:hdr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:revHdrs")]
    public partial class RevExHeaders : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExHeaders class.
        /// </summary>
        public RevExHeaders() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExHeaders class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExHeaders(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExHeaders class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExHeaders(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExHeaders class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExHeaders(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>minRev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: minRev</para>
        /// </summary>
        [SchemaAttr("minRev")]
        public UInt64Value? MinRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxRev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: maxRev</para>
        /// </summary>
        [SchemaAttr("maxRev")]
        public UInt64Value? MaxRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>docId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: docId</para>
        /// </summary>
        [SchemaAttr("docId")]
        public StringValue? DocId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endpointId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: endpointId</para>
        /// </summary>
        [SchemaAttr("endpointId")]
        public StringValue? EndpointId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:revHdrs");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExHeader>();
            builder.AddElement<RevExHeaders>()
                .AddAttribute("minRev", a => a.MinRev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("maxRev", a => a.MaxRev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("docId", a => a.DocId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("endpointId", a => a.EndpointId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExHeader), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExHeaders>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExStream Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:revStream.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell" /> <c>&lt;xr:xrrc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj" /> <c>&lt;xr:xrrco></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName" /> <c>&lt;xr:xrrDefName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj" /> <c>&lt;xr:xrrdo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting" /> <c>&lt;xr:xrrf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExFuture" /> <c>&lt;xr:xrrftr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExMove" /> <c>&lt;xr:xrrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn" /> <c>&lt;xr:xrrrc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp" /> <c>&lt;xr:xrrSheet></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed" /> <c>&lt;xr:xrrTrim></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported" /> <c>&lt;xr:xrrUspt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevGroup" /> <c>&lt;xr:xrrg></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevisionList" /> <c>&lt;xr:xrrList></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw" /> <c>&lt;xr:xrrListExpR></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:revStream")]
    public partial class RevExStream : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExStream class.
        /// </summary>
        public RevExStream() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExStream class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExStream(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExStream class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExStream(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExStream class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExStream(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:revStream");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExFuture>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExMove>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevisionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFuture), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExMove), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionList), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevGroup), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExStream>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialFormatType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:dxf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Border" /> <c>&lt;x:border></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Alignment" /> <c>&lt;x:alignment></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Protection" /> <c>&lt;x:protection></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Fill" /> <c>&lt;x:fill></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Font" /> <c>&lt;x:font></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.NumberingFormat" /> <c>&lt;x:numFmt></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:dxf")]
    public partial class DifferentialFormatType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class.
        /// </summary>
        public DifferentialFormatType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormatType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormatType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormatType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DifferentialFormatType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:dxf");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Border>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Alignment>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Protection>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Fill>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Font>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Font), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.NumberingFormat), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Fill), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Alignment), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Border), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Protection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Font Properties.</para>
        /// <para>Represents the following element tag in the schema: x:font.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Font? Font
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Font>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Number Format.</para>
        /// <para>Represents the following element tag in the schema: x:numFmt.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.NumberingFormat? NumberingFormat
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.NumberingFormat>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Fill.</para>
        /// <para>Represents the following element tag in the schema: x:fill.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Fill? Fill
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Fill>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Alignment.</para>
        /// <para>Represents the following element tag in the schema: x:alignment.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Alignment? Alignment
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Alignment>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Border Properties.</para>
        /// <para>Represents the following element tag in the schema: x:border.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Border? Border
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Border>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Protection Properties.</para>
        /// <para>Represents the following element tag in the schema: x:protection.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Protection? Protection
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Protection>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Future Feature Data Storage Area.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormatType>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionPtr Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:revisionPtr.</para>
    /// </summary>
    [SchemaAttr("xr:revisionPtr")]
    public partial class RevisionPtr : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionPtr class.
        /// </summary>
        public RevisionPtr() : base()
        {
        }

        /// <summary>
        /// <para>revIDLastSave, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: revIDLastSave</para>
        /// </summary>
        [SchemaAttr("revIDLastSave")]
        public UInt64Value? RevIDLastSave
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>documentId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: documentId</para>
        /// </summary>
        [SchemaAttr("documentId")]
        public StringValue? DocumentId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:revisionPtr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevisionPtr>()
                .AddAttribute("revIDLastSave", a => a.RevIDLastSave, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("documentId", a => a.DocumentId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionPtr>(deep);
    }

    /// <summary>
    /// <para>Defines the StateBasedObject Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:objectState.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.AutoFilter" /> <c>&lt;xr:autoFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.Comments" /> <c>&lt;xr:comments></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.DataValidation" /> <c>&lt;xr:dataValidation></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.Hyperlink" /> <c>&lt;xr:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition" /> <c>&lt;xr:pivotTableDefinition></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup" /> <c>&lt;xr:sparklineGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:objectState")]
    public partial class StateBasedObject : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StateBasedObject class.
        /// </summary>
        public StateBasedObject() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedObject(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedObject class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedObject(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedObject class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StateBasedObject(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:objectState");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.AutoFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.Comments>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.DataValidation>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.DataValidation), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Hyperlink), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Comments), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.AutoFilter), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>Represents an external link to another workbook..</para>
        /// <para>Represents the following element tag in the schema: xr:dataValidation.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.DataValidation? DataValidation
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.DataValidation>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents a hyperlink within a cell..</para>
        /// <para>Represents the following element tag in the schema: xr:hyperlink.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.Hyperlink? Hyperlink
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.Hyperlink>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents a sparkline group of 1 or more sparklines..</para>
        /// <para>Represents the following element tag in the schema: xr:sparklineGroup.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup? SparklineGroup
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.SparklineGroup>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents one comment within a cell..</para>
        /// <para>Represents the following element tag in the schema: xr:comments.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.Comments? Comments
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.Comments>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents an autofilter..</para>
        /// <para>Represents the following element tag in the schema: xr:autoFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.AutoFilter? AutoFilter
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.AutoFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Represents a PivotTable View..</para>
        /// <para>Represents the following element tag in the schema: xr:pivotTableDefinition.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition? pivotTableDefinition
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.pivotTableDefinition>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateBasedObject>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExHeader Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hdr.</para>
    /// </summary>
    [SchemaAttr("xr:hdr")]
    public partial class RevExHeader : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExHeader class.
        /// </summary>
        public RevExHeader() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
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

        /// <summary>
        /// <para>minRev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: minRev</para>
        /// </summary>
        [SchemaAttr("minRev")]
        public UInt64Value? MinRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxRev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: maxRev</para>
        /// </summary>
        [SchemaAttr("maxRev")]
        public UInt64Value? MaxRev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>time, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: time</para>
        /// </summary>
        [SchemaAttr("time")]
        public DateTimeValue? Time
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:hdr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExHeader>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("minRev", a => a.MinRev)
                .AddAttribute("maxRev", a => a.MaxRev)
                .AddAttribute("time", a => a.Time, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExHeader>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExFuture Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrftr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExTest" /> <c>&lt;xr:xrrtest></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrftr")]
    public partial class RevExFuture : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExFuture class.
        /// </summary>
        public RevExFuture() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFuture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFuture(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFuture class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFuture(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFuture class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExFuture(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sti, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sti</para>
        /// </summary>
        [SchemaAttr("sti")]
        public BooleanValue? Sti
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrftr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExTest>();
            builder.AddElement<RevExFuture>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("sti", a => a.Sti);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTest), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFuture>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExUnsupported Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrUspt.</para>
    /// </summary>
    [SchemaAttr("xr:xrrUspt")]
    public partial class RevExUnsupported : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExUnsupported class.
        /// </summary>
        public RevExUnsupported() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrUspt");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExUnsupported>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExUnsupported>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExTrimmed Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrTrim.</para>
    /// </summary>
    [SchemaAttr("xr:xrrTrim")]
    public partial class RevExTrimmed : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExTrimmed class.
        /// </summary>
        public RevExTrimmed() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrTrim");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExTrimmed>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExTrimmed>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExRowColumn Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrrc.</para>
    /// </summary>
    [SchemaAttr("xr:xrrrc")]
    public partial class RevExRowColumn : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExRowColumn class.
        /// </summary>
        public RevExRowColumn() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>eol, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: eol</para>
        /// </summary>
        [SchemaAttr("eol")]
        public BooleanValue? Eol
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>action, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: action</para>
        /// </summary>
        [SchemaAttr("action")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>? Action
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RwColAction>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrrc");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExRowColumn>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("eol", a => a.Eol)
                .AddAttribute("ref", a => a.Ref, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("action", a => a.Action, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExRowColumn>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExMove Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrm.</para>
    /// </summary>
    [SchemaAttr("xr:xrrm")]
    public partial class RevExMove : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExMove class.
        /// </summary>
        public RevExMove() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>src, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: src</para>
        /// </summary>
        [SchemaAttr("src")]
        public StringValue? Src
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dst, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: dst</para>
        /// </summary>
        [SchemaAttr("dst")]
        public StringValue? Dst
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>srcSh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: srcSh</para>
        /// </summary>
        [SchemaAttr("srcSh")]
        public StringValue? SrcSh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrm");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExMove>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("src", a => a.Src, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("dst", a => a.Dst, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("srcSh", a => a.SrcSh, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExMove>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExChangeCell Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrc.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.ChangeCellSubEdit" /> <c>&lt;xr:ccse></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevCell" /> <c>&lt;xr:c></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrc")]
    public partial class RevExChangeCell : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class.
        /// </summary>
        public RevExChangeCell() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChangeCell(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChangeCell(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChangeCell class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExChangeCell(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>listUid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: listUid</para>
        /// </summary>
        [SchemaAttr("listUid")]
        public StringValue? ListUid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public StringValue? R
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [SchemaAttr("x")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>? X
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>w, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        [SchemaAttr("w")]
        public UInt32Value? W
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrc");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.ChangeCellSubEdit>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevCell>();
            builder.AddElement<RevExChangeCell>()
                .AddAttribute("listUid", a => a.ListUid, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("r", a => a.R, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("t", a => a.T)
                .AddAttribute("x", a => a.X)
                .AddAttribute("w", a => a.W);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevCell), 1, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ChangeCellSubEdit), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExChangeCell>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExFormatting Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrf.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType" /> <c>&lt;xr:dxf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.ExtensionList" /> <c>&lt;xr:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrf")]
    public partial class RevExFormatting : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExFormatting class.
        /// </summary>
        public RevExFormatting() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFormatting(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFormatting class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExFormatting(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExFormatting class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExFormatting(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numFmtId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: numFmtId</para>
        /// </summary>
        [SchemaAttr("numFmtId")]
        public UInt32Value? NumFmtId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>xfDxf, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: xfDxf</para>
        /// </summary>
        [SchemaAttr("xfDxf")]
        public BooleanValue? XfDxf
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr("style")]
        public BooleanValue? Style
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sqref, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sqref</para>
        /// </summary>
        [SchemaAttr("sqref")]
        public ListValue<StringValue>? Sqref
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>start, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: start</para>
        /// </summary>
        [SchemaAttr("start")]
        public UInt32Value? Start
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>length, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: length</para>
        /// </summary>
        [SchemaAttr("length")]
        public UInt32Value? Length
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>styleUid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: styleUid</para>
        /// </summary>
        [SchemaAttr("styleUid")]
        public StringValue? StyleUid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fBlankCell, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: fBlankCell</para>
        /// </summary>
        [SchemaAttr("fBlankCell")]
        public BooleanValue? FBlankCell
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyNumberFormat, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: applyNumberFormat</para>
        /// </summary>
        [SchemaAttr("applyNumberFormat")]
        public BooleanValue? ApplyNumberFormat
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyFont, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: applyFont</para>
        /// </summary>
        [SchemaAttr("applyFont")]
        public BooleanValue? ApplyFont
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyFill, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: applyFill</para>
        /// </summary>
        [SchemaAttr("applyFill")]
        public BooleanValue? ApplyFill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyBorder, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: applyBorder</para>
        /// </summary>
        [SchemaAttr("applyBorder")]
        public BooleanValue? ApplyBorder
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyAlignment, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: applyAlignment</para>
        /// </summary>
        [SchemaAttr("applyAlignment")]
        public BooleanValue? ApplyAlignment
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>applyProtection, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: applyProtection</para>
        /// </summary>
        [SchemaAttr("applyProtection")]
        public BooleanValue? ApplyProtection
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrf");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.ExtensionList>();
            builder.AddElement<RevExFormatting>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("numFmtId", a => a.NumFmtId)
                .AddAttribute("xfDxf", a => a.XfDxf)
                .AddAttribute("style", a => a.Style)
                .AddAttribute("sqref", a => a.Sqref, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("start", a => a.Start)
                .AddAttribute("length", a => a.Length)
                .AddAttribute("styleUid", a => a.StyleUid, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("fBlankCell", a => a.FBlankCell)
                .AddAttribute("applyNumberFormat", a => a.ApplyNumberFormat)
                .AddAttribute("applyFont", a => a.ApplyFont)
                .AddAttribute("applyFill", a => a.ApplyFill)
                .AddAttribute("applyBorder", a => a.ApplyBorder)
                .AddAttribute("applyAlignment", a => a.ApplyAlignment)
                .AddAttribute("applyProtection", a => a.ApplyProtection);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>DifferentialFormatType.</para>
        /// <para>Represents the following element tag in the schema: xr:dxf.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType? DifferentialFormatType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.DifferentialFormatType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xr:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExFormatting>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExDefinedName Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrDefName.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.ExtensionList" /> <c>&lt;xr:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula" /> <c>&lt;xr:formula></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrDefName")]
    public partial class RevExDefinedName : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class.
        /// </summary>
        public RevExDefinedName() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDefinedName(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDefinedName(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDefinedName class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExDefinedName(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customView, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: customView</para>
        /// </summary>
        [SchemaAttr("customView")]
        public BooleanValue? CustomView
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>function, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: function</para>
        /// </summary>
        [SchemaAttr("function")]
        public BooleanValue? Function
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>functionGroupId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: functionGroupId</para>
        /// </summary>
        [SchemaAttr("functionGroupId")]
        public ByteValue? FunctionGroupId
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>shortcutKey, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: shortcutKey</para>
        /// </summary>
        [SchemaAttr("shortcutKey")]
        public ByteValue? ShortcutKey
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>hidden, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hidden</para>
        /// </summary>
        [SchemaAttr("hidden")]
        public BooleanValue? Hidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customMenu, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: customMenu</para>
        /// </summary>
        [SchemaAttr("customMenu")]
        public StringValue? CustomMenu
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>help, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: help</para>
        /// </summary>
        [SchemaAttr("help")]
        public StringValue? Help
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>statusBar, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: statusBar</para>
        /// </summary>
        [SchemaAttr("statusBar")]
        public StringValue? StatusBar
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>comment, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: comment</para>
        /// </summary>
        [SchemaAttr("comment")]
        public StringValue? Comment
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrDefName");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula>();
            builder.AddElement<RevExDefinedName>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("customView", a => a.CustomView)
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("function", a => a.Function)
                .AddAttribute("functionGroupId", a => a.FunctionGroupId)
                .AddAttribute("shortcutKey", a => a.ShortcutKey)
                .AddAttribute("hidden", a => a.Hidden)
                .AddAttribute("customMenu", a => a.CustomMenu)
                .AddAttribute("description", a => a.Description)
                .AddAttribute("help", a => a.Help)
                .AddAttribute("statusBar", a => a.StatusBar)
                .AddAttribute("comment", a => a.Comment);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>FormulaFormula.</para>
        /// <para>Represents the following element tag in the schema: xr:formula.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula? FormulaFormula
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.FormulaFormula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xr:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExDefinedName>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExDelObj Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrdo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader" /> <c>&lt;xr:hdr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrdo")]
    public partial class RevExDelObj : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExDelObj class.
        /// </summary>
        public RevExDelObj() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDelObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDelObj(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDelObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExDelObj(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExDelObj class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExDelObj(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrdo");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader>();
            builder.AddElement<RevExDelObj>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>StateBasedHeader.</para>
        /// <para>Represents the following element tag in the schema: xr:hdr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader? StateBasedHeader
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExDelObj>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExChgObj Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrco.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevisionState" /> <c>&lt;xr:body></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevisionStateLink" /> <c>&lt;xr:link></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader" /> <c>&lt;xr:hdr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrco")]
    public partial class RevExChgObj : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExChgObj class.
        /// </summary>
        public RevExChgObj() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChgObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChgObj(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChgObj class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevExChgObj(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevExChgObj class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevExChgObj(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrco");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevisionState>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevisionStateLink>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader>();
            builder.AddElement<RevExChgObj>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader), 1, 1, version: FileFormatVersions.Office2016),
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionStateLink), 0, 1, version: FileFormatVersions.Office2016),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionState), 0, 1, version: FileFormatVersions.Office2016)
                }
            };
        }

        /// <summary>
        /// <para>StateBasedHeader.</para>
        /// <para>Represents the following element tag in the schema: xr:hdr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader? StateBasedHeader
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.StateBasedHeader>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExChgObj>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExSheetOp Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrSheet.</para>
    /// </summary>
    [SchemaAttr("xr:xrrSheet")]
    public partial class RevExSheetOp : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExSheetOp class.
        /// </summary>
        public RevExSheetOp() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>op, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: op</para>
        /// </summary>
        [SchemaAttr("op")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>? Op
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SheetOp>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idOrig, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idOrig</para>
        /// </summary>
        [SchemaAttr("idOrig")]
        public UInt32Value? IdOrig
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idNew, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: idNew</para>
        /// </summary>
        [SchemaAttr("idNew")]
        public UInt32Value? IdNew
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrSheet");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevExSheetOp>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("op", a => a.Op, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name)
                .AddAttribute("idOrig", a => a.IdOrig)
                .AddAttribute("idNew", a => a.IdNew);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExSheetOp>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrList.</para>
    /// </summary>
    [SchemaAttr("xr:xrrList")]
    public partial class RevisionList : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionList class.
        /// </summary>
        public RevisionList() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Data, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: Data</para>
        /// </summary>
        [SchemaAttr("Data")]
        public BooleanValue? Data
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Formatting, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: Formatting</para>
        /// </summary>
        [SchemaAttr("Formatting")]
        public BooleanValue? Formatting
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>RangeBased, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: RangeBased</para>
        /// </summary>
        [SchemaAttr("RangeBased")]
        public BooleanValue? RangeBased
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Fake, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: Fake</para>
        /// </summary>
        [SchemaAttr("Fake")]
        public BooleanValue? Fake
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Headers, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: Headers</para>
        /// </summary>
        [SchemaAttr("Headers")]
        public BooleanValue? Headers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>InsDelHeaders, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: InsDelHeaders</para>
        /// </summary>
        [SchemaAttr("InsDelHeaders")]
        public BooleanValue? InsDelHeaders
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rId, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rId</para>
        /// </summary>
        [SchemaAttr("rId")]
        public UInt32Value? RId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrList");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevisionList>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("Data", a => a.Data)
                .AddAttribute("Formatting", a => a.Formatting)
                .AddAttribute("RangeBased", a => a.RangeBased)
                .AddAttribute("Fake", a => a.Fake)
                .AddAttribute("ref", a => a.Ref, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("Headers", a => a.Headers)
                .AddAttribute("InsDelHeaders", a => a.InsDelHeaders)
                .AddAttribute("rId", a => a.RId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionList>(deep);
    }

    /// <summary>
    /// <para>Defines the RevListAutoExpandRw Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrListExpR.</para>
    /// </summary>
    [SchemaAttr("xr:xrrListExpR")]
    public partial class RevListAutoExpandRw : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevListAutoExpandRw class.
        /// </summary>
        public RevListAutoExpandRw() : base()
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>refAdded, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: refAdded</para>
        /// </summary>
        [SchemaAttr("refAdded")]
        public StringValue? RefAdded
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>listGuid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: listGuid</para>
        /// </summary>
        [SchemaAttr("listGuid")]
        public StringValue? ListGuid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrListExpR");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevListAutoExpandRw>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx)
                .AddAttribute("refAdded", a => a.RefAdded, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("listGuid", a => a.ListGuid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevListAutoExpandRw>(deep);
    }

    /// <summary>
    /// <para>Defines the RevGroup Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrg.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell" /> <c>&lt;xr:xrrc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj" /> <c>&lt;xr:xrrco></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName" /> <c>&lt;xr:xrrDefName></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj" /> <c>&lt;xr:xrrdo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting" /> <c>&lt;xr:xrrf></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExFuture" /> <c>&lt;xr:xrrftr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExMove" /> <c>&lt;xr:xrrm></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn" /> <c>&lt;xr:xrrrc></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp" /> <c>&lt;xr:xrrSheet></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed" /> <c>&lt;xr:xrrTrim></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported" /> <c>&lt;xr:xrrUspt></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevisionList" /> <c>&lt;xr:xrrList></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw" /> <c>&lt;xr:xrrListExpR></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:xrrg")]
    public partial class RevGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevGroup class.
        /// </summary>
        public RevGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rev, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rev</para>
        /// </summary>
        [SchemaAttr("rev")]
        public UInt64Value? Rev
        {
            get => GetAttribute<UInt64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sh, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sh</para>
        /// </summary>
        [SchemaAttr("sh")]
        public StringValue? Sh
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidp, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidp</para>
        /// </summary>
        [SchemaAttr("uidp")]
        public StringValue? Uidp
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ctx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ctx</para>
        /// </summary>
        [SchemaAttr("ctx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>? Ctx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RevisionContext>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrg");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExFuture>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExMove>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevisionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw>();
            builder.AddElement<RevGroup>()
                .AddAttribute("rev", a => a.Rev, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("sh", a => a.Sh, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidp", a => a.Uidp, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("ctx", a => a.Ctx);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFuture), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExUnsupported), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExTrimmed), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExRowColumn), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExMove), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChangeCell), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExFormatting), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDefinedName), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExDelObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExChgObj), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevExSheetOp), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevisionList), 0, 0, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevListAutoExpandRw), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the RevExTest Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:xrrtest.</para>
    /// </summary>
    [SchemaAttr("xr:xrrtest")]
    public partial class RevExTest : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevExTest class.
        /// </summary>
        public RevExTest() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:xrrtest");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevExTest>(deep);
    }

    /// <summary>
    /// <para>Defines the RevCell Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:c.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RstType" /> <c>&lt;xr:is></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.FFormula" /> <c>&lt;xr:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.Xstring" /> <c>&lt;xr:v></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:c")]
    public partial class RevCell : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevCell class.
        /// </summary>
        public RevCell() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevCell(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevCell(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevCell class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevCell(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.CellValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nop, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: nop</para>
        /// </summary>
        [SchemaAttr("nop")]
        public BooleanValue? Nop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tick, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: tick</para>
        /// </summary>
        [SchemaAttr("tick")]
        public BooleanValue? Tick
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rep, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: rep</para>
        /// </summary>
        [SchemaAttr("rep")]
        public UInt32Value? Rep
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:c");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RstType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.FFormula>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.Xstring>();
            builder.AddElement<RevCell>()
                .AddAttribute("t", a => a.T)
                .AddAttribute("nop", a => a.Nop)
                .AddAttribute("tick", a => a.Tick)
                .AddAttribute("rep", a => a.Rep);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FFormula), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Xstring), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RstType), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>FFormula.</para>
        /// <para>Represents the following element tag in the schema: xr:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.FFormula? FFormula
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.FFormula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Xstring.</para>
        /// <para>Represents the following element tag in the schema: xr:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.Xstring? Xstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.Xstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RstType.</para>
        /// <para>Represents the following element tag in the schema: xr:is.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.RstType? RstType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.RstType>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevCell>(deep);
    }

    /// <summary>
    /// <para>Defines the ChangeCellSubEdit Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:ccse.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RevCell" /> <c>&lt;xr:c></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:ccse")]
    public partial class ChangeCellSubEdit : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class.
        /// </summary>
        public ChangeCellSubEdit() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChangeCellSubEdit(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ChangeCellSubEdit(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ChangeCellSubEdit class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ChangeCellSubEdit(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public StringValue? R
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [SchemaAttr("x")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>? X
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FillTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>w, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: w</para>
        /// </summary>
        [SchemaAttr("w")]
        public UInt32Value? W
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:ccse");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RevCell>();
            builder.AddElement<ChangeCellSubEdit>()
                .AddAttribute("r", a => a.R, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("t", a => a.T)
                .AddAttribute("x", a => a.X)
                .AddAttribute("w", a => a.W);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RevCell), 1, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ChangeCellSubEdit>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:extLst")]
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
            builder.SetSchema("xr:extLst");
            builder.Availability = FileFormatVersions.Office2016;
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
    /// <para>Defines the FormulaFormula Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:formula.</para>
    /// </summary>
    [SchemaAttr("xr:formula")]
    public partial class FormulaFormula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FormulaFormula class.
        /// </summary>
        public FormulaFormula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FormulaFormula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FormulaFormula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:formula");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FormulaFormula>(deep);
    }

    /// <summary>
    /// <para>Defines the FFormula Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:f.</para>
    /// </summary>
    [SchemaAttr("xr:f")]
    public partial class FFormula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the FFormula class.
        /// </summary>
        public FFormula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FFormula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public FFormula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:f");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FFormula>(deep);
    }

    /// <summary>
    /// <para>Defines the StateBasedHeader Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hdr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RefMap" /> <c>&lt;xr:refmap></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:hdr")]
    public partial class StateBasedHeader : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class.
        /// </summary>
        public StateBasedHeader() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedHeader(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public StateBasedHeader(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StateBasedHeader class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public StateBasedHeader(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>eft, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: eft</para>
        /// </summary>
        [SchemaAttr("eft")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>? Eft
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.FeatureType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>eftx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: eftx</para>
        /// </summary>
        [SchemaAttr("eftx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>? Eftx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtFeatureType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seft, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: seft</para>
        /// </summary>
        [SchemaAttr("seft")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>? Seft
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.SubFeatureType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>seftx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: seftx</para>
        /// </summary>
        [SchemaAttr("seftx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>? Seftx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.ExtSubFeatureType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:hdr");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RefMap>();
            builder.AddElement<StateBasedHeader>()
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("eft", a => a.Eft, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("eftx", a => a.Eftx)
                .AddAttribute("seft", a => a.Seft)
                .AddAttribute("seftx", a => a.Seftx);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefMap), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>RefMap.</para>
        /// <para>Represents the following element tag in the schema: xr:refmap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.RefMap? RefMap
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.RefMap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<StateBasedHeader>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionStateLink Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:link.</para>
    /// </summary>
    [SchemaAttr("xr:link")]
    public partial class RevisionStateLink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionStateLink class.
        /// </summary>
        public RevisionStateLink() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2016 and later.</para>
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
            builder.SetSchema("xr:link");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RevisionStateLink>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionStateLink>(deep);
    }

    /// <summary>
    /// <para>Defines the RevisionState Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:body.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.FreezePanes" /> <c>&lt;xr:freezePanes></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet" /> <c>&lt;xr:hideUnhideSheet></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.Outlines" /> <c>&lt;xr:outlines></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps" /> <c>&lt;xr:rowColVisualOps></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings" /> <c>&lt;xr:showGridlinesHeadings></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:body")]
    public partial class RevisionState : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RevisionState class.
        /// </summary>
        public RevisionState() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevisionState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevisionState(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevisionState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RevisionState(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RevisionState class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RevisionState(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:body");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.FreezePanes>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.Outlines>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.FreezePanes), 0, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Outlines), 0, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <summary>
        /// <para>RowColVisualOps.</para>
        /// <para>Represents the following element tag in the schema: xr:rowColVisualOps.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps? RowColVisualOps
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOps>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HideUnhideSheet.</para>
        /// <para>Represents the following element tag in the schema: xr:hideUnhideSheet.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet? HideUnhideSheet
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.HideUnhideSheet>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ShowGridlinesHeadings.</para>
        /// <para>Represents the following element tag in the schema: xr:showGridlinesHeadings.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings? ShowGridlinesHeadings
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.ShowGridlinesHeadings>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FreezePanes.</para>
        /// <para>Represents the following element tag in the schema: xr:freezePanes.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.FreezePanes? FreezePanes
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.FreezePanes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Outlines.</para>
        /// <para>Represents the following element tag in the schema: xr:outlines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xr = http://schemas.microsoft.com/office/spreadsheetml/2014/revision
        /// </remark>
        public DocumentFormat.OpenXml.Office2016.Excel.Outlines? Outlines
        {
            get => GetElement<DocumentFormat.OpenXml.Office2016.Excel.Outlines>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RevisionState>(deep);
    }

    /// <summary>
    /// <para>Defines the RefMap Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:refmap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RefCell" /> <c>&lt;xr:ref></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RefFuture" /> <c>&lt;xr:future></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RefOartAnchor" /> <c>&lt;xr:oartAnchor></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.RefTest" /> <c>&lt;xr:test></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.SheetXluid" /> <c>&lt;xr:sheetUid></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:refmap")]
    public partial class RefMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RefMap class.
        /// </summary>
        public RefMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RefMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RefMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RefMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RefMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RefMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RefMap(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:refmap");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RefCell>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RefFuture>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RefOartAnchor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.RefTest>();
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.SheetXluid>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 0)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefCell), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.SheetXluid), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefOartAnchor), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefFuture), 1, 1, version: FileFormatVersions.Office2016),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.RefTest), 1, 1, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefMap>(deep);
    }

    /// <summary>
    /// <para>Defines the RowColVisualOps Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:rowColVisualOps.</para>
    /// </summary>
    [SchemaAttr("xr:rowColVisualOps")]
    public partial class RowColVisualOps : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RowColVisualOps class.
        /// </summary>
        public RowColVisualOps() : base()
        {
        }

        /// <summary>
        /// <para>action, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: action</para>
        /// </summary>
        [SchemaAttr("action")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>? Action
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.RowColVisualOp>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isRow, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: isRow</para>
        /// </summary>
        [SchemaAttr("isRow")]
        public BooleanValue? IsRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public UInt32Value? Size
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>userSized, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: userSized</para>
        /// </summary>
        [SchemaAttr("userSized")]
        public BooleanValue? UserSized
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:rowColVisualOps");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RowColVisualOps>()
                .AddAttribute("action", a => a.Action, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("isRow", a => a.IsRow, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("size", a => a.Size)
                .AddAttribute("userSized", a => a.UserSized);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowColVisualOps>(deep);
    }

    /// <summary>
    /// <para>Defines the HideUnhideSheet Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hideUnhideSheet.</para>
    /// </summary>
    [SchemaAttr("xr:hideUnhideSheet")]
    public partial class HideUnhideSheet : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the HideUnhideSheet class.
        /// </summary>
        public HideUnhideSheet() : base()
        {
        }

        /// <summary>
        /// <para>hide, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: hide</para>
        /// </summary>
        [SchemaAttr("hide")]
        public BooleanValue? Hide
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:hideUnhideSheet");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<HideUnhideSheet>()
                .AddAttribute("hide", a => a.Hide, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<HideUnhideSheet>(deep);
    }

    /// <summary>
    /// <para>Defines the ShowGridlinesHeadings Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:showGridlinesHeadings.</para>
    /// </summary>
    [SchemaAttr("xr:showGridlinesHeadings")]
    public partial class ShowGridlinesHeadings : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ShowGridlinesHeadings class.
        /// </summary>
        public ShowGridlinesHeadings() : base()
        {
        }

        /// <summary>
        /// <para>showGridLines, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: showGridLines</para>
        /// </summary>
        [SchemaAttr("showGridLines")]
        public BooleanValue? ShowGridLines
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showRowCol, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: showRowCol</para>
        /// </summary>
        [SchemaAttr("showRowCol")]
        public BooleanValue? ShowRowCol
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:showGridlinesHeadings");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<ShowGridlinesHeadings>()
                .AddAttribute("showGridLines", a => a.ShowGridLines, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("showRowCol", a => a.ShowRowCol, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ShowGridlinesHeadings>(deep);
    }

    /// <summary>
    /// <para>Defines the FreezePanes Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:freezePanes.</para>
    /// </summary>
    [SchemaAttr("xr:freezePanes")]
    public partial class FreezePanes : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FreezePanes class.
        /// </summary>
        public FreezePanes() : base()
        {
        }

        /// <summary>
        /// <para>sheetViewUid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: sheetViewUid</para>
        /// </summary>
        [SchemaAttr("sheetViewUid")]
        public StringValue? SheetViewUid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:freezePanes");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<FreezePanes>()
                .AddAttribute("sheetViewUid", a => a.SheetViewUid, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FreezePanes>(deep);
    }

    /// <summary>
    /// <para>Defines the Outlines Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:outlines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2016.Excel.Outline" /> <c>&lt;xr:outline></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:outlines")]
    public partial class Outlines : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Outlines class.
        /// </summary>
        public Outlines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Outlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Outlines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Outlines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Outlines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Outlines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Outlines(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>isRow, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: isRow</para>
        /// </summary>
        [SchemaAttr("isRow")]
        public BooleanValue? IsRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:outlines");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2016.Excel.Outline>();
            builder.AddElement<Outlines>()
                .AddAttribute("isRow", a => a.IsRow, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2016.Excel.Outline), 0, 0, version: FileFormatVersions.Office2016)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outlines>(deep);
    }

    /// <summary>
    /// <para>Defines the Outline Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:outline.</para>
    /// </summary>
    [SchemaAttr("xr:outline")]
    public partial class Outline : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Outline class.
        /// </summary>
        public Outline() : base()
        {
        }

        /// <summary>
        /// <para>isCollapsed, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: isCollapsed</para>
        /// </summary>
        [SchemaAttr("isCollapsed")]
        public BooleanValue? IsCollapsed
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>level, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: level</para>
        /// </summary>
        [SchemaAttr("level")]
        public ByteValue? Level
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:outline");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Outline>()
                .AddAttribute("isCollapsed", a => a.IsCollapsed, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("level", a => a.Level, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Outline>(deep);
    }

    /// <summary>
    /// <para>Defines the Xstring Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:v.</para>
    /// </summary>
    [SchemaAttr("xr:v")]
    public partial class Xstring : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Xstring class.
        /// </summary>
        public Xstring() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Xstring class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Xstring(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:v");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);
    }

    /// <summary>
    /// <para>Defines the RstType Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:is.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties" /> <c>&lt;x:phoneticPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PhoneticRun" /> <c>&lt;x:rPh></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Run" /> <c>&lt;x:r></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Text" /> <c>&lt;x:t></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:is")]
    public partial class RstType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RstType class.
        /// </summary>
        public RstType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RstType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RstType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RstType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RstType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RstType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RstType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:is");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PhoneticRun>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Run>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Text>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Text), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Run), 0, 32767),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticRun), 0, 32767),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties), 0, 1)
            };
        }

        /// <summary>
        /// <para>Text.</para>
        /// <para>Represents the following element tag in the schema: x:t.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Text? Text
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Text>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RstType>(deep);
    }

    /// <summary>
    /// <para>Defines the RefCell Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:ref.</para>
    /// </summary>
    [SchemaAttr("xr:ref")]
    public partial class RefCell : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefCell class.
        /// </summary>
        public RefCell() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        [SchemaAttr("ajt")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>? Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        [SchemaAttr("ajtx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>? Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        [SchemaAttr("homeRef")]
        public BooleanValue? HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public ListValue<StringValue>? R
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uidLast, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uidLast</para>
        /// </summary>
        [SchemaAttr("uidLast")]
        public StringValue? UidLast
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:ref");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RefCell>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajt", a => a.Ajt, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajtx", a => a.Ajtx)
                .AddAttribute("homeRef", a => a.HomeRef)
                .AddAttribute("r", a => a.R, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("uidLast", a => a.UidLast, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefCell>(deep);
    }

    /// <summary>
    /// <para>Defines the SheetXluid Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:sheetUid.</para>
    /// </summary>
    [SchemaAttr("xr:sheetUid")]
    public partial class SheetXluid : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SheetXluid class.
        /// </summary>
        public SheetXluid() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        [SchemaAttr("ajt")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>? Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        [SchemaAttr("ajtx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>? Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        [SchemaAttr("homeRef")]
        public BooleanValue? HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>uid, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: uid</para>
        /// </summary>
        [SchemaAttr("uid")]
        public StringValue? Uid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:sheetUid");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<SheetXluid>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajt", a => a.Ajt, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajtx", a => a.Ajtx)
                .AddAttribute("homeRef", a => a.HomeRef)
                .AddAttribute("uid", a => a.Uid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SheetXluid>(deep);
    }

    /// <summary>
    /// <para>Defines the RefOartAnchor Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:oartAnchor.</para>
    /// </summary>
    [SchemaAttr("xr:oartAnchor")]
    public partial class RefOartAnchor : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefOartAnchor class.
        /// </summary>
        public RefOartAnchor() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        [SchemaAttr("ajt")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>? Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        [SchemaAttr("ajtx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>? Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        [SchemaAttr("homeRef")]
        public BooleanValue? HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public StringValue? R
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fromRowOff, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: fromRowOff</para>
        /// </summary>
        [SchemaAttr("fromRowOff")]
        public Int64Value? FromRowOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fromColOff, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: fromColOff</para>
        /// </summary>
        [SchemaAttr("fromColOff")]
        public Int64Value? FromColOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toRowOff, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: toRowOff</para>
        /// </summary>
        [SchemaAttr("toRowOff")]
        public Int64Value? ToRowOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toColOff, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: toColOff</para>
        /// </summary>
        [SchemaAttr("toColOff")]
        public Int64Value? ToColOff
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cx</para>
        /// </summary>
        [SchemaAttr("cx")]
        public Int64Value? Cx
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cy, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: cy</para>
        /// </summary>
        [SchemaAttr("cy")]
        public Int64Value? Cy
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>x, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: x</para>
        /// </summary>
        [SchemaAttr("x")]
        public Int64Value? X
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>y, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: y</para>
        /// </summary>
        [SchemaAttr("y")]
        public Int64Value? Y
        {
            get => GetAttribute<Int64Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>oat, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: oat</para>
        /// </summary>
        [SchemaAttr("oat")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>? Oat
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.OartAnchorType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:oartAnchor");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RefOartAnchor>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajt", a => a.Ajt, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajtx", a => a.Ajtx)
                .AddAttribute("homeRef", a => a.HomeRef)
                .AddAttribute("r", a => a.R)
                .AddAttribute("fromRowOff", a => a.FromRowOff, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("fromColOff", a => a.FromColOff, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("toRowOff", a => a.ToRowOff, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("toColOff", a => a.ToColOff, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("cx", a => a.Cx, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                })
                .AddAttribute("cy", a => a.Cy, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (0L), MaxInclusive = (2147483647L) });
                })
                .AddAttribute("x", a => a.X, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("y", a => a.Y, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MinInclusive = (-27273042329600L), MaxInclusive = (27273042316900L) });
                })
                .AddAttribute("oat", a => a.Oat, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefOartAnchor>(deep);
    }

    /// <summary>
    /// <para>Defines the RefFuture Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:future.</para>
    /// </summary>
    [SchemaAttr("xr:future")]
    public partial class RefFuture : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefFuture class.
        /// </summary>
        public RefFuture() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:future");
            builder.Availability = FileFormatVersions.Office2016;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefFuture>(deep);
    }

    /// <summary>
    /// <para>Defines the RefTest Class.</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:test.</para>
    /// </summary>
    [SchemaAttr("xr:test")]
    public partial class RefTest : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RefTest class.
        /// </summary>
        public RefTest() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajt, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajt</para>
        /// </summary>
        [SchemaAttr("ajt")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>? Ajt
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ajtx, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: ajtx</para>
        /// </summary>
        [SchemaAttr("ajtx")]
        public EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>? Ajtx
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2016.Excel.AdjustTypeExt>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>homeRef, this property is only available in Office 2016 and later.</para>
        /// <para>Represents the following attribute in the schema: homeRef</para>
        /// </summary>
        [SchemaAttr("homeRef")]
        public BooleanValue? HomeRef
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:test");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<RefTest>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajt", a => a.Ajt, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("ajtx", a => a.Ajtx)
                .AddAttribute("homeRef", a => a.HomeRef);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RefTest>(deep);
    }

    /// <summary>
    /// <para>Represents an external link to another workbook..</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:dataValidation.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Formula1" /> <c>&lt;x:formula1></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Formula2" /> <c>&lt;x:formula2></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.ExcelAc.List" /> <c>&lt;x12ac:list></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:dataValidation")]
    public partial class DataValidation : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataValidation class.
        /// </summary>
        public DataValidation() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidation(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidation class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataValidation(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataValidation class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataValidation(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorStyle</para>
        /// <para>Represents the following attribute in the schema: errorStyle</para>
        /// </summary>
        [SchemaAttr("errorStyle")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>? ErrorStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationErrorStyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imeMode</para>
        /// <para>Represents the following attribute in the schema: imeMode</para>
        /// </summary>
        [SchemaAttr("imeMode")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>? ImeMode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationImeModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>operator</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        [SchemaAttr("operator")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>? Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DataValidationOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowBlank</para>
        /// <para>Represents the following attribute in the schema: allowBlank</para>
        /// </summary>
        [SchemaAttr("allowBlank")]
        public BooleanValue? AllowBlank
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDropDown</para>
        /// <para>Represents the following attribute in the schema: showDropDown</para>
        /// </summary>
        [SchemaAttr("showDropDown")]
        public BooleanValue? ShowDropDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInputMessage</para>
        /// <para>Represents the following attribute in the schema: showInputMessage</para>
        /// </summary>
        [SchemaAttr("showInputMessage")]
        public BooleanValue? ShowInputMessage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showErrorMessage</para>
        /// <para>Represents the following attribute in the schema: showErrorMessage</para>
        /// </summary>
        [SchemaAttr("showErrorMessage")]
        public BooleanValue? ShowErrorMessage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorTitle</para>
        /// <para>Represents the following attribute in the schema: errorTitle</para>
        /// </summary>
        [SchemaAttr("errorTitle")]
        public StringValue? ErrorTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>error</para>
        /// <para>Represents the following attribute in the schema: error</para>
        /// </summary>
        [SchemaAttr("error")]
        public StringValue? Error
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>promptTitle</para>
        /// <para>Represents the following attribute in the schema: promptTitle</para>
        /// </summary>
        [SchemaAttr("promptTitle")]
        public StringValue? PromptTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>prompt</para>
        /// <para>Represents the following attribute in the schema: prompt</para>
        /// </summary>
        [SchemaAttr("prompt")]
        public StringValue? Prompt
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sqref</para>
        /// <para>Represents the following attribute in the schema: sqref</para>
        /// </summary>
        [SchemaAttr("sqref")]
        public ListValue<StringValue>? SequenceOfReferences
        {
            get => GetAttribute<ListValue<StringValue>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:dataValidation");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Formula1>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Formula2>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.ExcelAc.List>();
            builder.AddElement<DataValidation>()
                .AddAttribute("type", a => a.Type)
                .AddAttribute("errorStyle", a => a.ErrorStyle)
                .AddAttribute("imeMode", a => a.ImeMode)
                .AddAttribute("operator", a => a.Operator)
                .AddAttribute("allowBlank", a => a.AllowBlank)
                .AddAttribute("showDropDown", a => a.ShowDropDown)
                .AddAttribute("showInputMessage", a => a.ShowInputMessage)
                .AddAttribute("showErrorMessage", a => a.ShowErrorMessage)
                .AddAttribute("errorTitle", a => a.ErrorTitle)
                .AddAttribute("error", a => a.Error)
                .AddAttribute("promptTitle", a => a.PromptTitle)
                .AddAttribute("prompt", a => a.Prompt)
                .AddAttribute("sqref", a => a.SequenceOfReferences, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.ExcelAc.List), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula1), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formula2), 0, 1)
            };
        }

        /// <summary>
        /// <para>List.</para>
        /// <para>Represents the following element tag in the schema: x12ac:list.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x12ac = http://schemas.microsoft.com/office/spreadsheetml/2011/1/ac
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.ExcelAc.List? List
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.ExcelAc.List>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula1.</para>
        /// <para>Represents the following element tag in the schema: x:formula1.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Formula1? Formula1
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula1>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula2.</para>
        /// <para>Represents the following element tag in the schema: x:formula2.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Formula2? Formula2
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formula2>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataValidation>(deep);
    }

    /// <summary>
    /// <para>Represents a hyperlink within a cell..</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:hyperlink.</para>
    /// </summary>
    [SchemaAttr("xr:hyperlink")]
    public partial class Hyperlink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Hyperlink class.
        /// </summary>
        public Hyperlink() : base()
        {
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Relationship Id</para>
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

        /// <summary>
        /// <para>Location</para>
        /// <para>Represents the following attribute in the schema: location</para>
        /// </summary>
        [SchemaAttr("location")]
        public StringValue? Location
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Tool Tip</para>
        /// <para>Represents the following attribute in the schema: tooltip</para>
        /// </summary>
        [SchemaAttr("tooltip")]
        public StringValue? Tooltip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Display String</para>
        /// <para>Represents the following attribute in the schema: display</para>
        /// </summary>
        [SchemaAttr("display")]
        public StringValue? Display
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:hyperlink");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddElement<Hyperlink>()
                .AddAttribute("ref", a => a.Reference, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("r:id", a => a.Id)
                .AddAttribute("location", a => a.Location)
                .AddAttribute("tooltip", a => a.Tooltip)
                .AddAttribute("display", a => a.Display);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);
    }

    /// <summary>
    /// <para>Represents a sparkline group of 1 or more sparklines..</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:sparklineGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.SeriesColor" /> <c>&lt;x14:colorSeries></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.NegativeColor" /> <c>&lt;x14:colorNegative></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.AxisColor" /> <c>&lt;x14:colorAxis></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.MarkersColor" /> <c>&lt;x14:colorMarkers></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor" /> <c>&lt;x14:colorFirst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor" /> <c>&lt;x14:colorLast></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor" /> <c>&lt;x14:colorHigh></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor" /> <c>&lt;x14:colorLow></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Excel.Formula" /> <c>&lt;xne:f></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.Sparklines" /> <c>&lt;x14:sparklines></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:sparklineGroup")]
    public partial class SparklineGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SparklineGroup class.
        /// </summary>
        public SparklineGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SparklineGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SparklineGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SparklineGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SparklineGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>manualMax, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: manualMax</para>
        /// </summary>
        [SchemaAttr("manualMax")]
        public DoubleValue? ManualMax
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>manualMin, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: manualMin</para>
        /// </summary>
        [SchemaAttr("manualMin")]
        public DoubleValue? ManualMin
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lineWeight, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: lineWeight</para>
        /// </summary>
        [SchemaAttr("lineWeight")]
        public DoubleValue? LineWeight
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dateAxis, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dateAxis</para>
        /// </summary>
        [SchemaAttr("dateAxis")]
        public BooleanValue? DateAxis
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayEmptyCellsAs, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: displayEmptyCellsAs</para>
        /// </summary>
        [SchemaAttr("displayEmptyCellsAs")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>? DisplayEmptyCellsAs
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.DisplayBlanksAsValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>markers, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: markers</para>
        /// </summary>
        [SchemaAttr("markers")]
        public BooleanValue? Markers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>high, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: high</para>
        /// </summary>
        [SchemaAttr("high")]
        public BooleanValue? High
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>low, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: low</para>
        /// </summary>
        [SchemaAttr("low")]
        public BooleanValue? Low
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>first, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: first</para>
        /// </summary>
        [SchemaAttr("first")]
        public BooleanValue? First
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>last, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: last</para>
        /// </summary>
        [SchemaAttr("last")]
        public BooleanValue? Last
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>negative, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: negative</para>
        /// </summary>
        [SchemaAttr("negative")]
        public BooleanValue? Negative
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayXAxis, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: displayXAxis</para>
        /// </summary>
        [SchemaAttr("displayXAxis")]
        public BooleanValue? DisplayXAxis
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>displayHidden, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: displayHidden</para>
        /// </summary>
        [SchemaAttr("displayHidden")]
        public BooleanValue? DisplayHidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minAxisType, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: minAxisType</para>
        /// </summary>
        [SchemaAttr("minAxisType")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>? MinAxisType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxAxisType, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: maxAxisType</para>
        /// </summary>
        [SchemaAttr("maxAxisType")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>? MaxAxisType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SparklineAxisMinMaxValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rightToLeft, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: rightToLeft</para>
        /// </summary>
        [SchemaAttr("rightToLeft")]
        public BooleanValue? RightToLeft
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:sparklineGroup");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.SeriesColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.NegativeColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.AxisColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.MarkersColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.Sparklines>();
            builder.AddElement<SparklineGroup>()
                .AddAttribute("manualMax", a => a.ManualMax)
                .AddAttribute("manualMin", a => a.ManualMin)
                .AddAttribute("lineWeight", a => a.LineWeight)
                .AddAttribute("type", a => a.Type)
                .AddAttribute("dateAxis", a => a.DateAxis)
                .AddAttribute("displayEmptyCellsAs", a => a.DisplayEmptyCellsAs)
                .AddAttribute("markers", a => a.Markers)
                .AddAttribute("high", a => a.High)
                .AddAttribute("low", a => a.Low)
                .AddAttribute("first", a => a.First)
                .AddAttribute("last", a => a.Last)
                .AddAttribute("negative", a => a.Negative)
                .AddAttribute("displayXAxis", a => a.DisplayXAxis)
                .AddAttribute("displayHidden", a => a.DisplayHidden)
                .AddAttribute("minAxisType", a => a.MinAxisType)
                .AddAttribute("maxAxisType", a => a.MaxAxisType)
                .AddAttribute("rightToLeft", a => a.RightToLeft);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SeriesColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.NegativeColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.AxisColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.MarkersColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.Sparklines), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>SeriesColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorSeries.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.SeriesColor? SeriesColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.SeriesColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>NegativeColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorNegative.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.NegativeColor? NegativeColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.NegativeColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>AxisColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorAxis.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.AxisColor? AxisColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.AxisColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MarkersColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorMarkers.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.MarkersColor? MarkersColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.MarkersColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>FirstMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorFirst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor? FirstMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.FirstMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LastMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorLast.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor? LastMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.LastMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>HighMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorHigh.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor? HighMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.HighMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>LowMarkerColor.</para>
        /// <para>Represents the following element tag in the schema: x14:colorLow.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor? LowMarkerColor
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.LowMarkerColor>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formula.</para>
        /// <para>Represents the following element tag in the schema: xne:f.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.Formula? Formula
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.Formula>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sparklines.</para>
        /// <para>Represents the following element tag in the schema: x14:sparklines.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x14 = http://schemas.microsoft.com/office/spreadsheetml/2009/9/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.Excel.Sparklines? Sparklines
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.Excel.Sparklines>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SparklineGroup>(deep);
    }

    /// <summary>
    /// <para>Represents one comment within a cell..</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:comments.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Authors" /> <c>&lt;x:authors></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.CommentList" /> <c>&lt;x:commentList></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:comments")]
    public partial class Comments : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Comments class.
        /// </summary>
        public Comments() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comments(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Comments(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Comments class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Comments(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:comments");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Authors>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.CommentList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Authors), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CommentList), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Authors.</para>
        /// <para>Represents the following element tag in the schema: x:authors.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Authors? Authors
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Authors>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>List of Comments.</para>
        /// <para>Represents the following element tag in the schema: x:commentList.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.CommentList? CommentList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.CommentList>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Comments>(deep);
    }

    /// <summary>
    /// <para>Represents an autofilter..</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:autoFilter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.FilterColumn" /> <c>&lt;x:filterColumn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SortState" /> <c>&lt;x:sortState></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:autoFilter")]
    public partial class AutoFilter : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the AutoFilter class.
        /// </summary>
        public AutoFilter() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AutoFilter(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFilter class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public AutoFilter(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the AutoFilter class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public AutoFilter(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Cell or Range Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:autoFilter");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.FilterColumn>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SortState>();
            builder.AddElement<AutoFilter>()
                .AddAttribute("ref", a => a.Reference);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.FilterColumn), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<AutoFilter>(deep);
    }

    /// <summary>
    /// <para>Represents a PivotTable View..</para>
    /// <para>This class is available in Office 2016 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xr:pivotTableDefinition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ChartFormats" /> <c>&lt;x:chartFormats></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ColumnFields" /> <c>&lt;x:colFields></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage" /> <c>&lt;x:colHierarchiesUsage></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ColumnItems" /> <c>&lt;x:colItems></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats" /> <c>&lt;x:conditionalFormats></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DataFields" /> <c>&lt;x:dataFields></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Formats" /> <c>&lt;x:formats></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Location" /> <c>&lt;x:location></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PageFields" /> <c>&lt;x:pageFields></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotFields" /> <c>&lt;x:pivotFields></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotFilters" /> <c>&lt;x:filters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies" /> <c>&lt;x:pivotHierarchies></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle" /> <c>&lt;x:pivotTableStyleInfo></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.RowFields" /> <c>&lt;x:rowFields></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage" /> <c>&lt;x:rowHierarchiesUsage></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.RowItems" /> <c>&lt;x:rowItems></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xr:pivotTableDefinition")]
    public partial class pivotTableDefinition : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class.
        /// </summary>
        public pivotTableDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public pivotTableDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public pivotTableDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the pivotTableDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public pivotTableDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cacheId</para>
        /// <para>Represents the following attribute in the schema: cacheId</para>
        /// </summary>
        [SchemaAttr("cacheId")]
        public UInt32Value? CacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dataOnRows</para>
        /// <para>Represents the following attribute in the schema: dataOnRows</para>
        /// </summary>
        [SchemaAttr("dataOnRows")]
        public BooleanValue? DataOnRows
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dataPosition</para>
        /// <para>Represents the following attribute in the schema: dataPosition</para>
        /// </summary>
        [SchemaAttr("dataPosition")]
        public UInt32Value? DataPosition
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Auto Format Id</para>
        /// <para>Represents the following attribute in the schema: autoFormatId</para>
        /// </summary>
        [SchemaAttr("autoFormatId")]
        public UInt32Value? AutoFormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Number Formats</para>
        /// <para>Represents the following attribute in the schema: applyNumberFormats</para>
        /// </summary>
        [SchemaAttr("applyNumberFormats")]
        public BooleanValue? ApplyNumberFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Border Formats</para>
        /// <para>Represents the following attribute in the schema: applyBorderFormats</para>
        /// </summary>
        [SchemaAttr("applyBorderFormats")]
        public BooleanValue? ApplyBorderFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Font Formats</para>
        /// <para>Represents the following attribute in the schema: applyFontFormats</para>
        /// </summary>
        [SchemaAttr("applyFontFormats")]
        public BooleanValue? ApplyFontFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Pattern Formats</para>
        /// <para>Represents the following attribute in the schema: applyPatternFormats</para>
        /// </summary>
        [SchemaAttr("applyPatternFormats")]
        public BooleanValue? ApplyPatternFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Alignment Formats</para>
        /// <para>Represents the following attribute in the schema: applyAlignmentFormats</para>
        /// </summary>
        [SchemaAttr("applyAlignmentFormats")]
        public BooleanValue? ApplyAlignmentFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Apply Width / Height Formats</para>
        /// <para>Represents the following attribute in the schema: applyWidthHeightFormats</para>
        /// </summary>
        [SchemaAttr("applyWidthHeightFormats")]
        public BooleanValue? ApplyWidthHeightFormats
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dataCaption</para>
        /// <para>Represents the following attribute in the schema: dataCaption</para>
        /// </summary>
        [SchemaAttr("dataCaption")]
        public StringValue? DataCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>grandTotalCaption</para>
        /// <para>Represents the following attribute in the schema: grandTotalCaption</para>
        /// </summary>
        [SchemaAttr("grandTotalCaption")]
        public StringValue? GrandTotalCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>errorCaption</para>
        /// <para>Represents the following attribute in the schema: errorCaption</para>
        /// </summary>
        [SchemaAttr("errorCaption")]
        public StringValue? ErrorCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showError</para>
        /// <para>Represents the following attribute in the schema: showError</para>
        /// </summary>
        [SchemaAttr("showError")]
        public BooleanValue? ShowError
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>missingCaption</para>
        /// <para>Represents the following attribute in the schema: missingCaption</para>
        /// </summary>
        [SchemaAttr("missingCaption")]
        public StringValue? MissingCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMissing</para>
        /// <para>Represents the following attribute in the schema: showMissing</para>
        /// </summary>
        [SchemaAttr("showMissing")]
        public BooleanValue? ShowMissing
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pageStyle</para>
        /// <para>Represents the following attribute in the schema: pageStyle</para>
        /// </summary>
        [SchemaAttr("pageStyle")]
        public StringValue? PageStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pivotTableStyle</para>
        /// <para>Represents the following attribute in the schema: pivotTableStyle</para>
        /// </summary>
        [SchemaAttr("pivotTableStyle")]
        public StringValue? PivotTableStyleName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>vacatedStyle</para>
        /// <para>Represents the following attribute in the schema: vacatedStyle</para>
        /// </summary>
        [SchemaAttr("vacatedStyle")]
        public StringValue? VacatedStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>updatedVersion</para>
        /// <para>Represents the following attribute in the schema: updatedVersion</para>
        /// </summary>
        [SchemaAttr("updatedVersion")]
        public ByteValue? UpdatedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minRefreshableVersion</para>
        /// <para>Represents the following attribute in the schema: minRefreshableVersion</para>
        /// </summary>
        [SchemaAttr("minRefreshableVersion")]
        public ByteValue? MinRefreshableVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>asteriskTotals</para>
        /// <para>Represents the following attribute in the schema: asteriskTotals</para>
        /// </summary>
        [SchemaAttr("asteriskTotals")]
        public BooleanValue? AsteriskTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItems</para>
        /// <para>Represents the following attribute in the schema: showItems</para>
        /// </summary>
        [SchemaAttr("showItems")]
        public BooleanValue? ShowItems
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>editData</para>
        /// <para>Represents the following attribute in the schema: editData</para>
        /// </summary>
        [SchemaAttr("editData")]
        public BooleanValue? EditData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>disableFieldList</para>
        /// <para>Represents the following attribute in the schema: disableFieldList</para>
        /// </summary>
        [SchemaAttr("disableFieldList")]
        public BooleanValue? DisableFieldList
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showCalcMbrs</para>
        /// <para>Represents the following attribute in the schema: showCalcMbrs</para>
        /// </summary>
        [SchemaAttr("showCalcMbrs")]
        public BooleanValue? ShowCalculatedMembers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visualTotals</para>
        /// <para>Represents the following attribute in the schema: visualTotals</para>
        /// </summary>
        [SchemaAttr("visualTotals")]
        public BooleanValue? VisualTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMultipleLabel</para>
        /// <para>Represents the following attribute in the schema: showMultipleLabel</para>
        /// </summary>
        [SchemaAttr("showMultipleLabel")]
        public BooleanValue? ShowMultipleLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDataDropDown</para>
        /// <para>Represents the following attribute in the schema: showDataDropDown</para>
        /// </summary>
        [SchemaAttr("showDataDropDown")]
        public BooleanValue? ShowDataDropDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDrill</para>
        /// <para>Represents the following attribute in the schema: showDrill</para>
        /// </summary>
        [SchemaAttr("showDrill")]
        public BooleanValue? ShowDrill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>printDrill</para>
        /// <para>Represents the following attribute in the schema: printDrill</para>
        /// </summary>
        [SchemaAttr("printDrill")]
        public BooleanValue? PrintDrill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showMemberPropertyTips</para>
        /// <para>Represents the following attribute in the schema: showMemberPropertyTips</para>
        /// </summary>
        [SchemaAttr("showMemberPropertyTips")]
        public BooleanValue? ShowMemberPropertyTips
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDataTips</para>
        /// <para>Represents the following attribute in the schema: showDataTips</para>
        /// </summary>
        [SchemaAttr("showDataTips")]
        public BooleanValue? ShowDataTips
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableWizard</para>
        /// <para>Represents the following attribute in the schema: enableWizard</para>
        /// </summary>
        [SchemaAttr("enableWizard")]
        public BooleanValue? EnableWizard
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableDrill</para>
        /// <para>Represents the following attribute in the schema: enableDrill</para>
        /// </summary>
        [SchemaAttr("enableDrill")]
        public BooleanValue? EnableDrill
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enableFieldProperties</para>
        /// <para>Represents the following attribute in the schema: enableFieldProperties</para>
        /// </summary>
        [SchemaAttr("enableFieldProperties")]
        public BooleanValue? EnableFieldProperties
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>preserveFormatting</para>
        /// <para>Represents the following attribute in the schema: preserveFormatting</para>
        /// </summary>
        [SchemaAttr("preserveFormatting")]
        public BooleanValue? PreserveFormatting
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>useAutoFormatting</para>
        /// <para>Represents the following attribute in the schema: useAutoFormatting</para>
        /// </summary>
        [SchemaAttr("useAutoFormatting")]
        public BooleanValue? UseAutoFormatting
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pageWrap</para>
        /// <para>Represents the following attribute in the schema: pageWrap</para>
        /// </summary>
        [SchemaAttr("pageWrap")]
        public UInt32Value? PageWrap
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pageOverThenDown</para>
        /// <para>Represents the following attribute in the schema: pageOverThenDown</para>
        /// </summary>
        [SchemaAttr("pageOverThenDown")]
        public BooleanValue? PageOverThenDown
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>subtotalHiddenItems</para>
        /// <para>Represents the following attribute in the schema: subtotalHiddenItems</para>
        /// </summary>
        [SchemaAttr("subtotalHiddenItems")]
        public BooleanValue? SubtotalHiddenItems
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowGrandTotals</para>
        /// <para>Represents the following attribute in the schema: rowGrandTotals</para>
        /// </summary>
        [SchemaAttr("rowGrandTotals")]
        public BooleanValue? RowGrandTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>colGrandTotals</para>
        /// <para>Represents the following attribute in the schema: colGrandTotals</para>
        /// </summary>
        [SchemaAttr("colGrandTotals")]
        public BooleanValue? ColumnGrandTotals
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fieldPrintTitles</para>
        /// <para>Represents the following attribute in the schema: fieldPrintTitles</para>
        /// </summary>
        [SchemaAttr("fieldPrintTitles")]
        public BooleanValue? FieldPrintTitles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemPrintTitles</para>
        /// <para>Represents the following attribute in the schema: itemPrintTitles</para>
        /// </summary>
        [SchemaAttr("itemPrintTitles")]
        public BooleanValue? ItemPrintTitles
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mergeItem</para>
        /// <para>Represents the following attribute in the schema: mergeItem</para>
        /// </summary>
        [SchemaAttr("mergeItem")]
        public BooleanValue? MergeItem
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showDropZones</para>
        /// <para>Represents the following attribute in the schema: showDropZones</para>
        /// </summary>
        [SchemaAttr("showDropZones")]
        public BooleanValue? ShowDropZones
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>createdVersion</para>
        /// <para>Represents the following attribute in the schema: createdVersion</para>
        /// </summary>
        [SchemaAttr("createdVersion")]
        public ByteValue? CreatedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>indent</para>
        /// <para>Represents the following attribute in the schema: indent</para>
        /// </summary>
        [SchemaAttr("indent")]
        public UInt32Value? Indent
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showEmptyRow</para>
        /// <para>Represents the following attribute in the schema: showEmptyRow</para>
        /// </summary>
        [SchemaAttr("showEmptyRow")]
        public BooleanValue? ShowEmptyRow
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showEmptyCol</para>
        /// <para>Represents the following attribute in the schema: showEmptyCol</para>
        /// </summary>
        [SchemaAttr("showEmptyCol")]
        public BooleanValue? ShowEmptyColumn
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showHeaders</para>
        /// <para>Represents the following attribute in the schema: showHeaders</para>
        /// </summary>
        [SchemaAttr("showHeaders")]
        public BooleanValue? ShowHeaders
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>compact</para>
        /// <para>Represents the following attribute in the schema: compact</para>
        /// </summary>
        [SchemaAttr("compact")]
        public BooleanValue? Compact
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outline</para>
        /// <para>Represents the following attribute in the schema: outline</para>
        /// </summary>
        [SchemaAttr("outline")]
        public BooleanValue? Outline
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>outlineData</para>
        /// <para>Represents the following attribute in the schema: outlineData</para>
        /// </summary>
        [SchemaAttr("outlineData")]
        public BooleanValue? OutlineData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>compactData</para>
        /// <para>Represents the following attribute in the schema: compactData</para>
        /// </summary>
        [SchemaAttr("compactData")]
        public BooleanValue? CompactData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>published</para>
        /// <para>Represents the following attribute in the schema: published</para>
        /// </summary>
        [SchemaAttr("published")]
        public BooleanValue? Published
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>gridDropZones</para>
        /// <para>Represents the following attribute in the schema: gridDropZones</para>
        /// </summary>
        [SchemaAttr("gridDropZones")]
        public BooleanValue? GridDropZones
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>immersive</para>
        /// <para>Represents the following attribute in the schema: immersive</para>
        /// </summary>
        [SchemaAttr("immersive")]
        public BooleanValue? StopImmersiveUi
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>multipleFieldFilters</para>
        /// <para>Represents the following attribute in the schema: multipleFieldFilters</para>
        /// </summary>
        [SchemaAttr("multipleFieldFilters")]
        public BooleanValue? MultipleFieldFilters
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>chartFormat</para>
        /// <para>Represents the following attribute in the schema: chartFormat</para>
        /// </summary>
        [SchemaAttr("chartFormat")]
        public UInt32Value? ChartFormat
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowHeaderCaption</para>
        /// <para>Represents the following attribute in the schema: rowHeaderCaption</para>
        /// </summary>
        [SchemaAttr("rowHeaderCaption")]
        public StringValue? RowHeaderCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>colHeaderCaption</para>
        /// <para>Represents the following attribute in the schema: colHeaderCaption</para>
        /// </summary>
        [SchemaAttr("colHeaderCaption")]
        public StringValue? ColumnHeaderCaption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fieldListSortAscending</para>
        /// <para>Represents the following attribute in the schema: fieldListSortAscending</para>
        /// </summary>
        [SchemaAttr("fieldListSortAscending")]
        public BooleanValue? FieldListSortAscending
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>mdxSubqueries</para>
        /// <para>Represents the following attribute in the schema: mdxSubqueries</para>
        /// </summary>
        [SchemaAttr("mdxSubqueries")]
        public BooleanValue? MdxSubqueries
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customListSort</para>
        /// <para>Represents the following attribute in the schema: customListSort</para>
        /// </summary>
        [SchemaAttr("customListSort")]
        public BooleanValue? CustomListSort
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xr:pivotTableDefinition");
            builder.Availability = FileFormatVersions.Office2016;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ChartFormats>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnItems>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DataFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Formats>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Location>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PageFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotFilters>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowFields>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowItems>();
            builder.AddElement<pivotTableDefinition>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("cacheId", a => a.CacheId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("dataOnRows", a => a.DataOnRows)
                .AddAttribute("dataPosition", a => a.DataPosition)
                .AddAttribute("autoFormatId", a => a.AutoFormatId)
                .AddAttribute("applyNumberFormats", a => a.ApplyNumberFormats)
                .AddAttribute("applyBorderFormats", a => a.ApplyBorderFormats)
                .AddAttribute("applyFontFormats", a => a.ApplyFontFormats)
                .AddAttribute("applyPatternFormats", a => a.ApplyPatternFormats)
                .AddAttribute("applyAlignmentFormats", a => a.ApplyAlignmentFormats)
                .AddAttribute("applyWidthHeightFormats", a => a.ApplyWidthHeightFormats)
                .AddAttribute("dataCaption", a => a.DataCaption, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("grandTotalCaption", a => a.GrandTotalCaption)
                .AddAttribute("errorCaption", a => a.ErrorCaption)
                .AddAttribute("showError", a => a.ShowError)
                .AddAttribute("missingCaption", a => a.MissingCaption)
                .AddAttribute("showMissing", a => a.ShowMissing)
                .AddAttribute("pageStyle", a => a.PageStyle)
                .AddAttribute("pivotTableStyle", a => a.PivotTableStyleName)
                .AddAttribute("vacatedStyle", a => a.VacatedStyle)
                .AddAttribute("tag", a => a.Tag)
                .AddAttribute("updatedVersion", a => a.UpdatedVersion)
                .AddAttribute("minRefreshableVersion", a => a.MinRefreshableVersion)
                .AddAttribute("asteriskTotals", a => a.AsteriskTotals)
                .AddAttribute("showItems", a => a.ShowItems)
                .AddAttribute("editData", a => a.EditData)
                .AddAttribute("disableFieldList", a => a.DisableFieldList)
                .AddAttribute("showCalcMbrs", a => a.ShowCalculatedMembers)
                .AddAttribute("visualTotals", a => a.VisualTotals)
                .AddAttribute("showMultipleLabel", a => a.ShowMultipleLabel)
                .AddAttribute("showDataDropDown", a => a.ShowDataDropDown)
                .AddAttribute("showDrill", a => a.ShowDrill)
                .AddAttribute("printDrill", a => a.PrintDrill)
                .AddAttribute("showMemberPropertyTips", a => a.ShowMemberPropertyTips)
                .AddAttribute("showDataTips", a => a.ShowDataTips)
                .AddAttribute("enableWizard", a => a.EnableWizard)
                .AddAttribute("enableDrill", a => a.EnableDrill)
                .AddAttribute("enableFieldProperties", a => a.EnableFieldProperties)
                .AddAttribute("preserveFormatting", a => a.PreserveFormatting)
                .AddAttribute("useAutoFormatting", a => a.UseAutoFormatting)
                .AddAttribute("pageWrap", a => a.PageWrap)
                .AddAttribute("pageOverThenDown", a => a.PageOverThenDown)
                .AddAttribute("subtotalHiddenItems", a => a.SubtotalHiddenItems)
                .AddAttribute("rowGrandTotals", a => a.RowGrandTotals)
                .AddAttribute("colGrandTotals", a => a.ColumnGrandTotals)
                .AddAttribute("fieldPrintTitles", a => a.FieldPrintTitles)
                .AddAttribute("itemPrintTitles", a => a.ItemPrintTitles)
                .AddAttribute("mergeItem", a => a.MergeItem)
                .AddAttribute("showDropZones", a => a.ShowDropZones)
                .AddAttribute("createdVersion", a => a.CreatedVersion)
                .AddAttribute("indent", a => a.Indent)
                .AddAttribute("showEmptyRow", a => a.ShowEmptyRow)
                .AddAttribute("showEmptyCol", a => a.ShowEmptyColumn)
                .AddAttribute("showHeaders", a => a.ShowHeaders)
                .AddAttribute("compact", a => a.Compact)
                .AddAttribute("outline", a => a.Outline)
                .AddAttribute("outlineData", a => a.OutlineData)
                .AddAttribute("compactData", a => a.CompactData)
                .AddAttribute("published", a => a.Published)
                .AddAttribute("gridDropZones", a => a.GridDropZones)
                .AddAttribute("immersive", a => a.StopImmersiveUi)
                .AddAttribute("multipleFieldFilters", a => a.MultipleFieldFilters)
                .AddAttribute("chartFormat", a => a.ChartFormat)
                .AddAttribute("rowHeaderCaption", a => a.RowHeaderCaption)
                .AddAttribute("colHeaderCaption", a => a.ColumnHeaderCaption)
                .AddAttribute("fieldListSortAscending", a => a.FieldListSortAscending)
                .AddAttribute("mdxSubqueries", a => a.MdxSubqueries)
                .AddAttribute("customListSort", a => a.CustomListSort);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Location), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowItems), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnItems), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PageFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DataFields), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Formats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ChartFormats), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotFilters), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Location.</para>
        /// <para>Represents the following element tag in the schema: x:location.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Location? Location
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Location>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotFields.</para>
        /// <para>Represents the following element tag in the schema: x:pivotFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotFields? PivotFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RowFields.</para>
        /// <para>Represents the following element tag in the schema: x:rowFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.RowFields? RowFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RowItems.</para>
        /// <para>Represents the following element tag in the schema: x:rowItems.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.RowItems? RowItems
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnFields.</para>
        /// <para>Represents the following element tag in the schema: x:colFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColumnFields? ColumnFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnItems.</para>
        /// <para>Represents the following element tag in the schema: x:colItems.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColumnItems? ColumnItems
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PageFields.</para>
        /// <para>Represents the following element tag in the schema: x:pageFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PageFields? PageFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PageFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataFields.</para>
        /// <para>Represents the following element tag in the schema: x:dataFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.DataFields? DataFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.DataFields>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Formats.</para>
        /// <para>Represents the following element tag in the schema: x:formats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.Formats? Formats
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.Formats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ConditionalFormats.</para>
        /// <para>Represents the following element tag in the schema: x:conditionalFormats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats? ConditionalFormats
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ChartFormats.</para>
        /// <para>Represents the following element tag in the schema: x:chartFormats.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ChartFormats? ChartFormats
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ChartFormats>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotHierarchies.</para>
        /// <para>Represents the following element tag in the schema: x:pivotHierarchies.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies? PivotHierarchies
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotHierarchies>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotTableStyle.</para>
        /// <para>Represents the following element tag in the schema: x:pivotTableStyleInfo.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle? PivotTableStyle
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableStyle>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotFilters.</para>
        /// <para>Represents the following element tag in the schema: x:filters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotFilters? PivotFilters
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RowHierarchiesUsage.</para>
        /// <para>Represents the following element tag in the schema: x:rowHierarchiesUsage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage? RowHierarchiesUsage
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.RowHierarchiesUsage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ColumnHierarchiesUsage.</para>
        /// <para>Represents the following element tag in the schema: x:colHierarchiesUsage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage? ColumnHierarchiesUsage
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.ColumnHierarchiesUsage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotTableDefinitionExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList? PivotTableDefinitionExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.PivotTableDefinitionExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<pivotTableDefinition>(deep);
    }

    /// <summary>
    /// Defines the RevisionContext enumeration.
    /// </summary>
    public enum RevisionContext
    {
        /// <summary>
        /// normal.
        /// <para>When the item is serialized out as xml, its value is "normal".</para>
        /// </summary>
        [EnumString("normal")]
        Normal,
        /// <summary>
        /// undo.
        /// <para>When the item is serialized out as xml, its value is "undo".</para>
        /// </summary>
        [EnumString("undo")]
        Undo,
        /// <summary>
        /// redo.
        /// <para>When the item is serialized out as xml, its value is "redo".</para>
        /// </summary>
        [EnumString("redo")]
        Redo,
        /// <summary>
        /// copy.
        /// <para>When the item is serialized out as xml, its value is "copy".</para>
        /// </summary>
        [EnumString("copy")]
        Copy
    }

    /// <summary>
    /// Defines the RwColAction enumeration.
    /// </summary>
    public enum RwColAction
    {
        /// <summary>
        /// insr.
        /// <para>When the item is serialized out as xml, its value is "insr".</para>
        /// </summary>
        [EnumString("insr")]
        Insr,
        /// <summary>
        /// delr.
        /// <para>When the item is serialized out as xml, its value is "delr".</para>
        /// </summary>
        [EnumString("delr")]
        Delr,
        /// <summary>
        /// insc.
        /// <para>When the item is serialized out as xml, its value is "insc".</para>
        /// </summary>
        [EnumString("insc")]
        Insc,
        /// <summary>
        /// delc.
        /// <para>When the item is serialized out as xml, its value is "delc".</para>
        /// </summary>
        [EnumString("delc")]
        Delc
    }

    /// <summary>
    /// Defines the FeatureType enumeration.
    /// </summary>
    public enum FeatureType
    {
        /// <summary>
        /// dataValidation.
        /// <para>When the item is serialized out as xml, its value is "dataValidation".</para>
        /// </summary>
        [EnumString("dataValidation")]
        DataValidation,
        /// <summary>
        /// hyperlink.
        /// <para>When the item is serialized out as xml, its value is "hyperlink".</para>
        /// </summary>
        [EnumString("hyperlink")]
        Hyperlink,
        /// <summary>
        /// rowColVisualOps.
        /// <para>When the item is serialized out as xml, its value is "rowColVisualOps".</para>
        /// </summary>
        [EnumString("rowColVisualOps")]
        RowColVisualOps,
        /// <summary>
        /// freezePanes.
        /// <para>When the item is serialized out as xml, its value is "freezePanes".</para>
        /// </summary>
        [EnumString("freezePanes")]
        FreezePanes,
        /// <summary>
        /// sparklines.
        /// <para>When the item is serialized out as xml, its value is "sparklines".</para>
        /// </summary>
        [EnumString("sparklines")]
        Sparklines,
        /// <summary>
        /// hideUnhideSheet.
        /// <para>When the item is serialized out as xml, its value is "hideUnhideSheet".</para>
        /// </summary>
        [EnumString("hideUnhideSheet")]
        HideUnhideSheet,
        /// <summary>
        /// showGridlinesHeadings.
        /// <para>When the item is serialized out as xml, its value is "showGridlinesHeadings".</para>
        /// </summary>
        [EnumString("showGridlinesHeadings")]
        ShowGridlinesHeadings,
        /// <summary>
        /// comment.
        /// <para>When the item is serialized out as xml, its value is "comment".</para>
        /// </summary>
        [EnumString("comment")]
        Comment,
        /// <summary>
        /// outlines.
        /// <para>When the item is serialized out as xml, its value is "outlines".</para>
        /// </summary>
        [EnumString("outlines")]
        Outlines,
        /// <summary>
        /// drawingElement.
        /// <para>When the item is serialized out as xml, its value is "drawingElement".</para>
        /// </summary>
        [EnumString("drawingElement")]
        DrawingElement,
        /// <summary>
        /// autoFilter.
        /// <para>When the item is serialized out as xml, its value is "autoFilter".</para>
        /// </summary>
        [EnumString("autoFilter")]
        AutoFilter,
        /// <summary>
        /// pivotTable.
        /// <para>When the item is serialized out as xml, its value is "pivotTable".</para>
        /// </summary>
        [EnumString("pivotTable")]
        PivotTable,
        /// <summary>
        /// future.
        /// <para>When the item is serialized out as xml, its value is "future".</para>
        /// </summary>
        [EnumString("future")]
        Future
    }

    /// <summary>
    /// Defines the ExtFeatureType enumeration.
    /// </summary>
    public enum ExtFeatureType
    {
        /// <summary>
        /// reserved.
        /// <para>When the item is serialized out as xml, its value is "reserved".</para>
        /// </summary>
        [EnumString("reserved")]
        Reserved
    }

    /// <summary>
    /// Defines the SubFeatureType enumeration.
    /// </summary>
    public enum SubFeatureType
    {
        /// <summary>
        /// none.
        /// <para>When the item is serialized out as xml, its value is "none".</para>
        /// </summary>
        [EnumString("none")]
        None,
        /// <summary>
        /// future.
        /// <para>When the item is serialized out as xml, its value is "future".</para>
        /// </summary>
        [EnumString("future")]
        Future
    }

    /// <summary>
    /// Defines the ExtSubFeatureType enumeration.
    /// </summary>
    public enum ExtSubFeatureType
    {
        /// <summary>
        /// reserved.
        /// <para>When the item is serialized out as xml, its value is "reserved".</para>
        /// </summary>
        [EnumString("reserved")]
        Reserved
    }

    /// <summary>
    /// Defines the RowColVisualOp enumeration.
    /// </summary>
    public enum RowColVisualOp
    {
        /// <summary>
        /// hide.
        /// <para>When the item is serialized out as xml, its value is "hide".</para>
        /// </summary>
        [EnumString("hide")]
        Hide,
        /// <summary>
        /// unhide.
        /// <para>When the item is serialized out as xml, its value is "unhide".</para>
        /// </summary>
        [EnumString("unhide")]
        Unhide,
        /// <summary>
        /// resize.
        /// <para>When the item is serialized out as xml, its value is "resize".</para>
        /// </summary>
        [EnumString("resize")]
        Resize,
        /// <summary>
        /// autosize.
        /// <para>When the item is serialized out as xml, its value is "autosize".</para>
        /// </summary>
        [EnumString("autosize")]
        Autosize
    }

    /// <summary>
    /// Defines the SheetOp enumeration.
    /// </summary>
    public enum SheetOp
    {
        /// <summary>
        /// insert.
        /// <para>When the item is serialized out as xml, its value is "insert".</para>
        /// </summary>
        [EnumString("insert")]
        Insert,
        /// <summary>
        /// delete.
        /// <para>When the item is serialized out as xml, its value is "delete".</para>
        /// </summary>
        [EnumString("delete")]
        Delete,
        /// <summary>
        /// reorder.
        /// <para>When the item is serialized out as xml, its value is "reorder".</para>
        /// </summary>
        [EnumString("reorder")]
        Reorder,
        /// <summary>
        /// rename.
        /// <para>When the item is serialized out as xml, its value is "rename".</para>
        /// </summary>
        [EnumString("rename")]
        Rename
    }

    /// <summary>
    /// Defines the FillType enumeration.
    /// </summary>
    public enum FillType
    {
        /// <summary>
        /// fill.
        /// <para>When the item is serialized out as xml, its value is "fill".</para>
        /// </summary>
        [EnumString("fill")]
        Fill,
        /// <summary>
        /// array.
        /// <para>When the item is serialized out as xml, its value is "array".</para>
        /// </summary>
        [EnumString("array")]
        Array,
        /// <summary>
        /// future.
        /// <para>When the item is serialized out as xml, its value is "future".</para>
        /// </summary>
        [EnumString("future")]
        Future
    }

    /// <summary>
    /// Defines the FillTypeExt enumeration.
    /// </summary>
    public enum FillTypeExt
    {
        /// <summary>
        /// test.
        /// <para>When the item is serialized out as xml, its value is "test".</para>
        /// </summary>
        [EnumString("test")]
        Test
    }

    /// <summary>
    /// Defines the AdjustType enumeration.
    /// </summary>
    public enum AdjustType
    {
        /// <summary>
        /// fmla.
        /// <para>When the item is serialized out as xml, its value is "fmla".</para>
        /// </summary>
        [EnumString("fmla")]
        Fmla,
        /// <summary>
        /// format.
        /// <para>When the item is serialized out as xml, its value is "format".</para>
        /// </summary>
        [EnumString("format")]
        Format,
        /// <summary>
        /// condFmt.
        /// <para>When the item is serialized out as xml, its value is "condFmt".</para>
        /// </summary>
        [EnumString("condFmt")]
        CondFmt,
        /// <summary>
        /// sparkline.
        /// <para>When the item is serialized out as xml, its value is "sparkline".</para>
        /// </summary>
        [EnumString("sparkline")]
        Sparkline,
        /// <summary>
        /// anchor.
        /// <para>When the item is serialized out as xml, its value is "anchor".</para>
        /// </summary>
        [EnumString("anchor")]
        Anchor,
        /// <summary>
        /// fmlaNoSticky.
        /// <para>When the item is serialized out as xml, its value is "fmlaNoSticky".</para>
        /// </summary>
        [EnumString("fmlaNoSticky")]
        FmlaNoSticky,
        /// <summary>
        /// noAdj.
        /// <para>When the item is serialized out as xml, its value is "noAdj".</para>
        /// </summary>
        [EnumString("noAdj")]
        NoAdj,
        /// <summary>
        /// fragile.
        /// <para>When the item is serialized out as xml, its value is "fragile".</para>
        /// </summary>
        [EnumString("fragile")]
        Fragile,
        /// <summary>
        /// future.
        /// <para>When the item is serialized out as xml, its value is "future".</para>
        /// </summary>
        [EnumString("future")]
        Future
    }

    /// <summary>
    /// Defines the AdjustTypeExt enumeration.
    /// </summary>
    public enum AdjustTypeExt
    {
        /// <summary>
        /// test.
        /// <para>When the item is serialized out as xml, its value is "test".</para>
        /// </summary>
        [EnumString("test")]
        Test
    }

    /// <summary>
    /// Defines the OartAnchorType enumeration.
    /// </summary>
    public enum OartAnchorType
    {
        /// <summary>
        /// twoCell.
        /// <para>When the item is serialized out as xml, its value is "twoCell".</para>
        /// </summary>
        [EnumString("twoCell")]
        TwoCell,
        /// <summary>
        /// oneCell.
        /// <para>When the item is serialized out as xml, its value is "oneCell".</para>
        /// </summary>
        [EnumString("oneCell")]
        OneCell,
        /// <summary>
        /// absolute.
        /// <para>When the item is serialized out as xml, its value is "absolute".</para>
        /// </summary>
        [EnumString("absolute")]
        Absolute
    }
}