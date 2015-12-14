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
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition for IaasVMRestoreRequest class.
    /// </summary>
    public partial class IaasVMRestoreRequest : RestoreRequest
    {
        private System.DateTime? _affinityGroup;
        
        /// <summary>
        /// Optional. AffinityGroup of IaasVMRestoreRequest
        /// </summary>
        public System.DateTime? AffinityGroup
        {
            get { return this._affinityGroup; }
            set { this._affinityGroup = value; }
        }
        
        private bool _cloudServiceOrResourceGroup;
        
        /// <summary>
        /// Optional. CloudServiceOrResourceGroup of IaasVMRestoreRequest
        /// </summary>
        public bool CloudServiceOrResourceGroup
        {
            get { return this._cloudServiceOrResourceGroup; }
            set { this._cloudServiceOrResourceGroup = value; }
        }
        
        private string _createNewCloudService;
        
        /// <summary>
        /// Optional. CreateNewCloudService of IaasVMRestoreRequest
        /// </summary>
        public string CreateNewCloudService
        {
            get { return this._createNewCloudService; }
            set { this._createNewCloudService = value; }
        }
        
        private string _recoveryPointId;
        
        /// <summary>
        /// Optional. RecoveryPointId for IaasVMRestoreRequest
        /// </summary>
        public string RecoveryPointId
        {
            get { return this._recoveryPointId; }
            set { this._recoveryPointId = value; }
        }
        
        private string _recoveryType;
        
        /// <summary>
        /// Optional. RecoveryType for IaasVMRestoreRequest
        /// </summary>
        public string RecoveryType
        {
            get { return this._recoveryType; }
            set { this._recoveryType = value; }
        }
        
        private System.DateTime? _region;
        
        /// <summary>
        /// Optional. Region of IaasVMRestoreRequest
        /// </summary>
        public System.DateTime? Region
        {
            get { return this._region; }
            set { this._region = value; }
        }
        
        private string _storageAccountName;
        
        /// <summary>
        /// Optional. StorageAccountName for IaasVMRestoreRequest
        /// </summary>
        public string StorageAccountName
        {
            get { return this._storageAccountName; }
            set { this._storageAccountName = value; }
        }
        
        private string _subnetName;
        
        /// <summary>
        /// Optional. SubnetName of IaasVMRestoreRequest
        /// </summary>
        public string SubnetName
        {
            get { return this._subnetName; }
            set { this._subnetName = value; }
        }
        
        private string _virtualMachineName;
        
        /// <summary>
        /// Optional. VirtualMachineName of IaasVMRestoreRequest
        /// </summary>
        public string VirtualMachineName
        {
            get { return this._virtualMachineName; }
            set { this._virtualMachineName = value; }
        }
        
        private string _virtualNetworkName;
        
        /// <summary>
        /// Optional. VirtualNetworkName of IaasVMRestoreRequest
        /// </summary>
        public string VirtualNetworkName
        {
            get { return this._virtualNetworkName; }
            set { this._virtualNetworkName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the IaasVMRestoreRequest class.
        /// </summary>
        public IaasVMRestoreRequest()
        {
        }
    }
}
