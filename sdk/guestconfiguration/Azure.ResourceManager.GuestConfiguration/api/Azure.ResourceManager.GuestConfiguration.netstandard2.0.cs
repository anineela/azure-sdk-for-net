namespace Azure.ResourceManager.GuestConfiguration
{
    public partial class GuestConfigurationAssignmentData : Azure.ResourceManager.GuestConfiguration.Models.ProxyResource
    {
        public GuestConfigurationAssignmentData() { }
        public Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentProperties Properties { get { throw null; } set { } }
        public Azure.ResourceManager.Models.SystemData SystemData { get { throw null; } }
    }
    public static partial class GuestConfigurationExtensions
    {
        public static Azure.Pageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData> GetGuestConfigurationAssignments(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData> GetGuestConfigurationAssignments(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData> GetGuestConfigurationAssignmentsAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData> GetGuestConfigurationAssignmentsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> GetGuestConfigurationHcrpAssignment(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string machineName, string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>> GetGuestConfigurationHcrpAssignmentAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string machineName, string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource GetGuestConfigurationHcrpAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentCollection GetGuestConfigurationHcrpAssignments(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string machineName) { throw null; }
        public static Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> GetGuestConfigurationVmAssignment(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vmName, string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>> GetGuestConfigurationVmAssignmentAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vmName, string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource GetGuestConfigurationVmAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentCollection GetGuestConfigurationVmAssignments(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vmName) { throw null; }
        public static Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> GetGuestConfigurationVmssAssignment(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vmssName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>> GetGuestConfigurationVmssAssignmentAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vmssName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource GetGuestConfigurationVmssAssignmentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentCollection GetGuestConfigurationVmssAssignments(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string vmssName) { throw null; }
    }
    public partial class GuestConfigurationHcrpAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>, System.Collections.IEnumerable
    {
        protected GuestConfigurationHcrpAssignmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string guestConfigurationAssignmentName, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string guestConfigurationAssignmentName, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> Get(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>> GetAsync(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GuestConfigurationHcrpAssignmentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected GuestConfigurationHcrpAssignmentResource() { }
        public virtual Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string machineName, string guestConfigurationAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationHCRPAssignmentReport(string reportId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport>> GetGuestConfigurationHCRPAssignmentReportAsync(string reportId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationHCRPAssignmentReports(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationHCRPAssignmentReportsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationHcrpAssignmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GuestConfigurationVmAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>, System.Collections.IEnumerable
    {
        protected GuestConfigurationVmAssignmentCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string guestConfigurationAssignmentName, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string guestConfigurationAssignmentName, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> Get(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>> GetAsync(string guestConfigurationAssignmentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GuestConfigurationVmAssignmentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected GuestConfigurationVmAssignmentResource() { }
        public virtual Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmName, string guestConfigurationAssignmentName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationAssignmentReport(string reportId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport>> GetGuestConfigurationAssignmentReportAsync(string reportId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationAssignmentReports(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationAssignmentReportsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmAssignmentResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class GuestConfigurationVmssAssignmentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>, System.Collections.IEnumerable
    {
        protected GuestConfigurationVmssAssignmentCollection() { }
        public virtual Azure.Response<bool> Exists(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> Get(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>> GetAsync(string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class GuestConfigurationVmssAssignmentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected GuestConfigurationVmssAssignmentResource() { }
        public virtual Azure.ResourceManager.GuestConfiguration.GuestConfigurationAssignmentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vmssName, string name) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.GuestConfigurationVmssAssignmentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationAssignmentReportsVMS(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationAssignmentReportsVMs(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport>> GetGuestConfigurationAssignmentReportsVMSAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReport> GetGuestConfigurationAssignmentReportsVMsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.GuestConfiguration.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ActionAfterReboot : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ActionAfterReboot(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot ContinueConfiguration { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot StopConfiguration { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot left, Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot left, Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AssignmentInfo
    {
        public AssignmentInfo() { }
        public Azure.ResourceManager.GuestConfiguration.Models.ConfigurationInfo Configuration { get { throw null; } set { } }
        public string Name { get { throw null; } }
    }
    public partial class AssignmentReport
    {
        public AssignmentReport() { }
        public Azure.ResourceManager.GuestConfiguration.Models.AssignmentInfo Assignment { get { throw null; } set { } }
        public Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus? ComplianceStatus { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.Type? OperationType { get { throw null; } }
        public string ReportId { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.GuestConfiguration.Models.AssignmentReportResource> Resources { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.VmInfo Vm { get { throw null; } set { } }
    }
    public partial class AssignmentReportDetails
    {
        internal AssignmentReportDetails() { }
        public Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus? ComplianceStatus { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public string JobId { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.Type? OperationType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.GuestConfiguration.Models.AssignmentReportResource> Resources { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
    }
    public partial class AssignmentReportResource
    {
        public AssignmentReportResource() { }
        public Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus? ComplianceStatus { get { throw null; } }
        public System.BinaryData Properties { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.GuestConfiguration.Models.AssignmentReportResourceComplianceReason> Reasons { get { throw null; } }
        public string ResourceId { get { throw null; } }
    }
    public partial class AssignmentReportResourceComplianceReason
    {
        public AssignmentReportResourceComplianceReason() { }
        public string Code { get { throw null; } }
        public string Phrase { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AssignmentType : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.AssignmentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AssignmentType(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.AssignmentType ApplyAndAutoCorrect { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.AssignmentType ApplyAndMonitor { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.AssignmentType Audit { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.AssignmentType DeployAndAutoCorrect { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.AssignmentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.AssignmentType left, Azure.ResourceManager.GuestConfiguration.Models.AssignmentType right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.AssignmentType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.AssignmentType left, Azure.ResourceManager.GuestConfiguration.Models.AssignmentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ComplianceStatus : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ComplianceStatus(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus Compliant { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus NonCompliant { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus Pending { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus left, Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus left, Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfigurationInfo
    {
        public ConfigurationInfo() { }
        public string Name { get { throw null; } }
        public string Version { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ConfigurationMode : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ConfigurationMode(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode ApplyAndAutoCorrect { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode ApplyAndMonitor { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode ApplyOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode left, Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode left, Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ConfigurationParameter
    {
        public ConfigurationParameter() { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class ConfigurationSetting
    {
        internal ConfigurationSetting() { }
        public Azure.ResourceManager.GuestConfiguration.Models.ActionAfterReboot? ActionAfterReboot { get { throw null; } }
        public bool? AllowModuleOverwrite { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.ConfigurationMode? ConfigurationMode { get { throw null; } }
        public float? ConfigurationModeFrequencyMins { get { throw null; } }
        public bool? RebootIfNeeded { get { throw null; } }
        public float? RefreshFrequencyMins { get { throw null; } }
    }
    public partial class GuestConfigurationAssignmentProperties
    {
        public GuestConfigurationAssignmentProperties() { }
        public string AssignmentHash { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus? ComplianceStatus { get { throw null; } }
        public string Context { get { throw null; } set { } }
        public Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationNavigation GuestConfiguration { get { throw null; } set { } }
        public System.DateTimeOffset? LastComplianceStatusChecked { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.AssignmentReport LatestAssignmentReport { get { throw null; } set { } }
        public string LatestReportId { get { throw null; } }
        public string ParameterHash { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public string TargetResourceId { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.GuestConfiguration.Models.VmssVmInfo> VmssVmList { get { throw null; } set { } }
    }
    public partial class GuestConfigurationAssignmentReport
    {
        internal GuestConfigurationAssignmentReport() { }
        public string Id { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationAssignmentReportProperties Properties { get { throw null; } }
    }
    public partial class GuestConfigurationAssignmentReportProperties
    {
        internal GuestConfigurationAssignmentReportProperties() { }
        public Azure.ResourceManager.GuestConfiguration.Models.AssignmentInfo Assignment { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus? ComplianceStatus { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.AssignmentReportDetails Details { get { throw null; } }
        public System.DateTimeOffset? EndOn { get { throw null; } }
        public string ReportId { get { throw null; } }
        public System.DateTimeOffset? StartOn { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.VmInfo Vm { get { throw null; } }
        public string VmssResourceId { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GuestConfigurationKind : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GuestConfigurationKind(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind DSC { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind left, Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind left, Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GuestConfigurationNavigation
    {
        public GuestConfigurationNavigation() { }
        public string AssignmentSource { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.AssignmentType? AssignmentType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.GuestConfiguration.Models.ConfigurationParameter> ConfigurationParameter { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.GuestConfiguration.Models.ConfigurationParameter> ConfigurationProtectedParameter { get { throw null; } }
        public Azure.ResourceManager.GuestConfiguration.Models.ConfigurationSetting ConfigurationSetting { get { throw null; } }
        public string ContentHash { get { throw null; } set { } }
        public string ContentType { get { throw null; } }
        public System.Uri ContentUri { get { throw null; } set { } }
        public Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationKind? Kind { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
    }
    public partial class GuestConfigurationResourceData
    {
        public GuestConfigurationResourceData() { }
        public string Id { get { throw null; } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string ResourceType { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState Created { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState left, Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState left, Azure.ResourceManager.GuestConfiguration.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProxyResource : Azure.ResourceManager.GuestConfiguration.Models.GuestConfigurationResourceData
    {
        public ProxyResource() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Type : System.IEquatable<Azure.ResourceManager.GuestConfiguration.Models.Type>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Type(string value) { throw null; }
        public static Azure.ResourceManager.GuestConfiguration.Models.Type Consistency { get { throw null; } }
        public static Azure.ResourceManager.GuestConfiguration.Models.Type Initial { get { throw null; } }
        public bool Equals(Azure.ResourceManager.GuestConfiguration.Models.Type other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.GuestConfiguration.Models.Type left, Azure.ResourceManager.GuestConfiguration.Models.Type right) { throw null; }
        public static implicit operator Azure.ResourceManager.GuestConfiguration.Models.Type (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.GuestConfiguration.Models.Type left, Azure.ResourceManager.GuestConfiguration.Models.Type right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VmInfo
    {
        public VmInfo() { }
        public string Id { get { throw null; } }
        public string Uuid { get { throw null; } }
    }
    public partial class VmssVmInfo
    {
        public VmssVmInfo() { }
        public Azure.ResourceManager.GuestConfiguration.Models.ComplianceStatus? ComplianceStatus { get { throw null; } }
        public System.DateTimeOffset? LastComplianceChecked { get { throw null; } }
        public string LatestReportId { get { throw null; } }
        public string VmId { get { throw null; } }
        public string VmResourceId { get { throw null; } }
    }
}
