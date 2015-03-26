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
    public class ServiceauthtokensDeprecatedEndpoint
{
        [TestMethod]
        public void ListAllServiceAuthTokensDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""75a9a9e0-b76a-4bb6-ab35-82a264088a2e"",
        ""url"": ""/v2/service_auth_tokens/75a9a9e0-b76a-4bb6-ab35-82a264088a2e"",
        ""created_at"": ""2015-03-25T13:48:42+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-24"",
        ""provider"": ""provider-24""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3fef6ab9-f33a-4454-bb79-eab4b409e465"",
        ""url"": ""/v2/service_auth_tokens/3fef6ab9-f33a-4454-bb79-eab4b409e465"",
        ""created_at"": ""2015-03-25T13:48:42+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-25"",
        ""provider"": ""provider-25""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""8f269a0e-58a6-4cc6-ae19-d9de51ce9ccc"",
        ""url"": ""/v2/service_auth_tokens/8f269a0e-58a6-4cc6-ae19-d9de51ce9ccc"",
        ""created_at"": ""2015-03-25T13:48:42+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-26"",
        ""provider"": ""provider-26""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.ListAllServiceAuthTokensDeprecated().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("75a9a9e0-b76a-4bb6-ab35-82a264088a2e", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/75a9a9e0-b76a-4bb6-ab35-82a264088a2e", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:42+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-24", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("provider-24", TestUtil.ToTestableString(obj[0].Provider), true);
                Assert.AreEqual("3fef6ab9-f33a-4454-bb79-eab4b409e465", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/3fef6ab9-f33a-4454-bb79-eab4b409e465", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:42+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-25", TestUtil.ToTestableString(obj[1].Label), true);
                Assert.AreEqual("provider-25", TestUtil.ToTestableString(obj[1].Provider), true);
                Assert.AreEqual("8f269a0e-58a6-4cc6-ae19-d9de51ce9ccc", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/8f269a0e-58a6-4cc6-ae19-d9de51ce9ccc", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:42+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-26", TestUtil.ToTestableString(obj[2].Label), true);
                Assert.AreEqual("provider-26", TestUtil.ToTestableString(obj[2].Provider), true);

            }
        }

        [TestMethod]
        public void FilterResultSetByLabelDeprecatedTest()
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
        ""guid"": ""eea28f57-e366-4221-b663-99eb4532efa5"",
        ""url"": ""/v2/service_auth_tokens/eea28f57-e366-4221-b663-99eb4532efa5"",
        ""created_at"": ""2015-03-25T13:48:42+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""Nic-Token"",
        ""provider"": ""provider-23""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.FilterResultSetByLabelDeprecated().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("eea28f57-e366-4221-b663-99eb4532efa5", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/eea28f57-e366-4221-b663-99eb4532efa5", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:42+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("Nic-Token", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("provider-23", TestUtil.ToTestableString(obj[0].Provider), true);

            }
        }

        [TestMethod]
        public void DeleteServiceAuthTokenDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceAuthTokensDeprecated.DeleteServiceAuthTokenDeprecated(guid).Wait();

            }
        }

        [TestMethod]
        public void RetrieveServiceAuthTokenDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4a73375e-a8b3-4a92-8ec6-9276c7e21bb4"",
    ""url"": ""/v2/service_auth_tokens/4a73375e-a8b3-4a92-8ec6-9276c7e21bb4"",
    ""created_at"": ""2015-03-25T13:48:42+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-14"",
    ""provider"": ""provider-14""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceAuthTokensDeprecated.RetrieveServiceAuthTokenDeprecated(guid).Result;


                Assert.AreEqual("4a73375e-a8b3-4a92-8ec6-9276c7e21bb4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/4a73375e-a8b3-4a92-8ec6-9276c7e21bb4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:42+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-14", TestUtil.ToTestableString(obj.Label), true);
                Assert.AreEqual("provider-14", TestUtil.ToTestableString(obj.Provider), true);

            }
        }

        [TestMethod]
        public void FilterResultSetByProviderDeprecatedTest()
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
        ""guid"": ""4bd662d3-1a45-4a41-973d-164d91812000"",
        ""url"": ""/v2/service_auth_tokens/4bd662d3-1a45-4a41-973d-164d91812000"",
        ""created_at"": ""2015-03-25T13:48:42+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-20"",
        ""provider"": ""Face-Offer""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceAuthTokensDeprecated.FilterResultSetByProviderDeprecated().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("4bd662d3-1a45-4a41-973d-164d91812000", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_auth_tokens/4bd662d3-1a45-4a41-973d-164d91812000", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:42+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("label-20", TestUtil.ToTestableString(obj[0].Label), true);
                Assert.AreEqual("Face-Offer", TestUtil.ToTestableString(obj[0].Provider), true);

            }
        }

    }
}