// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtSignalR;

namespace MgmtSignalR.Tests.Mock
{
    /// <summary> Test for PrivateEndpointConnection. </summary>
    public partial class PrivateEndpointConnectionMockTests : MockTestBase
    {
        public PrivateEndpointConnectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async System.Threading.Tasks.Task Get()
        {
            // Example: SignalRPrivateEndpointConnections_Get
            var privateEndpointConnectionId = MgmtSignalR.PrivateEndpointConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService", "mySignalRService.1fa229cd-bf3f-47f0-8c49-afb36723997e");
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(privateEndpointConnectionId);

            await privateEndpointConnection.GetAsync();
        }

        [RecordedTest]
        public async System.Threading.Tasks.Task Delete()
        {
            // Example: SignalRPrivateEndpointConnections_Delete
            var privateEndpointConnectionId = MgmtSignalR.PrivateEndpointConnection.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService", "mySignalRService.1fa229cd-bf3f-47f0-8c49-afb36723997e");
            var privateEndpointConnection = GetArmClient().GetPrivateEndpointConnection(privateEndpointConnectionId);

            await privateEndpointConnection.DeleteAsync(true);
        }
    }
}
