namespace Scheduler.Resources
{
    /// <summary>
    /// 
    /// </summary>
    public class FrameworkID
    {
        public string Value { get; set; }
    }

    /// <summary>
    /// Represents information about the framework.
    /// </summary>
    public class FrameworkInformation
    {
        public class Capability
        {
            public enum CapabilityType
            {
                EVOCABLE_RESOURCES = 1
            }

            public CapabilityType Type { get; set; }
        }
        
        
        /// <summary>
        /// </summary>
		public string User { get; set; }

        /// <summary>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [OPTIONAL]
        /// </summary>
        public FrameworkID ID { get; set; }

        /// <summary>
        /// [OPTIONAL] 
        /// </summary>
        public double FailoverTimeout { get; set; }

        /// <summary>
        /// [OPTIONAL]
        /// </summary>
        public bool Checkpoint { get; set; }

        /// <summary>
        /// [OPTIONAL] 
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// [OPTIONAL]
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// [OPTIONAL]
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// [OPTIONAL]
        /// </summary>
        public string WebUiUrl { get; set; }

        /// <summary>
        /// [OPTIONAL]
        /// </summary>
        public Capability[] Capabilities { get; set; }

        /// <summary>
        /// Initialises a new instance of the FrameworkInformation class. 
        /// </summary>
        public FrameworkInformation()
        {
            FailoverTimeout = 0D;
            Checkpoint = false;
            Role = "*";
        }
    }
}