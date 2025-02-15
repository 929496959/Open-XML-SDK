﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2013.Excel
{
    /// <summary>
    /// <para>Defines the PivotCaches Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotCache" /> <c>&lt;x:pivotCache></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotCaches")]
    public partial class PivotCaches : OpenXmlPivotCachesElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCaches class.
        /// </summary>
        public PivotCaches() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotCaches(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotCaches(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotCaches class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotCaches(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotCaches");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCachePivotCaches Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCachePivotCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotCache" /> <c>&lt;x:pivotCache></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineCachePivotCaches")]
    public partial class TimelineCachePivotCaches : OpenXmlPivotCachesElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class.
        /// </summary>
        public TimelineCachePivotCaches() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotCaches(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotCaches(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotCaches class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCachePivotCaches(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineCachePivotCaches");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.PivotCache), 1, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlPivotCachesElement Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.PivotCache" /> <c>&lt;x:pivotCache></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlPivotCachesElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class.
        /// </summary>
        protected OpenXmlPivotCachesElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlPivotCachesElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlPivotCachesElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlPivotCachesElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlPivotCachesElement(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.PivotCache>();
        }
    }

    /// <summary>
    /// <para>Defines the PivotTableReferences Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableReferences.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.PivotTableReference" /> <c>&lt;x15:pivotTableReference></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotTableReferences")]
    public partial class PivotTableReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class.
        /// </summary>
        public PivotTableReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotTableReferences");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.PivotTableReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotTableReference), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the QueryTable Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:queryTable.</para>
    /// </summary>
    [SchemaAttr("x15:queryTable")]
    public partial class QueryTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the QueryTable class.
        /// </summary>
        public QueryTable() : base()
        {
        }

        /// <summary>
        /// <para>clipped, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: clipped</para>
        /// </summary>
        [SchemaAttr("clipped")]
        public BooleanValue? Clipped
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceDataName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: sourceDataName</para>
        /// </summary>
        [SchemaAttr("sourceDataName")]
        public StringValue? SourceDataName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>drillThrough, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: drillThrough</para>
        /// </summary>
        [SchemaAttr("drillThrough")]
        public BooleanValue? DrillThrough
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:queryTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<QueryTable>()
                .AddAttribute("clipped", a => a.Clipped)
                .AddAttribute("sourceDataName", a => a.SourceDataName)
                .AddAttribute("drillThrough", a => a.DrillThrough);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QueryTable>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtensions Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:webExtensions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.WebExtension" /> <c>&lt;x15:webExtension></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:webExtensions")]
    public partial class WebExtensions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtensions class.
        /// </summary>
        public WebExtensions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtensions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtensions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtensions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:webExtensions");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.WebExtension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.WebExtension), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtensions>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCacheReferences Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCacheRefs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheReference" /> <c>&lt;x15:timelineCacheRef></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineCacheRefs")]
    public partial class TimelineCacheReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class.
        /// </summary>
        public TimelineCacheReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCacheReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineCacheRefs");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineCacheReference), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineReferences Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineRefs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineReference" /> <c>&lt;x15:timelineRef></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineRefs")]
    public partial class TimelineReferences : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineReferences class.
        /// </summary>
        public TimelineReferences() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineReferences(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineReferences class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineReferences(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineReferences class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineReferences(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineRefs");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineReference>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineReference), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineReferences>(deep);
    }

    /// <summary>
    /// <para>Defines the WorkbookProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:workbookPr.</para>
    /// </summary>
    [SchemaAttr("x15:workbookPr")]
    public partial class WorkbookProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the WorkbookProperties class.
        /// </summary>
        public WorkbookProperties() : base()
        {
        }

        /// <summary>
        /// <para>chartTrackingRefBase, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: chartTrackingRefBase</para>
        /// </summary>
        [SchemaAttr("chartTrackingRefBase")]
        public BooleanValue? ChartTrackingReferenceBase
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:workbookPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<WorkbookProperties>()
                .AddAttribute("chartTrackingRefBase", a => a.ChartTrackingReferenceBase);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WorkbookProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyles Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyles.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineStyle" /> <c>&lt;x15:timelineStyle></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineStyles")]
    public partial class TimelineStyles : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyles class.
        /// </summary>
        public TimelineStyles() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyles(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyles class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyles(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyles class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineStyles(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>defaultTimelineStyle, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: defaultTimelineStyle</para>
        /// </summary>
        [SchemaAttr("defaultTimelineStyle")]
        public StringValue? DefaultTimelineStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineStyles");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyle>();
            builder.AddElement<TimelineStyles>()
                .AddAttribute("defaultTimelineStyle", a => a.DefaultTimelineStyle, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineStyle), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyles>(deep);
    }

    /// <summary>
    /// <para>Defines the DifferentialFormats Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dxfs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat" /> <c>&lt;x:dxf></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:dxfs")]
    public partial class DifferentialFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class.
        /// </summary>
        public DifferentialFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DifferentialFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DifferentialFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DifferentialFormats(string outerXml) : base(outerXml)
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
            builder.SetSchema("x15:dxfs");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat>();
            builder.AddElement<DifferentialFormats>()
                .AddAttribute("count", a => a.Count);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.DifferentialFormat), 0, 0)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DifferentialFormats>(deep);
    }

    /// <summary>
    /// <para>Defines the Connection Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:connection.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TextProperties" /> <c>&lt;x15:textPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.DataFeedProperties" /> <c>&lt;x15:dataFeedPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ModelTextProperties" /> <c>&lt;x15:modelTextPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties" /> <c>&lt;x15:oledbPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.RangeProperties" /> <c>&lt;x15:rangePr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:connection")]
    public partial class Connection : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Connection class.
        /// </summary>
        public Connection() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Connection(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Connection class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Connection(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>model, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: model</para>
        /// </summary>
        [SchemaAttr("model")]
        public BooleanValue? Model
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>excludeFromRefreshAll, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: excludeFromRefreshAll</para>
        /// </summary>
        [SchemaAttr("excludeFromRefreshAll")]
        public BooleanValue? ExcludeFromRefreshAll
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>autoDelete, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: autoDelete</para>
        /// </summary>
        [SchemaAttr("autoDelete")]
        public BooleanValue? AutoDelete
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>usedByAddin, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: usedByAddin</para>
        /// </summary>
        [SchemaAttr("usedByAddin")]
        public BooleanValue? UsedByAddin
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:connection");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TextProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.DataFeedProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ModelTextProperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.RangeProperties>();
            builder.AddElement<Connection>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("model", a => a.Model)
                .AddAttribute("excludeFromRefreshAll", a => a.ExcludeFromRefreshAll)
                .AddAttribute("autoDelete", a => a.AutoDelete)
                .AddAttribute("usedByAddin", a => a.UsedByAddin);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TextProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelTextProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.RangeProperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DataFeedProperties), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TextProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:textPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.TextProperties? TextProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.TextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ModelTextProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:modelTextPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ModelTextProperties? ModelTextProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ModelTextProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>RangeProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:rangePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.RangeProperties? RangeProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.RangeProperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>OleDbPrpoperties.</para>
        /// <para>Represents the following element tag in the schema: x15:oledbPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties? OleDbPrpoperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.OleDbPrpoperties>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DataFeedProperties.</para>
        /// <para>Represents the following element tag in the schema: x15:dataFeedPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.DataFeedProperties? DataFeedProperties
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.DataFeedProperties>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Connection>(deep);
    }

    /// <summary>
    /// <para>Defines the CalculatedMember Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:calculatedMember.</para>
    /// </summary>
    [SchemaAttr("x15:calculatedMember")]
    public partial class CalculatedMember : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CalculatedMember class.
        /// </summary>
        public CalculatedMember() : base()
        {
        }

        /// <summary>
        /// <para>measureGroup, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: measureGroup</para>
        /// </summary>
        [SchemaAttr("measureGroup")]
        public StringValue? MeasureGroup
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>numberFormat, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: numberFormat</para>
        /// </summary>
        [SchemaAttr("numberFormat")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat>? NumberFormat
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.CalculatedMemberNumberFormat>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>measure, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: measure</para>
        /// </summary>
        [SchemaAttr("measure")]
        public BooleanValue? Measure
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:calculatedMember");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CalculatedMember>()
                .AddAttribute("measureGroup", a => a.MeasureGroup)
                .AddAttribute("numberFormat", a => a.NumberFormat)
                .AddAttribute("measure", a => a.Measure);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CalculatedMember>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableUISettings Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableUISettings.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.FieldListActiveTabTopLevelEntity" /> <c>&lt;x15:activeTabTopLevelEntity></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotTableUISettings")]
    public partial class PivotTableUISettings : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class.
        /// </summary>
        public PivotTableUISettings() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableUISettings(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableUISettings(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableUISettings class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableUISettings(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>sourceDataName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: sourceDataName</para>
        /// </summary>
        [SchemaAttr("sourceDataName")]
        public StringValue? SourceDataName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>relNeededHidden, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: relNeededHidden</para>
        /// </summary>
        [SchemaAttr("relNeededHidden")]
        public BooleanValue? RelNeededHidden
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotTableUISettings");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.FieldListActiveTabTopLevelEntity>();
            builder.AddElement<PivotTableUISettings>()
                .AddAttribute("sourceDataName", a => a.SourceDataName)
                .AddAttribute("relNeededHidden", a => a.RelNeededHidden);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.FieldListActiveTabTopLevelEntity), 0, 0, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableUISettings>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotFilter Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotFilter.</para>
    /// </summary>
    [SchemaAttr("x15:pivotFilter")]
    public partial class PivotFilter : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotFilter class.
        /// </summary>
        public PivotFilter() : base()
        {
        }

        /// <summary>
        /// <para>useWholeDay, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: useWholeDay</para>
        /// </summary>
        [SchemaAttr("useWholeDay")]
        public BooleanValue? UseWholeDay
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotFilter");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotFilter>()
                .AddAttribute("useWholeDay", a => a.UseWholeDay, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotFilter>(deep);
    }

    /// <summary>
    /// <para>Defines the CachedUniqueNames Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:cachedUniqueNames.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.CachedUniqueName" /> <c>&lt;x15:cachedUniqueName></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:cachedUniqueNames")]
    public partial class CachedUniqueNames : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class.
        /// </summary>
        public CachedUniqueNames() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CachedUniqueNames(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CachedUniqueNames(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CachedUniqueNames class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CachedUniqueNames(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:cachedUniqueNames");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.CachedUniqueName>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.CachedUniqueName), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedUniqueNames>(deep);
    }

    /// <summary>
    /// <para>Defines the CacheHierarchy Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:cacheHierarchy.</para>
    /// </summary>
    [SchemaAttr("x15:cacheHierarchy")]
    public partial class CacheHierarchy : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CacheHierarchy class.
        /// </summary>
        public CacheHierarchy() : base()
        {
        }

        /// <summary>
        /// <para>aggregatedColumn, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: aggregatedColumn</para>
        /// </summary>
        [SchemaAttr("aggregatedColumn")]
        public Int32Value? AggregatedColumn
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:cacheHierarchy");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CacheHierarchy>()
                .AddAttribute("aggregatedColumn", a => a.AggregatedColumn, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CacheHierarchy>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelinePivotCacheDefinition Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelinePivotCacheDefinition.</para>
    /// </summary>
    [SchemaAttr("x15:timelinePivotCacheDefinition")]
    public partial class TimelinePivotCacheDefinition : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelinePivotCacheDefinition class.
        /// </summary>
        public TimelinePivotCacheDefinition() : base()
        {
        }

        /// <summary>
        /// <para>timelineData, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: timelineData</para>
        /// </summary>
        [SchemaAttr("timelineData")]
        public BooleanValue? TimelineData
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelinePivotCacheDefinition");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelinePivotCacheDefinition>()
                .AddAttribute("timelineData", a => a.TimelineData);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelinePivotCacheDefinition>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCacheIdVersion Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotCacheIdVersion.</para>
    /// </summary>
    [SchemaAttr("x15:pivotCacheIdVersion")]
    public partial class PivotCacheIdVersion : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCacheIdVersion class.
        /// </summary>
        public PivotCacheIdVersion() : base()
        {
        }

        /// <summary>
        /// <para>cacheIdSupportedVersion, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: cacheIdSupportedVersion</para>
        /// </summary>
        [SchemaAttr("cacheIdSupportedVersion")]
        public ByteValue? CacheIdSupportedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cacheIdCreatedVersion, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: cacheIdCreatedVersion</para>
        /// </summary>
        [SchemaAttr("cacheIdCreatedVersion")]
        public ByteValue? CacheIdCreatedVersion
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotCacheIdVersion");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotCacheIdVersion>()
                .AddAttribute("cacheIdSupportedVersion", a => a.CacheIdSupportedVersion, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("cacheIdCreatedVersion", a => a.CacheIdCreatedVersion, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheIdVersion>(deep);
    }

    /// <summary>
    /// <para>Defines the DataModel Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dataModel.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships" /> <c>&lt;x15:modelRelationships></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ModelTables" /> <c>&lt;x15:modelTables></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:dataModel")]
    public partial class DataModel : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataModel class.
        /// </summary>
        public DataModel() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataModel(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataModel class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataModel(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>minVersionLoad, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: minVersionLoad</para>
        /// </summary>
        [SchemaAttr("minVersionLoad")]
        public ByteValue? MinVersionLoad
        {
            get => GetAttribute<ByteValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:dataModel");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ModelTables>();
            builder.AddElement<DataModel>()
                .AddAttribute("minVersionLoad", a => a.MinVersionLoad);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelTables), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ModelTables.</para>
        /// <para>Represents the following element tag in the schema: x15:modelTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ModelTables? ModelTables
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ModelTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ModelRelationships.</para>
        /// <para>Represents the following element tag in the schema: x15:modelRelationships.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships? ModelRelationships
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ModelRelationships>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataModel>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableData Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.PivotRow" /> <c>&lt;x15:pivotRow></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotTableData")]
    public partial class PivotTableData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableData class.
        /// </summary>
        public PivotTableData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>rowCount, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: rowCount</para>
        /// </summary>
        [SchemaAttr("rowCount")]
        public UInt32Value? RowCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnCount, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: columnCount</para>
        /// </summary>
        [SchemaAttr("columnCount")]
        public UInt32Value? ColumnCount
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cacheId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: cacheId</para>
        /// </summary>
        [SchemaAttr("cacheId")]
        public UInt32Value? CacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotTableData");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.PivotRow>();
            builder.AddElement<PivotTableData>()
                .AddAttribute("rowCount", a => a.RowCount)
                .AddAttribute("columnCount", a => a.ColumnCount)
                .AddAttribute("cacheId", a => a.CacheId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotRow), 1, 0, version: FileFormatVersions.Office2013)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableData>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotCacheDecoupled Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotCacheDecoupled.</para>
    /// </summary>
    [SchemaAttr("x15:pivotCacheDecoupled")]
    public partial class PivotCacheDecoupled : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotCacheDecoupled class.
        /// </summary>
        public PivotCacheDecoupled() : base()
        {
        }

        /// <summary>
        /// <para>decoupled, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: decoupled</para>
        /// </summary>
        [SchemaAttr("decoupled")]
        public BooleanValue? Decoupled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotCacheDecoupled");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotCacheDecoupled>()
                .AddAttribute("decoupled", a => a.Decoupled);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotCacheDecoupled>(deep);
    }

    /// <summary>
    /// <para>Defines the DataField Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dataField.</para>
    /// </summary>
    [SchemaAttr("x15:dataField")]
    public partial class DataField : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DataField class.
        /// </summary>
        public DataField() : base()
        {
        }

        /// <summary>
        /// <para>isCountDistinct, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: isCountDistinct</para>
        /// </summary>
        [SchemaAttr("isCountDistinct")]
        public BooleanValue? IsCountDistinct
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:dataField");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DataField>()
                .AddAttribute("isCountDistinct", a => a.IsCountDistinct);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataField>(deep);
    }

    /// <summary>
    /// <para>Defines the MovingPeriodState Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:movingPeriodState.</para>
    /// </summary>
    [SchemaAttr("x15:movingPeriodState")]
    public partial class MovingPeriodState : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MovingPeriodState class.
        /// </summary>
        public MovingPeriodState() : base()
        {
        }

        /// <summary>
        /// <para>referenceDateBegin, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: referenceDateBegin</para>
        /// </summary>
        [SchemaAttr("referenceDateBegin")]
        public DateTimeValue? ReferenceDateBegin
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>referencePeriod, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: referencePeriod</para>
        /// </summary>
        [SchemaAttr("referencePeriod")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>? ReferencePeriod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>referenceMultiple, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: referenceMultiple</para>
        /// </summary>
        [SchemaAttr("referenceMultiple")]
        public UInt32Value? ReferenceMultiple
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>movingPeriod, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: movingPeriod</para>
        /// </summary>
        [SchemaAttr("movingPeriod")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>? MovingPeriod
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodStep>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>movingMultiple, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: movingMultiple</para>
        /// </summary>
        [SchemaAttr("movingMultiple")]
        public UInt32Value? MovingMultiple
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:movingPeriodState");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<MovingPeriodState>()
                .AddAttribute("referenceDateBegin", a => a.ReferenceDateBegin, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("referencePeriod", a => a.ReferencePeriod, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("referenceMultiple", a => a.ReferenceMultiple, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("movingPeriod", a => a.MovingPeriod, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("movingMultiple", a => a.MovingMultiple, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MovingPeriodState>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCaches Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCaches.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.SlicerCache" /> <c>&lt;x14:slicerCache></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:slicerCaches")]
    public partial class SlicerCaches : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCaches class.
        /// </summary>
        public SlicerCaches() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCaches(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCaches class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCaches(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCaches class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCaches(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:slicerCaches");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.SlicerCache>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCache), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCaches>(deep);
    }

    /// <summary>
    /// <para>Defines the TableSlicerCache Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:tableSlicerCache.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:tableSlicerCache")]
    public partial class TableSlicerCache : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class.
        /// </summary>
        public TableSlicerCache() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableSlicerCache(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TableSlicerCache(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TableSlicerCache class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TableSlicerCache(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>tableId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: tableId</para>
        /// </summary>
        [SchemaAttr("tableId")]
        public UInt32Value? TableId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>column, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: column</para>
        /// </summary>
        [SchemaAttr("column")]
        public UInt32Value? Column
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sortOrder, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sortOrder</para>
        /// </summary>
        [SchemaAttr("sortOrder")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>? SortOrder
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.TabularSlicerCacheSortOrderValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>customListSort, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: customListSort</para>
        /// </summary>
        [SchemaAttr("customListSort")]
        public BooleanValue? CustomListSort
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>crossFilter, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: crossFilter</para>
        /// </summary>
        [SchemaAttr("crossFilter")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>? CrossFilter
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.Excel.SlicerCacheCrossFilterValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:tableSlicerCache");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddElement<TableSlicerCache>()
                .AddAttribute("tableId", a => a.TableId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("column", a => a.Column, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("sortOrder", a => a.SortOrder)
                .AddAttribute("customListSort", a => a.CustomListSort)
                .AddAttribute("crossFilter", a => a.CrossFilter);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TableSlicerCache>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCacheHideItemsWithNoData Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCacheHideItemsWithNoData.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.SlicerCacheOlapLevelName" /> <c>&lt;x15:slicerCacheOlapLevelName></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:slicerCacheHideItemsWithNoData")]
    public partial class SlicerCacheHideItemsWithNoData : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class.
        /// </summary>
        public SlicerCacheHideItemsWithNoData() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheHideItemsWithNoData(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCacheHideItemsWithNoData(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCacheHideItemsWithNoData class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCacheHideItemsWithNoData(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:slicerCacheHideItemsWithNoData");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.SlicerCacheOlapLevelName>();
            builder.AddElement<SlicerCacheHideItemsWithNoData>()
                .AddAttribute("count", a => a.Count);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SlicerCacheOlapLevelName), 0, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheHideItemsWithNoData>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCachePivotTables Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCachePivotTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable" /> <c>&lt;x14:pivotTable></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:slicerCachePivotTables")]
    public partial class SlicerCachePivotTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class.
        /// </summary>
        public SlicerCachePivotTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCachePivotTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SlicerCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SlicerCachePivotTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SlicerCachePivotTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:slicerCachePivotTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.Excel.SlicerCachePivotTable), 1, 0, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCachePivotTables>(deep);
    }

    /// <summary>
    /// <para>Defines the Survey Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:survey.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr" /> <c>&lt;x15:surveyPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TitlePrSurveyElementPr" /> <c>&lt;x15:titlePr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr" /> <c>&lt;x15:descriptionPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions" /> <c>&lt;x15:questions></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:survey")]
    public partial class Survey : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Survey class.
        /// </summary>
        public Survey() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Survey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Survey(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Survey class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Survey(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Survey class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Survey(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public UInt32Value? Id
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>guid, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: guid</para>
        /// </summary>
        [SchemaAttr("guid")]
        public StringValue? Guid
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:survey");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TitlePrSurveyElementPr>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions>();
            builder.AddElement<Survey>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("guid", a => a.Guid, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("title", a => a.Title)
                .AddAttribute("description", a => a.Description);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TitlePrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SurveyPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:surveyPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr? SurveyPrSurveyElementPr
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.SurveyPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TitlePrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:titlePr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.TitlePrSurveyElementPr? TitlePrSurveyElementPr
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.TitlePrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DescriptionPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:descriptionPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr? DescriptionPrSurveyElementPr
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.DescriptionPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SurveyQuestions.</para>
        /// <para>Represents the following element tag in the schema: x15:questions.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions? SurveyQuestions
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestions>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Survey>(deep);
    }

    /// <summary>
    /// <para>Defines the Timelines Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelines.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.Timeline" /> <c>&lt;x15:timeline></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelines")]
    public partial class Timelines : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the Timelines class.
        /// </summary>
        public Timelines() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timelines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timelines(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timelines class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timelines(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timelines class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Timelines(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelines");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.Timeline>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.Timeline), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timelines>(deep);

        internal Timelines(TimeLinePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the TimeLinePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(TimeLinePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the TimeLinePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(TimeLinePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the TimeLinePart associated with this element.
        /// </summary>
        public TimeLinePart? TimeLinePart
        {
            get => OpenXmlPart as TimeLinePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the TimelineCacheDefinition Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCacheDefinition.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTables" /> <c>&lt;x15:pivotTables></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineState" /> <c>&lt;x15:state></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineCacheDefinition")]
    public partial class TimelineCacheDefinition : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class.
        /// </summary>
        public TimelineCacheDefinition() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheDefinition(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCacheDefinition(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCacheDefinition class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCacheDefinition(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: sourceName</para>
        /// </summary>
        [SchemaAttr("sourceName")]
        public StringValue? SourceName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineCacheDefinition");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTables>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineState>();
            builder.AddElement<TimelineCacheDefinition>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("sourceName", a => a.SourceName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTables), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineState), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TimelineCachePivotTables.</para>
        /// <para>Represents the following element tag in the schema: x15:pivotTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTables? TimelineCachePivotTables
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>TimelineState.</para>
        /// <para>Represents the following element tag in the schema: x15:state.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.TimelineState? TimelineState
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.TimelineState>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheDefinition>(deep);

        internal TimelineCacheDefinition(TimeLineCachePart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the TimeLineCachePart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(TimeLineCachePart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the TimeLineCachePart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(TimeLineCachePart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the TimeLineCachePart associated with this element.
        /// </summary>
        public TimeLineCachePart? TimeLineCachePart
        {
            get => OpenXmlPart as TimeLineCachePart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the PivotTableReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableReference.</para>
    /// </summary>
    [SchemaAttr("x15:pivotTableReference")]
    public partial class PivotTableReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableReference class.
        /// </summary>
        public PivotTableReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:pivotTableReference");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotTableReference>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableReference>(deep);
    }

    /// <summary>
    /// <para>Defines the WebExtension Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:webExtension.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.Excel.Formula" /> <c>&lt;xne:f></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:webExtension")]
    public partial class WebExtension : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the WebExtension class.
        /// </summary>
        public WebExtension() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtension(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public WebExtension(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the WebExtension class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public WebExtension(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>appRef, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: appRef</para>
        /// </summary>
        [SchemaAttr("appRef")]
        public StringValue? ApplicationReference
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:webExtension");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office.Excel.Formula>();
            builder.AddElement<WebExtension>()
                .AddAttribute("appRef", a => a.ApplicationReference, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.Excel.Formula), 1, 1)
            };
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

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<WebExtension>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCacheReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineCacheRef.</para>
    /// </summary>
    [SchemaAttr("x15:timelineCacheRef")]
    public partial class TimelineCacheReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCacheReference class.
        /// </summary>
        public TimelineCacheReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:timelineCacheRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineCacheReference>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCacheReference>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineReference Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineRef.</para>
    /// </summary>
    [SchemaAttr("x15:timelineRef")]
    public partial class TimelineReference : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineReference class.
        /// </summary>
        public TimelineReference() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:timelineRef");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineReference>()
                .AddAttribute("r:id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineReference>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyle Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyle.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElements" /> <c>&lt;x15:timelineStyleElements></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineStyle")]
    public partial class TimelineStyle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyle class.
        /// </summary>
        public TimelineStyle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineStyle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:timelineStyle");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElements>();
            builder.AddElement<TimelineStyle>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElements), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>TimelineStyleElements.</para>
        /// <para>Represents the following element tag in the schema: x15:timelineStyleElements.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElements? TimelineStyleElements
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElements>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyle>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyleElement Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyleElement.</para>
    /// </summary>
    [SchemaAttr("x15:timelineStyleElement")]
    public partial class TimelineStyleElement : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyleElement class.
        /// </summary>
        public TimelineStyleElement() : base()
        {
        }

        /// <summary>
        /// <para>type, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>dxfId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: dxfId</para>
        /// </summary>
        [SchemaAttr("dxfId")]
        public UInt32Value? FormatId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineStyleElement");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineStyleElement>()
                .AddAttribute("type", a => a.Type, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("dxfId", a => a.FormatId);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyleElement>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineStyleElements Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timelineStyleElements.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElement" /> <c>&lt;x15:timelineStyleElement></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timelineStyleElements")]
    public partial class TimelineStyleElements : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class.
        /// </summary>
        public TimelineStyleElements() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyleElements(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineStyleElements(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineStyleElements class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineStyleElements(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timelineStyleElements");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElement>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineStyleElement), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineStyleElements>(deep);
    }

    /// <summary>
    /// <para>Defines the DbTable Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dbTable.</para>
    /// </summary>
    [SchemaAttr("x15:dbTable")]
    public partial class DbTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DbTable class.
        /// </summary>
        public DbTable() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:dbTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DbTable>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbTable>(deep);
    }

    /// <summary>
    /// <para>Defines the DbTables Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dbTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.DbTable" /> <c>&lt;x15:dbTable></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:dbTables")]
    public partial class DbTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DbTables class.
        /// </summary>
        public DbTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DbTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DbTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DbTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DbTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DbTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DbTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:dbTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.DbTable>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbTable), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbTables>(deep);
    }

    /// <summary>
    /// <para>Defines the DbCommand Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dbCommand.</para>
    /// </summary>
    [SchemaAttr("x15:dbCommand")]
    public partial class DbCommand : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DbCommand class.
        /// </summary>
        public DbCommand() : base()
        {
        }

        /// <summary>
        /// <para>text, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>
        [SchemaAttr("text")]
        public StringValue? Text
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:dbCommand");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<DbCommand>()
                .AddAttribute("text", a => a.Text, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DbCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the TextProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:textPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.TextFields" /> <c>&lt;x:textFields></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:textPr")]
    public partial class TextProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TextProperties class.
        /// </summary>
        public TextProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TextProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TextProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TextProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>prompt</para>
        /// <para>Represents the following attribute in the schema: prompt</para>
        /// </summary>
        [SchemaAttr("prompt")]
        public BooleanValue? Prompt
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fileType</para>
        /// <para>Represents the following attribute in the schema: fileType</para>
        /// </summary>
        [SchemaAttr("fileType")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues>? FileType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.FileTypeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>codePage</para>
        /// <para>Represents the following attribute in the schema: codePage</para>
        /// </summary>
        [SchemaAttr("codePage")]
        public UInt32Value? CodePage
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>characterSet</para>
        /// <para>Represents the following attribute in the schema: characterSet</para>
        /// </summary>
        [SchemaAttr("characterSet")]
        public StringValue? TextCharacterSet
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstRow</para>
        /// <para>Represents the following attribute in the schema: firstRow</para>
        /// </summary>
        [SchemaAttr("firstRow")]
        public UInt32Value? FirstRow
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sourceFile</para>
        /// <para>Represents the following attribute in the schema: sourceFile</para>
        /// </summary>
        [SchemaAttr("sourceFile")]
        public StringValue? SourceFile
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>delimited</para>
        /// <para>Represents the following attribute in the schema: delimited</para>
        /// </summary>
        [SchemaAttr("delimited")]
        public BooleanValue? Delimited
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>decimal</para>
        /// <para>Represents the following attribute in the schema: decimal</para>
        /// </summary>
        [SchemaAttr("decimal")]
        public StringValue? Decimal
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>thousands</para>
        /// <para>Represents the following attribute in the schema: thousands</para>
        /// </summary>
        [SchemaAttr("thousands")]
        public StringValue? Thousands
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tab</para>
        /// <para>Represents the following attribute in the schema: tab</para>
        /// </summary>
        [SchemaAttr("tab")]
        public BooleanValue? TabAsDelimiter
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>space</para>
        /// <para>Represents the following attribute in the schema: space</para>
        /// </summary>
        [SchemaAttr("space")]
        public BooleanValue? Space
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>comma</para>
        /// <para>Represents the following attribute in the schema: comma</para>
        /// </summary>
        [SchemaAttr("comma")]
        public BooleanValue? Comma
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>semicolon</para>
        /// <para>Represents the following attribute in the schema: semicolon</para>
        /// </summary>
        [SchemaAttr("semicolon")]
        public BooleanValue? Semicolon
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>consecutive</para>
        /// <para>Represents the following attribute in the schema: consecutive</para>
        /// </summary>
        [SchemaAttr("consecutive")]
        public BooleanValue? Consecutive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>qualifier</para>
        /// <para>Represents the following attribute in the schema: qualifier</para>
        /// </summary>
        [SchemaAttr("qualifier")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues>? Qualifier
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.QualifierValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>delimiter</para>
        /// <para>Represents the following attribute in the schema: delimiter</para>
        /// </summary>
        [SchemaAttr("delimiter")]
        public StringValue? Delimiter
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:textPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.TextFields>();
            builder.AddElement<TextProperties>()
                .AddAttribute("prompt", a => a.Prompt)
                .AddAttribute("fileType", a => a.FileType)
                .AddAttribute("codePage", a => a.CodePage)
                .AddAttribute("characterSet", a => a.TextCharacterSet)
                .AddAttribute("firstRow", a => a.FirstRow)
                .AddAttribute("sourceFile", a => a.SourceFile)
                .AddAttribute("delimited", a => a.Delimited)
                .AddAttribute("decimal", a => a.Decimal)
                .AddAttribute("thousands", a => a.Thousands)
                .AddAttribute("tab", a => a.TabAsDelimiter)
                .AddAttribute("space", a => a.Space)
                .AddAttribute("comma", a => a.Comma)
                .AddAttribute("semicolon", a => a.Semicolon)
                .AddAttribute("consecutive", a => a.Consecutive)
                .AddAttribute("qualifier", a => a.Qualifier)
                .AddAttribute("delimiter", a => a.Delimiter);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.TextFields), 0, 1)
            };
        }

        /// <summary>
        /// <para>TextFields.</para>
        /// <para>Represents the following element tag in the schema: x:textFields.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x = http://schemas.openxmlformats.org/spreadsheetml/2006/main
        /// </remark>
        public DocumentFormat.OpenXml.Spreadsheet.TextFields? TextFields
        {
            get => GetElement<DocumentFormat.OpenXml.Spreadsheet.TextFields>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTextProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelTextPr.</para>
    /// </summary>
    [SchemaAttr("x15:modelTextPr")]
    public partial class ModelTextProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTextProperties class.
        /// </summary>
        public ModelTextProperties() : base()
        {
        }

        /// <summary>
        /// <para>headers, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: headers</para>
        /// </summary>
        [SchemaAttr("headers")]
        public BooleanValue? Headers
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:modelTextPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ModelTextProperties>()
                .AddAttribute("headers", a => a.Headers);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTextProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the RangeProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:rangePr.</para>
    /// </summary>
    [SchemaAttr("x15:rangePr")]
    public partial class RangeProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RangeProperties class.
        /// </summary>
        public RangeProperties() : base()
        {
        }

        /// <summary>
        /// <para>sourceName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: sourceName</para>
        /// </summary>
        [SchemaAttr("sourceName")]
        public StringValue? SourceName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:rangePr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<RangeProperties>()
                .AddAttribute("sourceName", a => a.SourceName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RangeProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the OleDbPrpoperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:oledbPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.DbCommand" /> <c>&lt;x15:dbCommand></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.DbTables" /> <c>&lt;x15:dbTables></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:oledbPr")]
    public partial class OleDbPrpoperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class.
        /// </summary>
        public OleDbPrpoperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleDbPrpoperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OleDbPrpoperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OleDbPrpoperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OleDbPrpoperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>connection, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: connection</para>
        /// </summary>
        [SchemaAttr("connection")]
        public StringValue? Connection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:oledbPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.DbCommand>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.DbTables>();
            builder.AddElement<OleDbPrpoperties>()
                .AddAttribute("connection", a => a.Connection);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbTables), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbCommand), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>DbTables.</para>
        /// <para>Represents the following element tag in the schema: x15:dbTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.DbTables? DbTables
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.DbTables>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DbCommand.</para>
        /// <para>Represents the following element tag in the schema: x15:dbCommand.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.DbCommand? DbCommand
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.DbCommand>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OleDbPrpoperties>(deep);
    }

    /// <summary>
    /// <para>Defines the DataFeedProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:dataFeedPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.DbTables" /> <c>&lt;x15:dbTables></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:dataFeedPr")]
    public partial class DataFeedProperties : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class.
        /// </summary>
        public DataFeedProperties() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataFeedProperties(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DataFeedProperties(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DataFeedProperties class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DataFeedProperties(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>connection, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: connection</para>
        /// </summary>
        [SchemaAttr("connection")]
        public StringValue? Connection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:dataFeedPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.DbTables>();
            builder.AddElement<DataFeedProperties>()
                .AddAttribute("connection", a => a.Connection, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.DbTables), 1, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>DbTables.</para>
        /// <para>Represents the following element tag in the schema: x15:dbTables.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.DbTables? DbTables
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.DbTables>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DataFeedProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the FieldListActiveTabTopLevelEntity Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:activeTabTopLevelEntity.</para>
    /// </summary>
    [SchemaAttr("x15:activeTabTopLevelEntity")]
    public partial class FieldListActiveTabTopLevelEntity : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the FieldListActiveTabTopLevelEntity class.
        /// </summary>
        public FieldListActiveTabTopLevelEntity() : base()
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public UInt32Value? Type
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:activeTabTopLevelEntity");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<FieldListActiveTabTopLevelEntity>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("type", a => a.Type);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<FieldListActiveTabTopLevelEntity>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:extLst.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:extLst")]
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
            builder.SetSchema("x15:extLst");
            builder.Availability = FileFormatVersions.Office2013;
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
    /// <para>Defines the CachedUniqueName Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:cachedUniqueName.</para>
    /// </summary>
    [SchemaAttr("x15:cachedUniqueName")]
    public partial class CachedUniqueName : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CachedUniqueName class.
        /// </summary>
        public CachedUniqueName() : base()
        {
        }

        /// <summary>
        /// <para>index, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: index</para>
        /// </summary>
        [SchemaAttr("index")]
        public UInt32Value? Index
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:cachedUniqueName");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<CachedUniqueName>()
                .AddAttribute("index", a => a.Index, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CachedUniqueName>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTable Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelTable.</para>
    /// </summary>
    [SchemaAttr("x15:modelTable")]
    public partial class ModelTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTable class.
        /// </summary>
        public ModelTable() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>connection, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: connection</para>
        /// </summary>
        [SchemaAttr("connection")]
        public StringValue? Connection
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:modelTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ModelTable>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("connection", a => a.Connection, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTable>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelRelationship Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelRelationship.</para>
    /// </summary>
    [SchemaAttr("x15:modelRelationship")]
    public partial class ModelRelationship : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelRelationship class.
        /// </summary>
        public ModelRelationship() : base()
        {
        }

        /// <summary>
        /// <para>fromTable, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: fromTable</para>
        /// </summary>
        [SchemaAttr("fromTable")]
        public StringValue? FromTable
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fromColumn, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: fromColumn</para>
        /// </summary>
        [SchemaAttr("fromColumn")]
        public StringValue? FromColumn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toTable, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: toTable</para>
        /// </summary>
        [SchemaAttr("toTable")]
        public StringValue? ToTable
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>toColumn, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: toColumn</para>
        /// </summary>
        [SchemaAttr("toColumn")]
        public StringValue? ToColumn
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:modelRelationship");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ModelRelationship>()
                .AddAttribute("fromTable", a => a.FromTable, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("fromColumn", a => a.FromColumn, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("toTable", a => a.ToTable, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("toColumn", a => a.ToColumn, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelRelationship>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelTables Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ModelTable" /> <c>&lt;x15:modelTable></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:modelTables")]
    public partial class ModelTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelTables class.
        /// </summary>
        public ModelTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:modelTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ModelTable>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelTable), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelTables>(deep);
    }

    /// <summary>
    /// <para>Defines the ModelRelationships Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:modelRelationships.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ModelRelationship" /> <c>&lt;x15:modelRelationship></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:modelRelationships")]
    public partial class ModelRelationships : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ModelRelationships class.
        /// </summary>
        public ModelRelationships() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelRelationships class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelRelationships(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelRelationships class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ModelRelationships(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ModelRelationships class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ModelRelationships(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:modelRelationships");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ModelRelationship>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ModelRelationship), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ModelRelationships>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotValueCell Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:c.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.Xstring" /> <c>&lt;x15:v></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra" /> <c>&lt;x15:x></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:c")]
    public partial class PivotValueCell : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotValueCell class.
        /// </summary>
        public PivotValueCell() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotValueCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotValueCell(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotValueCell class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotValueCell(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotValueCell class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotValueCell(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>i, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        [SchemaAttr("i")]
        public UInt32Value? Item
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>t, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: t</para>
        /// </summary>
        [SchemaAttr("t")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType>? Text
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SXVCellType>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:c");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.Xstring>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra>();
            builder.AddElement<PivotValueCell>()
                .AddAttribute("i", a => a.Item)
                .AddAttribute("t", a => a.Text);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.Xstring), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>Xstring.</para>
        /// <para>Represents the following element tag in the schema: x15:v.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.Xstring? Xstring
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.Xstring>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>PivotValueCellExtra.</para>
        /// <para>Represents the following element tag in the schema: x15:x.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra? PivotValueCellExtra
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.PivotValueCellExtra>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotValueCell>(deep);
    }

    /// <summary>
    /// <para>Defines the Xstring Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:v.</para>
    /// </summary>
    [SchemaAttr("x15:v")]
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
            builder.SetSchema("x15:v");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Xstring>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotValueCellExtra Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:x.</para>
    /// </summary>
    [SchemaAttr("x15:x")]
    public partial class PivotValueCellExtra : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotValueCellExtra class.
        /// </summary>
        public PivotValueCellExtra() : base()
        {
        }

        /// <summary>
        /// <para>in, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: in</para>
        /// </summary>
        [SchemaAttr("in")]
        public UInt32Value? FormatIndex
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bc, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: bc</para>
        /// </summary>
        [SchemaAttr("bc")]
        public HexBinaryValue? BackgroundColor
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>fc, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: fc</para>
        /// </summary>
        [SchemaAttr("fc")]
        public HexBinaryValue? ForegroundColor
        {
            get => GetAttribute<HexBinaryValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>i, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: i</para>
        /// </summary>
        [SchemaAttr("i")]
        public BooleanValue? Italic
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>un, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: un</para>
        /// </summary>
        [SchemaAttr("un")]
        public BooleanValue? Underline
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>st, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: st</para>
        /// </summary>
        [SchemaAttr("st")]
        public BooleanValue? Strikethrough
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>b, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: b</para>
        /// </summary>
        [SchemaAttr("b")]
        public BooleanValue? Bold
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:x");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<PivotValueCellExtra>()
                .AddAttribute("in", a => a.FormatIndex)
                .AddAttribute("bc", a => a.BackgroundColor, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { Length = (4L) });
                })
                .AddAttribute("fc", a => a.ForegroundColor, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { Length = (4L) });
                })
                .AddAttribute("i", a => a.Italic)
                .AddAttribute("un", a => a.Underline)
                .AddAttribute("st", a => a.Strikethrough)
                .AddAttribute("b", a => a.Bold);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotValueCellExtra>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotTableServerFormats Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTableServerFormats.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ServerFormat" /> <c>&lt;x15:serverFormat></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotTableServerFormats")]
    public partial class PivotTableServerFormats : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class.
        /// </summary>
        public PivotTableServerFormats() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableServerFormats(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotTableServerFormats(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotTableServerFormats class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotTableServerFormats(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:pivotTableServerFormats");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ServerFormat>();
            builder.AddElement<PivotTableServerFormats>()
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ServerFormat), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotTableServerFormats>(deep);
    }

    /// <summary>
    /// <para>Defines the ServerFormat Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:serverFormat.</para>
    /// </summary>
    [SchemaAttr("x15:serverFormat")]
    public partial class ServerFormat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ServerFormat class.
        /// </summary>
        public ServerFormat() : base()
        {
        }

        /// <summary>
        /// <para>Culture</para>
        /// <para>Represents the following attribute in the schema: culture</para>
        /// </summary>
        [SchemaAttr("culture")]
        public StringValue? Culture
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>Format</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>
        [SchemaAttr("format")]
        public StringValue? Format
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:serverFormat");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ServerFormat>()
                .AddAttribute("culture", a => a.Culture)
                .AddAttribute("format", a => a.Format);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ServerFormat>(deep);
    }

    /// <summary>
    /// <para>Defines the SlicerCacheOlapLevelName Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:slicerCacheOlapLevelName.</para>
    /// </summary>
    [SchemaAttr("x15:slicerCacheOlapLevelName")]
    public partial class SlicerCacheOlapLevelName : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SlicerCacheOlapLevelName class.
        /// </summary>
        public SlicerCacheOlapLevelName() : base()
        {
        }

        /// <summary>
        /// <para>uniqueName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: uniqueName</para>
        /// </summary>
        [SchemaAttr("uniqueName")]
        public StringValue? UniqueName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:slicerCacheOlapLevelName");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<SlicerCacheOlapLevelName>()
                .AddAttribute("uniqueName", a => a.UniqueName, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SlicerCacheOlapLevelName>(deep);
    }

    /// <summary>
    /// <para>Defines the SurveyPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:surveyPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:surveyPr")]
    public partial class SurveyPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class.
        /// </summary>
        public SurveyPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurveyPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:surveyPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the TitlePrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:titlePr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:titlePr")]
    public partial class TitlePrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class.
        /// </summary>
        public TitlePrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlePrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TitlePrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TitlePrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TitlePrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:titlePr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TitlePrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the DescriptionPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:descriptionPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:descriptionPr")]
    public partial class DescriptionPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class.
        /// </summary>
        public DescriptionPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DescriptionPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DescriptionPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DescriptionPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DescriptionPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:descriptionPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DescriptionPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the QuestionsPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:questionsPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:questionsPr")]
    public partial class QuestionsPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class.
        /// </summary>
        public QuestionsPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionsPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionsPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionsPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public QuestionsPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:questionsPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuestionsPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the QuestionPrSurveyElementPr Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:questionPr.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:questionPr")]
    public partial class QuestionPrSurveyElementPr : OpenXmlSurveyElementPrElement
    {
        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class.
        /// </summary>
        public QuestionPrSurveyElementPr() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionPrSurveyElementPr(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuestionPrSurveyElementPr(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuestionPrSurveyElementPr class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public QuestionPrSurveyElementPr(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:questionPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuestionPrSurveyElementPr>(deep);
    }

    /// <summary>
    /// <para>Defines the OpenXmlSurveyElementPrElement Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class OpenXmlSurveyElementPrElement : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class.
        /// </summary>
        protected OpenXmlSurveyElementPrElement() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlSurveyElementPrElement(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected OpenXmlSurveyElementPrElement(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OpenXmlSurveyElementPrElement class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected OpenXmlSurveyElementPrElement(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>cssClass, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: cssClass</para>
        /// </summary>
        [SchemaAttr("cssClass")]
        public StringValue? CssClass
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bottom, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: bottom</para>
        /// </summary>
        [SchemaAttr("bottom")]
        public Int32Value? Bottom
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>top, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: top</para>
        /// </summary>
        [SchemaAttr("top")]
        public Int32Value? Top
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>left, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: left</para>
        /// </summary>
        [SchemaAttr("left")]
        public Int32Value? Left
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>right, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: right</para>
        /// </summary>
        [SchemaAttr("right")]
        public Int32Value? Right
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>width, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: width</para>
        /// </summary>
        [SchemaAttr("width")]
        public UInt32Value? Width
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>height, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: height</para>
        /// </summary>
        [SchemaAttr("height")]
        public UInt32Value? Height
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>position, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: position</para>
        /// </summary>
        [SchemaAttr("position")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition>? Position
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.SurveyPosition>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddElement<OpenXmlSurveyElementPrElement>()
                .AddAttribute("cssClass", a => a.CssClass)
                .AddAttribute("bottom", a => a.Bottom)
                .AddAttribute("top", a => a.Top)
                .AddAttribute("left", a => a.Left)
                .AddAttribute("right", a => a.Right)
                .AddAttribute("width", a => a.Width)
                .AddAttribute("height", a => a.Height)
                .AddAttribute("position", a => a.Position);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }
    }

    /// <summary>
    /// <para>Defines the SurveyQuestions Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:questions.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr" /> <c>&lt;x15:questionsPr></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestion" /> <c>&lt;x15:question></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:questions")]
    public partial class SurveyQuestions : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class.
        /// </summary>
        public SurveyQuestions() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestions(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestions(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestions class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurveyQuestions(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:questions");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestion>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SurveyQuestion), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>QuestionsPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:questionsPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr? QuestionsPrSurveyElementPr
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.QuestionsPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyQuestions>(deep);
    }

    /// <summary>
    /// <para>Defines the SurveyQuestion Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:question.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.QuestionPrSurveyElementPr" /> <c>&lt;x15:questionPr></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:question")]
    public partial class SurveyQuestion : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class.
        /// </summary>
        public SurveyQuestion() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestion(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SurveyQuestion(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SurveyQuestion class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SurveyQuestion(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>binding, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: binding</para>
        /// </summary>
        [SchemaAttr("binding")]
        public UInt32Value? Binding
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>text, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: text</para>
        /// </summary>
        [SchemaAttr("text")]
        public StringValue? Text
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>type, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: type</para>
        /// </summary>
        [SchemaAttr("type")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType>? Type
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionType>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>format, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: format</para>
        /// </summary>
        [SchemaAttr("format")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat>? Format
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Excel.QuestionFormat>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helpText, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: helpText</para>
        /// </summary>
        [SchemaAttr("helpText")]
        public StringValue? HelpText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>required, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: required</para>
        /// </summary>
        [SchemaAttr("required")]
        public BooleanValue? Required
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>defaultValue, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: defaultValue</para>
        /// </summary>
        [SchemaAttr("defaultValue")]
        public StringValue? DefaultValue
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>decimalPlaces, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: decimalPlaces</para>
        /// </summary>
        [SchemaAttr("decimalPlaces")]
        public UInt32Value? DecimalPlaces
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rowSource, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: rowSource</para>
        /// </summary>
        [SchemaAttr("rowSource")]
        public StringValue? RowSource
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:question");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.QuestionPrSurveyElementPr>();
            builder.AddElement<SurveyQuestion>()
                .AddAttribute("binding", a => a.Binding, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("text", a => a.Text)
                .AddAttribute("type", a => a.Type)
                .AddAttribute("format", a => a.Format)
                .AddAttribute("helpText", a => a.HelpText)
                .AddAttribute("required", a => a.Required)
                .AddAttribute("defaultValue", a => a.DefaultValue)
                .AddAttribute("decimalPlaces", a => a.DecimalPlaces)
                .AddAttribute("rowSource", a => a.RowSource);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.QuestionPrSurveyElementPr), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>QuestionPrSurveyElementPr.</para>
        /// <para>Represents the following element tag in the schema: x15:questionPr.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.QuestionPrSurveyElementPr? QuestionPrSurveyElementPr
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.QuestionPrSurveyElementPr>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SurveyQuestion>(deep);
    }

    /// <summary>
    /// <para>Defines the Timeline Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:timeline.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:timeline")]
    public partial class Timeline : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Timeline class.
        /// </summary>
        public Timeline() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timeline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timeline(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timeline class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Timeline(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Timeline class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Timeline(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: name</para>
        /// </summary>
        [SchemaAttr("name")]
        public StringValue? Name
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>cache, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: cache</para>
        /// </summary>
        [SchemaAttr("cache")]
        public StringValue? Cache
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>caption, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: caption</para>
        /// </summary>
        [SchemaAttr("caption")]
        public StringValue? Caption
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showHeader, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: showHeader</para>
        /// </summary>
        [SchemaAttr("showHeader")]
        public BooleanValue? ShowHeader
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showSelectionLabel, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: showSelectionLabel</para>
        /// </summary>
        [SchemaAttr("showSelectionLabel")]
        public BooleanValue? ShowSelectionLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showTimeLevel, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: showTimeLevel</para>
        /// </summary>
        [SchemaAttr("showTimeLevel")]
        public BooleanValue? ShowTimeLevel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showHorizontalScrollbar, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: showHorizontalScrollbar</para>
        /// </summary>
        [SchemaAttr("showHorizontalScrollbar")]
        public BooleanValue? ShowHorizontalScrollbar
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>level, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: level</para>
        /// </summary>
        [SchemaAttr("level")]
        public UInt32Value? Level
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>selectionLevel, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: selectionLevel</para>
        /// </summary>
        [SchemaAttr("selectionLevel")]
        public UInt32Value? SelectionLevel
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>scrollPosition, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: scrollPosition</para>
        /// </summary>
        [SchemaAttr("scrollPosition")]
        public DateTimeValue? ScrollPosition
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr("style")]
        public StringValue? Style
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:timeline");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddElement<Timeline>()
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("cache", a => a.Cache, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("caption", a => a.Caption)
                .AddAttribute("showHeader", a => a.ShowHeader)
                .AddAttribute("showSelectionLabel", a => a.ShowSelectionLabel)
                .AddAttribute("showTimeLevel", a => a.ShowTimeLevel)
                .AddAttribute("showHorizontalScrollbar", a => a.ShowHorizontalScrollbar)
                .AddAttribute("level", a => a.Level, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("selectionLevel", a => a.SelectionLevel, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("scrollPosition", a => a.ScrollPosition)
                .AddAttribute("style", a => a.Style);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
            builder.AddConstraint(new AttributeValueLengthConstraint("x15:name", 1, 1000) { Application = ApplicationType.Excel, Version = FileFormatVersions.Office2013 });
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Timeline>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineCachePivotTable Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTable.</para>
    /// </summary>
    [SchemaAttr("x15:pivotTable")]
    public partial class TimelineCachePivotTable : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTable class.
        /// </summary>
        public TimelineCachePivotTable() : base()
        {
        }

        /// <summary>
        /// <para>tabId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: tabId</para>
        /// </summary>
        [SchemaAttr("tabId")]
        public UInt32Value? TabId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>name, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:pivotTable");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<TimelineCachePivotTable>()
                .AddAttribute("tabId", a => a.TabId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("name", a => a.Name, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotTable>(deep);
    }

    /// <summary>
    /// <para>Defines the SelectionTimelineRange Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:selection.</para>
    /// </summary>
    [SchemaAttr("x15:selection")]
    public partial class SelectionTimelineRange : TimelineRange
    {
        /// <summary>
        /// Initializes a new instance of the SelectionTimelineRange class.
        /// </summary>
        public SelectionTimelineRange() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:selection");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SelectionTimelineRange>(deep);
    }

    /// <summary>
    /// <para>Defines the BoundsTimelineRange Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:bounds.</para>
    /// </summary>
    [SchemaAttr("x15:bounds")]
    public partial class BoundsTimelineRange : TimelineRange
    {
        /// <summary>
        /// Initializes a new instance of the BoundsTimelineRange class.
        /// </summary>
        public BoundsTimelineRange() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:bounds");
            builder.Availability = FileFormatVersions.Office2013;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BoundsTimelineRange>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineRange Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class TimelineRange : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineRange class.
        /// </summary>
        protected TimelineRange() : base()
        {
        }

        /// <summary>
        /// <para>startDate, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: startDate</para>
        /// </summary>
        [SchemaAttr("startDate")]
        public DateTimeValue? StartDate
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>endDate, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: endDate</para>
        /// </summary>
        [SchemaAttr("endDate")]
        public DateTimeValue? EndDate
        {
            get => GetAttribute<DateTimeValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<TimelineRange>()
                .AddAttribute("startDate", a => a.StartDate, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("endDate", a => a.EndDate, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
        }
    }

    /// <summary>
    /// <para>Defines the AutoFilter Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:autoFilter.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.ExtensionList" /> <c>&lt;x:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.FilterColumn" /> <c>&lt;x:filterColumn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.SortState" /> <c>&lt;x:sortState></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:autoFilter")]
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
            builder.SetSchema("x15:autoFilter");
            builder.Availability = FileFormatVersions.Office2013;
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
    /// <para>Defines the TimelineCachePivotTables Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotTables.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTable" /> <c>&lt;x15:pivotTable></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotTables")]
    public partial class TimelineCachePivotTables : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class.
        /// </summary>
        public TimelineCachePivotTables() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotTables(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineCachePivotTables(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineCachePivotTables class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineCachePivotTables(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:pivotTables");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTable>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.TimelineCachePivotTable), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineCachePivotTables>(deep);
    }

    /// <summary>
    /// <para>Defines the TimelineState Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:state.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.ExtensionList" /> <c>&lt;x15:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState" /> <c>&lt;x15:movingPeriodState></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.SelectionTimelineRange" /> <c>&lt;x15:selection></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.BoundsTimelineRange" /> <c>&lt;x15:bounds></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:state")]
    public partial class TimelineState : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TimelineState class.
        /// </summary>
        public TimelineState() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineState(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineState class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TimelineState(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TimelineState class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TimelineState(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>singleRangeFilterState, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: singleRangeFilterState</para>
        /// </summary>
        [SchemaAttr("singleRangeFilterState")]
        public BooleanValue? SingleRangeFilterState
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>minimalRefreshVersion, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: minimalRefreshVersion</para>
        /// </summary>
        [SchemaAttr("minimalRefreshVersion")]
        public UInt32Value? MinimalRefreshVersion
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>lastRefreshVersion, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: lastRefreshVersion</para>
        /// </summary>
        [SchemaAttr("lastRefreshVersion")]
        public UInt32Value? LastRefreshVersion
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>pivotCacheId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: pivotCacheId</para>
        /// </summary>
        [SchemaAttr("pivotCacheId")]
        public UInt32Value? PivotCacheId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterType, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: filterType</para>
        /// </summary>
        [SchemaAttr("filterType")]
        public EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues>? FilterType
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Spreadsheet.PivotFilterValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: filterId</para>
        /// </summary>
        [SchemaAttr("filterId")]
        public UInt32Value? FilterId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterTabId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: filterTabId</para>
        /// </summary>
        [SchemaAttr("filterTabId")]
        public UInt32Value? FilterTabId
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>filterPivotName, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: filterPivotName</para>
        /// </summary>
        [SchemaAttr("filterPivotName")]
        public StringValue? FilterPivotName
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("x15:state");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.SelectionTimelineRange>();
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.BoundsTimelineRange>();
            builder.AddElement<TimelineState>()
                .AddAttribute("singleRangeFilterState", a => a.SingleRangeFilterState)
                .AddAttribute("minimalRefreshVersion", a => a.MinimalRefreshVersion, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("lastRefreshVersion", a => a.LastRefreshVersion, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("pivotCacheId", a => a.PivotCacheId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("filterType", a => a.FilterType, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("filterId", a => a.FilterId)
                .AddAttribute("filterTabId", a => a.FilterTabId)
                .AddAttribute("filterPivotName", a => a.FilterPivotName);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.SelectionTimelineRange), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.BoundsTimelineRange), 1, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState), 0, 1, version: FileFormatVersions.Office2013),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.ExtensionList), 0, 1, version: FileFormatVersions.Office2013)
            };
        }

        /// <summary>
        /// <para>SelectionTimelineRange.</para>
        /// <para>Represents the following element tag in the schema: x15:selection.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.SelectionTimelineRange? SelectionTimelineRange
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.SelectionTimelineRange>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BoundsTimelineRange.</para>
        /// <para>Represents the following element tag in the schema: x15:bounds.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.BoundsTimelineRange? BoundsTimelineRange
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.BoundsTimelineRange>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>MovingPeriodState.</para>
        /// <para>Represents the following element tag in the schema: x15:movingPeriodState.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState? MovingPeriodState
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.MovingPeriodState>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: x15:extLst.</para>
        /// </summary>
        /// <remark>
        /// xmlns:x15 = http://schemas.microsoft.com/office/spreadsheetml/2010/11/main
        /// </remark>
        public DocumentFormat.OpenXml.Office2013.Excel.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office2013.Excel.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TimelineState>(deep);
    }

    /// <summary>
    /// <para>Defines the PivotRow Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is x15:pivotRow.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2013.Excel.PivotValueCell" /> <c>&lt;x15:c></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("x15:pivotRow")]
    public partial class PivotRow : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PivotRow class.
        /// </summary>
        public PivotRow() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotRow(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotRow class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PivotRow(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PivotRow class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PivotRow(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>r, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: r</para>
        /// </summary>
        [SchemaAttr("r")]
        public UInt32Value? Reference
        {
            get => GetAttribute<UInt32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>count, this property is only available in Office 2013 and later.</para>
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
            builder.SetSchema("x15:pivotRow");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddChild<DocumentFormat.OpenXml.Office2013.Excel.PivotValueCell>();
            builder.AddElement<PivotRow>()
                .AddAttribute("r", a => a.Reference)
                .AddAttribute("count", a => a.Count, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2013.Excel.PivotValueCell), 1, 0, version: FileFormatVersions.Office2013)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PivotRow>(deep);
    }

    /// <summary>
    /// Defines the TimelineStyleType enumeration.
    /// </summary>
    public enum TimelineStyleType
    {
        /// <summary>
        /// selectionLabel.
        /// <para>When the item is serialized out as xml, its value is "selectionLabel".</para>
        /// </summary>
        [EnumString("selectionLabel")]
        SelectionLabel,
        /// <summary>
        /// timeLevel.
        /// <para>When the item is serialized out as xml, its value is "timeLevel".</para>
        /// </summary>
        [EnumString("timeLevel")]
        TimeLevel,
        /// <summary>
        /// periodLabel1.
        /// <para>When the item is serialized out as xml, its value is "periodLabel1".</para>
        /// </summary>
        [EnumString("periodLabel1")]
        PeriodLabel1,
        /// <summary>
        /// periodLabel2.
        /// <para>When the item is serialized out as xml, its value is "periodLabel2".</para>
        /// </summary>
        [EnumString("periodLabel2")]
        PeriodLabel2,
        /// <summary>
        /// selectedTimeBlock.
        /// <para>When the item is serialized out as xml, its value is "selectedTimeBlock".</para>
        /// </summary>
        [EnumString("selectedTimeBlock")]
        SelectedTimeBlock,
        /// <summary>
        /// unselectedTimeBlock.
        /// <para>When the item is serialized out as xml, its value is "unselectedTimeBlock".</para>
        /// </summary>
        [EnumString("unselectedTimeBlock")]
        UnselectedTimeBlock,
        /// <summary>
        /// selectedTimeBlockSpace.
        /// <para>When the item is serialized out as xml, its value is "selectedTimeBlockSpace".</para>
        /// </summary>
        [EnumString("selectedTimeBlockSpace")]
        SelectedTimeBlockSpace
    }

    /// <summary>
    /// Defines the CalculatedMemberNumberFormat enumeration.
    /// </summary>
    public enum CalculatedMemberNumberFormat
    {
        /// <summary>
        /// default.
        /// <para>When the item is serialized out as xml, its value is "default".</para>
        /// </summary>
        [EnumString("default")]
        Default,
        /// <summary>
        /// number.
        /// <para>When the item is serialized out as xml, its value is "number".</para>
        /// </summary>
        [EnumString("number")]
        Number,
        /// <summary>
        /// percent.
        /// <para>When the item is serialized out as xml, its value is "percent".</para>
        /// </summary>
        [EnumString("percent")]
        Percent
    }

    /// <summary>
    /// Defines the SXVCellType enumeration.
    /// </summary>
    public enum SXVCellType
    {
        /// <summary>
        /// b.
        /// <para>When the item is serialized out as xml, its value is "b".</para>
        /// </summary>
        [EnumString("b")]
        Boolean,
        /// <summary>
        /// n.
        /// <para>When the item is serialized out as xml, its value is "n".</para>
        /// </summary>
        [EnumString("n")]
        Number,
        /// <summary>
        /// e.
        /// <para>When the item is serialized out as xml, its value is "e".</para>
        /// </summary>
        [EnumString("e")]
        Error,
        /// <summary>
        /// str.
        /// <para>When the item is serialized out as xml, its value is "str".</para>
        /// </summary>
        [EnumString("str")]
        String,
        /// <summary>
        /// d.
        /// <para>When the item is serialized out as xml, its value is "d".</para>
        /// </summary>
        [EnumString("d")]
        Date,
        /// <summary>
        /// bl.
        /// <para>When the item is serialized out as xml, its value is "bl".</para>
        /// </summary>
        [EnumString("bl")]
        Blank
    }

    /// <summary>
    /// Defines the MovingPeriodStep enumeration.
    /// </summary>
    public enum MovingPeriodStep
    {
        /// <summary>
        /// year.
        /// <para>When the item is serialized out as xml, its value is "year".</para>
        /// </summary>
        [EnumString("year")]
        Year,
        /// <summary>
        /// quarter.
        /// <para>When the item is serialized out as xml, its value is "quarter".</para>
        /// </summary>
        [EnumString("quarter")]
        Quarter,
        /// <summary>
        /// month.
        /// <para>When the item is serialized out as xml, its value is "month".</para>
        /// </summary>
        [EnumString("month")]
        Month,
        /// <summary>
        /// week.
        /// <para>When the item is serialized out as xml, its value is "week".</para>
        /// </summary>
        [EnumString("week")]
        Week,
        /// <summary>
        /// day.
        /// <para>When the item is serialized out as xml, its value is "day".</para>
        /// </summary>
        [EnumString("day")]
        Day
    }

    /// <summary>
    /// Defines the QuestionType enumeration.
    /// </summary>
    public enum QuestionType
    {
        /// <summary>
        /// checkBox.
        /// <para>When the item is serialized out as xml, its value is "checkBox".</para>
        /// </summary>
        [EnumString("checkBox")]
        CheckBox,
        /// <summary>
        /// choice.
        /// <para>When the item is serialized out as xml, its value is "choice".</para>
        /// </summary>
        [EnumString("choice")]
        Choice,
        /// <summary>
        /// date.
        /// <para>When the item is serialized out as xml, its value is "date".</para>
        /// </summary>
        [EnumString("date")]
        Date,
        /// <summary>
        /// time.
        /// <para>When the item is serialized out as xml, its value is "time".</para>
        /// </summary>
        [EnumString("time")]
        Time,
        /// <summary>
        /// multipleLinesOfText.
        /// <para>When the item is serialized out as xml, its value is "multipleLinesOfText".</para>
        /// </summary>
        [EnumString("multipleLinesOfText")]
        MultipleLinesOfText,
        /// <summary>
        /// number.
        /// <para>When the item is serialized out as xml, its value is "number".</para>
        /// </summary>
        [EnumString("number")]
        Number,
        /// <summary>
        /// singleLineOfText.
        /// <para>When the item is serialized out as xml, its value is "singleLineOfText".</para>
        /// </summary>
        [EnumString("singleLineOfText")]
        SingleLineOfText
    }

    /// <summary>
    /// Defines the QuestionFormat enumeration.
    /// </summary>
    public enum QuestionFormat
    {
        /// <summary>
        /// generalDate.
        /// <para>When the item is serialized out as xml, its value is "generalDate".</para>
        /// </summary>
        [EnumString("generalDate")]
        GeneralDate,
        /// <summary>
        /// longDate.
        /// <para>When the item is serialized out as xml, its value is "longDate".</para>
        /// </summary>
        [EnumString("longDate")]
        LongDate,
        /// <summary>
        /// shortDate.
        /// <para>When the item is serialized out as xml, its value is "shortDate".</para>
        /// </summary>
        [EnumString("shortDate")]
        ShortDate,
        /// <summary>
        /// longTime.
        /// <para>When the item is serialized out as xml, its value is "longTime".</para>
        /// </summary>
        [EnumString("longTime")]
        LongTime,
        /// <summary>
        /// shortTime.
        /// <para>When the item is serialized out as xml, its value is "shortTime".</para>
        /// </summary>
        [EnumString("shortTime")]
        ShortTime,
        /// <summary>
        /// generalNumber.
        /// <para>When the item is serialized out as xml, its value is "generalNumber".</para>
        /// </summary>
        [EnumString("generalNumber")]
        GeneralNumber,
        /// <summary>
        /// standard.
        /// <para>When the item is serialized out as xml, its value is "standard".</para>
        /// </summary>
        [EnumString("standard")]
        Standard,
        /// <summary>
        /// fixed.
        /// <para>When the item is serialized out as xml, its value is "fixed".</para>
        /// </summary>
        [EnumString("fixed")]
        Fixed,
        /// <summary>
        /// percent.
        /// <para>When the item is serialized out as xml, its value is "percent".</para>
        /// </summary>
        [EnumString("percent")]
        Percent,
        /// <summary>
        /// currency.
        /// <para>When the item is serialized out as xml, its value is "currency".</para>
        /// </summary>
        [EnumString("currency")]
        Currency
    }

    /// <summary>
    /// Defines the SurveyPosition enumeration.
    /// </summary>
    public enum SurveyPosition
    {
        /// <summary>
        /// absolute.
        /// <para>When the item is serialized out as xml, its value is "absolute".</para>
        /// </summary>
        [EnumString("absolute")]
        Absolute,
        /// <summary>
        /// fixed.
        /// <para>When the item is serialized out as xml, its value is "fixed".</para>
        /// </summary>
        [EnumString("fixed")]
        Fixed,
        /// <summary>
        /// relative.
        /// <para>When the item is serialized out as xml, its value is "relative".</para>
        /// </summary>
        [EnumString("relative")]
        Relative,
        /// <summary>
        /// static.
        /// <para>When the item is serialized out as xml, its value is "static".</para>
        /// </summary>
        [EnumString("static")]
        Static,
        /// <summary>
        /// inherit.
        /// <para>When the item is serialized out as xml, its value is "inherit".</para>
        /// </summary>
        [EnumString("inherit")]
        Inherit
    }
}