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
    public class OrganizationsTest
    {

        [TestMethod]
        public void TestDisassociateUserWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            DisassociateUserWithOrganizationByUsernameRequest request = new DisassociateUserWithOrganizationByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateOrganizationRequest()
        {
            string json = @"{
  ""name"": ""New Organization Name"",
  ""quota_definition_guid"": ""20fd2276-b306-4efa-bc2e-7de969f5bc0f""
}";

            UpdateOrganizationRequest request = new UpdateOrganizationRequest();

            request.Name = "New Organization Name";
            request.QuotaDefinitionGuid = new Guid("20fd2276-b306-4efa-bc2e-7de969f5bc0f");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestAssociateAuditorWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateAuditorWithOrganizationByUsernameRequest request = new AssociateAuditorWithOrganizationByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestAssociateUserWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateUserWithOrganizationByUsernameRequest request = new AssociateUserWithOrganizationByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestDisassociateManagerWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""manage@example.com""
}";

            DisassociateManagerWithOrganizationByUsernameRequest request = new DisassociateManagerWithOrganizationByUsernameRequest();

            request.Username = "manage@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestDisassociateBillingManagerWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""billing_manager@example.com""
}";

            DisassociateBillingManagerWithOrganizationByUsernameRequest request = new DisassociateBillingManagerWithOrganizationByUsernameRequest();

            request.Username = "billing_manager@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestAssociateManagerWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateManagerWithOrganizationByUsernameRequest request = new AssociateManagerWithOrganizationByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestAssociateBillingManagerWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""user@example.com""
}";

            AssociateBillingManagerWithOrganizationByUsernameRequest request = new AssociateBillingManagerWithOrganizationByUsernameRequest();

            request.Username = "user@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestDisassociateAuditorWithOrganizationByUsernameRequest()
        {
            string json = @"{
  ""username"": ""auditor@example.com""
}";

            DisassociateAuditorWithOrganizationByUsernameRequest request = new DisassociateAuditorWithOrganizationByUsernameRequest();

            request.Username = "auditor@example.com";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateOrganizationRequest()
        {
            string json = @"{
  ""name"": ""my-org-name"",
  ""quota_definition_guid"": ""662c8c0b-f40c-4416-9c12-4c85f56224cc""
}";

            CreateOrganizationRequest request = new CreateOrganizationRequest();

            request.Name = "my-org-name";
            request.QuotaDefinitionGuid = new Guid("662c8c0b-f40c-4416-9c12-4c85f56224cc");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
