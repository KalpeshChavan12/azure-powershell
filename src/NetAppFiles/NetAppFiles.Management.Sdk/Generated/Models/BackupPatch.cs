// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Backup patch
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupPatch
    {
        /// <summary>
        /// Initializes a new instance of the BackupPatch class.
        /// </summary>
        public BackupPatch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupPatch class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="backupId">backupId</param>
        /// <param name="creationDate">creationDate</param>
        /// <param name="provisioningState">Azure lifecycle management</param>
        /// <param name="size">Size of backup</param>
        /// <param name="label">Label for backup</param>
        /// <param name="backupType">backupType</param>
        /// <param name="failureReason">Failure reason</param>
        /// <param name="volumeName">Volume name</param>
        /// <param name="useExistingSnapshot">Manual backup an already existing
        /// snapshot. This will always be false for scheduled backups and
        /// true/false for manual backups</param>
        public BackupPatch(IDictionary<string, string> tags = default(IDictionary<string, string>), string backupId = default(string), System.DateTime? creationDate = default(System.DateTime?), string provisioningState = default(string), long? size = default(long?), string label = default(string), string backupType = default(string), string failureReason = default(string), string volumeName = default(string), bool? useExistingSnapshot = default(bool?))
        {
            Tags = tags;
            BackupId = backupId;
            CreationDate = creationDate;
            ProvisioningState = provisioningState;
            Size = size;
            Label = label;
            BackupType = backupType;
            FailureReason = failureReason;
            VolumeName = volumeName;
            UseExistingSnapshot = useExistingSnapshot;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets backupId
        /// </summary>
        /// <remarks>
        /// UUID v4 used to identify the Backup
        /// </remarks>
        [JsonProperty(PropertyName = "properties.backupId")]
        public string BackupId { get; private set; }

        /// <summary>
        /// Gets creationDate
        /// </summary>
        /// <remarks>
        /// The creation date of the backup
        /// </remarks>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets size of backup
        /// </summary>
        [JsonProperty(PropertyName = "properties.size")]
        public long? Size { get; private set; }

        /// <summary>
        /// Gets or sets label for backup
        /// </summary>
        [JsonProperty(PropertyName = "properties.label")]
        public string Label { get; set; }

        /// <summary>
        /// Gets backupType
        /// </summary>
        /// <remarks>
        /// Type of backup Manual or Scheduled. Possible values include:
        /// 'Manual', 'Scheduled'
        /// </remarks>
        [JsonProperty(PropertyName = "properties.backupType")]
        public string BackupType { get; private set; }

        /// <summary>
        /// Gets failure reason
        /// </summary>
        [JsonProperty(PropertyName = "properties.failureReason")]
        public string FailureReason { get; private set; }

        /// <summary>
        /// Gets volume name
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeName")]
        public string VolumeName { get; private set; }

        /// <summary>
        /// Gets or sets manual backup an already existing snapshot. This will
        /// always be false for scheduled backups and true/false for manual
        /// backups
        /// </summary>
        [JsonProperty(PropertyName = "properties.useExistingSnapshot")]
        public bool? UseExistingSnapshot { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BackupId != null)
            {
                if (BackupId.Length > 36)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "BackupId", 36);
                }
                if (BackupId.Length < 36)
                {
                    throw new ValidationException(ValidationRules.MinLength, "BackupId", 36);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(BackupId, "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "BackupId", "^[a-fA-F0-9]{8}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{4}-[a-fA-F0-9]{12}$");
                }
            }
        }
    }
}
