// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public partial class ManagedServiceIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ManagedServiceIdentity class.
        /// </summary>
        public ManagedServiceIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedServiceIdentity class.
        /// </summary>
        /// <param name="principalId">The principal id of the system assigned
        /// identity. This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="tenantId">The tenant id of the system assigned
        /// identity. This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="type">The type of identity used for the resource. The
        /// type 'SystemAssigned, UserAssigned' includes both an implicitly
        /// created identity and a set of user assigned identities. The type
        /// 'None' will remove any identities from the service. Possible values
        /// include: 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned', 'None'</param>
        public ManagedServiceIdentity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of the system assigned identity. This
        /// property will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id of the system assigned identity. This property
        /// will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the type of identity used for the resource. The type
        /// 'SystemAssigned, UserAssigned' includes both an implicitly created
        /// identity and a set of user assigned identities. The type 'None'
        /// will remove any identities from the service. Possible values
        /// include: 'SystemAssigned', 'UserAssigned', 'SystemAssigned,
        /// UserAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType? Type { get; set; }

    }
}