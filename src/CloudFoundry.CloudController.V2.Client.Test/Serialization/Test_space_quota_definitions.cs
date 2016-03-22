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
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class SpaceQuotaDefinitionsTest
    {

        [TestMethod]
        public void TestUpdateSpaceQuotaDefinitionRequest()
        {
            string json = @"{
  ""name"": ""new_name""
}";

            UpdateSpaceQuotaDefinitionRequest request = new UpdateSpaceQuotaDefinitionRequest();

            request.Name = "new_name";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateSpaceQuotaDefinitionRequest()
        {
            string json = @"{
  ""name"": ""gold_quota"",
  ""non_basic_services_allowed"": true,
  ""total_services"": -1,
  ""total_routes"": -1,
  ""memory_limit"": 5120,
  ""organization_guid"": ""aa4b7810-7f7a-4f26-a941-cb9a62b9ec71""
}";

            CreateSpaceQuotaDefinitionRequest request = new CreateSpaceQuotaDefinitionRequest();

            request.Name = "gold_quota";
            request.NonBasicServicesAllowed = true;
            request.TotalServices = -1;
            request.TotalRoutes = -1;
            request.MemoryLimit = 5120;
            request.OrganizationGuid = new Guid("aa4b7810-7f7a-4f26-a941-cb9a62b9ec71");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
