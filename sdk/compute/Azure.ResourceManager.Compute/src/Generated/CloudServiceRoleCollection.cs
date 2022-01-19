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
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of CloudServiceRole and their operations over its parent. </summary>
    public partial class CloudServiceRoleCollection : ArmCollection, IEnumerable<CloudServiceRole>, IAsyncEnumerable<CloudServiceRole>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CloudServiceRolesRestOperations _cloudServiceRolesRestClient;

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRoleCollection"/> class for mocking. </summary>
        protected CloudServiceRoleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CloudServiceRoleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CloudServiceRoleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(CloudServiceRole.ResourceType, out string apiVersion);
            _cloudServiceRolesRestClient = new CloudServiceRolesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CloudService.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CloudService.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Gets a role from a cloud service. </summary>
        /// <param name="roleName"> Name of the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual Response<CloudServiceRole> Get(string roleName, CancellationToken cancellationToken = default)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.Get");
            scope.Start();
            try
            {
                var response = _cloudServiceRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CloudServiceRole(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a role from a cloud service. </summary>
        /// <param name="roleName"> Name of the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public async virtual Task<Response<CloudServiceRole>> GetAsync(string roleName, CancellationToken cancellationToken = default)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.Get");
            scope.Start();
            try
            {
                var response = await _cloudServiceRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CloudServiceRole(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleName"> Name of the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual Response<CloudServiceRole> GetIfExists(string roleName, CancellationToken cancellationToken = default)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cloudServiceRolesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CloudServiceRole>(null, response.GetRawResponse());
                return Response.FromValue(new CloudServiceRole(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleName"> Name of the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public async virtual Task<Response<CloudServiceRole>> GetIfExistsAsync(string roleName, CancellationToken cancellationToken = default)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cloudServiceRolesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CloudServiceRole>(null, response.GetRawResponse());
                return Response.FromValue(new CloudServiceRole(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleName"> Name of the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleName, CancellationToken cancellationToken = default)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(roleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleName"> Name of the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string roleName, CancellationToken cancellationToken = default)
        {
            if (roleName == null)
            {
                throw new ArgumentNullException(nameof(roleName));
            }

            using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(roleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all roles in a cloud service. Use nextLink property in the response to get the next page of roles. Do this till nextLink is null to fetch all the roles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CloudServiceRole" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CloudServiceRole> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CloudServiceRole> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceRolesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceRole(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<CloudServiceRole> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _cloudServiceRolesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceRole(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all roles in a cloud service. Use nextLink property in the response to get the next page of roles. Do this till nextLink is null to fetch all the roles. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CloudServiceRole" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CloudServiceRole> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CloudServiceRole>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceRolesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceRole(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<CloudServiceRole>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CloudServiceRoleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _cloudServiceRolesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CloudServiceRole(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<CloudServiceRole> IEnumerable<CloudServiceRole>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CloudServiceRole> IAsyncEnumerable<CloudServiceRole>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CloudServiceRole, CloudServiceRoleData> Construct() { }
    }
}
