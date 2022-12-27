// <copyright file="GetCustomerResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeApiSDK.Standard;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// GetCustomerResponse.
    /// </summary>
    public class GetCustomerResponse
    {
        private long? fbId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "fb_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerResponse"/> class.
        /// </summary>
        public GetCustomerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerResponse"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="delinquent">delinquent.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="document">document.</param>
        /// <param name="type">type.</param>
        /// <param name="fbAccessToken">fb_access_token.</param>
        /// <param name="address">address.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="phones">phones.</param>
        /// <param name="fbId">fb_id.</param>
        /// <param name="code">code.</param>
        /// <param name="documentType">document_type.</param>
        public GetCustomerResponse(
            string id = null,
            string name = null,
            string email = null,
            bool? delinquent = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            string document = null,
            string type = null,
            string fbAccessToken = null,
            Models.GetAddressResponse address = null,
            Dictionary<string, string> metadata = null,
            Models.GetPhonesResponse phones = null,
            long? fbId = null,
            string code = null,
            string documentType = null)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Delinquent = delinquent;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Document = document;
            this.Type = type;
            this.FbAccessToken = fbAccessToken;
            this.Address = address;
            this.Metadata = metadata;
            this.Phones = phones;
            if (fbId != null)
            {
                this.FbId = fbId;
            }

            this.Code = code;
            this.DocumentType = documentType;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Include)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Include)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Include)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Delinquent.
        /// </summary>
        [JsonProperty("delinquent", NullValueHandling = NullValueHandling.Include)]
        public bool? Delinquent { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Include)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets Document.
        /// </summary>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Include)]
        public string Document { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Include)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets FbAccessToken.
        /// </summary>
        [JsonProperty("fb_access_token", NullValueHandling = NullValueHandling.Include)]
        public string FbAccessToken { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Include)]
        public Models.GetAddressResponse Address { get; set; }

        /// <summary>
        /// Gets or sets Metadata.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets Phones.
        /// </summary>
        [JsonProperty("phones", NullValueHandling = NullValueHandling.Include)]
        public Models.GetPhonesResponse Phones { get; set; }

        /// <summary>
        /// Gets or sets FbId.
        /// </summary>
        [JsonProperty("fb_id")]
        public long? FbId
        {
            get
            {
                return this.fbId;
            }

            set
            {
                this.shouldSerialize["fb_id"] = true;
                this.fbId = value;
            }
        }

        /// <summary>
        /// Código de referência do cliente no sistema da loja. Max: 52 caracteres
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Include)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets DocumentType.
        /// </summary>
        [JsonProperty("document_type", NullValueHandling = NullValueHandling.Include)]
        public string DocumentType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetCustomerResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFbId()
        {
            this.shouldSerialize["fb_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFbId()
        {
            return this.shouldSerialize["fb_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetCustomerResponse other &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Delinquent == null && other.Delinquent == null) || (this.Delinquent?.Equals(other.Delinquent) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.Document == null && other.Document == null) || (this.Document?.Equals(other.Document) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.FbAccessToken == null && other.FbAccessToken == null) || (this.FbAccessToken?.Equals(other.FbAccessToken) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Metadata == null && other.Metadata == null) || (this.Metadata?.Equals(other.Metadata) == true)) &&
                ((this.Phones == null && other.Phones == null) || (this.Phones?.Equals(other.Phones) == true)) &&
                ((this.FbId == null && other.FbId == null) || (this.FbId?.Equals(other.FbId) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Delinquent = {(this.Delinquent == null ? "null" : this.Delinquent.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.Document = {(this.Document == null ? "null" : this.Document == string.Empty ? "" : this.Document)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.FbAccessToken = {(this.FbAccessToken == null ? "null" : this.FbAccessToken == string.Empty ? "" : this.FbAccessToken)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"Metadata = {(this.Metadata == null ? "null" : this.Metadata.ToString())}");
            toStringOutput.Add($"this.Phones = {(this.Phones == null ? "null" : this.Phones.ToString())}");
            toStringOutput.Add($"this.FbId = {(this.FbId == null ? "null" : this.FbId.ToString())}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType == string.Empty ? "" : this.DocumentType)}");
        }
    }
}