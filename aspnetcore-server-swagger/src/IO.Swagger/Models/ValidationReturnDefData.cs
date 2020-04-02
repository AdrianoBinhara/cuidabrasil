/*
 * FVC
 *
 * API para o app Floripa Versus Corona  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: binhara@azuris.com.br
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ValidationReturnDefData : IEquatable<ValidationReturnDefData>
    { 
        /// <summary>
        /// Gets or Sets IsNewUser
        /// </summary>
        [DataMember(Name="isNewUser")]
        public string IsNewUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidationReturnDefData {\n");
            sb.Append("  IsNewUser: ").Append(IsNewUser).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ValidationReturnDefData)obj);
        }

        /// <summary>
        /// Returns true if ValidationReturnDefData instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidationReturnDefData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationReturnDefData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsNewUser == other.IsNewUser ||
                    IsNewUser != null &&
                    IsNewUser.Equals(other.IsNewUser)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (IsNewUser != null)
                    hashCode = hashCode * 59 + IsNewUser.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ValidationReturnDefData left, ValidationReturnDefData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValidationReturnDefData left, ValidationReturnDefData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}