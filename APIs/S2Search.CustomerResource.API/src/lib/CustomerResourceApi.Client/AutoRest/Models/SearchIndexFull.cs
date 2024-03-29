// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.CustomerResourceApi.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SearchIndexFull
    {
        /// <summary>
        /// Initializes a new instance of the SearchIndexFull class.
        /// </summary>
        public SearchIndexFull()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchIndexFull class.
        /// </summary>
        public SearchIndexFull(SearchIndex searchIndex = default(SearchIndex), Feed feed = default(Feed), IList<NotificationRule> notificationsRules = default(IList<NotificationRule>), IList<Synonym> synonyms = default(IList<Synonym>), SearchInterface searchInterface = default(SearchInterface))
        {
            SearchIndex = searchIndex;
            Feed = feed;
            NotificationsRules = notificationsRules;
            Synonyms = synonyms;
            SearchInterface = searchInterface;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchIndex")]
        public SearchIndex SearchIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feed")]
        public Feed Feed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notificationsRules")]
        public IList<NotificationRule> NotificationsRules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "synonyms")]
        public IList<Synonym> Synonyms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchInterface")]
        public SearchInterface SearchInterface { get; set; }

    }
}
