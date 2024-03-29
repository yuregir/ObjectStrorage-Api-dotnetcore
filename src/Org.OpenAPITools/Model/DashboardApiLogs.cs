/* 
 * Metacore IOT Object Storage API
 *
 * Metacore IOT Core Services
 *
 * The version of the OpenAPI document: 0.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DashboardApiLogs
    /// </summary>
    [DataContract]
    public partial class DashboardApiLogs :  IEquatable<DashboardApiLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardApiLogs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DashboardApiLogs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardApiLogs" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="details">details (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="ip">ip (required).</param>
        /// <param name="notes">notes (required).</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="source">source (required).</param>
        /// <param name="userId">userId (required).</param>
        public DashboardApiLogs(string id = default(string), string details = default(string), string eventType = default(string), string ip = default(string), string notes = default(string), string organizationId = default(string), string source = default(string), string userId = default(string))
        {
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for DashboardApiLogs and cannot be null");
            }
            else
            {
                this.Details = details;
            }

            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new InvalidDataException("eventType is a required property for DashboardApiLogs and cannot be null");
            }
            else
            {
                this.EventType = eventType;
            }

            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for DashboardApiLogs and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }

            // to ensure "notes" is required (not null)
            if (notes == null)
            {
                throw new InvalidDataException("notes is a required property for DashboardApiLogs and cannot be null");
            }
            else
            {
                this.Notes = notes;
            }

            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for DashboardApiLogs and cannot be null");
            }
            else
            {
                this.Source = source;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for DashboardApiLogs and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            this.Id = id;
            this.OrganizationId = organizationId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DashboardApiLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DashboardApiLogs);
        }

        /// <summary>
        /// Returns true if DashboardApiLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of DashboardApiLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DashboardApiLogs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.EventType != null)
                    hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // EventType (string) maxLength
            if(this.EventType != null && this.EventType.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be less than 20.", new [] { "EventType" });
            }

            // EventType (string) minLength
            if(this.EventType != null && this.EventType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventType, length must be greater than 1.", new [] { "EventType" });
            }

            yield break;
        }
    }

}
