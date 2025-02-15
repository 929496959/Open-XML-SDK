﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2019.Excel.RichData2
{
    /// <summary>
    /// <para>Defines the RichFilterColumn Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:filterColumn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilters" /> <c>&lt;xlrd2:customFilters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.DynamicRichFilter" /> <c>&lt;xlrd2:dynamicFilter></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilters" /> <c>&lt;xlrd2:filters></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichTop10" /> <c>&lt;xlrd2:top10></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:filterColumn")]
    public partial class RichFilterColumn : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class.
        /// </summary>
        public RichFilterColumn() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilterColumn(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilterColumn(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilterColumn class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichFilterColumn(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:filterColumn");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilters>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.DynamicRichFilter>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilters>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichTop10>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilters), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichTop10), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilters), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.DynamicRichFilter), 1, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichFilters.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:filters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilters? RichFilters
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichTop10.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:top10.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichTop10? RichTop10
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichTop10>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>CustomRichFilters.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:customFilters.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilters? CustomRichFilters
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilters>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DynamicRichFilter.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:dynamicFilter.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.DynamicRichFilter? DynamicRichFilter
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.DynamicRichFilter>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFilterColumn>(deep);
    }

    /// <summary>
    /// <para>Defines the RichSortCondition Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richSortCondition.</para>
    /// </summary>
    [SchemaAttr("xlrd2:richSortCondition")]
    public partial class RichSortCondition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichSortCondition class.
        /// </summary>
        public RichSortCondition() : base()
        {
        }

        /// <summary>
        /// <para>richSortKey, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: richSortKey</para>
        /// </summary>
        [SchemaAttr("richSortKey")]
        public StringValue? RichSortKey
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>descending, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: descending</para>
        /// </summary>
        [SchemaAttr("descending")]
        public BooleanValue? Descending
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortBy, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sortBy</para>
        /// </summary>
        [SchemaAttr("sortBy")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>? SortBy
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.SortByValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>ref, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: ref</para>
        /// </summary>
        [SchemaAttr("ref")]
        public StringValue? Reference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customList, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: customList</para>
        /// </summary>
        [SchemaAttr("customList")]
        public StringValue? CustomList
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>
        [SchemaAttr("dxfId")]
        public UInt32Value? FormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconSet, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: iconSet</para>
        /// </summary>
        [SchemaAttr("iconSet")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>? IconSet
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.IconSetTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>iconId, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: iconId</para>
        /// </summary>
        [SchemaAttr("iconId")]
        public UInt32Value? IconId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:richSortCondition");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichSortCondition>()
                .AddAttribute("richSortKey", a => a.RichSortKey)
                .AddAttribute("descending", a => a.Descending)
                .AddAttribute("sortBy", a => a.SortBy)
                .AddAttribute("ref", a => a.Reference, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("customList", a => a.CustomList)
                .AddAttribute("dxfId", a => a.FormatId)
                .AddAttribute("iconSet", a => a.IconSet)
                .AddAttribute("iconId", a => a.IconId);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichSortCondition>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBags Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:supportingPropertyBags.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayData" /> <c>&lt;xlrd2:spbArrays></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagData" /> <c>&lt;xlrd2:spbData></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:supportingPropertyBags")]
    public partial class SupportingPropertyBags : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class.
        /// </summary>
        public SupportingPropertyBags() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBags(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBags(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBags class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBags(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:supportingPropertyBags");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayData>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagData>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayData), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagData), 1, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>SupportingPropertyBagArrayData.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:spbArrays.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayData? SupportingPropertyBagArrayData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayData>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SupportingPropertyBagData.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:spbData.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagData? SupportingPropertyBagData
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagData>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBags>(deep);

        internal SupportingPropertyBags(RdSupportingPropertyBagPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RdSupportingPropertyBagPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RdSupportingPropertyBagPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RdSupportingPropertyBagPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RdSupportingPropertyBagPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RdSupportingPropertyBagPart associated with this element.
        /// </summary>
        public RdSupportingPropertyBagPart? RdSupportingPropertyBagPart
        {
            get => OpenXmlPart as RdSupportingPropertyBagPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagStructures Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spbStructures.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructure" /> <c>&lt;xlrd2:s></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:spbStructures")]
    public partial class SupportingPropertyBagStructures : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class.
        /// </summary>
        public SupportingPropertyBagStructures() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructures(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructures(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructures class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagStructures(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
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
            builder.SetSchema("xlrd2:spbStructures");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructure>();
            builder.AddElement<SupportingPropertyBagStructures>()
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagStructure), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagStructures>(deep);

        internal SupportingPropertyBagStructures(RdSupportingPropertyBagStructurePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RdSupportingPropertyBagStructurePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RdSupportingPropertyBagStructurePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RdSupportingPropertyBagStructurePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RdSupportingPropertyBagStructurePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RdSupportingPropertyBagStructurePart associated with this element.
        /// </summary>
        public RdSupportingPropertyBagStructurePart? RdSupportingPropertyBagStructurePart
        {
            get => OpenXmlPart as RdSupportingPropertyBagStructurePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the ArrayData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:arrayData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.Array" /> <c>&lt;xlrd2:a></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:arrayData")]
    public partial class ArrayData : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the ArrayData class.
        /// </summary>
        public ArrayData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArrayData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ArrayData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ArrayData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
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
            builder.SetSchema("xlrd2:arrayData");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.Array>();
            builder.AddElement<ArrayData>()
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.Array), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArrayData>(deep);

        internal ArrayData(RdArrayPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RdArrayPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RdArrayPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RdArrayPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RdArrayPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RdArrayPart associated with this element.
        /// </summary>
        public RdArrayPart? RdArrayPart
        {
            get => OpenXmlPart as RdArrayPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the RichStylesheet Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richStyleSheet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.Dxfs" /> <c>&lt;xlrd2:dxfs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperties" /> <c>&lt;xlrd2:richProperties></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyles" /> <c>&lt;xlrd2:richStyles></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:richStyleSheet")]
    public partial class RichStylesheet : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStylesheet class.
        /// </summary>
        public RichStylesheet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylesheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStylesheet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylesheet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStylesheet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylesheet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichStylesheet(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:richStyleSheet");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.Dxfs>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyles>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.Dxfs), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperties), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyles), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>Dxfs.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:dxfs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.Dxfs? Dxfs
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.Dxfs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichFormatProperties.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:richProperties.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperties? RichFormatProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichStyles.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:richStyles.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyles? RichStyles
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyles>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStylesheet>(deep);

        internal RichStylesheet(RichStylesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RichStylesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RichStylesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RichStylesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RichStylesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RichStylesPart associated with this element.
        /// </summary>
        public RichStylesPart? RichStylesPart
        {
            get => OpenXmlPart as RichStylesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the RichValueTypesInfo Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rvTypesInfo.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueGlobalType" /> <c>&lt;xlrd2:global></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypes" /> <c>&lt;xlrd2:types></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:rvTypesInfo")]
    public partial class RichValueTypesInfo : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class.
        /// </summary>
        public RichValueTypesInfo() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypesInfo(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypesInfo(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypesInfo class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypesInfo(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:rvTypesInfo");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueGlobalType>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypes>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueGlobalType), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypes), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueGlobalType.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:global.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueGlobalType? RichValueGlobalType
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueGlobalType>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RichValueTypes.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:types.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypes? RichValueTypes
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypes>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypesInfo>(deep);

        internal RichValueTypesInfo(RdRichValueTypesPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RdRichValueTypesPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RdRichValueTypesPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RdRichValueTypesPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RdRichValueTypesPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RdRichValueTypesPart associated with this element.
        /// </summary>
        public RdRichValueTypesPart? RdRichValueTypesPart
        {
            get => OpenXmlPart as RdRichValueTypesPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the RichFilters Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:filters.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichDateGroupItem" /> <c>&lt;xlrd2:dateGroupItem></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilter" /> <c>&lt;xlrd2:filter></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:filters")]
    public partial class RichFilters : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFilters class.
        /// </summary>
        public RichFilters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilters(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFilters(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFilters class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichFilters(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:filters");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichDateGroupItem>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilter>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFilter), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichDateGroupItem), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFilters>(deep);
    }

    /// <summary>
    /// <para>Defines the RichTop10 Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:top10.</para>
    /// </summary>
    [SchemaAttr("xlrd2:top10")]
    public partial class RichTop10 : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichTop10 class.
        /// </summary>
        public RichTop10() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>
        [SchemaAttr("key")]
        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top</para>
        /// <para>Represents the following attribute in the schema: top</para>
        /// </summary>
        [SchemaAttr("top")]
        public BooleanValue? Top
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Filter by Percent</para>
        /// <para>Represents the following attribute in the schema: percent</para>
        /// </summary>
        [SchemaAttr("percent")]
        public BooleanValue? Percent
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top or Bottom Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Filter Value</para>
        /// <para>Represents the following attribute in the schema: filterVal</para>
        /// </summary>
        [SchemaAttr("filterVal")]
        public DoubleValue? FilterValue
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:top10");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichTop10>()
                .AddAttribute("key", a => a.Key)
                .AddAttribute("top", a => a.Top)
                .AddAttribute("percent", a => a.Percent)
                .AddAttribute("val", a => a.Val, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("filterVal", a => a.FilterValue);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichTop10>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomRichFilters Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:customFilters.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilter" /> <c>&lt;xlrd2:customFilter></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:customFilters")]
    public partial class CustomRichFilters : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class.
        /// </summary>
        public CustomRichFilters() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomRichFilters(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomRichFilters(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomRichFilters class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomRichFilters(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>and, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: and</para>
        /// </summary>
        [SchemaAttr("and")]
        public BooleanValue? And
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:customFilters");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilter>();
            builder.AddElement<CustomRichFilters>()
                .AddAttribute("and", a => a.And);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 2)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.CustomRichFilter), 0, 1, version: FileFormatVersions.Office2019),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomRichFilters>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicRichFilter Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:dynamicFilter.</para>
    /// </summary>
    [SchemaAttr("xlrd2:dynamicFilter")]
    public partial class DynamicRichFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicRichFilter class.
        /// </summary>
        public DynamicRichFilter() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>
        [SchemaAttr("key")]
        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Dynamic filter type</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DynamicFilterValues>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DynamicFilterValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public DoubleValue? Val
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Max Value</para>
        /// <para>Represents the following attribute in the schema: maxVal</para>
        /// </summary>
        [SchemaAttr("maxVal")]
        public DoubleValue? MaxVal
        {
            get => GetAttribute<DoubleValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>valIso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: valIso</para>
        /// </summary>
        [SchemaAttr("valIso")]
        public DateTimeValue? ValIso
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxValIso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: maxValIso</para>
        /// </summary>
        [SchemaAttr("maxValIso")]
        public DateTimeValue? MaxValIso
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:dynamicFilter");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<DynamicRichFilter>()
                .AddAttribute("key", a => a.Key)
                .AddAttribute("type", a => a.Type, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("val", a => a.Val)
                .AddAttribute("maxVal", a => a.MaxVal)
                .AddAttribute("valIso", a => a.ValIso, aBuilder =>
                {
                    aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                })
                .AddAttribute("maxValIso", a => a.MaxValIso, aBuilder =>
                {
                    aBuilder.AddValidator(new OfficeVersionValidator(FileFormatVersions.Office2010));
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicRichFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:extLst")]
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
            builder.SetSchema("xlrd2:extLst");
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
    /// <para>Defines the RichFilter Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:filter.</para>
    /// </summary>
    [SchemaAttr("xlrd2:filter")]
    public partial class RichFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFilter class.
        /// </summary>
        public RichFilter() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>
        [SchemaAttr("key")]
        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>val, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>blank, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: blank</para>
        /// </summary>
        [SchemaAttr("blank")]
        public BooleanValue? Blank
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>nodata, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: nodata</para>
        /// </summary>
        [SchemaAttr("nodata")]
        public BooleanValue? Nodata
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:filter");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichFilter>()
                .AddAttribute("key", a => a.Key)
                .AddAttribute("val", a => a.Val)
                .AddAttribute("blank", a => a.Blank)
                .AddAttribute("nodata", a => a.Nodata);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the RichDateGroupItem Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:dateGroupItem.</para>
    /// </summary>
    [SchemaAttr("xlrd2:dateGroupItem")]
    public partial class RichDateGroupItem : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichDateGroupItem class.
        /// </summary>
        public RichDateGroupItem() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>
        [SchemaAttr("key")]
        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Year</para>
        /// <para>Represents the following attribute in the schema: year</para>
        /// </summary>
        [SchemaAttr("year")]
        public UInt16Value? Year
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Month</para>
        /// <para>Represents the following attribute in the schema: month</para>
        /// </summary>
        [SchemaAttr("month")]
        public UInt16Value? Month
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Day</para>
        /// <para>Represents the following attribute in the schema: day</para>
        /// </summary>
        [SchemaAttr("day")]
        public UInt16Value? Day
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Hour</para>
        /// <para>Represents the following attribute in the schema: hour</para>
        /// </summary>
        [SchemaAttr("hour")]
        public UInt16Value? Hour
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Minute</para>
        /// <para>Represents the following attribute in the schema: minute</para>
        /// </summary>
        [SchemaAttr("minute")]
        public UInt16Value? Minute
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Second</para>
        /// <para>Represents the following attribute in the schema: second</para>
        /// </summary>
        [SchemaAttr("second")]
        public UInt16Value? Second
        {
            get => GetAttribute<UInt16Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Date Time Grouping</para>
        /// <para>Represents the following attribute in the schema: dateTimeGrouping</para>
        /// </summary>
        [SchemaAttr("dateTimeGrouping")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.DateTimeGroupingValues>? DateTimeGrouping
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.DateTimeGroupingValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:dateGroupItem");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichDateGroupItem>()
                .AddAttribute("key", a => a.Key)
                .AddAttribute("year", a => a.Year, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("month", a => a.Month)
                .AddAttribute("day", a => a.Day)
                .AddAttribute("hour", a => a.Hour)
                .AddAttribute("minute", a => a.Minute)
                .AddAttribute("second", a => a.Second)
                .AddAttribute("dateTimeGrouping", a => a.DateTimeGrouping, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichDateGroupItem>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomRichFilter Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:customFilter.</para>
    /// </summary>
    [SchemaAttr("xlrd2:customFilter")]
    public partial class CustomRichFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomRichFilter class.
        /// </summary>
        public CustomRichFilter() : base()
        {
        }

        /// <summary>
        /// <para>key, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: key</para>
        /// </summary>
        [SchemaAttr("key")]
        public StringValue? Key
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Filter Comparison Operator</para>
        /// <para>Represents the following attribute in the schema: operator</para>
        /// </summary>
        [SchemaAttr("operator")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>? Operator
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.FilterOperatorValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Top or Bottom Value</para>
        /// <para>Represents the following attribute in the schema: val</para>
        /// </summary>
        [SchemaAttr("val")]
        public StringValue? Val
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:customFilter");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<CustomRichFilter>()
                .AddAttribute("key", a => a.Key)
                .AddAttribute("operator", a => a.Operator)
                .AddAttribute("val", a => a.Val);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomRichFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagArrayData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spbArrays.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArray" /> <c>&lt;xlrd2:a></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:spbArrays")]
    public partial class SupportingPropertyBagArrayData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class.
        /// </summary>
        public SupportingPropertyBagArrayData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArrayData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArrayData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagArrayData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
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
            builder.SetSchema("xlrd2:spbArrays");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArray>();
            builder.AddElement<SupportingPropertyBagArrayData>()
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArray), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagArrayData>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagData Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spbData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBag" /> <c>&lt;xlrd2:spb></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:spbData")]
    public partial class SupportingPropertyBagData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class.
        /// </summary>
        public SupportingPropertyBagData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
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
            builder.SetSchema("xlrd2:spbData");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBag>();
            builder.AddElement<SupportingPropertyBagData>()
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBag), 0, 0, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagData>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBag Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:spb.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValue" /> <c>&lt;xlrd2:v></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:spb")]
    public partial class SupportingPropertyBag : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class.
        /// </summary>
        public SupportingPropertyBag() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBag(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBag(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBag class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBag(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>s, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: s</para>
        /// </summary>
        [SchemaAttr("s")]
        public UInt32Value? S
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:spb");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValue>();
            builder.AddElement<SupportingPropertyBag>()
                .AddAttribute("s", a => a.S, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValue), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBag>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:v.</para>
    /// </summary>
    [SchemaAttr("xlrd2:v")]
    public partial class SupportingPropertyBagValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagValue class.
        /// </summary>
        public SupportingPropertyBagValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SupportingPropertyBagValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:v");
            builder.Availability = FileFormatVersions.Office2019;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagValue>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagStructure Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:s.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagKey" /> <c>&lt;xlrd2:k></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:s")]
    public partial class SupportingPropertyBagStructure : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class.
        /// </summary>
        public SupportingPropertyBagStructure() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructure(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagStructure(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagStructure class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagStructure(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:s");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagKey>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagKey), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagStructure>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagKey Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:k.</para>
    /// </summary>
    [SchemaAttr("xlrd2:k")]
    public partial class SupportingPropertyBagKey : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagKey class.
        /// </summary>
        public SupportingPropertyBagKey() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:k");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<SupportingPropertyBagKey>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagKey>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagArray Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:a.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValue" /> <c>&lt;xlrd2:v></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:a")]
    public partial class SupportingPropertyBagArray : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class.
        /// </summary>
        public SupportingPropertyBagArray() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArray(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SupportingPropertyBagArray(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArray class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SupportingPropertyBagArray(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2019 and later.</para>
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
            builder.SetSchema("xlrd2:a");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValue>();
            builder.AddElement<SupportingPropertyBagArray>()
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValue), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagArray>(deep);
    }

    /// <summary>
    /// <para>Defines the SupportingPropertyBagArrayValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:v.</para>
    /// </summary>
    [SchemaAttr("xlrd2:v")]
    public partial class SupportingPropertyBagArrayValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayValue class.
        /// </summary>
        public SupportingPropertyBagArrayValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SupportingPropertyBagArrayValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SupportingPropertyBagArrayValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.SupportingPropertyBagArrayValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:v");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<SupportingPropertyBagArrayValue>()
                .AddAttribute("t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SupportingPropertyBagArrayValue>(deep);
    }

    /// <summary>
    /// <para>Defines the Array Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:a.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValue" /> <c>&lt;xlrd2:v></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:a")]
    public partial class Array : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Array class.
        /// </summary>
        public Array() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Array class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Array(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Array class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Array(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Array class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Array(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public UInt32Value? R
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>c, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: c</para>
        /// </summary>
        [SchemaAttr("c")]
        public UInt32Value? C
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:a");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValue>();
            builder.AddElement<Array>()
                .AddAttribute("r", a => a.R, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("c", a => a.C);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValue), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Array>(deep);
    }

    /// <summary>
    /// <para>Defines the ArrayValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:v.</para>
    /// </summary>
    [SchemaAttr("xlrd2:v")]
    public partial class ArrayValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the ArrayValue class.
        /// </summary>
        public ArrayValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ArrayValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public ArrayValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValueType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ArrayValueType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:v");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<ArrayValue>()
                .AddAttribute("t", a => a.T);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ArrayValue>(deep);
    }

    /// <summary>
    /// <para>Defines the Dxfs Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:dxfs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat" /> <c>&lt;x:dxf></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:dxfs")]
    public partial class Dxfs : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Dxfs class.
        /// </summary>
        public Dxfs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Dxfs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Dxfs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Dxfs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Dxfs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Dxfs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Dxfs(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>Format Count</para>
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
            builder.SetSchema("xlrd2:dxfs");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat>();
            builder.AddElement<Dxfs>()
                .AddAttribute("count", a => a.Count);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Dxfs>(deep);
    }

    /// <summary>
    /// <para>Defines the RichFormatProperties Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richProperties.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperty" /> <c>&lt;xlrd2:rPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:richProperties")]
    public partial class RichFormatProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class.
        /// </summary>
        public RichFormatProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFormatProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichFormatProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichFormatProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichFormatProperties(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:richProperties");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperty>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatProperty), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFormatProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStyles Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:richStyles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyle" /> <c>&lt;xlrd2:rSty></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:richStyles")]
    public partial class RichStyles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStyles class.
        /// </summary>
        public RichStyles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichStyles(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:richStyles");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyle>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStyle), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStyles>(deep);
    }

    /// <summary>
    /// <para>Defines the RichFormatProperty Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rPr.</para>
    /// </summary>
    [SchemaAttr("xlrd2:rPr")]
    public partial class RichFormatProperty : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichFormatProperty class.
        /// </summary>
        public RichFormatProperty() : base()
        {
        }

        /// <summary>
        /// <para>n, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: n</para>
        /// </summary>
        [SchemaAttr("n")]
        public StringValue? N
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatPropertyType>? T
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichFormatPropertyType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:rPr");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichFormatProperty>()
                .AddAttribute("n", a => a.N, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("t", a => a.T, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichFormatProperty>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStyle Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rSty.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylePropertyValue" /> <c>&lt;xlrd2:rpv></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:rSty")]
    public partial class RichStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStyle class.
        /// </summary>
        public RichStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>dxfid, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: dxfid</para>
        /// </summary>
        [SchemaAttr("dxfid")]
        public UInt32Value? Dxfid
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:rSty");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylePropertyValue>();
            builder.AddElement<RichStyle>()
                .AddAttribute("dxfid", a => a.Dxfid);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichStylePropertyValue), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the RichStylePropertyValue Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:rpv.</para>
    /// </summary>
    [SchemaAttr("xlrd2:rpv")]
    public partial class RichStylePropertyValue : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the RichStylePropertyValue class.
        /// </summary>
        public RichStylePropertyValue() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichStylePropertyValue class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public RichStylePropertyValue(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        /// <summary>
        /// <para>i, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        [SchemaAttr("i")]
        public UInt32Value? I
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:rpv");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichStylePropertyValue>()
                .AddAttribute("i", a => a.I, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichStylePropertyValue>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueGlobalType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:global.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags" /> <c>&lt;xlrd2:keyFlags></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:global")]
    public partial class RichValueGlobalType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class.
        /// </summary>
        public RichValueGlobalType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueGlobalType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueGlobalType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueGlobalType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueGlobalType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:global");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueTypeKeyFlags.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:keyFlags.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags? RichValueTypeKeyFlags
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueGlobalType>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypes Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:types.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueType" /> <c>&lt;xlrd2:type></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:types")]
    public partial class RichValueTypes : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypes class.
        /// </summary>
        public RichValueTypes() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypes(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypes class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypes(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypes class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypes(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:types");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueType>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueType), 0, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypes>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueType Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:type.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList" /> <c>&lt;xlrd2:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags" /> <c>&lt;xlrd2:keyFlags></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:type")]
    public partial class RichValueType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueType class.
        /// </summary>
        public RichValueType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueType(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:type");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags>();
            builder.AddElement<RichValueType>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags), 0, 1, version: FileFormatVersions.Office2019),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList), 0, 1, version: FileFormatVersions.Office2019)
            };
        }

        /// <summary>
        /// <para>RichValueTypeKeyFlags.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:keyFlags.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags? RichValueTypeKeyFlags
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeKeyFlags>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlrd2:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:xlrd2 = http://schemas.microsoft.com/office/spreadsheetml/2017/richdata2
        /// </remark>
        public DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2019.Excel.RichData2.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueType>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypeKeyFlags Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:keyFlags.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKey" /> <c>&lt;xlrd2:key></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:keyFlags")]
    public partial class RichValueTypeKeyFlags : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class.
        /// </summary>
        public RichValueTypeKeyFlags() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeKeyFlags(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeKeyFlags(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeKeyFlags class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypeKeyFlags(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:keyFlags");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKey>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKey), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypeKeyFlags>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypeReservedKey Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:key.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKeyFlag" /> <c>&lt;xlrd2:flag></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("xlrd2:key")]
    public partial class RichValueTypeReservedKey : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class.
        /// </summary>
        public RichValueTypeReservedKey() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeReservedKey(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RichValueTypeReservedKey(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKey class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RichValueTypeReservedKey(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:key");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddChild<DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKeyFlag>();
            builder.AddElement<RichValueTypeReservedKey>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2019.Excel.RichData2.RichValueTypeReservedKeyFlag), 1, 0, version: FileFormatVersions.Office2019)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypeReservedKey>(deep);
    }

    /// <summary>
    /// <para>Defines the RichValueTypeReservedKeyFlag Class.</para>
    /// <para>This class is available in Office 2019 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlrd2:flag.</para>
    /// </summary>
    [SchemaAttr("xlrd2:flag")]
    public partial class RichValueTypeReservedKeyFlag : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RichValueTypeReservedKeyFlag class.
        /// </summary>
        public RichValueTypeReservedKeyFlag() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>value, this property is only available in Office 2019 and later.</para>
        /// <para>Represents the following attribute in the schema: value</para>
        /// </summary>
        [SchemaAttr("value")]
        public BooleanValue? Value
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlrd2:flag");
            builder.Availability = FileFormatVersions.Office2019;
            builder.AddElement<RichValueTypeReservedKeyFlag>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("value", a => a.Value, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RichValueTypeReservedKeyFlag>(deep);
    }

    /// <summary>
    /// Defines the SupportingPropertyBagValueType enumeration.
    /// </summary>
    public enum SupportingPropertyBagValueType
    {
        /// <summary>
        /// d.
        /// <para>When the item is serialized out as xml, its value is "d".</para>
        /// </summary>
        [EnumString("d")]
        D,
        /// <summary>
        /// i.
        /// <para>When the item is serialized out as xml, its value is "i".</para>
        /// </summary>
        [EnumString("i")]
        I,
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        B,
        /// <summary>
        /// s.
        /// <para>When the item is serialized out as xml, its value is "s".</para>
        /// </summary>
        [EnumString("s")]
        S,
        /// <summary>
        /// spb.
        /// <para>When the item is serialized out as xml, its value is "spb".</para>
        /// </summary>
        [EnumString("spb")]
        Spb,
        /// <summary>
        /// spba.
        /// <para>When the item is serialized out as xml, its value is "spba".</para>
        /// </summary>
        [EnumString("spba")]
        Spba
    }

    /// <summary>
    /// Defines the SupportingPropertyBagArrayValueType enumeration.
    /// </summary>
    public enum SupportingPropertyBagArrayValueType
    {
        /// <summary>
        /// d.
        /// <para>When the item is serialized out as xml, its value is "d".</para>
        /// </summary>
        [EnumString("d")]
        D,
        /// <summary>
        /// i.
        /// <para>When the item is serialized out as xml, its value is "i".</para>
        /// </summary>
        [EnumString("i")]
        I,
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        B,
        /// <summary>
        /// s.
        /// <para>When the item is serialized out as xml, its value is "s".</para>
        /// </summary>
        [EnumString("s")]
        S,
        /// <summary>
        /// spb.
        /// <para>When the item is serialized out as xml, its value is "spb".</para>
        /// </summary>
        [EnumString("spb")]
        Spb
    }

    /// <summary>
    /// Defines the ArrayValueType enumeration.
    /// </summary>
    public enum ArrayValueType
    {
        /// <summary>
        /// d.
        /// <para>When the item is serialized out as xml, its value is "d".</para>
        /// </summary>
        [EnumString("d")]
        D,
        /// <summary>
        /// i.
        /// <para>When the item is serialized out as xml, its value is "i".</para>
        /// </summary>
        [EnumString("i")]
        I,
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        B,
        /// <summary>
        /// e.
        /// <para>When the item is serialized out as xml, its value is "e".</para>
        /// </summary>
        [EnumString("e")]
        E,
        /// <summary>
        /// s.
        /// <para>When the item is serialized out as xml, its value is "s".</para>
        /// </summary>
        [EnumString("s")]
        S,
        /// <summary>
        /// r.
        /// <para>When the item is serialized out as xml, its value is "r".</para>
        /// </summary>
        [EnumString("r")]
        R,
        /// <summary>
        /// a.
        /// <para>When the item is serialized out as xml, its value is "a".</para>
        /// </summary>
        [EnumString("a")]
        A
    }

    /// <summary>
    /// Defines the RichFormatPropertyType enumeration.
    /// </summary>
    public enum RichFormatPropertyType
    {
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        B,
        /// <summary>
        /// n.
        /// <para>When the item is serialized out as xml, its value is "n".</para>
        /// </summary>
        [EnumString("n")]
        N,
        /// <summary>
        /// i.
        /// <para>When the item is serialized out as xml, its value is "i".</para>
        /// </summary>
        [EnumString("i")]
        I,
        /// <summary>
        /// s.
        /// <para>When the item is serialized out as xml, its value is "s".</para>
        /// </summary>
        [EnumString("s")]
        S
    }
}