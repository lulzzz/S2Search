// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.CustomerResourceApi.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateUserStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdateUserStatusRequest class.
        /// </summary>
        public UpdateUserStatusRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateUserStatusRequest class.
        /// </summary>
        public UpdateUserStatusRequest(System.Guid? searchIndexId = default(System.Guid?), string username = default(string), bool? status = default(bool?))
        {
            SearchIndexId = searchIndexId;
            Username = username;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchIndexId")]
        public System.Guid? SearchIndexId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public bool? Status { get; set; }

    }
}
