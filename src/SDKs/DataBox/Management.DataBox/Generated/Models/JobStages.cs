// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job stages.
    /// </summary>
    public partial class JobStages
    {
        /// <summary>
        /// Initializes a new instance of the JobStages class.
        /// </summary>
        public JobStages()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStages class.
        /// </summary>
        /// <param name="stageName">Name of the job stage. Possible values
        /// include: 'DeviceOrdered', 'DevicePrepared', 'Dispatched',
        /// 'Delivered', 'PickedUp', 'AtAzureDC', 'DataCopy', 'Completed',
        /// 'CompletedWithErrors', 'Cancelled',
        /// 'Failed_IssueReportedAtCustomer', 'Failed_IssueDetectedAtAzureDC',
        /// 'Aborted'</param>
        /// <param name="displayName">Display name of the job stage.</param>
        /// <param name="stageStatus">Status of the job stage. Possible values
        /// include: 'None', 'InProgress', 'Succeeded', 'Failed', 'Cancelled',
        /// 'Cancelling', 'SucceededWithErrors'</param>
        /// <param name="stageTime">Time for the job stage in UTC ISO 8601
        /// format.</param>
        /// <param name="jobStageDetails">Job Stage Details</param>
        /// <param name="errorDetails">Error details for the stage.</param>
        public JobStages(StageName? stageName = default(StageName?), string displayName = default(string), StageStatus? stageStatus = default(StageStatus?), System.DateTime? stageTime = default(System.DateTime?), object jobStageDetails = default(object), IList<JobErrorDetails> errorDetails = default(IList<JobErrorDetails>))
        {
            StageName = stageName;
            DisplayName = displayName;
            StageStatus = stageStatus;
            StageTime = stageTime;
            JobStageDetails = jobStageDetails;
            ErrorDetails = errorDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the job stage. Possible values include:
        /// 'DeviceOrdered', 'DevicePrepared', 'Dispatched', 'Delivered',
        /// 'PickedUp', 'AtAzureDC', 'DataCopy', 'Completed',
        /// 'CompletedWithErrors', 'Cancelled',
        /// 'Failed_IssueReportedAtCustomer', 'Failed_IssueDetectedAtAzureDC',
        /// 'Aborted'
        /// </summary>
        [JsonProperty(PropertyName = "stageName")]
        public StageName? StageName { get; private set; }

        /// <summary>
        /// Gets display name of the job stage.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets status of the job stage. Possible values include: 'None',
        /// 'InProgress', 'Succeeded', 'Failed', 'Cancelled', 'Cancelling',
        /// 'SucceededWithErrors'
        /// </summary>
        [JsonProperty(PropertyName = "stageStatus")]
        public StageStatus? StageStatus { get; private set; }

        /// <summary>
        /// Gets time for the job stage in UTC ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "stageTime")]
        public System.DateTime? StageTime { get; private set; }

        /// <summary>
        /// Gets job Stage Details
        /// </summary>
        [JsonProperty(PropertyName = "jobStageDetails")]
        public object JobStageDetails { get; private set; }

        /// <summary>
        /// Gets error details for the stage.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<JobErrorDetails> ErrorDetails { get; private set; }

    }
}
