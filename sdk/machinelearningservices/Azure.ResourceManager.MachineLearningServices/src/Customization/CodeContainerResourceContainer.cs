// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of CodeContainerResource and their operations over a Workspace. </summary>
    public partial class CodeContainerResourceContainer : ResourceContainer
    {

        // Container level operations.

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public virtual Response<CodeContainerResource> CreateOrUpdate(string name, CodeContainer properties, CancellationToken cancellationToken = default)
        {
            return Get(name, cancellationToken);
        }

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        public virtual Task<Response<CodeContainerResource>> CreateOrUpdateAsync(string name, CodeContainer properties, CancellationToken cancellationToken = default)
        {
            return GetAsync(name, cancellationToken);
        }

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal virtual CodeContainersCreateOrUpdateOperation StartCreateOrUpdate(string name, CodeContainer properties, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Create or update container. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal virtual Task<CodeContainersCreateOrUpdateOperation> StartCreateOrUpdateAsync(string name, CodeContainer properties, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CodeContainerResource> Get(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeContainerResourceContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                return Response.FromValue(GenerateResource(name), null);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Task<Response<CodeContainerResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CodeContainerResourceContainer.Get");
            scope.Start();
            try
            {
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }

                return Task.FromResult(Response.FromValue(GenerateResource(name), null));
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Response<CodeContainerResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Task<Response<CodeContainerResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Response<bool> CheckIfExists(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Container name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        internal virtual Task<Response<bool>> CheckIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> List containers. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CodeContainerResource" /> that may take multiple service requests to iterate over. </returns>
        internal Pageable<CodeContainerResource> GetAll(string skip = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> List containers. </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CodeContainerResource" /> that may take multiple service requests to iterate over. </returns>
        internal AsyncPageable<CodeContainerResource> GetAllAsync(string skip = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Filters the list of <see cref="CodeContainerResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        internal Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary> Filters the list of <see cref="CodeContainerResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        private CodeContainerResource GenerateResource(
            string name,
            CodeContainerResourceData resourceData = default)
        {
            resourceData ??= new CodeContainerResourceData(
                Parent.Id + $"/codes/{name}",
                name,
                CodeContainerResourceOperations.ResourceType,
                new CodeContainer(string.Empty, new Dictionary<string, string>(), new Dictionary<string, string>()),
                null);

            return new CodeContainerResource(Parent, resourceData);
        }
    }
}
