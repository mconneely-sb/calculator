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
    /// A money transfer request
    /// </summary>
    [DataContract]
        public partial class TransferRequest :  IEquatable<TransferRequest>, IValidatableObject
    {
        /// <summary>
        /// Frequency of recurring transfer&#x27;s execution
        /// </summary>
        /// <value>Frequency of recurring transfer&#x27;s execution</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FrequencyEnum
        {
            /// <summary>
            /// Enum WEEKLY for value: WEEKLY
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY = 1,
            /// <summary>
            /// Enum MONTHLY for value: MONTHLY
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY = 2,
            /// <summary>
            /// Enum QUARTERLY for value: QUARTERLY
            /// </summary>
            [EnumMember(Value = "QUARTERLY")]
            QUARTERLY = 3,
            /// <summary>
            /// Enum YEARLY for value: YEARLY
            /// </summary>
            [EnumMember(Value = "YEARLY")]
            YEARLY = 4        }
        /// <summary>
        /// Frequency of recurring transfer&#x27;s execution
        /// </summary>
        /// <value>Frequency of recurring transfer&#x27;s execution</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferRequest" /> class.
        /// </summary>
        /// <param name="source">Source account number (required).</param>
        /// <param name="destination">Destination account number (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="date">Execution date for a delayed transfer or first execution date for a recurring one .</param>
        /// <param name="occurrences">Number of times a recurring transfer will be executed .</param>
        /// <param name="frequency">Frequency of recurring transfer&#x27;s execution.</param>
        public TransferRequest(string source = default(string), string destination = default(string), decimal? amount = default(decimal?), DateTime? date = default(DateTime?), int? occurrences = default(int?), FrequencyEnum? frequency = default(FrequencyEnum?))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for TransferRequest and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            // to ensure "destination" is required (not null)
            if (destination == null)
            {
                throw new InvalidDataException("destination is a required property for TransferRequest and cannot be null");
            }
            else
            {
                this.Destination = destination;
            }
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TransferRequest and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            this.Date = date;
            this.Occurrences = occurrences;
            this.Frequency = frequency;
        }
        
        /// <summary>
        /// Source account number
        /// </summary>
        /// <value>Source account number</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Destination account number
        /// </summary>
        /// <value>Destination account number</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Execution date for a delayed transfer or first execution date for a recurring one 
        /// </summary>
        /// <value>Execution date for a delayed transfer or first execution date for a recurring one </value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Number of times a recurring transfer will be executed 
        /// </summary>
        /// <value>Number of times a recurring transfer will be executed </value>
        [DataMember(Name="occurrences", EmitDefaultValue=false)]
        public int? Occurrences { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferRequest {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
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
            return this.Equals(input as TransferRequest);
        }

        /// <summary>
        /// Returns true if TransferRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferRequest input)
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
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Occurrences == input.Occurrences ||
                    (this.Occurrences != null &&
                    this.Occurrences.Equals(input.Occurrences))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
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
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Occurrences != null)
                    hashCode = hashCode * 59 + this.Occurrences.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
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
