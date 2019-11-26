// Date :    2017- 09-14
// Author : Harvey Hu
// -----------------------------------------------------------------------
// <copyright file="UsageSummaryModel.cs" company="Microsoft">
//     Microsoft@2017.
// </copyright>
// -----------------------------------------------------------------------

namespace azcnBillingDemo
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    ///     class of usage Summary Model
    /// </summary>
    public class UsageSummaryModel
    {
        /// <summary>
        ///     Gets or sets the billing amount.
        /// </summary>
        /// <value>
        ///     The billing amount.
        /// </value>
        [DataMember]
        [JsonProperty("Amount")]
        public string Amount { get; set; }

        /// <summary>
        ///     Gets or sets the azure service commitment of billing summary.
        /// </summary>
        /// <value>
        ///     The azure service commitment of billing summary.
        /// </value>
        [DataMember]
        [JsonProperty("Azure Service Commitment")]
        public string AzureServiceCommitment { get; set; }

        /// <summary>
        ///     Gets or sets the currency code of billing.
        /// </summary>
        /// <value>
        ///     The currency code of billing.
        /// </value>
        [DataMember]
        [JsonProperty("Currency Code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the month of billing date.
        /// </summary>
        /// <value>
        ///     The month of billing date.
        /// </value>
        [DataMember]
        public DateTime Month { get; set; }
    }
}