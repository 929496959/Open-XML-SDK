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

namespace DocumentFormat.OpenXml.Office2013.Drawing
{
    /// <summary>
    /// <para>Defines the BackgroundProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:backgroundPr.</para>
    /// </summary>
    [SchemaAttr("a15:backgroundPr")]
    public partial class BackgroundProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackgroundProperties class.
        /// </summary>
        public BackgroundProperties() : base()
        {
        }

        /// <summary>
        /// <para>bwMode, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: bwMode</para>
        /// </summary>
        [SchemaAttr("bwMode")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? Mode
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bwPure, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: bwPure</para>
        /// </summary>
        [SchemaAttr("bwPure")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? Pure
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>bwNormal, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: bwNormal</para>
        /// </summary>
        [SchemaAttr("bwNormal")]
        public EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>? Normal
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>targetScreenSize, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: targetScreenSize</para>
        /// </summary>
        [SchemaAttr("targetScreenSize")]
        public EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>? TargetScreenSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2013.Drawing.TargetScreenSize>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a15:backgroundPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<BackgroundProperties>()
                .AddAttribute("bwMode", a => a.Mode, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("bwPure", a => a.Pure, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("bwNormal", a => a.Normal, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                })
                .AddAttribute("targetScreenSize", a => a.TargetScreenSize, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackgroundProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the NonVisualGroupProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:nonVisualGroupProps.</para>
    /// </summary>
    [SchemaAttr("a15:nonVisualGroupProps")]
    public partial class NonVisualGroupProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the NonVisualGroupProperties class.
        /// </summary>
        public NonVisualGroupProperties() : base()
        {
        }

        /// <summary>
        /// <para>isLegacyGroup, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: isLegacyGroup</para>
        /// </summary>
        [SchemaAttr("isLegacyGroup")]
        public BooleanValue? IsLegacyGroup
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a15:nonVisualGroupProps");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<NonVisualGroupProperties>()
                .AddAttribute("isLegacyGroup", a => a.IsLegacyGroup);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<NonVisualGroupProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the ObjectProperties Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:objectPr.</para>
    /// </summary>
    [SchemaAttr("a15:objectPr")]
    public partial class ObjectProperties : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ObjectProperties class.
        /// </summary>
        public ObjectProperties() : base()
        {
        }

        /// <summary>
        /// <para>objectId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: objectId</para>
        /// </summary>
        [SchemaAttr("objectId")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isActiveX, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: isActiveX</para>
        /// </summary>
        [SchemaAttr("isActiveX")]
        public BooleanValue? IsActiveX
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>linkType, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: linkType</para>
        /// </summary>
        [SchemaAttr("linkType")]
        public StringValue? LinkType
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a15:objectPr");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<ObjectProperties>()
                .AddAttribute("objectId", a => a.Id)
                .AddAttribute("isActiveX", a => a.IsActiveX)
                .AddAttribute("linkType", a => a.LinkType);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ObjectProperties>(deep);
    }

    /// <summary>
    /// <para>Defines the SignatureLine Class.</para>
    /// <para>This class is available in Office 2013 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is a15:signatureLine.</para>
    /// </summary>
    [SchemaAttr("a15:signatureLine")]
    public partial class SignatureLine : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the SignatureLine class.
        /// </summary>
        public SignatureLine() : base()
        {
        }

        /// <summary>
        /// <para>isSignatureLine, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: isSignatureLine</para>
        /// </summary>
        [SchemaAttr("isSignatureLine")]
        public BooleanValue? IsSignatureLine
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
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
        /// <para>provId, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: provId</para>
        /// </summary>
        [SchemaAttr("provId")]
        public StringValue? ProviderId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signingInstructionsSet, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: signingInstructionsSet</para>
        /// </summary>
        [SchemaAttr("signingInstructionsSet")]
        public BooleanValue? SigningInstructionsSet
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowComments, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: allowComments</para>
        /// </summary>
        [SchemaAttr("allowComments")]
        public BooleanValue? AllowComments
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showSignDate, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: showSignDate</para>
        /// </summary>
        [SchemaAttr("showSignDate")]
        public BooleanValue? ShowSignDate
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>suggestedSigner, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: suggestedSigner</para>
        /// </summary>
        [SchemaAttr("suggestedSigner")]
        public StringValue? SuggestedSigner
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>suggestedSigner2, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: suggestedSigner2</para>
        /// </summary>
        [SchemaAttr("suggestedSigner2")]
        public StringValue? SuggestedSigner2
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>suggestedSignerEmail, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: suggestedSignerEmail</para>
        /// </summary>
        [SchemaAttr("suggestedSignerEmail")]
        public StringValue? SuggestedSignerEmail
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>signingInstructions, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: signingInstructions</para>
        /// </summary>
        [SchemaAttr("signingInstructions")]
        public StringValue? SigningInstructions
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>addlXml, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: addlXml</para>
        /// </summary>
        [SchemaAttr("addlXml")]
        public StringValue? AdditionalXml
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sigProvUrl, this property is only available in Office 2013 and later.</para>
        /// <para>Represents the following attribute in the schema: sigProvUrl</para>
        /// </summary>
        [SchemaAttr("sigProvUrl")]
        public StringValue? SignatureProviderUrl
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("a15:signatureLine");
            builder.Availability = FileFormatVersions.Office2013;
            builder.AddElement<SignatureLine>()
                .AddAttribute("isSignatureLine", a => a.IsSignatureLine)
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("provId", a => a.ProviderId, aBuilder =>
                {
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true), Pattern = ("\\{[0-9A-F]{8}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{4}-[0-9A-F]{12}\\}") });
                })
                .AddAttribute("signingInstructionsSet", a => a.SigningInstructionsSet)
                .AddAttribute("allowComments", a => a.AllowComments)
                .AddAttribute("showSignDate", a => a.ShowSignDate)
                .AddAttribute("suggestedSigner", a => a.SuggestedSigner)
                .AddAttribute("suggestedSigner2", a => a.SuggestedSigner2)
                .AddAttribute("suggestedSignerEmail", a => a.SuggestedSignerEmail)
                .AddAttribute("signingInstructions", a => a.SigningInstructions)
                .AddAttribute("addlXml", a => a.AdditionalXml)
                .AddAttribute("sigProvUrl", a => a.SignatureProviderUrl);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SignatureLine>(deep);
    }

    /// <summary>
    /// Defines the TargetScreenSize enumeration.
    /// </summary>
    public enum TargetScreenSize
    {
        /// <summary>
        /// 544x376.
        /// <para>When the item is serialized out as xml, its value is "544x376".</para>
        /// </summary>
        [EnumString("544x376")]
        Sz544x376,
        /// <summary>
        /// 640x480.
        /// <para>When the item is serialized out as xml, its value is "640x480".</para>
        /// </summary>
        [EnumString("640x480")]
        Sz640x480,
        /// <summary>
        /// 720x512.
        /// <para>When the item is serialized out as xml, its value is "720x512".</para>
        /// </summary>
        [EnumString("720x512")]
        Sz720x512,
        /// <summary>
        /// 800x600.
        /// <para>When the item is serialized out as xml, its value is "800x600".</para>
        /// </summary>
        [EnumString("800x600")]
        Sz800x600,
        /// <summary>
        /// 1024x768.
        /// <para>When the item is serialized out as xml, its value is "1024x768".</para>
        /// </summary>
        [EnumString("1024x768")]
        Sz1024x768,
        /// <summary>
        /// 1152x882.
        /// <para>When the item is serialized out as xml, its value is "1152x882".</para>
        /// </summary>
        [EnumString("1152x882")]
        Sz1152x882,
        /// <summary>
        /// 1152x900.
        /// <para>When the item is serialized out as xml, its value is "1152x900".</para>
        /// </summary>
        [EnumString("1152x900")]
        Sz1152x900,
        /// <summary>
        /// 1280x1024.
        /// <para>When the item is serialized out as xml, its value is "1280x1024".</para>
        /// </summary>
        [EnumString("1280x1024")]
        Sz1280x1024,
        /// <summary>
        /// 1600x1200.
        /// <para>When the item is serialized out as xml, its value is "1600x1200".</para>
        /// </summary>
        [EnumString("1600x1200")]
        Sz1600x1200,
        /// <summary>
        /// 1800x1440.
        /// <para>When the item is serialized out as xml, its value is "1800x1440".</para>
        /// </summary>
        [EnumString("1800x1440")]
        Sz1800x1440,
        /// <summary>
        /// 1920x1200.
        /// <para>When the item is serialized out as xml, its value is "1920x1200".</para>
        /// </summary>
        [EnumString("1920x1200")]
        Sz1920x1200
    }
}