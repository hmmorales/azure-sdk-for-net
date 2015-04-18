// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    /// <summary>
    /// Service operation for automation job schedules.  (see
    /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
    /// information)
    /// </summary>
    public partial interface IJobScheduleOperations
    {
        /// <summary>
        /// Create a job schedule.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters supplied to the create job schedule operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the create job schedule operation.
        /// </returns>
        Task<JobScheduleCreateResponse> CreateAsync(string resourceGroupName, string automationAccount, JobScheduleCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete the job schedule identified by job schedule name.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='jobScheduleName'>
        /// The job schedule name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string automationAccount, Guid jobScheduleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve the job schedule identified by job schedule name.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='jobScheduleName'>
        /// The job schedule name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the get job schedule operation.
        /// </returns>
        Task<JobScheduleGetResponse> GetAsync(string resourceGroupName, string automationAccount, Guid jobScheduleName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve a list of job schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// The automation account name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list job schedule operation.
        /// </returns>
        Task<JobScheduleListResponse> ListAsync(string resourceGroupName, string automationAccount, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieve next list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='nextLink'>
        /// The link to retrieve next set of items.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response model for the list job schedule operation.
        /// </returns>
        Task<JobScheduleListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
