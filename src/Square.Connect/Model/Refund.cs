/* 
 * Square Connect API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
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

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a refund processed for a Square transaction.
    /// </summary>
    [DataContract]
    public partial class Refund :  IEquatable<Refund>
    {
        /// <summary>
        /// The current status of the refund (`PENDING`, `APPROVED`, `REJECTED`, or `FAILED`).
        /// </summary>
        /// <value>The current status of the refund (`PENDING`, `APPROVED`, `REJECTED`, or `FAILED`).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum APPROVED for "APPROVED"
            /// </summary>
            [EnumMember(Value = "APPROVED")]
            APPROVED,
            
            /// <summary>
            /// Enum REJECTED for "REJECTED"
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED,
            
            /// <summary>
            /// Enum FAILED for "FAILED"
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED
        }

        /// <summary>
        /// This function is to convert the String Value to its correspoding Enum value
        /// </summary>
        public static StatusEnum ToStatusEnum (string str)
        {
            var enumType = typeof(StatusEnum);
            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
                if (enumMemberAttribute.Value == str) return (StatusEnum)Enum.Parse(enumType, name);
            }
            return default(StatusEnum);
        }

        /// <summary>
        /// This function is to convert the Enum Value to its correspoding String Value
        /// </summary>
        public static string StatusEnumToString(StatusEnum type)
        {
            var enumType = typeof(StatusEnum);
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute = ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
            return enumMemberAttribute.Value;
            
        }

        /// <summary>
        /// The current status of the refund (`PENDING`, `APPROVED`, `REJECTED`, or `FAILED`).
        /// </summary>
        /// <value>The current status of the refund (`PENDING`, `APPROVED`, `REJECTED`, or `FAILED`).</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Refund() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        /// <param name="Id">The refund&#39;s unique ID. (required).</param>
        /// <param name="LocationId">The ID of the refund&#39;s associated location. (required).</param>
        /// <param name="TransactionId">The ID of the transaction that the refunded tender is part of. (required).</param>
        /// <param name="TenderId">The ID of the refunded tender. (required).</param>
        /// <param name="CreatedAt">The time when the refund was created, in RFC 3339 format..</param>
        /// <param name="Reason">The reason for the refund being issued. (required).</param>
        /// <param name="AmountMoney">The amount of money refunded to the buyer. (required).</param>
        /// <param name="Status">The current status of the refund (&#x60;PENDING&#x60;, &#x60;APPROVED&#x60;, &#x60;REJECTED&#x60;, or &#x60;FAILED&#x60;). (required).</param>
        /// <param name="ProcessingFeeMoney">The amount of Square processing fee money refunded to the *merchant*..</param>
        public Refund(string Id = null, string LocationId = null, string TransactionId = null, string TenderId = null, string CreatedAt = null, string Reason = null, Money AmountMoney = null, StatusEnum? Status = null, Money ProcessingFeeMoney = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Refund and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "LocationId" is required (not null)
            if (LocationId == null)
            {
                throw new InvalidDataException("LocationId is a required property for Refund and cannot be null");
            }
            else
            {
                this.LocationId = LocationId;
            }
            // to ensure "TransactionId" is required (not null)
            if (TransactionId == null)
            {
                throw new InvalidDataException("TransactionId is a required property for Refund and cannot be null");
            }
            else
            {
                this.TransactionId = TransactionId;
            }
            // to ensure "TenderId" is required (not null)
            if (TenderId == null)
            {
                throw new InvalidDataException("TenderId is a required property for Refund and cannot be null");
            }
            else
            {
                this.TenderId = TenderId;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for Refund and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for Refund and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Refund and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.CreatedAt = CreatedAt;
            this.ProcessingFeeMoney = ProcessingFeeMoney;
        }
        
        /// <summary>
        /// The refund&#39;s unique ID.
        /// </summary>
        /// <value>The refund&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the refund&#39;s associated location.
        /// </summary>
        /// <value>The ID of the refund&#39;s associated location.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The ID of the transaction that the refunded tender is part of.
        /// </summary>
        /// <value>The ID of the transaction that the refunded tender is part of.</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// The ID of the refunded tender.
        /// </summary>
        /// <value>The ID of the refunded tender.</value>
        [DataMember(Name="tender_id", EmitDefaultValue=false)]
        public string TenderId { get; set; }
        /// <summary>
        /// The time when the refund was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the refund was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// The reason for the refund being issued.
        /// </summary>
        /// <value>The reason for the refund being issued.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// The amount of money refunded to the buyer.
        /// </summary>
        /// <value>The amount of money refunded to the buyer.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The amount of Square processing fee money refunded to the *merchant*.
        /// </summary>
        /// <value>The amount of Square processing fee money refunded to the *merchant*.</value>
        [DataMember(Name="processing_fee_money", EmitDefaultValue=false)]
        public Money ProcessingFeeMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Refund {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TenderId: ").Append(TenderId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProcessingFeeMoney: ").Append(ProcessingFeeMoney).Append("\n");
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
            return this.Equals(obj as Refund);
        }

        /// <summary>
        /// Returns true if Refund instances are equal
        /// </summary>
        /// <param name="other">Instance of Refund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Refund other)
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
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.TenderId == other.TenderId ||
                    this.TenderId != null &&
                    this.TenderId.Equals(other.TenderId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ProcessingFeeMoney == other.ProcessingFeeMoney ||
                    this.ProcessingFeeMoney != null &&
                    this.ProcessingFeeMoney.Equals(other.ProcessingFeeMoney)
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
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.TenderId != null)
                    hash = hash * 59 + this.TenderId.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ProcessingFeeMoney != null)
                    hash = hash * 59 + this.ProcessingFeeMoney.GetHashCode();
                return hash;
            }
        }
    }

}
