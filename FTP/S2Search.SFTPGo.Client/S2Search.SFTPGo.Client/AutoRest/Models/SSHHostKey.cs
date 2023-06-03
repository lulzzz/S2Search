// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SSHHostKey
    {
        /// <summary>
        /// Initializes a new instance of the SSHHostKey class.
        /// </summary>
        public SSHHostKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSHHostKey class.
        /// </summary>
        public SSHHostKey(string path = default(string), string fingerprint = default(string))
        {
            Path = path;
            Fingerprint = fingerprint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        public string Fingerprint { get; set; }

    }
}