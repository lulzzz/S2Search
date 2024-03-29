// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.CustomerResourceApi.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Feed
    {
        /// <summary>
        /// Initializes a new instance of the Feed class.
        /// </summary>
        public Feed()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Feed class.
        /// </summary>
        public Feed(int? feedId = default(int?), int? type = default(int?), string scheduleCron = default(string), System.Guid? searchIndexId = default(System.Guid?), System.DateTime? createdDate = default(System.DateTime?), System.DateTime? supersededDate = default(System.DateTime?), string scheduleFriendlyDescription = default(string), bool? isLatest = default(bool?))
        {
            FeedId = feedId;
            Type = type;
            ScheduleCron = scheduleCron;
            SearchIndexId = searchIndexId;
            CreatedDate = createdDate;
            SupersededDate = supersededDate;
            ScheduleFriendlyDescription = scheduleFriendlyDescription;
            IsLatest = isLatest;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedId")]
        public int? FeedId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduleCron")]
        public string ScheduleCron { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchIndexId")]
        public System.Guid? SearchIndexId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supersededDate")]
        public System.DateTime? SupersededDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheduleFriendlyDescription")]
        public string ScheduleFriendlyDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isLatest")]
        public bool? IsLatest { get; set; }

    }
}
