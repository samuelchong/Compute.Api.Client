using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Api.Contracts.Server
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("cloneServer", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class CloneServerType
	{

		private string imageNameField;

		private string descriptionField;

		private string clusterIdField;

		private bool guestOsCustomizationField;

		private bool guestOsCustomizationFieldSpecified;

		private string idField;

		/// <remarks/>
		public string imageName
		{
			get
			{
				return this.imageNameField;
			}
			set
			{
				this.imageNameField = value;
			}
		}

		/// <remarks/>
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}

		/// <remarks/>
		public string clusterId
		{
			get
			{
				return this.clusterIdField;
			}
			set
			{
				this.clusterIdField = value;
			}
		}

		/// <remarks/>
		public bool guestOsCustomization
		{
			get
			{
				return this.guestOsCustomizationField;
			}
			set
			{
				this.guestOsCustomizationField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool guestOsCustomizationSpecified
		{
			get
			{
				return this.guestOsCustomizationFieldSpecified;
			}
			set
			{
				this.guestOsCustomizationFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
	}

}
