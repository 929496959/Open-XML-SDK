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

namespace DocumentFormat.OpenXml.Office.Excel
{
    /// <summary>
    /// <para>Defines the Macrosheet Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:macrosheet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.AutoFilter" /> <c>&lt;x:autoFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Columns" /> <c>&lt;x:cols></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting" /> <c>&lt;x:conditionalFormatting></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.CustomProperties" /> <c>&lt;x:customProperties></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews" /> <c>&lt;x:customSheetViews></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DataConsolidate" /> <c>&lt;x:dataConsolidate></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Drawing" /> <c>&lt;x:drawing></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter" /> <c>&lt;x:drawingHF></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.HeaderFooter" /> <c>&lt;x:headerFooter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing" /> <c>&lt;x:legacyDrawing></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter" /> <c>&lt;x:legacyDrawingHF></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.OleObjects" /> <c>&lt;x:oleObjects></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.RowBreaks" /> <c>&lt;x:rowBreaks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks" /> <c>&lt;x:colBreaks></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PageMargins" /> <c>&lt;x:pageMargins></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PageSetup" /> <c>&lt;x:pageSetup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties" /> <c>&lt;x:phoneticPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PrintOptions" /> <c>&lt;x:printOptions></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Picture" /> <c>&lt;x:picture></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SheetData" /> <c>&lt;x:sheetData></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SheetDimension" /> <c>&lt;x:dimension></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties" /> <c>&lt;x:sheetFormatPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SheetProperties" /> <c>&lt;x:sheetPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SheetProtection" /> <c>&lt;x:sheetProtection></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SheetViews" /> <c>&lt;x:sheetViews></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SortState" /> <c>&lt;x:sortState></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xne:macrosheet")]
    public partial class Macrosheet : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Macrosheet class.
        /// </summary>
        public Macrosheet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Macrosheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Macrosheet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Macrosheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Macrosheet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Macrosheet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Macrosheet(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:macrosheet");
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.AutoFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Columns>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.CustomProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DataConsolidate>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Drawing>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.HeaderFooter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.OleObjects>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.RowBreaks>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PageMargins>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PageSetup>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PrintOptions>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Picture>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SheetData>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SheetDimension>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SheetProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SheetProtection>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SheetViews>();
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.SortState>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetDimension), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetViews), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Columns), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetData), 1, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SheetProtection), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.AutoFilter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.SortState), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DataConsolidate), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomSheetViews), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PhoneticProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ConditionalFormatting), 0, 0),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PrintOptions), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PageMargins), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PageSetup), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.HeaderFooter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.RowBreaks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ColumnBreaks), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.CustomProperties), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Drawing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawing), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingHeaderFooter), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Picture), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.OleObjects), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DrawingHeaderFooter), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.ExtensionList), 0, 1)
            };
        }

        /// <summary>
        /// <para>Sheet Properties.</para>
        /// <para>Represents the following element tag in the schema: x:sheetPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetProperties? SheetProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Macro Sheet Dimensions.</para>
        /// <para>Represents the following element tag in the schema: x:dimension.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetDimension? SheetDimension
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetDimension>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Macro Sheet Views.</para>
        /// <para>Represents the following element tag in the schema: x:sheetViews.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetViews? SheetViews
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetViews>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Sheet Format Properties.</para>
        /// <para>Represents the following element tag in the schema: x:sheetFormatPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties? SheetFormatProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.SheetFormatProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Macrosheet>(deep);

        internal Macrosheet(MacroSheetPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the MacroSheetPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(MacroSheetPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the MacroSheetPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(MacroSheetPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the MacroSheetPart associated with this element.
        /// </summary>
        public MacroSheetPart? MacroSheetPart
        {
            get => OpenXmlPart as MacroSheetPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Worksheet Sort Map.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:worksheetSortMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Excel.ColumnSortMap" /> <c>&lt;xne:colSortMap></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Excel.RowSortMap" /> <c>&lt;xne:rowSortMap></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xne:worksheetSortMap")]
    public partial class WorksheetSortMap : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class.
        /// </summary>
        public WorksheetSortMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetSortMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WorksheetSortMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WorksheetSortMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WorksheetSortMap(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:worksheetSortMap");
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ColumnSortMap>();
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.RowSortMap>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.RowSortMap), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ColumnSortMap), 0, 1)
            };
        }

        /// <summary>
        /// <para>Row Sort Map.</para>
        /// <para>Represents the following element tag in the schema: xne:rowSortMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.RowSortMap? RowSortMap
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.RowSortMap>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Column Sort Map.</para>
        /// <para>Represents the following element tag in the schema: xne:colSortMap.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xne = http://schemas.microsoft.com/office/excel/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Office.Excel.ColumnSortMap? ColumnSortMap
        {
            get => GetElement<DocumentFormat.OpenXml.Office.Excel.ColumnSortMap>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorksheetSortMap>(deep);

        internal WorksheetSortMap(WorksheetSortMapPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the WorksheetSortMapPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(WorksheetSortMapPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the WorksheetSortMapPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(WorksheetSortMapPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the WorksheetSortMapPart associated with this element.
        /// </summary>
        public WorksheetSortMapPart? WorksheetSortMapPart
        {
            get => OpenXmlPart as WorksheetSortMapPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ReferenceSequence Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:sqref.</para>
    /// </summary>
    [SchemaAttr("xne:sqref")]
    public partial class ReferenceSequence : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ReferenceSequence class.
        /// </summary>
        public ReferenceSequence() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ReferenceSequence class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ReferenceSequence(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new ListValue<StringValue> { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddValidator<ListValue<StringValue>>(NumberValidator.Instance);
            builder.SetSchema("xne:sqref");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ReferenceSequence>(deep);
    }

    /// <summary>
    /// <para>Defines the Formula Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:f.</para>
    /// </summary>
    [SchemaAttr("xne:f")]
    public partial class Formula : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the Formula class.
        /// </summary>
        public Formula() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Formula class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public Formula(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:f");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Formula>(deep);
    }

    /// <summary>
    /// <para>Row Sort Map.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:rowSortMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Excel.RowSortMapItem" /> <c>&lt;xne:row></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xne:rowSortMap")]
    public partial class RowSortMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RowSortMap class.
        /// </summary>
        public RowSortMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RowSortMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RowSortMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RowSortMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RowSortMap(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr("count")]
        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:rowSortMap");
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.RowSortMapItem>();
            builder.AddElement<RowSortMap>()
                .AddAttribute("ref", a => a.Ref, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MaxInclusive = (536870910L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.RowSortMapItem), 1, 536870910)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSortMap>(deep);
    }

    /// <summary>
    /// <para>Column Sort Map.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:colSortMap.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Excel.ColumnSortMapItem" /> <c>&lt;xne:col></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xne:colSortMap")]
    public partial class ColumnSortMap : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class.
        /// </summary>
        public ColumnSortMap() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColumnSortMap(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ColumnSortMap(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ColumnSortMap class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ColumnSortMap(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Reference</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Ref
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Count</para>
        /// <para>Represents the following attribute in the schema: count</para>
        /// </summary>
        [SchemaAttr("count")]
        public UInt32Value? Count
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:colSortMap");
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.ColumnSortMapItem>();
            builder.AddElement<ColumnSortMap>()
                .AddAttribute("ref", a => a.Ref, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(new NumberValidator() { MaxInclusive = (536870910L) });
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.ColumnSortMapItem), 1, 536870910)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSortMap>(deep);
    }

    /// <summary>
    /// <para>Row.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:row.</para>
    /// </summary>
    [SchemaAttr("xne:row")]
    public partial class RowSortMapItem : SortMapItemType
    {
        /// <summary>
        /// Initializes a new instance of the RowSortMapItem class.
        /// </summary>
        public RowSortMapItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:row");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RowSortMapItem>(deep);
    }

    /// <summary>
    /// <para>Column.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xne:col.</para>
    /// </summary>
    [SchemaAttr("xne:col")]
    public partial class ColumnSortMapItem : SortMapItemType
    {
        /// <summary>
        /// Initializes a new instance of the ColumnSortMapItem class.
        /// </summary>
        public ColumnSortMapItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xne:col");
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ColumnSortMapItem>(deep);
    }

    /// <summary>
    /// <para>Defines the SortMapItemType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class SortMapItemType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SortMapItemType class.
        /// </summary>
        protected SortMapItemType() : base()
        {
        }

        /// <summary>
        /// <para>New Value</para>
        /// <para>Represents the following attribute in the schema: newVal</para>
        /// </summary>
        [SchemaAttr("newVal")]
        public UInt32Value? NewVal
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Old Value</para>
        /// <para>Represents the following attribute in the schema: oldVal</para>
        /// </summary>
        [SchemaAttr("oldVal")]
        public UInt32Value? OldVal
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<SortMapItemType>()
                .AddAttribute("newVal", a => a.NewVal, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("oldVal", a => a.OldVal, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }
}