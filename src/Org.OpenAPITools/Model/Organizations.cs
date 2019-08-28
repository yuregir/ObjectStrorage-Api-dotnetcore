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
    /// Organizations
    /// </summary>
    [DataContract]
    public partial class Organizations :  IEquatable<Organizations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Organizations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Organizations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Organizations" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="address">address (required).</param>
        /// <param name="brandName">brandName (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="gpsLogId">gpsLogId.</param>
        /// <param name="isActive">isActive (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="organizationId">organizationId.</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="primaryContactName">primaryContactName (required).</param>
        /// <param name="settingId">settingId.</param>
        /// <param name="taxNumber">taxNumber (required).</param>
        /// <param name="taxOffice">taxOffice (required).</param>
        public Organizations(string id = default(string), string address = default(string), string brandName = default(string), string city = default(string), string description = default(string), string email = default(string), int gpsLogId = default(int), bool isActive = default(bool), string name = default(string), string organizationId = default(string), string phoneNumber = default(string), string primaryContactName = default(string), int settingId = default(int), int taxNumber = default(int), string taxOffice = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for Organizations and cannot be null");
            }
            else
            {
                this.Address = address;
            }

            // to ensure "brandName" is required (not null)
            if (brandName == null)
            {
                throw new InvalidDataException("brandName is a required property for Organizations and cannot be null");
            }
            else
            {
                this.BrandName = brandName;
            }

            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for Organizations and cannot be null");
            }
            else
            {
                this.City = city;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for Organizations and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for Organizations and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // to ensure "isActive" is required (not null)
            if (isActive == null)
            {
                throw new InvalidDataException("isActive is a required property for Organizations and cannot be null");
            }
            else
            {
                this.IsActive = isActive;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Organizations and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "phoneNumber" is required (not null)
            if (phoneNumber == null)
            {
                throw new InvalidDataException("phoneNumber is a required property for Organizations and cannot be null");
            }
            else
            {
                this.PhoneNumber = phoneNumber;
            }

            // to ensure "primaryContactName" is required (not null)
            if (primaryContactName == null)
            {
                throw new InvalidDataException("primaryContactName is a required property for Organizations and cannot be null");
            }
            else
            {
                this.PrimaryContactName = primaryContactName;
            }

            // to ensure "taxNumber" is required (not null)
            if (taxNumber == null)
            {
                throw new InvalidDataException("taxNumber is a required property for Organizations and cannot be null");
            }
            else
            {
                this.TaxNumber = taxNumber;
            }

            // to ensure "taxOffice" is required (not null)
            if (taxOffice == null)
            {
                throw new InvalidDataException("taxOffice is a required property for Organizations and cannot be null");
            }
            else
            {
                this.TaxOffice = taxOffice;
            }

            this.Id = id;
            this.GpsLogId = gpsLogId;
            this.OrganizationId = organizationId;
            this.SettingId = settingId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets BrandName
        /// </summary>
        [DataMember(Name="brandName", EmitDefaultValue=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets GpsLogId
        /// </summary>
        [DataMember(Name="gpsLogId", EmitDefaultValue=false)]
        public int GpsLogId { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContactName
        /// </summary>
        [DataMember(Name="primaryContactName", EmitDefaultValue=false)]
        public string PrimaryContactName { get; set; }

        /// <summary>
        /// Gets or Sets SettingId
        /// </summary>
        [DataMember(Name="settingId", EmitDefaultValue=false)]
        public int SettingId { get; set; }

        /// <summary>
        /// Gets or Sets TaxNumber
        /// </summary>
        [DataMember(Name="taxNumber", EmitDefaultValue=false)]
        public int TaxNumber { get; set; }

        /// <summary>
        /// Gets or Sets TaxOffice
        /// </summary>
        [DataMember(Name="taxOffice", EmitDefaultValue=false)]
        public string TaxOffice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Organizations {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  GpsLogId: ").Append(GpsLogId).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PrimaryContactName: ").Append(PrimaryContactName).Append("\n");
            sb.Append("  SettingId: ").Append(SettingId).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  TaxOffice: ").Append(TaxOffice).Append("\n");
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
            return this.Equals(input as Organizations);
        }

        /// <summary>
        /// Returns true if Organizations instances are equal
        /// </summary>
        /// <param name="input">Instance of Organizations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Organizations input)
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
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.GpsLogId == input.GpsLogId ||
                    this.GpsLogId.Equals(input.GpsLogId)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OrganizationId == input.OrganizationId ||
                    (this.OrganizationId != null &&
                    this.OrganizationId.Equals(input.OrganizationId))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PrimaryContactName == input.PrimaryContactName ||
                    (this.PrimaryContactName != null &&
                    this.PrimaryContactName.Equals(input.PrimaryContactName))
                ) && 
                (
                    this.SettingId == input.SettingId ||
                    this.SettingId.Equals(input.SettingId)
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    this.TaxNumber.Equals(input.TaxNumber)
                ) && 
                (
                    this.TaxOffice == input.TaxOffice ||
                    (this.TaxOffice != null &&
                    this.TaxOffice.Equals(input.TaxOffice))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.BrandName != null)
                    hashCode = hashCode * 59 + this.BrandName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.GpsLogId.GetHashCode();
                hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrganizationId != null)
                    hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.PrimaryContactName != null)
                    hashCode = hashCode * 59 + this.PrimaryContactName.GetHashCode();
                hashCode = hashCode * 59 + this.SettingId.GetHashCode();
                hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                if (this.TaxOffice != null)
                    hashCode = hashCode * 59 + this.TaxOffice.GetHashCode();
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