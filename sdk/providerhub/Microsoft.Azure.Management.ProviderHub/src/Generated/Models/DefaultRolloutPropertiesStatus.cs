// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class DefaultRolloutPropertiesStatus : DefaultRolloutStatus
    {
        /// <summary>
        /// Initializes a new instance of the DefaultRolloutPropertiesStatus
        /// class.
        /// </summary>
        public DefaultRolloutPropertiesStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefaultRolloutPropertiesStatus
        /// class.
        /// </summary>
        /// <param name="nextTrafficRegion">Possible values include:
        /// 'NotSpecified', 'Canary', 'LowTraffic', 'MediumTraffic',
        /// 'HighTraffic', 'None', 'RestOfTheWorldGroupOne',
        /// 'RestOfTheWorldGroupTwo'</param>
        /// <param name="subscriptionReregistrationResult">Possible values
        /// include: 'NotApplicable', 'ConditionalUpdate', 'ForcedUpdate',
        /// 'Failed'</param>
        public DefaultRolloutPropertiesStatus(IList<string> completedRegions = default(IList<string>), IDictionary<string, ExtendedErrorInfo> failedOrSkippedRegions = default(IDictionary<string, ExtendedErrorInfo>), string nextTrafficRegion = default(string), System.DateTime? nextTrafficRegionScheduledTime = default(System.DateTime?), string subscriptionReregistrationResult = default(string))
            : base(completedRegions, failedOrSkippedRegions, nextTrafficRegion, nextTrafficRegionScheduledTime, subscriptionReregistrationResult)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
