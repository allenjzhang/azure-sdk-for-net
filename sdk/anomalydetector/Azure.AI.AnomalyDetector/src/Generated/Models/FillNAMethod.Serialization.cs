// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.AnomalyDetector.Models
{
    internal static partial class FillNAMethodExtensions
    {
        public static string ToSerialString(this FillNAMethod value) => value switch
        {
            FillNAMethod.Previous => "Previous",
            FillNAMethod.Subsequent => "Subsequent",
            FillNAMethod.Linear => "Linear",
            FillNAMethod.Zero => "Zero",
            FillNAMethod.Pad => "Pad",
            FillNAMethod.NotFill => "NotFill",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FillNAMethod value.")
        };

        public static FillNAMethod ToFillNAMethod(this string value)
        {
            if (string.Equals(value, "Previous", StringComparison.InvariantCultureIgnoreCase)) return FillNAMethod.Previous;
            if (string.Equals(value, "Subsequent", StringComparison.InvariantCultureIgnoreCase)) return FillNAMethod.Subsequent;
            if (string.Equals(value, "Linear", StringComparison.InvariantCultureIgnoreCase)) return FillNAMethod.Linear;
            if (string.Equals(value, "Zero", StringComparison.InvariantCultureIgnoreCase)) return FillNAMethod.Zero;
            if (string.Equals(value, "Pad", StringComparison.InvariantCultureIgnoreCase)) return FillNAMethod.Pad;
            if (string.Equals(value, "NotFill", StringComparison.InvariantCultureIgnoreCase)) return FillNAMethod.NotFill;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FillNAMethod value.");
        }
    }
}
