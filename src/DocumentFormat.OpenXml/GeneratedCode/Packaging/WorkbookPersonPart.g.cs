﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the WorkbookPersonPart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2019)]
    [ContentType(ContentTypeConstant)]
    [RelationshipTypeAttribute(RelationshipTypeConstant)]
    public partial class WorkbookPersonPart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-excel.person+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2017/10/relationships/person";
        private DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.PersonList? _rootElement;

        /// <summary>
        /// Creates an instance of the WorkbookPersonPart OpenXmlType
        /// </summary>
        internal protected WorkbookPersonPart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        private protected override OpenXmlPartRootElement? InternalRootElement
        {
            get
            {
                return _rootElement;
            }

            set
            {
                _rootElement = value as DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.PersonList;
            }
        }

        internal override OpenXmlPartRootElement? PartRootElement => PersonList;

        /// <summary>
        /// Gets or sets the root element of this part.
        /// </summary>
        public DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.PersonList PersonList
        {
            get
            {
                if (_rootElement is null)
                {
                    LoadDomTree<DocumentFormat.OpenXml.Office2019.Excel.ThreadedComments.PersonList>();
                }

                return _rootElement!;
            }

            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                SetDomTree(value);
            }
        }

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "person";

        /// <inheritdoc/>
        internal sealed override string TargetPath => "persons";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2019);
        }
    }
}
