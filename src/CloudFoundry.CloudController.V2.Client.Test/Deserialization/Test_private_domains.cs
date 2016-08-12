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
    public class PrivateDomainsTest
    {


        [TestMethod]
        public void TestRetrievePrivateDomainResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c28e19f8-09cb-425b-a200-bf18e9c13467"",
    ""url"": ""/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde"",
    ""created_at"": ""2016-07-27T14:02:27Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""c28e19f8-09cb-425b-a200-bf18e9c13467"",
    ""owning_organization_url"": ""/v2/organizations/05f43e1a-5da5-4a98-9d16-04de921dbb6e"",
    ""shared_organizations_url"": ""/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde/shared_organizations""
  }
}";

            RetrievePrivateDomainResponse obj = Utilities.DeserializeJson<RetrievePrivateDomainResponse>(json);

            Assert.AreEqual("c28e19f8-09cb-425b-a200-bf18e9c13467", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:27Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("c28e19f8-09cb-425b-a200-bf18e9c13467", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/05f43e1a-5da5-4a98-9d16-04de921dbb6e", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestListAllPrivateDomainsResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""url"": ""/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde"",
        ""created_at"": ""2016-07-27T14:02:27Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""owning_organization_url"": ""/v2/organizations/05f43e1a-5da5-4a98-9d16-04de921dbb6e"",
        ""shared_organizations_url"": ""/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""url"": ""/v2/private_domains/ac1da062-85df-427d-a315-ee0776f23602"",
        ""created_at"": ""2016-07-27T14:02:31Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-35.example.com"",
        ""owning_organization_guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""owning_organization_url"": ""/v2/organizations/14d95077-265c-44d6-95c8-ab90297ac430"",
        ""shared_organizations_url"": ""/v2/private_domains/ac1da062-85df-427d-a315-ee0776f23602/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""url"": ""/v2/private_domains/a9c2403b-bf00-476e-8909-faaff3d50380"",
        ""created_at"": ""2016-07-27T14:02:31Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-36.example.com"",
        ""owning_organization_guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""owning_organization_url"": ""/v2/organizations/4436a3bc-9a34-46b2-a1eb-99da07682c6a"",
        ""shared_organizations_url"": ""/v2/private_domains/a9c2403b-bf00-476e-8909-faaff3d50380/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""url"": ""/v2/private_domains/72a75e33-a4dc-454f-ba09-ee6a2143c98c"",
        ""created_at"": ""2016-07-27T14:02:31Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-37.example.com"",
        ""owning_organization_guid"": ""2f97976b-4cbe-47c1-a23b-388a24f75c1a"",
        ""owning_organization_url"": ""/v2/organizations/636a952b-7931-486b-828b-90e8e24ee265"",
        ""shared_organizations_url"": ""/v2/private_domains/72a75e33-a4dc-454f-ba09-ee6a2143c98c/shared_organizations""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllPrivateDomainsResponse> page = Utilities.DeserializePage<ListAllPrivateDomainsResponse>(json, null);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:27Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/05f43e1a-5da5-4a98-9d16-04de921dbb6e", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/abf20200-6a35-44b7-823e-e1793c7c1fde/shared_organizations", TestUtil.ToTestableString(page[0].SharedOrganizationsUrl), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/ac1da062-85df-427d-a315-ee0776f23602", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:31Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-35.example.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[1].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/14d95077-265c-44d6-95c8-ab90297ac430", TestUtil.ToTestableString(page[1].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/ac1da062-85df-427d-a315-ee0776f23602/shared_organizations", TestUtil.ToTestableString(page[1].SharedOrganizationsUrl), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/a9c2403b-bf00-476e-8909-faaff3d50380", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:31Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-36.example.com", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/4436a3bc-9a34-46b2-a1eb-99da07682c6a", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/a9c2403b-bf00-476e-8909-faaff3d50380/shared_organizations", TestUtil.ToTestableString(page[2].SharedOrganizationsUrl), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/72a75e33-a4dc-454f-ba09-ee6a2143c98c", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:31Z", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-37.example.com", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("2f97976b-4cbe-47c1-a23b-388a24f75c1a", TestUtil.ToTestableString(page[3].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/636a952b-7931-486b-828b-90e8e24ee265", TestUtil.ToTestableString(page[3].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/72a75e33-a4dc-454f-ba09-ee6a2143c98c/shared_organizations", TestUtil.ToTestableString(page[3].SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestCreatePrivateDomainOwnedByGivenOrganizationResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""1be5de52-1556-417c-975e-5a4d56b7f786"",
    ""url"": ""/v2/private_domains/fa6d5c1e-dce5-444f-8501-52b063edde39"",
    ""created_at"": ""2016-07-27T14:02:32Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""1be5de52-1556-417c-975e-5a4d56b7f786"",
    ""owning_organization_url"": ""/v2/organizations/e1e47995-1216-4aff-96e8-00b4500f25f4"",
    ""shared_organizations_url"": ""/v2/private_domains/fa6d5c1e-dce5-444f-8501-52b063edde39/shared_organizations""
  }
}";

            CreatePrivateDomainOwnedByGivenOrganizationResponse obj = Utilities.DeserializeJson<CreatePrivateDomainOwnedByGivenOrganizationResponse>(json);

            Assert.AreEqual("1be5de52-1556-417c-975e-5a4d56b7f786", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/fa6d5c1e-dce5-444f-8501-52b063edde39", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1be5de52-1556-417c-975e-5a4d56b7f786", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/e1e47995-1216-4aff-96e8-00b4500f25f4", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/fa6d5c1e-dce5-444f-8501-52b063edde39/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestListAllSharedOrganizationsForPrivateDomainResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""55665285-d1ac-4329-becc-3636dbb0f2b3"",
        ""url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d"",
        ""created_at"": ""2016-07-27T14:02:31Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-176"",
        ""billing_enabled"": false,
        ""quota_definition_guid"": ""55665285-d1ac-4329-becc-3636dbb0f2b3"",
        ""status"": ""active"",
        ""quota_definition_url"": ""/v2/quota_definitions/dcb0d729-912e-4d3f-9d0b-042f248ef3a0"",
        ""spaces_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/spaces"",
        ""domains_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/domains"",
        ""private_domains_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/private_domains"",
        ""users_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/users"",
        ""managers_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/managers"",
        ""billing_managers_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/billing_managers"",
        ""auditors_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/auditors"",
        ""app_events_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/app_events"",
        ""space_quota_definitions_url"": ""/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/space_quota_definitions""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSharedOrganizationsForPrivateDomainResponse> page = Utilities.DeserializePage<ListAllSharedOrganizationsForPrivateDomainResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("55665285-d1ac-4329-becc-3636dbb0f2b3", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:31Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-176", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].BillingEnabled), true);
            Assert.AreEqual("55665285-d1ac-4329-becc-3636dbb0f2b3", TestUtil.ToTestableString(page[0].QuotaDefinitionGuid), true);
            Assert.AreEqual("active", TestUtil.ToTestableString(page[0].Status), true);
            Assert.AreEqual("/v2/quota_definitions/dcb0d729-912e-4d3f-9d0b-042f248ef3a0", TestUtil.ToTestableString(page[0].QuotaDefinitionUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/private_domains", TestUtil.ToTestableString(page[0].PrivateDomainsUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/users", TestUtil.ToTestableString(page[0].UsersUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/billing_managers", TestUtil.ToTestableString(page[0].BillingManagersUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/organizations/790b7119-71b2-47e1-9589-11c12710307d/space_quota_definitions", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionsUrl), true);
        }

        [TestMethod]
        public void TestFilterPrivateDomainsByNameResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d8f109c7-a4d4-49d6-ad9a-459fdf72d21e"",
        ""url"": ""/v2/private_domains/c63c8e29-0c6c-4697-bbd8-eff9f5c87881"",
        ""created_at"": ""2016-07-27T14:02:32Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""d8f109c7-a4d4-49d6-ad9a-459fdf72d21e"",
        ""owning_organization_url"": ""/v2/organizations/3f193bfc-bbad-49d8-9a1d-04a9adee2478"",
        ""shared_organizations_url"": ""/v2/private_domains/c63c8e29-0c6c-4697-bbd8-eff9f5c87881/shared_organizations""
      }
    }
  ]
}";

            PagedResponseCollection<FilterPrivateDomainsByNameResponse> page = Utilities.DeserializePage<FilterPrivateDomainsByNameResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("d8f109c7-a4d4-49d6-ad9a-459fdf72d21e", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/c63c8e29-0c6c-4697-bbd8-eff9f5c87881", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-07-27T14:02:32Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("d8f109c7-a4d4-49d6-ad9a-459fdf72d21e", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/3f193bfc-bbad-49d8-9a1d-04a9adee2478", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/c63c8e29-0c6c-4697-bbd8-eff9f5c87881/shared_organizations", TestUtil.ToTestableString(page[0].SharedOrganizationsUrl), true);
        }
    }
}
