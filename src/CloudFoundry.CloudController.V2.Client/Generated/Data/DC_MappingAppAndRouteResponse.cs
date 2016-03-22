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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.RoutesMappingEndpoint.MappingAppAndRoute()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/routes_mapping/mapping_an_app_and_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class MappingAppAndRouteResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractMappingAppAndRouteResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.RoutesMappingEndpoint.MappingAppAndRoute()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/routes_mapping/mapping_an_app_and_a_route.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractMappingAppAndRouteResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Port</para>
        /// </summary>
        [JsonProperty("app_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppPort
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Guid</para>
        /// </summary>
        [JsonProperty("app_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AppGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Route Guid</para>
        /// </summary>
        [JsonProperty("route_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RouteGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The App Url</para>
        /// </summary>
        [JsonProperty("app_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Route Url</para>
        /// </summary>
        [JsonProperty("route_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RouteUrl
        {
            get;
            set;
        }
    }
}