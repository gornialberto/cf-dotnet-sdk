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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class OrganizationQuotaDefinitionsEndpoint : BaseEndpoint
    {
        public OrganizationQuotaDefinitionsEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Delete a Particular Organization Quota Definition
        /// </summary>
        public async Task DeleteOrganizationQuotaDefinition(Guid? guid)
        {
            string route = string.Format("/v2/quota_definitions/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
        }

        /// <summary>
        /// List all Organization Quota Definitions
        /// </summary>
        public async Task<PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse>> ListAllOrganizationQuotaDefinitions()
        {
            return await ListAllOrganizationQuotaDefinitions(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllOrganizationQuotaDefinitionsResponse>> ListAllOrganizationQuotaDefinitions(RequestOptions options)
        {
            string route = "/v2/quota_definitions";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllOrganizationQuotaDefinitionsResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Updating a Organization Quota Definition
        /// </summary>
        public async Task<UpdateOrganizationQuotaDefinitionResponse> UpdateOrganizationQuotaDefinition(Guid? guid, UpdateOrganizationQuotaDefinitionRequest value)
        {
            string route = string.Format("/v2/quota_definitions/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<UpdateOrganizationQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Organization Quota Definition
        /// </summary>
        public async Task<RetrieveOrganizationQuotaDefinitionResponse> RetrieveOrganizationQuotaDefinition(Guid? guid)
        {
            string route = string.Format("/v2/quota_definitions/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<RetrieveOrganizationQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Organization Quota Definition
        /// </summary>
        public async Task<CreateOrganizationQuotaDefinitionResponse> CreateOrganizationQuotaDefinition(CreateOrganizationQuotaDefinitionRequest value)
        {
            string route = "/v2/quota_definitions";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<CreateOrganizationQuotaDefinitionResponse>(await response.ReadContentAsStringAsync());
        }
    }
}