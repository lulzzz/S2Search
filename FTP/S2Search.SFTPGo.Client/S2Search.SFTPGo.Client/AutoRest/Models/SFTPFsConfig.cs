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

    public partial class SFTPFsConfig
    {
        /// <summary>
        /// Initializes a new instance of the SFTPFsConfig class.
        /// </summary>
        public SFTPFsConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SFTPFsConfig class.
        /// </summary>
        /// <param name="endpoint">remote SFTP endpoint as host:port</param>
        /// <param name="username">you can specify a password or private key or
        /// both. In the latter case the private key will be tried
        /// first.</param>
        /// <param name="fingerprints">SHA256 fingerprints to use for host key
        /// verification. If you don't provide any fingerprint the remote host
        /// key will not be verified, this is a security risk</param>
        /// <param name="prefix">Specifying a prefix you can restrict all
        /// operations to a given path within the remote SFTP server.</param>
        public SFTPFsConfig(string endpoint = default(string), string username = default(string), Secret password = default(Secret), Secret privateKey = default(Secret), IList<string> fingerprints = default(IList<string>), string prefix = default(string))
        {
            Endpoint = endpoint;
            Username = username;
            Password = password;
            PrivateKey = privateKey;
            Fingerprints = fingerprints;
            Prefix = prefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets remote SFTP endpoint as host:port
        /// </summary>
        [JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets you can specify a password or private key or both. In
        /// the latter case the private key will be tried first.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public Secret Password { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "private_key")]
        public Secret PrivateKey { get; set; }

        /// <summary>
        /// Gets or sets SHA256 fingerprints to use for host key verification.
        /// If you don't provide any fingerprint the remote host key will not
        /// be verified, this is a security risk
        /// </summary>
        [JsonProperty(PropertyName = "fingerprints")]
        public IList<string> Fingerprints { get; set; }

        /// <summary>
        /// Gets or sets specifying a prefix you can restrict all operations to
        /// a given path within the remote SFTP server.
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

    }
}