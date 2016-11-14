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
    /// Represents a declaration of nexus within a particular taxing jurisdiction.
    /// </summary>
    [DataContract]
    public partial class NexusModel :  IEquatable<NexusModel>
    {
        /// <summary>
        /// The jurisdiction type of the jurisdiction in which this company declared nexus.
        /// </summary>
        /// <value>The jurisdiction type of the jurisdiction in which this company declared nexus.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JurisTypeIdEnum
        {
            
            /// <summary>
            /// Enum STA for "STA"
            /// </summary>
            [EnumMember(Value = "STA")]
            STA,
            
            /// <summary>
            /// Enum CTY for "CTY"
            /// </summary>
            [EnumMember(Value = "CTY")]
            CTY,
            
            /// <summary>
            /// Enum CIT for "CIT"
            /// </summary>
            [EnumMember(Value = "CIT")]
            CIT,
            
            /// <summary>
            /// Enum STJ for "STJ"
            /// </summary>
            [EnumMember(Value = "STJ")]
            STJ,
            
            /// <summary>
            /// Enum CNT for "CNT"
            /// </summary>
            [EnumMember(Value = "CNT")]
            CNT
        }

        /// <summary>
        /// The type of nexus that this company is declaring.
        /// </summary>
        /// <value>The type of nexus that this company is declaring.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NexusTypeIdEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum SalesOrSellersUseTax for "SalesOrSellersUseTax"
            /// </summary>
            [EnumMember(Value = "SalesOrSellersUseTax")]
            SalesOrSellersUseTax,
            
            /// <summary>
            /// Enum SalesTax for "SalesTax"
            /// </summary>
            [EnumMember(Value = "SalesTax")]
            SalesTax,
            
            /// <summary>
            /// Enum SSTVolunteer for "SSTVolunteer"
            /// </summary>
            [EnumMember(Value = "SSTVolunteer")]
            SSTVolunteer,
            
            /// <summary>
            /// Enum SSTNonVolunteer for "SSTNonVolunteer"
            /// </summary>
            [EnumMember(Value = "SSTNonVolunteer")]
            SSTNonVolunteer
        }

        /// <summary>
        /// Indicates whether this nexus is defined as origin or destination nexus.
        /// </summary>
        /// <value>Indicates whether this nexus is defined as origin or destination nexus.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourcingEnum
        {
            
            /// <summary>
            /// Enum Destination for "Destination"
            /// </summary>
            [EnumMember(Value = "Destination")]
            Destination,
            
            /// <summary>
            /// Enum Origin for "Origin"
            /// </summary>
            [EnumMember(Value = "Origin")]
            Origin
        }

        /// <summary>
        /// If you are declaring local nexus within this jurisdiction, this indicates whether you are declaring only               a specified list of local jurisdictions, all state-administered local jurisdictions, or all local jurisdictions.
        /// </summary>
        /// <value>If you are declaring local nexus within this jurisdiction, this indicates whether you are declaring only               a specified list of local jurisdictions, all state-administered local jurisdictions, or all local jurisdictions.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LocalNexusTypeIdEnum
        {
            
            /// <summary>
            /// Enum Selected for "Selected"
            /// </summary>
            [EnumMember(Value = "Selected")]
            Selected,
            
            /// <summary>
            /// Enum StateAdministered for "StateAdministered"
            /// </summary>
            [EnumMember(Value = "StateAdministered")]
            StateAdministered,
            
            /// <summary>
            /// Enum All for "All"
            /// </summary>
            [EnumMember(Value = "All")]
            All
        }

        /// <summary>
        /// The jurisdiction type of the jurisdiction in which this company declared nexus.
        /// </summary>
        /// <value>The jurisdiction type of the jurisdiction in which this company declared nexus.</value>
        [DataMember(Name="jurisTypeId", EmitDefaultValue=false)]
        public JurisTypeIdEnum? JurisTypeId { get; set; }
        /// <summary>
        /// The type of nexus that this company is declaring.
        /// </summary>
        /// <value>The type of nexus that this company is declaring.</value>
        [DataMember(Name="nexusTypeId", EmitDefaultValue=false)]
        public NexusTypeIdEnum? NexusTypeId { get; set; }
        /// <summary>
        /// Indicates whether this nexus is defined as origin or destination nexus.
        /// </summary>
        /// <value>Indicates whether this nexus is defined as origin or destination nexus.</value>
        [DataMember(Name="sourcing", EmitDefaultValue=false)]
        public SourcingEnum? Sourcing { get; set; }
        /// <summary>
        /// If you are declaring local nexus within this jurisdiction, this indicates whether you are declaring only               a specified list of local jurisdictions, all state-administered local jurisdictions, or all local jurisdictions.
        /// </summary>
        /// <value>If you are declaring local nexus within this jurisdiction, this indicates whether you are declaring only               a specified list of local jurisdictions, all state-administered local jurisdictions, or all local jurisdictions.</value>
        [DataMember(Name="localNexusTypeId", EmitDefaultValue=false)]
        public LocalNexusTypeIdEnum? LocalNexusTypeId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NexusModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NexusModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NexusModel" /> class.
        /// </summary>
        /// <param name="JurisTypeId">The jurisdiction type of the jurisdiction in which this company declared nexus..</param>
        /// <param name="EffectiveDate">The date when this nexus began.  If not known, set to null..</param>
        /// <param name="EndDate">If this nexus will end or has ended on a specific date, set this to the date when this nexus ends..</param>
        /// <param name="NexusTypeId">The type of nexus that this company is declaring..</param>
        /// <param name="Sourcing">Indicates whether this nexus is defined as origin or destination nexus..</param>
        /// <param name="HasLocalNexus">True if you are also declaring local nexus within this jurisdiction.              Many U.S. states have options for declaring nexus in local jurisdictions as well as within the state..</param>
        /// <param name="LocalNexusTypeId">If you are declaring local nexus within this jurisdiction, this indicates whether you are declaring only               a specified list of local jurisdictions, all state-administered local jurisdictions, or all local jurisdictions..</param>
        /// <param name="HasPermanentEstablishment">Set this value to true if your company has a permanent establishment within this jurisdiction..</param>
        /// <param name="TaxId">Optional - the tax identification number under which you declared nexus..</param>
        public NexusModel(JurisTypeIdEnum? JurisTypeId = null, DateTime? EffectiveDate = null, DateTime? EndDate = null, NexusTypeIdEnum? NexusTypeId = null, SourcingEnum? Sourcing = null, bool? HasLocalNexus = null, LocalNexusTypeIdEnum? LocalNexusTypeId = null, bool? HasPermanentEstablishment = null, string TaxId = null)
        {
            this.JurisTypeId = JurisTypeId;
            this.EffectiveDate = EffectiveDate;
            this.EndDate = EndDate;
            this.NexusTypeId = NexusTypeId;
            this.Sourcing = Sourcing;
            this.HasLocalNexus = HasLocalNexus;
            this.LocalNexusTypeId = LocalNexusTypeId;
            this.HasPermanentEstablishment = HasPermanentEstablishment;
            this.TaxId = TaxId;
        }
        
        /// <summary>
        /// The unique ID number of this declaration of nexus.
        /// </summary>
        /// <value>The unique ID number of this declaration of nexus.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }
        /// <summary>
        /// The unique ID number of the company that declared nexus.
        /// </summary>
        /// <value>The unique ID number of the company that declared nexus.</value>
        [DataMember(Name="companyId", EmitDefaultValue=false)]
        public int? CompanyId { get; private set; }
        /// <summary>
        /// The two character ISO-3166 country code of the country in which this company declared nexus.
        /// </summary>
        /// <value>The two character ISO-3166 country code of the country in which this company declared nexus.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; private set; }
        /// <summary>
        /// The two or three character ISO region code of the region, state, or province in which this company declared nexus.
        /// </summary>
        /// <value>The two or three character ISO region code of the region, state, or province in which this company declared nexus.</value>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; private set; }
        /// <summary>
        /// The code identifying the jurisdiction in which this company declared nexus.
        /// </summary>
        /// <value>The code identifying the jurisdiction in which this company declared nexus.</value>
        [DataMember(Name="jurisCode", EmitDefaultValue=false)]
        public string JurisCode { get; private set; }
        /// <summary>
        /// The common name of the jurisdiction in which this company declared nexus.
        /// </summary>
        /// <value>The common name of the jurisdiction in which this company declared nexus.</value>
        [DataMember(Name="jurisName", EmitDefaultValue=false)]
        public string JurisName { get; private set; }
        /// <summary>
        /// The date when this nexus began.  If not known, set to null.
        /// </summary>
        /// <value>The date when this nexus began.  If not known, set to null.</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }
        /// <summary>
        /// If this nexus will end or has ended on a specific date, set this to the date when this nexus ends.
        /// </summary>
        /// <value>If this nexus will end or has ended on a specific date, set this to the date when this nexus ends.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The short name of the jurisdiction.
        /// </summary>
        /// <value>The short name of the jurisdiction.</value>
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; private set; }
        /// <summary>
        /// The signature code of the boundary region as defined by Avalara.
        /// </summary>
        /// <value>The signature code of the boundary region as defined by Avalara.</value>
        [DataMember(Name="signatureCode", EmitDefaultValue=false)]
        public string SignatureCode { get; private set; }
        /// <summary>
        /// The state assigned number of this jurisdiction.
        /// </summary>
        /// <value>The state assigned number of this jurisdiction.</value>
        [DataMember(Name="stateAssignedNo", EmitDefaultValue=false)]
        public string StateAssignedNo { get; private set; }
        /// <summary>
        /// True if you are also declaring local nexus within this jurisdiction.              Many U.S. states have options for declaring nexus in local jurisdictions as well as within the state.
        /// </summary>
        /// <value>True if you are also declaring local nexus within this jurisdiction.              Many U.S. states have options for declaring nexus in local jurisdictions as well as within the state.</value>
        [DataMember(Name="hasLocalNexus", EmitDefaultValue=false)]
        public bool? HasLocalNexus { get; set; }
        /// <summary>
        /// Set this value to true if your company has a permanent establishment within this jurisdiction.
        /// </summary>
        /// <value>Set this value to true if your company has a permanent establishment within this jurisdiction.</value>
        [DataMember(Name="hasPermanentEstablishment", EmitDefaultValue=false)]
        public bool? HasPermanentEstablishment { get; set; }
        /// <summary>
        /// Optional - the tax identification number under which you declared nexus.
        /// </summary>
        /// <value>Optional - the tax identification number under which you declared nexus.</value>
        [DataMember(Name="taxId", EmitDefaultValue=false)]
        public string TaxId { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NexusModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  JurisTypeId: ").Append(JurisTypeId).Append("\n");
            sb.Append("  JurisCode: ").Append(JurisCode).Append("\n");
            sb.Append("  JurisName: ").Append(JurisName).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  SignatureCode: ").Append(SignatureCode).Append("\n");
            sb.Append("  StateAssignedNo: ").Append(StateAssignedNo).Append("\n");
            sb.Append("  NexusTypeId: ").Append(NexusTypeId).Append("\n");
            sb.Append("  Sourcing: ").Append(Sourcing).Append("\n");
            sb.Append("  HasLocalNexus: ").Append(HasLocalNexus).Append("\n");
            sb.Append("  LocalNexusTypeId: ").Append(LocalNexusTypeId).Append("\n");
            sb.Append("  HasPermanentEstablishment: ").Append(HasPermanentEstablishment).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  CreatedUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  ModifiedUserId: ").Append(ModifiedUserId).Append("\n");
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
            return this.Equals(obj as NexusModel);
        }

        /// <summary>
        /// Returns true if NexusModel instances are equal
        /// </summary>
        /// <param name="other">Instance of NexusModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NexusModel other)
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
                    this.CompanyId == other.CompanyId ||
                    this.CompanyId != null &&
                    this.CompanyId.Equals(other.CompanyId)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
                ) && 
                (
                    this.JurisTypeId == other.JurisTypeId ||
                    this.JurisTypeId != null &&
                    this.JurisTypeId.Equals(other.JurisTypeId)
                ) && 
                (
                    this.JurisCode == other.JurisCode ||
                    this.JurisCode != null &&
                    this.JurisCode.Equals(other.JurisCode)
                ) && 
                (
                    this.JurisName == other.JurisName ||
                    this.JurisName != null &&
                    this.JurisName.Equals(other.JurisName)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.SignatureCode == other.SignatureCode ||
                    this.SignatureCode != null &&
                    this.SignatureCode.Equals(other.SignatureCode)
                ) && 
                (
                    this.StateAssignedNo == other.StateAssignedNo ||
                    this.StateAssignedNo != null &&
                    this.StateAssignedNo.Equals(other.StateAssignedNo)
                ) && 
                (
                    this.NexusTypeId == other.NexusTypeId ||
                    this.NexusTypeId != null &&
                    this.NexusTypeId.Equals(other.NexusTypeId)
                ) && 
                (
                    this.Sourcing == other.Sourcing ||
                    this.Sourcing != null &&
                    this.Sourcing.Equals(other.Sourcing)
                ) && 
                (
                    this.HasLocalNexus == other.HasLocalNexus ||
                    this.HasLocalNexus != null &&
                    this.HasLocalNexus.Equals(other.HasLocalNexus)
                ) && 
                (
                    this.LocalNexusTypeId == other.LocalNexusTypeId ||
                    this.LocalNexusTypeId != null &&
                    this.LocalNexusTypeId.Equals(other.LocalNexusTypeId)
                ) && 
                (
                    this.HasPermanentEstablishment == other.HasPermanentEstablishment ||
                    this.HasPermanentEstablishment != null &&
                    this.HasPermanentEstablishment.Equals(other.HasPermanentEstablishment)
                ) && 
                (
                    this.TaxId == other.TaxId ||
                    this.TaxId != null &&
                    this.TaxId.Equals(other.TaxId)
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
                if (this.CompanyId != null)
                    hash = hash * 59 + this.CompanyId.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
                if (this.JurisTypeId != null)
                    hash = hash * 59 + this.JurisTypeId.GetHashCode();
                if (this.JurisCode != null)
                    hash = hash * 59 + this.JurisCode.GetHashCode();
                if (this.JurisName != null)
                    hash = hash * 59 + this.JurisName.GetHashCode();
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.SignatureCode != null)
                    hash = hash * 59 + this.SignatureCode.GetHashCode();
                if (this.StateAssignedNo != null)
                    hash = hash * 59 + this.StateAssignedNo.GetHashCode();
                if (this.NexusTypeId != null)
                    hash = hash * 59 + this.NexusTypeId.GetHashCode();
                if (this.Sourcing != null)
                    hash = hash * 59 + this.Sourcing.GetHashCode();
                if (this.HasLocalNexus != null)
                    hash = hash * 59 + this.HasLocalNexus.GetHashCode();
                if (this.LocalNexusTypeId != null)
                    hash = hash * 59 + this.LocalNexusTypeId.GetHashCode();
                if (this.HasPermanentEstablishment != null)
                    hash = hash * 59 + this.HasPermanentEstablishment.GetHashCode();
                if (this.TaxId != null)
                    hash = hash * 59 + this.TaxId.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.CreatedUserId != null)
                    hash = hash * 59 + this.CreatedUserId.GetHashCode();
                if (this.ModifiedDate != null)
                    hash = hash * 59 + this.ModifiedDate.GetHashCode();
                if (this.ModifiedUserId != null)
                    hash = hash * 59 + this.ModifiedUserId.GetHashCode();
                return hash;
            }
        }
    }

}
