// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace BodyAndPath_LowLevel
{
    /// <summary> The BodyAndPath service client. </summary>
    public partial class BodyAndPathClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of BodyAndPathClient for mocking. </summary>
        protected BodyAndPathClient()
        {
        }

        /// <summary> Initializes a new instance of BodyAndPathClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public BodyAndPathClient(AzureKeyCredential credential, Uri endpoint = null, BodyAndPathClientOptions options = null)
        {
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            endpoint ??= new Uri("http://localhost:3000");

            options ??= new BodyAndPathClientOptions();

            _clientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, new HttpPipelinePolicy[] { new LowLevelCallbackPolicy() }, new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemName"/> or <paramref name="content"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateAsync(string itemName, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(itemName, content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemName"/> or <paramref name="content"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual Response Create(string itemName, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(itemName, content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemNameStream"/> or <paramref name="content"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateStreamAsync(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemNameStream"/> or <paramref name="content"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual Response CreateStream(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="enumName1"> The first name. Allowed values: &quot;current&quot; | &quot;default&quot;. </param>
        /// <param name="enumName2"> The second name. Allowed values: &quot;latest&quot;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enumName1"/>, <paramref name="enumName2"/>, or <paramref name="content"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateEnumAsync(string enumName1, string enumName2, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateEnumRequest(enumName1, enumName2, content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="enumName1"> The first name. Allowed values: &quot;current&quot; | &quot;default&quot;. </param>
        /// <param name="enumName2"> The second name. Allowed values: &quot;latest&quot;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enumName1"/>, <paramref name="enumName2"/>, or <paramref name="content"/> is null. </exception>
#pragma warning disable AZC0002
        public virtual Response CreateEnum(string enumName1, string enumName2, RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateEnumRequest(enumName1, enumName2, content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetBodyAndPathsAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.GetBodyAndPaths");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetBodyAndPathsRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetBodyAndPaths(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.GetBodyAndPaths");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetBodyAndPathsRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all products. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetItemsAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.GetItems");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemsRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all products. </summary>
        /// <param name="options"> The request options. </param>
#pragma warning disable AZC0002
        public virtual Response GetItems(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("BodyAndPathClient.GetItems");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemsRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateRequest(string itemName, RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemName, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateStreamRequest(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemNameStream, true);
            if (excluded != null)
            {
                foreach (var param in excluded)
                {
                    uri.AppendQuery("excluded", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateEnumRequest(string enumName1, string enumName2, RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(enumName1, true);
            uri.AppendPath("/", false);
            uri.AppendPath(enumName2, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetBodyAndPathsRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/list", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetItemsRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/listItems", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
