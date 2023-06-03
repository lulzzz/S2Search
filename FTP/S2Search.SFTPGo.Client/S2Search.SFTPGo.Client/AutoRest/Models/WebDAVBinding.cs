// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebDAVBinding
    {
        /// <summary>
        /// Initializes a new instance of the WebDAVBinding class.
        /// </summary>
        public WebDAVBinding()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebDAVBinding class.
        /// </summary>
        /// <param name="address">TCP address the server listen on</param>
        /// <param name="port">the port used for serving requests</param>
        /// <param name="clientAuthType">1 means that client certificate
        /// authentication is required in addition to HTTP basic
        /// authentication</param>
        public WebDAVBinding(string address = default(string), int? port = default(int?), bool? enableHttps = default(bool?), int? clientAuthType = default(int?))
        {
            Address = address;
            Port = port;
            EnableHttps = enableHttps;
            ClientAuthType = clientAuthType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets TCP address the server listen on
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the port used for serving requests
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int? Port { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable_https")]
        public bool? EnableHttps { get; set; }

        /// <summary>
        /// Gets or sets 1 means that client certificate authentication is
        /// required in addition to HTTP basic authentication
        /// </summary>
        [JsonProperty(PropertyName = "client_auth_type")]
        public int? ClientAuthType { get; set; }

    }
}