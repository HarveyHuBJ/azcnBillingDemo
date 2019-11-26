// Date :    2017- 09-14
// Author : Harvey Hu
// -----------------------------------------------------------------------
// <copyright file="PriceSheetModel.cs" company="Microsoft">
//     Microsoft@2017.
// </copyright>
// -----------------------------------------------------------------------

namespace azcnBillingDemo
{
    using Newtonsoft.Json;
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    ///     class of price sheet model
    /// </summary>
    public class PriceSheetModel
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        /// <value>
        /// The service.
        /// </value>
        [DataMember]
        [JsonProperty("Service")]
        public string Service { get; set; }

        /// <summary>
        /// Gets or sets the unit of measure.
        /// </summary>
        /// <value>
        /// The unit of measure.
        /// </value>
        [DataMember]
        [JsonProperty("UnitOfMeasure")]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        /// Gets or sets the part number.
        /// </summary>
        /// <value>
        /// The part number.
        /// </value>
        [DataMember]
        [JsonProperty("PartNumber")]
        public string PartNumber { get; set; }

        /// <summary>
        /// Gets or sets the unit price.
        /// </summary>
        /// <value>
        /// The unit price.
        /// </value>
        [DataMember]
        [JsonProperty("UnitPrice")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        [DataMember]
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [DataMember]
        public DateTime Date { get; set; }
    }
}