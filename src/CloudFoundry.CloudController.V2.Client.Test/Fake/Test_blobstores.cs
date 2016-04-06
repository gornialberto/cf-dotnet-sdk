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
    public class BlobstoresEndpoint
{
        [TestMethod]
        public void DeleteAllBlobsInBuildpackCacheBlobstoreTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""841e7b1f-5c69-4ce0-a287-b2400944fd1b"",
    ""created_at"": ""2016-03-30T10:15:16Z"",
    ""url"": ""/v2/jobs/1f518cb9-dbe2-4c53-a042-dcda449cb93d""
  },
  ""entity"": {
    ""guid"": ""841e7b1f-5c69-4ce0-a287-b2400944fd1b"",
    ""status"": ""queued""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)202;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Blobstores.DeleteAllBlobsInBuildpackCacheBlobstore().Result;


                Assert.AreEqual("841e7b1f-5c69-4ce0-a287-b2400944fd1b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-03-30T10:15:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("/v2/jobs/1f518cb9-dbe2-4c53-a042-dcda449cb93d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("841e7b1f-5c69-4ce0-a287-b2400944fd1b", TestUtil.ToTestableString(obj.Guid), true);
                Assert.AreEqual("queued", TestUtil.ToTestableString(obj.Status), true);

            }
        }

    }
}