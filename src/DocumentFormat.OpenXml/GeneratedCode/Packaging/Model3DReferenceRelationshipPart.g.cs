﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the Model3DReferenceRelationshipPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class Model3DReferenceRelationshipPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "model/gltf-binary";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/06/relationships/model3d";

        /// <summary>
        /// Creates an instance of the Model3DReferenceRelationshipPart OpenXmlType
        /// </summary>
        internal protected Model3DReferenceRelationshipPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetFileExtension => ".glb";

        /// <inheritdoc/>
        internal sealed override string TargetName => "model3d";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "../media";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
    }
}
