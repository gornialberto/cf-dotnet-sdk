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
    public class SecurityGroupRunningDefaultsEndpoint
{
        [TestMethod]
        public void SetSecurityGroupAsDefaultForRunningAppsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""d0da217c-3fc9-456e-a7ca-d7a34ab7d773"",
    ""url"": ""/v2/config/running_security_groups/d0da217c-3fc9-456e-a7ca-d7a34ab7d773"",
    ""created_at"": ""2015-03-25T13:48:58+00:00"",
    ""updated_at"": ""2015-03-25T13:48:58+00:00""
  },
  ""entity"": {
    ""name"": ""name-1827"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": true,
    ""staging_default"": false
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroupRunningDefaults.SetSecurityGroupAsDefaultForRunningApps(guid).Result;


                Assert.AreEqual("d0da217c-3fc9-456e-a7ca-d7a34ab7d773", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/running_security_groups/d0da217c-3fc9-456e-a7ca-d7a34ab7d773", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1827", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);

            }
        }

        [TestMethod]
        public void RemovingSecurityGroupAsDefaultForRunningAppsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SecurityGroupRunningDefaults.RemovingSecurityGroupAsDefaultForRunningApps(guid).Wait();

            }
        }

        [TestMethod]
        public void ReturnSecurityGroupsUsedForRunningAppsTest()
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
        ""guid"": ""ea7e859c-a04c-42bb-b110-266fe4142f88"",
        ""url"": ""/v2/config/running_security_groups/ea7e859c-a04c-42bb-b110-266fe4142f88"",
        ""created_at"": ""2015-03-25T13:48:58+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1826"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": true,
        ""staging_default"": false
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SecurityGroupRunningDefaults.ReturnSecurityGroupsUsedForRunningApps().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("ea7e859c-a04c-42bb-b110-266fe4142f88", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/config/running_security_groups/ea7e859c-a04c-42bb-b110-266fe4142f88", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-03-25T13:48:58+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1826", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].StagingDefault), true);

            }
        }

    }
}