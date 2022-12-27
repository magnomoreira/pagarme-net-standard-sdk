// <copyright file="ListInvoicesResponse.cs" company="APIMatic">
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
    /// ListInvoicesResponse.
    /// </summary>
    public class ListInvoicesResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoicesResponse"/> class.
        /// </summary>
        public ListInvoicesResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListInvoicesResponse"/> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="paging">paging.</param>
        public ListInvoicesResponse(
            List<Models.GetInvoiceResponse> data = null,
            Models.PagingResponse paging = null)
        {
            this.Data = data;
            this.Paging = paging;
        }

        /// <summary>
        /// The Invoice objects
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Include)]
        public List<Models.GetInvoiceResponse> Data { get; set; }

        /// <summary>
        /// Paging object
        /// </summary>
        [JsonProperty("paging", NullValueHandling = NullValueHandling.Include)]
        public Models.PagingResponse Paging { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListInvoicesResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is ListInvoicesResponse other &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Paging == null && other.Paging == null) || (this.Paging?.Equals(other.Paging) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Paging = {(this.Paging == null ? "null" : this.Paging.ToString())}");
        }
    }
}