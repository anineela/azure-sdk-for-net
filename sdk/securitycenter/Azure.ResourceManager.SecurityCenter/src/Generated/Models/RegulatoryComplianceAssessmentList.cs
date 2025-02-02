// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of regulatory compliance assessment response. </summary>
    internal partial class RegulatoryComplianceAssessmentList
    {
        /// <summary> Initializes a new instance of RegulatoryComplianceAssessmentList. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RegulatoryComplianceAssessmentList(IEnumerable<RegulatoryComplianceAssessmentData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of RegulatoryComplianceAssessmentList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal RegulatoryComplianceAssessmentList(IReadOnlyList<RegulatoryComplianceAssessmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<RegulatoryComplianceAssessmentData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
