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
    public partial class ReqPasswordDef : IEquatable<ReqPasswordDef>
    { 
        /// <summary>
        /// Senha atual.
        /// </summary>
        /// <value>Senha atual.</value>
        [DataMember(Name="senha_atual")]
        public string SenhaAtual { get; set; }

        /// <summary>
        /// Senha nova.
        /// </summary>
        /// <value>Senha nova.</value>
        [DataMember(Name="senha_nova")]
        public string SenhaNova { get; set; }

        /// <summary>
        /// Cofirma&amp;ccedil;&amp;atilde;o de nova senha.
        /// </summary>
        /// <value>Cofirma&amp;ccedil;&amp;atilde;o de nova senha.</value>
        [DataMember(Name="senha_nova2")]
        public string SenhaNova2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqPasswordDef {\n");
            sb.Append("  SenhaAtual: ").Append(SenhaAtual).Append("\n");
            sb.Append("  SenhaNova: ").Append(SenhaNova).Append("\n");
            sb.Append("  SenhaNova2: ").Append(SenhaNova2).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ReqPasswordDef)obj);
        }

        /// <summary>
        /// Returns true if ReqPasswordDef instances are equal
        /// </summary>
        /// <param name="other">Instance of ReqPasswordDef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReqPasswordDef other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SenhaAtual == other.SenhaAtual ||
                    SenhaAtual != null &&
                    SenhaAtual.Equals(other.SenhaAtual)
                ) && 
                (
                    SenhaNova == other.SenhaNova ||
                    SenhaNova != null &&
                    SenhaNova.Equals(other.SenhaNova)
                ) && 
                (
                    SenhaNova2 == other.SenhaNova2 ||
                    SenhaNova2 != null &&
                    SenhaNova2.Equals(other.SenhaNova2)
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
                    if (SenhaAtual != null)
                    hashCode = hashCode * 59 + SenhaAtual.GetHashCode();
                    if (SenhaNova != null)
                    hashCode = hashCode * 59 + SenhaNova.GetHashCode();
                    if (SenhaNova2 != null)
                    hashCode = hashCode * 59 + SenhaNova2.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ReqPasswordDef left, ReqPasswordDef right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReqPasswordDef left, ReqPasswordDef right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}