// <copyright file="GetTransferSettingsResponse.cs" company="APIMatic">
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
    /// GetTransferSettingsResponse.
    /// </summary>
    public class GetTransferSettingsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferSettingsResponse"/> class.
        /// </summary>
        public GetTransferSettingsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransferSettingsResponse"/> class.
        /// </summary>
        /// <param name="transferEnabled">transfer_enabled.</param>
        /// <param name="transferInterval">transfer_interval.</param>
        /// <param name="transferDay">transfer_day.</param>
        public GetTransferSettingsResponse(
            bool? transferEnabled = null,
            string transferInterval = null,
            int? transferDay = null)
        {
            this.TransferEnabled = transferEnabled;
            this.TransferInterval = transferInterval;
            this.TransferDay = transferDay;
        }

        /// <summary>
        /// Gets or sets TransferEnabled.
        /// </summary>
        [JsonProperty("transfer_enabled", NullValueHandling = NullValueHandling.Include)]
        public bool? TransferEnabled { get; set; }

        /// <summary>
        /// Gets or sets TransferInterval.
        /// </summary>
        [JsonProperty("transfer_interval", NullValueHandling = NullValueHandling.Include)]
        public string TransferInterval { get; set; }

        /// <summary>
        /// Gets or sets TransferDay.
        /// </summary>
        [JsonProperty("transfer_day", NullValueHandling = NullValueHandling.Include)]
        public int? TransferDay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetTransferSettingsResponse : ({string.Join(", ", toStringOutput)})";
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

            return obj is GetTransferSettingsResponse other &&
                ((this.TransferEnabled == null && other.TransferEnabled == null) || (this.TransferEnabled?.Equals(other.TransferEnabled) == true)) &&
                ((this.TransferInterval == null && other.TransferInterval == null) || (this.TransferInterval?.Equals(other.TransferInterval) == true)) &&
                ((this.TransferDay == null && other.TransferDay == null) || (this.TransferDay?.Equals(other.TransferDay) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransferEnabled = {(this.TransferEnabled == null ? "null" : this.TransferEnabled.ToString())}");
            toStringOutput.Add($"this.TransferInterval = {(this.TransferInterval == null ? "null" : this.TransferInterval == string.Empty ? "" : this.TransferInterval)}");
            toStringOutput.Add($"this.TransferDay = {(this.TransferDay == null ? "null" : this.TransferDay.ToString())}");
        }
    }
}