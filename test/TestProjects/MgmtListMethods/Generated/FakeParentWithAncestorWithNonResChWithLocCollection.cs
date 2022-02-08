// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of FakeParentWithAncestorWithNonResChWithLoc and their operations over its parent. </summary>
    public partial class FakeParentWithAncestorWithNonResChWithLocCollection : ArmCollection, IEnumerable<FakeParentWithAncestorWithNonResChWithLoc>, IAsyncEnumerable<FakeParentWithAncestorWithNonResChWithLoc>
    {
        private readonly ClientDiagnostics _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics;
        private readonly FakeParentWithAncestorWithNonResChWithLocsRestOperations _fakeParentWithAncestorWithNonResChWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocCollection"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithNonResChWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FakeParentWithAncestorWithNonResChWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", FakeParentWithAncestorWithNonResChWithLoc.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(FakeParentWithAncestorWithNonResChWithLoc.ResourceType, out string fakeParentWithAncestorWithNonResChWithLocApiVersion);
            _fakeParentWithAncestorWithNonResChWithLocRestClient = new FakeParentWithAncestorWithNonResChWithLocsRestOperations(_fakeParentWithAncestorWithNonResChWithLocClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, fakeParentWithAncestorWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Fake.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Fake.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<FakeParentWithAncestorWithNonResChWithLoc>> CreateOrUpdateAsync(bool waitForCompletion, string fakeParentWithAncestorWithNonResChWithLocName, FakeParentWithAncestorWithNonResChWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<FakeParentWithAncestorWithNonResChWithLoc>(Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<FakeParentWithAncestorWithNonResChWithLoc> CreateOrUpdate(bool waitForCompletion, string fakeParentWithAncestorWithNonResChWithLocName, FakeParentWithAncestorWithNonResChWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChWithLocName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<FakeParentWithAncestorWithNonResChWithLoc>(Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithAncestorWithNonResChWithLoc>> GetAsync(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLoc> Get(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_ListTest
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithAncestorWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithAncestorWithNonResChWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeParentWithAncestorWithNonResChWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.ListTestAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FakeParentWithAncestorWithNonResChWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.ListTestNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_ListTest
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithAncestorWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithAncestorWithNonResChWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FakeParentWithAncestorWithNonResChWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.ListTest(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FakeParentWithAncestorWithNonResChWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.ListTestNextPage(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithNonResChWithLoc(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithAncestorWithNonResChWithLoc>> GetIfExistsAsync(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FakeParentWithAncestorWithNonResChWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLoc> GetIfExists(string fakeParentWithAncestorWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeParentWithAncestorWithNonResChWithLocName, nameof(fakeParentWithAncestorWithNonResChWithLocName));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithNonResChWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FakeParentWithAncestorWithNonResChWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLoc(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FakeParentWithAncestorWithNonResChWithLoc> IEnumerable<FakeParentWithAncestorWithNonResChWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FakeParentWithAncestorWithNonResChWithLoc> IAsyncEnumerable<FakeParentWithAncestorWithNonResChWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
