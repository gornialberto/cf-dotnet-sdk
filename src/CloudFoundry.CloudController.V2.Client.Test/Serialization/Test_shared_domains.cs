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
    public class SharedDomainsTest
    {

        [TestMethod]
        public void TestCreateSharedDomainRequest()
        {
            string json = @"{
  ""name"": ""example.com"",
  ""router_group_guid"": ""29858a1a-4a98-4f20-84be-281c08992521""
}";

            CreateSharedDomainRequest request = new CreateSharedDomainRequest();

            request.Name = "example.com";
            request.RouterGroupGuid = new Guid("29858a1a-4a98-4f20-84be-281c08992521");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
