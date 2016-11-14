/* 
 * AvaTax API
 *
 * REST interface to Avalara's enterprise tax service, AvaTax.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Avalara.AvaTax.RestClient.Model
{
    /// <summary>
    /// Represents a batch of uploaded documents.
    /// </summary>
    [DataContract]
    public partial class BatchModel :  IEquatable<BatchModel>
    {
        /// <summary>
        /// The type of this batch.
        /// </summary>
        /// <value>The type of this batch.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum AvaCertUpdate for "AvaCertUpdate"
            /// </summary>
            [EnumMember(Value = "AvaCertUpdate")]
            AvaCertUpdate,
            
            /// <summary>
            /// Enum AvaCertUpdateAll for "AvaCertUpdateAll"
            /// </summary>
            [EnumMember(Value = "AvaCertUpdateAll")]
            AvaCertUpdateAll,
            
            /// <summary>
            /// Enum BatchMaintenance for "BatchMaintenance"
            /// </summary>
            [EnumMember(Value = "BatchMaintenance")]
            BatchMaintenance,
            
            /// <summary>
            /// Enum CompanyLocationImport for "CompanyLocationImport"
            /// </summary>
            [EnumMember(Value = "CompanyLocationImport")]
            CompanyLocationImport,
            
            /// <summary>
            /// Enum DocumentImport for "DocumentImport"
            /// </summary>
            [EnumMember(Value = "DocumentImport")]
            DocumentImport,
            
            /// <summary>
            /// Enum ExemptCertImport for "ExemptCertImport"
            /// </summary>
            [EnumMember(Value = "ExemptCertImport")]
            ExemptCertImport,
            
            /// <summary>
            /// Enum ItemImport for "ItemImport"
            /// </summary>
            [EnumMember(Value = "ItemImport")]
            ItemImport,
            
            /// <summary>
            /// Enum SalesAuditExport for "SalesAuditExport"
            /// </summary>
            [EnumMember(Value = "SalesAuditExport")]
            SalesAuditExport,
            
            /// <summary>
            /// Enum SstpTestDeckImport for "SstpTestDeckImport"
            /// </summary>
            [EnumMember(Value = "SstpTestDeckImport")]
            SstpTestDeckImport,
            
            /// <summary>
            /// Enum TaxRuleImport for "TaxRuleImport"
            /// </summary>
            [EnumMember(Value = "TaxRuleImport")]
            TaxRuleImport,
            
            /// <summary>
            /// Enum TransactionImport for "TransactionImport"
            /// </summary>
            [EnumMember(Value = "TransactionImport")]
            TransactionImport,
            
            /// <summary>
            /// Enum UPCBulkImport for "UPCBulkImport"
            /// </summary>
            [EnumMember(Value = "UPCBulkImport")]
            UPCBulkImport,
            
            /// <summary>
            /// Enum UPCValidationImport for "UPCValidationImport"
            /// </summary>
            [EnumMember(Value = "UPCValidationImport")]
            UPCValidationImport
        }

        /// <summary>
        /// This batch's current processing status
        /// </summary>
        /// <value>This batch's current processing status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Waiting for "Waiting"
            /// </summary>
            [EnumMember(Value = "Waiting")]
            Waiting,
            
            /// <summary>
            /// Enum SystemErrors for "SystemErrors"
            /// </summary>
            [EnumMember(Value = "SystemErrors")]
            SystemErrors,
            
            /// <summary>
            /// Enum Cancelled for "Cancelled"
            /// </summary>
            [EnumMember(Value = "Cancelled")]
            Cancelled,
            
            /// <summary>
            /// Enum Completed for "Completed"
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed,
            
            /// <summary>
            /// Enum Creating for "Creating"
            /// </summary>
            [EnumMember(Value = "Creating")]
            Creating,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted,
            
            /// <summary>
            /// Enum Errors for "Errors"
            /// </summary>
            [EnumMember(Value = "Errors")]
            Errors,
            
            /// <summary>
            /// Enum Paused for "Paused"
            /// </summary>
            [EnumMember(Value = "Paused")]
            Paused,
            
            /// <summary>
            /// Enum Processing for "Processing"
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing
        }

        /// <summary>
        /// The type of this batch.
        /// </summary>
        /// <value>The type of this batch.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// This batch's current processing status
        /// </summary>
        /// <value>This batch's current processing status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchModel" /> class.
        /// </summary>
        /// <param name="Name">The user-friendly readable name for this batch. (required).</param>
        /// <param name="Type">The type of this batch. (required).</param>
        /// <param name="Status">This batch&#39;s current processing status.</param>
        /// <param name="Options">Any optional flags provided for this batch.</param>
        /// <param name="BatchAgent">The agent used to create this batch.</param>
        /// <param name="Files">The list of files contained in this batch..</param>
        public BatchModel(string Name = null, TypeEnum? Type = null, StatusEnum? Status = null, string Options = null, string BatchAgent = null, List<BatchFileModel> Files = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BatchModel and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for BatchModel and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Status = Status;
            this.Options = Options;
            this.BatchAgent = BatchAgent;
            this.Files = Files;
        }
        
        /// <summary>
        /// The unique ID number of this batch.
        /// </summary>
        /// <value>The unique ID number of this batch.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The user-friendly readable name for this batch.
        /// </summary>
        /// <value>The user-friendly readable name for this batch.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The Account ID number of the account that owns this batch.
        /// </summary>
        /// <value>The Account ID number of the account that owns this batch.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; private set; }
        /// <summary>
        /// The Company ID number of the company that owns this batch.
        /// </summary>
        /// <value>The Company ID number of the company that owns this batch.</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public int? CompanyId { get; private set; }
        /// <summary>
        /// Any optional flags provided for this batch
        /// </summary>
        /// <value>Any optional flags provided for this batch</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public string Options { get; set; }
        /// <summary>
        /// The agent used to create this batch
        /// </summary>
        /// <value>The agent used to create this batch</value>
        [DataMember(Name="batchAgent", EmitDefaultValue=false)]
        public string BatchAgent { get; set; }
        /// <summary>
        /// The date/time when this batch started processing
        /// </summary>
        /// <value>The date/time when this batch started processing</value>
        [DataMember(Name="startedDate", EmitDefaultValue=false)]
        public DateTime? StartedDate { get; private set; }
        /// <summary>
        /// The number of records in this batch; determined by the server
        /// </summary>
        /// <value>The number of records in this batch; determined by the server</value>
        [DataMember(Name="recordCount", EmitDefaultValue=false)]
        public int? RecordCount { get; private set; }
        /// <summary>
        /// The current record being processed
        /// </summary>
        /// <value>The current record being processed</value>
        [DataMember(Name="currentRecord", EmitDefaultValue=false)]
        public int? CurrentRecord { get; private set; }
        /// <summary>
        /// The date/time when this batch was completely processed
        /// </summary>
        /// <value>The date/time when this batch was completely processed</value>
        [DataMember(Name="completedDate", EmitDefaultValue=false)]
        public DateTime? CompletedDate { get; private set; }
        /// <summary>
        /// The date when this record was created.
        /// </summary>
        /// <value>The date when this record was created.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; private set; }
        /// <summary>
        /// The User ID of the user who created this record.
        /// </summary>
        /// <value>The User ID of the user who created this record.</value>
        [DataMember(Name="createdUserId", EmitDefaultValue=false)]
        public int? CreatedUserId { get; private set; }
        /// <summary>
        /// The date/time when this record was last modified.
        /// </summary>
        /// <value>The date/time when this record was last modified.</value>
        [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
        public DateTime? ModifiedDate { get; private set; }
        /// <summary>
        /// The user ID of the user who last modified this record.
        /// </summary>
        /// <value>The user ID of the user who last modified this record.</value>
        [DataMember(Name="modifiedUserId", EmitDefaultValue=false)]
        public int? ModifiedUserId { get; private set; }
        /// <summary>
        /// The list of files contained in this batch.
        /// </summary>
        /// <value>The list of files contained in this batch.</value>
        [DataMember(Name="files", EmitDefaultValue=false)]
        public List<BatchFileModel> Files { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  BatchAgent: ").Append(BatchAgent).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedUserId: ").Append(ModifiedUserId).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BatchModel);
        }

        /// <summary>
        /// Returns true if BatchModel instances are equal
        /// </summary>
        /// <param name="other">Instance of BatchModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.BatchAgent == other.BatchAgent ||
                    this.BatchAgent != null &&
                    this.BatchAgent.Equals(other.BatchAgent)
                ) && 
                (
                    this.StartedDate == other.StartedDate ||
                    this.StartedDate != null &&
                    this.StartedDate.Equals(other.StartedDate)
                ) && 
                (
                    this.RecordCount == other.RecordCount ||
                    this.RecordCount != null &&
                    this.RecordCount.Equals(other.RecordCount)
                ) && 
                (
                    this.CurrentRecord == other.CurrentRecord ||
                    this.CurrentRecord != null &&
                    this.CurrentRecord.Equals(other.CurrentRecord)
                ) && 
                (
                    this.CompletedDate == other.CompletedDate ||
                    this.CompletedDate != null &&
                    this.CompletedDate.Equals(other.CompletedDate)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.CreatedUserId == other.CreatedUserId ||
                    this.CreatedUserId != null &&
                    this.CreatedUserId.Equals(other.CreatedUserId)
                ) && 
                (
                    this.ModifiedDate == other.ModifiedDate ||
                    this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(other.ModifiedDate)
                ) && 
                (
                    this.ModifiedUserId == other.ModifiedUserId ||
                    this.ModifiedUserId != null &&
                    this.ModifiedUserId.Equals(other.ModifiedUserId)
                ) && 
                (
                    this.Files == other.Files ||
                    this.Files != null &&
                    this.Files.SequenceEqual(other.Files)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.BatchAgent != null)
                    hash = hash * 59 + this.BatchAgent.GetHashCode();
                if (this.StartedDate != null)
                    hash = hash * 59 + this.StartedDate.GetHashCode();
                if (this.RecordCount != null)
                    hash = hash * 59 + this.RecordCount.GetHashCode();
                if (this.CurrentRecord != null)
                    hash = hash * 59 + this.CurrentRecord.GetHashCode();
                if (this.CompletedDate != null)
                    hash = hash * 59 + this.CompletedDate.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatedUserId != null)
                    hash = hash * 59 + this.CreatedUserId.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.ModifiedUserId != null)
                    hash = hash * 59 + this.ModifiedUserId.GetHashCode();
                if (this.Files != null)
                    hash = hash * 59 + this.Files.GetHashCode();
                return hash;
            }
        }
    }

}
