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
using Azure.ResourceManager.MobileNetwork.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    internal partial class DiagnosticsPackagesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DiagnosticsPackagesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DiagnosticsPackagesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/diagnosticsPackages/", false);
            uri.AppendPath(diagnosticsPackageName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a diagnostics package. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="diagnosticsPackageName"> The name of the diagnostics package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(diagnosticsPackageName, nameof(diagnosticsPackageName));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, diagnosticsPackageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a diagnostics package. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="diagnosticsPackageName"> The name of the diagnostics package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(diagnosticsPackageName, nameof(diagnosticsPackageName));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, diagnosticsPackageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/diagnosticsPackages/", false);
            uri.AppendPath(diagnosticsPackageName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about the specified diagnostics package. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="diagnosticsPackageName"> The name of the diagnostics package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MobileNetworkDiagnosticsPackageData>> GetAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(diagnosticsPackageName, nameof(diagnosticsPackageName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, diagnosticsPackageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MobileNetworkDiagnosticsPackageData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MobileNetworkDiagnosticsPackageData.DeserializeMobileNetworkDiagnosticsPackageData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MobileNetworkDiagnosticsPackageData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about the specified diagnostics package. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="diagnosticsPackageName"> The name of the diagnostics package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MobileNetworkDiagnosticsPackageData> Get(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(diagnosticsPackageName, nameof(diagnosticsPackageName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, diagnosticsPackageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MobileNetworkDiagnosticsPackageData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MobileNetworkDiagnosticsPackageData.DeserializeMobileNetworkDiagnosticsPackageData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MobileNetworkDiagnosticsPackageData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/diagnosticsPackages/", false);
            uri.AppendPath(diagnosticsPackageName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the specified diagnostics package. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="diagnosticsPackageName"> The name of the diagnostics package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(diagnosticsPackageName, nameof(diagnosticsPackageName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, diagnosticsPackageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the specified diagnostics package. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="diagnosticsPackageName"> The name of the diagnostics package. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="packetCoreControlPlaneName"/> or <paramref name="diagnosticsPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, string diagnosticsPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));
            Argument.AssertNotNullOrEmpty(diagnosticsPackageName, nameof(diagnosticsPackageName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName, diagnosticsPackageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPacketCoreControlPlaneRequest(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/", false);
            uri.AppendPath(packetCoreControlPlaneName, true);
            uri.AppendPath("/diagnosticsPackages", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the diagnostics packages under a packet core control plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DiagnosticsPackageListResult>> ListByPacketCoreControlPlaneAsync(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticsPackageListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DiagnosticsPackageListResult.DeserializeDiagnosticsPackageListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the diagnostics packages under a packet core control plane. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DiagnosticsPackageListResult> ListByPacketCoreControlPlane(string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneRequest(subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticsPackageListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DiagnosticsPackageListResult.DeserializeDiagnosticsPackageListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPacketCoreControlPlaneNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the diagnostics packages under a packet core control plane. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DiagnosticsPackageListResult>> ListByPacketCoreControlPlaneNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneNextPageRequest(nextLink, subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticsPackageListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DiagnosticsPackageListResult.DeserializeDiagnosticsPackageListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the diagnostics packages under a packet core control plane. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DiagnosticsPackageListResult> ListByPacketCoreControlPlaneNextPage(string nextLink, string subscriptionId, string resourceGroupName, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(packetCoreControlPlaneName, nameof(packetCoreControlPlaneName));

            using var message = CreateListByPacketCoreControlPlaneNextPageRequest(nextLink, subscriptionId, resourceGroupName, packetCoreControlPlaneName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DiagnosticsPackageListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DiagnosticsPackageListResult.DeserializeDiagnosticsPackageListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
