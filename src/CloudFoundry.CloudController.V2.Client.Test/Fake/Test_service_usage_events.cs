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
    public class ServiceUsageEventsEndpoint
{
        [TestMethod]
        public void ListServiceUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/service_usage_events?after_guid=8dd706cc-5288-4b18-9d6e-042a5dd415f4=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""086e51d2-f6e5-40df-b9ef-24b312be3e81"",
        ""url"": ""/v2/service_usage_events/a03b077b-75b2-4c15-b3af-efa3ce663984"",
        ""created_at"": ""2016-07-27T14:02:34Z""
      },
      ""entity"": {
        ""state"": ""CREATED"",
        ""org_guid"": ""086e51d2-f6e5-40df-b9ef-24b312be3e81"",
        ""space_guid"": ""086e51d2-f6e5-40df-b9ef-24b312be3e81"",
        ""space_name"": ""name-233"",
        ""service_instance_guid"": ""086e51d2-f6e5-40df-b9ef-24b312be3e81"",
        ""service_instance_name"": ""name-234"",
        ""service_instance_type"": ""type-8"",
        ""service_plan_guid"": ""086e51d2-f6e5-40df-b9ef-24b312be3e81"",
        ""service_plan_name"": ""name-235"",
        ""service_guid"": ""086e51d2-f6e5-40df-b9ef-24b312be3e81"",
        ""service_label"": ""label-24""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceUsageEvents.ListServiceUsageEvents().Result;

                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("/v2/service_usage_events?after_guid=8dd706cc-5288-4b18-9d6e-042a5dd415f4=asc=2=1", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("086e51d2-f6e5-40df-b9ef-24b312be3e81", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_usage_events/a03b077b-75b2-4c15-b3af-efa3ce663984", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:34Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("CREATED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("086e51d2-f6e5-40df-b9ef-24b312be3e81", TestUtil.ToTestableString(obj[0].OrgGuid), true);
                Assert.AreEqual("086e51d2-f6e5-40df-b9ef-24b312be3e81", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("name-233", TestUtil.ToTestableString(obj[0].SpaceName), true);
                Assert.AreEqual("086e51d2-f6e5-40df-b9ef-24b312be3e81", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("name-234", TestUtil.ToTestableString(obj[0].ServiceInstanceName), true);
                Assert.AreEqual("type-8", TestUtil.ToTestableString(obj[0].ServiceInstanceType), true);
                Assert.AreEqual("086e51d2-f6e5-40df-b9ef-24b312be3e81", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("name-235", TestUtil.ToTestableString(obj[0].ServicePlanName), true);
                Assert.AreEqual("086e51d2-f6e5-40df-b9ef-24b312be3e81", TestUtil.ToTestableString(obj[0].ServiceGuid), true);
                Assert.AreEqual("label-24", TestUtil.ToTestableString(obj[0].ServiceLabel), true);

            }
        }

        [TestMethod]
        public void PurgeAndReseedServiceUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();


                cfClient.ServiceUsageEvents.PurgeAndReseedServiceUsageEvents().Wait();

            }
        }

        [TestMethod]
        public void RetrieveServiceUsageEventTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""ddf8b450-cd26-44fb-a49d-6ec0f81b350e"",
    ""url"": ""/v2/service_usage_events/3c2934cd-68fa-4e1b-8b70-36cfd2d13ffc"",
    ""created_at"": ""2016-07-27T14:02:32Z""
  },
  ""entity"": {
    ""state"": ""CREATED"",
    ""org_guid"": ""ddf8b450-cd26-44fb-a49d-6ec0f81b350e"",
    ""space_guid"": ""ddf8b450-cd26-44fb-a49d-6ec0f81b350e"",
    ""space_name"": ""name-212"",
    ""service_instance_guid"": ""ddf8b450-cd26-44fb-a49d-6ec0f81b350e"",
    ""service_instance_name"": ""name-213"",
    ""service_instance_type"": ""type-1"",
    ""service_plan_guid"": ""ddf8b450-cd26-44fb-a49d-6ec0f81b350e"",
    ""service_plan_name"": ""name-214"",
    ""service_guid"": ""ddf8b450-cd26-44fb-a49d-6ec0f81b350e"",
    ""service_label"": ""label-17""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceUsageEvents.RetrieveServiceUsageEvent(guid).Result;


                Assert.AreEqual("ddf8b450-cd26-44fb-a49d-6ec0f81b350e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_usage_events/3c2934cd-68fa-4e1b-8b70-36cfd2d13ffc", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-07-27T14:02:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("CREATED", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("ddf8b450-cd26-44fb-a49d-6ec0f81b350e", TestUtil.ToTestableString(obj.OrgGuid), true);
                Assert.AreEqual("ddf8b450-cd26-44fb-a49d-6ec0f81b350e", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("name-212", TestUtil.ToTestableString(obj.SpaceName), true);
                Assert.AreEqual("ddf8b450-cd26-44fb-a49d-6ec0f81b350e", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("name-213", TestUtil.ToTestableString(obj.ServiceInstanceName), true);
                Assert.AreEqual("type-1", TestUtil.ToTestableString(obj.ServiceInstanceType), true);
                Assert.AreEqual("ddf8b450-cd26-44fb-a49d-6ec0f81b350e", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("name-214", TestUtil.ToTestableString(obj.ServicePlanName), true);
                Assert.AreEqual("ddf8b450-cd26-44fb-a49d-6ec0f81b350e", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("label-17", TestUtil.ToTestableString(obj.ServiceLabel), true);

            }
        }

    }
}