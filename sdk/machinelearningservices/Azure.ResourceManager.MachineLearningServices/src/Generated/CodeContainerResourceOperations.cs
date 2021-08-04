// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the operations that can be performed over a specific CodeContainerResource. </summary>
    public partial class CodeContainerResourceOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private CodeContainersRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="CodeContainerResourceOperations"/> class for mocking. </summary>
        protected CodeContainerResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CodeContainerResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal CodeContainerResourceOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CodeContainersRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/codes";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets a list of CodeVersionResources in the CodeContainerResource. </summary>
        /// <returns> An object representing collection of CodeVersionResources and their operations over a CodeContainerResource. </returns>
        public CodeVersionResourceContainer GetCodeVersionResources()
        {
            return new CodeVersionResourceContainer(this);
        }
    }
}
