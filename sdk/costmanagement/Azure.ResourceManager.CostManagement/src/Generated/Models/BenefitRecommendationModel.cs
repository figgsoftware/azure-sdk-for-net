// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> benefit plan recommendation details. </summary>
    public partial class BenefitRecommendationModel : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BenefitRecommendationModel"/>. </summary>
        public BenefitRecommendationModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BenefitRecommendationModel"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// The properties of the benefit recommendations.
        /// Please note <see cref="BenefitRecommendationProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SharedScopeBenefitRecommendationProperties"/> and <see cref="SingleScopeBenefitRecommendationProperties"/>.
        /// </param>
        /// <param name="kind"> Reservation or SavingsPlan. </param>
        internal BenefitRecommendationModel(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BenefitRecommendationProperties properties, BillingAccountBenefitKind? kind) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary>
        /// The properties of the benefit recommendations.
        /// Please note <see cref="BenefitRecommendationProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SharedScopeBenefitRecommendationProperties"/> and <see cref="SingleScopeBenefitRecommendationProperties"/>.
        /// </summary>
        public BenefitRecommendationProperties Properties { get; set; }
        /// <summary> Reservation or SavingsPlan. </summary>
        public BillingAccountBenefitKind? Kind { get; set; }
    }
}
