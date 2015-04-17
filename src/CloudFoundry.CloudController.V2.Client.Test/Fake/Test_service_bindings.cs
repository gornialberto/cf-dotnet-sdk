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
    public class ServiceBindingsEndpoint
{
        [TestMethod]
        public void RetrieveServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e7f54dee-4b7f-4dd8-8b0b-480539154a88"",
    ""url"": ""/v2/service_bindings/e7f54dee-4b7f-4dd8-8b0b-480539154a88"",
    ""created_at"": ""2015-04-16T12:04:14+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""2a2b09b2-c4a9-4d25-9e35-b5841104b2ba"",
    ""service_instance_guid"": ""37c4ef57-d779-43d6-a2b3-0a7418f6170c"",
    ""credentials"": {
      ""creds-key-17"": ""creds-val-17""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/2a2b09b2-c4a9-4d25-9e35-b5841104b2ba"",
    ""service_instance_url"": ""/v2/service_instances/37c4ef57-d779-43d6-a2b3-0a7418f6170c""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceBindings.RetrieveServiceBinding(guid).Result;


                Assert.AreEqual("e7f54dee-4b7f-4dd8-8b0b-480539154a88", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/e7f54dee-4b7f-4dd8-8b0b-480539154a88", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("2a2b09b2-c4a9-4d25-9e35-b5841104b2ba", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("37c4ef57-d779-43d6-a2b3-0a7418f6170c", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/2a2b09b2-c4a9-4d25-9e35-b5841104b2ba", TestUtil.ToTestableString(obj.AppUrl), true);
                Assert.AreEqual("/v2/service_instances/37c4ef57-d779-43d6-a2b3-0a7418f6170c", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsTest()
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
        ""guid"": ""8b1e7ee5-5e6a-4f7b-91d8-7f4fea488ef8"",
        ""url"": ""/v2/service_bindings/8b1e7ee5-5e6a-4f7b-91d8-7f4fea488ef8"",
        ""created_at"": ""2015-04-16T12:04:13+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""fd5bac66-7205-4d74-ace1-b721a8c47191"",
        ""service_instance_guid"": ""1be878f5-14d4-4b75-93af-2613ed860661"",
        ""credentials"": {
          ""creds-key-9"": ""creds-val-9""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/fd5bac66-7205-4d74-ace1-b721a8c47191"",
        ""service_instance_url"": ""/v2/service_instances/1be878f5-14d4-4b75-93af-2613ed860661""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceBindings.ListAllServiceBindings().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("8b1e7ee5-5e6a-4f7b-91d8-7f4fea488ef8", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/8b1e7ee5-5e6a-4f7b-91d8-7f4fea488ef8", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:13+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("fd5bac66-7205-4d74-ace1-b721a8c47191", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("1be878f5-14d4-4b75-93af-2613ed860661", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/fd5bac66-7205-4d74-ace1-b721a8c47191", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/service_instances/1be878f5-14d4-4b75-93af-2613ed860661", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceBindings.DeleteServiceBinding(guid).Wait();

            }
        }

        [TestMethod]
        public void CreateServiceBindingTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f43be5e1-cea9-4061-b8c2-7556ea46e14c"",
    ""url"": ""/v2/service_bindings/f43be5e1-cea9-4061-b8c2-7556ea46e14c"",
    ""created_at"": ""2015-04-16T12:04:14+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""app_guid"": ""f00a7716-66d9-43db-9e78-84eba6eafb56"",
    ""service_instance_guid"": ""efa04183-646b-4602-9ede-b6555287d8e7"",
    ""credentials"": {
      ""creds-key-23"": ""creds-val-23""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""app_url"": ""/v2/apps/f00a7716-66d9-43db-9e78-84eba6eafb56"",
    ""service_instance_url"": ""/v2/user_provided_service_instances/efa04183-646b-4602-9ede-b6555287d8e7""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceBindingRequest value = new CreateServiceBindingRequest();


                var obj = cfClient.ServiceBindings.CreateServiceBinding(value).Result;


                Assert.AreEqual("f43be5e1-cea9-4061-b8c2-7556ea46e14c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/f43be5e1-cea9-4061-b8c2-7556ea46e14c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-16T12:04:14+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("f00a7716-66d9-43db-9e78-84eba6eafb56", TestUtil.ToTestableString(obj.AppGuid), true);
                Assert.AreEqual("efa04183-646b-4602-9ede-b6555287d8e7", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/f00a7716-66d9-43db-9e78-84eba6eafb56", TestUtil.ToTestableString(obj.AppUrl), true);
                Assert.AreEqual("/v2/user_provided_service_instances/efa04183-646b-4602-9ede-b6555287d8e7", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

    }
}