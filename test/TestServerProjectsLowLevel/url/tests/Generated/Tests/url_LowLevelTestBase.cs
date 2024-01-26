// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core.TestFramework;
using url_LowLevel;

namespace url_LowLevel.Tests
{
    public partial class url_LowLevelTestBase : RecordedTestBase<url_LowLevelTestEnvironment>
    {
        public url_LowLevelTestBase(bool isAsync) : base(isAsync)
        {
        }

        protected PathsClient CreatePathsClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestUrlTestServiceClientOptions options = InstrumentClientOptions(new AutoRestUrlTestServiceClientOptions());
            PathsClient client = new PathsClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected QueriesClient CreateQueriesClient(Uri endpoint, AzureKeyCredential credential)
        {
            AutoRestUrlTestServiceClientOptions options = InstrumentClientOptions(new AutoRestUrlTestServiceClientOptions());
            QueriesClient client = new QueriesClient(endpoint, credential, options);
            return InstrumentClient(client);
        }

        protected PathItemsClient CreatePathItemsClient(Uri endpoint, string globalStringPath, AzureKeyCredential credential)
        {
            AutoRestUrlTestServiceClientOptions options = InstrumentClientOptions(new AutoRestUrlTestServiceClientOptions());
            PathItemsClient client = new PathItemsClient(endpoint, globalStringPath, credential, options);
            return InstrumentClient(client);
        }
    }
}
