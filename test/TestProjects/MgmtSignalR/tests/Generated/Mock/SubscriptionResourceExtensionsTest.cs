// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtSignalR.Models;

namespace MgmtSignalR.Tests.Mock
{
    /// <summary> Test for SubscriptionResource. </summary>
    public partial class SubscriptionResourceExtensionsMockTests : MockTestBase
    {
        public SubscriptionResourceExtensionsMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CheckNameAvailabilitySignalR()
        {
            // Example: SignalR_CheckNameAvailability
            var subscriptionResourceExtensions = GetArmClient().GetSubscriptionResource(SubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000"));
            string location = "eastus";
            MgmtSignalR.Models.NameAvailabilityParameters parameters = new MgmtSignalR.Models.NameAvailabilityParameters(resourceType: "Microsoft.SignalRService/SignalR", name: "my-signalr-service");

            await subscriptionResourceExtensions.CheckNameAvailabilitySignalRAsync(location, parameters);
        }

        [RecordedTest]
        public async Task GetSignalRResources()
        {
            // Example: SignalR_ListBySubscription
            var subscriptionResourceExtensions = GetArmClient().GetSubscriptionResource(SubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000"));

            await foreach (var _ in subscriptionResourceExtensions.GetSignalRResourcesAsync())
            {
            }
        }

        [RecordedTest]
        public async Task GetUsages()
        {
            // Example: Usages_List
            var subscriptionResourceExtensions = GetArmClient().GetSubscriptionResource(SubscriptionResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000"));
            string location = "eastus";

            await foreach (var _ in subscriptionResourceExtensions.GetUsagesAsync(location))
            {
            }
        }
    }
}
