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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class AssociateUserWithOrganizationResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("billing_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BillingEnabled
        {
            get;
            set;
        }

        [JsonProperty("quota_definition_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? QuotaDefinitionGuid
        {
            get;
            set;
        }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status
        {
            get;
            set;
        }

        [JsonProperty("quota_definition_url", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaDefinitionUrl
        {
            get;
            set;
        }

        [JsonProperty("spaces_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpacesUrl
        {
            get;
            set;
        }

        [JsonProperty("domains_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainsUrl
        {
            get;
            set;
        }

        [JsonProperty("private_domains_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateDomainsUrl
        {
            get;
            set;
        }

        [JsonProperty("users_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UsersUrl
        {
            get;
            set;
        }

        [JsonProperty("managers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagersUrl
        {
            get;
            set;
        }

        [JsonProperty("billing_managers_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingManagersUrl
        {
            get;
            set;
        }

        [JsonProperty("auditors_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuditorsUrl
        {
            get;
            set;
        }

        [JsonProperty("app_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppEventsUrl
        {
            get;
            set;
        }

        [JsonProperty("space_quota_definitions_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceQuotaDefinitionsUrl
        {
            get;
            set;
        }
    }
}