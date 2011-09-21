﻿using System.Xml.Serialization;

namespace EVEMon.Common.SettingsObjects
{
    public sealed class TrayTooltipSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrayTooltipSettings"/> class.
        /// </summary>
        public TrayTooltipSettings()
        {
            Format = "%n - %s %tr - %r";
        }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        /// <value>The format.</value>
        [XmlElement("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [display order].
        /// </summary>
        /// <value><c>true</c> if [display order]; otherwise, <c>false</c>.</value>
        [XmlElement("DisplayOrder")]
        public bool DisplayOrder { get; set; }
    }
}