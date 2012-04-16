﻿using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.API
{
    public sealed class SerializableAPIWalletJournal
    {
        private readonly Collection<SerializableWalletJournalListItem> m_walletJournal;

        public SerializableAPIWalletJournal()
        {
            m_walletJournal = new Collection<SerializableWalletJournalListItem>();
        }

        [XmlArray("transactions")]
        [XmlArrayItem("transaction")]
        public Collection<SerializableWalletJournalListItem> WalletJournal
        {
            get { return m_walletJournal; }
        }

    }
}
