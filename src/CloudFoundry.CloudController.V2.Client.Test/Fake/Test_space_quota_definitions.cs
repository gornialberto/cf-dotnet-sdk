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
    public class SpaceQuotaDefinitionsEndpoint
{
        [TestMethod]
        public void RemoveSpaceFromSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                cfClient.SpaceQuotaDefinitions.RemoveSpaceFromSpaceQuotaDefinition(guid, space_guid).Wait();

            }
        }

        [TestMethod]
        public void DeleteSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SpaceQuotaDefinitions.DeleteSpaceQuotaDefinition(guid).Wait();

            }
        }

        [TestMethod]
        public void RetrieveSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""acdda9fb-0880-456b-8774-5d46560705aa"",
    ""url"": ""/v2/space_quota_definitions/9de85250-568e-4d34-a155-e86f4286f495"",
    ""created_at"": ""2016-03-21T10:59:27Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-418"",
    ""organization_guid"": ""acdda9fb-0880-456b-8774-5d46560705aa"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""organization_url"": ""/v2/organizations/e582ce02-3733-4837-91a2-96ec24b1301e"",
    ""spaces_url"": ""/v2/space_quota_definitions/9de85250-568e-4d34-a155-e86f4286f495/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SpaceQuotaDefinitions.RetrieveSpaceQuotaDefinition(guid).Result;


                Assert.AreEqual("acdda9fb-0880-456b-8774-5d46560705aa", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/9de85250-568e-4d34-a155-e86f4286f495", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-418", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("acdda9fb-0880-456b-8774-5d46560705aa", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("/v2/organizations/e582ce02-3733-4837-91a2-96ec24b1301e", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/9de85250-568e-4d34-a155-e86f4286f495/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void UpdateSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""976ed110-294b-4751-970d-8a5b714e6537"",
    ""url"": ""/v2/space_quota_definitions/dfe567e2-2606-4a38-9c8c-315a2ad7afde"",
    ""created_at"": ""2016-03-21T10:59:27Z"",
    ""updated_at"": ""2016-03-21T10:59:27Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""organization_guid"": ""976ed110-294b-4751-970d-8a5b714e6537"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""organization_url"": ""/v2/organizations/f73608a9-ceff-46e4-bfd6-bf1b466a4aa6"",
    ""spaces_url"": ""/v2/space_quota_definitions/dfe567e2-2606-4a38-9c8c-315a2ad7afde/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateSpaceQuotaDefinitionRequest value = new UpdateSpaceQuotaDefinitionRequest();


                var obj = cfClient.SpaceQuotaDefinitions.UpdateSpaceQuotaDefinition(guid, value).Result;


                Assert.AreEqual("976ed110-294b-4751-970d-8a5b714e6537", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/dfe567e2-2606-4a38-9c8c-315a2ad7afde", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("976ed110-294b-4751-970d-8a5b714e6537", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("/v2/organizations/f73608a9-ceff-46e4-bfd6-bf1b466a4aa6", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/dfe567e2-2606-4a38-9c8c-315a2ad7afde/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSpacesForSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0db0f710-5ccb-4ab7-8bd2-45d5c2f06d99"",
        ""url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e"",
        ""created_at"": ""2016-03-21T10:59:27Z"",
        ""updated_at"": ""2016-03-21T10:59:27Z""
      },
      ""entity"": {
        ""name"": ""name-406"",
        ""organization_guid"": ""0db0f710-5ccb-4ab7-8bd2-45d5c2f06d99"",
        ""space_quota_definition_guid"": ""0db0f710-5ccb-4ab7-8bd2-45d5c2f06d99"",
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/eaec4d9f-c36f-46ae-9871-a5754a7e1364"",
        ""space_quota_definition_url"": ""/v2/space_quota_definitions/7e9e2e0c-bff5-4fdf-99a0-9cc21a240c7b"",
        ""developers_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/developers"",
        ""managers_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/managers"",
        ""auditors_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/auditors"",
        ""apps_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/apps"",
        ""routes_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/routes"",
        ""domains_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/domains"",
        ""service_instances_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/service_instances"",
        ""app_events_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/app_events"",
        ""events_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/events"",
        ""security_groups_url"": ""/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/security_groups""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SpaceQuotaDefinitions.ListAllSpacesForSpaceQuotaDefinition(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("0db0f710-5ccb-4ab7-8bd2-45d5c2f06d99", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-406", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("0db0f710-5ccb-4ab7-8bd2-45d5c2f06d99", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("0db0f710-5ccb-4ab7-8bd2-45d5c2f06d99", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].AllowSsh), true);
                Assert.AreEqual("/v2/organizations/eaec4d9f-c36f-46ae-9871-a5754a7e1364", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/7e9e2e0c-bff5-4fdf-99a0-9cc21a240c7b", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/developers", TestUtil.ToTestableString(obj[0].DevelopersUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/spaces/620e2977-7b5f-4846-969a-cd6536f4b20e/security_groups", TestUtil.ToTestableString(obj[0].SecurityGroupsUrl), true);

            }
        }

        [TestMethod]
        public void AssociateSpaceWithSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c138982b-ea2f-4025-b1ae-4212c086e06c"",
    ""url"": ""/v2/space_quota_definitions/43ba6240-a477-4e7f-bc83-ece17ee2e718"",
    ""created_at"": ""2016-03-21T10:59:27Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-413"",
    ""organization_guid"": ""c138982b-ea2f-4025-b1ae-4212c086e06c"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""organization_url"": ""/v2/organizations/c65a89f9-ac34-400b-bc59-c7aade301041"",
    ""spaces_url"": ""/v2/space_quota_definitions/43ba6240-a477-4e7f-bc83-ece17ee2e718/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                var obj = cfClient.SpaceQuotaDefinitions.AssociateSpaceWithSpaceQuotaDefinition(guid, space_guid).Result;


                Assert.AreEqual("c138982b-ea2f-4025-b1ae-4212c086e06c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/43ba6240-a477-4e7f-bc83-ece17ee2e718", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-413", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("c138982b-ea2f-4025-b1ae-4212c086e06c", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("/v2/organizations/c65a89f9-ac34-400b-bc59-c7aade301041", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/43ba6240-a477-4e7f-bc83-ece17ee2e718/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void CreateSpaceQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""aa4b7810-7f7a-4f26-a941-cb9a62b9ec71"",
    ""url"": ""/v2/space_quota_definitions/73be09dd-2f3e-4682-bf45-4900f29dd252"",
    ""created_at"": ""2016-03-21T10:59:27Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""organization_guid"": ""aa4b7810-7f7a-4f26-a941-cb9a62b9ec71"",
    ""non_basic_services_allowed"": true,
    ""total_services"": -1,
    ""total_routes"": -1,
    ""memory_limit"": 5120,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""organization_url"": ""/v2/organizations/a3a2b004-c0b3-48de-940b-722db0b53a06"",
    ""spaces_url"": ""/v2/space_quota_definitions/73be09dd-2f3e-4682-bf45-4900f29dd252/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSpaceQuotaDefinitionRequest value = new CreateSpaceQuotaDefinitionRequest();


                var obj = cfClient.SpaceQuotaDefinitions.CreateSpaceQuotaDefinition(value).Result;


                Assert.AreEqual("aa4b7810-7f7a-4f26-a941-cb9a62b9ec71", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/73be09dd-2f3e-4682-bf45-4900f29dd252", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("aa4b7810-7f7a-4f26-a941-cb9a62b9ec71", TestUtil.ToTestableString(obj.OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
                Assert.AreEqual("/v2/organizations/a3a2b004-c0b3-48de-940b-722db0b53a06", TestUtil.ToTestableString(obj.OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/73be09dd-2f3e-4682-bf45-4900f29dd252/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSpaceQuotaDefinitionsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""15c47fee-abc2-4c50-9549-b6947180bd3e"",
        ""url"": ""/v2/space_quota_definitions/bec89d1d-1f65-49f9-b14f-12a10df640cc"",
        ""created_at"": ""2016-03-21T10:59:27Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-389"",
        ""organization_guid"": ""15c47fee-abc2-4c50-9549-b6947180bd3e"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 60,
        ""total_routes"": 1000,
        ""memory_limit"": 20480,
        ""instance_memory_limit"": -1,
        ""app_instance_limit"": -1,
        ""app_task_limit"": 5,
        ""organization_url"": ""/v2/organizations/cb915a4d-fd76-4d7e-a8e3-27e2ccd846a5"",
        ""spaces_url"": ""/v2/space_quota_definitions/bec89d1d-1f65-49f9-b14f-12a10df640cc/spaces""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SpaceQuotaDefinitions.ListAllSpaceQuotaDefinitions().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("15c47fee-abc2-4c50-9549-b6947180bd3e", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/space_quota_definitions/bec89d1d-1f65-49f9-b14f-12a10df640cc", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-03-21T10:59:27Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-389", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("15c47fee-abc2-4c50-9549-b6947180bd3e", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj[0].TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj[0].TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj[0].MemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj[0].InstanceMemoryLimit), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj[0].AppInstanceLimit), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj[0].AppTaskLimit), true);
                Assert.AreEqual("/v2/organizations/cb915a4d-fd76-4d7e-a8e3-27e2ccd846a5", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/space_quota_definitions/bec89d1d-1f65-49f9-b14f-12a10df640cc/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);

            }
        }

    }
}