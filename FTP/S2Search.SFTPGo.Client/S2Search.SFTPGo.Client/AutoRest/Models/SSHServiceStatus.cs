// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SSHServiceStatus
    {
        /// <summary>
        /// Initializes a new instance of the SSHServiceStatus class.
        /// </summary>
        public SSHServiceStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSHServiceStatus class.
        /// </summary>
        public SSHServiceStatus(bool? isActive = default(bool?), IList<SSHBinding> bindings = default(IList<SSHBinding>), IList<SSHHostKey> hostKeys = default(IList<SSHHostKey>), IList<string> sshCommands = default(IList<string>))
        {
            IsActive = isActive;
            Bindings = bindings;
            HostKeys = hostKeys;
            SshCommands = sshCommands;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bindings")]
        public IList<SSHBinding> Bindings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_keys")]
        public IList<SSHHostKey> HostKeys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssh_commands")]
        public IList<string> SshCommands { get; set; }

    }
}