﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace DD.CBU.Compute.Api.Contracts.Network20
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("pool", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)
    ]
    public partial class PoolType
    {

        private string networkDomainIdField;

        private string nameField;

        private string descriptionField;

        private string loadBalanceMethodField;

        private IdAndNameType[] healthMonitorField;

        private string serviceDownActionField;

        private string slowRampTimeField;

        private string stateField;

        private System.DateTime createTimeField;

        private string idField;

        private string datacenterIdField;

        /// <remarks/>
        public string networkDomainId
        {
            get { return this.networkDomainIdField; }
            set { this.networkDomainIdField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string loadBalanceMethod
        {
            get { return this.loadBalanceMethodField; }
            set { this.loadBalanceMethodField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("healthMonitor")]
        public IdAndNameType[] healthMonitor
        {
            get { return this.healthMonitorField; }
            set { this.healthMonitorField = value; }
        }

        /// <remarks/>
        public string serviceDownAction
        {
            get { return this.serviceDownActionField; }
            set { this.serviceDownActionField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string slowRampTime
        {
            get { return this.slowRampTimeField; }
            set { this.slowRampTimeField = value; }
        }

        /// <remarks/>
        public string state
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <remarks/>
        public System.DateTime createTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datacenterId
        {
            get { return this.datacenterIdField; }
            set { this.datacenterIdField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class pools
    {

        private PoolType[] poolField;

        private int pageNumberField;

        private bool pageNumberFieldSpecified;

        private int pageCountField;

        private bool pageCountFieldSpecified;

        private int totalCountField;

        private bool totalCountFieldSpecified;

        private int pageSizeField;

        private bool pageSizeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("pool")]
        public PoolType[] pool
        {
            get { return this.poolField; }
            set { this.poolField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageNumber
        {
            get { return this.pageNumberField; }
            set { this.pageNumberField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageNumberSpecified
        {
            get { return this.pageNumberFieldSpecified; }
            set { this.pageNumberFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageCount
        {
            get { return this.pageCountField; }
            set { this.pageCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageCountSpecified
        {
            get { return this.pageCountFieldSpecified; }
            set { this.pageCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int totalCount
        {
            get { return this.totalCountField; }
            set { this.totalCountField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool totalCountSpecified
        {
            get { return this.totalCountFieldSpecified; }
            set { this.totalCountFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int pageSize
        {
            get { return this.pageSizeField; }
            set { this.pageSizeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSizeSpecified
        {
            get { return this.pageSizeFieldSpecified; }
            set { this.pageSizeFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class createPool
    {

        private string networkDomainIdField;

        private string nameField;

        private string descriptionField;

        private string loadBalanceMethodField;

        private string[] healthMonitorIdField;

        private string serviceDownActionField;

        private string slowRampTimeField;

        /// <remarks/>
        public string networkDomainId
        {
            get { return this.networkDomainIdField; }
            set { this.networkDomainIdField = value; }
        }

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string loadBalanceMethod
        {
            get { return this.loadBalanceMethodField; }
            set { this.loadBalanceMethodField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("healthMonitorId")]
        public string[] healthMonitorId
        {
            get { return this.healthMonitorIdField; }
            set { this.healthMonitorIdField = value; }
        }

        /// <remarks/>
        public string serviceDownAction
        {
            get { return this.serviceDownActionField; }
            set { this.serviceDownActionField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string slowRampTime
        {
            get { return this.slowRampTimeField; }
            set { this.slowRampTimeField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("deletePool", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class DeletePoolType
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("editPool", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class EditPoolType
    {

        private string descriptionField;

        private string loadBalanceMethodField;

        private string[] healthMonitorIdField;

        private string serviceDownActionField;

        private int slowRampTimeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <remarks/>
        public string loadBalanceMethod
        {
            get { return this.loadBalanceMethodField; }
            set { this.loadBalanceMethodField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("healthMonitorId", IsNullable = true)]
        public string[] healthMonitorId
        {
            get { return this.healthMonitorIdField; }
            set { this.healthMonitorIdField = value; }
        }

        /// <remarks/>
        public string serviceDownAction
        {
            get { return this.serviceDownActionField; }
            set { this.serviceDownActionField = value; }
        }

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public int slowRampTime
        {
            get { return this.slowRampTimeField; }
            set { this.slowRampTimeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }
}
