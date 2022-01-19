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
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing collection of AfdRoute and their operations over its parent. </summary>
    public partial class AfdRouteCollection : ArmCollection, IEnumerable<AfdRoute>, IAsyncEnumerable<AfdRoute>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AfdRoutesRestOperations _afdRoutesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AfdRouteCollection"/> class for mocking. </summary>
        protected AfdRouteCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AfdRouteCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AfdRouteCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(AfdRoute.ResourceType, out string apiVersion);
            _afdRoutesRestClient = new AfdRoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AfdEndpoint.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AfdEndpoint.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="route"> Route properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public virtual AfdRouteCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string routeName, AfdRouteData route, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _afdRoutesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken);
                var operation = new AfdRouteCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _afdRoutesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route).Request, response);
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

        /// <summary> Creates a new route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="route"> Route properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="route"/> is null. </exception>
        public async virtual Task<AfdRouteCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string routeName, AfdRouteData route, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (route == null)
            {
                throw new ArgumentNullException(nameof(route));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _afdRoutesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route, cancellationToken).ConfigureAwait(false);
                var operation = new AfdRouteCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _afdRoutesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, route).Request, response);
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

        /// <summary> Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<AfdRoute> Get(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.Get");
            scope.Start();
            try
            {
                var response = _afdRoutesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AfdRoute(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an existing route with the specified route name under the specified subscription, resource group, profile, and AzureFrontDoor endpoint. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<AfdRoute>> GetAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.Get");
            scope.Start();
            try
            {
                var response = await _afdRoutesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AfdRoute(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<AfdRoute> GetIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _afdRoutesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AfdRoute>(null, response.GetRawResponse());
                return Response.FromValue(new AfdRoute(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<AfdRoute>> GetIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _afdRoutesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AfdRoute>(null, response.GetRawResponse());
                return Response.FromValue(new AfdRoute(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> Name of the routing rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AfdRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AfdRoute> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AfdRoute> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdRoutesRestClient.ListByEndpoint(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRoute(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AfdRoute> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _afdRoutesRestClient.ListByEndpointNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRoute(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all of the existing origins within a profile. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AfdRoute" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AfdRoute> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AfdRoute>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdRoutesRestClient.ListByEndpointAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRoute(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AfdRoute>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AfdRouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _afdRoutesRestClient.ListByEndpointNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AfdRoute(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AfdRoute> IEnumerable<AfdRoute>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AfdRoute> IAsyncEnumerable<AfdRoute>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, AfdRoute, AfdRouteData> Construct() { }
    }
}
