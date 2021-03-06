// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Network security rules evaluation result.
    /// </summary>
    public partial class NetworkSecurityRulesEvaluationResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NetworkSecurityRulesEvaluationResult class.
        /// </summary>
        public NetworkSecurityRulesEvaluationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NetworkSecurityRulesEvaluationResult class.
        /// </summary>
        /// <param name="name">Name of the network security rule.</param>
        /// <param name="protocolMatched">Value indicating whether protocol is
        /// matched.</param>
        /// <param name="sourceMatched">Value indicating whether source is
        /// matched.</param>
        /// <param name="sourcePortMatched">Value indicating whether source
        /// port is matched.</param>
        /// <param name="destinationMatched">Value indicating whether
        /// destination is matched.</param>
        /// <param name="destinationPortMatched">Value indicating whether
        /// destination port is matched.</param>
        public NetworkSecurityRulesEvaluationResult(string name = default(string), bool? protocolMatched = default(bool?), bool? sourceMatched = default(bool?), bool? sourcePortMatched = default(bool?), bool? destinationMatched = default(bool?), bool? destinationPortMatched = default(bool?))
        {
            Name = name;
            ProtocolMatched = protocolMatched;
            SourceMatched = sourceMatched;
            SourcePortMatched = sourcePortMatched;
            DestinationMatched = destinationMatched;
            DestinationPortMatched = destinationPortMatched;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the network security rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether protocol is matched.
        /// </summary>
        [JsonProperty(PropertyName = "protocolMatched")]
        public bool? ProtocolMatched { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether source is matched.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMatched")]
        public bool? SourceMatched { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether source port is matched.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePortMatched")]
        public bool? SourcePortMatched { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether destination is matched.
        /// </summary>
        [JsonProperty(PropertyName = "destinationMatched")]
        public bool? DestinationMatched { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether destination port is matched.
        /// </summary>
        [JsonProperty(PropertyName = "destinationPortMatched")]
        public bool? DestinationPortMatched { get; set; }

    }
}
