#DD.CBU.Compute.Api.Client


##CBU.Compute.Api.Client.Account.AccountAccessor
            
The account accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetAccounts
The get accounts.
> #####Return value
> The .

####GetAccountsWithPhoneNumber
The get accounts with phone number.
> #####Return value
> The .

####GetAdministratorAccount(System.String)
The get administrator account.
> #####Parameters
> **username:** The username.

> #####Return value
> The .

####AddSubAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
The add sub administrator account.
> #####Parameters
> **account:** The account.

> #####Return value
> The .

####DeleteSubAdministratorAccount(System.String)
The delete sub administrator account.
> #####Parameters
> **username:** The username.

> #####Return value
> The .

####UpdateAdministratorPhoneNumber(System.String,System.String,System.String)
The update administrator phone number.
> #####Parameters
> **userName:** The User Name

> **phoneCountryCode:** The Phone Country Code

> **phoneNumber:** The Phone Number

> #####Return value
> The .

####ChangePassword(System.String,System.String)
The update administrator password.
> #####Parameters
> **userName:** The User Name

> **password:** The Password

> #####Return value
> The .

####UpdateAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
The update administrator account.
> #####Parameters
> **account:** The account.

> #####Return value
> The .

####GetListOfMultiGeographyRegions
The get list of multi geography regions.
> #####Return value
> The .

####GetListOfSoftwareLabels
The get list of software labels.
> #####Return value
> The .

####GetDataCentersWithMaintenanceStatuses(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get data centers with maintenance statuses.
> #####Parameters
> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetDataCenterWithMaintenanceStatus(System.String)
The get data center with maintenance status.
> #####Parameters
> **locationId:** The identifier of the datacenter.

> #####Return value
> The .

####DesignatePrimaryAdministratorAccount(System.String)
The designate primary administrator account.
> #####Parameters
> **username:** The username.

> #####Return value
> The .

####GetTwoFactorAuthenticationStatus
The get two factor authentication status.
> #####Return value
> The .

####SetTwoFactorAuthenticationStatus(DD.CBU.Compute.Api.Contracts.Organization.TwoFactorAuthentication)
The set two factor authentication status.
> #####Parameters
> **status:** The status.

> #####Return value
> The .

##CBU.Compute.Api.Client.Backup.BackupAccessor
            
The backup accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####EnableBackup(System.String,DD.CBU.Compute.Api.Contracts.Backup.ServicePlan)
The enable backup.
> #####Parameters
> **serverId:** The server id.

> **plan:** The plan.

> #####Return value
> The .

####DisableBackup(System.String)
The disable backup.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ChangeBackupPlan(System.String,DD.CBU.Compute.Api.Contracts.Backup.ServicePlan)
The change backup plan.
> #####Parameters
> **serverId:** The server id.

> **plan:** The plan.

> #####Return value
> The .

####GetBackupClientTypes(System.String)
The get backup client types.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetBackupStoragePolicies(System.String)
The get backup storage policies.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetBackupSchedulePolicies(System.String)
The get backup schedule policies.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetBackupClients(System.String)
The get backup clients.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####AddBackupClient(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientType,DD.CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy,DD.CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The add backup client.
> #####Parameters
> **serverId:** The server id.

> **clientType:** The client type.

> **storagePolicy:** The storage policy.

> **schedulePolicy:** The schedule policy.

> **alertingType:** The alerting type.

> #####Return value
> The .

####AddBackupClient(System.String,System.String,System.String,System.String,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The add backup client.
> #####Parameters
> **serverId:** The server id.

> **clientType:** The client type.

> **storagePolicy:** The storage policy.

> **schedulePolicy:** The schedule policy.

> **alertingType:** The alerting type.

> #####Return value
> The .

####RemoveBackupClient(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
The remove backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> #####Return value
> The .

####RemoveBackupClient(System.String,System.String)
The remove backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The backup client id.

> #####Return value
> The .

####ModifyBackupClient(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,DD.CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy,DD.CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The modify backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **storagePolicy:** The storage policy.

> **schedulePolicy:** The schedule policy.

> **alertingType:** The alerting type.

> #####Return value
> The .

####ModifyBackupClient(System.String,System.String,System.String,System.String,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The modify backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The Backup Client Id.

> **schedulePolicyName:** The Schedule Policy Name

> **alertingType:** The alerting type.

> **storagePolicyName:** The Storage Policy Name

> #####Return value
> The .

####InitiateBackup(System.String,System.String)
The initiate backup.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The backup client id.

> #####Return value
> The .

####InitiateBackup(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
The initiate backup.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> #####Return value
> The .

####CancelBackupJob(System.String,System.String)
The cancel backup job.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The backup client id.

> #####Return value
> The .

####CancelBackupJob(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
The cancel backup job.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> #####Return value
> The .

####InPlaceRestore(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,System.DateTime)
In place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **asAtDate:** The date and time to recover to.

> #####Return value
> A Status message from the API.

####InPlaceRestore(System.String,System.String,System.DateTime)
In place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** Identifier for the backup client.

> **asAtDate:** The date and time to recover to.

> #####Return value
> A Status message from the API.

####OutOfPlaceRestore(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,System.DateTime,DD.CBU.Compute.Api.Contracts.Server.ServerWithBackupType)
Out of place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **asAtDate:** The date and time to recover to.

> **targetServer:** Target client.

> #####Return value
> A Status message from the API;

####OutOfPlaceRestore(System.String,System.String,System.DateTime,System.String)
Out of place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** Identifier for the backup client.

> **asAtDate:** The date and time to recover to.

> **targetServerId:** Identifier for the target client.

> #####Return value
> A Status message from the API;

####OutOfPlaceRestore(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,System.DateTime,DD.CBU.Compute.Api.Contracts.Network20.ServerType)
Out of place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **asAtDate:** The date and time to recover to.

> **targetServer:** Target server.

> #####Return value
> A Status message from the API;

####GetSystemRestoreTargets(System.Guid,System.String)
Retrieves a list of compatible target Servers for an Out of Place given a specific deployed Server and Backup Client Type as input.
> #####Parameters
> **serverId:** 

> **backupClientType:** 

> #####Return value
> 

##CBU.Compute.Api.Client.Backup.ComputeApiClientBackupExtensions
            
Extension methods for the backup section of the CaaS API.
        
###Methods


####EnableBackup(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.ServicePlan)
Enables the backup with a specific service plan.
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **plan:** The enumerated service plan

> #####Return value
> The status of the request

####DisableBackup(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Disable the backup service from the server. Note the server MUST not have any clients
> #####Parameters
> **client:** The object

> **serverId:** The server id

> #####Return value
> The status of the request

####ChangeBackupPlan(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.ServicePlan)
Modify the backup service plan.
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **plan:** The plan to change to

> #####Return value
> The status of the request

####GetBackupClientTypes(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
List the client types for a specified server
> #####Parameters
> **client:** The object

> **serverId:** The server id

> #####Return value
> The status of the request

####GetBackupStoragePolicies(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
List the storage policies for a specified server
> #####Parameters
> **client:** The object

> **serverId:** The server id

> #####Return value
> The status of the request

####GetBackupSchedulePolicies(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
List the schedule policies for a specified server
> #####Parameters
> **client:** The object

> **serverId:** The server id

> #####Return value
> The status of the request

####GetBackupClients(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Gets a list of backup clients.
> #####Parameters
> **client:** The object

> **serverId:** The server id

> #####Return value
> A list of backup clients

####AddBackupClient(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientType,DD.CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy,DD.CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
Adds a backup client to a specified server.
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **clientType:** The backup client type to add

> **storagePolicy:** The backup storage policy

> **schedulePolicy:** The backup schedule policy

> **alertingType:** The alerting type

> #####Return value
> The status of the request

####RemoveBackupClient(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
Removes the backup client from a specified server.
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **backupClient:** The backup client to remove

> #####Return value
> The status of the request

####ModifyBackupClient(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,DD.CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy,DD.CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
Modifies the backup client on the specified server.
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **backupClient:** The backup client to modify

> **storagePolicy:** The storage policy to modify

> **schedulePolicy:** The schedule policy to modify

> **alertingType:** The alerting type to modify

> #####Return value
> The status of the request

####InitiateBackup(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
Requests an immediate Backup for a Backup Client
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **backupClient:** The backup client to modify

> #####Return value
> The status of the request

####CancelBackupJob(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
Requests a cancellation for any running job for a backup client
> #####Parameters
> **client:** The object

> **serverId:** The server id

> **backupClient:** The backup client to modify

> #####Return value
> The status of the request

##CBU.Compute.Api.Client.Drs.ConsistencyGroupAccessor
            
The Consistency Group Accessor type.
        
###Fields

####_apiClient
The _client.
###Methods


####Constructor
Initializes a new instance of the DD.CBU.Compute.Api.Client.Network20.NetworkDomain class.
> #####Parameters
> **apiClient:** The client.


####GetConsistencyGroups(DD.CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupListOptions)
The Get Consistency Group method.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> List of

####GetConsistencyGroupsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The Get Consistency Group menthod.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The pagination options.

> #####Return value
> Paginated result of

####CreateConsistencyGroup(DD.CBU.Compute.Api.Contracts.Drs.CreateConsistencyGroupType)
The Create Consistency Group
> #####Parameters
> **createConsistencyGroup:** The create consistency group type.

> #####Return value
> The

####GetConsistencyGroupSnapshots(DD.CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupSnapshotListOptions)
The Get Consistency Group Snapshot method.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> List of

####StopPreviewSnapshot(DD.CBU.Compute.Api.Contracts.Drs.StopPreviewSnapshotType)
The stop preview snapshot of a consistency group.
> #####Parameters
> **stopPreviewSnapshotType:** The stop preview snapshot type.

> #####Return value
> The

####StartPreviewSnapshot(DD.CBU.Compute.Api.Contracts.Drs.StartPreviewSnapshotType)
Start preview snapshot of a consistency group.
> #####Parameters
> **startPreviewSnapshotType:** The start preview snapshot type.

> #####Return value
> The

####DeleteConsistencyGroup(DD.CBU.Compute.Api.Contracts.Drs.DeleteConsistencyGroupType)
The Delete Consistency Group method.
> #####Parameters
> **deleteConsistencyGroupType:** The delete consistency group.

> #####Return value
> 

####InitiateFailoverForConsistencyGroup(DD.CBU.Compute.Api.Contracts.Drs.InitiateFailoverType)
The initiate failover for a consistency group.
> #####Parameters
> **InitiateFailover:** The Initiate failover type.

> #####Return value
> The

####ExpandJournal(DD.CBU.Compute.Api.Contracts.Drs.ExpandJournalType)
Expand journal
> #####Parameters
> **expandJournalType:** Expand journal type.

> #####Return value
> The

##CBU.Compute.Api.Client.ApiClientException
            
The base class for API client exceptions.
        
###Methods


####Constructor
Initialises a new instance of the class. Create a new .
> #####Parameters
> **messageOrFormat:** The exception message or message format.

> **formatArguments:** Optional message format arguments.


####Constructor
Initialises a new instance of the class. Create a new .
> #####Parameters
> **messageOrFormat:** The exception message or message format.

> **innerException:** A previous exception that caused the current exception to be raised.

> **formatArguments:** Optional message format arguments.


####Constructor
Initialises a new instance of the class. Deserialisation constructor for .
> #####Parameters
> **info:** A serialisation data store that holds the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.ApiUris
            
Constants and formatters for API URLs.
        
###Fields

####MCP1_0_PREFIX
The MCP 1.0 prefix.
####MCP2_3_PREFIX
The MCP 2.3 prefix.
####MyAccount
The path (relative to the base API URL) of the My Account action.
###Methods


####Account(System.Guid)
Accounts the given organisation identifier.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####AccountWithPhoneNumber(System.Guid)
The path (relative to the base API URL) to Account With Phone Number action.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The .

####UpdateAdministrator(System.Guid,System.String)
The path (relative to the base API URL) to update My Account action.
> #####Parameters
> **orgId:** The org Id.

> **username:** The username.

> #####Return value
> The .

####AccountWithPhoneNumber(System.Guid,System.String)
The path (relative to the base API URL) to Account With Phone Number action.
> #####Parameters
> **orgId:** The org Id.

> **username:** The username.

> #####Return value
> The .

####SetPrimaryAdministrator(System.Guid,System.String)
The path (relative to the base API URL) set primary administrator action.
> #####Parameters
> **orgId:** The org Id.

> **username:** The username.

> #####Return value
> The .

####DeleteSubAdministrator(System.Guid,System.String)
The path (relative to the base API URL) delete sub administrator action.
> #####Parameters
> **orgId:** The org Id.

> **username:** The username.

> #####Return value
> The .

####ComputeBase(System.String)
Get the base URI for the CaaS REST API.
> #####Parameters
> **targetRegionName:** The target region's short name ("au", for example).

> #####Return value
> The base URI for the CaaS REST API.

####SoftwareLabels(System.Guid)
Get the relative URI for the CaaS API action that retrieves a list of all software labels for deployment by the specified organisation.
> #####Parameters
> **organizationId:** The organisation Id.

> #####Return value
> The relative action Uri.

####MultiGeographyRegions(System.Guid)
Get the relative URI for the CaaS API action that retrieves a list of Multiple Geography Regions for deployment by the specified organisation.
> #####Parameters
> **organizationId:** The organisation Id.

> #####Return value
> The relative action Uri.

####DatacentersWithDiskSpeedDetails(System.Guid)
Get the relative URI for the CaaS API action that retrieves a list of all data centres available for use by the specified organisation.
> #####Parameters
> **organizationId:** The organisation Id.

> #####Return value
> The relative action Uri.

####NetworkDomains(System.Guid)
The network domains.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####NetworkDomain(System.Guid,System.Guid)
The network domain.
> #####Parameters
> **orgId:** The org id.

> **networkDomainId:** The network Domain Id.

> #####Return value
> The .

####AddNic(System.Guid)
Anthony, 4/24/2015.
Adds a NIC to a server
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####RemoveNic(System.Guid)
Removes a NIC from a server
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####ListNics(System.Guid,System.Guid)
Lists Nics under a VLAN
> #####Parameters
> **orgId:** The org Id.

> **vlanId:** The VLAN Id

> #####Return value
> An URI.

####NotifyNicIpChange(System.Guid)
Returns the relative URI of the REST request for Botify NIC IP change.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####CreateNetworkDomain(System.Guid)
Get the URI for creating a network domain.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####ModifyNetworkDomain(System.Guid)
The modify network domain.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####DeleteNetworkDomain(System.Guid)
Deletes the network domain described by orgId.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####DeployServerOnNetworkDomain(System.Guid)
Deploy server on network domains url.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####DataCentres(System.Guid)
Get the relative URI for the CaaS API action that retrieves a list of all data centres available for use by the specified organisation.
> #####Parameters
> **orgId:** The organisation Id

> #####Return value
> The relative action Uri.

####DatacentresWithMaintanence(System.Guid)
Get the relative URI for the CaaS API action that retrieves a list of all data centres available for use by the specified organisation.
> #####Parameters
> **orgId:** The organisation Id

> #####Return value
> The relative action Uri.

####DatacentreWithMaintanence(System.Guid,System.String)
Get the relative URI for the CaaS API action that retrieves a list of all data centres available for use by the specified organisation.
> #####Parameters
> **orgId:** The organisation Id

> **locationId:** The location id.

> #####Return value
> The relative action Uri.

####ImagesWithSoftwareLabels(System.String)
Get the relative URI for the CaaS API action that retrieves a list of all system-defined images deployed in the specified data centre.
> #####Parameters
> **locationName:** The data centre location name.

> #####Return value
> The relative action Uri.

####ImagesWithDiskSpeed(System.Guid,DD.CBU.Compute.Api.Client.ServerImageType,System.String,System.String,System.String,System.String,System.String)
Gets the relative URI for the CaaS API action that retrieves a filtered list of server images or servers.
> #####Parameters
> **orgId:** The organization id

> **imagetype:** The imagetype.

> **imageId:** The image Id.

> **name:** The server name

> **location:** The server location

> **operatingSystemId:** The operating System Id.

> **operatingSystemFamily:** The operating System Family.

> #####Return value
> A list of deployed servers

####RemoveCustomerServerImage(System.Guid,System.String)
Gets the relative URI for the CaaS API action that delete a customer image.
> #####Parameters
> **orgId:** The organization id

> **imageId:** The customer image id

> #####Return value
> The .

####CleanFailedCustomerServerImage(System.Guid,System.String)
Gets the relative URI for the CaaS API action that clean a failed customer image.
> #####Parameters
> **orgId:** The organization id

> **imageId:** The customer image id

> #####Return value
> The .

####CopyCustomerServerImage(System.Guid)
Gets the relative URI for the CaaS API action that copies customer source image.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> The .

####DeployedServers(System.Guid)
Gets the relative URI for the CaaS API action that retrieves a filtered list of deployed servers.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> A list of deployed servers

####DeployedServers(System.Guid,System.String,System.String,System.String,System.String)
Gets the relative URI for the CaaS API action that retrieves a filtered list of deployed servers.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server Id.

> **name:** The server name

> **networkId:** The server networkid

> **location:** The server location

> #####Return value
> A list of deployed servers

####CustomerImagesWithSoftwareLabels(System.Guid,System.String)
Gets the relative URI for the CaaS API action that retrieves a list of customer images with software labels
> #####Parameters
> **orgId:** The organization id

> **networkLocation:** The network location id

> #####Return value
> A list of OS server images

####DeployServer(System.Guid)
(This method is obsolete) deploy server.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####DeployServerWithDiskSpeed(System.Guid)
Deploy server with disk speed.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####ModifyServer(System.Guid,System.String)
Modify the server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for a modify servers

####EditServerMetadata(System.Guid)
Edit server metadata.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI of the REST request for a Edit server metadata

####DeleteServer(System.Guid,System.String)
Deletes the server. The Server must be stopped before it can be deleted
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for a deletion of the server

####ShutdownServer(System.Guid,System.String)
A “graceful” stop of a server by initiating a shutdown sequence within the guest operating system.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for a graceful shutdown of the server

####PowerOnServer(System.Guid,System.String)
Powers on an existing deployed server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for starting the server

####PoweroffMcp1Server(System.Guid,System.String)
An abrupt power off of the server. Success is guarenteed
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for powering off the server

####RebootServer(System.Guid,System.String)
A "graceful" reboot of the server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for rebooting the server

####ResetServer(System.Guid,System.String)
Resets the server (hard reset).
> #####Parameters
> **orgId:** The org Id.

> **serverId:** The server Id.

> #####Return value
> An URI.

####UpdateServerVMwareTools(System.Guid,System.String)
Triggers an update of the VMware Tools software running on the guest OS of a virtual server
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for rebooting the server

####CloneServerToCustomerImage(System.Guid,System.String,System.String,System.String)
Initiates a clone of a server to create a Customer Image
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> **imageName:** The image Name.

> **imageDesc:** The image Desc.

> #####Return value
> Returns the relative URI of the REST request for rebooting the server

####ChangeServerDiskSpeed(System.Guid,System.String,System.String)
Change server disk speed
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> **diskId:** The disk id

> #####Return value
> Returns the relative URI of the REST request for change server disk size the server

####ChangeServerDiskSize(System.Guid,System.String,System.String)
Change server disk size
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> **diskId:** The disk id

> #####Return value
> Returns the relative URI of the REST request for change server disk size the server

####AddServerDisk(System.Guid,System.String,System.String,System.String)
Adds a additional disk to a CaaS server
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> **size:** The size of the new disk

> **speedId:** The speed of the new disk

> #####Return value
> The .

####RemoveServerDisk(System.Guid,System.String,System.String)
The relative URI for the CaaS API action that deletes a server disk
> #####Parameters
> **orgId:** The organisation id

> **serverId:** The server id

> **diskId:** The disk id

> #####Return value
> The .

####CreateAntiAffinityRule(System.Guid)
The relative URI for the CaaS API action that creates a anti affinity rule
> #####Parameters
> **orgId:** The organisation id

> #####Return value
> The .

####GetAntiAffinityRule(System.Guid,System.String,System.String,System.String)
The relative URI for the CaaS API action that deletes a anti affinity rule
> #####Parameters
> **orgId:** The org id

> **ruleId:** The anti affinity rule id

> **location:** The location

> **networkId:** The network id

> #####Return value
> The .

####RemoveAntiAffinityRule(System.Guid,System.String)
Removes the anti affinity rule.
> #####Parameters
> **orgId:** The org Id.

> **ruleId:** The anti affinity rule id.

> #####Return value
> An URI.

####GetMcp2Servers(System.Guid)
Anthony, 6/17/2015.
Gets MCP 2 servers.
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> The MCP 2 servers.

####GetMcp2Server(System.Guid,System.Guid)
Anthony, 6/17/2015.
Gets MCP 2 server.
> #####Parameters
> **orgId:** The organization Id.

> **serverId:** The server Id.

> #####Return value
> The MCP 2 servers.

####GetMcp2GetAntiAffinityRules(System.Guid)
Gets the list anti affinity rule URL.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL.

####GetMcp2GetAntiAffinityRulesForServer(System.Guid,System.Guid)
Gets the list anti affinity rule URL.
> #####Parameters
> **orgId:** The org Id.

> **serverId:** The server Id.

> #####Return value
> The URL.

####GetMcp2GetAntiAffinityRulesForNetwork(System.Guid,System.Guid)
Gets the list anti affinity rule URL.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The network Id.

> #####Return value
> The URL.

####GetMcp2GetAntiAffinityRulesForNetworkDomain(System.Guid,System.Guid)
Gets the list anti affinity rule URL.
> #####Parameters
> **orgId:** The org Id.

> **networkDomainId:** The network domain Id.

> #####Return value
> The URL.

####GetFirewallRules(System.Guid)
Gets the list firewall rules URL.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL.

####GetFirewallRule(System.Guid,System.Guid)
Gets the get firewall rule URL.
> #####Parameters
> **orgId:** The org Id.

> **firewallRuleId:** The firewall rule Id.

> #####Return value
> The URL.

####CreateFirewallRule(System.Guid)
Gets the create firewall rule URL.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL.

####EditFirewallRule(System.Guid)
Gets the edit firewall rule URL.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL.

####DeleteFirewallRule(System.Guid)
Gets the delete firewall rule URL.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL.

####GetVlan(System.Guid,System.Guid,System.String,System.Guid)
The get Virtual LAN.
> #####Parameters
> **orgId:** The org id.

> **id:** The id.

> **vlanName:** The Virtual LAN name.

> **networkDomainId:** The network domain id.

> #####Return value
> The .

####GetVlan(System.Guid,System.Guid)
The get Virtual LAN.
> #####Parameters
> **orgId:** The org id.

> **vlanId:** Identifier for the vlan.

> #####Return value
> The .

####GetVlanByOrgId(System.Guid)
Gets vlan by organisation identifier.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The vlan by organisation identifier.

####DeployVlan(System.Guid)
The relative URI for the CaaS API for deploying the VLan.
> #####Parameters
> **orgId:** The organization ID.

> #####Return value
> A URI.

####EditVlan(System.Guid)
The relative URI for the CaaS API for editing the VLan.
> #####Parameters
> **orgId:** The organization ID.

> #####Return value
> A URI.

####ExpandVlan(System.Guid)
The relative URI for the CaaS API for expanding the VLan.
> #####Parameters
> **orgId:** The organization ID.

> #####Return value
> A URI.

####DeleteVlan(System.Guid)
Deletes the vlan described by orgId.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####NetworkWithLocations(System.Guid)
Lists the Networks deployed across all data center locations for the supplied organization.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI of the REST request for a list of networks

####NetworkWithLocation(System.Guid,System.String)
Lists the Networks deployed across all data center locations for the supplied organization.
> #####Parameters
> **orgId:** The organization id

> **locationId:** The identifier of the location to get the networks from.

> #####Return value
> Returns the relative URI of the REST request for a list of networks

####CreateAclRule(System.Guid,System.String)
Create an ACL rule
> #####Parameters
> **orgId:** The organization id

> **networkId:** The network id

> #####Return value
> Returns the relative URI of the REST request for creating an ACL rule

####DeleteAclRule(System.Guid,System.String,System.String)
Removes the ACL rule
> #####Parameters
> **orgId:** The organization id

> **networkId:** The network id

> **aclId:** The ACL rule id

> #####Return value
> Returns the relative URI of the REST request for removing an ACL rule

####GetAclRules(System.Guid,System.String)
Getting all the ACL rules in the network
> #####Parameters
> **orgId:** The organization id

> **networkId:** The network id

> #####Return value
> Returns the relative URI of the REST request for getting ACL rules

####GetNatRules(System.Guid,System.String)
Gets all the NAT rules for a specified network.
> #####Parameters
> **orgId:** The organization id.

> **networkId:** The network id.

> #####Return value
> Returns the relative URI of the REST request for getting the NAT rules

####CreateNatRule(System.Guid,System.String)
Creates a new NAT rule.
> #####Parameters
> **orgId:** The organization id.

> **networkId:** The network id.

> #####Return value
> Returns the relative URI of the REST request for creating a new NAT rule

####DeleteNatRule(System.Guid,System.String,System.String)
Deletes a specified NAT rule
> #####Parameters
> **orgId:** The organization id.

> **networkId:** The network id.

> **natRuleId:** The NAT rule id to delete

> #####Return value
> Returns the relative URI of the REST request for deleting an existing NAT rule

####CreateNetwork(System.Guid)
Gets the relative URI for the CaaS API action that creates a network in a specified data centre location.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI of the REST request for creating a network.

####DeleteNetwork(System.Guid,System.String)
Deletes the network.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> An URI.

####ModifyNetwork(System.Guid,System.String)
Modify network.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> An URI.

####GetNetworkConfig(System.Guid,System.String)
Gets network configuration.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> The network configuration.

####ReserveNetworkPublicIpAddressBlock(System.Guid,System.String)
Reserve network public IP address block.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> An URI.

####ReleaseNetworkPublicIpAddressBlock(System.Guid,System.String,System.String)
Release public ip address block
> #####Parameters
> **orgId:** The org id

> **networkId:** The network id

> **ipBlockId:** The block id

> #####Return value
> The .

####SetServerToVipNetworkPublicIpAddressBlock(System.Guid,System.String,System.String)
Set server to vip ip address block setting
> #####Parameters
> **orgId:** The org id

> **networkId:** The network id

> **ipBlockId:** The block id

> #####Return value
> The .

####SetNetworkMulticast(System.Guid,System.String)
Set multicast on network setting
> #####Parameters
> **orgId:** The org id

> **networkId:** The network id

> #####Return value
> The .

####EnableBackup(System.Guid,System.String)
Enables the Backup service for a deployed Server. Requires the Organization ID, Server ID and the Service Plan being enabled.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for enabling the backup on the server

####DisableBackup(System.Guid,System.String)
Disables the Backup service for a deployed server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for disabling the backup on the server

####ChangeBackupPlan(System.Guid,System.String)
Modify the backup service plan for a deployed server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for modifying the backup service pland of the server

####BackupClientTypes(System.Guid,System.String)
Backup client types associated with a specific server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request listing the client types for the server

####BackupStoragePolicies(System.Guid,System.String)
Backup storage policies associated with a specific server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request listing the storage policies for the server

####BackupSchedulePolicies(System.Guid,System.String)
Backup schedule policies associated with a specific server.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request listing the schedule policies for the server

####GetBackupDetails(System.Guid,System.String)
Retrieves complete details of how the Backup service is configured for a specific deployed Server. Requires the Organization ID and Server ID for the Server and that the Server already has the Backup service enabled. The user must be the Primary Administrator or a Sub-Administrator with the “backup” role.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for getting the backup details of the server

####AddBackupClient(System.Guid,System.String)
Provisions a new Backup Client for a deployed Server. Requires the Organization ID, the Server ID for the server and that the Server already has the Backup service enabled. The user must be the Primary Administrator or a Sub-Administrator with the “backup” role
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> #####Return value
> Returns the relative URI of the REST request for adding a backup client to the server

####RemoveBackupClient(System.Guid,System.String,System.String)
Removes a Backup Client for the Backup service on a deployed Server. Requires the Organization ID, Server ID and Backup Client ID for the relevant Backup Client and Server and that the Server already has the Backup service enabled. The user must be the Primary Administrator or a Sub-Administrator with the “backup” role. Note that the Backup Client ID is available from the backupClient.id additionalInformation element in the response received when the Backup Client was originally added. See Add Backup Client for details.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> **backupClientId:** The backup client id to remove

> #####Return value
> Returns the relative URI of the REST request for removing a backup client from the server

####RestoreBackup(System.Guid,System.String,System.String)
Restore backup.
> #####Parameters
> **orgId:** The org Id.

> **serverId:** The server Id.

> **backupClientId:** The backup client id restore.

> #####Return value
> An URI.

####ModifyBackupClient(System.Guid,System.String,System.String)
Modifies the settings of an existing Backup Client for a deployed Server. Requires the Organization ID, the Server ID for the server and that the Server already has the Backup service enabled. The user must be the Primary Administrator or a Sub-Administrator with the “backup” role. Note that the Backup Client type cannot be changed.
> #####Parameters
> **orgId:** The organization id

> **serverId:** The server id

> **backupClientId:** The backup client id to modify

> #####Return value
> Returns the relative URI of the REST request for modifying a backup client for the server

####InitiateBackup(System.Guid,System.String,System.String)
Requests an immediate Backup for a Backup Client
> #####Parameters
> **organizationId:** The organization id

> **serverId:** The server id

> **backupClientId:** The backup client id

> #####Return value
> Returns the relative URI of the REST request for initiating a backup on the client

####CancelBackupJobs(System.Guid,System.String,System.String)
Requests a cancellation of all running jobs for a backup client
> #####Parameters
> **organizationId:** The organization id

> **serverId:** The server id

> **backupClientId:** The backup client id

> #####Return value
> Returns the relative URI of the REST request for cancelling backup jobs on the client

####GetOvfPackages(System.Guid)
Gets the relative URI for the CaaS API action that retrieves a list of OVF Packages
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI of the REST request for getting the OVF Packages

####ImportCustomerImage(System.Guid)
Gets the relative URI for the CaaS API action that POST a request to import a customer image
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI of the REST request for importing a customer image

####RemoteOvfPackageCopy(System.Guid)
Gets the relative URI for the CaaS API action that copy an OVF package from a remote geo.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI.

####GetRemoteOvfPackageCopyInProgress(System.Guid)
Gets the relative URI for the CaaS API action to get the OVF package copies in progress.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI.

####GetRemoteOvfPackageCopyHistory(System.Guid,System.Int32)
Gets the relative URI for the CaaS API action to get the OVF package copy history.
> #####Parameters
> **orgId:** The organization id

> **count:** The maximum number of items to return.

> #####Return value
> Returns the relative URI.

####ExportCustomerImage(System.Guid)
Gets the relative URI for the CaaS API action that POST a request to export a customer image
> #####Parameters
> **orgId:** The organization id

> #####Return value
> Returns the relative URI of the REST request for exporting a customer image

####GetCustomerImageImports(System.Guid)
Gets the relative URI for the CaaS API action that retrieves a list of customer image imports in progress.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> A list of customer image imports in progress

####GetCustomerImageExports(System.Guid)
Gets the relative URI for the CaaS API action that retrieves a list of customer image exports in progress.
> #####Parameters
> **orgId:** The organization id

> #####Return value
> A list of customer image exports in progress

####GetCustomerImageExportHistory(System.Guid,System.Int32)
Gets the customer image export history.
> #####Parameters
> **organizationId:** The organization identifier.

> **count:** The number of results to return.

> #####Return value
> The URI for the API.

####CreateOrGetVipRealServers(System.Guid,System.String)
The relative URI for the CaaS API action that list or creates VIP real servers
> #####Parameters
> **orgId:** The org id

> **networkId:** The network id

> #####Return value
> The .

####DeleteVipRealServers(System.Guid,System.String,System.String)
The relative URI for the CaaS API action that deletes VIP real servers
> #####Parameters
> **orgId:** The org id

> **networkId:** The network id

> **rServerId:** The real server id

> #####Return value
> The .

####ModifyVipRealServers(System.Guid,System.String,System.String)
The relative URI for the CaaS API action that deletes VIP real servers
> #####Parameters
> **orgId:** The org id

> **networkId:** The network id

> **rServerId:** The real server id

> #####Return value
> The .

####CreateOrGetVipProbes(System.Guid,System.String)
Creates or get vip probes.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> The new or get vip probes.

####DeleteVipProbes(System.Guid,System.String,System.String)
The relative URI for the CaaS API action that deletes VIP probes.
> #####Parameters
> **orgId:** The org id.

> **networkId:** The network id.

> **probeId:** The probe id.

> #####Return value
> An URI.

####ModifyVipProbes(System.Guid,System.String,System.String)
Modify vip probes.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **probeId:** The probe id.

> #####Return value
> An URI.

####CreateOrGetVipServerFarm(System.Guid,System.String)
Creates or get vip server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> The new or get vip server farm.

####DeleteVipServerFarm(System.Guid,System.String,System.String)
Deletes the vip server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **serverFarmId:** The probe id.

> #####Return value
> An URI.

####GetVipServerFarm(System.Guid,System.String,System.String)
Gets vip server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **serverFarmId:** The probe id.

> #####Return value
> The vip server farm.

####AddVipRealServerToServerFarm(System.Guid,System.String,System.String)
Adds a vip real server to server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **serverFarmId:** The probe id.

> #####Return value
> An URI.

####RemoveVipRealServerFromServerFarm(System.Guid,System.String,System.String)
Removes the vip real server from server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **serverFarmId:** The probe id.

> #####Return value
> An URI.

####AddVipProbeToServerFarm(System.Guid,System.String,System.String)
Adds a vip probe to server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **serverFarmId:** The probe id.

> #####Return value
> An URI.

####RemoveVipProbeFromServerFarm(System.Guid,System.String,System.String)
Removes the vip probe from server farm.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **serverFarmId:** The probe id.

> #####Return value
> An URI.

####CreateOrGetVipPersistenceProfile(System.Guid,System.String)
Creates or get vip persistence profile.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> The new or get vip persistence profile.

####DeleteVipPersistenceProfile(System.Guid,System.String,System.String)
Deletes the vip persistence profile.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **persProfileId:** Identifier for the pers profile.

> #####Return value
> An URI.

####CreateOrGetVip(System.Guid,System.String)
Creates or get vip.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> The new or get vip.

####DeleteVip(System.Guid,System.String,System.String)
Deletes the vip.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **vipId:** The vip id.

> #####Return value
> An URI.

####ModifyVip(System.Guid,System.String,System.String)
Modify vip.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> **vipId:** The vip id.

> #####Return value
> An URI.

####EnableServerMonitoring(System.Guid)
Gets the URL to enable server monitoring
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL

####ChangeServerMonitoringPlan(System.Guid)
Gets the URL to change the server monitoring plan
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL

####DisableServerMonitoring(System.Guid)
Gets the URL to disable server monitoring
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> The URL

####GetMonitoringUsageReport(System.Guid,System.DateTime,System.Nullable{System.DateTime})
Gets the URL to retrieve server monitoring usage report
> #####Parameters
> **orgId:** The org Id.

> **startDate:** The start date.

> **endDate:** The end date.

> #####Return value
> The URL

####AddPublicIpBlock(System.Guid)
Adds a public IP block.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####GetPublicIpBlocks(System.Guid,System.String)
Gets public IP blocks.
> #####Parameters
> **orgId:** The org Id.

> **networkDomainId:** The network Domain Id.

> #####Return value
> The public IP blocks.

####GetPublicIpBlock(System.Guid,System.String)
Gets public IP block.
> #####Parameters
> **orgId:** The org Id.

> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The public IP block.

####GetReservedPublicAddresses(System.Guid,System.String)
Gets reserved public addresses.
> #####Parameters
> **orgId:** The org Id.

> **networkDomainId:** The network Domain Id.

> #####Return value
> The reserved public addresses.

####GetReservedPublicAddressesForNetwork(System.Guid,System.String)
Gets reserved public addresses for network.
> #####Parameters
> **orgId:** The org Id.

> **networkId:** The server networkid.

> #####Return value
> The reserved public addresses for network.

####GetReservedPrivateAddresses(System.Guid,System.String)
Gets reserved private addresses.
> #####Parameters
> **orgId:** The org Id.

> **vlanId:** The VLAN Id.

> #####Return value
> The reserved public addresses.

####DeleteServer(System.Guid)
Deletes the server.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> Returns the relative URI of the REST request for a deletion of the server.

####StartServer(System.Guid)
Starts a server.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####ResetServer(System.Guid)
Resets the server (hard reset).
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####RebootServer(System.Guid)
A "graceful" reboot of the server.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> Returns the relative URI of the REST request for rebooting the server.

####ShutdownServer(System.Guid)
A “graceful” stop of a server by initiating a shutdown sequence within the guest operating system.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> Returns the relative URI of the REST request for a graceful shutdown of the server.

####PowerOffServer(System.Guid)
Power off server.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####UpdateVmwareTools(System.Guid)
Updates the vmware tools described by orgId.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####UpgradeVirtualHardware(System.Guid)
upgrade virtual hardware for the server.
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI.

####GetDomainNatRules(System.Guid,System.String)
Gets all the NAT rules for a specified network.
> #####Parameters
> **orgId:** The organization id.

> **networkDomainId:** The network id.

> #####Return value
> Returns the relative URI of the REST request for getting the NAT rules

####GetNatRule(System.Guid,System.String)
Deletes a NAT Rule.
> #####Parameters
> **orgId:** The organization id.

> **natRuleId:** The NAT Rule id to be deleted.

> #####Return value
> Returns the relative URI of the REST request for getting the NAT rule.

####CreateNatRule(System.Guid)
Creates a NAT Rule on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> Returns the relative URI of the REST request for creating the NAT rule.

####DeleteNatRule(System.Guid)
Deletes a NAT Rule.
> #####Parameters
> **orgId:** The NAT Rule.

> #####Return value
> Returns the relative URI of the REST request for deleting the NAT rule.

####CreatePool(System.Guid)
Returns the relative URI of the REST request for creating the Pool.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetPools(System.Guid)
Returns the relative URI of the REST request for getting the Pools.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetPool(System.Guid,System.Guid)
Returns the relative URI of the REST request for getting the Single Pool details.
> #####Parameters
> **orgId:** The organization id.

> **poolId:** The Pool id.

> #####Return value
> The .

####EditPool(System.Guid)
Returns the relative URI of the REST request for updating the Pool.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeletePool(System.Guid)
Returns the relative URI of the REST request for deleting the Pool.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####AddPoolMember(System.Guid)
Returns the relative URI of the REST request for creating the Pool Member.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetPoolMembers(System.Guid)
Returns the relative URI of the REST request for getting the Pool Members.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetPoolMember(System.Guid,System.Guid)
Returns the relative URI of the REST request for getting the Single Pool Member details.
> #####Parameters
> **orgId:** The organization id.

> **poolMemberId:** The Pool Member id.

> #####Return value
> The .

####EditPoolMember(System.Guid)
Returns the relative URI of the REST request for updating the Pool Member.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeletePoolMember(System.Guid)
Returns the relative URI of the REST request for deleting the Pool Member.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####AddVipNode(System.Guid)
Returns the relative URI of the REST request for creating the VIP Node.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetVipNodes(System.Guid)
Returns the relative URI of the REST request for getting the VIP Nodes.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetVipNode(System.Guid,System.Guid)
Returns the relative URI of the REST request for getting the Single VIP Node details.
> #####Parameters
> **orgId:** The organization id.

> **vipNodeId:** The VIP Node id.

> #####Return value
> The .

####EditVipNode(System.Guid)
Returns the relative URI of the REST request for updating the VIP Node.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeleteVipNode(System.Guid)
Returns the relative URI of the REST request for deleting the VIP Node.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####CreateVirtualListener(System.Guid)
Returns the relative URI of the REST request for creating the Virtual Listener.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetVirtualListeners(System.Guid)
Returns the relative URI of the REST request for getting the Virtual Listeners.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetVirtualListener(System.Guid,System.Guid)
Returns the relative URI of the REST request for getting the Single Virtual Listener details.
> #####Parameters
> **orgId:** The organization id.

> **virtualListenerId:** The Virtual Listener id.

> #####Return value
> The .

####EditVirtualListener(System.Guid)
Returns the relative URI of the REST request for updating the Virtual Listener.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeleteVirtualListener(System.Guid)
Returns the relative URI of the REST request for deleting the Virtual Listener.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetDefaultHealthMonitors(System.Guid,System.Guid)
Returns the get default health monitor URL.
> #####Parameters
> **orgId:** The organization id.

> **networkDomainId:** The network domain id.

> #####Return value
> The .

####GetDefaultPersistenceProfile(System.Guid,System.Guid)
Returns the get default persistence profile URL.
> #####Parameters
> **orgId:** The organization id.

> **networkDomainId:** The network domain id.

> #####Return value
> The .

####GetDefaultIrule(System.Guid,System.Guid)
Returns the get default iRule URL.
> #####Parameters
> **orgId:** The organization id.

> **networkDomainId:** The network domain id.

> #####Return value
> The .

####NotifyPrivateIpChange(System.Guid,System.String)
Returns the relative URI of the REST request for notify private IP address change.
> #####Parameters
> **orgId:** The organization id.

> **serverId:** The Server Id.

> #####Return value
> The .

####RemovePublicIpv4AddressBlock(System.Guid)
Returns the relative URI of the REST request for removing a Public IPv4 Address Block from a Network Domain.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeployMCP20Server(System.Guid)
Deploy server via MCP 2.0 api
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI for the mcp2.0 deploy server api.

####CleanServer(System.Guid)
Clean server via MCP 2.0 api
> #####Parameters
> **orgId:** The org Id.

> #####Return value
> An URI for the mcp2.0 clean server api.

####SummaryUsageReport(System.Guid,System.DateTime,System.DateTime)
Returns the relative URI of the REST request for usage summary.
> #####Parameters
> **orgId:** The organization id.

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The .

####DetailedUsageReport(System.Guid,System.DateTime,System.DateTime)
Returns the relative URI of the REST request for detailed usage.
> #####Parameters
> **orgId:** The organization id.

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The .

####SoftwareUnitsReport(System.Guid,System.DateTime,System.DateTime)
Returns the relative URI of the REST request for software units usage report.
> #####Parameters
> **orgId:** The organization id.

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The .

####BackupUsageReport(System.Guid,System.String,System.DateTime,System.DateTime)
Returns the relative URI of the REST request for backup usage report.
> #####Parameters
> **orgId:** The organization id.

> **datacenterId:** The datacenter Id

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The .

####AdminLogReport(System.Guid,System.DateTime,System.DateTime)
Returns the relative URI of the REST request for administrator logs report.
> #####Parameters
> **orgId:** The organization id.

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The .

####DrsPairsUsageReport(System.Guid,System.DateTime,System.DateTime)
Returns the relative URI of the REST request for DRS Server Pairs usage report.
> #####Parameters
> **orgId:** The organization id.

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The .

####GetMcp2OsImages(System.Guid)
Gets MCP 2 os images.
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> The MCP 2 images.

####GetMcp2OsImage(System.Guid,System.Guid)
Gets MCP 2 os images.
> #####Parameters
> **orgId:** The organization Id.

> **imageId:** The image Id.

> #####Return value
> The MCP 2 images.

####GetMcp2CustomerImages(System.Guid)
Gets MCP 2 customer images.
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> The MCP 2 images.

####GetMcp2CustomerImage(System.Guid,System.Guid)
Gets MCP 2 customer image.
> #####Parameters
> **orgId:** The organization Id.

> **imageId:** The image Id.

> #####Return value
> The MCP 2 images.

####EditMcp2CustomerImageMetadata(System.Guid)
Edit MCP 2 customer image metadata
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> Url endpoint

####GetMcp2OperatingSystems(System.Guid,System.String)
Get MCP 2 operating systems
> #####Parameters
> **orgId:** The organization Id.

> **dataCenterId:** The data center Id.

> #####Return value
> Url endpoint

####CreateSecurityGroup(System.Guid)
Create security group
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> Url endpoint

####EditSecurityGroup(System.Guid)
Edit security group
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> Url endpoint

####DeleteSecurityGroup(System.Guid)
Delete security group
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> Url endpoint

####AddNicToSecurityGroup(System.Guid)
Add nic to security group
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> Url endpoint

####RemoveNicFromSecurityGroup(System.Guid)
Remove Nic from security group
> #####Parameters
> **orgId:** The organization Id.

> #####Return value
> Url endpoint

####GetSecurityGroupForVlan(System.Guid,System.Guid)
Get security group
> #####Parameters
> **orgId:** The organization Id.

> **vlanId:** VLan Id

> #####Return value
> Url endpoint

####GetSecurityGroupForServer(System.Guid,System.Guid)
Get security group
> #####Parameters
> **orgId:** The organization Id.

> **serverId:** Server Id

> #####Return value
> Url endpoint

####ReconfigureServer(System.Guid)
Returns the relative URI of the REST request for reconfiguring the server.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ListofTargetServers(System.Guid,System.Guid,System.String)
Retrieves a list of compatible target Servers for an Out of Place given a specific deployed Server and Backup Client Type as input.
> #####Parameters
> **organizationId:** The organization id

> **serverId:** The server id

> **backupClientType:** The backup client id

> #####Return value
> Returns the relative URI of the REST request for initiating a backup on the client

####TwoFactorAuthenicationStatus(System.Guid)
Returns the relative URI of the REST request for two factor authentication status.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####CreateIpAddressList(System.Guid)
Returns the relative URI of the REST request for create ip address list.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ListIpAddressList(System.Guid,System.Guid)
Returns the relative URI of the REST request for list ip address list.
> #####Parameters
> **orgId:** The organization id.

> **networkDomainId:** The network domain id.

> #####Return value
> The .

####GetIpAddressList(System.Guid,System.Guid)
Returns the relative URI of the REST request for get ip address list.
> #####Parameters
> **orgId:** The organization id.

> **ipAddressListId:** The Ip address list id.

> #####Return value
> The .

####EditIpAddressList(System.Guid)
Returns the relative URI of the REST request for edit ip address list.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeleteIpAddressList(System.Guid)
Returns the relative URI of the REST request for delete ip address list.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####CreatePortList(System.Guid)
Returns the relative URI of the REST request for create port list.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ListPortList(System.Guid,System.Guid)
Returns the relative URI of the REST request for list port list.
> #####Parameters
> **orgId:** The organization id.

> **networkDomainId:** The network domain id.

> #####Return value
> The .

####GetPortList(System.Guid,System.Guid)
Returns the relative URI of the REST request for get port list.
> #####Parameters
> **orgId:** The organization id.

> **portListId:** The Ip address list id.

> #####Return value
> The .

####EditPortList(System.Guid)
Returns the relative URI of the REST request for edit port list.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeletePortList(System.Guid)
Returns the relative URI of the REST request for delete port list.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####AddDisk(System.Guid)
Returns the relative URI of the REST request for adding disk to server.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####RemoveDisk(System.Guid)
Returns the relative URI of the REST request for removing disk from server.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ReservePrivateIpv4Address(System.Guid)
Returns the relative URI of the REST request for reserving private ip v4 address.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####UnreservePrivateIpv4Address(System.Guid)
Returns the relative URI of the REST request for unreserving private ip v4 address.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ReserveIpv6Address(System.Guid)
Returns the relative URI of the REST request for reserving ip v6 address.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetReservedIpv6Addresses(System.Guid)
The get reserved ipv 6 addresses.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####UnreserveIpv6Address(System.Guid)
Returns the relative URI of the REST request for unreserving ip v6 address.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetReservedPrivateIpv4Addresses(System.Guid)
The get reserved private ipv 4 addresses.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####CreateTagKey(System.Guid)
Returns the relative URI of the REST request for create tag key.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ListTagKeys(System.Guid)
Returns the relative URI of the REST request for list tag key.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetTagKey(System.Guid,System.Guid)
Returns the relative URI of the REST request for get tag key.
> #####Parameters
> **orgId:** The organization id.

> **tagKeyId:** The tag key id.

> #####Return value
> The .

####EditTagKey(System.Guid)
Returns the relative URI of the REST request for edit tag key.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeleteTagKey(System.Guid)
Returns the relative URI of the REST request for delete tag key.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ApplyTags(System.Guid)
The apply tags.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####GetTags(System.Guid)
The get tags.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####RemoveTag(System.Guid)
The remove tag.
> #####Parameters
> **orgId:** The org id.

> #####Return value
> The .

####GetConsistencyGroups(System.Guid)
Returns the relative URI of the REST request for get consistency groups.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####CreateConsistencyGroups(System.Guid)
Returns the relative URI of the REST request for create consistency groups.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####GetConsistencyGroupSnapshots(System.Guid)
Returns the relative URI of the REST request for get consistency group snapshots.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####StopPreviewSnapshot(System.Guid)
Returns the relative URI of the REST request for stop preview snapshot of a consistency group.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####StartPreviewSnapshot(System.Guid)
Returns the relative URI of the REST request for start preview snapshot of a consistency group.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####DeleteConsistencyGroup(System.Guid)
Returns the relative URI of the REST request for delete consistency group.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####InitiateFailover(System.Guid)
Returns the relative URI of the REST request for initiate failover for a consistency group.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

####ExpandJournal(System.Guid)
Returns the relative URI of the REST request for expand journal.
> #####Parameters
> **orgId:** The organization id.

> #####Return value
> The .

##CBU.Compute.Api.Client.Exceptions.ApiHostNotFoundException
            
The api host not found exception.
        
###Fields

####message
The message.
###Properties

####Vendor
Gets or sets the vendor.
####Region
Gets or sets the region.
####Message
Gets the message.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **info:** The info.

> **context:** The context.

> #####Exceptions
> **System.ArgumentNullException:** 


####GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Get exception data for serialisation.
> #####Parameters
> **info:** A serialisation data store that will hold the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.Exceptions.ComputeApiWithStatusException
            
The bad request exception.
        
###Properties

####CaaSOperationStatus
Gets or sets the caas operation status. for MCP 1.0 operations
####CaaSOperationResponse
Gets or sets the caas operation response. for MCP 2.0 operations
####CaasRawResponse
Gets or sets the caas operation response. for other operations
####Message
Gets the message.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **error:** Error Type, for older clients

> **caasRawResponse:** The caa operation status.

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **error:** Error Type, for older clients

> **caasOperationStatus:** The caa operation status.

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **error:** Error Type

> **caasOperationResponse:** The caa operation response.

> **uri:** The uri.


####Constructor
Initialises a new instance of the class. Deserialisation constructor for .
> #####Parameters
> **info:** A serialisation data store that holds the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


####GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Get exception data for serialisation.
> #####Parameters
> **info:** A serialisation data store that will hold the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.Exceptions.ComputeApiHttpException
            
The CaaS Internal Server Error.	
        
###Properties

####HttpStatusCode
Http Response Code
####HttpMethod
Http Method
####Response
Http Response
####Message
Gets the message.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **uri:** The uri.

> **httpMethod:** Http Method

> **httpStatusCode:** Http Status Code

> **response:** Http Response


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **uri:** The uri.

> **httpMethod:** Http Method

> **httpRequestException:** Http request exception


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **info:** The info.

> **context:** The context.


####GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Get exception data for serialisation.
> #####Parameters
> **info:** A serialisation data store that will hold the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.Exceptions.InternalServerErrorException
            
The CaaS Internal Server Error.	
        
###Fields

####ErrorMessage
The error message.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **uri:** The uri.

> **response:** Http Response


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **info:** The info.

> **context:** The context.


##CBU.Compute.Api.Client.Exceptions.PermissionDeniedException
            
The CaaS organization not set exception.	
        
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **caasOperationStatus:** CaaS Operation Details

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **caasOperationResponse:** CaaS Operation Details

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **caasRawResponse:** CaaS Operation Details

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **info:** The info.

> **context:** The context.


##CBU.Compute.Api.Client.Exceptions.ComputeApiMethodNotFoundException
            
The bad request exception.
        
###Fields

####ErrorMessage
The error message.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **uri:** The uri.


####Constructor
Initialises a new instance of the class. Deserialisation constructor for .
> #####Parameters
> **info:** A serialisation data store that holds the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.Exceptions.ServiceUnavailableException
            
The bad request exception.
        
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **uri:** The uri.


####Constructor
Initialises a new instance of the class. Deserialisation constructor for .
> #####Parameters
> **info:** A serialisation data store that holds the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.Exceptions.BadRequestException
            
The bad request exception.
        
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **caasOperationStatus:** The caa operation status.

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **caasOperationResponse:** The caa operation response.

> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **rawResponse:** The caas operation raw response.

> **uri:** The uri.


####Constructor
Initialises a new instance of the class. Deserialisation constructor for .
> #####Parameters
> **info:** A serialisation data store that holds the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.Exceptions.InvalidCredentialsException
            
The CaaS organization not set exception.	
        
###Fields

####ErrorMessage
The error message.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **uri:** The uri.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **info:** The info.

> **context:** The context.


##CBU.Compute.Api.Client.Exceptions.CaaSOrganizationNotSetException
            
The caa s organization not set exception.
        
###Fields

####ErrorMessage
The error message.
###Methods


####Constructor
Initialises a new instance of the class.

##CBU.Compute.Api.Client.ComputeApiError
            
Represents the reason that a was raised.
        
###Fields

####Unknown
An unknown reason. Used to detect uninitialised values; do not use directly.
####InvalidCredentials
The CaaS API indicates that the supplied credentials are invalid.
####BadRequest
The CaaS API indicates a bad request and return a descriptive (Status) error
####PermissionDenied
The CaaS API indicates that the supplied credentials are invalid for this org or doesnt have appropriate Role.
####ServiceUnavailable
The CaaS API indicates a service unavailable and return a descriptive (Status) error
####InternalServerError
The CaaS API indicates unhandled internal server error
####ApiMethodNotFoundError
The CaaS API endpoint not found, typically happens during maintenance
####HttpException
The CaaS API indicates unhandled Http

##CBU.Compute.Api.Client.Infrastructure.InfrastructureAccessor
            
The AccountAccessor interface.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetDataCenters(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Infrastructure.DataCenterListOptions)
The get data centers with maintenance statuses.
> #####Parameters
> **pagingOptions:** The paging options.

> **filterOptions:** The Filter options

> #####Return value
> The .

####GetDataCentersPaginated(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Infrastructure.DataCenterListOptions)
The get data centers with maintenance statuses.
> #####Parameters
> **pagingOptions:** The paging options.

> **filterOptions:** The Filter options

> #####Return value
> The .

####GetOperatingSystems(System.String,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Infrastructure.OperatingSystemListOptions)
Get Operating systems supported at the data center level
> #####Parameters
> **dataCenterId:** Data center id

> **pagingOptions:** Paging options

> **filterOptions:** Filtering options

> #####Return value
> Operating Systems

##CBU.Compute.Api.Client.Interfaces.Account.IAccountAccessor
            
The AccountAccessor interface.
        
###Methods


####GetAccounts
The get accounts.
> #####Return value
> The .

####GetAccountsWithPhoneNumber
The get accounts with phone number.
> #####Return value
> The .

####GetAdministratorAccount(System.String)
The get administrator account.
> #####Parameters
> **username:** The username.

> #####Return value
> The .

####AddSubAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
The add sub administrator account.
> #####Parameters
> **account:** The account.

> #####Return value
> The .

####DeleteSubAdministratorAccount(System.String)
The delete sub administrator account.
> #####Parameters
> **username:** The username.

> #####Return value
> The .

####ChangePassword(System.String,System.String)
The update administrator password.
> #####Parameters
> **userName:** The User Name

> **password:** The Password

> #####Return value
> The .

####UpdateAdministratorPhoneNumber(System.String,System.String,System.String)
The update administrator phone number.
> #####Parameters
> **userName:** The User Name

> **phoneCountryCode:** The Phone Country Code

> **phoneNumber:** The Phone Number

> #####Return value
> The .

####UpdateAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
The update administrator account.
> #####Parameters
> **account:** The account.

> #####Return value
> The .

####GetListOfMultiGeographyRegions
The get list of multi geography regions.
> #####Return value
> The .

####GetListOfSoftwareLabels
The get list of software labels.
> #####Return value
> The .

####GetDataCentersWithMaintenanceStatuses(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get data centers with maintenance statuses.
> #####Parameters
> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetDataCenterWithMaintenanceStatus(System.String)
The get data center with maintenance status.
> #####Parameters
> **locationId:** The identifier of the datacenter.

> #####Return value
> The .

####DesignatePrimaryAdministratorAccount(System.String)
The designate primary administrator account.
> #####Parameters
> **username:** The username.

> #####Return value
> The .

####GetTwoFactorAuthenticationStatus
The get two factor authentication status.
> #####Return value
> The .

####SetTwoFactorAuthenticationStatus(DD.CBU.Compute.Api.Contracts.Organization.TwoFactorAuthentication)
The set two factor authentication status.
> #####Parameters
> **status:** The status.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Drs.IConsistencyGroupAccessor
            
The Consistency Group Interface.
        
###Methods


####GetConsistencyGroups(DD.CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupListOptions)
The Get Consistency Group method.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> List of

####GetConsistencyGroupsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The Get Consistency Group menthod.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The pagination options.

> #####Return value
> Paginated result of

####CreateConsistencyGroup(DD.CBU.Compute.Api.Contracts.Drs.CreateConsistencyGroupType)
The Create Consistency Group
> #####Parameters
> **createConsistencyGroup:** The create consistency group type.

> #####Return value
> The

####GetConsistencyGroupSnapshots(DD.CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupSnapshotListOptions)
The Get Consistency Group Snapshots method.
> #####Return value
> List of

####StopPreviewSnapshot(DD.CBU.Compute.Api.Contracts.Drs.StopPreviewSnapshotType)
The stop preview snapshot of a consistency group.
> #####Parameters
> **stopPreviewSnapshotType:** The stop preview snapshot type.

> #####Return value
> The

####StartPreviewSnapshot(DD.CBU.Compute.Api.Contracts.Drs.StartPreviewSnapshotType)
Start preview snapshot of a consistency group.
> #####Parameters
> **startPreviewSnapshotType:** The start preview snapshot type.

> #####Return value
> The

####DeleteConsistencyGroup(DD.CBU.Compute.Api.Contracts.Drs.DeleteConsistencyGroupType)
The Delete Consistency Group method.
> #####Parameters
> **deleteConsistencyGroupType:** The delete consistency group.

> #####Return value
> 

####InitiateFailoverForConsistencyGroup(DD.CBU.Compute.Api.Contracts.Drs.InitiateFailoverType)
The initiate failover for a consistency group.
> #####Parameters
> **InitiateFailover:** The Initiate failover type.

> #####Return value
> The

####ExpandJournal(DD.CBU.Compute.Api.Contracts.Drs.ExpandJournalType)
Expand journal
> #####Parameters
> **expandJournalType:** Expand journal type.

> #####Return value
> The

##CBU.Compute.Api.Client.Interfaces.Infrastructure.IInfrastructureAccessor
            
The AccountAccessor interface.
        
###Methods


####GetDataCenters(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Infrastructure.DataCenterListOptions)
The get data centers with maintenance statuses.
> #####Parameters
> **pagingOptions:** The paging options.

> **filterOptions:** The Filter options

> #####Return value
> The .

####GetDataCentersPaginated(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Infrastructure.DataCenterListOptions)
The get data centers with maintenance statuses.
> #####Parameters
> **pagingOptions:** The paging options.

> **filterOptions:** The Filter options

> #####Return value
> The .

####GetOperatingSystems(System.String,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Infrastructure.OperatingSystemListOptions)
The get os images for a data center
> #####Parameters
> **dataCenterId:** Data center id

> **pagingOptions:** The paging options.

> **filterOptions:** The Filter options

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Backup.IBackupAccessor
            
The BackupAccessor interface.
        
###Methods


####EnableBackup(System.String,DD.CBU.Compute.Api.Contracts.Backup.ServicePlan)
The enable backup.
> #####Parameters
> **serverId:** The server id.

> **plan:** The plan.

> #####Return value
> The .

####DisableBackup(System.String)
The disable backup.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ChangeBackupPlan(System.String,DD.CBU.Compute.Api.Contracts.Backup.ServicePlan)
The change backup plan.
> #####Parameters
> **serverId:** The server id.

> **plan:** The plan.

> #####Return value
> The .

####GetBackupClientTypes(System.String)
The get backup client types.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetBackupStoragePolicies(System.String)
The get backup storage policies.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetBackupSchedulePolicies(System.String)
The get backup schedule policies.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetBackupClients(System.String)
The get backup clients.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####AddBackupClient(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientType,DD.CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy,DD.CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The add backup client.
> #####Parameters
> **serverId:** The server id.

> **clientType:** The client type.

> **storagePolicy:** The storage policy.

> **schedulePolicy:** The schedule policy.

> **alertingType:** The alerting type.

> #####Return value
> The .

####AddBackupClient(System.String,System.String,System.String,System.String,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The add backup client.
> #####Parameters
> **serverId:** The server id.

> **clientType:** The client type.

> **storagePolicy:** The storage policy.

> **schedulePolicy:** The schedule policy.

> **alertingType:** The alerting type.

> #####Return value
> The .

####RemoveBackupClient(System.String,System.String)
The remove backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The backup client id.

> #####Return value
> The .

####RemoveBackupClient(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
The remove backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> #####Return value
> The .

####ModifyBackupClient(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,DD.CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy,DD.CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The modify backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **storagePolicy:** The storage policy.

> **schedulePolicy:** The schedule policy.

> **alertingType:** The alerting type.

> #####Return value
> The .

####ModifyBackupClient(System.String,System.String,System.String,System.String,DD.CBU.Compute.Api.Contracts.Backup.AlertingType)
The modify backup client.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The Backup Client Id.

> **schedulePolicyName:** The Schedule Policy Name

> **alertingType:** The alerting type.

> **storagePolicyName:** The Storage Policy Name

> #####Return value
> The .

####InitiateBackup(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
The initiate backup.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> #####Return value
> The .

####InitiateBackup(System.String,System.String)
The initiate backup.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The backup client id.

> #####Return value
> The .

####CancelBackupJob(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType)
The cancel backup job.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> #####Return value
> The .

####CancelBackupJob(System.String,System.String)
The cancel backup job.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** The backup client id.

> #####Return value
> The .

####InPlaceRestore(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,System.DateTime)
In place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **asAtDate:** The date and time to recover to.

> #####Return value
> A Status message from the API.

####InPlaceRestore(System.String,System.String,System.DateTime)
In place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** Identifier for the backup client.

> **asAtDate:** The date and time to recover to.

> #####Return value
> A Status message from the API.

####OutOfPlaceRestore(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,System.DateTime,DD.CBU.Compute.Api.Contracts.Server.ServerWithBackupType)
Out of place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **asAtDate:** The date and time to recover to.

> **targetServer:** Target server.

> #####Return value
> A Status message from the API;

####OutOfPlaceRestore(System.String,System.String,System.DateTime,System.String)
Out of place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClientId:** Identifier for the backup client.

> **asAtDate:** The date and time to recover to.

> **targetServerId:** Identifier for the target client.

> #####Return value
> A Status message from the API;

####OutOfPlaceRestore(System.String,DD.CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType,System.DateTime,DD.CBU.Compute.Api.Contracts.Network20.ServerType)
Out of place restore.
> #####Parameters
> **serverId:** The server id.

> **backupClient:** The backup client.

> **asAtDate:** The date and time to recover to.

> **targetServer:** Target server.

> #####Return value
> A Status message from the API;

####GetSystemRestoreTargets(System.Guid,System.String)
Retrieves a list of compatible target Servers for an Out of Place given a specific deployed Server and Backup Client Type as input.
> #####Parameters
> **serverId:** 

> **backupClientType:** 

> #####Return value
> 

##CBU.Compute.Api.Client.Interfaces.IDeprecatedComputeApiClient
            
The interface of the CaaS API Client
        
###Methods


####LoginAsync(System.Net.ICredentials)
The login async.
> #####Parameters
> **accountCredentials:** The account credentials.

> #####Return value
> The .

####GetListOfSoftwareLabels
Gets a list of software labels.
> #####Return value
> The .

####GetListOfMultiGeographyRegions
Gets a list of multi geography regions
> #####Return value
> The .

####DeleteSubAdministratorAccount(System.String)
Deletes a sub administrator account
> #####Parameters
> **username:** The username

> #####Return value
> The .

####GetAdministratorAccount(System.String)
Get a (sub) administrator account
> #####Parameters
> **username:** The username

> #####Return value
> The .

####DesignatePrimaryAdministratorAccount(System.String)
Designate a primary administrator account
> #####Parameters
> **username:** The username

> #####Return value
> The .

####GetDataCentersWithMaintenanceStatuses
Gets all the data centres for the organisation.
> #####Return value
> The data centres.

####GetAccounts
Gets the account of the organisation.
> #####Return value
> The .

####AddSubAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
Adds a sub administrator account
> #####Parameters
> **account:** The account

> #####Return value
> The .

####UpdateAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
Updates an administrator account
> #####Parameters
> **account:** The account

> #####Return value
> The .

####GetAvailableDataCenters
Gets available data centres
> #####Return value
> The .

####GetImages(System.String)
Gets the OS images at a particular location.
> #####Parameters
> **locationName:** The location.

> #####Return value
> The .

####GetImages(System.String,System.String,System.String,System.String,System.String)
Get OS server images
> #####Parameters
> **imageId:** The imageId filter

> **name:** The name filter

> **location:** The location filter

> **operatingSystemId:** The OS id

> **operatingSystemFamily:** The OS family

> #####Return value
> The .

####GetCustomerServerImages(System.String)
Gets the deployed customer server images.
> #####Parameters
> **networkLocation:** The location.

> #####Return value
> The .

####GetCustomerServerImages(System.String,System.String,System.String,System.String,System.String)
Get customer server images
> #####Parameters
> **imageId:** The imageId filter

> **name:** The name filter

> **location:** The location filter

> **operatingSystemId:** The OS id

> **operatingSystemFamily:** The OS family

> #####Return value
> The .

####RemoveCustomerServerImage(System.String)
Remove customer images
> #####Parameters
> **imageid:** The image id

> #####Return value
> The .

####DeployServerImageTask(System.String,System.String,System.String,System.String,System.String,System.Boolean)
Deploy a server using an image in a specified network.
> #####Parameters
> **name:** The name of the new server.

> **description:** The description of the new server.

> **networkId:** The network id to deploy the server.

> **imageId:** The image id to deploy the server.

> **adminPassword:** The administrator password.

> **isStarted:** Will the server powers on after deployment?

> #####Return value
> The status of the deployment.

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,Disk[])
Deploy a server using an image in a specified network.
> #####Parameters
> **name:** The name of the new server.

> **description:** The description of the new server.

> **networkId:** The network id to deploy the server.

> **privateIp:** The privateIp address to deploy the server.

> **imageId:** The image id to deploy the server.

> **adminPassword:** The administrator password.

> **start:** Will the server powers on after deployment?

> **disk:** Array od disk configurations

> #####Return value
> The status of the deployment.

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean)
Deploy a server using an image in a specified network.
> #####Parameters
> **name:** The name of the new server.

> **description:** The description of the new server.

> **networkId:** The network id to deploy the server.

> **privateIp:** The network id or privateIp address to deploy the server.

> **imageId:** The image id to deploy the server.

> **adminPassword:** The administrator password.

> **start:** Will the server powers on after deployment?

> #####Return value
> The status of the deployment.

####ModifyServer(System.String,System.String,System.String,System.Int32,System.Int32,System.String)
The modify server.
> #####Parameters
> **serverId:** The server id.

> **name:** The name.

> **description:** The description.

> **memory:** The memory.

> **cpucount:** The CPU count.

> **privateIp:** The private IP.

> #####Return value
> The .

####ServerPowerOn(System.String)
Powers on the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerPowerOff(System.String)
Powers off the server.
> #####Parameters
> **serverId:** Server Id

> #####Return value
> The .

####ServerRestart(System.String)
Restart the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerReset(System.String)
Power cycles an existing deployed server. This is the equivalent of pulling and replacing the power cord for a physical server. Requires your organization ID and the ID of the target server..
> #####Parameters
> **serverId:** The server id.

> #####Return value
> Returns a status of the HTTP request

####ServerShutdown(System.String)
Shutdown the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ChangeServerDiskSize(System.String,System.String,System.String)
Modify server disk size.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> **sizeInGb:** Size In GB.

> #####Return value
> The status of the deployment.

####ChangeServerDiskSpeed(System.String,System.String,System.String)
Modify server disk speed.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> **speedId:** Size in GB.

> #####Return value
> The status of the deployment.

####AddServerDisk(System.String,System.String,System.String)
Add Disk to Server
> #####Parameters
> **serverId:** The server id

> **size:** The size of the new disk

> **speedId:** The speed Id.

> #####Return value
> The .

####RemoveServerDisk(System.String,System.String)
Modify server server settings.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> #####Return value
> The status of the deployment.

####ServerUpdateVMwareTools(System.String)
Triggers an update of the VMWare Tools software running on the guest OS of a virtual server
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerDelete(System.String)
Delete the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerCloneToCustomerImage(System.String,System.String,System.String)
Initiates a clone of a server to create a Customer Image
> #####Parameters
> **serverId:** The server id.

> **imageName:** The customer image name.

> **imageDesc:** The customer image description.

> #####Return value
> The .

####GetDeployedServers
Gets the deployed servers.
> #####Return value
> The .

####GetDeployedServers(System.String,System.String,System.String,System.String)
Gets a filtered list of deployed servers.
> #####Parameters
> **serverid:** The server Id.

> **name:** The name.

> **networkId:** The network Id.

> **location:** The location.

> #####Return value
> The .

####CreateServerAntiAffinityRule(System.String,System.String)
Creates a new Server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **serverId1:** The server Id for the 1'st server

> **serverId2:** The server Id for the 2'nd server

> #####Return value
> The .

####GetServerAntiAffinityRules(System.String,System.String,System.String)
List all Server Anti-Affinity Rules
> #####Parameters
> **ruleId:** Filter by rule Id

> **location:** Filter by location

> **networkId:** Filter by network Id

> #####Return value
> The .

####RemoveServerAntiAffinityRule(System.String)
Remove a server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **ruleId:** The ruleId

> #####Return value
> The .

####DiscoverHomeMultiGeo(DD.CBU.Compute.Api.Client.KnownApiVendor,System.Net.ICredentials)
Since MultiGeo call is only valid for the home geo, use this method to discover what is your home geo and the applicable regions for this user. This is a multithreaded call that uses the underlying ComputeApiClient.GetListOfMultiGeographyRegions() to discover the home geo and multi geo for this user to all API endpoints known for vendor. Note: Most of the user vendor is DimensionData. Use this if you have to guess which vendor the user is under.
> #####Parameters
> **vendor:** The vendor of the user

> **credential:** Credential of the user

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Network20.IIpAddressAccessor
            
IP Address Management functions.
        
###Methods


####AddPublicIpBlock(System.Guid)
Adds a public IP block.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> #####Return value
> The job from the API;

####GetPublicIpBlocks(System.Guid)
Gets public IP blocks.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> #####Return value
> The public IP blocks.

####GetPublicIpBlocksPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Network20.PublicIpListOptions)
Gets public IP blocks.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **pagingOptions:** The paging options, null means default.

> **options:** Filtering options

> #####Return value
> The public IP blocks.

####GetPublicIpBlock(System.Guid)
Gets public IP block.
> #####Parameters
> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The public IP block.

####GetPublicIpBlock(System.Guid,System.Guid)
Gets public IP block.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The public IP block.

####GetReservedPublicAddressesForNetworkDomain(System.Guid)
Gets reserved public addresses.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> #####Return value
> The reserved public addresses.

####GetReservedPublicAddressesForNetwork(System.Guid)
Gets reserved public addresses for network.
> #####Parameters
> **networkId:** Identifier for the network.

> #####Return value
> The reserved public addresses for network.

####GetReservedPublicAddressesForNetworkDomainPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedPublicIpv4ListOptions)
Gets reserved public IP addresses for a network domain.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **pagingOptions:** The paging options, null means default.

> **filterOptions:** Filtering option

> #####Return value
> The reserved public addresses.

####GetReservedPrivateAddressesForVlan(System.Guid)
Gets reserved private addresses.
> #####Parameters
> **vlanId:** The VLAN Id.

> #####Return value
> The reserved private addresses.

####GetReservedPrivateAddressesForVlanPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets reserved private addresses.
> #####Parameters
> **vlanId:** The VLAN Id.

> **pagingOptions:** The paging options, null means default.

> #####Return value
> The reserved private addresses.

####DeletePublicIpBlock(System.Guid,System.Guid)
Deletes the public IP block.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The job from the API;

####GetReservedPrivateIpv4Addresses(DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedPrivateIpv4ListOptions)
The get reserved private ipv 4 addresses.
> #####Parameters
> **reservedPrivateIpv4ListOptions:** The reserved private ipv 4 list options.

> #####Return value
> The .

####GetReservedPrivateIpv4AddressesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedPrivateIpv4ListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved private ipv 4 addresses paginated.
> #####Parameters
> **reservedPrivateIpv4ListOptions:** The reserved private ipv 4 list options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####ReservePrivateIpv4Address(DD.CBU.Compute.Api.Contracts.Network20.ReservePrivateIpv4AddressType)
The reserve private ipv 4 address.
> #####Parameters
> **reservePrivateIpv4Address:** The reserve private ipv 4 address.

> #####Return value
> The .

####UnreservePrivateIpv4Address(DD.CBU.Compute.Api.Contracts.Network20.UnreservePrivateIpv4AddressType)
The unreserve private ipv 4 address.
> #####Parameters
> **unReservePrivateIpv4Address:** The un reserve private ipv 4 address.

> #####Return value
> The .

####ReserveIpv6Address(DD.CBU.Compute.Api.Contracts.Network20.ReserveIpv6AddressType)
The reserve ipv 6 address.
> #####Parameters
> **reserveIpv6Address:** The reserve ipv 6 address.

> #####Return value
> The .

####UnreserveIpv6Address(DD.CBU.Compute.Api.Contracts.Network20.UnreserveIpv6AddressType)
The unreserve ipv 6 address.
> #####Parameters
> **unreserveIpv6Address:** The unreserve ipv 6 address.

> #####Return value
> The .

####GetReservedIpv6Addresses
The get reserved ipv 6 addresses.
> #####Return value
> The .

####GetReservedIpv6Addresses(System.Guid)
The get reserved ipv 6 addresses.
> #####Parameters
> **vlanId:** The vlan id.

> #####Return value
> The .

####GetReservedIpv6Addresses(System.String)
The get reserved ipv 6 addresses.
> #####Parameters
> **ipAddress:** The ip address.

> #####Return value
> The .

####GetReservedIpv6AddressesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedIpv6ListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved ipv 6 addresses paginated.
> #####Parameters
> **reservedIpv6ListOptions:** The reserved ipv 6 list options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetReservedIpv6AddressesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved ipv 6 addresses paginated.
> #####Parameters
> **vlanId:** The vlan id.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetReservedIpv6AddressesPaginated(System.String,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved ipv 6 addresses paginated.
> #####Parameters
> **ipAddress:** The ip address.

> **pagingOptions:** The paging options.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Network20.INatAccessor
            
The Network Address Translation Management interface.
        
###Methods


####GetNatRules(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.NatRuleListOptions)
Retrieves the list of the NAT Rules on a particular Network Domain at an MCP 2.0 data center This API requires your organization ID and the ID of the target network.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **options:** Options for filtering the operations.

> #####Return value
> 

####GetNatRulesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.NatRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves the list of the NAT Rules on a particular Network Domain at an MCP 2.0 data center This API requires your organization ID and the ID of the target network.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **options:** Options for filtering the operations.

> **pagingOptions:** The paging options, null means default.

> #####Return value
> The NAT Rule collection.

####CreateNatRule(DD.CBU.Compute.Api.Contracts.Network20.createNatRule)
Creates a NAT Rule on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **natRule:** The NAT Rule.

> #####Return value
> Operation status

####GetNatRule(System.Guid)
Returns details of a single NAT Rule.
> #####Parameters
> **natRuleId:** The NAT Rule id.

> #####Return value
> The NAt Rule.

####DeleteNatRule(System.Guid)
Deletes a NAT Rule.
> #####Parameters
> **natRuleId:** The id of the VLAN.

> #####Return value
> The job from the API;

##CBU.Compute.Api.Client.Interfaces.Network20.IVipSupportAccessor
            
The VIP support interface.
        
###Methods


####GetDefaultHealthMonitors(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultHealthMonitorListOptions)
Retrieves default health monitors.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> #####Return value
> The async task of collection of

####GetDefaultHealthMonitorsPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultHealthMonitorListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves default health monitors.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> **pagingOptions:** The paging options

> #####Return value
> The async task of

####GetDefaultPersistenceProfiles(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultPersistenceProfileListOptions)
Retrieves default persistence profiles.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> #####Return value
> The async task of collection of

####GetDefaultPersistenceProfilesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultPersistenceProfileListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves default persistence profiles.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> **pagingOptions:** The paging options

> #####Return value
> The async task of

####GetDefaultIrules(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultIruleListOptions)
Retrieves default iRules.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> #####Return value
> The async task of collection of

####GetDefaultIrulesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultIruleListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves default iRules.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> **pagingOptions:** The paging options

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Interfaces.Network20.IVipVirtualListenerAccessor
            
The VIP Virtual Listener Management interface.
        
###Methods


####CreateVirtualListener(DD.CBU.Compute.Api.Contracts.Network20.createVirtualListener)
Creates a VirtualListener on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **virtualListener:** The create virtual listener.

> #####Return value
> The async task of

####GetVirtualListeners(DD.CBU.Compute.Api.Contracts.Requests.Network20.VirtualListenerListOptions)
Retrieves all of the VirtualListeners on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of collection of

####GetVirtualListenersPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.VirtualListenerListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves all of the VirtualListeners on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> **pagingOptions:** The paging Options.

> #####Return value
> The async task of

####GetVirtualListener(System.Guid)
Returns details of a single VirtualListener.
> #####Parameters
> **virtualListenerId:** The VirtualListener id.

> #####Return value
> The async task of

####EditVirtualListener(DD.CBU.Compute.Api.Contracts.Network20.editVirtualListener)
Updates the mutable properties of a VirtualListener.
> #####Parameters
> **virtualListener:** The edit virtualListener.

> #####Return value
> The async task of

####DeleteVirtualListener(System.Guid)
Deletes a VirtualListener.
> #####Parameters
> **virtualListenerId:** The VirtualListener id.

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Interfaces.Network20.IVipNodeAccessor
            
The VIP Node Management interface.
        
###Methods


####CreateNode(DD.CBU.Compute.Api.Contracts.Network20.CreateNodeType)
Creates a Node on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **node:** The create node.

> #####Return value
> The async task of

####GetNodes(DD.CBU.Compute.Api.Contracts.Requests.Network20.NodeListOptions)
Retrieves all of the Nodes on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of collection of

####GetNodesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.NodeListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves all of the Nodes on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> **pagingOptions:** The paging Options.

> #####Return value
> The async task of

####GetNode(System.Guid)
Returns details of a single Node.
> #####Parameters
> **nodeId:** The Node id.

> #####Return value
> The async task of

####EditNode(DD.CBU.Compute.Api.Contracts.Network20.EditNodeType)
Updates the mutable properties of a Node.
> #####Parameters
> **node:** The edit node.

> #####Return value
> The async task of

####DeleteNode(System.Guid)
Deletes a Node.
> #####Parameters
> **nodeId:** The Node id.

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Interfaces.Network20.IFirewallRuleAccessor
            
The Firewall Rule Accessor interface.
        
###Methods


####GetFirewallRules(DD.CBU.Compute.Api.Contracts.Requests.Network20.FirewallRuleListOptions)
Lists all firewall rules.
> #####Parameters
> **options:** The filter options.

> #####Return value
> The collection of matching firewall rules.

####GetFirewallRulesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.FirewallRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Lists all firewall rules.
> #####Parameters
> **options:** The filter options.

> **pagingOptions:** The paging options.

> #####Return value
> The async task of

####GetFirewallRule(System.Guid)
Gets a specific firewall rule.
> #####Parameters
> **firewallRuleId:** The firewall rule identifier.

> #####Return value
> The response details.

####CreateFirewallRule(DD.CBU.Compute.Api.Contracts.Network20.CreateFirewallRuleType)
Creates a firewall rule.
> #####Parameters
> **createFirewallRule:** The firewall rule details.

> #####Return value
> The response details.

####EditFirewallRule(DD.CBU.Compute.Api.Contracts.Network20.EditFirewallRuleType)
Edits a firewall rule.
> #####Parameters
> **editFirewallRule:** The firewall rule details.

> #####Return value
> The response details.

####DeleteFirewallRule(System.Guid)
Deletes a firewall rule.
> #####Parameters
> **firewallRuleId:** The firewall rule identifier.

> #####Return value
> The response details.

####CreateIpAddressList(DD.CBU.Compute.Api.Contracts.Network20.createIpAddressList)
Creates an ip address list.
> #####Parameters
> **createIpAddressList:** The ip address list details.

> #####Return value
> The response details.

####GetIpAddressLists(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.IpAddressListOptions)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The network domain id.

> **options:** The filter options.

> #####Return value
> The collection of matching ip address list.

####GetIpAddressListsPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.IpAddressListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The Network domain id.

> **options:** The filter options.

> **pagingOptions:** The paging options.

> #####Return value
> The async task of

####GetIpAddressList(System.Guid)
Gets the ip address list.
> #####Parameters
> **ipAddressListId:** The ip address list id.

> #####Return value
> The collection of matching ip address list.

####EditIpAddressList(DD.CBU.Compute.Api.Contracts.Network20.editIpAddressList)
Edits an ip address list.
> #####Parameters
> **editIpAddressList:** The ip address list details.

> #####Return value
> The response details.

####DeleteIpAddressList(DD.CBU.Compute.Api.Contracts.Network20.deleteIpAddressList)
Deletes an ip address list.
> #####Parameters
> **deleteIpAddressList:** The ip address list id to be deleted.

> #####Return value
> The response details.

####CreatePortList(DD.CBU.Compute.Api.Contracts.Network20.createPortList)
Creates an ip address list.
> #####Parameters
> **createPortList:** The ip address list details.

> #####Return value
> The response details.

####GetPortLists(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.PortListOptions)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The network domain id.

> **options:** The filter options.

> #####Return value
> The collection of matching ip address list.

####GetPortListsPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.PortListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The Network domain id.

> **options:** The filter options.

> **pagingOptions:** The paging options.

> #####Return value
> The async task of

####GetPortList(System.Guid)
Gets the ip address list.
> #####Parameters
> **portListId:** The ip address list id.

> #####Return value
> The collection of matching ip address list.

####EditPortList(DD.CBU.Compute.Api.Contracts.Network20.editPortList)
Edits an ip address list.
> #####Parameters
> **editPortList:** The ip address list details.

> #####Return value
> The response details.

####DeletePortList(DD.CBU.Compute.Api.Contracts.Network20.DeletePortListType)
Deletes an ip address list.
> #####Parameters
> **deletePortList:** The ip address list id to be deleted.

> #####Return value
> The response details.

##CBU.Compute.Api.Client.Interfaces.Network20.IVlanSecurityGroupAccessor
            
The VlanAccessor interface.
        
###Methods


####CreateSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.createSecurityGroup)
Create Security Group
> #####Parameters
> **securityGroup:** Details regarding the security group

> #####Return value
> Response Data

####EditSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.editSecurityGroup)
Edit Security Group
> #####Parameters
> **securityGroup:** Details regarding the security group

> #####Return value
> Response Data

####DeleteSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.DeleteSecurityGroup)
Delete Security Group
> #####Parameters
> **securityGroup:** Details regarding the security group

> #####Return value
> Response Data

####GetSecurityGroupsPaged(System.Nullable{System.Guid},System.Nullable{System.Guid},DD.CBU.Compute.Api.Contracts.Requests.PageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Network20.SecurityGroupListOptions)
Get the list of security groups associated with either the server or the vlan
> #####Parameters
> **vlanId:** Security group associated with the vlan

> **serverId:** Groups associated with the Nics on the server, only provide wither vlan or serverid

> **pagingOptions:** Paging options

> **filterOptions:** Filter Options

> #####Return value
> 

####AddNicToSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.addNicToSecurityGroup)
Add Nic to Security Group
> #####Parameters
> **nicSecurityGroup:** Details regarding the security group and the nic

> #####Return value
> Response Data

####RemoveNicFromSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.removeNicFromSecurityGroup)
Remove Nic from Security Group
> #####Parameters
> **nicSecurityGroup:** Details regarding the security group and the nic

> #####Return value
> Response Data

##CBU.Compute.Api.Client.Interfaces.Network20.INetworkDomainAccessor
            
The NetworkDomain interface.
        
###Methods


####GetNetworkDomains(DD.CBU.Compute.Api.Contracts.Requests.Network20.NetworkDomainListOptions)
The get network domains.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> The .

####GetNetworkDomainsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.NetworkDomainListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The get network domains.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetNetworkDomain(System.Guid)
This function gets a network domain from Cloud.
> #####Parameters
> **networkDomainId:** Network domain id.

> #####Return value
> The network domain with the supplied id.

####GetNetworkDomain(System.String)
This function gets a network domain from Cloud.
> #####Parameters
> **networkDomainName:** The network domain name.

> #####Return value
> The network domain with the supplid name.

####DeployNetworkDomain(DD.CBU.Compute.Api.Contracts.Network20.DeployNetworkDomainType)
This function deploys a new network domains to Cloud
> #####Parameters
> **networkDomain:** The network Domain.

> #####Return value
> Response containing status.

####ModifyNetworkDomain(DD.CBU.Compute.Api.Contracts.Network20.EditNetworkDomainType)
The modify network domain.
> #####Parameters
> **networkDomain:** The network domain.

> #####Return value
> The .

####DeleteNetworkDomain(System.Guid)
Delete the network domain.
> #####Parameters
> **id:** The identifier of the network domain.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Network20.IVipPoolAccessor
            
The NetworkDomainVip interface.
        
###Methods


####CreatePool(DD.CBU.Compute.Api.Contracts.Network20.createPool)
Creates a Pool on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **pool:** The create pool.

> #####Return value
> The async task of

####GetPools(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolListOptions)
Retrieves all of the Pools on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of collection of

####GetPoolsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves all of the Pools on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> **pagingOptions:** The paging Options.

> #####Return value
> The async task of

####GetPool(System.Guid)
Returns details of a single Pool.
> #####Parameters
> **poolId:** The Pool id.

> #####Return value
> The async task of

####EditPool(DD.CBU.Compute.Api.Contracts.Network20.EditPoolType)
Updates the mutable properties of a Pool.
> #####Parameters
> **pool:** The edit pool.

> #####Return value
> The async task of

####DeletePool(System.Guid)
Deletes a Pool.
> #####Parameters
> **poolId:** The Pool id.

> #####Return value
> The async task of

####AddPoolMember(DD.CBU.Compute.Api.Contracts.Network20.addPoolMember)
Adds a Node, combined with Port information to the identified Pool as a new Pool Member.
> #####Parameters
> **poolMember:** The Pool Member

> #####Return value
> The async task of

####GetPoolMembers(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolMemberListOptions)
Retrieves the Pool Members on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of a collection of

####GetPoolMembersPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolMemberListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves the Pool Members on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options.

> **pagingOptions:** The Paging options.

> #####Return value
> The async task of

####GetPoolMember(System.Guid)
Returns details of a single Pool Member.
> #####Parameters
> **poolMemberId:** The Pool Member id.

> #####Return value
> The async task of

####EditPoolMember(DD.CBU.Compute.Api.Contracts.Network20.editPoolMember)
Updates the status of a Pool Member.
> #####Parameters
> **poolMember:** The edit pool member.

> #####Return value
> The async task of

####RemovePoolMember(System.Guid)
Removes a Pool Member.
> #####Parameters
> **poolMemberId:** The Pool Member id.

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Interfaces.Network20.INetworkingAccessor
            
Interface for networking 2.0 API.
        
###Properties

####NetworkDomain
Gets the Network Domain Accessor
####Vlan
Gets the VLAN Accessor
####SecurityGroup
Gets the Vlan Security Group Accessor
####IpAddress
Gets the IP address Accessor.
####Nat
Gets the NAT Rule Accessor.
####FirewallRule
Gets the Firewall Rule Accessor.
####VipSupport
Gets the VIP Support Accessor.
####VipPool
Gets the VIP Pool Accessor.
####VipNode
Gets the VIP Node Accessor.
####VipVirtualListener
Gets the VIP Virtual Listener Accessor.

##CBU.Compute.Api.Client.Interfaces.Network20.IVlanAccessor
            
The VlanAccessor interface.
        
###Methods


####GetVlans(DD.CBU.Compute.Api.Contracts.Requests.Network20.VlanListOptions)
Retrieves the list of ACL rules associated with a network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **options:** Options for controlling the operation.

> #####Return value
> The VLAN collection.

####GetVlansPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.VlanListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves the list of ACL rules associated with a network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **options:** Options for controlling the operation.

> **pagingOptions:** Options for controlling the paging.

> #####Return value
> The VLAN collection.

####GetVlans(System.Guid,System.String,System.Guid,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The get VLAN list.
> #####Parameters
> **id:** The id.

> **vlanName:** The VLAN name.

> **networkDomainId:** The network domain id.

> **pagingOptions:** The paging Options.

> #####Return value
> The .

####GetVlan(System.Guid)
An IComputeApiClient extension method that gets a VLAN.
> #####Parameters
> **vlanId:** The id.

> #####Return value
> The vlan.

####DeployVlan(DD.CBU.Compute.Api.Contracts.Network20.DeployVlanType)
Deploys Virtual LAN on a network domain
> #####Parameters
> **vlan:** Virtual LAN

> #####Return value
> Operation status

####EditVlan(DD.CBU.Compute.Api.Contracts.Network20.EditVlanType)
Edit Virtual LAN on a network domain.
> #####Parameters
> **editVlan:** Edit Virtual LAN request.

> #####Return value
> Operation status

####ExpandVlan(DD.CBU.Compute.Api.Contracts.Network20.ExpandVlanType)
Expand Virtual LAN on a network domain.
> #####Parameters
> **expandVlan:** Expand Virtual LAN request.

> #####Return value
> Operation status

####DeleteVlan(System.Guid)
Delete a Virtual LAN
> #####Parameters
> **id:** The id of the VLAN.

> #####Return value
> Operation status

##CBU.Compute.Api.Client.Interfaces.Network.INetworkAccessor
            
The Network interface.
        
###Methods


####CreateNetwork(System.String,System.String,System.String)
The create network.
> #####Parameters
> **networkName:** The network name.

> **dataCentreLocation:** The data centre location.

> **description:** The description.

> #####Return value
> The .

####GetNetworks
The get networks task.
> #####Return value
> The .

####GetNetworks(System.String)
The get networks task.
> #####Parameters
> **locationId:** The identifier of the location to get the networks from.

> #####Return value
> The .

####DeleteNetwork(System.String)
The delete network.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####ModifyNetwork(System.String,System.String,System.String)
The modify network.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **description:** The description.

> #####Return value
> The .

####GetNetworkConfig(System.String)
The get network config.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####GetNatRules(System.String)
The get nat rules.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####DeleteNatRule(System.String,System.String)
The delete nat rule.
> #####Parameters
> **networkId:** The network id.

> **natRuleId:** The nat rule id.

> #####Return value
> The .

####CreateNatRule(System.String,System.String,System.Net.IPAddress)
The create nat rule.
> #####Parameters
> **networkId:** The network id.

> **natRuleName:** The nat rule name.

> **sourceIp:** The source ip.

> #####Return value
> The .

####CreateAclRule(System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Network.AclActionType,DD.CBU.Compute.Api.Contracts.Network.AclProtocolType,DD.CBU.Compute.Api.Contracts.Network.PortRangeTypeType,System.Net.IPAddress,System.Net.IPAddress,System.Net.IPAddress,System.Net.IPAddress,System.Int32,System.Int32,DD.CBU.Compute.Api.Contracts.Network.AclType)
The create acl rule.
> #####Parameters
> **networkId:** The network id.

> **aclRuleName:** The acl rule name.

> **position:** The position.

> **action:** The action.

> **protocol:** The protocol.

> **portRangeType:** The port range type.

> **sourceIpAddress:** The source ip address.

> **sourceNetmask:** The source netmask.

> **destIpAddress:** The dest ip address.

> **destNetmask:** The dest netmask.

> **port1:** The port 1.

> **port2:** The port 2.

> **aclType:** The acl type.

> #####Return value
> The .

####GetAclRules(System.String)
The get acl rules.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####DeleteAclRule(System.String,System.String)
The delete acl rule.
> #####Parameters
> **networkId:** The network id.

> **aclRuleId:** The acl rule id.

> #####Return value
> The .

####ReserveNetworkPublicIpAddressBlock(System.String)
The reserve network public ip address block.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####ReleaseNetworkPublicIpAddressBlock(System.String,System.String)
The release network public ip address block.
> #####Parameters
> **networkId:** The network id.

> **ipBlockId:** The ip block id.

> #####Return value
> The .

####GetNetworkPublicIpAddressBlock(System.String)
The get network public ip address block.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####SetServertoVipNetworkPublicIpAddressBlock(System.String,System.String,System.Boolean)
The set serverto vip network public ip address block.
> #####Parameters
> **networkId:** The network id.

> **ipBlockId:** The ip block id.

> **enable:** The enable.

> #####Return value
> The .

####SetNetworkMulticast(System.String,System.Boolean)
The set network multicast.
> #####Parameters
> **networkId:** The network id.

> **enable:** The enable.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Network.INetworkingLegacyAccessor
            
The NetworkingLegacy interface.
        
###Properties

####Network
Gets the network.
####NetworkVip
Gets the network vip.

##CBU.Compute.Api.Client.Interfaces.Network.INetworkVipAccessor
            
The Vip interface.
        
###Methods


####GetRealServers(System.String)
The get real servers.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreateRealServer(System.String,System.String,System.String,System.Boolean)
The create real server.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **serverId:** The server id.

> **inService:** The in service.

> #####Return value
> The .

####RemoveRealServer(System.String,System.String)
The remove real server.
> #####Parameters
> **networkId:** The network id.

> **realServerId:** The r server id.

> #####Return value
> The .

####ModifyRealServer(System.String,System.String,System.Boolean)
The modify real server.
> #####Parameters
> **networkId:** The network id.

> **realServerId:** The r server id.

> **inService:** The in service.

> #####Return value
> The .

####GetProbes(System.String)
The get probes.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreateProbe(System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ProbeType,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.ProbeRequestMethod,System.String,System.String)
The create probe.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **type:** The type.

> **port:** The port.

> **probeIntervalSeconds:** The probe interval seconds.

> **errorCountBeforeServerFail:** The error count before server fail.

> **successCountBeforeServerEnable:** The success count before server enable.

> **failedProbeIntervalSeconds:** The failed probe interval seconds.

> **maxReplyWaitSeconds:** The max reply wait seconds.

> **statusCodeLowerBound:** The status code lower bound.

> **statusCodeUpperBound:** The status code upper bound.

> **requestMethod:** The request method.

> **requestUrl:** The request url.

> **matchContent:** The match content.

> #####Return value
> The .

####ModifyProbe(System.String,System.String,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
The modify probe.
> #####Parameters
> **networkId:** The network id.

> **probeId:** The probe id.

> **probeIntervalSeconds:** The probe interval seconds.

> **errorCountBeforeServerFail:** The error count before server fail.

> **successCountBeforeServerEnable:** The success count before server enable.

> **failedProbeIntervalSeconds:** The failed probe interval seconds.

> **maxReplyWaitSeconds:** The max reply wait seconds.

> #####Return value
> The .

####RemoveProbe(System.String,System.String)
The remove probe.
> #####Parameters
> **networkId:** The network id.

> **probeId:** The probe id.

> #####Return value
> The .

####GetServerFarms(System.String)
The get server farms.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####GetServerFarmDetails(System.String,System.String)
The get server farm details.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> #####Return value
> The .

####CreateServerFarm(System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ServerFarmPredictorType,System.String,System.Int32,System.String)
The create server farm.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **predictor:** The predictor.

> **realServerId:** The r server id.

> **rServerPort:** The r server port.

> **probeId:** The probe id.

> #####Return value
> The .

####RemoveServerFarm(System.String,System.String)
The remove server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> #####Return value
> The .

####ModifyServerFarm(System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ServerFarmPredictorType)
The modify server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **predictor:** The predictor.

> #####Return value
> The .

####AddRealServerToServerFarm(System.String,System.String,System.String,System.Int32)
The add real server to server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **realServerId:** The real server id.

> **realServerPort:** The real server port.

> #####Return value
> The .

####RemoveRealServerFromServerFarm(System.String,System.String,System.String,System.Int32)
The remove real server from server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **realServerId:** The real server id.

> **realServerPort:** The real server port.

> #####Return value
> The .

####AddProbeToServerFarm(System.String,System.String,System.String)
The add probe to server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **probeId:** The probe id.

> #####Return value
> The .

####RemoveProbeFromServerFarm(System.String,System.String,System.String)
The remove probe from server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **probeId:** The probe id.

> #####Return value
> The .

####GetPersistenceProfile(System.String)
The get persistence profile.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreatePersistenceProfileIpNetmask(System.String,System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.PersistenceProfileDirection,System.String)
The create persistence profile ip netmask.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **serverFarmId:** The server farm id.

> **timeOutMinutes:** The time out minutes.

> **direction:** The direction.

> **netmask:** The netmask.

> #####Return value
> The .

####CreatePersistenceProfileHttpCookie(System.String,System.String,System.String,System.Int32,System.String,DD.CBU.Compute.Api.Contracts.Vip.PersistenceProfileCookieType)
The create persistence profile http cookie.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **serverFarmId:** The server farm id.

> **timeOutMinutes:** The time out minutes.

> **cookieName:** The cookie name.

> **cookieType:** The cookie type.

> #####Return value
> The .

####RemovePersistenceProfile(System.String,System.String)
The remove persistence profile.
> #####Parameters
> **networkId:** The network id.

> **persistenceProfileId:** The pers profile id.

> #####Return value
> The .

####GetVips(System.String)
The get vips.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreateVip(System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.VipProtocol,DD.CBU.Compute.Api.Contracts.Vip.VipTargetType,System.String,System.Boolean,System.Boolean,System.String)
The create vip.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **port:** The port.

> **protocol:** The protocol.

> **targetType:** The target type.

> **targetId:** The target id.

> **replyToIcmp:** The reply to icmp.

> **inService:** The in service.

> **ipAddress:** The ip address.

> #####Return value
> The .

####RemoveVip(System.String,System.String)
The remove vip.
> #####Parameters
> **networkId:** The network id.

> **vipId:** The vip id.

> #####Return value
> The .

####ModifyVip(System.String,System.String,System.Boolean,System.Boolean)
The modify vip.
> #####Parameters
> **networkId:** The network id.

> **vipId:** The vip id.

> **replyToIcmp:** The reply to icmp.

> **inService:** The in service.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.ImportExportImages.IImportExportCustomerImageAccessor
            
The ImportExportCustomerImageAccessor interface.
        
###Methods


####GetOvfPackages
The get ovf packages.
> #####Return value
> The .

####GetCustomerImagesImports
The get customer images imports.
> #####Return value
> The .

####GetCustomerImagesExports
The get customer images exports.
> #####Return value
> The .

####GetCustomerImagesExportHistory(System.Int32)
The get customer images export history.
> #####Parameters
> **count:** The count.

> #####Return value
> The .

####ImportCustomerImage(System.String,System.String,System.String,System.String)
The import customer image.
> #####Parameters
> **customerImageName:** The customer image name.

> **ovfPackageName:** The ovf package name.

> **networkLocation:** The network location.

> **description:** The description.

> #####Return value
> The .

####ExportCustomerImage(DD.CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImage,System.String)
The export customer image.
> #####Parameters
> **image:** The image.

> **ovfPrefix:** The ovf prefix.

> #####Return value
> The .

####ExportCustomerImage(System.String,System.String)
The import customer image.
> #####Parameters
> **imageId:** The customer image id.

> **ovfPrefix:** The ovf package name.

> #####Return value
> The .

####CopyOvfPackageFromRemoteGeo(DD.CBU.Compute.Api.Contracts.Image.NewRemoteOvfCopy)
Copies an OVF package from a remote geo.
> #####Parameters
> **newRemoteOvfCopy:** The copy request.

> #####Return value
> The .

####GetRemoteOvfPackageCopyInProgress
Gets OVF package copies currently in progress.
> #####Return value
> The .

####GetRemoteOvfPackageCopyHistory(System.Int32)
Gets OVF package copy history.
> #####Parameters
> **count:** The count.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Server20.IMonitoringAccessor
            
The Monitoring Accessor interface.
        
###Methods


####EnableServerMonitoring(DD.CBU.Compute.Api.Contracts.Network20.EnableServerMonitoringType)
Enables server monitoring.
> #####Parameters
> **enableServerMonitoring:** The monitoring settings.

> #####Return value
> The status response

####ChangeServerMonitoringPlan(DD.CBU.Compute.Api.Contracts.Network20.ChangeServerMonitoringPlanType)
Changes the service plan.
> #####Parameters
> **changeServerMonitoringPlan:** The monitoring settings.

> #####Return value
> The status response

####DisableServerMonitoring(System.Guid)
Disables server monitoring.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The status response

####GetMonitoringUsageReport(System.DateTime,System.Nullable{System.DateTime})
Gets the monitoring usage report.
> #####Parameters
> **startDate:** The start date.

> **endDate:** The end date.

> #####Return value
> The usage report as CSV.

##CBU.Compute.Api.Client.Interfaces.Server20.IAntiAffinityRuleAccessor
            
The AntiAffinityRuleAccessor interface.
        
###Methods


####GetAntiAffinityRulesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForServer(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions)
Gets the available anti affinity rules for a specific server.
> #####Parameters
> **serverId:** The server id.

> **filteringOptions:** The filtering options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForServerPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules for a specific server.
> #####Parameters
> **serverId:** The server id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetwork(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions)
Gets the available anti affinity rules for a specific network.
> #####Parameters
> **networkId:** The network id.

> **filteringOptions:** The filtering options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetworkPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules for a specific network.
> #####Parameters
> **networkId:** The network id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetworkDomain(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions)
Gets the available anti affinity rules for a specific network domain.
> #####Parameters
> **networkDomainId:** The network domain id.

> **filteringOptions:** The filtering options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetworkDomainPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules for a specific network domain.
> #####Parameters
> **networkDomainId:** The network domain id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

##CBU.Compute.Api.Client.Interfaces.Server20.IServerImageAccessor
            
The ServerAccessor interface.
        
###Methods


####GetOsImage(System.Guid)
Get the OS images supported on this data center
> #####Parameters
> **imageId:** The image Id

> #####Return value
> The .

####GetOsImages(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerOsImageListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get OS images supported on this data center
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetCustomerImage(System.Guid)
Get the customer images supported on this data center
> #####Parameters
> **imageId:** The image Id

> #####Return value
> The .

####GetCustomerImages(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerCustomerImageListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get customer images supported on this data center
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####EditCustomerImageMetadata(DD.CBU.Compute.Api.Contracts.Network20.ImageMetadataType)
Edit the customer image metadata
> #####Parameters
> **imageMetadata:** The image metadata

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Server20.IServerAccessor
            
The ServerAccessor interface.
        
###Methods


####GetMcp2DeployedServers(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get mcp 2 deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetServers(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions)
The get mcp 2 deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> The .

####GetServersPaginated(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get mcp 2 deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetMcp2DeployedServer(System.Guid)
The get mcp 2 deployed server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetServer(System.Guid)
The get mcp 2 deployed server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####DeleteServer(System.Guid)
Deletes the server described by serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####StartServer(System.Guid)
Starts a server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####ShutdownServer(System.Guid)
Shutdown server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####RebootServer(System.Guid)
Reboot server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####ResetServer(System.Guid)
Resets the server described by serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####PowerOffServer(System.Guid)
Power off server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####UpdateVmwareTools(System.Guid)
Updates the v mware tools described by serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####UpgradeVirtualHardware(System.Guid)
Updates the vistual hardware for serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####DeployServer(DD.CBU.Compute.Api.Contracts.Network20.DeployServerType)
Deploys a server to MCP1.0 or MCP 2.0 data centers
> #####Parameters
> **serverDetails:** Details of the server to be deployed

> #####Return value
> A standard CaaS response

####CleanServer(System.Guid)
Cleans a failed server deployment.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####AddNic(System.Guid,System.Nullable{System.Guid},System.String,System.String)
Adds an additional NIC to a server.
> #####Parameters
> **serverId:** The server id.

> **vlanId:** The VLAN id

> **privateIpv4:** The Private IP v4 address

> **networkAdapter:** The optional network adapter type (E1000 or VMXNET3)

> #####Return value
> A standard CaaS response

####RemoveNic(System.Guid)
Removes an additional NIC from a server.
> #####Parameters
> **nicId:** The NIC id.

> #####Return value
> A standard CaaS response

####ListNics(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.ListNicsOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The list nics.
> #####Parameters
> **vlanId:** The vlan id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####NotifyNicIpChange(DD.CBU.Compute.Api.Contracts.Network20.NotifyNicIpChangeType)
Updates the Cloud record to match the value set on the deployed server.
> #####Parameters
> **notifyNicIpChange:** The Notify NIC IP change model.

> #####Return value
> A standard CaaS response

####ReconfigureServer(DD.CBU.Compute.Api.Contracts.Network20.ReconfigureServerType)
Updates compute resource properties of a Server
> #####Parameters
> **reconfigureServer:** Details of the server to be updated

> #####Return value
> A standard CaaS response

####AddDisk(DD.CBU.Compute.Api.Contracts.Network20.AddDiskType)
The add disk.
> #####Parameters
> **addDisk:** The add disk.

> #####Return value
> The .

####RemoveDisk(DD.CBU.Compute.Api.Contracts.Network20.RemoveDiskType)
The remove disk.
> #####Parameters
> **removeDisk:** The remove disk.

> #####Return value
> The .

####EditServerMetadata(DD.CBU.Compute.Api.Contracts.Network20.editServerMetadata)
Edit metadata of the server
> #####Parameters
> **editServerMetadata:** Server metadata change model.

> #####Return value
> The async type of

##CBU.Compute.Api.Client.Interfaces.Server20.IServerManagementAccessor
            
The ServerManagementAccessor interface.
        
###Properties

####Server
Gets the Server Accessor.
####ServerImage
Gets the Server Images Accessor.
####AntiAffinityRule
Gets the Anti Affinity Rule Accessor.
####Monitoring
Gets the Monitoring Accessor.

##CBU.Compute.Api.Client.Interfaces.Reports.IReportAccessor
            
The Reports Interface
        
###Methods


####GetSummaryUsage(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report of the sum total usage across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetDetailedUsageReport(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report by the specifics of all usage across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetSoftwareUnitsUsageReport(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report by identifying the software unit calculation specifics for any Priced Software on virtual servers across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetBackupUsageReport(System.String,System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report by identifying the specifics of all Backup usage across the account.
> #####Parameters
> **datacenterId:** The datacenter Id

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetAdministratorLogsReport(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report of the administrator actions taken across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetDrsPairsUsageReport(System.DateTime,System.DateTime)
Returns a report detailing the DRS server pairs that were in existance for the supplied organizationId during the specified date range.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

##CBU.Compute.Api.Client.Interfaces.Server.IServerAccessor
            
The server Interface
        
###Methods


####GetDeployedServers(System.String,System.String,System.String,System.String)
The get deployed servers.
> #####Parameters
> **serverid:** The serverid.

> **name:** The name.

> **networkId:** The network id.

> **location:** The location.

> #####Return value
> The .

####GetDeployedServers(DD.CBU.Compute.Api.Contracts.Requests.Server.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####ModifyServer(System.String,System.String,System.String,System.Int32,System.Int32,System.String)
The modify server.
> #####Parameters
> **serverId:** The server id.

> **name:** The name.

> **description:** The description.

> **memory:** The memory.

> **cpucount:** The CPU count.

> **privateIp:** The private IP.

> #####Return value
> The .

####ServerPowerOn(System.String)
Powers on the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerPowerOff(System.String)
Powers off the server.
> #####Parameters
> **serverId:** Server Id

> #####Return value
> The .

####ServerRestart(System.String)
Restart the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerReset(System.String)
Power cycles an existing deployed server. This is the equivalent of pulling and replacing the power cord for a physical server. Requires your organization ID and the ID of the target server..
> #####Parameters
> **serverId:** The server id.

> #####Return value
> Returns a status of the HTTP request

####ServerShutdown(System.String)
Shutdown the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ChangeServerDiskSize(System.String,System.String,System.String)
Modify server disk size.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> **sizeInGb:** Size In GB.

> #####Return value
> The status of the deployment.

####ChangeServerDiskSpeed(System.String,System.String,System.String)
Modify server disk speed.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> **speedId:** Size in GB.

> #####Return value
> The status of the deployment.

####AddServerDisk(System.String,System.String,System.String)
Add Disk to Server
> #####Parameters
> **serverId:** The server id

> **size:** The size of the new disk

> **speedId:** The speed Id.

> #####Return value
> The .

####RemoveServerDisk(System.String,System.String)
Modify server server settings.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> #####Return value
> The status of the deployment.

####ServerUpdateVMwareTools(System.String)
Triggers an update of the VMWare Tools software running on the guest OS of a virtual server
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerDelete(System.String)
Delete the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerCloneToCustomerImage(System.String,System.String,System.String)
Initiates a clone of a server to create a Customer Image
> #####Parameters
> **serverId:** The server id.

> **imageName:** The customer image name.

> **imageDesc:** The customer image description.

> #####Return value
> The .

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,Disk[])
Deploy a server using an image in a specified network.
> #####Parameters
> **name:** The name of the new server.

> **description:** The description of the new server.

> **networkId:** The network id to deploy the server.

> **privateIp:** The privateIp address to deploy the server.

> **imageId:** The image id to deploy the server.

> **adminPassword:** The administrator password.

> **start:** Will the server powers on after deployment?

> **disk:** Array od disk configurations

> #####Return value
> The status of the deployment.

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean)
The deploy server with disk speed image task.
> #####Parameters
> **name:** The name.

> **description:** The description.

> **networkId:** The network id.

> **privateIp:** The private ip.

> **imageId:** The image id.

> **adminPassword:** The admin password.

> **start:** The start.

> #####Return value
> The .

####CreateServerAntiAffinityRule(System.String,System.String)
Creates a new Server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **serverId1:** The server Id for the 1'st server

> **serverId2:** The server Id for the 2'nd server

> #####Return value
> The .

####GetServerAntiAffinityRules(System.String,System.String,System.String)
List all Server Anti-Affinity Rules
> #####Parameters
> **ruleId:** Filter by rule Id

> **location:** Filter by location

> **networkId:** Filter by network Id

> #####Return value
> The .

####RemoveServerAntiAffinityRule(System.String)
Remove a server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **ruleId:** The ruleId

> #####Return value
> The .

####NotifyPrivateIpChange(System.String,System.String)
The notify system private IP address change.
> #####Parameters
> **serverId:** The server id.

> **privateIpV4:** The Private IP v4.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Server.IServerImagesAccessor
            
The ServerImagesAccessor interface.
        
###Methods


####GetImages(System.String,System.String,System.String,System.String,System.String)
The get images.
> #####Parameters
> **imageId:** The image id.

> **name:** The name.

> **location:** The location.

> **operatingSystemId:** The operating system id.

> **operatingSystemFamily:** The operating system family.

> #####Return value
> The .

####GetCustomerServerImages(System.String,System.String,System.String,System.String,System.String)
The get customer server images.
> #####Parameters
> **imageId:** The image id.

> **name:** The name.

> **location:** The location.

> **operatingSystemId:** The operating system id.

> **operatingSystemFamily:** The operating system family.

> #####Return value
> The .

####CopyCustomerServerImage(System.String,System.String,System.String,System.String,System.String)
The copy customer image
> #####Parameters
> **imageId:** The source image id.

> **targetImageName:** Target Image Name

> **targetImageDescription:** Target Image Description

> **targetLocation:** Target Location

> **ovfPackagePrefix:** OVF Package Prefix

> #####Return value
> The .

####GetCustomerServerImageBeingCopied
Returns all the customer images being copied.
> #####Return value
> list of images being copied

####RemoveCustomerServerImage(System.String)
The remove customer server image.
> #####Parameters
> **imageid:** The imageid.

> #####Return value
> The .

####CleanFailedCustomerServerImage(System.String)
The clean failed customer server image.
> #####Parameters
> **imageid:** The imageid.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.Server.IServerManagementLegacyAccessor
            
The ServerManagementLegacyAccessor interface.
        
###Properties

####Server
Gets the server.
####ServerImage
Gets the server image.

##CBU.Compute.Api.Client.Interfaces.Tagging.ITaggingAccessor
            
The TaggingAccessor interface.
        
###Methods


####CreateTagKey(DD.CBU.Compute.Api.Contracts.Network20.createTagKeyType)
The create tag key.
> #####Parameters
> **createTagKey:** The create tag key.

> #####Return value
> The .

####GetTagKeys(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagKeyListOptions)
The get tag keys.
> #####Parameters
> **tagKeyListOptions:** The tag key list options.

> #####Return value
> The .

####GetTagKeysPaginated(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagKeyListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get tag keys paginated.
> #####Parameters
> **tagKeyListOptions:** The tag key list options.

> **paginngOptions:** The paginng options.

> #####Return value
> The .

####GetTagKey(System.Guid)
The get tag key.
> #####Parameters
> **tagKeyId:** The tag key id.

> #####Return value
> The .

####EditTagKey(DD.CBU.Compute.Api.Contracts.Network20.EditTagKeyType)
The edit tag key.
> #####Parameters
> **editTagKey:** The edit tag key.

> #####Return value
> The .

####DeleteTagKey(DD.CBU.Compute.Api.Contracts.Network20.deleteTagKeyType)
The delete tag key.
> #####Parameters
> **deleteTagKey:** The delete tag key.

> #####Return value
> The .

####ApplyTags(DD.CBU.Compute.Api.Contracts.Network20.applyTags)
The apply tags.
> #####Parameters
> **applyTags:** The apply tags.

> #####Return value
> The .

####GetTags(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagListOptions)
The get tags.
> #####Parameters
> **tagListOptions:** The tag list options.

> #####Return value
> The .

####GetTagsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get tags paginated.
> #####Parameters
> **tagListOptions:** The tag list options.

> **paginngOptions:** The paginng options.

> #####Return value
> The .

####RemoveTags(DD.CBU.Compute.Api.Contracts.Network20.RemoveTagsType)
The remove tags.
> #####Parameters
> **removeTags:** The remove tags.

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.IComputeApiClient
            
The interface of the CaaS API Client
        
###Properties

####WebApi
The web API that requests directly from the REST API.
####Account
Gets the account accessor
####Infrastructure
Gets the Infrastructure accessor.
####Networking
Gets the networking 2.0 methods.
####NetworkingLegacy
Gets the networking legacy 1.0 methods
####ServerManagementLegacy
Gets the server legacy.
####ServerManagement
Gets the server management.
####ImportExportCustomerImage
Gets the import and export customer images accessor
####Backup
Gets the backup.
####Reports
Gets the Reports
####Tagging
Gets the tagging.
####ConsistencyGroups
Gets the Consistency groups.
###Methods


####Login
The login async.
> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.IHttpClient
            
Represents a type that can make HttpClient calls.
        
###Properties

####BaseAddress
The base address used by the HTTP client.
###Methods


####GetAsync(System.Uri)
Get asynchronously
> #####Parameters
> **uri:** The URI

> #####Return value
> The .

####DeleteAsync(System.Uri)
Delete asynchronously
> #####Parameters
> **uri:** The URI

> #####Return value
> The .

####PutAsync(System.Uri,System.Net.Http.HttpContent)
Put asynchronously
> #####Parameters
> **uri:** The URI

> **content:** 

> #####Return value
> The .

####PostAsync(System.Uri,System.Net.Http.HttpContent)
Post asynchronously
> #####Parameters
> **uri:** The URI

> **content:** The content to post

> #####Return value
> The .

##CBU.Compute.Api.Client.Interfaces.IWebApi
            
The web API interface for communication with CaaS REST API.
        
###Properties

####OrganizationId
Gets the CaaS client organization id.
###Methods


####LoginAsync
The login async.
> #####Return value
> The .

####GetAsync``1(System.Uri,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.IFilterableRequest)
Invoke a CaaS API operation using a HTTP GET request.
> #####Parameters
> **relativeOperationUri:** The operation URI (relative to the CaaS API's base URI).

> **pagingOptions:** The paging Options.

> **filteringOptions:** The filtering Options.

> #####Return value
> The operation result.

####PostAsync``2(System.Uri,``0)
Invoke a CaaS API operation using a HTTP POST request.
> #####Parameters
> **relativeOperationUri:** The operation URI (relative to the CaaS API's base URI).

> **content:** The content that will be deserialised and passed in the body of the POST request.

> #####Return value
> The operation result.

####PostAsync``1(System.Uri,System.String)
Invoke a CaaS API operation using a HTTP POST request with string content
> #####Parameters
> **relativeOperationUri:** The operation URI (relative to the CaaS API's base URI).

> **content:** The content that will be passed as string in the body of the POST request.

> #####Return value
> The operation result.

##CBU.Compute.Api.Client.KnownApiRegion
            
Values that represent known API regions. 
            
GeoKey represents the geokey value returned by multigeo call	   
        
###Fields

####Africa_AF
Africa (AF), GeoKey = africa
####AsiaPacific_AP
Asia Pacific (AP) , GeoKey = asiapacific
####Australia_AU
Australia (AU), GeoKey = australia
####Canada_CA
Canada (CA), GeoKey = canada
####Europe_EU
Europe (EU), GeoKey = europe
####India_IN
India, GeoKey = india
####Indonesia_ID
Indonesia, GeoKey = indonesia
####Israel_IL
Israel, GeoKey = israel
####NorthAmerica_NA
North America (NA), GeoKey = northamerica
####SouthAmerica_SA
South America (LATAM), GeoKey = southamerica

##CBU.Compute.Api.Client.KnownApiVendor
            
The known API vendor.
        
###Fields

####DimensionData
Dimension Data
####DimensionData_Government
Dimension Data Governament
####NTTA
NTT-America (part of NTT communications).
####Cisco
The cisco.
####InternetSolutions
Internet Solutions, a subsidiary of Dimension Data.
####Indosat
Indosat indonesia
####BSNL
BNSL Vendor indosat.
####RootAxcess
RootAxcess Vendor (NA).
####Tenzing_Everest
RootAxcess Vendor (NA).
####PWW_Cloud_Connect
PWW Cloud Connect Vendor (NA).
####Med_One
Med1

##CBU.Compute.Api.Client.KnownApiUri
            
Static class to
        
###Fields

####_instance
Singleton implementation of the known API class
###Properties

####Instance
Gets the instance.
####KnownApiHostNames
Private Dictionary to host all endpoints
####KnownFtpHostNames
Private Dictionary to host all endpoints
####KnownVpnHostNames
Private Dictionary to host all regional vpn endpoints
####KnownMonitoringHostNames
Private Dictionary to host all regional monitoring endpoints
####KnownVendorEndPointPairs
Mapping between Vendor and applicable regions
####KnownApiHostUiNames
Private Dictionary to host all regional password reset endpoints
###Methods


####Constructor
Anthony, 4/24/2015.
Prevents a default instance of the DD.CBU.Compute.Api.Client.KnownApiUri class from being created.

####GetBaseUri(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion)
Return an known CaaS URI based on vendor and region
> #####Parameters
> **vendor:** The vendor

> **region:** The region

> #####Return value
> The .

####GetFtpHost(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion)
The get ftp host.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> #####Return value
> The .
> #####Exceptions
> **DD.CBU.Compute.Api.Client.ComputeApiException:** 


####GetVpnUrl(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion)
The get vpn host.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> #####Return value
> The .
> #####Exceptions
> **DD.CBU.Compute.Api.Client.ComputeApiException:** 


####GetMonitoringUrl(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion)
The get Monitoring url.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> #####Return value
> The .
> #####Exceptions
> **DD.CBU.Compute.Api.Client.ComputeApiException:** 


####GetRegionHostUiUrl(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion)
The get password reset url.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> #####Return value
> The .
> #####Exceptions
> **DD.CBU.Compute.Api.Client.Exceptions.ApiHostNotFoundException:** 


####GetKnownRegionList(DD.CBU.Compute.Api.Client.KnownApiVendor)
List of Known Regions that are valid for the particular Vendor.
> #####Parameters
> **vendor:** The Vendor.

> #####Return value
> The list of known regions.

####GetKnownRegionGeoKey(DD.CBU.Compute.Api.Client.KnownApiRegion)
Return the geokey for a known region
> #####Parameters
> **region:** Known Api Region

> #####Return value
> Geo Key

####GetKnownRegionFromGeoKey(System.String)
Returns the KnownRegion from geoKey
> #####Parameters
> **geoKey:** Geo Key

> #####Return value
> Known Region

####CreateKnownApiHostNames
Creates the collection of known URLs per vendor according to Cloud API Documentation

####AddHostName(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion,System.String)
Add host name to the known endpoints.
> #####Parameters
> **vendor:** The Vendor.

> **region:** The Region.

> **apiUrl:** The API URL.


####AddFtpHostName(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion,System.String)
The add ftp host name.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> **apiUrl:** The API url.


####AddVpnHostName(DD.CBU.Compute.Api.Client.KnownApiRegion,System.String)
The add vpn host name.
> #####Parameters
> **region:** The region.

> **apiUrl:** The API url.


####AddMonitoringHostName(DD.CBU.Compute.Api.Client.KnownApiRegion,System.String)
The add monitoring host name.
> #####Parameters
> **region:** The region.

> **apiUrl:** The API url.


####AddHostUiUrl(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion,System.String)
The add password reset host name.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> **apiUrl:** The api url.


##CBU.Compute.Api.Client.Network20.ComputeApiClientNetworkExtensions
            
Extension methods for the Network section of the CaaS API.
        
###Methods


####DeployServerOnNetworkDomain(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Network20.DeployServerType)
This function deploys a new network domains to Cloud
> #####Parameters
> **client:** The client.

> **server:** The network Domain.

> #####Return value
> Response containing status.

####AddNicToServer(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Network20.AddNicType)
Anthony, 4/24/2015.
An IComputeApiClient extension method that adds a NIC to server to 'addNic'.
> #####Parameters
> **client:** The compute client.

> **addNic:** The add NIC.

> #####Return value
> A standard response.

##CBU.Compute.Api.Client.Network20.IpAddressAccessor
            
An IP address management client.
            
> *See also: T:DD.CBU.Compute.Api.Client.Interfaces.IIpam
        
###Fields

####_apiClient
The client.
###Methods


####Constructor
Initializes a new instance of the .
> #####Parameters
> **apiClient:** The client.


####AddPublicIpBlock(System.Guid)
Adds a public IP block.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> #####Return value
> The job from the API;

####GetPublicIpBlocks(System.Guid)
Gets public IP blocks.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> #####Return value
> The public IP blocks.

####GetPublicIpBlocksPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Network20.PublicIpListOptions)
Gets public IP blocks.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **pagingOptions:** The paging options, null means default.

> **filterOptions:** Filtering option

> #####Return value
> The public IP blocks.

####GetPublicIpBlock(System.Guid)
Gets public IP block.
> #####Parameters
> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The public IP block.

####GetPublicIpBlock(System.Guid,System.Guid)
Gets public IP block.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The public IP block.

####GetReservedPublicAddressesForNetworkDomain(System.Guid)
Gets reserved public IP addresses for a network domain.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> #####Return value
> The reserved public addresses.

####GetReservedPublicAddressesForNetworkDomainPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedPublicIpv4ListOptions)
Gets reserved public IP addresses for a network domain.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **pagingOptions:** The paging options, null means default.

> **filterOptions:** Filtering option

> #####Return value
> The reserved public addresses.

####GetReservedPublicAddressesForNetwork(System.Guid)
Gets reserved public addresses for an MCP 1.0 network.
> #####Parameters
> **networkId:** Identifier for the network.

> #####Return value
> The reserved public addresses for network.

####GetReservedPrivateIpv4Addresses(DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedPrivateIpv4ListOptions)
The get reserved private ipv 4 addresses.
> #####Parameters
> **reservedPrivateIpv4ListOptions:** The reserved private ipv 4 list options.

> #####Return value
> The .

####GetReservedPrivateAddressesForVlan(System.Guid)
Gets reserved private addresses.
> #####Parameters
> **vlanId:** The VLAN Id.

> #####Return value
> The reserved private addresses.

####GetReservedPrivateIpv4AddressesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedPrivateIpv4ListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved private ipv 4 addresses paginated.
> #####Parameters
> **reservedPrivateIpv4ListOptions:** The reserved private ipv 4 list options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetReservedPrivateAddressesForVlanPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets reserved private addresses.
> #####Parameters
> **vlanId:** The VLAN Id.

> **pagingOptions:** The paging options, null means default.

> #####Return value
> The reserved private addresses.

####DeletePublicIpBlock(System.Guid,System.Guid)
Deletes the public IP block.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **publicIpBlockId:** Identifier for the public IP block.

> #####Return value
> The job from the API;

####ReservePrivateIpv4Address(DD.CBU.Compute.Api.Contracts.Network20.ReservePrivateIpv4AddressType)
The reserve private ipv 4 address.
> #####Parameters
> **reservePrivateIpv4Address:** The reserve private ipv 4 address.

> #####Return value
> The .

####UnreservePrivateIpv4Address(DD.CBU.Compute.Api.Contracts.Network20.UnreservePrivateIpv4AddressType)
The unreserve private ipv 4 address.
> #####Parameters
> **unReservePrivateIpv4Address:** The un reserve private ipv 4 address.

> #####Return value
> The .

####ReserveIpv6Address(DD.CBU.Compute.Api.Contracts.Network20.ReserveIpv6AddressType)
The reserve ipv 6 address.
> #####Parameters
> **reserveIpv6Address:** The reserve ipv 6 address.

> #####Return value
> The .

####UnreserveIpv6Address(DD.CBU.Compute.Api.Contracts.Network20.UnreserveIpv6AddressType)
The unreserve ipv 6 address.
> #####Parameters
> **unreserveIpv6Address:** The unreserve ipv 6 address.

> #####Return value
> The .

####GetReservedIpv6Addresses
The get reserved ipv 6 addresses.
> #####Return value
> The .

####GetReservedIpv6Addresses(System.Guid)
The get reserved ipv 6 addresses.
> #####Parameters
> **vlanId:** The vlan id.

> #####Return value
> The .

####GetReservedIpv6Addresses(System.String)
The get reserved ipv 6 addresses.
> #####Parameters
> **ipAddress:** The ip address.

> #####Return value
> The .

####GetReservedIpv6AddressesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.ReservedIpv6ListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved ipv 6 addresses paginated.
> #####Parameters
> **reservedIpv6ListOptions:** The reserved ipv 6 list options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetReservedIpv6AddressesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved ipv 6 addresses paginated.
> #####Parameters
> **vlanId:** The vlan id.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetReservedIpv6AddressesPaginated(System.String,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get reserved ipv 6 addresses paginated.
> #####Parameters
> **ipAddress:** The ip address.

> **pagingOptions:** The paging options.

> #####Return value
> The .

##CBU.Compute.Api.Client.Network20.NatAccessor
            
The Network Address Translation Management.
        
###Fields

####_api
The Web Api.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **api:** The api.


####GetNatRules(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.NatRuleListOptions)
Retrieves the list of the NAT Rules on a particular Network Domain at an MCP 2.0 data center This API requires your organization ID and the ID of the target network.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **options:** Options for filtering the operations.

> #####Return value
> The NAT Rule collection.

####GetNatRulesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.NatRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves the list of the NAT Rules on a particular Network Domain at an MCP 2.0 data center This API requires your organization ID and the ID of the target network.
> #####Parameters
> **networkDomainId:** Identifier for the network domain.

> **options:** Options for filtering the operations.

> **pagingOptions:** The paging options, null means default.

> #####Return value
> The NAT Rule collection.

####CreateNatRule(DD.CBU.Compute.Api.Contracts.Network20.createNatRule)
Creates a NAT Rule on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **natRule:** The NAT Rule.

> #####Return value
> Operation status

####GetNatRule(System.Guid)
Returns details of a single NAT Rule.
> #####Parameters
> **natRuleId:** The NAT Rule id.

> #####Return value
> The NAt Rule.

####DeleteNatRule(System.Guid)
Deletes a NAT Rule.
> #####Parameters
> **natRuleId:** The id of the VLAN.

> #####Return value
> The job from the API;

##CBU.Compute.Api.Client.Network20.NetworkDomainAccessor
            
The network domain.
        
###Fields

####_apiClient
The _client.
###Methods


####Constructor
Initializes a new instance of the DD.CBU.Compute.Api.Client.Network20.NetworkDomain class.
> #####Parameters
> **apiClient:** The client.


####GetNetworkDomains(DD.CBU.Compute.Api.Contracts.Requests.Network20.NetworkDomainListOptions)
The get network domains.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> The .

####GetNetworkDomainsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.NetworkDomainListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The get network domains.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetNetworkDomain(System.Guid)
This function gets a network domain from Cloud.
> #####Parameters
> **networkDomainId:** Network domain id.

> #####Return value
> The network domain with the supplied id.

####GetNetworkDomain(System.String)
This function gets a network domain from Cloud.
> #####Parameters
> **networkDomainName:** The network domain name.

> #####Return value
> The network domain with the supplid name.

####DeployNetworkDomain(DD.CBU.Compute.Api.Contracts.Network20.DeployNetworkDomainType)
This function deploys a new network domains to Cloud
> #####Parameters
> **networkDomain:** The network Domain.

> #####Return value
> Response containing status.

####ModifyNetworkDomain(DD.CBU.Compute.Api.Contracts.Network20.EditNetworkDomainType)
The modify network domain.
> #####Parameters
> **networkDomain:** The network domain.

> #####Return value
> The .

####DeleteNetworkDomain(System.Guid)
Delete the network domain.
> #####Parameters
> **id:** The identifier of the network domain.

> #####Return value
> The .

##CBU.Compute.Api.Client.Network20.NetworkDomainExtensions
            
Extension methods for network domain operations.
        
###Methods


####GetNetworkDomains(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
This function gets list of network domains from Cloud.
> #####Parameters
> **client:** The client.

> **pagingOptions:** Options for controlling the paging.

> #####Return value
> The list of network domains associated with the organization.

####GetNetworkDomain(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.Guid)
This function gets list of network domains from Cloud.
> #####Parameters
> **client:** The client.

> **networkDomainId:** Network domain id.

> #####Return value
> The list of network domains associated with the organization.

####GetNetworkDomain(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
This function gets list of network domains from Cloud.
> #####Parameters
> **client:** The client.

> **networkDomainName:** The network domain name.

> #####Return value
> The list of network domains associated with the organization.

####DeployNetworkDomain(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Network20.DeployNetworkDomainType)
This function deploys a new network domains to Cloud
> #####Parameters
> **client:** The client.

> **networkDomain:** The network Domain.

> #####Return value
> Response containing status.

####DeleteNetworkDomain(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
An IComputeApiClient extension method that deletes the network domain.
> #####Parameters
> **client:** The client.

> **id:** The identifier of the network domain.

> #####Return value
> A job response from the API;

##CBU.Compute.Api.Client.Network20.VipSupportAccessor
            
The VIP support type.
        
###Fields

####_api
The Web Api.
###Methods


####Constructor
Initializes a new instance of
> #####Parameters
> **api:** The Web Api


####GetDefaultHealthMonitors(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultHealthMonitorListOptions)
Retrieves default health monitors.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> #####Return value
> The async task of collection of

####GetDefaultHealthMonitorsPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultHealthMonitorListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves default health monitors.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> **pagingOptions:** The paging options

> #####Return value
> The async task of

####GetDefaultPersistenceProfiles(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultPersistenceProfileListOptions)
Retrieves default persistence profiles.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> #####Return value
> The async task of collection of

####GetDefaultPersistenceProfilesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultPersistenceProfileListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves default persistence profiles.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> **pagingOptions:** The paging options

> #####Return value
> The async task of

####GetDefaultIrules(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultIruleListOptions)
Retrieves default iRules.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> #####Return value
> The async task of collection of

####GetDefaultIrulesPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.DefaultIruleListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves default iRules.
> #####Parameters
> **networkDomainId:** The network domain id

> **options:** The filter options

> **pagingOptions:** The paging options

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Network20.VipPoolAccessor
            
The NetworkDomainVip type.
        
###Fields

####_api
The Web Api.
###Methods


####Constructor
Initializes a new instance of
> #####Parameters
> **api:** The Web Api


####CreatePool(DD.CBU.Compute.Api.Contracts.Network20.createPool)
Creates a Pool on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **pool:** The create pool.

> #####Return value
> The async task of

####GetPools(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolListOptions)
Retrieves all of the Pools on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of collection of

####GetPoolsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves all of the Pools on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> **pagingOptions:** The paging Options.

> #####Return value
> The async task of

####GetPool(System.Guid)
Returns details of a single Pool.
> #####Parameters
> **poolId:** The Pool id.

> #####Return value
> The async task of

####EditPool(DD.CBU.Compute.Api.Contracts.Network20.EditPoolType)
Updates the mutable properties of a Pool.
> #####Parameters
> **pool:** The edit pool.

> #####Return value
> The async task of

####DeletePool(System.Guid)
Deletes a Pool.
> #####Parameters
> **poolId:** The Pool id.

> #####Return value
> The async task of

####AddPoolMember(DD.CBU.Compute.Api.Contracts.Network20.addPoolMember)
Adds a Node, combined with Port information to the identified Pool as a new Pool Member.
> #####Parameters
> **poolMember:** The Pool Member

> #####Return value
> The async task of

####GetPoolMembers(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolMemberListOptions)
Retrieves the Pool Members on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of a collection of

####GetPoolMembersPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.PoolMemberListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves the Pool Members on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options.

> **pagingOptions:** The Paging options.

> #####Return value
> The async task of

####GetPoolMember(System.Guid)
Returns details of a single Pool Member.
> #####Parameters
> **poolMemberId:** The Pool Member id.

> #####Return value
> The async task of

####EditPoolMember(DD.CBU.Compute.Api.Contracts.Network20.editPoolMember)
Updates the status of a Pool Member.
> #####Parameters
> **poolMember:** The edit pool member.

> #####Return value
> The async task of

####RemovePoolMember(System.Guid)
Deletes a Pool Member.
> #####Parameters
> **poolMemberId:** The Pool Member id.

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Network20.NetworkingAccessor
            
A standard implementation of Network 2.0 access methods.
        
###Properties

####NetworkDomain
Gets the network domain Accessor.
####Vlan
Gets the VLAN Accessor.
####SecurityGroup
Gets the Vlan Security group accessor
####IpAddress
Gets the IP address Accessor.
####Nat
Gets the NAT Rule Accessor.
####FirewallRule
Gets the Firewall Rule Accessor.
####VipSupport
Gets the VIP Support Accessor.
####VipPool
Gets the VIP Pool Accessor.
####VipNode
Gets the VIP Node Accessor.
####VipVirtualListener
Gets the VIP Virtual Listener Accessor.
###Methods


####Constructor
Initializes a new instance of the class.
> #####Parameters
> **apiClient:** The api Client.


##CBU.Compute.Api.Client.Network20.VipNodeAccessor
            
The VIP Node Management type.
        
###Fields

####_api
The Web Api.
###Methods


####Constructor
Initializes a new instance of
> #####Parameters
> **api:** The Web Api


####CreateNode(DD.CBU.Compute.Api.Contracts.Network20.CreateNodeType)
Creates a Node on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **node:** The create node.

> #####Return value
> The async task of

####GetNodes(DD.CBU.Compute.Api.Contracts.Requests.Network20.NodeListOptions)
Retrieves all of the Nodes on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of collection of

####GetNodesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.NodeListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves all of the Nodes on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> **pagingOptions:** The paging Options.

> #####Return value
> The async task of

####GetNode(System.Guid)
Returns details of a single Node.
> #####Parameters
> **nodeId:** The Node id.

> #####Return value
> The async task of

####EditNode(DD.CBU.Compute.Api.Contracts.Network20.EditNodeType)
Updates the mutable properties of a Node.
> #####Parameters
> **node:** The edit node.

> #####Return value
> The async task of

####DeleteNode(System.Guid)
Deletes a Node.
> #####Parameters
> **nodeId:** The Node id.

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Network20.VipVirtualListenerAccessor
            
The VIP Virtual Listener Management type.
        
###Fields

####_api
The Web Api.
###Methods


####Constructor
Initializes a new instance of
> #####Parameters
> **api:** The Web Api


####GetVirtualListeners(DD.CBU.Compute.Api.Contracts.Requests.Network20.VirtualListenerListOptions)
Retrieves all of the VirtualListeners on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> #####Return value
> The async task of collection of

####GetVirtualListenersPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.VirtualListenerListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves all of the VirtualListeners on a particular Network Domain at an MCP 2.0 data center.
> #####Parameters
> **options:** The filter options

> **pagingOptions:** The paging Options.

> #####Return value
> The async task of

####GetVirtualListener(System.Guid)
Returns details of a single VirtualListener.
> #####Parameters
> **virtualListenerId:** The VirtualListener id.

> #####Return value
> The async task of

####CreateVirtualListener(DD.CBU.Compute.Api.Contracts.Network20.createVirtualListener)
Creates a VirtualListener on a Network Domain in an MCP 2.0 data center location.
> #####Parameters
> **virtualListener:** The create virtual listener.

> #####Return value
> The async task of

####EditVirtualListener(DD.CBU.Compute.Api.Contracts.Network20.editVirtualListener)
Updates the mutable properties of a VirtualListener.
> #####Parameters
> **virtualListener:** The edit virtualListener.

> #####Return value
> The async task of

####DeleteVirtualListener(System.Guid)
Deletes a VirtualListener.
> #####Parameters
> **virtualListenerId:** The VirtualListener id.

> #####Return value
> The async task of

##CBU.Compute.Api.Client.Network20.FirewallRuleAccessor
            
Access methods for firewall rule Operations
        
###Fields

####_api
The Api.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **api:** The api.


####GetFirewallRules(DD.CBU.Compute.Api.Contracts.Requests.Network20.FirewallRuleListOptions)
Lists all firewall rules.
> #####Parameters
> **options:** The filter options.

> #####Return value
> The collection of matching firewall rules.

####GetFirewallRulesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.FirewallRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Lists all firewall rules.
> #####Parameters
> **options:** The filter options.

> **pagingOptions:** The paging options.

> #####Return value
> The async task of

####GetFirewallRule(System.Guid)
Gets a specific firewall rule.
> #####Parameters
> **firewallRuleId:** The firewall rule identifier.

> #####Return value
> The response details.

####CreateFirewallRule(DD.CBU.Compute.Api.Contracts.Network20.CreateFirewallRuleType)
Creates a firewall rule.
> #####Parameters
> **createFirewallRule:** The firewall rule details.

> #####Return value
> The response details.

####EditFirewallRule(DD.CBU.Compute.Api.Contracts.Network20.EditFirewallRuleType)
Edits a firewall rule.
> #####Parameters
> **editFirewallRule:** The firewall rule details.

> #####Return value
> The response details.

####DeleteFirewallRule(System.Guid)
Deletes a firewall rule.
> #####Parameters
> **firewallRuleId:** The firewall rule identifier.

> #####Return value
> The response details.

####CreateIpAddressList(DD.CBU.Compute.Api.Contracts.Network20.createIpAddressList)
Creates an ip address list.
> #####Parameters
> **createIpAddressList:** The ip address list details.

> #####Return value
> The response details.

####GetIpAddressLists(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.IpAddressListOptions)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The network domain id.

> **options:** The filter options.

> #####Return value
> The collection of matching ip address list.

####GetIpAddressListsPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.IpAddressListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The Network domain id.

> **options:** The filter options.

> **pagingOptions:** The paging options.

> #####Return value
> The async task of

####GetIpAddressList(System.Guid)
Gets the ip address list.
> #####Parameters
> **ipAddressListId:** The ip address list id.

> #####Return value
> The collection of matching ip address list.

####EditIpAddressList(DD.CBU.Compute.Api.Contracts.Network20.editIpAddressList)
Edits an ip address list.
> #####Parameters
> **editIpAddressList:** The ip address list details.

> #####Return value
> The response details.

####DeleteIpAddressList(DD.CBU.Compute.Api.Contracts.Network20.deleteIpAddressList)
Deletes an ip address list.
> #####Parameters
> **deleteIpAddressList:** The ip address list id to be deleted.

> #####Return value
> The response details.

####CreatePortList(DD.CBU.Compute.Api.Contracts.Network20.createPortList)
Creates an ip address list.
> #####Parameters
> **createPortList:** The ip address list details.

> #####Return value
> The response details.

####GetPortLists(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.PortListOptions)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The network domain id.

> **options:** The filter options.

> #####Return value
> The collection of matching ip address list.

####GetPortListsPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Network20.PortListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Lists all ip address list.
> #####Parameters
> **networkDomainId:** The Network domain id.

> **options:** The filter options.

> **pagingOptions:** The paging options.

> #####Return value
> The async task of

####GetPortList(System.Guid)
Gets the ip address list.
> #####Parameters
> **portListId:** The ip address list id.

> #####Return value
> The collection of matching ip address list.

####EditPortList(DD.CBU.Compute.Api.Contracts.Network20.editPortList)
Edits an ip address list.
> #####Parameters
> **editPortList:** The ip address list details.

> #####Return value
> The response details.

####DeletePortList(DD.CBU.Compute.Api.Contracts.Network20.DeletePortListType)
Deletes an ip address list.
> #####Parameters
> **deletePortList:** The ip address list id to be deleted.

> #####Return value
> The response details.

##CBU.Compute.Api.Client.Network20.SecurityGroupAccessor
            
Access methods for VLAN Operations
            
> *See also: T:DD.CBU.Compute.Api.Client.Interfaces.IVlan
        
###Fields

####_api
The Api.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **api:** The api.


####CreateSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.createSecurityGroup)
Creates the Security group
> #####Parameters
> **securityGroup:** Security group

> #####Return value
> Response Data

####EditSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.editSecurityGroup)
Edit the security group
> #####Parameters
> **securityGroup:** Security group

> #####Return value
> Response Data

####DeleteSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.DeleteSecurityGroup)
Delete the security group
> #####Parameters
> **securityGroup:** Security group

> #####Return value
> Response Data

####GetSecurityGroupsPaged(System.Nullable{System.Guid},System.Nullable{System.Guid},DD.CBU.Compute.Api.Contracts.Requests.PageableRequest,DD.CBU.Compute.Api.Contracts.Requests.Network20.SecurityGroupListOptions)
List Security groups associated with server nics or the vlan
> #####Parameters
> **vlanId:** Vlan Id

> **serverId:** Server Id

> **pagingOptions:** Paging options

> **filterOptions:** Filter options

> #####Return value
> List of Security groups

####AddNicToSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.addNicToSecurityGroup)
Add nic to the security group
> #####Parameters
> **nicSecurityGroup:** Security group and nic details

> #####Return value
> Response Data

####RemoveNicFromSecurityGroup(DD.CBU.Compute.Api.Contracts.Network20.removeNicFromSecurityGroup)
Remove nic from the security group
> #####Parameters
> **nicSecurityGroup:** Security group and nic details

> #####Return value
> Response Data

##CBU.Compute.Api.Client.Network20.VlanAccessor
            
Access methods for VLAN Operations
            
> *See also: T:DD.CBU.Compute.Api.Client.Interfaces.IVlan
        
###Fields

####_api
The Api.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **api:** The api.


####GetVlans(DD.CBU.Compute.Api.Contracts.Requests.Network20.VlanListOptions)
Retrieves the list of ACL rules associated with a network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **options:** Options for controlling the operation.

> #####Return value
> The VLAN collection.

####GetVlansPaginated(DD.CBU.Compute.Api.Contracts.Requests.Network20.VlanListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Retrieves the list of ACL rules associated with a network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **options:** Options for controlling the operation.

> **pagingOptions:** Options for controlling the paging.

> #####Return value
> The VLAN collection.

####GetVlans(System.Guid,System.String,System.Guid,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The get VLAN list.
> #####Parameters
> **id:** The id.

> **vlanName:** The VLAN name.

> **networkDomainId:** The network domain id.

> **pagingOptions:** The paging Options.

> #####Return value
> The .

####GetVlan(System.Guid)
An IComputeApiClient extension method that gets a VLAN.
> #####Parameters
> **vlanId:** The id.

> #####Return value
> The vlan.

####DeployVlan(DD.CBU.Compute.Api.Contracts.Network20.DeployVlanType)
Deploys Virtual LAN on a network domain
> #####Parameters
> **vlan:** Virtual LAN

> #####Return value
> Operation status

####EditVlan(DD.CBU.Compute.Api.Contracts.Network20.EditVlanType)
Edit Virtual LAN on a network domain.
> #####Parameters
> **editVlan:** Edit Virtual LAN request.

> #####Return value
> Operation status

####ExpandVlan(DD.CBU.Compute.Api.Contracts.Network20.ExpandVlanType)
Expand Virtual LAN on a network domain.
> #####Parameters
> **expandVlan:** Expand Virtual LAN request.

> #####Return value
> Operation status

####DeleteVlan(System.Guid)
Delete a Virtual LAN
> #####Parameters
> **id:** The id of the VLAN.

> #####Return value
> Operation status

##CBU.Compute.Api.Client.Network20.VlanExtensions
            
The vlan extensions.
        
###Methods


####GetVlans(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Requests.Network20.VlanListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Anthony, 4/24/2015.
Retrieves the list of ACL rules associated with a network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **options:** Options for controlling the operation.

> **pagingOptions:** Options for controlling the paging.

> #####Return value
> The VLAN collection.

####GetVlans(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.Guid,System.String,System.Guid,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
The get VLAN list.
> #####Parameters
> **client:** The client.

> **id:** The id.

> **vlanName:** The VLAN name.

> **networkDomainId:** The network domain id.

> **pagingOptions:** The paging Options.

> #####Return value
> The .

####GetVlan(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.Guid)
An IComputeApiClient extension method that gets a VLAN.
> #####Parameters
> **client:** The object.

> **vlanId:** The id.

> #####Return value
> The vlan.

####DeployVlan(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Network20.DeployVlanType)
Deploys Virtual LAN on a network domain
> #####Parameters
> **client:** The compute client

> **vlan:** Virtual LAN

> #####Return value
> Operation status

####DeleteVlan(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
An IComputeApiClient extension method that deletes the vlan.
> #####Parameters
> **client:** The compute client.

> **id:** The id of the VLAN.

> #####Return value
> The job from the API;

##CBU.Compute.Api.Client.Network.NetworkAccessor
            
The networking legacy.
        
###Fields

####_apiClient
The Api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####CreateNetwork(System.String,System.String,System.String)
The create network.
> #####Parameters
> **networkName:** The network name.

> **dataCentreLocation:** The data centre location.

> **description:** The description.

> #####Return value
> The .

####GetNetworks
The get networks task.
> #####Return value
> The .

####GetNetworks(System.String)
The get networks task.
> #####Parameters
> **locationId:** The identifier of the location to get the networks from.

> #####Return value
> The .

####DeleteNetwork(System.String)
The delete network.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####ModifyNetwork(System.String,System.String,System.String)
The modify network.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **description:** The description.

> #####Return value
> The .

####GetNetworkConfig(System.String)
The get network config.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####GetNatRules(System.String)
The get nat rules.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####DeleteNatRule(System.String,System.String)
The delete nat rule.
> #####Parameters
> **networkId:** The network id.

> **natRuleId:** The nat rule id.

> #####Return value
> The .

####CreateNatRule(System.String,System.String,System.Net.IPAddress)
The create nat rule.
> #####Parameters
> **networkId:** The network id.

> **natRuleName:** The nat rule name.

> **sourceIp:** The source ip.

> #####Return value
> The .

####CreateAclRule(System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Network.AclActionType,DD.CBU.Compute.Api.Contracts.Network.AclProtocolType,DD.CBU.Compute.Api.Contracts.Network.PortRangeTypeType,System.Net.IPAddress,System.Net.IPAddress,System.Net.IPAddress,System.Net.IPAddress,System.Int32,System.Int32,DD.CBU.Compute.Api.Contracts.Network.AclType)
The create acl rule.
> #####Parameters
> **networkId:** The network id.

> **aclRuleName:** The acl rule name.

> **position:** The position.

> **action:** The action.

> **protocol:** The protocol.

> **portRangeType:** The port range type.

> **sourceIpAddress:** The source ip address.

> **sourceNetmask:** The source netmask.

> **destIpAddress:** The dest ip address.

> **destNetmask:** The dest netmask.

> **port1:** The port 1.

> **port2:** The port 2.

> **aclType:** The acl type.

> #####Return value
> The .
> #####Exceptions
> **System.ArgumentOutOfRangeException:** 


####GetAclRules(System.String)
The get acl rules.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####DeleteAclRule(System.String,System.String)
The delete acl rule.
> #####Parameters
> **networkId:** The network id.

> **aclRuleId:** The acl rule id.

> #####Return value
> The .

####ReserveNetworkPublicIpAddressBlock(System.String)
The reserve network public ip address block.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####ReleaseNetworkPublicIpAddressBlock(System.String,System.String)
The release network public ip address block.
> #####Parameters
> **networkId:** The network id.

> **ipBlockId:** The ip block id.

> #####Return value
> The .

####GetNetworkPublicIpAddressBlock(System.String)
The get network public ip address block.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####SetServertoVipNetworkPublicIpAddressBlock(System.String,System.String,System.Boolean)
The set serverto vip network public ip address block.
> #####Parameters
> **networkId:** The network id.

> **ipBlockId:** The ip block id.

> **enable:** The enable.

> #####Return value
> The .

####SetNetworkMulticast(System.String,System.Boolean)
The set network multicast.
> #####Parameters
> **networkId:** The network id.

> **enable:** The enable.

> #####Return value
> The .

##CBU.Compute.Api.Client.Network.NetworkingLegacyAccessor
            
A standard implementation of Network 2.0 access methods.
        
###Properties

####Network
Gets the network.
####NetworkVip
Gets the network vip.
###Methods


####Constructor
Initializes a new instance of the DD.CBU.Compute.Api.Client.Network20.Networking class.
> #####Parameters
> **apiClient:** The api Client.


##CBU.Compute.Api.Client.Network.NetworkVipAccessor
            
The vip.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetRealServers(System.String)
The get real servers.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreateRealServer(System.String,System.String,System.String,System.Boolean)
The create real server.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **serverId:** The server id.

> **inService:** The in service.

> #####Return value
> The .

####RemoveRealServer(System.String,System.String)
The remove real server.
> #####Parameters
> **networkId:** The network id.

> **realServerId:** The r server id.

> #####Return value
> The .

####ModifyRealServer(System.String,System.String,System.Boolean)
The modify real server.
> #####Parameters
> **networkId:** The network id.

> **rServerId:** The r server id.

> **inService:** The in service.

> #####Return value
> The .

####GetProbes(System.String)
The get probes.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreateProbe(System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ProbeType,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.ProbeRequestMethod,System.String,System.String)
The create probe.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **type:** The type.

> **port:** The port.

> **probeIntervalSeconds:** The probe interval seconds.

> **errorCountBeforeServerFail:** The error count before server fail.

> **successCountBeforeServerEnable:** The success count before server enable.

> **failedProbeIntervalSeconds:** The failed probe interval seconds.

> **maxReplyWaitSeconds:** The max reply wait seconds.

> **statusCodeLowerBound:** The status code lower bound.

> **statusCodeUpperBound:** The status code upper bound.

> **requestMethod:** The request method.

> **requestUrl:** The request url.

> **matchContent:** The match content.

> #####Return value
> The .

####ModifyProbe(System.String,System.String,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
The modify probe.
> #####Parameters
> **networkId:** The network id.

> **probeId:** The probe id.

> **probeIntervalSeconds:** The probe interval seconds.

> **errorCountBeforeServerFail:** The error count before server fail.

> **successCountBeforeServerEnable:** The success count before server enable.

> **failedProbeIntervalSeconds:** The failed probe interval seconds.

> **maxReplyWaitSeconds:** The max reply wait seconds.

> #####Return value
> The .

####RemoveProbe(System.String,System.String)
The remove probe.
> #####Parameters
> **networkId:** The network id.

> **probeId:** The probe id.

> #####Return value
> The .

####GetServerFarms(System.String)
The get server farms.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####GetServerFarmDetails(System.String,System.String)
The get server farm details.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> #####Return value
> The .

####CreateServerFarm(System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ServerFarmPredictorType,System.String,System.Int32,System.String)
The create server farm.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **predictor:** The predictor.

> **rServerId:** The r server id.

> **rServerPort:** The r server port.

> **probeId:** The probe id.

> #####Return value
> The .

####RemoveServerFarm(System.String,System.String)
The remove server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> #####Return value
> The .

####ModifyServerFarm(System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ServerFarmPredictorType)
The modify server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **predictor:** The predictor.

> #####Return value
> The .

####AddRealServerToServerFarm(System.String,System.String,System.String,System.Int32)
The add real server to server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **realServerId:** The real server id.

> **realServerPort:** The real server port.

> #####Return value
> The .

####RemoveRealServerFromServerFarm(System.String,System.String,System.String,System.Int32)
The remove real server from server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **realServerId:** The real server id.

> **realServerPort:** The real server port.

> #####Return value
> The .

####AddProbeToServerFarm(System.String,System.String,System.String)
The add probe to server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **probeId:** The probe id.

> #####Return value
> The .

####RemoveProbeFromServerFarm(System.String,System.String,System.String)
The remove probe from server farm.
> #####Parameters
> **networkId:** The network id.

> **serverFarmId:** The server farm id.

> **probeId:** The probe id.

> #####Return value
> The .

####GetPersistenceProfile(System.String)
The get persistence profile.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreatePersistenceProfileIpNetmask(System.String,System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.PersistenceProfileDirection,System.String)
The create persistence profile ip netmask.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **serverFarmId:** The server farm id.

> **timeOutMinutes:** The time out minutes.

> **direction:** The direction.

> **netmask:** The netmask.

> #####Return value
> The .

####CreatePersistenceProfileHttpCookie(System.String,System.String,System.String,System.Int32,System.String,DD.CBU.Compute.Api.Contracts.Vip.PersistenceProfileCookieType)
The create persistence profile http cookie.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **serverFarmId:** The server farm id.

> **timeOutMinutes:** The time out minutes.

> **cookieName:** The cookie name.

> **cookieType:** The cookie type.

> #####Return value
> The .

####RemovePersistenceProfile(System.String,System.String)
The remove persistence profile.
> #####Parameters
> **networkId:** The network id.

> **persistenceProfileId:** The pers profile id.

> #####Return value
> The .

####GetVips(System.String)
The get vips.
> #####Parameters
> **networkId:** The network id.

> #####Return value
> The .

####CreateVip(System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.VipProtocol,DD.CBU.Compute.Api.Contracts.Vip.VipTargetType,System.String,System.Boolean,System.Boolean,System.String)
The create vip.
> #####Parameters
> **networkId:** The network id.

> **name:** The name.

> **port:** The port.

> **protocol:** The protocol.

> **targetType:** The target type.

> **targetId:** The target id.

> **replyToIcmp:** The reply to icmp.

> **inService:** The in service.

> **ipAddress:** The ip address.

> #####Return value
> The .

####RemoveVip(System.String,System.String)
The remove vip.
> #####Parameters
> **networkId:** The network id.

> **vipId:** The vip id.

> #####Return value
> The .

####ModifyVip(System.String,System.String,System.Boolean,System.Boolean)
The modify vip.
> #####Parameters
> **networkId:** The network id.

> **vipId:** The vip id.

> **replyToIcmp:** The reply to icmp.

> **inService:** The in service.

> #####Return value
> The .

##CBU.Compute.Api.Client.Network.ComputeApiClientNetworkExtensions
            
Extension methods for the Network section of the CaaS API.
        
###Methods


####CreateNetwork(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String)
Deploys a new network in a designated data center location. The designated data center must be chosen from your available data centers list (See "List Data Centers (With Parameters)"). The "location" property of the data center is used to identify it for network creation. The "name" property must be unique within your organization.
> #####Parameters
> **client:** The object.

> **networkName:** A unique network name for the new network.

> **dataCentreLocation:** The data centre location.

> **description:** Optional. A decription for the network.

> #####Return value
> A status of the response.

####GetNetworksTask(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient)
Gets the networks with locations
> #####Parameters
> **client:** The object.

> #####Return value
> The networks

####DeleteNetwork(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Retrieves the details of a specific network owned by a customer. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to delete.

> #####Return value
> A status of the response.

####ModifyNetwork(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String)
Modify the details of a specific network owned by a customer. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to modify.

> **name:** The new network name.

> **description:** The new network description.

> #####Return value
> A status of the response.

####GetNetworkConfig(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Retrieves the details of a specific network owned by a customer. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to delete.

> #####Return value
> A NetworkConfigurationType of the response.

####GetNatRules(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Retrieves a list of NAT rules for a specified network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The target network id.

> #####Return value
> The status of the operation.

####DeleteNatRule(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Deletes an existing NAT rule for a specified network. This API requires your organization ID, the ID of the target network and the ID of the NAT rule to be deleted.
> #####Parameters
> **client:** The object.

> **networkId:** The target network id.

> **natRuleId:** The NAT rule id to delete.

> #####Return value
> The status of the operation.

####CreateNatRule(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Net.IPAddress)
The create nat rule.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **natRuleName:** The nat rule name.

> **sourceIp:** The source ip.

> #####Return value
> The .

####GetAclRules(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Retrieves the list of ACL rules associated with a network. This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object

> **networkId:** The target network id

> #####Return value
> The ACL rules.

####DeleteAclRule(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Deletes a specified ACL rule. This API requires your organization ID, the ID of the target network and the ID of the rule. Note: If the Cisco hardware is under heavy load when a Delete ACL Rule request is processed it is possible for a timeout to occur. In this situation the ACL rule deletion usually completes successfully but an error code REASON_292 will be returned to indicate that the ACL rule is in a pending state and a support case should be opened for it to be removed.
> #####Parameters
> **client:** The object.

> **networkId:** The target network id.

> **aclRuleId:** The ACL rule to delete.

> #####Return value
> The status of the operation.

####CreateAclRule(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Network.AclActionType,DD.CBU.Compute.Api.Contracts.Network.AclProtocolType,DD.CBU.Compute.Api.Contracts.Network.PortRangeTypeType,System.Net.IPAddress,System.Net.IPAddress,System.Net.IPAddress,System.Net.IPAddress,System.Int32,System.Int32,DD.CBU.Compute.Api.Contracts.Network.AclType)
The create acl rule.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **aclRuleName:** The acl rule name.

> **position:** The position.

> **action:** The action.

> **protocol:** The protocol.

> **portRangeType:** The port range type.

> **sourceIpAddress:** The source ip address.

> **sourceNetmask:** The source netmask.

> **destIpAddress:** The dest ip address.

> **destNetmask:** The dest netmask.

> **port1:** The port 1.

> **port2:** The port 2.

> **aclType:** The acl type.

> #####Return value
> The .
> #####Exceptions
> **System.ArgumentOutOfRangeException:** 


####ReserveNetworkPublicIpAddressBlock(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Reserves a public Ip address block for the network This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to delete.

> #####Return value
> A Status of the response.

####ReleaseNetworkPublicIpAddressBlock(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Releases a public Ip address block for the network This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to add the block.

> **ipBlockId:** The public ip address block id

> #####Return value
> A Status of the response.

####GetNetworkPublicIpAddressBlock(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
List the public Ip address blocks from a network This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to add the block.

> #####Return value
> A Status of the response.

####SetServertoVipNetworkPublicIpAddressBlock(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Boolean)
Set the server to VIP connectivity on a public Ip address block for the network This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id to add the block.

> **ipBlockId:** The public ip address block id

> **enable:** The setting of the Server to VIP on ip address block

> #####Return value
> A Status of the response.

####SetNetworkMulticast(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.Boolean)
Set Multicast for the network This API requires your organization ID and the ID of the target network.
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **enable:** The setting for multicast on network

> #####Return value
> A Status of the response.

##CBU.Compute.Api.Client.Server20.MonitoringAccessor
            
The server monitoring accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####EnableServerMonitoring(DD.CBU.Compute.Api.Contracts.Network20.EnableServerMonitoringType)
Enables server monitoring.
> #####Parameters
> **enableServerMonitoring:** The monitoring settings.

> #####Return value
> The status response

####ChangeServerMonitoringPlan(DD.CBU.Compute.Api.Contracts.Network20.ChangeServerMonitoringPlanType)
Changes the service plan.
> #####Parameters
> **changeServerMonitoringPlan:** The monitoring settings.

> #####Return value
> The status response

####DisableServerMonitoring(System.Guid)
Disables server monitoring.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The status response

####GetMonitoringUsageReport(System.DateTime,System.Nullable{System.DateTime})
Gets the monitoring usage report.
> #####Parameters
> **startDate:** The start date.

> **endDate:** The end date.

> #####Return value
> The usage report as CSV.

##CBU.Compute.Api.Client.Server20.Server20Extensions
            
A server 2.0 extensions methods.
        
###Methods


####GetMcp2DeployedServers(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.PageableRequest)
Gets MCP 2 deployed servers.
> #####Parameters
> **client:** The object.

> **options:** The options.

> **pagingOptions:** The paging Options.

> #####Return value
> The MCP 2 deployed servers.

####GetMcp2DeployedServer(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.Guid)
Anthony, 6/17/2015.
Gets MCP 2 deployed servers.
> #####Parameters
> **client:** The object.

> **serverId:** Identifier for the server.

> #####Return value
> The MCP 2 deployed servers.

##CBU.Compute.Api.Client.Server20.AntiAffinityRuleAccessor
            
The server 2.0 accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetAntiAffinityRulesPaginated(DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForServer(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions)
Gets the available anti affinity rules for a specific server.
> #####Parameters
> **serverId:** The server id.

> **filteringOptions:** The filtering options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForServerPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules for a specific server.
> #####Parameters
> **serverId:** The server id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetwork(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions)
Gets the available anti affinity rules for a specific network.
> #####Parameters
> **networkId:** The network id.

> **filteringOptions:** The filtering options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetworkPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules for a specific network.
> #####Parameters
> **networkId:** The network id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetworkDomain(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions)
Gets the available anti affinity rules for a specific network domain.
> #####Parameters
> **networkDomainId:** The network domain id.

> **filteringOptions:** The filtering options.

> #####Return value
> Collection of .

####GetAntiAffinityRulesForNetworkDomainPaginated(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Gets the available anti affinity rules for a specific network domain.
> #####Parameters
> **networkDomainId:** The network domain id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> Collection of .

##CBU.Compute.Api.Client.Server20.ServerImageAccessor
            
The server 2.0 image accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetOsImage(System.Guid)
Get OS Image
> #####Parameters
> **imageId:** Image Identifier

> #####Return value
> OS Image

####GetOsImages(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerOsImageListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Get OS Images
> #####Parameters
> **filteringOptions:** Filtering options

> #####Return value
> OS Images

####GetCustomerImage(System.Guid)
Get Customer Image
> #####Parameters
> **imageId:** Image Id

> #####Return value
> Customer Image

####GetCustomerImages(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerCustomerImageListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
Get Customer Images
> #####Parameters
> **filteringOptions:** Filtering options

> **pagingOptions:** Paging options

> #####Return value
> Customer Images

####EditCustomerImageMetadata(DD.CBU.Compute.Api.Contracts.Network20.ImageMetadataType)
Edit Customer Image Metadata
> #####Parameters
> **imageMetadata:** Image Metadata

> #####Return value
> Response Data

##CBU.Compute.Api.Client.Server20.ServerAccessor
            
The server 2.0 accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetMcp2DeployedServers(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get mcp 2 deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetServers(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions)
The get mcp 2 deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> #####Return value
> The .

####GetServersPaginated(DD.CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get mcp 2 deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####GetMcp2DeployedServer(System.Guid)
The get mcp 2 deployed server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####GetServer(System.Guid)
The get mcp 2 deployed server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####DeleteServer(System.Guid)
Deletes the server described by serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####StartServer(System.Guid)
Starts a server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####ShutdownServer(System.Guid)
Shutdown server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####RebootServer(System.Guid)
Reboot server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####ResetServer(System.Guid)
Resets the server described by serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####PowerOffServer(System.Guid)
Power off server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####UpdateVmwareTools(System.Guid)
Updates the v mware tools described by serverId.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####UpgradeVirtualHardware(System.Guid)
Upgrade virtual hardware for the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response.

####DeployServer(DD.CBU.Compute.Api.Contracts.Network20.DeployServerType)
Deploys a server to MCP1.0 or MCP 2.0 data centers
> #####Parameters
> **serverDetails:** Details of the server to be deployed

> #####Return value
> Response containing the server id

####CleanServer(System.Guid)
Cleans a failed server deployment.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> A standard CaaS response

####AddNic(System.Guid,System.Nullable{System.Guid},System.String,System.String)
Adds an additional NIC to a server.
> #####Parameters
> **serverId:** The server id.

> **vlanId:** The VLAN id

> **privateIpv4:** The Private IP v4 address

> **networkAdapter:** The optional network adapter type (E1000 or VMXNET3)

> #####Return value
> The .

####RemoveNic(System.Guid)
Removes an additional NIC from a server.
> #####Parameters
> **nicId:** The NIC id.

> #####Return value
> The .

####ListNics(System.Guid,DD.CBU.Compute.Api.Contracts.Requests.Server20.ListNicsOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The list nics.
> #####Parameters
> **vlanId:** The vlan id.

> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####NotifyNicIpChange(DD.CBU.Compute.Api.Contracts.Network20.NotifyNicIpChangeType)
Updates the Cloud record to match the value set on the deployed server.
> #####Parameters
> **notifyNicIpChange:** The Notify NIC IP change model.

> #####Return value
> The async type of

####EditServerMetadata(DD.CBU.Compute.Api.Contracts.Network20.editServerMetadata)
Edit metadata of the server
> #####Parameters
> **editServerMetadata:** Server metadata change model.

> #####Return value
> The async type of

####ReconfigureServer(DD.CBU.Compute.Api.Contracts.Network20.ReconfigureServerType)
Updates compute resource properties of a Server
> #####Parameters
> **reconfigureServer:** Details of the server to be updated

> #####Return value
> A standard CaaS response

####AddDisk(DD.CBU.Compute.Api.Contracts.Network20.AddDiskType)
The add disk.
> #####Parameters
> **addDisk:** The add disk.

> #####Return value
> The .

####RemoveDisk(DD.CBU.Compute.Api.Contracts.Network20.RemoveDiskType)
The remove disk.
> #####Parameters
> **removeDisk:** The remove disk.

> #####Return value
> The .

##CBU.Compute.Api.Client.Server20.ServerManagementAccessor
            
The server management accessor.
        
###Properties

####Server
Gets the Server Accessor.
####ServerImage
Gets the Server Images Accessor
####AntiAffinityRule
Gets the Anti Affinity Rule Accessor.
####Monitoring
Gets the Monitoring Accessor.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **webApi:** The webapi.


##CBU.Compute.Api.Client.Reports.ReportAccessor
            
The Report type.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetSummaryUsage(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report of the sum total usage across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetDetailedUsageReport(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report by the specifics of all usage across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetSoftwareUnitsUsageReport(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report by identifying the software unit calculation specifics for any Priced Software on virtual servers across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetBackupUsageReport(System.String,System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report by identifying the specifics of all Backup usage across the account.
> #####Parameters
> **datacenterId:** The datacenter Id

> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetAdministratorLogsReport(System.DateTime,System.DateTime)
Retrieves a CSV-formatted daily usage report of the administrator actions taken across the account.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

####GetDrsPairsUsageReport(System.DateTime,System.DateTime)
Returns a report detailing the DRS server pairs that were in existance for the supplied organizationId during the specified date range.
> #####Parameters
> **startDate:** The Start Date

> **endDate:** The End Date

> #####Return value
> The CSV formatted result

##CBU.Compute.Api.Client.ServerImageType
            
The server image type.
        
###Fields

####OS
The os.
####CUSTOMER
The customer.

##CBU.Compute.Api.Client.ImportExportImages.ImportExportCustomerImageAccessor
            
The import export customer image accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetOvfPackages
The get ovf packages.
> #####Return value
> The .

####GetCustomerImagesImports
The get customer images imports.
> #####Return value
> The .

####GetCustomerImagesExports
The get customer images exports.
> #####Return value
> The .

####GetCustomerImagesExportHistory(System.Int32)
The get customer images export history.
> #####Parameters
> **count:** The count.

> #####Return value
> The .

####ImportCustomerImage(System.String,System.String,System.String,System.String)
The import customer image.
> #####Parameters
> **customerImageName:** The customer image name.

> **ovfPackageName:** The ovf package name.

> **networkLocation:** The network location.

> **description:** The description.

> #####Return value
> The .

####ExportCustomerImage(DD.CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImage,System.String)
The export customer image.
> #####Parameters
> **image:** The image.

> **ovfPrefix:** The ovf prefix.

> #####Return value
> The .

####ExportCustomerImage(System.String,System.String)
The export customer image.
> #####Parameters
> **imageId:** The image id.

> **ovfPrefix:** The ovf prefix.

> #####Return value
> The .
> #####Exceptions
> **System.NotImplementedException:** 


####CopyOvfPackageFromRemoteGeo(DD.CBU.Compute.Api.Contracts.Image.NewRemoteOvfCopy)
Copies an OVF package from a remote geo.
> #####Parameters
> **newRemoteOvfCopy:** The copy request.

> #####Return value
> The .

####GetRemoteOvfPackageCopyInProgress
Gets OVF package copies currently in progress.
> #####Return value
> The .

####GetRemoteOvfPackageCopyHistory(System.Int32)
Gets OVF package copy history.
> #####Parameters
> **count:** The count.

> #####Return value
> The .

##CBU.Compute.Api.Client.ImportExportImages.ComputeApiClientImportExportExtensions
            
Extension methods for the "import and export of customer images" section of the CaaS API.
        
###Methods


####GetOvfPackages(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient)
Gets the OVF Packages that have been uploaded to the FTPS account for the supplied organization ID. An empty list will be returned if no OVF Packages have been uploaded by the organization.
> #####Parameters
> **client:** The object

> #####Return value
> The OVF Packages

####GetCustomerImagesImports(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient)
This function identifies the Customer Image Imports that are in progress for the supplied organization ID.
> #####Parameters
> **client:** The object

> #####Return value
> The customer image imports currently in progress

####GetCustomerImagesExports(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient)
This function identifies the Customer Image Exports that are in progress for the supplied organization ID.
> #####Parameters
> **client:** The object

> #####Return value
> The customer image exports currently in progress

####GetCustomerImagesExportHistory(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.Int32)
This function identifies the Customer Image Export history for the supplied organization ID.
> #####Parameters
> **client:** The object

> **count:** The count.

> #####Return value
> The customer image exports

####ImportCustomerImage(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String,System.String)
Starts the process of importing an OVF Package to become a new Customer Image for the supplied organization ID. This function takes the full name (including the “.mf” file suffix) of the manifest file identifying the OVF Package to import as a new Customer Image.
> #####Parameters
> **client:** The object

> **customerImageName:** 1-75 characters in length. The permitted character set is (within and excluding the quotes): “a-zA-Z0-9_+=# .,:;()-“. Note that the “space” character is permitted

> **ovfPackageName:** References a manifest identifying an OVF Package on the organization’s FTPS account. Maximum length 75 characters. The permitted character set is (within and excluding the quotes): “a-zA-Z0-9_+=#.,:;()-“. Note that the “space” character is not permitted

> **networkLocation:** Identifies the target data center location for the Customer Image. The target data center must reside within the same Geographic Region

> **description:** 0-255 characters in length.

> #####Return value
> Returns the ServerImageWithState object

####ExportCustomerImage(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,DD.CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImage,System.String)
Exports the customer image to the FTPS store
> #####Parameters
> **client:** The object

> **image:** The image to export.

> **ovfPrefix:** Required; 1-90 characters in length. Used to name each of the constituent files of the resulting OVF Package. The permitted character set is (within and excluding the quotes): “a-zA-Z0-9_+=#.,:;()-“. Note that the “space” character is not permitted.

> #####Return value
> The image export record, with the target names.

##CBU.Compute.Api.Client.Server.ServerAccessor
            
The server accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetDeployedServers(System.String,System.String,System.String,System.String)
The get deployed servers.
> #####Parameters
> **serverId:** The server Id.

> **name:** The name.

> **networkId:** The network id.

> **location:** The location.

> #####Return value
> The .

####GetDeployedServers(DD.CBU.Compute.Api.Contracts.Requests.Server.ServerListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get deployed servers.
> #####Parameters
> **filteringOptions:** The filtering options.

> **pagingOptions:** The paging options.

> #####Return value
> The .

####ModifyServer(System.String,System.String,System.String,System.Int32,System.Int32,System.String)
The modify server.
> #####Parameters
> **serverId:** The server id.

> **name:** The name.

> **description:** The description.

> **memory:** The memory.

> **cpucount:** The CPU count.

> **privateIp:** The private IP.

> #####Return value
> The .

####ServerPowerOn(System.String)
Powers on the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerPowerOff(System.String)
Powers off the server.
> #####Parameters
> **serverId:** Server Id

> #####Return value
> The .

####ServerRestart(System.String)
Restart the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerReset(System.String)
Power cycles an existing deployed server. This is the equivalent of pulling and replacing the power cord for a physical server. Requires your organization ID and the ID of the target server..
> #####Parameters
> **serverId:** The server id.

> #####Return value
> Returns a status of the HTTP request

####ServerShutdown(System.String)
Shutdown the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ChangeServerDiskSize(System.String,System.String,System.String)
Modify server disk size.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> **sizeInGb:** Size In GB.

> #####Return value
> The status of the deployment.

####ChangeServerDiskSpeed(System.String,System.String,System.String)
Modify server disk speed.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> **speedId:** Size in GB.

> #####Return value
> The status of the deployment.

####AddServerDisk(System.String,System.String,System.String)
Add Disk to Server
> #####Parameters
> **serverId:** The server id

> **size:** The size of the new disk

> **speedId:** The speed Id.

> #####Return value
> The .

####RemoveServerDisk(System.String,System.String)
Modify server server settings.
> #####Parameters
> **serverId:** The server id.

> **diskId:** The SCSI disk Id.

> #####Return value
> The status of the deployment.

####ServerUpdateVMwareTools(System.String)
Triggers an update of the VMWare Tools software running on the guest OS of a virtual server
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerDelete(System.String)
Delete the server.
> #####Parameters
> **serverId:** The server id.

> #####Return value
> The .

####ServerCloneToCustomerImage(System.String,System.String,System.String)
Initiates a clone of a server to create a Customer Image
> #####Parameters
> **serverId:** The server id.

> **imageName:** The customer image name.

> **imageDesc:** The customer image description.

> #####Return value
> The .

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,Disk[])
Deploy a server using an image in a specified network.
> #####Parameters
> **name:** The name of the new server.

> **description:** The description of the new server.

> **networkId:** The network id to deploy the server.

> **privateIp:** The privateIp address to deploy the server.

> **imageId:** The image id to deploy the server.

> **adminPassword:** The administrator password.

> **start:** Will the server powers on after deployment?

> **disk:** Array od disk configurations

> #####Return value
> The status of the deployment.

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean)
The deploy server with disk speed image task.
> #####Parameters
> **name:** The name.

> **description:** The description.

> **networkId:** The network id.

> **privateIp:** The private ip.

> **imageId:** The image id.

> **adminPassword:** The admin password.

> **start:** The start.

> #####Return value
> The .

####CreateServerAntiAffinityRule(System.String,System.String)
Creates a new Server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **serverId1:** The server Id for the 1'st server

> **serverId2:** The server Id for the 2'nd server

> #####Return value
> The .

####GetServerAntiAffinityRules(System.String,System.String,System.String)
List all Server Anti-Affinity Rules
> #####Parameters
> **ruleId:** Filter by rule Id

> **location:** Filter by location

> **networkId:** Filter by network Id

> #####Return value
> The .

####RemoveServerAntiAffinityRule(System.String)
Remove a server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **ruleId:** The ruleId

> #####Return value
> The .

####NotifyPrivateIpChange(System.String,System.String)
The notify system private IP address change.
> #####Parameters
> **serverId:** The server id.

> **privateIpV4:** The Private IP v4.

> #####Return value
> The .

##CBU.Compute.Api.Client.Server.ServerImagesAccessor
            
The server images accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####GetImages(System.String,System.String,System.String,System.String,System.String)
The get images.
> #####Parameters
> **imageId:** The image id.

> **name:** The name.

> **location:** The location.

> **operatingSystemId:** The operating system id.

> **operatingSystemFamily:** The operating system family.

> #####Return value
> The .

####GetCustomerServerImages(System.String,System.String,System.String,System.String,System.String)
The get customer server images.
> #####Parameters
> **imageId:** The image id.

> **name:** The name.

> **location:** The location.

> **operatingSystemId:** The operating system id.

> **operatingSystemFamily:** The operating system family.

> #####Return value
> The .

####CopyCustomerServerImage(System.String,System.String,System.String,System.String,System.String)
The copy customer image
> #####Parameters
> **imageId:** The source image id.

> **targetImageName:** Target Image Name

> **targetImageDescription:** Target Image Description

> **targetLocation:** Target Location

> **ovfPackagePrefix:** OVF Package Prefix

> #####Return value
> The .

####GetCustomerServerImageBeingCopied
Returns all the customer images being copied.
> #####Return value
> list of images being copied

####RemoveCustomerServerImage(System.String)
The remove customer server image.
> #####Parameters
> **imageId:** The image Id.

> #####Return value
> The .

####CleanFailedCustomerServerImage(System.String)
The clean failed customer server image.
> #####Parameters
> **imageId:** The image id.

> #####Return value
> The .

##CBU.Compute.Api.Client.Server.ServerManagementLegacyAccessor
            
The server legacy accessor.
        
###Properties

####Server
Gets the server.
####ServerImage
Gets the server image.
###Methods


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


##CBU.Compute.Api.Client.StatusExtensions
            
The status extensions.
        
###Methods


####IsSuccessful(DD.CBU.Compute.Api.Contracts.General.Status)
The Status extension method that query if 'status' is successful.
> #####Parameters
> **status:** The status to act on.

> #####Return value
> true if successful, false if not.

##CBU.Compute.Api.Client.Tagging.TaggingAccessor
            
The tagging accessor.
        
###Fields

####_apiClient
The _api client.
###Methods


####Constructor
Initializes a new instance of the class.
> #####Parameters
> **apiClient:** The api client.


####CreateTagKey(DD.CBU.Compute.Api.Contracts.Network20.createTagKeyType)
The create tag key.
> #####Parameters
> **createTagKey:** The create tag key.

> #####Return value
> The .

####GetTagKeys(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagKeyListOptions)
The get tag keys.
> #####Parameters
> **tagKeyListOptions:** The tag key list options.

> #####Return value
> The .

####GetTagKeysPaginated(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagKeyListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get tag keys paginated.
> #####Parameters
> **tagKeyListOptions:** The tag key list options.

> **paginngOptions:** The paginng options.

> #####Return value
> The .

####GetTagKey(System.Guid)
The get tag key.
> #####Parameters
> **tagKeyId:** The tag key id.

> #####Return value
> The .

####EditTagKey(DD.CBU.Compute.Api.Contracts.Network20.EditTagKeyType)
The edit tag key.
> #####Parameters
> **editTagKey:** The edit tag key.

> #####Return value
> The .

####DeleteTagKey(DD.CBU.Compute.Api.Contracts.Network20.deleteTagKeyType)
The delete tag key.
> #####Parameters
> **deleteTagKey:** The delete tag key.

> #####Return value
> The .

####ApplyTags(DD.CBU.Compute.Api.Contracts.Network20.applyTags)
The apply tags.
> #####Parameters
> **applyTags:** The apply tags.

> #####Return value
> The .

####GetTags(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagListOptions)
The get tags.
> #####Parameters
> **tagListOptions:** The tag list options.

> #####Return value
> The .

####GetTagsPaginated(DD.CBU.Compute.Api.Contracts.Requests.Tagging.TagListOptions,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest)
The get tags paginated.
> #####Parameters
> **tagListOptions:** The tag list options.

> **paginngOptions:** The paginng options.

> #####Return value
> The .

####RemoveTags(DD.CBU.Compute.Api.Contracts.Network20.RemoveTagsType)
The remove tags.
> #####Parameters
> **removeTags:** The remove tags.

> #####Return value
> The .

##CBU.Compute.Api.Client.Utilities.PageableRequestExtensions
            
Provides utility methods to append paging options to URIs.
        
###Methods


####AppendToUri(DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,System.Uri)
Appends query parameters for the supplied paging options to the supplied URI.
> #####Parameters
> **uri:** The URI to append the paging parameters to.

> **pagingOptions:** The paging options.

> #####Return value
> The URI with the paging parameters.

##CBU.Compute.Api.Client.Utilities.FilterableRequestExtensions
            
Provides utility methods to append filtering options to URIs.
        
###Methods


####AppendToUri(DD.CBU.Compute.Api.Contracts.Requests.IFilterableRequest,System.Uri)
Appends query parameters for the supplied list options object to the supplied URI.
> #####Parameters
> **uri:** The URI to append the filter parameters to.

> **filterableRequest:** The filtering options.

> #####Return value
> The URI with the filter parameters.

##CBU.Compute.Api.Client.Utilities.DisposableObject
            
Base class for disposable objects.
        
###Fields

####_isDisposed
Has the object been disposed?
###Properties

####IsDisposed
Has the object been disposed?
###Methods


####Dispose
Dispose of resources being used by the disposable object.

####Finalize
Finalises an instance of the class. Finaliser for .

####Dispose(System.Boolean)
Dispose of resources being used by the disposable object.
> #####Parameters
> **disposing:** Explicit disposal?


####CheckDisposed
Check if the object has been disposed.
> #####Exceptions
> **System.ObjectDisposedException:** The object has been disposed.


##CBU.Compute.Api.Client.ComputeApiClient
            
A client for the Dimension Data Compute-as-a-Service (CaaS) API.
        
###Fields

####_httpClientHandler
The _http client handler.
###Properties

####WebApi
Access to the web API for login/logout and account info
####Account
Gets the account.
####Infrastructure
Infrastructure accessor
####Networking
Gets the networking 2.0 methods. The networking.
####NetworkingLegacy
Gets the networking legacy 1.0 methods
####ServerManagementLegacy
Gets the server legacy.
####ServerManagement
Gets the server management.
####ImportExportCustomerImage
Gets or sets the import export customer image.
####Backup
Gets the backup.
####Reports
Gets the Reports
####Tagging
Gets the tagging.
####ConsistencyGroups
Gets the Consistency Groups.
###Methods


####Constructor
Initialises a new instance of the class. Create a new Compute-as-a-Service API client.
> #####Parameters
> **targetRegionName:** The name of the region whose CaaS API end-point is targeted by the client.


####Constructor
Initialises a new instance of the class. Creates a new CaaS API client using a base URI.
> #####Parameters
> **baseUri:** The base URI to use for the CaaS API.


####Constructor
Initialises a new instance of the class. Creates a new CaaS API client using a known vendor and region.
> #####Parameters
> **vendor:** The vendor

> **region:** The region


####Constructor
Initialises a new instance of the class. Creates a new CaaS API client using a Dimension Data vendor and known region.
> #####Parameters
> **region:** The region


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **httpClient:** The http client.

> **organizationId:** The organization id.

> #####Exceptions
> **System.ArgumentNullException:** 


####InitializeProperties(DD.CBU.Compute.Api.Client.Interfaces.IHttpClient,System.Guid)
The initialize properties.
> #####Parameters
> **httpClient:** The http client.

> **organizationId:** The organization Id.


####GetComputeApiClient(System.Uri,System.Net.ICredentials,System.Guid)
The get compute api client.
> #####Parameters
> **baseUri:** The base uri.

> **credentials:** The credentials.

> **organizationId:** The organization id.

> #####Return value
> The .
> #####Exceptions
> **System.ArgumentNullException:** 

> **System.ArgumentException:** 


####GetComputeApiClient(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion,System.Net.ICredentials,System.Guid)
Initialises a new instance of the class. Creates a new CaaS API client using a known vendor and region.
> #####Parameters
> **vendor:** The vendor

> **region:** The region

> **credentials:** The credentials.

> **organizationId:** The organization Id.

> #####Return value
> The .

####GetComputeApiClient(DD.CBU.Compute.Api.Client.KnownApiRegion,System.Net.ICredentials,System.Guid)
Initialises a new instance of the class. Creates a new CaaS API client using a Dimension Data vendor and known region.
> #####Parameters
> **region:** The region

> **credentials:** The credentials.

> **organizationId:** The organization Id.

> #####Return value
> The .

####Login
The login async.
> #####Return value
> The .

####GetFtpHost(DD.CBU.Compute.Api.Client.KnownApiVendor,DD.CBU.Compute.Api.Client.KnownApiRegion)
The get ftp host.
> #####Parameters
> **vendor:** The vendor.

> **region:** The region.

> #####Return value
> The .

####GetListOfMultiGeographyRegionsFromHomeRegion(DD.CBU.Compute.Api.Client.KnownApiVendor,System.Net.ICredentials)
The discover home multi geo.
> #####Parameters
> **vendor:** The vendor.

> **credential:** The credential.

> #####Return value
> The .
> #####Exceptions
> **System.Exception:** 


####Dispose(System.Boolean)
Dispose of resources being used by the CaaS API client.
> #####Parameters
> **disposing:** Explicit disposal?


####DiscoverHomeMultiGeo(DD.CBU.Compute.Api.Client.KnownApiVendor,System.Net.ICredentials)
Since MultiGeo call is only valid for the home geo, use this method to discover what is your home geo and the applicable regions for this user. This is a multithreaded call that uses the underlying ComputeApiClient.GetListOfMultiGeographyRegions() to discover the home geo and multi geo for this user to all API endpoints known for vendor. Note: Most of the user vendor is DimensionData. Use this if you have to guess which vendor the user is under.
> #####Parameters
> **vendor:** The vendor of the user

> **credential:** Credential of the user

> #####Return value
> The .

####DesignatePrimaryAdministratorAccount(System.String)
Allows the current Primary Administrator user to designate a Sub-Administrator user belonging to the same organization to become the Primary Administrator for the organization. The Sub-Administrator is identified by their .
> #####Parameters
> **username:** The Sub-Administrator account.

> #####Return value
> A result that describes whether or not the operation was successful.

####GetDataCentersWithMaintenanceStatuses
This function identifies the list of data center 's available to the organization of the authenticating user.
> #####Return value
> The list of data center 's associated with the organization.

####GetListOfSoftwareLabels
Gets a list of software labels
> #####Return value
> The .

####GetListOfMultiGeographyRegions
Returns a list of the Multi-Geography Regions available for the supplied {org-id An element is returned for each available Geographic Region.
> #####Return value
> A list of regions associated with the org ID.

####DeleteSubAdministratorAccount(System.String)
Allows the current Primary Administrator user to designate a Sub-Administrator user belonging to the same organization to become the Primary Administrator for the organization. The Sub-Administrator is identified by their .
> #####Parameters
> **username:** The Sub-Administrator account.

> #####Return value
> A result that describes whether or not the operation was successful.

####GetAdministratorAccount(System.String)
Used to retrieve full details of an Administrator account associated with the Organization identified by {org Id}. The Sub-Administrator is identified by their .
> #####Parameters
> **username:** The Administrator or sub-administrator account.

> #####Return value
> A result that describes whether or not the operation was successful.

####GetAccounts
Lists the Accounts belonging to the Organization identified by the organisation. The list will include all SubAdministrator accounts and the Primary Administrator account. The Primary Administrator is unique and is identified by the “primary administrator” role.
> #####Return value
> A list of accounts associated with the organisation.

####AddSubAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
Adds a new Sub-Administrator Account to the organization. The account is created with a set of roles defining the level of access to the organization’s Cloud resources or the account can be created as “read only”, restricted to just viewing Cloud resources and unable to generate Cloud Reports.
> #####Parameters
> **account:** The account that will be added to the org.

> #####Return value
> A object instance that shows the results of the operation.

####UpdateAdministratorAccount(DD.CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber)
This function updates an existing Administrator Account.
> #####Parameters
> **account:** The account to be updated.

> #####Return value
> A object instance that shows the results of the operation.

####GetCustomerServerImages(System.String,System.String,System.String,System.String,System.String)
Get customer server images
> #####Parameters
> **imageId:** The image Id.

> **name:** The name filter

> **location:** The location filter

> **operatingSystemId:** The OS id

> **operatingSystemFamily:** The OS family

> #####Return value
> The .

####GetImages(System.String)
Get a list of all system-defined images (with software labels) deployed in the specified data centre.
> #####Parameters
> **locationName:** The short name of the location in which the data centre is located.

> #####Return value
> A read-only list , sorted by UTC creation date / time, representing the images.

####GetCustomerServerImages(System.String)
This function lists the available Customer Images at a particular Location for the provided org-id. The response adds to the deprecated List Deployed Customer Images in Location function with the addition of zero to many, optional softwareLabel elements, listing the Priced Software packages installed on the Customer Image.
> #####Parameters
> **networkLocation:** The network location

> #####Return value
> A list of deployed customer images with software labels in location

####GetAvailableDataCenters
Asynchronously get a list of all CaaS data centres that are available for use by the specified organisation.
> #####Return value
> A read-only list of s representing the data centre information.

####RemoveCustomerServerImage(System.String)
Remove customer server images
> #####Parameters
> **imageId:** The ImageId

> #####Return value
> The .RemoveCustomerServerImage

####DeployServerImageTask(System.String,System.String,System.String,System.String,System.String,System.Boolean)
The deploy server image task.
> #####Parameters
> **name:** The name.

> **description:** The description.

> **networkId:** The network id.

> **imageId:** The image id.

> **adminPassword:** The admin password.

> **isStarted:** The is started.

> #####Return value
> The .

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean)
The deploy server with disk speed image task.
> #####Parameters
> **name:** The name.

> **description:** The description.

> **networkId:** The network id.

> **privateIp:** The private ip.

> **imageId:** The image id.

> **adminPassword:** The admin password.

> **start:** The start.

> #####Return value
> The .

####DeployServerWithDiskSpeedImageTask(System.String,System.String,System.String,System.String,System.String,System.String,System.Boolean,Disk[])
The deploy server with disk speed image task.
> #####Parameters
> **name:** The name.

> **description:** The description.

> **networkId:** The network id.

> **privateIp:** The private ip.

> **imageId:** The image id.

> **adminPassword:** The admin password.

> **start:** The start.

> **disk:** The disk.

> #####Return value
> The .

####ModifyServer(System.String,System.String,System.String,System.Int32,System.Int32,System.String)
Modify server server settings.
> #####Parameters
> **serverId:** The server id.

> **name:** The server new name on CaaS. This parameter does not change the machine/host name.

> **description:** The new description for the server.

> **memory:** Memory (in MB). Value must be represent a GB integer (e.g. 1024,. 2048, 3072, 4096, etc.)

> **cpucount:** Number of virtual CPU’s (e.g. 1, 2, 4 etc.)

> **privateIp:** The new privateIp of the server.

> #####Return value
> The .

####ServerPowerOn(System.String)
Powers on the server.
> #####Parameters
> **serverId:** The server id

> #####Return value
> Returns a status of the HTTP request

####ServerPowerOff(System.String)
Powers off the server
> #####Parameters
> **serverId:** The server id

> #####Return value
> Returns a status of the HTTP request

####ServerRestart(System.String)
Graceful reset of a server
> #####Parameters
> **serverId:** The server id

> #####Return value
> Returns a status of the HTTP request

####ServerReset(System.String)
Power cycles an existing deployed server. This is the equivalent of pulling and replacing the power cord for a physical server. Requires your organization ID and the ID of the target server..
> #####Parameters
> **serverId:** The server id.

> #####Return value
> Returns a status of the HTTP request

####ServerShutdown(System.String)
"Graceful" shutdown of the server.
> #####Parameters
> **serverId:** The server id

> #####Return value
> Returns a status of the HTTP request

####ServerUpdateVMwareTools(System.String)
Triggers an update of the VMWare Tools software running on the guest OS of a virtual server
> #####Parameters
> **serverId:** The server id

> #####Return value
> Returns a status of the HTTP request

####ServerCloneToCustomerImage(System.String,System.String,System.String)
Initiates a clone of a server to create a Customer Image
> #####Parameters
> **serverId:** The server id.

> **imageName:** The customer image name.

> **imageDesc:** The customer image description.

> #####Return value
> The .

####ChangeServerDiskSize(System.String,System.String,System.String)
Change server disk size
> #####Parameters
> **serverId:** The server id

> **diskId:** The disk id

> **sizeInGb:** New size of the disk

> #####Return value
> The .

####ChangeServerDiskSpeed(System.String,System.String,System.String)
Change server disk speed
> #####Parameters
> **serverId:** The server id

> **diskId:** The disk id

> **speedId:** New size of the disk

> #####Return value
> The .

####AddServerDisk(System.String,System.String,System.String)
Add disk to existing server
> #####Parameters
> **serverId:** The server id

> **size:** Size in GB

> **speedId:** The speed id

> #####Return value
> Returns a status of the HTTP request

####RemoveServerDisk(System.String,System.String)
Remove disk from existing server
> #####Parameters
> **serverId:** The server id

> **diskId:** The disk id

> #####Return value
> The .

####ServerDelete(System.String)
Deletes the server. The server must be turned off and with backup disabled
> #####Parameters
> **serverId:** The server id

> #####Return value
> Returns a status of the HTTP request

####GetDeployedServers
Gets all the deployed servers.
> #####Return value
> A list of deployed servers

####GetDeployedServers(System.String,System.String,System.String,System.String)
Gets filtered list of the deployed servers.
> #####Parameters
> **serverId:** The server Id.

> **name:** The name.

> **networkId:** The network Id.

> **location:** The location.

> #####Return value
> A list of deployed servers

####GetDeployedServerById(System.String)
Gets a deployed server by Id.
> #####Parameters
> **serverId:** The server Id.

> #####Return value
> A list of deployed servers

####GetDeployedServersByName(System.String)
Gets filtered list of the deployed servers by name
> #####Parameters
> **name:** The server name.

> #####Return value
> A list of deployed servers

####GetDeployedServersByNetworkId(System.String)
Gets filtered list of the deployed servers by network id
> #####Parameters
> **networkid:** The network id.

> #####Return value
> A list of deployed servers

####GetDeployedServersByLocation(System.String)
Gets filtered list of the deployed servers by location
> #####Parameters
> **location:** The location code

> #####Return value
> A list of deployed servers

####CreateServerAntiAffinityRule(System.String,System.String)
Creates a new Server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **serverId1:** The serverId for the 1st server

> **serverId2:** The serverId for the 2'nd server

> #####Return value
> The .

####GetServerAntiAffinityRules(System.String,System.String,System.String)
List all Server Anti-Affinity Rules
> #####Parameters
> **ruleId:** Filter by rule Id

> **location:** Filter by location

> **networkId:** Filter by network Id

> #####Return value
> The .

####RemoveServerAntiAffinityRule(System.String)
Remove a server Anti-Affinity Rule between two servers on the same Cloud network.
> #####Parameters
> **ruleId:** The ruleId

> #####Return value
> The .

####GetImages(System.String,System.String,System.String,System.String,System.String)
Get OS server images, paramenters are just for filtering. Use String.Empty on the parameter where filtering is not required.
> #####Parameters
> **imageId:** The image Id.

> **name:** The name filter

> **location:** The location filter

> **operatingSystemId:** The OS id

> **operatingSystemFamily:** The OS family

> #####Return value
> The .

####LoginAsync(System.Net.ICredentials)
Asynchronously log into the CaaS API.
> #####Parameters
> **accountCredentials:** The CaaS account credentials used to authenticate against the CaaS API.

> #####Return value
> An implementation representing the CaaS account that the client is logged into.

##CBU.Compute.Api.Client.ComputeApiException
            
Exception raised by the CaaS API client when it encounters an error response from the CaaS API.
        
###Properties

####Error
Gets or sets the error.
####Uri
The uri which caused the exception
####Message
Gets a message that describes the current exception. The error message that explains the reason for the exception, or an empty string("").
###Methods


####Constructor
Initialises a new instance of the class. Create a new .
> #####Parameters
> **messageOrFormat:** The exception message or message format.

> **formatArguments:** Optional message format arguments.


####Constructor
Initialises a new instance of the class. Create a new .
> #####Parameters
> **uri:** Api uri

> **messageOrFormat:** The exception message or message format.

> **formatArguments:** Optional message format arguments.


####Constructor
Initialises a new instance of the class. Create a new .
> #####Parameters
> **innerException:** A previous exception that caused the current exception to be raised.

> **messageOrFormat:** The exception message or message format.

> **formatArguments:** Optional message format arguments.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **error:** The error.

> **messageOrFormat:** The message or format.

> **formatArguments:** The format arguments.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **error:** The error.

> **uri:** The uri.

> **messageOrFormat:** The message or format.

> **formatArguments:** The format arguments.


####Constructor
Initialises a new instance of the class.
> #####Parameters
> **error:** The error.

> **uri:** The uri.

> **messageOrFormat:** The message or format.

> **ex:** Inner Exception

> **formatArguments:** The format arguments.


####Constructor
Initialises a new instance of the class. Deserialisation constructor for .
> #####Parameters
> **info:** A serialisation data store that holds the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


####GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
Get exception data for serialisation.
> #####Parameters
> **info:** A serialisation data store that will hold the serialized exception data.

> **context:** A value that indicates the source of the serialised data.

> #####Exceptions
> **System.ArgumentNullException:** The parameter is null.

> **System.Runtime.Serialization.SerializationException:** The class name is null or is zero (0).


##CBU.Compute.Api.Client.StringExtensions
            
The string extensions.
        
###Fields

####MCP1_0_PREFIX
The MCP 1.0 prefix.
####ci
The ci.
###Methods


####ToQueryString(System.Collections.Generic.Dictionary{System.String,System.String})
The to query string.
> #####Parameters
> **collection:** The collection.

> #####Return value
> The .

####ToQueryStringWithEmpty(System.Collections.Generic.Dictionary{System.String,System.String})
The to query string.
> #####Parameters
> **collection:** The collection.

> #####Return value
> The .

####ToTitleCase(System.String)
The to title case.
> #####Parameters
> **str:** The str.

> #####Return value
> The .

####ToTitleCase(System.String,DD.CBU.Compute.Api.Client.TitleCase)
The to title case.
> #####Parameters
> **str:** The str.

> **tcase:** The tcase.

> #####Return value
> The .

##CBU.Compute.Api.Client.TitleCase
            
The title case.
        
###Fields

####First
The first.
####All
The all.

##CBU.Compute.Api.Client.WebApi.CsvMediaTypeFormatter
            
The CSV Media type formatter
        
###Methods


####Constructor
Creates a new instance of

####Constructor
Creates an instance of
> #####Parameters
> **mediaTypeMapping:** 


####Constructor
Creates an instance of
> #####Parameters
> **mediaTypeMappings:** 


####CanReadType(System.Type)
Queries whether this can deserializean object of the specified type.
> #####Parameters
> **type:** The type to deserialize.

> #####Return value
> true if the can deserialize the type; otherwise, false.

####CanWriteType(System.Type)
Queries whether this can serializean object of the specified type.
> #####Parameters
> **type:** The type to serialize.

> #####Return value
> true if the can serialize the type; otherwise, false.

####ReadFromStreamAsync(System.Type,System.IO.Stream,System.Net.Http.HttpContent,System.Net.Http.Formatting.IFormatterLogger)
Asynchronously deserializes an object of the specified type.
> #####Parameters
> **type:** The type of the object to deserialize.

> **readStream:** The to read.

> **content:** The , if available. It may be null.

> **formatterLogger:** The to log events to.

> #####Return value
> A whose result will be an object of the given type.
> #####Exceptions
> **System.NotSupportedException:** Derived types need to support reading.


##CBU.Compute.Api.Client.WebApi.HttpClientAdapter
            
The http client adapter.
        
###Fields

####_client
The underlying .
###Properties

####BaseAddress
The base address used by the HTTP client.
###Methods


####Constructor
Initialises a new instance of the class. Create a new adaptor.
> #####Parameters
> **client:** The wrapped by the adaptor.


####GetAsync(System.Uri)
The get async.
> #####Parameters
> **uri:** The uri.

> #####Return value
> The .

####DeleteAsync(System.Uri)
The delete async.
> #####Parameters
> **uri:** The uri.

> #####Return value
> The .

####PutAsync(System.Uri,System.Net.Http.HttpContent)
The put async.
> #####Parameters
> **uri:** The uri.

> **content:** The content.

> #####Return value
> The .

####PostAsync(System.Uri,System.Net.Http.HttpContent)
The post async.
> #####Parameters
> **uri:** The uri.

> **content:** The content.

> #####Return value
> The .

####Dispose(System.Boolean)
Dispose of resources being used by the disposable object.
> #####Parameters
> **disposing:** Explicit disposal?


##CBU.Compute.Api.Client.WebApi.WebApi
            
The web API.
        
###Fields

####_mediaTypeFormatters
Media type formatters used to serialise and deserialise data contracts when communicating with the CaaS API.
####_httpClient
The used to communicate with the CaaS API.
####_organizationId
The _organization id.
###Properties

####OrganizationId
Gets the CaaS client organization id.
###Methods


####Constructor
Initialises a new instance of the class.

####Constructor
Initialises a new instance of the class.
> #####Parameters
> **client:** The client.

> **organizationId:** The organization Id.


####LoginAsync
Asynchronously log into the CaaS API.
> #####Return value
> An implementation representing the CaaS account that the client is logged into.

####GetAsync``1(System.Uri,DD.CBU.Compute.Api.Contracts.Requests.IPageableRequest,DD.CBU.Compute.Api.Contracts.Requests.IFilterableRequest)
The get async.
> #####Parameters
> **relativeOperationUri:** The relative operation uri.

> **pagingOptions:** The paging options.

> **filteringOptions:** The filtering options.

> #####Return value
> The .
> #####Exceptions
> **System.ArgumentNullException:** 

> **System.ArgumentException:** 

> **DD.CBU.Compute.Api.Client.ComputeApiException:** 

> **System.Net.Http.HttpRequestException:** 


####PostAsync``2(System.Uri,``0)
Invoke a CaaS API operation using a HTTP POST request.
> #####Parameters
> **relativeOperationUri:** The operation URI (relative to the CaaS API's base URI).

> **content:** The content that will be deserialised and passed in the body of the POST request.

> #####Return value
> The operation result.

####PostAsync``1(System.Uri,System.String)
Invoke a CaaS API operation using a HTTP POST request.
> #####Parameters
> **relativeOperationUri:** The operation URI (relative to the CaaS API's base URI).

> **content:** The content that will be deserialised and passed in the body of the POST request.

> #####Return value
> The operation result.

####Dispose(System.Boolean)
Dispose of resources being used by the CaaS API client.
> #####Parameters
> **disposing:** Explicit disposal?


####HandleApiRequestErrors(System.Net.Http.HttpResponseMessage)
The handle api request errors.
> #####Parameters
> **response:** The response.

> #####Return value
> The .
> #####Exceptions
> **DD.CBU.Compute.Api.Client.Exceptions.InvalidCredentialsException:** 

> **DD.CBU.Compute.Api.Client.ComputeApiException:** 

> **System.Net.Http.HttpRequestException:** 


####SafeReadContentAsync(System.Net.Http.HttpResponseMessage)
ReadContent From Response
> #####Parameters
> **response:** Http Response Object

> #####Return value
> Task for writing the log

####HandleApiRequestErrorsWithResponse(System.Net.Http.HttpResponseMessage,System.Uri)
Handle Http Exceptions with Response details
> #####Parameters
> **response:** Http Response

> **uri:** Request Uri

> #####Return value
> 

####SafeReadResponseAsync``1(System.Net.Http.HttpContent)
Read response with utf-8 encoding workaround
> #####Parameters
> **content:** Http content

> #####Return value
> Response task

####ReadResponseAsync``1(System.Net.Http.HttpContent)
Read response with utf-8 encoding workaround
> #####Parameters
> **content:** Http content

> #####Return value
> Response task

####ReadResponseUtf8WorkAroundAsync``1(System.Net.Http.HttpContent)
Read response as string then convert to type, utf-8 encoding error work around
> #####Parameters
> **content:** Http content

> #####Return value
> Response task

##CBU.Compute.Api.Client.TextMediaTypeFormatter
            
The text media type formatter.
        
###Methods


####Constructor
Initialises a new instance of the class.

####ReadFromStreamAsync(System.Type,System.IO.Stream,System.Net.Http.HttpContent,System.Net.Http.Formatting.IFormatterLogger)
The read from stream async.
> #####Parameters
> **type:** The type.

> **readStream:** The read stream.

> **content:** The content.

> **formatterLogger:** The formatter logger.

> #####Return value
> The .

####WriteToStreamAsync(System.Type,System.Object,System.IO.Stream,System.Net.Http.HttpContent,System.Net.TransportContext)
The write to stream async.
> #####Parameters
> **type:** The type.

> **value:** The value.

> **writeStream:** The write stream.

> **content:** The content.

> **transportContext:** The transport context.

> #####Return value
> The .

####CanReadType(System.Type)
The can read type.
> #####Parameters
> **type:** The type.

> #####Return value
> The .

####CanWriteType(System.Type)
The can write type.
> #####Parameters
> **type:** The type.

> #####Return value
> The .

##CBU.Compute.Api.Client.VIP.ComputeApiVipExtensions
            
The compute api vip extensions.
        
###Methods


####GetRealServers(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Gets the list of Real Servers from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> #####Return value
> The networks

####CreateRealServer(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String,System.Boolean)
Gets the list of Real Servers from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **name:** The real server name

> **serverId:** The server id

> **inService:** In service

> #####Return value
> The .

####RemoveRealServer(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Delete a of Real Servers from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **realServerId:** The real server id

> #####Return value
> The networks

####ModifyRealServer(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Boolean)
Modify a of Real Server on network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **realServerId:** The real server id

> **inService:** In service

> #####Return value
> The networks

####GetProbes(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Gets the list of Probes from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> #####Return value
> The networks

####CreateProbe(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ProbeType,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.ProbeRequestMethod,System.String,System.String)
The create probe.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **name:** The name.

> **type:** The type.

> **port:** The port.

> **probeIntervalSeconds:** The probe interval seconds.

> **errorCountBeforeServerFail:** The error count before server fail.

> **successCountBeforeServerEnable:** The success count before server enable.

> **failedProbeIntervalSeconds:** The failed probe interval seconds.

> **maxReplyWaitSeconds:** The max reply wait seconds.

> **statusCodeLowerBound:** The status code lower bound.

> **statusCodeUpperBound:** The status code upper bound.

> **requestMethod:** The request method.

> **requestUrl:** The request url.

> **matchContent:** The match content.

> #####Return value
> The .

####ModifyProbe(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
The modify probe.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **probeId:** The probe id.

> **probeIntervalSeconds:** The probe interval seconds.

> **errorCountBeforeServerFail:** The error count before server fail.

> **successCountBeforeServerEnable:** The success count before server enable.

> **failedProbeIntervalSeconds:** The failed probe interval seconds.

> **maxReplyWaitSeconds:** The max reply wait seconds.

> #####Return value
> The .

####RemoveProbe(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Delete a Probe from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **probeId:** The probe id

> #####Return value
> The .

####GetServerFarms(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
List all server farms from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> #####Return value
> The .

####GetServerFarmDetails(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Get server farm details from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> #####Return value
> The .

####CreateServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ServerFarmPredictorType,System.String,System.Int32,System.String)
Create a server farm from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **name:** The server farm name

> **predictor:** The server farm predictor

> **realServerId:** The first real server Id

> **realServerPort:** The first real server port

> **probeId:** The probe id

> #####Return value
> The .

####RemoveServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Delete a ServerFarm from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> #####Return value
> The .

####ModifyServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,DD.CBU.Compute.Api.Contracts.Vip.ServerFarmPredictorType)
Modify a ServerFarm
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> **predictor:** Either LEAST_CONNECTIONS or ROUND_ROBIN

> #####Return value
> The .

####AddRealServerToServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String,System.Int32)
Adds a Real Server to ServerFarm
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> **realServerId:** The real server id

> **realServerPort:** The real server port

> #####Return value
> The .

####RemoveRealServerFromServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String,System.Int32)
Removes a Real Server to ServerFarm
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> **realServerId:** The real server id

> **realServerPort:** The real server port

> #####Return value
> The .

####AddProbeToServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String)
Adds a Probe to ServerFarm
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> **probeId:** The probe id

> #####Return value
> The .

####RemoveProbeFromServerFarm(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String)
Removes a Probe to ServerFarm
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **serverFarmId:** The server farm id

> **probeId:** The probe id

> #####Return value
> The .

####GetPersistenceProfile(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Get persistence profile from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> #####Return value
> The .

####CreatePersistenceProfileIpNetmask(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.PersistenceProfileDirection,System.String)
Create a IP Netmask persistence profile for network VIP.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **name:** The name.

> **serverFarmId:** The server farm id.

> **timeOutMinutes:** The time out minutes.

> **direction:** The direction.

> **netmask:** The netmask.

> #####Return value
> The .

####CreatePersistenceProfileHttpCookie(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.String,System.Int32,System.String,DD.CBU.Compute.Api.Contracts.Vip.PersistenceProfileCookieType)
The create persistence profile http cookie.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **name:** The name.

> **serverFarmId:** The server farm id.

> **timeOutMinutes:** The time out minutes.

> **cookieName:** The cookie name.

> **cookieType:** The cookie type.

> #####Return value
> The .

####RemovePersistenceProfile(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Get persistence profile from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **persistenceProfileId:** The pers Profile Id.

> #####Return value
> The .

####GetVips(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String)
Get VIPs from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> #####Return value
> The .

####CreateVip(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Int32,DD.CBU.Compute.Api.Contracts.Vip.VipProtocol,DD.CBU.Compute.Api.Contracts.Vip.VipTargetType,System.String,System.Boolean,System.Boolean,System.String)
Create a VIPs from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **name:** The name

> **port:** The vip port

> **protocol:** The vip protocol

> **targetType:** The tartget type

> **targetId:** The target id

> **replyToIcmp:** Reply to icmp

> **inService:** In service

> **ipAddress:** Optional ip address

> #####Return value
> The .

####RemoveVip(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String)
Delete VIP from network VIP
> #####Parameters
> **client:** The object.

> **networkId:** The network id

> **vipId:** The vip id

> #####Return value
> The .

####ModifyVip(DD.CBU.Compute.Api.Client.Interfaces.IComputeApiClient,System.String,System.String,System.Boolean,System.Boolean)
The modify vip.
> #####Parameters
> **client:** The client.

> **networkId:** The network id.

> **vipId:** The vip id.

> **replyToIcmp:** The reply to icmp.

> **inService:** The in service.

> #####Return value
> The .