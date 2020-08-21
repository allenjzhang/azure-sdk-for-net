// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceVcoresCapability
    {
        internal static ManagedInstanceVcoresCapability DeserializeManagedInstanceVcoresCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<int> value = default;
            Optional<MaxSizeCapability> includedMaxSize = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedStorageSizes = default;
            Optional<bool> instancePoolSupported = default;
            Optional<bool> standaloneSupported = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedMaxSize"))
                {
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedStorageSizes"))
                {
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedStorageSizes = array;
                    continue;
                }
                if (property.NameEquals("instancePoolSupported"))
                {
                    instancePoolSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("standaloneSupported"))
                {
                    standaloneSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedInstanceVcoresCapability(name.Value, Optional.ToNullable(value), includedMaxSize.Value, Optional.ToList(supportedStorageSizes), Optional.ToNullable(instancePoolSupported), Optional.ToNullable(standaloneSupported), Optional.ToNullable(status), reason.Value);
        }
    }
}