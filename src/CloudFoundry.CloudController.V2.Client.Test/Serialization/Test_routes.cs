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
    public class RoutesTest
    {

        [TestMethod]
        public void TestUpdateRouteRequest()
        {
            string json = @"{
  ""host"": ""new_host""
}";

            UpdateRouteRequest request = new UpdateRouteRequest();

            request.Host = "new_host";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
        [TestMethod]
        public void TestCreateRouteRequest()
        {
            string json = @"{
  ""domain_guid"": ""2d7c75b6-3941-4346-bc7b-448e5262e60a"",
  ""space_guid"": ""b4f0a97b-4adb-4312-a6cf-0cc28642349e""
}";

            CreateRouteRequest request = new CreateRouteRequest();

            request.DomainGuid = new Guid("2d7c75b6-3941-4346-bc7b-448e5262e60a");
            request.SpaceGuid = new Guid("b4f0a97b-4adb-4312-a6cf-0cc28642349e");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(result, TestUtil.ToUnformatedJsonString(json));
        }
    }
}
