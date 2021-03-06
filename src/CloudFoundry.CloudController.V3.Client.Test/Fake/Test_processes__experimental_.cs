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

using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V3.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ProcessesExperimentalEndpoint
{
        [TestMethod]
        public void GetProcessTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""2242625a-25c7-4a91-8fbf-30201f3c36b2"",
  ""type"": ""web"",
  ""command"": null,
  ""instances"": 1,
  ""memory_in_mb"": 1024,
  ""disk_in_mb"": 1024,
  ""created_at"": ""2016-07-07T09:17:15Z"",
  ""updated_at"": ""2016-07-07T09:17:15Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/processes/37e82c8c-4f79-4301-b15a-fce3ef4fe61d""
    },
    ""scale"": {
      ""href"": ""/v3/processes/37e82c8c-4f79-4301-b15a-fce3ef4fe61d/scale"",
      ""method"": ""PUT""
    },
    ""app"": {
      ""href"": ""/v3/apps/c8dc9e9b-cfd7-4b5a-a0a7-6645f5ce9b30""
    },
    ""space"": {
      ""href"": ""/v2/spaces/56022427-7f9d-4c5e-92bd-e4a02a11a10d""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ProcessesExperimental.GetProcess(guid).Result;


                Assert.AreEqual("2242625a-25c7-4a91-8fbf-30201f3c36b2", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Command), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj.MemoryInMb), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj.DiskInMb), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void ListAllProcessesTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""pagination"": {
    ""total_results"": 3,
    ""first"": {
      ""href"": ""/v3/processes?page=1=2""
    },
    ""last"": {
      ""href"": ""/v3/processes?page=2=2""
    },
    ""next"": {
      ""href"": ""/v3/processes?page=2=2""
    },
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""a3c920a5-75c0-4f84-937a-c7a7b69fc702"",
      ""type"": ""web"",
      ""command"": null,
      ""instances"": 1,
      ""memory_in_mb"": 1024,
      ""disk_in_mb"": 1024,
      ""created_at"": ""2016-07-07T09:17:15Z"",
      ""updated_at"": ""2016-07-07T09:17:15Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/processes/889df296-d82a-4b61-8493-bdfcaea3a88b""
        },
        ""scale"": {
          ""href"": ""/v3/processes/889df296-d82a-4b61-8493-bdfcaea3a88b/scale"",
          ""method"": ""PUT""
        },
        ""app"": {
          ""href"": ""/v3/apps/fd62c98f-03ed-430e-a202-7f21b12917f5""
        },
        ""space"": {
          ""href"": ""/v2/spaces/d9fe7c00-c912-4937-852f-7a89e4dcb753""
        }
      }
    },
    {
      ""guid"": ""a3c920a5-75c0-4f84-937a-c7a7b69fc702"",
      ""type"": ""web"",
      ""command"": null,
      ""instances"": 1,
      ""memory_in_mb"": 1024,
      ""disk_in_mb"": 1024,
      ""created_at"": ""2016-07-07T09:17:15Z"",
      ""updated_at"": ""2016-07-07T09:17:15Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/processes/60be1b2c-a14b-4a18-abe4-7eaa45bcbced""
        },
        ""scale"": {
          ""href"": ""/v3/processes/60be1b2c-a14b-4a18-abe4-7eaa45bcbced/scale"",
          ""method"": ""PUT""
        },
        ""app"": {
          ""href"": ""/v3/apps/""
        },
        ""space"": {
          ""href"": ""/v2/spaces/d9fe7c00-c912-4937-852f-7a89e4dcb753""
        }
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ProcessesExperimental.ListAllProcesses().Result;

                Assert.AreEqual("a3c920a5-75c0-4f84-937a-c7a7b69fc702", TestUtil.ToTestableString(obj[0].Guid), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Command), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].MemoryInMb), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].DiskInMb), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj[0].CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj[0].UpdatedAt), true);
                Assert.AreEqual("a3c920a5-75c0-4f84-937a-c7a7b69fc702", TestUtil.ToTestableString(obj[1].Guid), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj[1].Type), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].Command), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[1].Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[1].MemoryInMb), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[1].DiskInMb), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj[1].CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj[1].UpdatedAt), true);

            }
        }

        [TestMethod]
        public void ScalingProcessTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""3cd15332-7b75-4550-adf9-54a7f26b5ff4"",
  ""type"": ""web"",
  ""command"": null,
  ""instances"": 3,
  ""memory_in_mb"": 100,
  ""disk_in_mb"": 100,
  ""created_at"": ""2016-07-07T09:17:15Z"",
  ""updated_at"": ""2016-07-07T09:17:15Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/processes/db4a1298-c1f9-421d-8703-039cef4d069a""
    },
    ""scale"": {
      ""href"": ""/v3/processes/db4a1298-c1f9-421d-8703-039cef4d069a/scale"",
      ""method"": ""PUT""
    },
    ""app"": {
      ""href"": ""/v3/apps/a56861c2-c2fc-43d1-aead-e496456e121e""
    },
    ""space"": {
      ""href"": ""/v2/spaces/5e5296b1-11dd-4ce3-a566-87709cda4d12""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                ScalingProcessRequest value = new ScalingProcessRequest();


                var obj = cfClient.ProcessesExperimental.ScalingProcess(guid, value).Result;


                Assert.AreEqual("3cd15332-7b75-4550-adf9-54a7f26b5ff4", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Command), true);
                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Instances), true);
                Assert.AreEqual("100", TestUtil.ToTestableString(obj.MemoryInMb), true);
                Assert.AreEqual("100", TestUtil.ToTestableString(obj.DiskInMb), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

        [TestMethod]
        public void TerminatingProcessInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                int? index = 0;


                cfClient.ProcessesExperimental.TerminatingProcessInstance(guid, index).Wait();

            }
        }

        [TestMethod]
        public void UpdateProcessTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""guid"": ""25e2f097-bf52-4718-83ca-5cbfec2bed17"",
  ""type"": ""web"",
  ""command"": ""X"",
  ""instances"": 1,
  ""memory_in_mb"": 1024,
  ""disk_in_mb"": 1024,
  ""created_at"": ""2016-07-07T09:17:15Z"",
  ""updated_at"": ""2016-07-07T09:17:15Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/processes/5ee885ae-b24d-4b57-a90b-827000fd34e1""
    },
    ""scale"": {
      ""href"": ""/v3/processes/5ee885ae-b24d-4b57-a90b-827000fd34e1/scale"",
      ""method"": ""PUT""
    },
    ""app"": {
      ""href"": ""/v3/apps/""
    },
    ""space"": {
      ""href"": ""/v2/spaces/d6c4f9a8-af31-4960-8ba8-53a059e0fca8""
    }
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateProcessRequest value = new UpdateProcessRequest();


                var obj = cfClient.ProcessesExperimental.UpdateProcess(guid, value).Result;


                Assert.AreEqual("25e2f097-bf52-4718-83ca-5cbfec2bed17", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("web", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("X", TestUtil.ToTestableString(obj.Command), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj.MemoryInMb), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj.DiskInMb), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj.CreatedAt), true);
                Assert.AreEqual("2016-07-07T09:17:15Z", TestUtil.ToTestableString(obj.UpdatedAt), true);

            }
        }

    }
}