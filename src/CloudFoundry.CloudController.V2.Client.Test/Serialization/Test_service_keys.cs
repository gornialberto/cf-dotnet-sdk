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
    public class ServiceKeysTest
    {

        [TestMethod]
        public void TestCreateServiceKeyRequest()
        {
            string json = @"{
  ""service_instance_guid"": ""fdc41dbc-d3e1-4627-a956-f115bd3db253"",
  ""name"": ""name-604""
}";

            CreateServiceKeyRequest request = new CreateServiceKeyRequest();

            request.ServiceInstanceGuid = new Guid("fdc41dbc-d3e1-4627-a956-f115bd3db253");
            request.Name = "name-604";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
