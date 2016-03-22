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


using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetEnvForApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/apps__experimental_/get_the_env_for_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetEnvForAppResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractGetEnvForAppResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.AppsExperimentalEndpoint.GetEnvForApp()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/231/apps__experimental_/get_the_env_for_an_app.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetEnvForAppResponse
    {

        /// <summary> 
        /// <para>The Environment Variables</para>
        /// </summary>
        [JsonProperty("environment_variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Staging Env Json</para>
        /// </summary>
        [JsonProperty("staging_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> StagingEnvJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Running Env Json</para>
        /// </summary>
        [JsonProperty("running_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> RunningEnvJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The System Env Json</para>
        /// </summary>
        [JsonProperty("system_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> SystemEnvJson
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Application Env Json</para>
        /// </summary>
        [JsonProperty("application_env_json", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> ApplicationEnvJson
        {
            get;
            set;
        }
    }
}