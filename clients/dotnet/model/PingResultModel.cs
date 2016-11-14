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
    /// Ping Result Model
    /// </summary>
    [DataContract]
    public partial class PingResultModel :  IEquatable<PingResultModel>
    {
        /// <summary>
        /// Returns the type of authentication you provided, if authenticated
        /// </summary>
        /// <value>Returns the type of authentication you provided, if authenticated</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum UsernamePassword for "UsernamePassword"
            /// </summary>
            [EnumMember(Value = "UsernamePassword")]
            UsernamePassword,
            
            /// <summary>
            /// Enum AccountIdLicenseKey for "AccountIdLicenseKey"
            /// </summary>
            [EnumMember(Value = "AccountIdLicenseKey")]
            AccountIdLicenseKey,
            
            /// <summary>
            /// Enum OpenIdBearerToken for "OpenIdBearerToken"
            /// </summary>
            [EnumMember(Value = "OpenIdBearerToken")]
            OpenIdBearerToken
        }

        /// <summary>
        /// Returns the type of authentication you provided, if authenticated
        /// </summary>
        /// <value>Returns the type of authentication you provided, if authenticated</value>
        [DataMember(Name="authenticationType", EmitDefaultValue=false)]
        public AuthenticationTypeEnum? AuthenticationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PingResultModel" /> class.
        /// </summary>
        /// <param name="Version">Version number.</param>
        /// <param name="Authenticated">Returns true if you provided authentication for this API call; false if you did not..</param>
        /// <param name="AuthenticationType">Returns the type of authentication you provided, if authenticated.</param>
        /// <param name="AuthenticatedUserName">The username of the currently authenticated user, if any..</param>
        public PingResultModel(string Version = null, bool? Authenticated = null, AuthenticationTypeEnum? AuthenticationType = null, string AuthenticatedUserName = null)
        {
            this.Version = Version;
            this.Authenticated = Authenticated;
            this.AuthenticationType = AuthenticationType;
            this.AuthenticatedUserName = AuthenticatedUserName;
        }
        
        /// <summary>
        /// Version number
        /// </summary>
        /// <value>Version number</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Returns true if you provided authentication for this API call; false if you did not.
        /// </summary>
        /// <value>Returns true if you provided authentication for this API call; false if you did not.</value>
        [DataMember(Name="authenticated", EmitDefaultValue=false)]
        public bool? Authenticated { get; set; }
        /// <summary>
        /// The username of the currently authenticated user, if any.
        /// </summary>
        /// <value>The username of the currently authenticated user, if any.</value>
        [DataMember(Name="authenticatedUserName", EmitDefaultValue=false)]
        public string AuthenticatedUserName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PingResultModel {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  AuthenticatedUserName: ").Append(AuthenticatedUserName).Append("\n");
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
            return this.Equals(obj as PingResultModel);
        }

        /// <summary>
        /// Returns true if PingResultModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PingResultModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PingResultModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Authenticated == other.Authenticated ||
                    this.Authenticated != null &&
                    this.Authenticated.Equals(other.Authenticated)
                ) && 
                (
                    this.AuthenticationType == other.AuthenticationType ||
                    this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(other.AuthenticationType)
                ) && 
                (
                    this.AuthenticatedUserName == other.AuthenticatedUserName ||
                    this.AuthenticatedUserName != null &&
                    this.AuthenticatedUserName.Equals(other.AuthenticatedUserName)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Authenticated != null)
                    hash = hash * 59 + this.Authenticated.GetHashCode();
                if (this.AuthenticationType != null)
                    hash = hash * 59 + this.AuthenticationType.GetHashCode();
                if (this.AuthenticatedUserName != null)
                    hash = hash * 59 + this.AuthenticatedUserName.GetHashCode();
                return hash;
            }
        }
    }

}
