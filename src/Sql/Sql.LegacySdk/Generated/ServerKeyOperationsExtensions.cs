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
using Microsoft.Azure.Management.Sql.LegacySdk;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class ServerKeyOperationsExtensions
    {
        /// <summary>
        /// Begins creating a new Azure SQL Server Key or updating an existing
        /// Azure SQL Server Key. To determine the status of the operation
        /// call GetCreateOrUpdateOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which to add the
        /// Server Key.
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a
        /// Server Key.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        public static ServerKeyCreateOrUpdateResponse BeginCreateOrUpdate(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName, ServerKeyCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, serverName, keyName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begins creating a new Azure SQL Server Key or updating an existing
        /// Azure SQL Server Key. To determine the status of the operation
        /// call GetCreateOrUpdateOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which to add the
        /// Server Key.
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a
        /// Server Key.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        public static Task<ServerKeyCreateOrUpdateResponse> BeginCreateOrUpdateAsync(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName, ServerKeyCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, keyName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Begins deleting an existing Azure SQL Server Key.To determine the
        /// status of the operation call GetDeleteOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which the Azure SQL
        /// Server Key belongs
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        public static ServerKeyDeleteResponse BeginDelete(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).BeginDeleteAsync(resourceGroupName, serverName, keyName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Begins deleting an existing Azure SQL Server Key.To determine the
        /// status of the operation call GetDeleteOperationStatus.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which the Azure SQL
        /// Server Key belongs
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        public static Task<ServerKeyDeleteResponse> BeginDeleteAsync(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName)
        {
            return operations.BeginDeleteAsync(resourceGroupName, serverName, keyName, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new Azure SQL Server Key or updates an existing Azure SQL
        /// Server Key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which to add the
        /// Server Key.
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a
        /// Server Key.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        public static ServerKeyCreateOrUpdateResponse CreateOrUpdate(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName, ServerKeyCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).CreateOrUpdateAsync(resourceGroupName, serverName, keyName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new Azure SQL Server Key or updates an existing Azure SQL
        /// Server Key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which to add the
        /// Server Key.
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for createing or updating a
        /// Server Key.
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        public static Task<ServerKeyCreateOrUpdateResponse> CreateOrUpdateAsync(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName, ServerKeyCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, serverName, keyName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes an existing Azure SQL Server Key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which the Azure SQL
        /// Server Key belongs
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key to be deleted.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        public static ServerKeyDeleteResponse Delete(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).DeleteAsync(resourceGroupName, serverName, keyName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes an existing Azure SQL Server Key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Server to which the Azure SQL
        /// Server Key belongs
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure SQL Server Key to be deleted.
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        public static Task<ServerKeyDeleteResponse> DeleteAsync(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName)
        {
            return operations.DeleteAsync(resourceGroupName, serverName, keyName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets an Azure Sql Server Key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that has the
        /// key.
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure Key Vault Key to be retrieved from
        /// the Azure SQL Database Server.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server Key request.
        /// </returns>
        public static ServerKeyGetResponse Get(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).GetAsync(resourceGroupName, serverName, keyName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets an Azure Sql Server Key.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server that has the
        /// key.
        /// </param>
        /// <param name='keyName'>
        /// Required. The name of the Azure Key Vault Key to be retrieved from
        /// the Azure SQL Database Server.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server Key request.
        /// </returns>
        public static Task<ServerKeyGetResponse> GetAsync(this IServerKeyOperations operations, string resourceGroupName, string serverName, string keyName)
        {
            return operations.GetAsync(resourceGroupName, serverName, keyName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure SQL Server Key create or update
        /// operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        public static ServerKeyCreateOrUpdateResponse GetCreateOrUpdateOperationStatus(this IServerKeyOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).GetCreateOrUpdateOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure SQL Server Key create or update
        /// operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Represents the response to a Azure Sql Server Key operation request.
        /// </returns>
        public static Task<ServerKeyCreateOrUpdateResponse> GetCreateOrUpdateOperationStatusAsync(this IServerKeyOperations operations, string operationStatusLink)
        {
            return operations.GetCreateOrUpdateOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the status of an Azure SQL Server Key delete operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        public static ServerKeyDeleteResponse GetDeleteOperationStatus(this IServerKeyOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).GetDeleteOperationStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the status of an Azure SQL Server Key delete operation.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the Begin operation
        /// </param>
        /// <returns>
        /// Represents the response to an Azure Sql Server Key Delete request.
        /// </returns>
        public static Task<ServerKeyDeleteResponse> GetDeleteOperationStatusAsync(this IServerKeyOperations operations, string operationStatusLink)
        {
            return operations.GetDeleteOperationStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets all Azure SQL Database Server Keys for a server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server Key request.
        /// </returns>
        public static ServerKeyListResponse List(this IServerKeyOperations operations, string resourceGroupName, string serverName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServerKeyOperations)s).ListAsync(resourceGroupName, serverName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets all Azure SQL Database Server Keys for a server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.LegacySdk.IServerKeyOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server Key request.
        /// </returns>
        public static Task<ServerKeyListResponse> ListAsync(this IServerKeyOperations operations, string resourceGroupName, string serverName)
        {
            return operations.ListAsync(resourceGroupName, serverName, CancellationToken.None);
        }
    }
}