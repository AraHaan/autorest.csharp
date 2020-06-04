// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using CustomNamespace;
using TypeSchemaMapping.Models;

namespace TypeSchemaMapping
{
    internal partial class MainRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of MainRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public MainRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateOperationRequest(CustomizedModel body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/Operation/", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (body != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> OperationAsync(CustomizedModel body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="body"> The Model to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Operation(CustomizedModel body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateOperationStructRequest(RenamedModelStruct? body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/OperationStruct/", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (body != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="body"> The ModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<RenamedModelStruct>> OperationStructAsync(RenamedModelStruct? body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationStructRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RenamedModelStruct value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RenamedModelStruct.DeserializeRenamedModelStruct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="body"> The ModelStruct to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<RenamedModelStruct> OperationStruct(RenamedModelStruct? body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationStructRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RenamedModelStruct value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RenamedModelStruct.DeserializeRenamedModelStruct(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateOperationSecondModelRequest(SecondModel body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/OperationSecondModel", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (body != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="body"> The SecondModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<SecondModel>> OperationSecondModelAsync(SecondModel body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationSecondModelRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecondModel value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SecondModel.DeserializeSecondModel(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="body"> The SecondModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<SecondModel> OperationSecondModel(SecondModel body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationSecondModelRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecondModel value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = SecondModel.DeserializeSecondModel(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateOperationModelWithArrayOfEnumRequest(ModelWithArrayOfEnum body)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/OperationModelWithArrayOfEnum", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            if (body != null)
            {
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(body);
                request.Content = content;
            }
            return message;
        }

        /// <param name="body"> The ModelWithArrayOfEnum to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ModelWithArrayOfEnum>> OperationModelWithArrayOfEnumAsync(ModelWithArrayOfEnum body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationModelWithArrayOfEnumRequest(body);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelWithArrayOfEnum value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ModelWithArrayOfEnum.DeserializeModelWithArrayOfEnum(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="body"> The ModelWithArrayOfEnum to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ModelWithArrayOfEnum> OperationModelWithArrayOfEnum(ModelWithArrayOfEnum body = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateOperationModelWithArrayOfEnumRequest(body);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ModelWithArrayOfEnum value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        if (document.RootElement.ValueKind == JsonValueKind.Null)
                        {
                            value = null;
                        }
                        else
                        {
                            value = ModelWithArrayOfEnum.DeserializeModelWithArrayOfEnum(document.RootElement);
                        }
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
