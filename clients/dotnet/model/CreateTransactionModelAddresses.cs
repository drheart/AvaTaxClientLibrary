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
    /// Default addresses for all lines in this document
    /// </summary>
    [DataContract]
    public partial class CreateTransactionModelAddresses :  IEquatable<CreateTransactionModelAddresses>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionModelAddresses" /> class.
        /// </summary>
        /// <param name="ShipFrom">ShipFrom.</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="PointOfOrderAcceptance">PointOfOrderAcceptance.</param>
        /// <param name="PointOfOrderOrigin">PointOfOrderOrigin.</param>
        /// <param name="SingleLocation">SingleLocation.</param>
        public CreateTransactionModelAddresses(AddressInfo ShipFrom = null, AddressInfo ShipTo = null, AddressInfo PointOfOrderAcceptance = null, AddressInfo PointOfOrderOrigin = null, AddressInfo SingleLocation = null)
        {
            this.ShipFrom = ShipFrom;
            this.ShipTo = ShipTo;
            this.PointOfOrderAcceptance = PointOfOrderAcceptance;
            this.PointOfOrderOrigin = PointOfOrderOrigin;
            this.SingleLocation = SingleLocation;
        }
        
        /// <summary>
        /// Gets or Sets ShipFrom
        /// </summary>
        [DataMember(Name="ShipFrom", EmitDefaultValue=false)]
        public AddressInfo ShipFrom { get; set; }
        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="ShipTo", EmitDefaultValue=false)]
        public AddressInfo ShipTo { get; set; }
        /// <summary>
        /// Gets or Sets PointOfOrderAcceptance
        /// </summary>
        [DataMember(Name="PointOfOrderAcceptance", EmitDefaultValue=false)]
        public AddressInfo PointOfOrderAcceptance { get; set; }
        /// <summary>
        /// Gets or Sets PointOfOrderOrigin
        /// </summary>
        [DataMember(Name="PointOfOrderOrigin", EmitDefaultValue=false)]
        public AddressInfo PointOfOrderOrigin { get; set; }
        /// <summary>
        /// Gets or Sets SingleLocation
        /// </summary>
        [DataMember(Name="SingleLocation", EmitDefaultValue=false)]
        public AddressInfo SingleLocation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransactionModelAddresses {\n");
            sb.Append("  ShipFrom: ").Append(ShipFrom).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  PointOfOrderAcceptance: ").Append(PointOfOrderAcceptance).Append("\n");
            sb.Append("  PointOfOrderOrigin: ").Append(PointOfOrderOrigin).Append("\n");
            sb.Append("  SingleLocation: ").Append(SingleLocation).Append("\n");
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
            return this.Equals(obj as CreateTransactionModelAddresses);
        }

        /// <summary>
        /// Returns true if CreateTransactionModelAddresses instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateTransactionModelAddresses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionModelAddresses other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ShipFrom == other.ShipFrom ||
                    this.ShipFrom != null &&
                    this.ShipFrom.Equals(other.ShipFrom)
                ) && 
                (
                    this.ShipTo == other.ShipTo ||
                    this.ShipTo != null &&
                    this.ShipTo.Equals(other.ShipTo)
                ) && 
                (
                    this.PointOfOrderAcceptance == other.PointOfOrderAcceptance ||
                    this.PointOfOrderAcceptance != null &&
                    this.PointOfOrderAcceptance.Equals(other.PointOfOrderAcceptance)
                ) && 
                (
                    this.PointOfOrderOrigin == other.PointOfOrderOrigin ||
                    this.PointOfOrderOrigin != null &&
                    this.PointOfOrderOrigin.Equals(other.PointOfOrderOrigin)
                ) && 
                (
                    this.SingleLocation == other.SingleLocation ||
                    this.SingleLocation != null &&
                    this.SingleLocation.Equals(other.SingleLocation)
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
                if (this.ShipFrom != null)
                    hash = hash * 59 + this.ShipFrom.GetHashCode();
                if (this.ShipTo != null)
                    hash = hash * 59 + this.ShipTo.GetHashCode();
                if (this.PointOfOrderAcceptance != null)
                    hash = hash * 59 + this.PointOfOrderAcceptance.GetHashCode();
                if (this.PointOfOrderOrigin != null)
                    hash = hash * 59 + this.PointOfOrderOrigin.GetHashCode();
                if (this.SingleLocation != null)
                    hash = hash * 59 + this.SingleLocation.GetHashCode();
                return hash;
            }
        }
    }

}
