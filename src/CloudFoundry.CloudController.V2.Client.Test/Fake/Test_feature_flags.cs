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

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class FeatureFlagsEndpoint
{
        [TestMethod]
        public void GetSpaceScopedPrivateBrokerCreationFeatureFlagExperimentalTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""space_scoped_private_broker_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/space_scoped_private_broker_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetSpaceScopedPrivateBrokerCreationFeatureFlagExperimental().Result;


                Assert.AreEqual("space_scoped_private_broker_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/space_scoped_private_broker_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetUserOrgCreationFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""user_org_creation"",
  ""enabled"": false,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/user_org_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetUserOrgCreationFeatureFlag().Result;


                Assert.AreEqual("user_org_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/user_org_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetUnsetUserRolesFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""unset_roles_by_username"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/unset_roles_by_username""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetUnsetUserRolesFeatureFlag().Result;


                Assert.AreEqual("unset_roles_by_username", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/unset_roles_by_username", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod, Ignore]
        public void SetFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""user_org_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/user_org_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                dynamic name = null;

                SetFeatureFlagRequest value = new SetFeatureFlagRequest();


                var obj = cfClient.FeatureFlags.SetFeatureFlag(name, value).Result;


                Assert.AreEqual("user_org_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/user_org_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetSetUserRolesFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""set_roles_by_username"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/set_roles_by_username""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetSetUserRolesFeatureFlag().Result;


                Assert.AreEqual("set_roles_by_username", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/set_roles_by_username", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetRouteCreationFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""route_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/route_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetRouteCreationFeatureFlag().Result;


                Assert.AreEqual("route_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/route_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetAppBitsUploadFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""app_bits_upload"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/app_bits_upload""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetAppBitsUploadFeatureFlag().Result;


                Assert.AreEqual("app_bits_upload", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/app_bits_upload", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetDiegoDockerFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""diego_docker"",
  ""enabled"": false,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/diego_docker""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetDiegoDockerFeatureFlag().Result;


                Assert.AreEqual("diego_docker", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/diego_docker", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetSpaceDeveloperEnvironmentVariableVisibilityFeatureFlagExperimentalTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""space_developer_env_var_visibility"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/space_developer_env_var_visibility""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetSpaceDeveloperEnvironmentVariableVisibilityFeatureFlagExperimental().Result;


                Assert.AreEqual("space_developer_env_var_visibility", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/space_developer_env_var_visibility", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetPrivateDomainCreationFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""private_domain_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/private_domain_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetPrivateDomainCreationFeatureFlag().Result;


                Assert.AreEqual("private_domain_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/private_domain_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetAppScalingFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""app_scaling"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/app_scaling""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetAppScalingFeatureFlag().Result;


                Assert.AreEqual("app_scaling", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/app_scaling", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetAllFeatureFlagsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"[
  {
    ""name"": ""user_org_creation"",
    ""enabled"": false,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/user_org_creation""
  },
  {
    ""name"": ""private_domain_creation"",
    ""enabled"": false,
    ""error_message"": ""foobar"",
    ""url"": ""/v2/config/feature_flags/private_domain_creation""
  },
  {
    ""name"": ""app_bits_upload"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/app_bits_upload""
  },
  {
    ""name"": ""app_scaling"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/app_scaling""
  },
  {
    ""name"": ""route_creation"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/route_creation""
  },
  {
    ""name"": ""service_instance_creation"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/service_instance_creation""
  },
  {
    ""name"": ""diego_docker"",
    ""enabled"": false,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/diego_docker""
  },
  {
    ""name"": ""set_roles_by_username"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/set_roles_by_username""
  },
  {
    ""name"": ""unset_roles_by_username"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/unset_roles_by_username""
  },
  {
    ""name"": ""task_creation"",
    ""enabled"": false,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/task_creation""
  },
  {
    ""name"": ""env_var_visibility"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/env_var_visibility""
  },
  {
    ""name"": ""space_scoped_private_broker_creation"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/space_scoped_private_broker_creation""
  },
  {
    ""name"": ""space_developer_env_var_visibility"",
    ""enabled"": true,
    ""error_message"": null,
    ""url"": ""/v2/config/feature_flags/space_developer_env_var_visibility""
  }
]";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetAllFeatureFlags().Result;


                Assert.AreEqual("user_org_creation", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/user_org_creation", TestUtil.ToTestableString(obj[0].Url), true);
                Assert.AreEqual("private_domain_creation", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].Enabled), true);
                Assert.AreEqual("foobar", TestUtil.ToTestableString(obj[1].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/private_domain_creation", TestUtil.ToTestableString(obj[1].Url), true);
                Assert.AreEqual("app_bits_upload", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[2].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/app_bits_upload", TestUtil.ToTestableString(obj[2].Url), true);
                Assert.AreEqual("app_scaling", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[3].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/app_scaling", TestUtil.ToTestableString(obj[3].Url), true);
                Assert.AreEqual("route_creation", TestUtil.ToTestableString(obj[4].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[4].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/route_creation", TestUtil.ToTestableString(obj[4].Url), true);
                Assert.AreEqual("service_instance_creation", TestUtil.ToTestableString(obj[5].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[5].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[5].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/service_instance_creation", TestUtil.ToTestableString(obj[5].Url), true);
                Assert.AreEqual("diego_docker", TestUtil.ToTestableString(obj[6].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[6].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[6].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/diego_docker", TestUtil.ToTestableString(obj[6].Url), true);
                Assert.AreEqual("set_roles_by_username", TestUtil.ToTestableString(obj[7].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[7].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[7].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/set_roles_by_username", TestUtil.ToTestableString(obj[7].Url), true);
                Assert.AreEqual("unset_roles_by_username", TestUtil.ToTestableString(obj[8].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[8].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[8].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/unset_roles_by_username", TestUtil.ToTestableString(obj[8].Url), true);
                Assert.AreEqual("task_creation", TestUtil.ToTestableString(obj[9].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[9].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[9].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/task_creation", TestUtil.ToTestableString(obj[9].Url), true);
                Assert.AreEqual("env_var_visibility", TestUtil.ToTestableString(obj[10].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[10].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[10].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/env_var_visibility", TestUtil.ToTestableString(obj[10].Url), true);
                Assert.AreEqual("space_scoped_private_broker_creation", TestUtil.ToTestableString(obj[11].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[11].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[11].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/space_scoped_private_broker_creation", TestUtil.ToTestableString(obj[11].Url), true);
                Assert.AreEqual("space_developer_env_var_visibility", TestUtil.ToTestableString(obj[12].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[12].Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[12].ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/space_developer_env_var_visibility", TestUtil.ToTestableString(obj[12].Url), true);

            }
        }

        [TestMethod]
        public void GetServiceInstanceCreationFeatureFlagTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""service_instance_creation"",
  ""enabled"": true,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/service_instance_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetServiceInstanceCreationFeatureFlag().Result;


                Assert.AreEqual("service_instance_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/service_instance_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

        [TestMethod]
        public void GetTaskCreationFeatureFlagExperimentalTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""task_creation"",
  ""enabled"": false,
  ""error_message"": null,
  ""url"": ""/v2/config/feature_flags/task_creation""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.FeatureFlags.GetTaskCreationFeatureFlagExperimental().Result;


                Assert.AreEqual("task_creation", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ErrorMessage), true);
                Assert.AreEqual("/v2/config/feature_flags/task_creation", TestUtil.ToTestableString(obj.Url), true);

            }
        }

    }
}