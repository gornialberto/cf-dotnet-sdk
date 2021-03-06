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
    public class ServicesEndpoint
{
        [TestMethod]
        public void DeleteServiceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""44a4f5a7-d8d1-4774-8865-6f5cbb7ee805"",
    ""created_at"": ""2017-01-04T15:58:34Z"",
    ""url"": ""/v2/jobs/2c026b64-7950-4957-897b-402819ad3342""
  },
  ""entity"": {
    ""guid"": ""44a4f5a7-d8d1-4774-8865-6f5cbb7ee805"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)202;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Services.DeleteService(guid).Result;


                Assert.AreEqual("44a4f5a7-d8d1-4774-8865-6f5cbb7ee805", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/2c026b64-7950-4957-897b-402819ad3342", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("44a4f5a7-d8d1-4774-8865-6f5cbb7ee805", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

        [TestMethod]
        public void ListAllServicePlansForServiceTest()
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
        ""guid"": ""3e5cd8bb-1c11-424a-ace2-995751189b47"",
        ""url"": ""/v2/service_plans/c8b397f0-3afa-4868-8985-3f59dad92445"",
        ""created_at"": ""2017-01-04T15:58:34Z"",
        ""updated_at"": ""2017-01-04T15:58:34Z""
      },
      ""entity"": {
        ""name"": ""name-85"",
        ""free"": false,
        ""description"": ""desc-6"",
        ""service_guid"": ""3e5cd8bb-1c11-424a-ace2-995751189b47"",
        ""extra"": null,
        ""unique_id"": ""378e829c-e5d3-4587-a1da-ab3ebe3e5b44"",
        ""public"": true,
        ""bindable"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/7d180d79-c3d1-4a17-8b5a-0b70841fec4a"",
        ""service_instances_url"": ""/v2/service_plans/c8b397f0-3afa-4868-8985-3f59dad92445/service_instances""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Services.ListAllServicePlansForService(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("3e5cd8bb-1c11-424a-ace2-995751189b47", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/c8b397f0-3afa-4868-8985-3f59dad92445", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-85", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Free), true);
                Assert.AreEqual("desc-6", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("3e5cd8bb-1c11-424a-ace2-995751189b47", TestUtil.ToTestableString(obj[0].ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Extra), true);
                Assert.AreEqual("378e829c-e5d3-4587-a1da-ab3ebe3e5b44", TestUtil.ToTestableString(obj[0].UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Bindable), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Active), true);
                Assert.AreEqual("/v2/services/7d180d79-c3d1-4a17-8b5a-0b70841fec4a", TestUtil.ToTestableString(obj[0].ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/c8b397f0-3afa-4868-8985-3f59dad92445/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""33649ecf-a777-4902-8f1e-7c09d15e3b55"",
    ""url"": ""/v2/services/71cb9618-64e1-4a13-a693-ed36ca545efd"",
    ""created_at"": ""2017-01-04T15:58:34Z"",
    ""updated_at"": ""2017-01-04T15:58:34Z""
  },
  ""entity"": {
    ""label"": ""label-5"",
    ""provider"": null,
    ""url"": null,
    ""description"": ""desc-9"",
    ""long_description"": null,
    ""version"": null,
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""f33f571b-4667-4306-ad33-550dfcd012c3"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""33649ecf-a777-4902-8f1e-7c09d15e3b55"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/71cb9618-64e1-4a13-a693-ed36ca545efd/service_plans""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Services.RetrieveService(guid).Result;


                Assert.AreEqual("33649ecf-a777-4902-8f1e-7c09d15e3b55", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/services/71cb9618-64e1-4a13-a693-ed36ca545efd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-5", TestUtil.ToTestableString(obj.Label), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Provider), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Url), true);
                Assert.AreEqual("desc-9", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
                Assert.AreEqual("f33f571b-4667-4306-ad33-550dfcd012c3", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
                Assert.AreEqual("33649ecf-a777-4902-8f1e-7c09d15e3b55", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
                Assert.AreEqual("/v2/services/71cb9618-64e1-4a13-a693-ed36ca545efd/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServicesTest()
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
        ""guid"": ""910199e1-d9e5-45cf-b36b-bb0d58d605d1"",
        ""url"": ""/v2/services/ab09661a-0724-486e-9fc3-a6be7babda12"",
        ""created_at"": ""2017-01-04T15:58:34Z"",
        ""updated_at"": ""2017-01-04T15:58:34Z""
      },
      ""entity"": {
        ""label"": ""label-4"",
        ""provider"": null,
        ""url"": null,
        ""description"": ""desc-8"",
        ""long_description"": null,
        ""version"": null,
        ""info_url"": null,
        ""active"": true,
        ""bindable"": true,
        ""unique_id"": ""1039ec32-99ee-4e8f-b9ca-01d2d18e56a0"",
        ""extra"": null,
        ""tags"": [

        ],
        ""requires"": [

        ],
        ""documentation_url"": null,
        ""service_broker_guid"": ""910199e1-d9e5-45cf-b36b-bb0d58d605d1"",
        ""plan_updateable"": false,
        ""service_plans_url"": ""/v2/services/ab09661a-0724-486e-9fc3-a6be7babda12/service_plans""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Services.ListAllServices().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("910199e1-d9e5-45cf-b36b-bb0d58d605d1", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/services/ab09661a-0724-486e-9fc3-a6be7babda12", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:34Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-4", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Provider), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Url), true);
                Assert.AreEqual("desc-8", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].LongDescription), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].InfoUrl), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Active), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Bindable), true);
                Assert.AreEqual("1039ec32-99ee-4e8f-b9ca-01d2d18e56a0", TestUtil.ToTestableString(obj[0].UniqueId), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Extra), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DocumentationUrl), true);
                Assert.AreEqual("910199e1-d9e5-45cf-b36b-bb0d58d605d1", TestUtil.ToTestableString(obj[0].ServiceBrokerGuid), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].PlanUpdateable), true);
                Assert.AreEqual("/v2/services/ab09661a-0724-486e-9fc3-a6be7babda12/service_plans", TestUtil.ToTestableString(obj[0].ServicePlansUrl), true);

            }
        }

    }
}