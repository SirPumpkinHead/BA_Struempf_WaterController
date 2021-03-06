/* 
 * FIWARE-NGSI v2 Specification
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ContextBrokerLibrary.Model
{
    /// <summary>
    /// ListRegistrationsResponse
    /// </summary>
    [DataContract]
    public partial class ListRegistrationsResponse : IEquatable<ListRegistrationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListRegistrationsResponse" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="dataProvided">dataProvided (required).</param>
        /// <param name="provider">provider (required).</param>
        /// <param name="expires">expires (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="forwardingInformation">forwardingInformation (required).</param>
        public ListRegistrationsResponse(string id = default(string), string description = default(string),
            Object dataProvided = default(Object), Object provider = default(Object), string expires = default(string),
            string status = default(string), Object forwardingInformation = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException(
                    "id is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException(
                    "description is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.Description = description;
            }

            // to ensure "dataProvided" is required (not null)
            if (dataProvided == null)
            {
                throw new InvalidDataException(
                    "dataProvided is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.DataProvided = dataProvided;
            }

            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new InvalidDataException(
                    "provider is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.Provider = provider;
            }

            // to ensure "expires" is required (not null)
            if (expires == null)
            {
                throw new InvalidDataException(
                    "expires is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.Expires = expires;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException(
                    "status is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "forwardingInformation" is required (not null)
            if (forwardingInformation == null)
            {
                throw new InvalidDataException(
                    "forwardingInformation is a required property for ListRegistrationsResponse and cannot be null");
            }
            else
            {
                this.ForwardingInformation = forwardingInformation;
            }
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DataProvided
        /// </summary>
        [DataMember(Name = "dataProvided", EmitDefaultValue = false)]
        public Object DataProvided { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public Object Provider { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets ForwardingInformation
        /// </summary>
        [DataMember(Name = "forwardingInformation", EmitDefaultValue = false)]
        public Object ForwardingInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRegistrationsResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataProvided: ").Append(DataProvided).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ForwardingInformation: ").Append(ForwardingInformation).Append("\n");
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
            return this.Equals(input as ListRegistrationsResponse);
        }

        /// <summary>
        /// Returns true if ListRegistrationsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListRegistrationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListRegistrationsResponse input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                     this.Description.Equals(input.Description))
                ) &&
                (
                    this.DataProvided == input.DataProvided ||
                    (this.DataProvided != null &&
                     this.DataProvided.Equals(input.DataProvided))
                ) &&
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                     this.Provider.Equals(input.Provider))
                ) &&
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                     this.Expires.Equals(input.Expires))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                     this.Status.Equals(input.Status))
                ) &&
                (
                    this.ForwardingInformation == input.ForwardingInformation ||
                    (this.ForwardingInformation != null &&
                     this.ForwardingInformation.Equals(input.ForwardingInformation))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DataProvided != null)
                    hashCode = hashCode * 59 + this.DataProvided.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Expires != null)
                    hashCode = hashCode * 59 + this.Expires.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ForwardingInformation != null)
                    hashCode = hashCode * 59 + this.ForwardingInformation.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}