namespace MWWMWeatherApp.Model {
    /// <summary>
    /// Set of and ID and LocalizedName
    /// </summary>
    public class Area {

        /// <summary>
        /// Unique identification number for the Area
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Area's common name
        /// </summary>
        public string LocalizedName { get; set; }
    }

    /// <summary>
    /// Represents a single City
    /// </summary>
    public class City {

        /// <summary>
        /// Unique ID for json requests
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// City's common name
        /// </summary>
        public string LocalizedName { get; set; }

        /// <summary>
        /// City's country
        /// </summary>
        public Area Country { get; set; }

        /// <summary>
        /// City's AdministrativeArea
        /// </summary>
        public Area AdministrativeArea { get; set; }
    }
}

