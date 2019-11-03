﻿// © 2019 Mobsites. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Mobsites.AspNetCore.Identity.Cosmos
{
    /// <summary>
    ///     Represents a claim that is granted to all users within a role.
    /// </summary>
    public class IdentityRoleClaim : Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>, ICosmosIdentity
    {
        public IdentityRoleClaim()
        {
            Id = Guid.NewGuid().ToString();
        }

        private string id;

        /// <summary>
        ///     Cosmos requires a string property named "id" as a primary key. 
        ///     The base class "Id" property is of type int, and so must be hidden with the new keyword.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public new string Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        /// <summary>
        ///     Override this to provide a value for the partition key parameter in the Cosmos container method calls.
        ///     NOTE: The derived class must also include a property that matches the partition key path that was used when creating the container.
        /// </summary>
        public virtual string PartitionKey => nameof(IdentityRoleClaim);
    }
}
