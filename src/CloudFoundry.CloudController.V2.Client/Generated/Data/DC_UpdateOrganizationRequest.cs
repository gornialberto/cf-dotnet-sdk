//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.UpdateOrganization()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/organizations/update_an_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateOrganizationRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateOrganizationRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationsEndpoint.UpdateOrganization()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/organizations/update_an_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateOrganizationRequest
    {

        /// <summary> 
        /// <para>The name of the organization</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of quota to associate with this organization</para>
        /// </summary>
        [JsonProperty("quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? QuotaDefinitionGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>Status of the organization</para>
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Status
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If billing is enabled for this organization</para>
        /// </summary>
        [JsonProperty("billing_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BillingEnabled
        {
            get;
            set;
        }
    }
}