#DD.CBU.Compute.Api.Contracts


##CBU.Compute.Api.Contracts.Drs.ConsistencyGroupSnapshotType
            
        
###Properties

####createTimeOffset

####id

####createTime

####sizeKb


##CBU.Compute.Api.Contracts.Drs.consistencyGroupSnapshots
            
        
###Properties

####snapshot

####totalCount

####journalUsageGb

####protectionWindow

####predictedProtectionWindow


##CBU.Compute.Api.Contracts.Drs.StopPreviewSnapshotType
            

        
###Properties

####consistencyGroupId


##CBU.Compute.Api.Contracts.Drs.StartPreviewSnapshotType
            
        
###Properties

####snapshotId

####consistencyGroupId


##CBU.Compute.Api.Contracts.Drs.DrsServerType
            

        
###Fields

####name

####id

####primaryNicIpv4

####primaryNicIpv6


##CBU.Compute.Api.Contracts.Drs.DrsNetworkDomainType
            

        
###Fields

####networkDomainName

####datacenterId

####networkDomainId


##CBU.Compute.Api.Contracts.Drs.consistencyGroups
            

        
###Fields

####consistencyGroup

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Drs.ConsistencyGroupType
            

        
###Fields

####name

####description

####journal

####source

####target

####serverPair

####createTime

####operationStatus

####drsInfrastructure

####drsStatusCheckFailureCount

####state

####progress

####id

####

####

####

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Drs.ConsistencyGroupTypeJournal
            

        
###Fields

####sizeGb

####extentCount


##CBU.Compute.Api.Contracts.Drs.ConsistencyGroupTypeServerPair
            

        
###Fields

####sourceServer

####targetServer

####id

####state


##CBU.Compute.Api.Contracts.Drs.ConsistencyGroupTypeDrsInfrastructure
            

        
###Fields

####enabled

####status

####updateTime


##CBU.Compute.Api.Contracts.Drs.CreateConsistencyGroupType
            

        
###Fields

####name

####description

####journalSizeGb

####serverPair


##CBU.Compute.Api.Contracts.Drs.DrsServerPairType
            

        
###Fields

####sourceServerId

####targetServerId


##CBU.Compute.Api.Contracts.Drs.DeleteConsistencyGroupType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Drs.InitiateFailoverType
            

        
###Properties

####consistencyGroupId


##CBU.Compute.Api.Contracts.Drs.ExpandJournalType
            
        
###Properties

####sizeGb

####id


##CBU.Compute.Api.Contracts.Network20.VlanType
            

        
###Properties

####networkDomain

####name

####description

####privateIpv4Range

####gatewayAddressing

####ipv4GatewayAddress

####ipv6Range

####ipv6GatewayAddress

####createTime

####state

####progress

####id

####datacenterId

####

####


##CBU.Compute.Api.Contracts.Network20.NetworkDomainType
            

        
###Properties

####name

####description

####type

####snatIpv4Address

####createTime

####state

####progress

####id

####datacenterId

####outsideTransitVlanIpv4Subnet


##CBU.Compute.Api.Contracts.Network20.AntiAffinityNetworkInfoTypeNic
            

        
###Properties

####id

####privateIpv4

####networkId

####networkName

####macAddress

####state


##CBU.Compute.Api.Contracts.Network20.AntiAffinityRuleType
            

        
###Properties

####serverSummary

####id

####state

####created

####datacenterId

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.IpAddressListType
            

        
###Properties

####name

####description

####ipVersion

####ipAddress

####childIpAddressList

####state

####createTime

####id


##CBU.Compute.Api.Contracts.Network20.NatRuleType
            

        
###Fields

####Item

####ItemElementName

####internalIp

####externalIp

####externalIpAddressability

####createTime

####datacenterId

###Properties

####state

####id


##CBU.Compute.Api.Contracts.Network20.NodeType
            

        
###Properties

####networkDomainId

####name

####description

####Item

####ItemElementName

####state

####status

####healthMonitor

####connectionLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####connectionRateLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####createTime

####loggingEnabled

####loggingEnabledSpecified

####id

####datacenterId

####

####


##CBU.Compute.Api.Contracts.Network20.PoolType
            

        
###Properties

####networkDomainId

####name

####description

####loadBalanceMethod

####healthMonitor

####serviceDownAction

####slowRampTime
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####state

####createTime

####id

####datacenterId


##CBU.Compute.Api.Contracts.Network20.PoolMemberType
            

        
###Properties

####networkDomainId

####pool

####node

####port

####portSpecified

####status

####state

####createTime

####id

####datacenterId

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.ServerType
            

        
###Properties

####nic
Note, server will have either nic or NetworkInfo Gets or sets the NIC. The NIC.
####networkInfo

####name

####description

####operatingSystem

####cpu

####memoryGb

####disk

####Item

####backup

####monitoring

####softwareLabel

####sourceImageId

####createTime

####deployed

####started

####state

####progress

####vmwareTools

####virtualHardware

####id

####datacenterId

####drsEligible

####consistencyGroup

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.VirtualListenerType
            

        
###Properties

####networkDomainId

####name

####state

####description

####createTime

####type

####protocol

####listenerIpAddress

####listenerIpAddressability

####port

####portSpecified

####enabled

####connectionLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####connectionRateLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####sourcePortPreservation

####pool

####clientClonePool

####persistenceProfile

####fallbackPersistenceProfile

####optimizationProfile

####irule

####id

####datacenterId


##CBU.Compute.Api.Contracts.Network20.IpAndPortFilterType
            

            

        
###Fields

####ip

####port

####

####

####


##CBU.Compute.Api.Contracts.Network20.IpAddressListSummaryType
            

        
###Properties

####id

####name


##CBU.Compute.Api.Contracts.Network20.IpAddressRangeType
            

        
###Properties

####begin

####prefixSize

####prefixSizeSpecified

####end


##CBU.Compute.Api.Contracts.Network20.createIpAddressList
            

        
###Properties

####networkDomainId

####name

####description

####ipVersion

####ipAddress

####childIpAddressListId


##CBU.Compute.Api.Contracts.Network20.ipAddressLists
            

        
###Properties

####ipAddressList

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.deleteIpAddressList
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.editIpAddressList
            

        
###Fields

####descriptionSpecified

####ipAddressSpecified

####childIpAddressListIdSpecified

###Properties

####description

####ipAddress

####childIpAddressListId

####id

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.editIpAddressListIpAddress
            

        
###Properties

####begin

####prefixSize

####prefixSizeSpecified

####end


##CBU.Compute.Api.Contracts.Network20.PortListSummaryType
            

        
###Fields

####id

####name


##CBU.Compute.Api.Contracts.Network20.createPortList
            

        
###Fields

####networkDomainId

####name

####description

####port

####childPortListId


##CBU.Compute.Api.Contracts.Network20.editPortList
            

        
###Fields

####description

####port

####portSpecified

####childPortListId

####childPortListIdSpecified

####id


##CBU.Compute.Api.Contracts.Network20.EditPortListPort
            

        
###Fields

####begin

####beginSpecified

####end

####endSpecified


##CBU.Compute.Api.Contracts.Network20.PortListType
            

        
###Fields

####name

####description

####port

####childPortList

####state

####createTime

####id


##CBU.Compute.Api.Contracts.Network20.portLists
            

        
###Fields

####portList

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DeletePortListType
            

        
###Fields

####id


##CBU.Compute.Api.Contracts.Network20.ApplyTagType
            

        
###Fields

####tagKeyName

####value

####valueSpecified


##CBU.Compute.Api.Contracts.Network20.ApplyTagByIdType
            

        
###Fields

####tagKeyId

####value

####valueSpecified


##CBU.Compute.Api.Contracts.Network20.createTagKeyType
            

        
###Fields

####name

####description

####valueRequired

####displayOnReport

####id

####descriptionSpecified


##CBU.Compute.Api.Contracts.Network20.deleteTagKeyType
            

        
###Fields

####id


##CBU.Compute.Api.Contracts.Network20.TagKeyType
            

        
###Fields

####name

####description

####valueRequired

####displayOnReport

####id

####descriptionSpecified


##CBU.Compute.Api.Contracts.Network20.tagKeys
            

        
###Fields

####tagKey

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.EditTagKeyType
            

        
###Fields

####name

####description

####valueRequired

####valueRequiredSpecified

####displayOnReport

####displayOnReportSpecified

####id

####nameSpecified

####descriptionSpecified


##CBU.Compute.Api.Contracts.Network20.RemoveTagsType
            

        
###Fields

####assetType

####assetId

####Items

####ItemsElementName


##CBU.Compute.Api.Contracts.Network20.TagKeyNameIdChoice
            

        
###Fields

####tagKeyId

####tagKeyName


##CBU.Compute.Api.Contracts.Network20.applyTags
            

        
###Fields

####assetType

####assetId

####Items

###Properties

####tag

####tagById


##CBU.Compute.Api.Contracts.Network20.TagType
            

        
###Fields

####assetType

####assetId

####assetName

####datacenterId

####tagKeyId

####tagKeyName

####value

####displayOnReport

####valueRequired

####valueSpecified


##CBU.Compute.Api.Contracts.Network20.tags
            

        
###Fields

####tag

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.MonitoringType
            

        
###Properties

####property

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network20.PropertyType
            

        
###Properties

####name

####value


##CBU.Compute.Api.Contracts.Network20.ConsoleAccessType
            

        
###Properties

####property

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network20.BackupType
            

        
###Properties

####property

####type

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network20.CpuSpeedType
            

        
###Properties

####displayName

####description

####unavailableReason

####id

####default

####available


##CBU.Compute.Api.Contracts.Network20.DiskSpeedType
            

        
###Properties

####displayName

####abbreviation

####description

####unavailableReason

####id

####default

####available


##CBU.Compute.Api.Contracts.Network20.HypervisorType
            

        
###Properties

####diskSpeed

####cpuSpeed

####property

####type

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network20.NetworkingType
            

        
###Properties

####property

####type

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network20.DrsType
            

        
###Properties

####property

####targetDatacenters

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network20.IdListType
            

        
###Properties

####list


##CBU.Compute.Api.Contracts.Network20.DatacenterType
            

        
###Properties

####displayName

####city

####state

####country

####vpnUrl

####ftpsHost

####networking

####hypervisor

####backup

####consoleAccess

####monitoring

####drs

####id

####type


##CBU.Compute.Api.Contracts.Network20.datacenters
            

        
###Properties

####datacenter

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.RulePlacementType
            

        
###Fields

####position

####relativeToRule


##CBU.Compute.Api.Contracts.Network20.RulePositionType
            

        
###Fields

####BEFORE

####AFTER

####FIRST

####LAST


##CBU.Compute.Api.Contracts.Network20.IpAndPortType
            

        
###Fields

####Item

####Item1

####

####

####


##CBU.Compute.Api.Contracts.Network20.IpAndPortTypeIP
            

        
###Fields

####address

####prefixSize

####prefixSizeSpecified


##CBU.Compute.Api.Contracts.Network20.PortRangeType
            

        
###Fields

####begin

####end

####endSpecified


##CBU.Compute.Api.Contracts.Network20.IpAndPortFilterTypeIP
            

        
###Fields

####address

####prefixSize

####prefixSizeSpecified


##CBU.Compute.Api.Contracts.Network20.IcmpPropertiesType
            

        
###Fields

####type

####code

####codeSpecified


##CBU.Compute.Api.Contracts.Network20.FirewallRuleType
            

        
###Fields

####networkDomainId

####name

####action

####ipVersion

####protocol

####icmpProperties

####source

####destination

####enabled

####state

####id

####datacenterId

####ruleType


##CBU.Compute.Api.Contracts.Network20.firewallRules
            

        
###Fields

####firewallRule

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.CreateFirewallRuleType
            

        
###Fields

####networkDomainId

####name

####action

####ipVersion

####protocol

####source

####destination

####enabled

####placement


##CBU.Compute.Api.Contracts.Network20.DeleteFirewallRuleType
            

        
###Fields

####id


##CBU.Compute.Api.Contracts.Network20.EditFirewallRuleType
            

        
###Fields

####action

####protocol

####source

####destination

####enabled

####enabledSpecified

####placement

####id


##CBU.Compute.Api.Contracts.Network20.ResponseType
            

        
###Properties

####operation

####responseCode

####message

####info

####warning

####error

####requestId


##CBU.Compute.Api.Contracts.Network20.NameValuePairType
            

        
###Properties

####name

####value


##CBU.Compute.Api.Contracts.Network20.ProgressStepType
            

        
###Properties

####name

####number

####percentComplete

####percentCompleteSpecified


##CBU.Compute.Api.Contracts.Network20.ProgressType
            

        
###Properties

####action

####requestTime

####userName

####numberOfSteps

####numberOfStepsSpecified

####updateTime

####updateTimeSpecified

####step

####failureReason


##CBU.Compute.Api.Contracts.Network20.VirtualHardwareType
            

        
###Properties

####version

####upToDate


##CBU.Compute.Api.Contracts.Network20.VmwareToolsType
            

        
###Properties

####versionStatus

####runningStatus

####apiVersion

####apiVersionSpecified


##CBU.Compute.Api.Contracts.Network20.CpuType
            

        
###Properties

####count

####speed

####coresPerSocket


##CBU.Compute.Api.Contracts.Network20.OperatingSystemType
            

        
###Properties

####id

####displayName

####family


##CBU.Compute.Api.Contracts.Network20.NetworkAdapterType
            

        
###Fields

####name

####isDefault


##CBU.Compute.Api.Contracts.Network20.OperatingSystemDetailType
            

        
###Fields

####displayName

####networkAdapter

####id

####family


##CBU.Compute.Api.Contracts.Network20.OperatingSystemsDetails
            

        
###Fields

####operatingSystemDetail

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.IdAndNameType
            

        
###Properties

####id

####name


##CBU.Compute.Api.Contracts.Network20.ImageType
            

        
###Properties

####name

####description

####operatingSystem

####cpu

####memoryGb

####disk

####softwareLabel

####createTime

####id

####datacenterId

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.ImageTypeDisk
            

        
###Properties

####id

####scsiId

####sizeGb

####speed


##CBU.Compute.Api.Contracts.Network20.customerImages
            

        
###Properties

####customerImage

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.CustomerImageType
            

        
###Properties

####source

####state

####progress

####vmwareTools

####virtualHardware

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.CustomerImageTypeSource
            

        
###Properties

####artifact

####type

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.CustomerImageTypeSourceArtifact
            

        
###Properties

####type

####value

####date

####dateSpecified


##CBU.Compute.Api.Contracts.Network20.osImages
            

        
###Properties

####osImage

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.OsImageType
            

        
###Properties

####osImageKey


##CBU.Compute.Api.Contracts.Network20.ImageMetadataType
            

        
###Properties

####description

####cpuSpeed

####operatingSystemId

####disk

####id

####

####


##CBU.Compute.Api.Contracts.Network20.ImageMetadataTypeDisk
            

        
###Properties

####scsiId

####speed


##CBU.Compute.Api.Contracts.Network20.operatingSystems
            

        
###Properties

####operatingSystem

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.ReservedPublicIpv4AddressType
            

        
###Fields

####datacenterId

####ipBlockId

####networkDomainId

####networkId

####Value


##CBU.Compute.Api.Contracts.Network20.ReservedIpv6AddressType
            

        
###Fields

####datacenterId

####vlanId

####Value


##CBU.Compute.Api.Contracts.Network20.ReservedPrivateIpv4AddressType
            

        
###Fields

####datacenterId

####networkId

####vlanId

####Value


##CBU.Compute.Api.Contracts.Network20.reservedPrivateIpv4Addresses
            

        
###Fields

####ipv4

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.reservedIpv6Addresses
            

        
###Fields

####reservedIpv6Address

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.reservedPublicIpv4Addresses
            

        
###Fields

####ip

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.ReservePrivateIpv4AddressType
            

        
###Fields

####Item

####ItemElementName

####ipAddress


##CBU.Compute.Api.Contracts.Network20.NetworkIdOrVlanIdChoiceType
            

        
###Fields

####networkId

####vlanId


##CBU.Compute.Api.Contracts.Network20.ReserveIpv6AddressType
            

        
###Fields

####vlanId

####ipAddress


##CBU.Compute.Api.Contracts.Network20.UnreservePrivateIpv4AddressType
            

        
###Fields

####Item

####ItemElementName

####ipAddress


##CBU.Compute.Api.Contracts.Network20.UnreserveIpv6AddressType
            

        
###Fields

####vlanId

####ipAddress


##CBU.Compute.Api.Contracts.Network20.natRules
            

        
###Fields

####natRule

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.NetworkDomainIdOrNetworkIdChoiceType
            

        
###Fields

####networkDomainId

####networkId


##CBU.Compute.Api.Contracts.Network20.createNatRule
            

        
###Fields

####Item

####ItemElementName

####internalIp

####externalIp


##CBU.Compute.Api.Contracts.Network20.deleteNatRule
            

        
###Fields

####id


##CBU.Compute.Api.Contracts.Network20.outsideTransitVlanIpv4Subnet
            

        
###Properties

####address

####prefixSize


##CBU.Compute.Api.Contracts.Network20.networkDomains
            

        
###Properties

####networkDomain

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DeployNetworkDomainType
            

        
###Properties

####datacenterId

####name

####description

####type


##CBU.Compute.Api.Contracts.Network20.EditNetworkDomainType
            

        
###Properties

####name

####description

####type

####id


##CBU.Compute.Api.Contracts.Network20.DeleteNetworkDomainType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.DefaultPersistenceProfileType
            

        
###Properties

####name

####virtualListenerCompatibility

####id

####fallbackCompatible


##CBU.Compute.Api.Contracts.Network20.defaultPersistenceProfiles
            

        
###Properties

####defaultPersistenceProfile

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.PublicIpBlockType
            

        
###Properties

####serverToVipConnectivity
Gets or sets a value indicating whether the server to vip connectivity. true if server to vip connectivity, false if not.
####networkDomainId
Gets or sets the identifier of the network domain. The identifier of the network domain.
####networkId
Gets or sets the identifier of the network. The identifier of the network.
####networkDefault
Gets or sets a value indicating whether the network default. true if network default, false if not.
####Items

####ItemsElementName

####baseIp

####size

####createTime

####state

####id

####datacenterId


##CBU.Compute.Api.Contracts.Network20.AddPublicIpBlockType
            

        
###Properties

####networkDomainId
Network Domain Id
####networkId
Network Id
####Item

####ItemElementName


##CBU.Compute.Api.Contracts.Network20.createSecurityGroup
            

        
###Properties

####vlanId

####name

####description


##CBU.Compute.Api.Contracts.Network20.DeleteSecurityGroup
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.addNicToSecurityGroup
            

        
###Properties

####nicId

####securityGroupId


##CBU.Compute.Api.Contracts.Network20.removeNicFromSecurityGroup
            

        
###Properties

####nicId

####securityGroupId


##CBU.Compute.Api.Contracts.Network20.SecurityGroupType
            

        
###Properties

####name

####description

####state

####nic

####vlanId

####createTime

####id

####datacenterId

####

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.SecurityGroupTypeNic
            

        
###Properties

####server

####id

####ipv4Address

####ipv6Address

####primary

####

####


##CBU.Compute.Api.Contracts.Network20.SecurityGroupTypeNicServer
            

        
###Properties

####name

####id


##CBU.Compute.Api.Contracts.Network20.securityGroups
            

        
###Properties

####securityGroup

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.editSecurityGroup
            

        
###Properties

####name

####description

####id


##CBU.Compute.Api.Contracts.Network20.VlanIdOrPrivateIpType
            

        
###Properties

####vlanId
Note Only PrivaleIpv4 Or VlanId is valid, dont specify both
####privateIpv4

####networkAdapter

####Item

####ItemElementName


##CBU.Compute.Api.Contracts.Network20.NewNicType
            

        
###Properties

####vlanId
Note Only PrivaleIpv4 Or VlanId is valid, dont specify both
####privateIpv4

####Item

####ItemElementName

####networkAdapter


##CBU.Compute.Api.Contracts.Network20.DeployServerType
            

        
###Properties

####network

####networkInfo
Gets or sets information describing the network. Information describing the network.
####name

####description

####imageId

####start

####administratorPassword

####cpu

####memoryGb

####memoryGbSpecified

####Item

####primaryDns

####secondaryDns

####ipv4Gateway

####disk

####microsoftTimeZone

####

####

####

####

####

####

####

####

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.DeployServerTypeNetwork
            

        
###Properties

####networkId

####privateIpv4

####Item

####ItemElementName

####

####

####


##CBU.Compute.Api.Contracts.Network20.editVirtualListener
            

        
###Properties

####poolIdSpecified

####clientClonePoolIdSpecified

####description

####enabled

####enabledSpecified

####connectionLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####connectionRateLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####sourcePortPreservation

####poolId

####clientClonePoolId

####persistenceProfileId

####fallbackPersistenceProfileId

####optimizationProfile

####iruleId

####id


##CBU.Compute.Api.Contracts.Network20.NetworkDomainIdOrNetworkIdIpBlockChoiceType
            

        
###Fields

####networkDefault

####networkDomainId

####networkId

####serverToVipConnectivity


##CBU.Compute.Api.Contracts.Network20.publicIpBlocks
            

        
###Properties

####publicIpBlock

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.RemovePublicIpBlockType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.PrivateIpv4OrVlanIdChoiceType
            

        
###Fields

####privateIpv4

####vlanId


##CBU.Compute.Api.Contracts.Network20.NicType
            

        
###Properties

####id

####privateIpv4

####ipv6

####vlanId

####vlanName

####macAddress

####state


##CBU.Compute.Api.Contracts.Network20.ServerTypeDisk
            

        
###Properties

####id

####scsiId

####sizeGb

####speed

####state


##CBU.Compute.Api.Contracts.Network20.ServerTypeNetworkInfo
            

        
###Properties

####primaryNic

####additionalNic

####networkDomainId


##CBU.Compute.Api.Contracts.Network20.ServerTypeNic
            

        
###Properties

####id

####privateIpv4

####networkId

####networkName

####macAddress

####state


##CBU.Compute.Api.Contracts.Network20.ServerTypeBackup
            

        
###Properties

####assetId

####servicePlan

####state


##CBU.Compute.Api.Contracts.Network20.ServerTypeMonitoring
            

        
###Properties

####monitoringId

####servicePlan

####state


##CBU.Compute.Api.Contracts.Network20.ServersResponseCollection
            

        
###Properties

####Server

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DeployServerTypeCpu
            

        
###Properties

####speed

####count

####countSpecified

####coresPerSocket

####coresPerSocketSpecified


##CBU.Compute.Api.Contracts.Network20.NetworkIdOrPrivateIpv4ChoiceType
            

        
###Fields

####networkId

####privateIpv4


##CBU.Compute.Api.Contracts.Network20.DeployServerTypeNetworkInfo
            

        
###Properties

####primaryNic

####additionalNic

####networkDomainId


##CBU.Compute.Api.Contracts.Network20.DeployServerTypeDisk
            

        
###Properties

####scsiId

####speed


##CBU.Compute.Api.Contracts.Network20.NotifyNicIpChangeType
            

        
###Properties

####privateIpv4

####ipv6

####nicId


##CBU.Compute.Api.Contracts.Network20.AddNicType
            

        
###Properties

####serverId

####nic


##CBU.Compute.Api.Contracts.Network20.RemoveNicType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.DeleteServerType
            	A delete server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.StartServerType
            	A start server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.ShutdownServerType
            	A shutdown server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.RebootServerType
            	A reboot server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.ResetServerType
            	A reset server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.PowerOffServerType
            	A power off server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.UpdateVmwareToolsServerType
            	An update vmware tools server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.UpgradeVirtualHardware
            	An update vmware tools server type. 
        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.CleanServerType
            

        
###Properties

####id
Gets or sets the identifier of the server. The identifier of the server.

##CBU.Compute.Api.Contracts.Network20.EnableServerMonitoringType
            

        
###Properties

####servicePlan

####id


##CBU.Compute.Api.Contracts.Network20.DisableServerMonitoringType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.ChangeServerMonitoringPlanType
            

        
###Properties

####servicePlan

####id


##CBU.Compute.Api.Contracts.Network20.AddLocalDiskType
            

        
###Properties

####sizeGb

####speed

####scsiId

####scsiIdSpecified

####id


##CBU.Compute.Api.Contracts.Network20.ReconfigureServerType
            

        
###Properties

####memoryGb

####memoryGbSpecified

####cpuCount

####cpuCountSpecified

####cpuSpeed

####coresPerSocket

####coresPerSocketSpecified

####id


##CBU.Compute.Api.Contracts.Network20.NicWithSecurityGroupType
            

        
###Properties

####type

####ipv4Address

####ipv6Address

####state

####serverId

####serverName

####serverDescription

####securityGroup

####id

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.NicWithSecurityGroupTypeSecurityGroup
            

        
###Properties

####name

####description

####state

####id


##CBU.Compute.Api.Contracts.Network20.nics
            

        
###Properties

####nic

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.AddDiskType
            

        
###Fields

####sizeGb

####speed

####scsiId

####scsiIdSpecified

####id


##CBU.Compute.Api.Contracts.Network20.RemoveDiskType
            

        
###Fields

####id


##CBU.Compute.Api.Contracts.Network20.drsEligible
            

        

##CBU.Compute.Api.Contracts.Network20.consistencyGroup
            

        
###Fields

####id

####name

####status

####serverRole


##CBU.Compute.Api.Contracts.Network20.editServerMetadata
            
        
###Properties

####name

####description

####drsEligible

####drsEligibleSpecified

####descriptionSpecified

####id


##CBU.Compute.Api.Contracts.Network20.AntiAffinityNetworkInfoType
            

        
###Properties

####

####

####

####

####

####

####Item

####

####

####

####


##CBU.Compute.Api.Contracts.Network20.AntiAffinityNetworkInfoTypeNetworkInfo
            

        
###Properties

####primaryNic

####additionalNic

####networkDomainId

####networkDomainName


##CBU.Compute.Api.Contracts.Network20.AntiAffinityRuleTypeServerSummary
            

        
###Properties

####name

####description

####networkingDetails

####id


##CBU.Compute.Api.Contracts.Network20.antiAffinityRules
            

        
###Properties

####antiAffinityRule

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DefaultHealthMonitorType
            

        
###Properties

####name

####nodeCompatible

####poolCompatible

####id


##CBU.Compute.Api.Contracts.Network20.defaultHealthMonitors
            

        
###Properties

####defaultHealthMonitor

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DefaultIruleType
            

        
###Properties

####irule

####virtualListenerCompatibility


##CBU.Compute.Api.Contracts.Network20.defaultIrules
            

        
###Properties

####defaultIrule

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.IpItemChoiceType
            

        
###Fields

####ipv4Address

####ipv6Address


##CBU.Compute.Api.Contracts.Network20.NodeTypeHealthMonitor
            

        
###Properties

####id

####name


##CBU.Compute.Api.Contracts.Network20.nodes
            

        
###Properties

####node

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.CreateNodeType
            

        
###Properties

####networkDomainId

####name

####description

####Item

####ItemElementName

####status

####healthMonitorId

####connectionLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####connectionRateLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]

##CBU.Compute.Api.Contracts.Network20.EditNodeType
            

        
###Properties

####description

####status

####healthMonitorId

####connectionLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####connectionRateLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####id


##CBU.Compute.Api.Contracts.Network20.DeleteNodeType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.pools
            

        
###Properties

####pool

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.createPool
            

        
###Properties

####networkDomainId

####name

####description

####loadBalanceMethod

####healthMonitorId

####serviceDownAction

####slowRampTime
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]

##CBU.Compute.Api.Contracts.Network20.DeletePoolType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.EditPoolType
            

        
###Properties

####description

####loadBalanceMethod

####healthMonitorId

####serviceDownAction

####slowRampTime
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####id


##CBU.Compute.Api.Contracts.Network20.PoolMemberTypeNode
            

        
###Properties

####id

####name

####ipAddress

####status


##CBU.Compute.Api.Contracts.Network20.poolMembers
            

        
###Properties

####poolMember

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.addPoolMember
            

        
###Properties

####poolId

####nodeId

####port

####portSpecified

####status


##CBU.Compute.Api.Contracts.Network20.editPoolMember
            

        
###Properties

####status

####id


##CBU.Compute.Api.Contracts.Network20.DeletePoolMemberType
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.IpRangeCidrType
            

        
###Properties

####address

####prefixSize


##CBU.Compute.Api.Contracts.Network20.VlanTypeNetworkDomain
            

        
###Properties

####id

####name


##CBU.Compute.Api.Contracts.Network20.vlans
            

        
###Properties

####vlan

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DeployVlanType
            

        
###Properties

####networkDomainId

####name

####description

####privateIpv4BaseAddress

####privateIpv4PrefixSize

####privateIpv4PrefixSizeSpecified

####gatewayAddressing


##CBU.Compute.Api.Contracts.Network20.EditVlanType
            

        
###Properties

####name

####description

####id


##CBU.Compute.Api.Contracts.Network20.ExpandVlanType
            

        
###Properties

####privateIpv4PrefixSize

####id


##CBU.Compute.Api.Contracts.Network20.PoolSummaryType
            

        
###Properties

####loadBalanceMethod

####serviceDownAction

####slowRampTime
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####healthMonitor

####id

####name


##CBU.Compute.Api.Contracts.Network20.createVirtualListener
            

        
###Properties

####networkDomainId

####name

####description

####type

####protocol

####listenerIpAddress

####port

####portSpecified

####enabled

####connectionLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####connectionRateLimit
[System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
####sourcePortPreservation

####poolId

####clientClonePoolId

####persistenceProfileId

####fallbackPersistenceProfileId

####optimizationProfile

####iruleId


##CBU.Compute.Api.Contracts.Network20.virtualListeners
            

        
###Properties

####virtualListener

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Network20.DeleteVirtualListener
            

        
###Properties

####id


##CBU.Compute.Api.Contracts.Network20.VirtualListenerCompatibilityType
            

        
###Properties

####type

####protocol


##CBU.Compute.Api.Contracts.Generic.IEntityStatusV2
            
An entity in the MCP2.0 API that has a status.
        
###Properties

####id
Entity ID
####state
Provisioned state

##CBU.Compute.Api.Contracts.Organization.TwoFactorAuthentication
            

        

##CBU.Compute.Api.Contracts.Backup.AlertingType
            

        
###Properties

####emailAddress

####trigger


##CBU.Compute.Api.Contracts.Backup.BackupClientDetailsType
            

        
###Properties

####description

####schedulePolicyName

####storagePolicyName

####alerting

####times

####totalBackupSizeGb

####totalBackupSizeGbSpecified

####downloadUrl

####runningJob

####id

####type

####isFileSystem

####status


##CBU.Compute.Api.Contracts.Backup.BackupClientType
            

        
###Properties

####type

####isFileSystem

####description

####
the items

##CBU.Compute.Api.Contracts.Backup.BackupClientTypes
            
The backup client types
        
###Properties

####Items
the items

##CBU.Compute.Api.Contracts.Backup.BackupDetails
            

        
###Properties

####backupClient

####assetId

####servicePlan

####state


##CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicies
            
The backup schedule policies
        
###Properties

####Items


##CBU.Compute.Api.Contracts.Backup.BackupSchedulePolicy
            
The backup schedule policy
        
###Properties

####name
The name
####description
The description

##CBU.Compute.Api.Contracts.Backup.BackupStoragePolicies
            
The backup storage policies
        
###Properties

####Items
The items

##CBU.Compute.Api.Contracts.Backup.BackupStoragePolicy
            
The backup storage policy
        
###Properties

####retentionPeriodInDays
The retention period in days
####name
The name
####secondaryLocation
The secondary location

##CBU.Compute.Api.Contracts.Backup.BackupTimesType
            

        
###Properties

####lastBackup

####lastBackupSpecified

####nextBackup

####nextBackupSpecified

####lastOnline

####lastOnlineSpecified


##CBU.Compute.Api.Contracts.Backup.BackupType
            

        
###Properties

####property

####type

####maintenanceStatus


##CBU.Compute.Api.Contracts.Backup.ModifyBackup
            

        
###Properties

####servicePlan

####

####

####


##CBU.Compute.Api.Contracts.Backup.ModifyBackupClient
            

        
###Properties

####storagePolicyName

####schedulePolicyName

####alerting


##CBU.Compute.Api.Contracts.Backup.NewBackup
            

        
###Properties

####servicePlan

####

####

####

####


##CBU.Compute.Api.Contracts.Backup.NewBackupClient
            

        
###Properties

####type

####storagePolicyName

####schedulePolicyName

####alerting


##CBU.Compute.Api.Contracts.Backup.RestoreBackup
            

        
###Properties

####asAtDate

####asAtDateSpecified

####targetServerId


##CBU.Compute.Api.Contracts.Backup.RestoreTargetServers
            

        
###Properties

####server


##CBU.Compute.Api.Contracts.Backup.RestoreTargetServerType
            

        
###Properties

####name

####description

####operatingSystem

####cpuCount

####memoryMb

####disk

####sourceImageId

####softwareLabel

####networkId

####machineName

####privateIp

####created

####backup

####id

####location

####

####


##CBU.Compute.Api.Contracts.Backup.RestoreTargetServerTypeBackup
            

        
###Properties

####assetId

####servicePlan


##CBU.Compute.Api.Contracts.Backup.RunningJobType
            

        
###Properties

####id

####name

####percentageComplete

####status


##CBU.Compute.Api.Contracts.Backup.SchedulePolicy
            

        
###Properties

####name

####description


##CBU.Compute.Api.Contracts.Backup.ServicePlan
            

        
###Fields

####Essentials

####Advanced

####Enterprise


##CBU.Compute.Api.Contracts.Backup.StoragePolicy
            

        
###Properties

####retentionPeriodInDays

####name

####secondaryLocation


##CBU.Compute.Api.Contracts.Backup.TriggerType
            

        
###Fields

####ON_FAILURE

####ON_SUCCESS

####ON_SUCCESS_OR_FAILURE


##CBU.Compute.Api.Contracts.General.PagedResponse`1
            
Wrapper classe for pages result collection.
            The type of the result.
        
###Properties

####items
Gets or sets the items.
####pageNumber
Gets or sets the page number.
####pageCount
Gets or sets the page count.
####totalCount
Gets or sets the total count.
####pageSize
Gets or sets the size of the page.

##CBU.Compute.Api.Contracts.General.AdditionalInformationType
            

        
###Properties

####value

####name


##CBU.Compute.Api.Contracts.General.PropertyType
            

        
###Properties

####name

####value


##CBU.Compute.Api.Contracts.General.ResultType
            

        
###Fields

####ERROR

####SUCCESS

####WARNING


##CBU.Compute.Api.Contracts.General.Status
            

        
###Properties

####operation

####result

####resultDetail

####resultCode

####additionalInformation
The additional information

##CBU.Compute.Api.Contracts.General.AdditionalInformation
            
The additional information
        
###Properties

####

####

####name
The name
####value
The value

##CBU.Compute.Api.Contracts.Datacenter.Datacenters
            

        
###Properties

####datacenter

####

####

####


##CBU.Compute.Api.Contracts.Datacenter.DatacentersWithDiskSpeedDetails
            

        
###Properties

####datacenter


##CBU.Compute.Api.Contracts.Datacenter.DatacentersWithLimits
            

        
###Properties

####datacenterWithLimits


##CBU.Compute.Api.Contracts.Datacenter.DatacentersWithMaintenanceStatus
            

        
###Properties

####datacenter


##CBU.Compute.Api.Contracts.Datacenter.DatacenterType
            

        
###Properties

####location

####displayName

####city

####state

####country

####vpnUrl

####default


##CBU.Compute.Api.Contracts.Datacenter.DatacenterWithDiskSpeedDetails
            

        
###Properties

####displayName

####city

####state

####country

####vpnUrl

####maxCpu

####maxRamMb

####diskSpeed

####location

####default


##CBU.Compute.Api.Contracts.Datacenter.DatacenterWithLimitsType
            

        
###Properties

####location

####displayName

####city

####state

####country

####vpnUrl

####default

####maxCpu

####maxRamMb


##CBU.Compute.Api.Contracts.Datacenter.DatacenterWithMaintenanceStatusType
            

        
###Properties

####displayName

####city

####state

####country

####vpnUrl

####networking

####hypervisor

####backup

####default

####location


##CBU.Compute.Api.Contracts.Datacenter.DiskSpeedAvailabilityType
            

        
###Properties

####displayName

####abbreviation

####description

####unavailableReason

####id

####default

####available


##CBU.Compute.Api.Contracts.Datacenter.HypervisorType
            

        
###Properties

####diskSpeed

####property

####type

####maintenanceStatus


##CBU.Compute.Api.Contracts.Datacenter.DatacenterDetail
            
Represents CaaS data centre with disk speed details.
        
###Fields

####_diskSpeedDetails
Detailed information about disk speeds available at the data centre.
###Properties

####DiskSpeedDetails
Detailed information about disk speeds available at the data centre.
####DD#CBU#Compute#Api#Contracts#Datacenter#IDatacenterDetail#DiskSpeedDetails
Detailed information about disk speeds available at the data centre.
###Methods


####Constructor
Create a new .

##CBU.Compute.Api.Contracts.Datacenter.DatacenterSummary
            
Represents summary information about a CaaS data centre.
        
###Properties

####IsDefault
Is the data centre the default data centre for the caller's organisation?
####LocationCode
The short location code used as a key to identity the data centre.
####DisplayName
The data centre display name.
####City
The name of the city in which the data centre is located.
####State
The name of the state in which the data centre is located.
####Country
The name of the country in which the data centre is located.
####VpnUrl
The access URL for the data centre VPN.
####MaxCpu
The maximum number of CPUs per virtual machine supported by the data centre.
####MaxRamMB
The maximum RAM (in MB) per virtual machine supported by the data centre.
###Methods


####Constructor
Create a new .

##CBU.Compute.Api.Contracts.Datacenter.DiskSpeedDetail
            
Represents detailed information about a disk speed specification.
        
###Properties

####IsAvailable
Is the disk speed available at the parent data centre?
####IsDefault
Is the disk speed the default disk speed at the parent data centre?
####Id
The disk speed Id.
####DisplayName
A display name for the disk speed.
####Abbreviation
An abbreviated name for the disk speed.
####Description
A description of the disk speed.
###Methods


####Constructor
Create a new .

##CBU.Compute.Api.Contracts.Datacenter.Geo
            

        
###Fields

####

###Properties

####id

####geoKey

####name

####cloudUiUrl

####cloudApiUrl

####isHome

####productKey

####pricingUrl

####state


##CBU.Compute.Api.Contracts.Datacenter.Geos
            

        
###Fields

####Items


##CBU.Compute.Api.Contracts.Datacenter.IDatacenterSummary
            
Provides read-only access to summary information about a CaaS data centre.
        
###Properties

####IsDefault
Is the data centre the default data centre for the caller's organisation?
####LocationCode
The short location code used as a key to identity the data centre.
####DisplayName
The data centre display name.
####City
The name of the city in which the data centre is located.
####State
The name of the state in which the data centre is located.
####Country
The name of the country in which the data centre is located.
####VpnUrl
The access URL for the data centre VPN.
####MaxCpu
The maximum number of CPUs per virtual machine supported by the data centre.
####MaxRamMB
The maximum RAM (in MB) per virtual machine supported by the data centre.

##CBU.Compute.Api.Contracts.Datacenter.IDatacenterDetail
            
Provides read-only access to summary information about a CaaS data centre (with disk speed detail).
        
###Properties

####DiskSpeedDetails
Detailed information about disk speeds available at the data centre.

##CBU.Compute.Api.Contracts.Datacenter.IDiskSpeedDetail
            
Provides read-only access to detailed information about a disk speed specification.
        
###Properties

####IsAvailable
Is the disk speed available at the parent data centre?
####IsDefault
Is the disk speed the default disk speed at the parent data centre?
####Id
The disk speed Id.
####DisplayName
A display name for the disk speed.
####Abbreviation
An abbreviated name for the disk speed.
####Description
A description of the disk speed.

##CBU.Compute.Api.Contracts.Directory.AccountsWithPhoneNumber
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Directory.AccountWithPhoneNumber
            

        
###Properties

####userName

####fullName

####firstName

####lastName

####password

####emailAddress

####phoneCountryCode

####phoneNumber

####department

####customDefined1

####customDefined2

####orgId

####MemberOfRoles
Roles (if any) to which the account belongs.

##CBU.Compute.Api.Contracts.Directory.RoleType
            
Sub-Administrator role type.
        
###Fields

####Network
An enum constant representing the network option.
####Backup
An enum constant representing the backup option.
####Server
An enum constant representing the server option.
####CreateImage
An enum constant representing the create image option.
####Storage
An enum constant representing the storage option.
####Reports
An enum constant representing the reports option.
####Tag
An enum constant representing the tag option.
####ReadOnly
An enum constant representing the read only option.

##CBU.Compute.Api.Contracts.Directory.Account
            
Represents a CaaS user account.	
        
###Fields

####_memberOfRoles
Roles (if any) to which the account belongs.
####
The items
###Properties

####

####

####

####

####

####

####

####

####

####

####

####

####

####
Roles (if any) to which the account belongs.
####UserName
The user login name associated with the account.
####FullName
The full name of the user associated with the account.
####FirstName
The first name of the user associated with the account.
####LastName
The last name of the user associated with the account.
####EmailAddress
The e-mail address of the user associated with the account.
####Department
The name of the department to which the account's user belongs.
####CustomDefined1
Custom field 1.
####CustomDefined2
Custom field 2.
####OrganizationId
The Id of the organisation to which the account belongs.
####Password
The password
####MemberOfRoles
Roles (if any) to which the account belongs.
####DD#CBU#Compute#Api#Contracts#Directory#IAccount#MemberOfRoles
Roles (if any) to which the account belongs.
###Methods


####Constructor
Create a new CaaS user account data-contract.

##CBU.Compute.Api.Contracts.Directory.Accounts
            
The accounts
        
###Fields

####Items
The items
###Properties

####


##CBU.Compute.Api.Contracts.Directory.IAccount
            
Provides read-only access to information about a CaaS account.
        
###Properties

####UserName
The user login name associated with the account.
####FullName
The full name of the user associated with the account.
####FirstName
The first name of the user associated with the account.
####LastName
The last name of the user associated with the account.
####EmailAddress
The e-mail address of the user associated with the account.
####Department
The name of the department to which the account's user belongs.
####CustomDefined1
Custom field 1.
####CustomDefined2
Custom field 2.
####OrganizationId
The Id of the organisation to which the account belongs.
####MemberOfRoles
Roles (if any) to which the account belongs.

##CBU.Compute.Api.Contracts.Directory.IRole
            
Provides read-only access to information about a role in the CaaS API.
        
###Properties

####Name
The name of the CaaS role.

##CBU.Compute.Api.Contracts.Directory.Role
            
Represents a role in the CaaS API.
        
###Fields

####
An enum constant representing the network option.
####
An enum constant representing the backup option.
####
An enum constant representing the server option.
####
An enum constant representing the create image option.
####
An enum constant representing the storage option.
####
An enum constant representing the reports option.
####
An enum constant representing the tag option.
####
An enum constant representing the read only option.
###Properties

####Name
The name of the CaaS role.
###Methods


####Constructor
Create a new CaaS role data-contract.

####Constructor
Create a new CaaS role data-contract using the helper enum

####Constructor
Create a new CaaS role data-contract using string

##CBU.Compute.Api.Contracts.Image.CopyRemoteOvfPackageHistory
            

        
###Properties

####copyRemoteOvfPackageRecord

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Image.CopyRemoteOvfPackageRecordType
            

        
###Properties

####mfFile

####ovfFile

####vmdkFile

####startDate

####endDate

####result

####resultCode

####resultDetail

####id

####sourceGeoKey


##CBU.Compute.Api.Contracts.Image.DeployedImages
            

        
###Properties

####DeployedImage

####

####


##CBU.Compute.Api.Contracts.Image.DeployedImagesWithDisks
            

        
###Properties

####DeployedImageWithDisks


##CBU.Compute.Api.Contracts.Image.DeployedImagesWithSoftwareLabels
            

        
###Properties

####DeployedImageWithSoftwareLabels


##CBU.Compute.Api.Contracts.Image.DeployedImageType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceServerId

####deployedTime

####deployedTimeSpecified

####location

####status


##CBU.Compute.Api.Contracts.Image.DeployedImageWithDisksType
            

        
###Properties

####additionalDisk


##CBU.Compute.Api.Contracts.Image.DeployedImageWithSoftwareLabelsType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceServerId

####deployedTime

####deployedTimeSpecified

####location

####status

####softwareLabel


##CBU.Compute.Api.Contracts.Image.ImageCopies
            

        
###Properties

####imageCopy


##CBU.Compute.Api.Contracts.Image.ImageCopyType
            

        
###Properties

####targetImage

####imageCopyId

####sourceLocation

####sourceImageId

####sourceImageName

####ovfPackagePrefix


##CBU.Compute.Api.Contracts.Image.ImageExportHistory
            

        
###Properties

####imageExportRecord


##CBU.Compute.Api.Contracts.Image.ImageExportRecord
            

        
###Properties

####userName

####image

####endDate

####result

####resultDetail

####resultCode

####outputFile

####id

####ovfPackagePrefix

####startDate


##CBU.Compute.Api.Contracts.Image.ImageExports
            

        
###Properties

####imageExport


##CBU.Compute.Api.Contracts.Image.ImageExportType
            

        
###Properties

####image

####status

####id

####ovfPackagePrefix

####startDate


##CBU.Compute.Api.Contracts.Image.ImageNameExists
            

        
###Properties

####location

####imageName


##CBU.Compute.Api.Contracts.Image.ImageSummaryType
            

        
###Properties

####name

####description

####location

####operatingSystem

####cpuCount

####memoryMb

####osStorageGb

####additionalDisk

####id

####

####


##CBU.Compute.Api.Contracts.Image.ImageSummaryTypeAdditionalDisk
            

        
###Properties

####scsiId

####sizeGb


##CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeed
            

        
###Properties

####image

####pageNumber

####pageCount

####totalCount

####pageSize

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImage
            

        
###Properties

####name

####description

####cpuCount

####memoryMb

####created

####state

####operatingSystem

####disk

####source

####id

####location

####softwareLabel

####

####

####

####

####

####

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImageOperatingSystem
            

        
###Properties

####id

####displayName

####type


##CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImageDisk
            

        
###Properties

####id

####scsiId

####sizeGb

####speed

####state


##CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImageSource
            

        
###Properties

####artifact

####type

####

####


##CBU.Compute.Api.Contracts.Image.ImagesWithDiskSpeedImageSourceArtifact
            

        
###Properties

####type

####value


##CBU.Compute.Api.Contracts.Image.NewImageCopy
            

        
###Properties

####sourceImageId

####targetImageName

####targetImageDescription

####targetLocation

####ovfPackagePrefix


##CBU.Compute.Api.Contracts.Image.NewImageExport
            

        
###Properties

####imageId

####ovfPackagePrefix


##CBU.Compute.Api.Contracts.Image.NewImageImport
            

        
###Properties

####ovfPackage

####name

####location

####description


##CBU.Compute.Api.Contracts.Image.NewQueueOvfCopyType
            

        
###Properties

####destinationGeoId

####sourceOvfPackage


##CBU.Compute.Api.Contracts.Image.NewRemoteOvfCopy
            

        
###Properties

####sourceGeoId

####sourceOvfPackage


##CBU.Compute.Api.Contracts.Image.OvfPackageFileType
            

        
###Properties

####name

####sizeBytes


##CBU.Compute.Api.Contracts.Image.OvfPackages
            

        
###Properties

####ovfPackage


##CBU.Compute.Api.Contracts.Image.OvfPackageType
            

        
###Properties

####name

####timestamp

####expiry

####status


##CBU.Compute.Api.Contracts.Image.OvfRemoteCopies
            

        
###Properties

####ovfCopy

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Image.OvfRemoteCopyType
            

        
###Properties

####name

####state

####status

####remoteCopyId

####sourceGeoKey


##CBU.Compute.Api.Contracts.Image.PendingDeployImages
            

        
###Properties

####PendingDeployImage


##CBU.Compute.Api.Contracts.Image.PendingDeployImageType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceServerId

####location

####status


##CBU.Compute.Api.Contracts.Image.PendingDeployImageWithSoftwareLabelsType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceServerId

####location

####status

####softwareLabel


##CBU.Compute.Api.Contracts.Image.ServerImages
            

        
###Fields

####Items

####

####


##CBU.Compute.Api.Contracts.Image.ServerImage
            

        
###Fields

####

####id

####resourcePath

####name

####description

####location

####cpuCount

####memory

####osStorage

####additionalLocalStorage

####created

####operatingSystem

####

####


##CBU.Compute.Api.Contracts.Image.ServerImagesServerImageOperatingSystem
            

        
###Fields

####type

####displayName


##CBU.Compute.Api.Contracts.Network.AclActionType
            

        
###Fields

####DENY

####PERMIT


##CBU.Compute.Api.Contracts.Network.AclProtocolType
            
All the ACL Protocol types.
        
###Fields

####IP
IP type
####ICMP
ICMP type
####TCP
TCP type
####UDP
UDP type

##CBU.Compute.Api.Contracts.Network.AclRuleListType
            

        
###Properties

####name

####AclRule


##CBU.Compute.Api.Contracts.Network.AclRuleType
            

        
###Properties

####id

####name

####status

####position

####action

####protocol

####sourceIpRange

####destinationIpRange

####portRange

####type


##CBU.Compute.Api.Contracts.Network.AclType
            

        
###Fields

####OUTSIDE_ACL

####INSIDE_ACL


##CBU.Compute.Api.Contracts.Network.IpBlockType
            

        
###Properties

####id

####baseIp

####subnetSize

####networkDefault

####serverToVipConnectivity


##CBU.Compute.Api.Contracts.Network.IpList
            

        
###Properties

####subnetSize

####ip


##CBU.Compute.Api.Contracts.Network.IpRangeType
            

        
###Properties

####ipAddress

####netmask


##CBU.Compute.Api.Contracts.Network.Ips
            

        
###Properties

####subnetSize

####Ip


##CBU.Compute.Api.Contracts.Network.NatRules
            

        
###Properties

####NatRule


##CBU.Compute.Api.Contracts.Network.NatRuleType
            

        
###Properties

####id

####name

####natIp

####sourceIp


##CBU.Compute.Api.Contracts.Network.NetworkConfigurationType
            

        
###Properties

####network

####hostName

####agg

####aggSpecified

####location

####context

####contextSpecified

####acePair

####acePairSpecified

####intVlan

####intVlanSpecified

####outVlan

####outVlanSpecified

####publicSnat

####privateSnat

####publicNet

####privateNet

####publicIps

####privateIps


##CBU.Compute.Api.Contracts.Network.NetworkConfigurationWithLocationType
            

        
###Properties

####id

####name

####description

####location

####privateNet

####multicast

####privateSnat

####publicSnat

####publicIps

####privateIps


##CBU.Compute.Api.Contracts.Network.NetworkingType
            

        
###Properties

####property

####type

####maintenanceStatus


##CBU.Compute.Api.Contracts.Network.Networks
            

        
###Properties

####Network


##CBU.Compute.Api.Contracts.Network.NetworkType
            

        
###Properties

####id

####resourcePath

####name

####description

####multicast

####multicastSpecified


##CBU.Compute.Api.Contracts.Network.NetworkWithLocations
            

        
###Fields

####Items

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Network.NetworkWithLocationsNetwork
            

        
###Fields

####id

####name

####description

####location

####privateNet

####multicast


##CBU.Compute.Api.Contracts.Network.NetworkWithLocationType
            

        
###Properties

####id

####name

####description

####location

####privateNet

####multicast


##CBU.Compute.Api.Contracts.Network.NewNetworkWithLocationType
            

        
###Properties

####name

####description

####location


##CBU.Compute.Api.Contracts.Network.PortRangeType
            

        
###Fields

####

####

####

####

####

###Properties

####type

####port1

####port1Specified

####port2

####port2Specified


##CBU.Compute.Api.Contracts.Network.PortRangeTypeType
            

        
###Fields

####ALL

####EQUAL_TO

####RANGE

####GREATER_THAN

####LESS_THAN


##CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupSnapshotListOptions
            
Filtering options for the Consistency Group Snapshot.
        
###Fields

####IdField
The "consistencyGroupId" field name.
####CreateTimeField
The "createTime.MIN" field name.
###Properties

####CreateTimeMax
Gets or sets the CreateTimeMax filter.

##CBU.Compute.Api.Contracts.Requests.Drs.ConsistencyGroupListOptions
            
Filtering options for the Consistency Group.
        
###Fields

####IdField
The "id" field name.
####SourceDatacenterIdField
The "source datacenterId" field name.
####TargetDatacenterIdField
The "target datacenterId" field name.
####SourceNetworkDomainIdField
The "source source network domain id" field name.
####TargetNetworkDomainIdField
The "target network domain id" field name.
####SourceServerIdField
The source server id field name.
####TargetServerIdField
The "target server id" field name.
####OperationStatusField
The "operation status" field name.
####DrsInfrastructureStatusField
The DRS infrastructure status field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Gets or sets the id filter.
####SourceDatacenterId
Identifies the source Data Center.
####TargetDatacenterId
Identifies the target Data Center.
####SourceNetworkDomainId
Identifies the source network domain id.
####TargetNetworkDomainId
Identifies the target network domain id.
####SourceServerId
Identifies the source server id.
####TargetServerId
Identifies the target server id.
####OperationStatus
Identifies the operation status.
####DrsInfrastructureStatus
The DRS infrastructure status field.
####Name
Identifies consistency group by their name.
####State
Gets or sets the State filter.

##CBU.Compute.Api.Contracts.Requests.Filter
            
A single request filter.
        
###Fields

####
The equals
####
The like
####
The greater than
####
The greater or equal
####
The less than
####
The less or equal
####
The null.
####
The not null.
###Properties

####Field
Gets or sets the field name.
####Operator
Gets or sets the filter operator.
####Value
Gets or sets the value.
####
Gets the filters.
###Methods


####ToString
Returns a that represents this instance.
> #####Return value
> A that represents this instance.

####Constructor
Initializes a new instance of the class.

####
Gets the filter value.
> #####Parameters
> **field:** The field name.


####
Gets the filter value.
> #####Parameters
> **field:** The field name.

> **operator:** The filter operator.


####
Gets the filter value.
> #####Parameters
> **filter:** The filter.


####
Sets the filter value.
> #####Parameters
> **field:** The field name.

> **value:** The value.


####
Sets the filter value.
> #####Parameters
> **field:** The field name.

> **operator:** The filter operator.

> **value:** The value.


##CBU.Compute.Api.Contracts.Requests.FilterOperator
            
The filter operator.
        
###Fields

####Equals
The equals
####Like
The like
####GreaterThan
The greater than
####GreaterOrEqual
The greater or equal
####LessThan
The less than
####LessOrEqual
The less or equal
####Null
The null.
####NotNull
The not null.

##CBU.Compute.Api.Contracts.Requests.FilterableRequest
            
The interface need to be implemented by requests which support filtering options.
        
###Properties

####Filters
Gets the filters.
###Methods


####Constructor
Initializes a new instance of the class.

####GetFilter``1(System.String)
Gets the filter value.
> #####Parameters
> **field:** The field name.


####GetFilter``1(System.String,DD.CBU.Compute.Api.Contracts.Requests.FilterOperator)
Gets the filter value.
> #####Parameters
> **field:** The field name.

> **operator:** The filter operator.


####GetFilter``1(DD.CBU.Compute.Api.Contracts.Requests.Filter)
Gets the filter value.
> #####Parameters
> **filter:** The filter.


####SetFilter(System.String,System.Object)
Sets the filter value.
> #####Parameters
> **field:** The field name.

> **value:** The value.


####SetFilter(System.String,DD.CBU.Compute.Api.Contracts.Requests.FilterOperator,System.Object)
Sets the filter value.
> #####Parameters
> **field:** The field name.

> **operator:** The filter operator.

> **value:** The value.


##CBU.Compute.Api.Contracts.Requests.IFilterableRequest
            
The interface need to be implemented by requests which support filtering options.
        
###Properties

####Filters
Gets the filters.

##CBU.Compute.Api.Contracts.Requests.Infrastructure.OperatingSystemListOptions
            
Filtering options for the operating system request.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####FamilyField
The "Family" field name.
###Properties

####Id
Gets or sets the id filter.
####Name
Gets or sets the Name filter.
####Family
Gets or sets the operating system family filter.

##CBU.Compute.Api.Contracts.Requests.Infrastructure.DataCenterListOptions
            
Filtering options for the data center request.
        
###Fields

####IdField
The "id" field name.
###Properties

####Id
Filter by identifier.

##CBU.Compute.Api.Contracts.Requests.Network20.ReservedIpv6ListOptions
            
The reserved ip v6 list options.
        
###Fields

####VlanIdField
The "vlanId" field name.
####IpAddressField
The "ipAddress" field name.
###Properties

####VlanId
Identifies VLAN id.
####IpAddress
Identifies private IPv4 addresses.

##CBU.Compute.Api.Contracts.Requests.Network20.ReservedPublicIpv4ListOptions
            
The reserved public IP v4 list options.
        
###Fields

####NetworkIdField
The "networkId" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####IpBlockIdField
The "ipBlockId" field name.
####IpAddressField
The "ipAddress" field name.
###Properties

####NetworkId
Identifies MCP 1.0 network id.
####NetworkDomainId
Identifies MCP 2.0 network domain id.
####IpBlockId
Identifies IP Block id.
####IpAddress
Identifies private IPv4 addresses.

##CBU.Compute.Api.Contracts.Requests.Network20.ReservedPrivateIpv4ListOptions
            
The reserved private ip v4 list options.
        
###Fields

####NetworkIdField
The "networkId" field name.
####VlanIdField
The "vlanId" field name.
####IpAddressField
The "ipAddress" field name.
###Properties

####NetworkId
Identifies MCP 1.0 network id.
####VlanId
Identifies VLAN id.
####IpAddress
Identifies private IPv4 addresses.

##CBU.Compute.Api.Contracts.Requests.Network20.PortListOptions
            
An ip address list options model.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Filter by identifier.
####Name
Filter by their name.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.IpAddressListOptions
            
An ip address list options model.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####IpVersionField
The "ipVersion" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Filter by identifier.
####IpVersion
Filter by Ip version.
####Name
Filter by their name.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.PublicIpListOptions
            
The NAT Rule list options type.
        
###Fields

####IdField
The "id" field name.
####DatacenterIdField
The "datacenterId" field name.
####CreateTimeField
The "createTime" field name.
####StateField
The "state" field name.
####BaseIpField
The "baseIp" field name.
####SizeField
The "size" field name.
###Properties

####Id
Gets or sets the id filter.
####DatacenterId
Identifies an individual Data Center.
####BaseIp
Identifies an Datacenter.
####Size
Filters by size.
####State
Filters by State.
####CreateTimeBefore
Gets or sets the CreateTimeBefore filter.
####CreateTimeAfter
Gets or sets the CreateTimeAfter filter.
####CreateTimeMin
Gets or sets the CreateTimeAfter Inclusive filter.
####CreateTimeMax
Gets or sets the CreateTimeMax filter.

##CBU.Compute.Api.Contracts.Requests.Network20.NatRuleListOptions
            
The NAT Rule list options type.
        
###Fields

####IdField
The "id" field name.
####StateField
The "state" field name.
####InternalIpField
The "internalIp" field name.
####ExternalIpField
The "externalIp" field name.
####NodeIdField
The "nodeIdField" field name.
###Properties

####Id
Identifies an individual NAT Rule.
####State
Identifies NAT Rules by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".
####InternalIp
Identifies internal IPv4 address addresses.
####ExternalIp
Identifies external IPv4 addresses.
####NodeId
Identifies NAT Rule by node id.

##CBU.Compute.Api.Contracts.Requests.Network20.NetworkDomainListOptions
            
Filtering options for the network request.
        
###Fields

####IdField
The "id" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####TypeField
The "type" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Gets or sets the id filter.
####DatacenterId
Identifies an individual Data Center.
####Name
Identifies Virtual Listeners by their name.
####Type
Gets or sets the Type filter.
####State
Gets or sets the State filter.

##CBU.Compute.Api.Contracts.Requests.Network20.FirewallRuleListOptions
            
A firewall rule list options model.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Filter by identifier.
####NetworkDomainId
Filter by Network Domain.
####Name
Filter by their name.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.DefaultHealthMonitorListOptions
            
A default health monitor list options model.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
###Properties

####Id
Filter by identifier.
####Name
Filter by their name.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.DefaultIruleListOptions
            
A iRule list options model.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
###Properties

####Id
Filter by identifier.
####Name
Filter by their name.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.DefaultPersistenceProfileListOptions
            
A persistence profile list options model.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
###Properties

####Id
Filter by identifier.
####Name
Filter by their name.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.SecurityGroupListOptions
            
A VLAN list options model.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####CreateTimeField
The "createTime" field name.
####StateField
The "state" field name.
###Properties

####Id
Gets or sets the id filter.
####Name
Gets or sets the Name filter.
####State
Identifies VLANs by their state. Case insensitive. The initial possible set of values for vlan.state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE", "REQUIRES_SUPPORT" This set of values should not be assumed to be static and can increase at any time.
####CreateTimeBefore
Gets or sets the CreateTimeBefore filter.
####CreateTimeAfter
Gets or sets the CreateTimeAfter filter.
####CreateTimeMin
Gets or sets the CreateTimeAfter Inclusive filter.
####CreateTimeMax
Gets or sets the CreateTimeMax filter.

##CBU.Compute.Api.Contracts.Requests.Network20.VlanListOptions
            
A VLAN list options model.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####PrivateIpv4AddressField
The "privateIpv4Address" field name.
####Ipv6AddressField
The "ipv6Address" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Identifies an individual Virtual Listener.
####NetworkDomainId
Identifies an individual Network Domain.
####DatacenterId
Identifies an individual Data Center.
####Name
Identifies Virtual Listeners by their name.
####PrivateIpv4Address
Identifies VLANs by their base network IPv4 address. privateIpv4Address=10.1.1.0.
####Ipv6Address
Identifies VLANs by their base network IPv6 address. ipv6Address= 2607:f480:1111:1102:0:0:0:0.
####State
Identifies VLANs by their state. Case insensitive. The initial possible set of values for vlan.state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT". This set of values should not be assumed to be static and can increase at any time.
####CreateTimeBefore
Identifies the date of creation of VLANs. Supports MIN, MAX, LT and GT. Refer to samples in Paging and Filtering for List API Functions.
####CreateTimeAfter
Identifies the date of creation of VLANs. Supports MIN, MAX, LT and GT. Refer to samples in Paging and Filtering for List API Functions.

##CBU.Compute.Api.Contracts.Requests.Network20.NodeListOptions
            
The Node list options.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
####Ipv4AddressField
The "ipv4Address" field name.
####Ipv6AddressField
The "ipv6Address" field name.
###Properties

####Id
Identifies an individual Virtual Listener.
####NetworkDomainId
Identifies an individual Network Domain.
####DatacenterId
Identifies an individual Data Center.
####Name
Identifies Virtual Listeners by their name.
####State
Identifies Nodes by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".
####Ipv4Address
Identifies Nodes by their specific Ipv4Address.
####Ipv6Address
Identifies Nodes by their specific Ipv6Address.

##CBU.Compute.Api.Contracts.Requests.Network20.PoolListOptions
            
The pool list options.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
####LoadBalancedMethodField
The "loadBalancedMethod" field name.
####ServiceDownActionField
The "serviceDownAction" field name.
####SlowRampTimeField
The "slowRampTime" field name.
###Properties

####Id
Gets or sets the id filter.
####NetworkDomainId
Identifies an individual Network Domain.
####DatacenterId
Identifies an individual Data Center.
####Name
Identifies Pools by their name.
####State
Identifies Pools by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".
####LoadBalancedMethod
Identifies Pools with the supplied loadBalanceMethod(s). loadBalanceMethod=ROUND_ROBIN
####ServiceDownAction
Filters the list to Pools with the supplied serviceDownAction(s). serviceDownAction=DROP
####SlowRampTime
Filters the list to Pools with the supplied slowRampTime(s).

##CBU.Compute.Api.Contracts.Requests.Network20.PoolMemberListOptions
            
The Pool Members list option.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####DatacenterIdField
The "datacenterId" field name.
####PoolIdField
The "poolId" field name.
####PoolNameField
The "poolName" field name.
####NodeIdField
The "nodeId" field name.
####NodeNameField
The "nodeName" field name.
####NodeIpField
The "nodeIp" field name.
####NodeStatusField
The "nodeStatus" field name.
####PortField
The "port" field name.
####StateField
The "state" field name.
####StatusField
The "status" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Gets or sets the id filter.
####NetworkDomainId
Identifies an individual Network Domain.
####DatacenterId
Identifies an individual Data Center.
####PoolId
Identifies an individual Pool.
####PoolName
Identifies Pools by their name.
####NodeId
Identifies an individual Node.
####NodeName
Identifies Nodes by their name.
####NodeIp
Identifies Nodes by their ipv4Address or by their ipv6Address.
####NodeStatus
Identifies Nodes by their status. nodeStatus=ENABLED
####Port
Identifies Pool Members by their port value.
####Status
Identifies Pool Members by their status.
####State
Identifies Pool Members by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Network20.VirtualListenerListOptions
            
The Virtal Listener List Options type.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####EnabledField
The "enabled" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
####TypeField
The "type" field name.
####ProtocolField
The "protocol" field name.
####ListenerIpAddressField
The "listenerIpAddress" field name.
####PortField
The "port" field name.
####PoolIdField
The "poolId" field name.
####ClientClonePoolIdField
The "clientClonePoolId" field name.
####PersistenceProfileIdField
The "persistenceProfileId" field name.
####FallbackPersistenceProfileIdField
The "fallbackPersistenceProfileId" field name.
###Properties

####Id
Identifies an individual Virtual Listener.
####NetworkDomainId
Identifies an individual Network Domain.
####DatacenterId
Identifies an individual Data Center.
####Name
Identifies Virtual Listeners by their name.
####Enabled
Identifies Virtual Listeners by whether or not they are enabled.
####State
Identifies Virtual Listeners by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".
####Type
Identifies Virtual Listeners by their type.
####Protocol
Identifies Virtual Listeners by their protocol.
####ListenerIpAddress
Identifies Virtual Listeners by their Listener IP Address.
####Port
Identifies Virtual Listeners by their virtual listener port.
####PoolId
Identifies Virtual Listeners by their Pool Id.
####ClientClonePoolId
Identifies Virtual Listeners by their Client Pool Id.
####PersistenceProfileId
Identifies Virtual Listeners by their default Persistence profile Id.
####FallbacKPersistenceProfileId
Identifies Virtual Listeners by their Fallback Persistence Profile Id.

##CBU.Compute.Api.Contracts.Requests.Server20.AntiAffinityRuleListOptions
            
Filtering options for the anti affinity rule request.
        
###Fields

####IdField
The "id" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
###Properties

####Id
Filter by identifier.
####State
Filter by their state. Case insensitive. The initial possible set of values for state are: "NORMAL", "PENDING_ADD", "PENDING_CHANGE", "PENDING_DELETE", "FAILED_ADD", "FAILED_CHANGE", "FAILED_DELETE" and "REQUIRES_SUPPORT".

##CBU.Compute.Api.Contracts.Requests.Server20.ServerCustomerImageListOptions
            
Filtering options for the server request.
        
###Fields

####IdField
The "id" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####CreateTimeField
The "createTime" field name.
####StateField
The "state" field name.
####OperatingSystemIdField
The "operatingSystemId" field name.
####OperatingSystemFamilyField
The "operatingSystemFamily" field name.
###Properties

####Id
Gets or sets the id filter.
####DatacenterId
Gets or sets the DatacenterId filter.
####Name
Gets or sets the Name filter.
####CreateTimeBefore
Gets or sets the CreateTimeBefore filter.
####CreateTimeAfter
Gets or sets the CreateTimeAfter filter.
####CreateTimeMin
Gets or sets the CreateTimeAfter Inclusive filter.
####CreateTimeMax
Gets or sets the CreateTimeMax filter.
####State
Gets or sets the State filter.
####OperatingSystemId
Gets or sets the Operating SystemId filter like REDHAT664.
####OperatingSystemFamily
Gets or sets the Operating System Family filter. eg : UNIX

##CBU.Compute.Api.Contracts.Requests.Server20.ListNicsOptions
            
Filtering options for the List NICs request.
        
###Fields

####IdField
The "id" field name.
####ServerIdField
The "serverId" field name.
####SecurityGroupIdField
The "securityGroupId" field name.
####SecurituGroupField
The "securitygroup" field name.
###Properties

####Id
Identifies an individual server nic.
####ServerId
Identifies an individual server.
####SecurityGroupId
Identifies an individual security group.
####SecurityGroup
Identifies an individual security group.

##CBU.Compute.Api.Contracts.Requests.Server20.ServerOsImageListOptions
            
Filtering options for the server request.
        
###Fields

####IdField
The "id" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####DatacenterIdField
The "datacenterId" field name.
####NameField
The "name" field name.
####StateField
The "state" field name.
####CreateTimeField
The "createTime" field name.
####OperatingSystemIdField
The "operatingSystemId" field name.
####OperatingSystemFamilyField
The "operatingSystemFamily" field name.
###Properties

####Id
Identifies an individual Virtual Listener.
####DatacenterId
Identifies an individual Data Center.
####Name
Identifies Virtual Listeners by their name.
####CreateTimeBefore
Gets or sets the CreateTimeBefore filter.
####CreateTimeAfter
Gets or sets the CreateTimeAfter filter.
####CreateTimeMin
Gets or sets the CreateTimeAfter Inclusive filter.
####CreateTimeMax
Gets or sets the CreateTimeBefore Inclusive filter.
####State
Gets or sets the State filter.
####OperatingSystemId
Gets or sets the Operating SystemId filter like REDHAT664.
####OperatingSystemFamily
Gets or sets the Operating System Family filter. eg : UNIX

##CBU.Compute.Api.Contracts.Requests.Server20.ServerListOptions
            
Filtering options for the server request.
        
###Fields

####IdField
The "id" field name.
####DatacenterIdField
The "datacenterId" field name.
####NetworkDomainIdField
The "networkDomainId" field name.
####NetworkIdField
The "networkId" field name.
####VlanIdField
The "vlanId" field name.
####SourceImageIdField
The "sourceImageId" field name.
####DeployedField
The "deployed" field name.
####NameField
The "name" field name.
####CreateTimeField
The "createTime" field name.
####StateField
The "state" field name.
####StartedField
The "started" field name.
####OperatingSystemIdField
The "operatingSystemId" field name.
####Ipv6Field
The "ipv6" field name.
####PrivateIpv4Field
The "privateIpv4" field name.
####DrsEligibleField
The "privateIpv4" field name.
###Properties

####Id
Identifies an individual Virtual Listener.
####NetworkDomainId
Identifies an individual Network Domain.
####DatacenterId
Identifies an individual Data Center.
####NetworkId
Gets or sets the NetworkId filter.
####VlanId
Gets or sets the VlanId filter.
####SourceImageId
Gets or sets the SourceImageId filter.
####Deployed
Gets or sets the Deployed filter.
####Name
Identifies Virtual Listeners by their name.
####CreateTimeBefore
Gets or sets the CreateTimeBefore filter.
####CreateTimeAfter
Gets or sets the CreateTimeAfter filter.
####State
Gets or sets the State filter.
####Started
Gets or sets the Started filter.
####OperatingSystemId
Gets or sets the OperatingSystemId filter.
####Ipv6
Gets or sets the Ipv6 filter.
####PrivateIpv4
Gets or sets the PrivateIpv4 filter.
####DrsEligible
Gets or sets the drsEligible filter.

##CBU.Compute.Api.Contracts.Requests.NullFilterOptions
            
The null filter options.
        
###Fields

####NULL
The null.
####NOT_NULL
The no t_ null.

##CBU.Compute.Api.Contracts.Requests.Server.ServerListOptions
            
Filtering options for the server request.
        
###Fields

####IdField
The "id" field name.
####LocationField
The "location" field name.
####NameField
The "name" field name.
####MachineNameField
The "machineName" field name.
####NetworkIdField
The "networkId" field name.
####SourceImageIdField
The "sourceImageId" field name.
####DeployedField
The "deployed" field name.
####CreateTimeField
The "createTime" field name.
####PrivateIpField
The "privateIp" field name.
###Properties

####Id
Gets or sets the Id filter.
####Location
Gets or sets the Location filter.
####Name
Gets or sets the Name filter.
####MachineName
Gets or sets the MachineName filter.
####NetworkId
Gets or sets the NetworkId filter.
####SourceImageId
Gets or sets the SourceImageId filter.
####Deployed
Gets or sets the Deployed filter.
####CreateTimeBefore
Gets or sets the CreateTimeBefore filter.
####CreateTimeAfter
Gets or sets the CreateTimeAfter filter.
####PrivateIp
Gets or sets the PrivateIp filter.

##CBU.Compute.Api.Contracts.Requests.Tagging.TagListOptions
            
The tag key list options.
        
###Fields

####AssetIdField
The "assetId" field name.
####AssetTypeField
The "assetType" field name.
####DatecenterIdField
The "datecenterId" field name.
####TagKeyNameField
The "tagKeyName" field name.
####TagKeyIdField
The "tagKeyId" field name.
####ValueField
The "value" field name.
####ValueRequiredField
The "valueRequired" field name.
####DisplayOnReportField
The "displayOnReport" field name.
###Properties

####AssetId
Gets or sets the asset id.
####AssetType
Gets or sets the asset type.
####DatecenterId
Gets or sets the datecenter id.
####TagKeyName
Gets or sets the tag key name.
####TagKeyId
Gets or sets the tag key id.
####Value
Gets or sets the value.
####ValueRequired
Gets or sets the ValueRequired filter.
####DisplayOnReport
Gets or sets the DisplayOnReport filter.

##CBU.Compute.Api.Contracts.Requests.Tagging.TagKeyListOptions
            
The tag key list options.
        
###Fields

####IdField
The "id" field name.
####NameField
The "name" field name.
####ValueRequiredField
The "valueRequired" field name.
####DisplayOnReportField
The "displayOnReport" field name.
###Properties

####Id
Gets or sets the Id filter.
####Name
Gets or sets the Name filter.
####ValueRequired
Gets or sets the ValueRequired filter.
####DisplayOnReport
Gets or sets the DisplayOnReport filter.

##CBU.Compute.Api.Contracts.Server10.AntiAffinityRules
            

        
###Properties

####antiAffinityRule

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Server10.AntiAffinityRuleType
            

        
###Properties

####serverSummary

####id

####state

####created

####location

####

####

####

####

####

####


##CBU.Compute.Api.Contracts.Server10.AntiAffinityRuleTypeServerSummary
            

        
###Properties

####name

####description

####privateIp

####networkId

####networkName

####id


##CBU.Compute.Api.Contracts.Server.Artifact
            

        
###Properties

####type

####value

####date

####dateSpecified


##CBU.Compute.Api.Contracts.Server.ClientStatusType
            

        
###Fields

####Active

####Offline

####Unregistered


##CBU.Compute.Api.Contracts.Server.DeployedServers
            

        
###Properties

####DeployedServer

####

####

####


##CBU.Compute.Api.Contracts.Server.DeployedServersWithDisks
            

        
###Properties

####DeployedServerWithDisks


##CBU.Compute.Api.Contracts.Server.DeployedServersWithSoftwareLabels
            

        
###Properties

####DeployedServerWithSoftwareLabels


##CBU.Compute.Api.Contracts.Server.DeployedServersWithStatus
            

        
###Properties

####DeployedServerWithStatus


##CBU.Compute.Api.Contracts.Server.DeployedServerType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceImageId

####networkId

####privateIpAddress

####publicIpAddress

####machineName

####isStarted

####deployedTime

####deployedTimeSpecified

####status


##CBU.Compute.Api.Contracts.Server.DeployedServerWithDisksType
            

        
###Properties

####additionalDisk


##CBU.Compute.Api.Contracts.Server.DeployedServerWithSoftwareLabelsType
            

        
###Properties

####softwareLabel


##CBU.Compute.Api.Contracts.Server.DeployedServerWithStatusType
            

        
###Properties

####machineStatus


##CBU.Compute.Api.Contracts.Server.DiskType
            

        
###Properties

####id

####scsiId

####diskSizeGb

####state


##CBU.Compute.Api.Contracts.Server.DiskWithSpeedType
            

        
###Properties

####id

####scsiId

####sizeGb

####speed

####state


##CBU.Compute.Api.Contracts.Server.MachineSpecificationType
            

        
###Properties

####cpuCount

####memoryMb

####osStorageGb

####additionalLocalStorageGb

####operatingSystem


##CBU.Compute.Api.Contracts.Server.MachineStatusType
            

        
###Properties

####value

####name


##CBU.Compute.Api.Contracts.Server.NewAntiAffinityRule
            

        
###Properties

####serverId


##CBU.Compute.Api.Contracts.Server.ChangeDiskSpeed
            

        
###Properties

####speed


##CBU.Compute.Api.Contracts.Server.ChangeDiskSize
            

        
###Properties

####newSizeGb


##CBU.Compute.Api.Contracts.Server.ICustomImageDetail
            
Provides read-only access to detailed information for a user-created CaaS image (with labels for its included software).
        
###Properties

####SourceServerId
The Id of the server from which the image was created.

##CBU.Compute.Api.Contracts.Server.IImageDetail
            
Provides read-only access to information about a deployed CaaS image (with labels for its included software).
        
###Properties

####Id
The image Id.
####Name
The image name.
####Description
The image description.
####MachineSpecification
The specifications of the image's associated virtual machine template.
####CreatedUtc
The UTC date / time that the image was created. Optional, if the image is a custom (user-created) image.
####Location
The location in which the image exists.

##CBU.Compute.Api.Contracts.Server.IMachineSpecification
            
Provides read-only access to information about specifications for a CaaS virtual machine.
        
###Properties

####CpuCount
The virtual machine's number of CPUs.
####MemoryMB
The virtual machine's memory size (in MB).
####OSStorageGB
The size of the virtual machine's OS disk (in GB).
####AdditionalLocalStorageGB
The size of the virtual machine's additional local disks (in GB).
####OperatingSystem
Information about the machine's operating system.

##CBU.Compute.Api.Contracts.Server.IOperatingSystem
            
Provides read-only access to information about a well-known operating system for CaaS virtual machines.
        
###Properties

####OperatingSystemType
The operating system type.
####DisplayName
The operating system display-name.

##CBU.Compute.Api.Contracts.Server.MachineSpecification
            
Represents the specifications for a CaaS virtual machine.
        
###Properties

####

####

####

####

####

####CpuCount
The virtual machine's number of CPUs.
####MemoryMB
The virtual machine's memory size (in MB).
####OSStorageGB
The size of the virtual machine's OS disk (in GB).
####AdditionalLocalStorageGB
The size of the virtual machine's additional local disks (in GB).
####OperatingSystem
Information about the machine's operating system.
####DD#CBU#Compute#Api#Contracts#Server#IMachineSpecification#OperatingSystem
Information about the machine's operating system.
###Methods


####Constructor
Create a new .

##CBU.Compute.Api.Contracts.Server.NewServerToDeployWithDiskSpeed
            
A new server to deploy
        
###Fields

####name

####description

####imageId

####administratorPassword

####start

####privateIp

####networkId

####disk


##CBU.Compute.Api.Contracts.Server.NewServerToDeploy
            
A new server to deploy
        
###Fields

####

####

####

####

####

####

####

####

####name

####description

####vlanResourcePath

####imageResourcePath

####administratorPassword

####isStarted


##CBU.Compute.Api.Contracts.Server.OperatingSystem
            
Represents a well-known operating system for CaaS virtual machines.
        
###Fields

####
An unknown type of operating system. Used to detect uninitialised values; do not use directly.
####
A windows operating system.
####
A UNIX-style operating system.
###Properties

####OperatingSystemType
The operating system type.
####DisplayName
The operating system display-name.
####

####

###Methods


####Constructor
Create a new operating system.

##CBU.Compute.Api.Contracts.Server.OperatingSystemType
            

        
###Fields

####
An unknown type of operating system. Used to detect uninitialised values; do not use directly.
####
A windows operating system.
####
A UNIX-style operating system.
###Properties

####type

####displayName


##CBU.Compute.Api.Contracts.Server.OperatingSystemTypeEnum
            
Well-known operating system types.
        
###Fields

####Unknown
An unknown type of operating system. Used to detect uninitialised values; do not use directly.
####Windows
A windows operating system.
####Unix
A UNIX-style operating system.

##CBU.Compute.Api.Contracts.Server.OSType
            

        
###Properties

####id

####displayName

####type


##CBU.Compute.Api.Contracts.Server.OutputFileType
            

        
###Properties

####type

####name

####sizeBytes

####date

####expiryDate


##CBU.Compute.Api.Contracts.Server.PendingDeployServers
            

        
###Properties

####PendingDeployServer

####


##CBU.Compute.Api.Contracts.Server.PendingDeployServersWithDisks
            

        
###Properties

####PendingDeployServerWithDisks


##CBU.Compute.Api.Contracts.Server.PendingDeployServerType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceImageId

####networkId

####privateIpAddress

####status


##CBU.Compute.Api.Contracts.Server.PendingDeployServerWithDisksType
            

        
###Properties

####additionalDisk


##CBU.Compute.Api.Contracts.Server.PendingDeployServerWithSoftwareLabelsType
            

        
###Properties

####id

####name

####description

####machineSpecification

####sourceImageId

####networkId

####privateIpAddress

####status

####softwareLabel


##CBU.Compute.Api.Contracts.Server.PricedPerType
            

        
###Fields

####SERVER

####CPU


##CBU.Compute.Api.Contracts.Server.ProgressStatusStepType
            

        
###Properties

####name

####number

####percentComplete

####percentCompleteSpecified


##CBU.Compute.Api.Contracts.Server.ProgressStatusType
            

        
###Properties

####action

####requestTime

####userName

####numberOfSteps

####numberOfStepsSpecified

####updateTime

####updateTimeSpecified

####step

####failureReason


##CBU.Compute.Api.Contracts.Server.ServerBackupType
            

        
###Properties

####assetId

####state

####servicePlan


##CBU.Compute.Api.Contracts.Server.ServerImagesWithState
            

        
###Properties

####serverImageWithState


##CBU.Compute.Api.Contracts.Server.ServerImageType
            

        
###Properties

####id

####resourcePath

####name

####description

####operatingSystem

####location

####sourceResourcePath

####cpuCount

####memory

####osStorage

####additionalLocalStorage

####additionalLocalStorageSpecified

####created

####createdSpecified


##CBU.Compute.Api.Contracts.Server.ServerImageWithStateType
            

        
###Properties

####id

####location

####name

####description

####operatingSystem

####cpuCount

####memoryMb

####osStorageGb

####additionalDisk

####softwareLabel

####source

####state

####deployedTime

####deployedTimeSpecified

####machineStatus

####status

####

####


##CBU.Compute.Api.Contracts.Server.ServerImageWithStateTypeSource
            

        
###Properties

####artifact

####type


##CBU.Compute.Api.Contracts.Server.ServerStatusName
            

        
###Fields

####vmwareToolsVersionStatus

####vmwareToolsRunningStatus

####vmwareToolsApiVersion


##CBU.Compute.Api.Contracts.Server.ServersWithBackup
            

        
###Properties

####server

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Server.ServersWithState
            

        
###Properties

####serverWithState

####pageNumber

####pageNumberSpecified

####pageCount

####pageCountSpecified

####totalCount

####totalCountSpecified

####pageSize

####pageSizeSpecified


##CBU.Compute.Api.Contracts.Server.ServerType
            

        
###Properties

####id

####resourcePath

####name

####description

####vlanResourcePath

####imageResourcePath

####operatingSystem

####cpuCount

####cpuCountSpecified

####memory

####memorySpecified

####osStorage

####osStorageSpecified

####additionalLocalStorage

####additionalLocalStorageSpecified

####machineName

####administratorPassword

####privateIPAddress

####isDeployed

####isStarted

####created

####createdSpecified


##CBU.Compute.Api.Contracts.Server.ServerWithBackupType
            

        
###Properties

####backup


##CBU.Compute.Api.Contracts.Server.ServerWithStateType
            

        
###Properties

####name

####description

####operatingSystem

####cpuCount

####memoryMb

####disk

####softwareLabel

####sourceImageId

####networkId

####machineName

####privateIp

####publicIp

####created

####isDeployed

####isStarted

####state

####status

####machineStatus

####id

####location


##CBU.Compute.Api.Contracts.Server.SoftwareLabelType
            

        
###Properties

####displayName

####description

####pricedPer

####runningUnits

####stoppedUnits

####id


##CBU.Compute.Api.Contracts.Software.SoftwareLabels
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Software.SoftwareLabel
            

        
###Properties

####

####displayName

####description

####pricedPer

####runningUnits

####stoppedUnits

####id


##CBU.Compute.Api.Contracts.Vip.NewPersistenceProfile
            

        
###Properties

####name

####serverFarmId

####timeoutMinutes

####type

####direction

####netmask

####cookieName

####cookieType


##CBU.Compute.Api.Contracts.Vip.NewProbe
            

        
###Properties

####name

####type

####probeIntervalSeconds

####errorCountBeforeServerFail

####successCountBeforeServerEnable

####failedProbeIntervalSeconds

####maxReplyWaitSeconds

####requestMethod

####port

####requestUrl

####matchContent

####statusCodeRange


##CBU.Compute.Api.Contracts.Vip.NewServerFarmRealServer
            

        
###Properties

####id

####port


##CBU.Compute.Api.Contracts.Vip.ProbeStatusCodeRange
            

        
###Properties

####lowerBound

####upperBound


##CBU.Compute.Api.Contracts.Vip.NewRealServer
            

        
###Properties

####name

####serverId

####inService


##CBU.Compute.Api.Contracts.Vip.NewServerFarm
            

        
###Properties

####

####

####name

####probeId

####predictor

####realServer


##CBU.Compute.Api.Contracts.Vip.NewVip
            

        
###Properties

####name

####ipAddress

####port

####protocol

####vipTargetType

####vipTargetId

####replyToIcmp

####inService


##CBU.Compute.Api.Contracts.Vip.PersistenceProfiles
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Vip.PersistenceProfile
            

        
###Properties

####

####id

####state

####name

####serverFarmId

####serverFarmName

####timeout

####type

####cookieName

####cookieType

####direction

####netmask


##CBU.Compute.Api.Contracts.Vip.Probes
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Vip.ProbeRequestMethod
            

        
###Fields

####GET

####HEAD


##CBU.Compute.Api.Contracts.Vip.ProbeType
            

        
###Fields

####TCP

####UDP

####HTTP

####HTTPS

####ICMP


##CBU.Compute.Api.Contracts.Vip.RealServers
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Vip.RealServer
            

        
###Properties

####

####id

####name

####serverId

####serverName

####serverIp

####inService


##CBU.Compute.Api.Contracts.Vip.ServerFarmDetails
            

        
###Properties

####id

####name

####predictor

####probe

####realServer


##CBU.Compute.Api.Contracts.Vip.ServerFarmProbe
            

        
###Properties

####id

####name

####type

####probeIntervalSeconds


##CBU.Compute.Api.Contracts.Vip.ServerFarmRealServer
            

        
###Properties

####id

####name

####ipAddress

####port

####inService


##CBU.Compute.Api.Contracts.Vip.ServerFarms
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Vip.ServerFarm
            

        
###Properties

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####

####id

####name

####predictor


##CBU.Compute.Api.Contracts.Vip.Vips
            

        
###Properties

####Items


##CBU.Compute.Api.Contracts.Vip.Vip
            

        
###Properties

####

####id

####name

####ipAddress

####port

####protocol

####vipTargetType

####vipTargetId

####vipTargetName

####replyToIcmp

####inService


##CBU.Compute.Api.Contracts.XmlNamespaceConstants
            
XML namespace constants for the CaaS API.
        
###Fields

####Server
The CaaS server XML namespace.
####Storage
The CaaS storage XML namespace.
####MultiGeo
The CaaS multiple-geographic-region XML namespace.
####WhiteLabel
The CaaS white-label XML namespace.
####VirtualIP
The CaaS virtual-IP XML namespace.
####Reset
The CaaS reset XML namespace.
####General
The CaaS general XML namespace.
####Support
The CaaS support XML namespace.
####Admin
The CaaS administration XML namespace.
####ManualImport
The CaaS manual-import XML namespace.
####Backup
The CaaS cloud backup XML namespace.
####Datacenter
The CaaS data centre XML namespace.
####Directory
The CaaS directory XML namespace.
####Network
The CaaS reset XML namespace.
####Organization
The CaaS organisation XML namespace.

##Servers
            

        
###Fields

####Items

###Properties

####

####

####

####

####

####

####

####

####

####


##Server
            

        
###Fields

####

####id

####location

####name

####description

####operatingSystem

####cpuCount

####memoryMb

####disk

####sourceImageId

####networkId

####machineName

####privateIp

####created

####isDeployed

####isStarted

####state

####machineStatus

###Properties

####

####

####

####

####

####

####

####

####

####


##DeployedServersWithDisksDeployedServerWithDisksMachineSpecification
            

        
###Fields

####cpuCount

####memoryMb

####osStorageGb

####additionalLocalStorageGb

####operatingSystem

####

####

####


##DeployedServersWithDisksDeployedServerWithDisksMachineSpecificationOperatingSystem
            

        
###Fields

####id

####type

####displayName


##DeployedServersWithDisksDeployedServerWithDisksMachineStatus
            

        
###Fields

####value

####name


##Disk
            

        
###Fields

####id

####scsiId

####sizeGb

####speed

####state


##ServersWithBackupServerOperatingSystem
            

        
###Properties

####id

####displayName

####type


##ServersWithBackupServerDisk
            

        
###Properties

####id

####scsiId

####sizeGb

####speed

####state


##ServersWithBackupServerMachineStatus
            

        
###Properties

####value

####name


##NewDataSet
            

        
###Properties

####Items
