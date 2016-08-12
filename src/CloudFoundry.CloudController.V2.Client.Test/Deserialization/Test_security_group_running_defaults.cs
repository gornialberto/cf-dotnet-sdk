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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SecurityGroupRunningDefaultsTest
    {


        [TestMethod]
        public void TestReturnSecurityGroupsUsedForRunningAppsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""5e12a80c-732f-41a8-8292-ab2813cdef5d"",
        ""url"": ""/v2/config/running_security_groups/297f8d1a-d4ff-412d-8122-988008caed12"",
        ""created_at"": ""2016-07-27T14:02:58Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2338"",
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

            PagedResponseCollection<ReturnSecurityGroupsUsedForRunningAppsResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForRunningAppsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("5e12a80c-732f-41a8-8292-ab2813cdef5d", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/297f8d1a-d4ff-412d-8122-988008caed12", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:58Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2338", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }

        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForRunningAppsResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ed2b86a3-d856-4383-ad9f-8f1727f0adb6"",
    ""url"": ""/v2/config/running_security_groups/6ea394c2-f4be-47e4-9f95-480aace6b111"",
    ""created_at"": ""2016-07-27T14:02:58Z"",
    ""updated_at"": ""2016-07-27T14:02:58Z""
  },
  ""entity"": {
    ""name"": ""name-2339"",
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

            SetSecurityGroupAsDefaultForRunningAppsResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForRunningAppsResponse>(json);

            Assert.AreEqual("ed2b86a3-d856-4383-ad9f-8f1727f0adb6", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/6ea394c2-f4be-47e4-9f95-480aace6b111", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:58Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-07-27T14:02:58Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2339", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
        }
    }
}
