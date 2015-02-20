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
    public class SpacesEndpoint : BaseEndpoint
    {
        public SpacesEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }

        /// <summary>
        /// Delete a Particular Space
        /// </summary>
        public async Task DeleteSpace(Guid? guid)
        {
            string route = string.Format("/v2/spaces/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
        }

        /// <summary>
        /// Remove Security Group from the Space
        /// </summary>
        public async Task<RemoveSecurityGroupFromSpaceResponse> RemoveSecurityGroupFromSpace(Guid? guid, Guid? security_group_guid)
        {
            string route = string.Format("/v2/spaces/{0}/security_groups/{1}", guid, security_group_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<RemoveSecurityGroupFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Security Groups for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSecurityGroupsForSpaceResponse>> ListAllSecurityGroupsForSpace(Guid? guid)
        {
            return await ListAllSecurityGroupsForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllSecurityGroupsForSpaceResponse>> ListAllSecurityGroupsForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/security_groups", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllSecurityGroupsForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Service Instances for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServiceInstancesForSpaceResponse>> ListAllServiceInstancesForSpace(Guid? guid)
        {
            return await ListAllServiceInstancesForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServiceInstancesForSpaceResponse>> ListAllServiceInstancesForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/service_instances", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllServiceInstancesForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Auditors for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAuditorsForSpaceResponse>> ListAllAuditorsForSpace(Guid? guid)
        {
            return await ListAllAuditorsForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllAuditorsForSpaceResponse>> ListAllAuditorsForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/auditors", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllAuditorsForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Security Group with the Space
        /// </summary>
        public async Task<AssociateSecurityGroupWithSpaceResponse> AssociateSecurityGroupWithSpace(Guid? guid, Guid? security_group_guid)
        {
            string route = string.Format("/v2/spaces/{0}/security_groups/{1}", guid, security_group_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<AssociateSecurityGroupWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Developers for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDevelopersForSpaceResponse>> ListAllDevelopersForSpace(Guid? guid)
        {
            return await ListAllDevelopersForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllDevelopersForSpaceResponse>> ListAllDevelopersForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/developers", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllDevelopersForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Services for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllServicesForSpaceResponse>> ListAllServicesForSpace(Guid? guid)
        {
            return await ListAllServicesForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllServicesForSpaceResponse>> ListAllServicesForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/services", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllServicesForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Auditor with the Space
        /// </summary>
        public async Task<AssociateAuditorWithSpaceResponse> AssociateAuditorWithSpace(Guid? guid, Guid? auditor_guid)
        {
            string route = string.Format("/v2/spaces/{0}/auditors/{1}", guid, auditor_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<AssociateAuditorWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Update a Space
        /// </summary>
        public async Task<UpdateSpaceResponse> UpdateSpace(Guid? guid, UpdateSpaceRequest value)
        {
            string route = string.Format("/v2/spaces/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<UpdateSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Developer with the Space
        /// </summary>
        public async Task<AssociateDeveloperWithSpaceResponse> AssociateDeveloperWithSpace(Guid? guid, Guid? developer_guid)
        {
            string route = string.Format("/v2/spaces/{0}/developers/{1}", guid, developer_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<AssociateDeveloperWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Auditor from the Space
        /// </summary>
        public async Task<RemoveAuditorFromSpaceResponse> RemoveAuditorFromSpace(Guid? guid, Guid? auditor_guid)
        {
            string route = string.Format("/v2/spaces/{0}/auditors/{1}", guid, auditor_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<RemoveAuditorFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Manager from the Space
        /// </summary>
        public async Task<RemoveManagerFromSpaceResponse> RemoveManagerFromSpace(Guid? guid, Guid? manager_guid)
        {
            string route = string.Format("/v2/spaces/{0}/managers/{1}", guid, manager_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<RemoveManagerFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Space
        /// </summary>
        public async Task<RetrieveSpaceResponse> RetrieveSpace(Guid? guid)
        {
            string route = string.Format("/v2/spaces/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<RetrieveSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Managers for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllManagersForSpaceResponse>> ListAllManagersForSpace(Guid? guid)
        {
            return await ListAllManagersForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllManagersForSpaceResponse>> ListAllManagersForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/managers", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllManagersForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Domains for the Space (deprecated)
        /// </summary>
        public async Task<PagedResponseCollection<ListAllDomainsForSpaceDeprecatedResponse>> ListAllDomainsForSpaceDeprecated(Guid? guid)
        {
            return await ListAllDomainsForSpaceDeprecated(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllDomainsForSpaceDeprecatedResponse>> ListAllDomainsForSpaceDeprecated(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/domains", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllDomainsForSpaceDeprecatedResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Manager with the Space
        /// </summary>
        public async Task<AssociateManagerWithSpaceResponse> AssociateManagerWithSpace(Guid? guid, Guid? manager_guid)
        {
            string route = string.Format("/v2/spaces/{0}/managers/{1}", guid, manager_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<AssociateManagerWithSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Events for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllEventsForSpaceResponse>> ListAllEventsForSpace(Guid? guid)
        {
            return await ListAllEventsForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllEventsForSpaceResponse>> ListAllEventsForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/events", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllEventsForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Spaces
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesResponse>> ListAllSpaces()
        {
            return await ListAllSpaces(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllSpacesResponse>> ListAllSpaces(RequestOptions options)
        {
            string route = "/v2/spaces";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllSpacesResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Remove Developer from the Space
        /// </summary>
        public async Task<RemoveDeveloperFromSpaceResponse> RemoveDeveloperFromSpace(Guid? guid, Guid? developer_guid)
        {
            string route = string.Format("/v2/spaces/{0}/developers/{1}", guid, developer_guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<RemoveDeveloperFromSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Space
        /// </summary>
        public async Task<CreateSpaceResponse> CreateSpace(CreateSpaceRequest value)
        {
            string route = "/v2/spaces";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<CreateSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Apps for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsForSpaceResponse>> ListAllAppsForSpace(Guid? guid)
        {
            return await ListAllAppsForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllAppsForSpaceResponse>> ListAllAppsForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/apps", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllAppsForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Routes for the Space
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesForSpaceResponse>> ListAllRoutesForSpace(Guid? guid)
        {
            return await ListAllRoutesForSpace(guid, new RequestOptions());
        }

        public async Task<PagedResponseCollection<ListAllRoutesForSpaceResponse>> ListAllRoutesForSpace(Guid? guid, RequestOptions options)
        {
            string route = string.Format("/v2/spaces/{0}/routes", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializePage<ListAllRoutesForSpaceResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Get Space summary
        /// </summary>
        public async Task<GetSpaceSummaryResponse> GetSpaceSummary(Guid? guid)
        {
            string route = string.Format("/v2/spaces/{0}/summary", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
            var response = await this.SendAsync(client);
            return Utilities.DeserializeJson<GetSpaceSummaryResponse>(await response.ReadContentAsStringAsync());
        }
    }
}