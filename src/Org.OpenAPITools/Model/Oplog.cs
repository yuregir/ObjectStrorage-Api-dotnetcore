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
    /// Oplog
    /// </summary>
    [DataContract]
    public partial class Oplog :  IEquatable<Oplog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Oplog" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="c">c.</param>
        /// <param name="i">i.</param>
        /// <param name="ip">ip.</param>
        /// <param name="o">o.</param>
        /// <param name="r">r.</param>
        /// <param name="u">u.</param>
        public Oplog(string id = default(string), Object c = default(Object), Object i = default(Object), Object ip = default(Object), Object o = default(Object), Object r = default(Object), Object u = default(Object))
        {
            this.Id = id;
            this.C = c;
            this.I = i;
            this.Ip = ip;
            this.O = o;
            this.R = r;
            this.U = u;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets C
        /// </summary>
        [DataMember(Name="c", EmitDefaultValue=false)]
        public Object C { get; set; }

        /// <summary>
        /// Gets or Sets I
        /// </summary>
        [DataMember(Name="i", EmitDefaultValue=false)]
        public Object I { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public Object Ip { get; set; }

        /// <summary>
        /// Gets or Sets O
        /// </summary>
        [DataMember(Name="o", EmitDefaultValue=false)]
        public Object O { get; set; }

        /// <summary>
        /// Gets or Sets R
        /// </summary>
        [DataMember(Name="r", EmitDefaultValue=false)]
        public Object R { get; set; }

        /// <summary>
        /// Gets or Sets U
        /// </summary>
        [DataMember(Name="u", EmitDefaultValue=false)]
        public Object U { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Oplog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  I: ").Append(I).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  O: ").Append(O).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  U: ").Append(U).Append("\n");
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
            return this.Equals(input as Oplog);
        }

        /// <summary>
        /// Returns true if Oplog instances are equal
        /// </summary>
        /// <param name="input">Instance of Oplog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Oplog input)
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
                    this.C == input.C ||
                    (this.C != null &&
                    this.C.Equals(input.C))
                ) && 
                (
                    this.I == input.I ||
                    (this.I != null &&
                    this.I.Equals(input.I))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.O == input.O ||
                    (this.O != null &&
                    this.O.Equals(input.O))
                ) && 
                (
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.U == input.U ||
                    (this.U != null &&
                    this.U.Equals(input.U))
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
                if (this.C != null)
                    hashCode = hashCode * 59 + this.C.GetHashCode();
                if (this.I != null)
                    hashCode = hashCode * 59 + this.I.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.O != null)
                    hashCode = hashCode * 59 + this.O.GetHashCode();
                if (this.R != null)
                    hashCode = hashCode * 59 + this.R.GetHashCode();
                if (this.U != null)
                    hashCode = hashCode * 59 + this.U.GetHashCode();
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
