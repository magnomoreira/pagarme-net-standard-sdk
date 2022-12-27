// <copyright file="GetBankTransferTransactionResponse.cs" company="APIMatic">
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
    /// GetBankTransferTransactionResponse.
    /// </summary>
    public class GetBankTransferTransactionResponse : GetTransactionResponse
    {
        private DateTime? paidAt;
        private int? paidAmount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "paid_at", false },
            { "paid_amount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBankTransferTransactionResponse"/> class.
        /// </summary>
        public GetBankTransferTransactionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBankTransferTransactionResponse"/> class.
        /// </summary>
        /// <param name="gatewayId">gateway_id.</param>
        /// <param name="amount">amount.</param>
        /// <param name="status">status.</param>
        /// <param name="success">success.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="attemptCount">attempt_count.</param>
        /// <param name="maxAttempts">max_attempts.</param>
        /// <param name="splits">splits.</param>
        /// <param name="nextAttempt">next_attempt.</param>
        /// <param name="transactionType">transaction_type.</param>
        /// <param name="id">id.</param>
        /// <param name="gatewayResponse">gateway_response.</param>
        /// <param name="antifraudResponse">antifraud_response.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="split">split.</param>
        /// <param name="interest">interest.</param>
        /// <param name="fine">fine.</param>
        /// <param name="maxDaysToPayPastDue">max_days_to_pay_past_due.</param>
        /// <param name="url">url.</param>
        /// <param name="bankTid">bank_tid.</param>
        /// <param name="bank">bank.</param>
        /// <param name="paidAt">paid_at.</param>
        /// <param name="paidAmount">paid_amount.</param>
        public GetBankTransferTransactionResponse(
            string gatewayId = null,
            int? amount = null,
            string status = null,
            bool? success = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            int? attemptCount = null,
            int? maxAttempts = null,
            List<Models.GetSplitResponse> splits = null,
            DateTime? nextAttempt = null,
            string transactionType = null,
            string id = null,
            Models.GetGatewayResponseResponse gatewayResponse = null,
            Models.GetAntifraudResponse antifraudResponse = null,
            Dictionary<string, string> metadata = null,
            List<Models.GetSplitResponse> split = null,
            Models.GetInterestResponse interest = null,
            Models.GetFineResponse fine = null,
            int? maxDaysToPayPastDue = null,
            string url = null,
            string bankTid = null,
            string bank = null,
            DateTime? paidAt = null,
            int? paidAmount = null)
            : base(
                gatewayId,
                amount,
                status,
                success,
                createdAt,
                updatedAt,
                attemptCount,
                maxAttempts,
                splits,
                nextAttempt,
                transactionType,
                id,
                gatewayResponse,
                antifraudResponse,
                metadata,
                split,
                interest,
                fine,
                maxDaysToPayPastDue)
        {
            this.Url = url;
            this.BankTid = bankTid;
            this.Bank = bank;
            if (paidAt != null)
            {
                this.PaidAt = paidAt;
            }

            if (paidAmount != null)
            {
                this.PaidAmount = paidAmount;
            }

        }

        /// <summary>
        /// Payment url
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Include)]
        public string Url { get; set; }

        /// <summary>
        /// Transaction identifier for the bank
        /// </summary>
        [JsonProperty("bank_tid", NullValueHandling = NullValueHandling.Include)]
        public string BankTid { get; set; }

        /// <summary>
        /// Bank
        /// </summary>
        [JsonProperty("bank", NullValueHandling = NullValueHandling.Include)]
        public string Bank { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at")]
        public DateTime? PaidAt
        {
            get
            {
                return this.paidAt;
            }

            set
            {
                this.shouldSerialize["paid_at"] = true;
                this.paidAt = value;
            }
        }

        /// <summary>
        /// Paid amount
        /// </summary>
        [JsonProperty("paid_amount")]
        public int? PaidAmount
        {
            get
            {
                return this.paidAmount;
            }

            set
            {
                this.shouldSerialize["paid_amount"] = true;
                this.paidAmount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetBankTransferTransactionResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaidAt()
        {
            this.shouldSerialize["paid_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaidAmount()
        {
            this.shouldSerialize["paid_amount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAt()
        {
            return this.shouldSerialize["paid_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaidAmount()
        {
            return this.shouldSerialize["paid_amount"];
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

            return obj is GetBankTransferTransactionResponse other &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.BankTid == null && other.BankTid == null) || (this.BankTid?.Equals(other.BankTid) == true)) &&
                ((this.Bank == null && other.Bank == null) || (this.Bank?.Equals(other.Bank) == true)) &&
                ((this.PaidAt == null && other.PaidAt == null) || (this.PaidAt?.Equals(other.PaidAt) == true)) &&
                ((this.PaidAmount == null && other.PaidAmount == null) || (this.PaidAmount?.Equals(other.PaidAmount) == true)) &&
                base.Equals(obj);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.BankTid = {(this.BankTid == null ? "null" : this.BankTid == string.Empty ? "" : this.BankTid)}");
            toStringOutput.Add($"this.Bank = {(this.Bank == null ? "null" : this.Bank == string.Empty ? "" : this.Bank)}");
            toStringOutput.Add($"this.PaidAt = {(this.PaidAt == null ? "null" : this.PaidAt.ToString())}");
            toStringOutput.Add($"this.PaidAmount = {(this.PaidAmount == null ? "null" : this.PaidAmount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}