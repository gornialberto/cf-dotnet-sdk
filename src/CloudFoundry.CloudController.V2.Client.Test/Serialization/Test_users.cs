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
    public class UsersTest
    {

        [TestMethod]
        public void TestUpdateUserRequest()
        {
            string json = @"{
  ""default_space_guid"": ""fb1cb130-87c1-445c-9575-24ac85b660fc""
}";

            UpdateUserRequest request = new UpdateUserRequest();

            request.DefaultSpaceGuid = new Guid("fb1cb130-87c1-445c-9575-24ac85b660fc");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateUserRequest()
        {
            string json = @"{
  ""guid"": ""0a414230-309b-45b6-9cdf-1af2759ee6a0""
}";

            CreateUserRequest request = new CreateUserRequest();

            request.Guid = new Guid("0a414230-309b-45b6-9cdf-1af2759ee6a0");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
