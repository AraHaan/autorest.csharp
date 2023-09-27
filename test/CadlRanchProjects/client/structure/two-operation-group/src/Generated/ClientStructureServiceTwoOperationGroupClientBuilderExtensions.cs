// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Client.Structure.Service.TwoOperationGroup;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="TwoOperationGroupClient"/> to client builder. </summary>
    public static partial class ClientStructureServiceTwoOperationGroupClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="TwoOperationGroupClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        public static IAzureClientBuilder<TwoOperationGroupClient, TwoOperationGroupClientOptions> AddTwoOperationGroupClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<TwoOperationGroupClient, TwoOperationGroupClientOptions>((options) => new TwoOperationGroupClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="TwoOperationGroupClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<TwoOperationGroupClient, TwoOperationGroupClientOptions> AddTwoOperationGroupClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<TwoOperationGroupClient, TwoOperationGroupClientOptions>(configuration);
        }
    }
}
