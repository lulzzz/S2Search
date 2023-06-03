// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ScoreStatus
    {
        /// <summary>
        /// Initializes a new instance of the ScoreStatus class.
        /// </summary>
        public ScoreStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScoreStatus class.
        /// </summary>
        /// <param name="score">if 0 the host is not listed</param>
        public ScoreStatus(int? score = default(int?))
        {
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if 0 the host is not listed
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public int? Score { get; set; }

    }
}