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
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class ScheduleOperationsExtensions
    {
        /// <summary>
        /// Create a schedule.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update schedule
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update schedule operation.
        /// </returns>
        public static ScheduleCreateOrUpdateResponse CreateOrUpdate(this IScheduleOperations operations, string resourceGroupName, string automationAccount, ScheduleCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScheduleOperations)s).CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a schedule.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create or update schedule
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create or update schedule operation.
        /// </returns>
        public static Task<ScheduleCreateOrUpdateResponse> CreateOrUpdateAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccount, ScheduleCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='scheduleName'>
        /// Required. The schedule name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IScheduleOperations operations, string resourceGroupName, string automationAccount, string scheduleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScheduleOperations)s).DeleteAsync(resourceGroupName, automationAccount, scheduleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='scheduleName'>
        /// Required. The schedule name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccount, string scheduleName)
        {
            return operations.DeleteAsync(resourceGroupName, automationAccount, scheduleName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='scheduleName'>
        /// Required. The schedule name.
        /// </param>
        /// <returns>
        /// The response model for the get schedule operation.
        /// </returns>
        public static ScheduleGetResponse Get(this IScheduleOperations operations, string resourceGroupName, string automationAccount, string scheduleName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScheduleOperations)s).GetAsync(resourceGroupName, automationAccount, scheduleName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='scheduleName'>
        /// Required. The schedule name.
        /// </param>
        /// <returns>
        /// The response model for the get schedule operation.
        /// </returns>
        public static Task<ScheduleGetResponse> GetAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccount, string scheduleName)
        {
            return operations.GetAsync(resourceGroupName, automationAccount, scheduleName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list schedule operation.
        /// </returns>
        public static ScheduleListResponse List(this IScheduleOperations operations, string resourceGroupName, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScheduleOperations)s).ListAsync(resourceGroupName, automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list schedule operation.
        /// </returns>
        public static Task<ScheduleListResponse> ListAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccount)
        {
            return operations.ListAsync(resourceGroupName, automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list schedule operation.
        /// </returns>
        public static ScheduleListResponse ListNext(this IScheduleOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScheduleOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list schedule operation.
        /// </returns>
        public static Task<ScheduleListResponse> ListNextAsync(this IScheduleOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the patch schedule operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Patch(this IScheduleOperations operations, string resourceGroupName, string automationAccount, SchedulePatchParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScheduleOperations)s).PatchAsync(resourceGroupName, automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update the schedule identified by schedule name.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.IScheduleOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the resource group
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the patch schedule operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> PatchAsync(this IScheduleOperations operations, string resourceGroupName, string automationAccount, SchedulePatchParameters parameters)
        {
            return operations.PatchAsync(resourceGroupName, automationAccount, parameters, CancellationToken.None);
        }
    }
}
