// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Details of VM Resource having Dynatrace OneAgent installed. </summary>
    public partial class VmInfo
    {
        /// <summary> Initializes a new instance of VmInfo. </summary>
        internal VmInfo()
        {
        }

        /// <summary> Initializes a new instance of VmInfo. </summary>
        /// <param name="resourceId"> Azure VM resource ID. </param>
        /// <param name="version"> Version of the Dynatrace agent installed on the VM. </param>
        /// <param name="monitoringType"> The monitoring mode of OneAgent. </param>
        /// <param name="autoUpdateSetting"> Update settings of OneAgent. </param>
        /// <param name="updateStatus"> The current update status of OneAgent. </param>
        /// <param name="availabilityState"> The availability state of OneAgent. </param>
        /// <param name="logModule"> Tells whether log modules are enabled or not. </param>
        /// <param name="hostGroup"> The name of the host group. </param>
        /// <param name="hostName"> The name of the host. </param>
        internal VmInfo(string resourceId, string version, MonitoringType? monitoringType, AutoUpdateSetting? autoUpdateSetting, UpdateStatus? updateStatus, AvailabilityState? availabilityState, LogModule? logModule, string hostGroup, string hostName)
        {
            ResourceId = resourceId;
            Version = version;
            MonitoringType = monitoringType;
            AutoUpdateSetting = autoUpdateSetting;
            UpdateStatus = updateStatus;
            AvailabilityState = availabilityState;
            LogModule = logModule;
            HostGroup = hostGroup;
            HostName = hostName;
        }

        /// <summary> Azure VM resource ID. </summary>
        public string ResourceId { get; }
        /// <summary> Version of the Dynatrace agent installed on the VM. </summary>
        public string Version { get; }
        /// <summary> The monitoring mode of OneAgent. </summary>
        public MonitoringType? MonitoringType { get; }
        /// <summary> Update settings of OneAgent. </summary>
        public AutoUpdateSetting? AutoUpdateSetting { get; }
        /// <summary> The current update status of OneAgent. </summary>
        public UpdateStatus? UpdateStatus { get; }
        /// <summary> The availability state of OneAgent. </summary>
        public AvailabilityState? AvailabilityState { get; }
        /// <summary> Tells whether log modules are enabled or not. </summary>
        public LogModule? LogModule { get; }
        /// <summary> The name of the host group. </summary>
        public string HostGroup { get; }
        /// <summary> The name of the host. </summary>
        public string HostName { get; }
    }
}
