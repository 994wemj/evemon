﻿using System.Collections.ObjectModel;
using System.Xml.Serialization;
using EVEMon.Common.Serialization.Settings;

namespace EVEMon.Common.SettingsObjects
{
    public sealed class PortableEveInstallationsSettings
    {
        private readonly Collection<SerializablePortableEveInstallation> m_eveClients;

        public PortableEveInstallationsSettings()
        {
            m_eveClients = new Collection<SerializablePortableEveInstallation>(); 
        }

        /// <summary>
        /// Gets the portable eve client installations.
        /// </summary>
        [XmlArray("eveClientInstallations")]
        [XmlArrayItem("eveClientInstallation")]
        public Collection<SerializablePortableEveInstallation> EVEClients => m_eveClients;
    }
}
