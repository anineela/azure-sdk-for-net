// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> time aggregation type. How the data that is collected should be combined over time. The default value is Average. </summary>
    public enum MonitorTimeAggregationType
    {
        /// <summary> Average. </summary>
        Average,
        /// <summary> Minimum. </summary>
        Minimum,
        /// <summary> Maximum. </summary>
        Maximum,
        /// <summary> Total. </summary>
        Total,
        /// <summary> Count. </summary>
        Count,
        /// <summary> Last. </summary>
        Last
    }
}
