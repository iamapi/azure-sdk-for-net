// Code generated by Microsoft (R) AutoRest Code Generator 1.2.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ContainerInstance;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The logs.
    /// </summary>
    public partial class Logs
    {
        /// <summary>
        /// Initializes a new instance of the Logs class.
        /// </summary>
        public Logs()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Logs class.
        /// </summary>
        /// <param name="content">content of the log.</param>
        public Logs(string content = default(string))
        {
            Content = content;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets content of the log.
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

    }
}