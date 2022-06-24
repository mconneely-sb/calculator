/* 
 * Sample Post Office API
 *
 * This is a sample post office API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// ConsumerErrorErrors
    /// </summary>
    [DataContract]
        public partial class ConsumerErrorErrors :  IEquatable<ConsumerErrorErrors>, IValidatableObject
    {
        /// <summary>
        /// the property source of the error
        /// </summary>
        /// <value>the property source of the error</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SourceEnum
        {
            /// <summary>
            /// Enum Source for value: source
            /// </summary>
            [EnumMember(Value = "source")]
            Source = 1,
            /// <summary>
            /// Enum Destination for value: destination
            /// </summary>
            [EnumMember(Value = "destination")]
            Destination = 2,
            /// <summary>
            /// Enum Amount for value: amount
            /// </summary>
            [EnumMember(Value = "amount")]
            Amount = 3,
            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 4,
            /// <summary>
            /// Enum Occurrences for value: occurrences
            /// </summary>
            [EnumMember(Value = "occurrences")]
            Occurrences = 5,
            /// <summary>
            /// Enum Frequency for value: frequency
            /// </summary>
            [EnumMember(Value = "frequency")]
            Frequency = 6        }
        /// <summary>
        /// the property source of the error
        /// </summary>
        /// <value>the property source of the error</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum MANDATORYPROPERTY for value: MANDATORY_PROPERTY
            /// </summary>
            [EnumMember(Value = "MANDATORY_PROPERTY")]
            MANDATORYPROPERTY = 1,
            /// <summary>
            /// Enum INVALIDFORMAT for value: INVALID_FORMAT
            /// </summary>
            [EnumMember(Value = "INVALID_FORMAT")]
            INVALIDFORMAT = 2,
            /// <summary>
            /// Enum INVALIDVALUE for value: INVALID_VALUE
            /// </summary>
            [EnumMember(Value = "INVALID_VALUE")]
            INVALIDVALUE = 3,
            /// <summary>
            /// Enum INSUFFICIENTBALANCE for value: INSUFFICIENT_BALANCE
            /// </summary>
            [EnumMember(Value = "INSUFFICIENT_BALANCE")]
            INSUFFICIENTBALANCE = 4        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsumerErrorErrors" /> class.
        /// </summary>
        /// <param name="source">the property source of the error (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="message">a human-readable error message (required).</param>
        public ConsumerErrorErrors(SourceEnum source = default(SourceEnum), TypeEnum type = default(TypeEnum), string message = default(string))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for ConsumerErrorErrors and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ConsumerErrorErrors and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for ConsumerErrorErrors and cannot be null");
            }
            else
            {
                this.Message = message;
            }
        }
        


        /// <summary>
        /// a human-readable error message
        /// </summary>
        /// <value>a human-readable error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerErrorErrors {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as ConsumerErrorErrors);
        }

        /// <summary>
        /// Returns true if ConsumerErrorErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsumerErrorErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsumerErrorErrors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
