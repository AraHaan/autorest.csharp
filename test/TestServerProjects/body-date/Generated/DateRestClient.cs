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

namespace body_date
{
    internal partial class DateRestClient
    {
        private Uri endpoint;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DateRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        public DateRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            endpoint ??= new Uri("http://localhost:3000");

            this.endpoint = endpoint;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetNullRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/null", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get null date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DateTimeOffset>> GetNullAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetNullRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get null date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetNull(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetNullRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetInvalidDateRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/invaliddate", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get invalid date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DateTimeOffset>> GetInvalidDateAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetInvalidDateRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get invalid date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetInvalidDate(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetInvalidDateRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetOverflowDateRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/overflowdate", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get overflow date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DateTimeOffset>> GetOverflowDateAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetOverflowDateRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get overflow date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetOverflowDate(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetOverflowDateRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetUnderflowDateRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/underflowdate", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get underflow date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DateTimeOffset>> GetUnderflowDateAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetUnderflowDateRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get underflow date value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetUnderflowDate(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetUnderflowDateRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutMaxDateRequest(DateTimeOffset dateBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/max", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStringValue(dateBody, "D");
            request.Content = content;
            return message;
        }

        /// <summary> Put max date value 9999-12-31. </summary>
        /// <param name="dateBody"> The Date to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutMaxDateAsync(DateTimeOffset dateBody, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutMaxDateRequest(dateBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put max date value 9999-12-31. </summary>
        /// <param name="dateBody"> The Date to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutMaxDate(DateTimeOffset dateBody, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutMaxDateRequest(dateBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetMaxDateRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/max", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get max date value 9999-12-31. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DateTimeOffset>> GetMaxDateAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetMaxDateRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get max date value 9999-12-31. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetMaxDate(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetMaxDateRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutMinDateRequest(DateTimeOffset dateBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/min", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStringValue(dateBody, "D");
            request.Content = content;
            return message;
        }

        /// <summary> Put min date value 0000-01-01. </summary>
        /// <param name="dateBody"> The Date to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PutMinDateAsync(DateTimeOffset dateBody, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutMinDateRequest(dateBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Put min date value 0000-01-01. </summary>
        /// <param name="dateBody"> The Date to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response PutMinDate(DateTimeOffset dateBody, CancellationToken cancellationToken = default)
        {
            using var message = CreatePutMinDateRequest(dateBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetMinDateRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/date/min", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get min date value 0000-01-01. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<DateTimeOffset>> GetMinDateAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetMinDateRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get min date value 0000-01-01. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<DateTimeOffset> GetMinDate(CancellationToken cancellationToken = default)
        {
            using var message = CreateGetMinDateRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DateTimeOffset value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = document.RootElement.GetDateTimeOffset("D");
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
