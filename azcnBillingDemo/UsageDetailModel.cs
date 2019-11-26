// Date :    2017- 09-14
// Author : Harvey Hu
// -----------------------------------------------------------------------
// <copyright file="UsageDetailModel.cs" company="Microsoft">
//     Microsoft@2017.
// </copyright>
// -----------------------------------------------------------------------

namespace azcnBillingDemo
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    ///     class of usage detail model
    /// </summary>
    public class UsageDetailModel
    {
        /// <summary>
        ///     Gets or sets the owner account name.
        /// </summary>
        /// <value>
        ///     The owner account name.
        /// </value>
        [DataMember]
        public string AccountName { get; set; }

        /// <summary>
        ///     Gets or sets the owner account.
        /// </summary>
        /// <value>
        ///     The owner account.
        /// </value>
        [DataMember]
        public string AccountOwnerId { get; set; }

        /// <summary>
        ///     Gets or sets the consumed quantity.
        /// </summary>
        /// <value>
        ///     The consumed quantity.
        /// </value>
        [DataMember]
        public decimal ConsumedQuantity { get; set; }

        /// <summary>
        ///     Gets or sets the billed service.
        /// </summary>
        /// <value>
        ///     The billed service.
        /// </value>
        [DataMember]
        public string ConsumedService { get; set; }

        /// <summary>
        ///     Gets or sets the billing detail date.
        /// </summary>
        /// <value>
        ///     The billing detail date.
        /// </value>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        ///     Gets or sets the day of billing detail date.
        /// </summary>
        /// <value>
        ///     The day of billing detail date.
        /// </value>
        [DataMember]
        public int Day { get; set; }

        /// <summary>
        ///     Gets or sets the cost of billing.
        /// </summary>
        /// <value>
        ///     The cost of billing.
        /// </value>
        [DataMember]
        public decimal ExtendedCost { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the instance of billing.
        /// </summary>
        /// <value>
        ///     The instance of billing.
        /// </value>
        [DataMember]
        public string InstanceId { get; set; }

        /// <summary>
        ///     Gets or sets the meter category.
        /// </summary>
        /// <value>
        ///     The meter category.
        /// </value>
        [DataMember]
        public string MeterCategory { get; set; }

        /// <summary>
        ///     Gets or sets the meter identifier.
        /// </summary>
        /// <value>
        ///     The meter identifier.
        /// </value>
        [DataMember]
        public Guid MeterId { get; set; }

        /// <summary>
        ///     Gets or sets the meter name.
        /// </summary>
        /// <value>
        ///     The meter name.
        /// </value>
        [DataMember]
        public string MeterName { get; set; }

        /// <summary>
        ///     Gets or sets the region of meter.
        /// </summary>
        /// <value>
        ///     The region of meter.
        /// </value>
        [DataMember]
        public string MeterRegion { get; set; }

        /// <summary>
        ///     Gets or sets the sub category of meter.
        /// </summary>
        /// <value>
        ///     The sub category of meter.
        /// </value>
        [DataMember]
        public string MeterSubCategory { get; set; }

        /// <summary>
        ///     Gets or sets the month of billing detail date.
        /// </summary>
        /// <value>
        ///     The month of billing detail date.
        /// </value>
        [DataMember]
        public int Month { get; set; }

        /// <summary>
        ///     Gets or sets the subscription product name.
        /// </summary>
        /// <value>
        ///     The subscription product name.
        /// </value>
        [DataMember]
        public string Product { get; set; }

        /// <summary>
        ///     Gets or sets the resource group.
        /// </summary>
        /// <value>
        ///     The year of the resource group.
        /// </value>
        [DataMember]
        public string ResourceGroup { get; set; }

        /// <summary>
        ///     Gets or sets the rate of usage.
        /// </summary>
        /// <value>
        ///     The rate of usage.
        /// </value>
        [DataMember]
        public decimal ResourceRate { get; set; }

        /// <summary>
        ///     Gets or sets the subscription guid.
        /// </summary>
        /// <value>
        ///     The subscription guid.
        /// </value>
        [DataMember]
        public Guid SubscriptionGuid { get; set; }

        /// <summary>
        ///     Gets or sets the subscription id.
        /// </summary>
        /// <value>
        ///     The subscription id.
        /// </value>
        [DataMember]
        public long SubscriptionId { get; set; }

        /// <summary>
        ///     Gets or sets the subscription name.
        /// </summary>
        /// <value>
        ///     The subscription name.
        /// </value>
        [DataMember]
        public string SubscriptionName { get; set; }

        /// <summary>
        ///     Gets or sets the billing unit.
        /// </summary>
        /// <value>
        ///     The billing unit.
        /// </value>
        [DataMember]
        public string UnitOfMeasure { get; set; }

        /// <summary>
        ///     Gets or sets the year of billing detail date.
        /// </summary>
        /// <value>
        ///     The year of billing detail date.
        /// </value>
        [DataMember]
        public int Year { get; set; }
    }
}