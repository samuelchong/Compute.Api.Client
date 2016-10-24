namespace DD.CBU.Compute.Api.Contracts.Image
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("importImage", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
    public partial class ImportImageType
    {
        private string ovfPackageField;

        private string nameField;

        private string descriptionField;

        private bool guestOsCustomizationField;

        private bool guestOsCustomizationSpecifiedField;

        private string ItemField;

        private ItemChoiceType ItemElementNameField;

        /// <remarks/>
        public string ovfPackage
        {
            get { return this.ovfPackageField; }
            set { this.ovfPackageField = value; }
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
        public bool guestOsCustomization
        {
            get { return this.guestOsCustomizationField; }
            set { this.guestOsCustomizationField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool guestOsCustomizationSpecified
        {
            get { return this.guestOsCustomizationSpecifiedField; }
            set { this.guestOsCustomizationSpecifiedField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("clusterId", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("datacenterId", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get { return this.ItemField; }
            set { this.ItemField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get { return this.ItemElementNameField; }
            set { this.ItemElementNameField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types", IncludeInSchema = false)]
    public enum ItemChoiceType
    {
        /// <remarks/>
        clusterId,

        /// <remarks/>
        datacenterId,
    }
}
