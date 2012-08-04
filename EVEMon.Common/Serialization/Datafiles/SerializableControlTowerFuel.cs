using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.Datafiles
{
    public sealed class SerializableControlTowerFuel : SerializableMaterialQuantity
    {
        /// <summary>
        /// Gets or sets the purpose.
        /// </summary>
        /// <value>
        /// The purpose.
        /// </value>
        [XmlAttribute("purpose")]
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the min security level.
        /// </summary>
        /// <value>
        /// The min security level.
        /// </value>
        [XmlAttribute("minSecurityLevel")]
        public string MinSecurityLevel { get; set; }

        /// <summary>
        /// Gets or sets the faction ID.
        /// </summary>
        /// <value>
        /// The faction ID.
        /// </value>
        [XmlAttribute("factionID")]
        public string FactionID { get; set; }

        /// <summary>
        /// Gets or sets the faction name.
        /// </summary>
        /// <value>
        /// The faction name.
        /// </value>
        [XmlAttribute("factionName")]
        public string FactionName { get; set; }
    }
}