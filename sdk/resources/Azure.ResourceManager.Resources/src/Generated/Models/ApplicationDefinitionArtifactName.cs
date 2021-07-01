// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Resources
{
    /// <summary> The managed application artifact name. </summary>
    public readonly partial struct ApplicationDefinitionArtifactName : IEquatable<ApplicationDefinitionArtifactName>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ApplicationDefinitionArtifactName"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationDefinitionArtifactName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string ApplicationResourceTemplateValue = "ApplicationResourceTemplate";
        private const string CreateUiDefinitionValue = "CreateUiDefinition";
        private const string MainTemplateParametersValue = "MainTemplateParameters";

        /// <summary> NotSpecified. </summary>
        public static ApplicationDefinitionArtifactName NotSpecified { get; } = new ApplicationDefinitionArtifactName(NotSpecifiedValue);
        /// <summary> ApplicationResourceTemplate. </summary>
        public static ApplicationDefinitionArtifactName ApplicationResourceTemplate { get; } = new ApplicationDefinitionArtifactName(ApplicationResourceTemplateValue);
        /// <summary> CreateUiDefinition. </summary>
        public static ApplicationDefinitionArtifactName CreateUiDefinition { get; } = new ApplicationDefinitionArtifactName(CreateUiDefinitionValue);
        /// <summary> MainTemplateParameters. </summary>
        public static ApplicationDefinitionArtifactName MainTemplateParameters { get; } = new ApplicationDefinitionArtifactName(MainTemplateParametersValue);
        /// <summary> Determines if two <see cref="ApplicationDefinitionArtifactName"/> values are the same. </summary>
        public static bool operator ==(ApplicationDefinitionArtifactName left, ApplicationDefinitionArtifactName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationDefinitionArtifactName"/> values are not the same. </summary>
        public static bool operator !=(ApplicationDefinitionArtifactName left, ApplicationDefinitionArtifactName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationDefinitionArtifactName"/>. </summary>
        public static implicit operator ApplicationDefinitionArtifactName(string value) => new ApplicationDefinitionArtifactName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationDefinitionArtifactName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationDefinitionArtifactName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
