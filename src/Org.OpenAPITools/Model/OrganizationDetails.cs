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
    /// OrganizationDetails
    /// </summary>
    [DataContract]
    public partial class OrganizationDetails :  IEquatable<OrganizationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDetails" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="balance">balance.</param>
        /// <param name="category">category.</param>
        /// <param name="contactType">contactType.</param>
        /// <param name="iban">iban.</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="subscriptionEndDateTime">subscriptionEndDateTime.</param>
        /// <param name="type">type.</param>
        public OrganizationDetails(string id = default(string), int balance = default(int), string category = default(string), string contactType = default(string), string iban = default(string), string organizationId = default(string), DateTime subscriptionEndDateTime = default(DateTime), string type = default(string))
        {
            this.Id = id;
            this.Balance = balance;
            this.Category = category;
            this.ContactType = contactType;
            this.Iban = iban;
            this.OrganizationId = organizationId;
            this.SubscriptionEndDateTime = subscriptionEndDateTime;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public int Balance { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets ContactType
        /// </summary>
        [DataMember(Name="contactType", EmitDefaultValue=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionEndDateTime
        /// </summary>
        [DataMember(Name="subscriptionEndDateTime", EmitDefaultValue=false)]
        public DateTime SubscriptionEndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationDetails {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  SubscriptionEndDateTime: ").Append(SubscriptionEndDateTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as OrganizationDetails);
        }

        /// <summary>
        /// Returns true if OrganizationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationDetails input)
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
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ContactType == input.ContactType ||
                    (this.ContactType != null &&
                    this.ContactType.Equals(input.ContactType))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.SubscriptionEndDateTime == input.SubscriptionEndDateTime ||
                    (this.SubscriptionEndDateTime != null &&
                    this.SubscriptionEndDateTime.Equals(input.SubscriptionEndDateTime))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ContactType != null)
                    hashCode = hashCode * 59 + this.ContactType.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.SubscriptionEndDateTime != null)
                    hashCode = hashCode * 59 + this.SubscriptionEndDateTime.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            yield break;
        }
    }

}
