using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.Eve
{
    /// <summary>
    /// CCP API error message handling - for application error messages within the xml.
    /// </summary>
    [XmlRoot("error")]
    public sealed class APICCPError
    {
        /// <summary>
        /// If this is non 0 then an error has occurred
        /// </summary>
        /// <value>105</value> Invalid character id
        /// <value>201</value> Character does not belong to account
        /// <value>202</value> Invalid API key
        /// <value>""</value> or <value>null</value> when the operation was successful (will be one of 5 values - "characterID", "TryAgainIn", "currentTimeTQOffset" and "currentTime"
        /// This is the variable that needs checking to see if the thing has worked.
        [XmlAttribute("code")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// If this is non 0 length or not null then an error has occurred and will this will be the only value in the entire class other than "current time
        /// </summary>
        /// <value>"Invalid characterID."</value>
        /// <value>"Authentication Failure."</value>
        /// <value>"Cached API key authentication failure"</value>
        /// <value>"Character does not belong to account"</value>
        /// <value>""</value> or <value>null</value> when the operation was successful (will be one of 5 values - "characterID", "TryAgainIn", "currentTimeTQOffset" and "currentTime"
        [XmlText]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets true when character has no corporation roles.
        /// </summary>
        [XmlIgnore]
        public bool IsCorpRolesError
        {
            get { return (ErrorCode >= 206 && ErrorCode <= 209) || ErrorCode == 213; }
        }

        /// <summary>
        /// Gets true when character has exhausted kill log.
        /// </summary>
        [XmlIgnore]
        public bool IsKillLogExhaustedError
        {
            get { return ErrorCode == 119; }
        }

        /// <summary>
        /// Gets true when character is not enlisted in factional warfare.
        /// </summary>
        [XmlIgnore]
        public bool IsFactionalWarfareEnlistedError
        {
            get { return ErrorCode == 124; }
        }

        /// <summary>
        /// Gets true when there is an unexpected failure accessing the database.
        /// </summary>
        [XmlIgnore]
        public bool IsUnexpectedDatabaseFailure
        {
            get { return ErrorCode == 520; }
        }

        /// <summary>
        /// Gets true when EVE backend database is temporarily disabled.
        /// </summary>
        [XmlIgnore]
        public bool IsEVEBackendDatabaseDisabled
        {
            get { return ErrorCode == 901; }
        }

        /// <summary>
        /// Gets true when web site database is temporarily disabled.
        /// </summary>
        [XmlIgnore]
        public bool IsWebSiteDatabaseDisabled
        {
            get { return ErrorCode == 902; }
        }

        /// <summary>
        /// Gets true when the API credentials are wrong.
        /// </summary>
        [XmlIgnore]
        public bool IsAuthenticationFailure
        {
            get { return ErrorCode == 203; }
        }

        /// <summary>
        /// Gets true when the account subscription has expired.
        /// </summary>
        [XmlIgnore]
        public bool IsLoginDeniedByAccountStatus
        {
            get { return ErrorCode == 211; }
        }

        /// <summary>
        /// Gets true when the API key has expired.
        /// </summary>
        [XmlIgnore]
        public bool IsAPIKeyExpired
        {
            get { return ErrorCode == 222; }
        }

        /// <summary>
        /// Gets true when getting character information fails.
        /// </summary>
        [XmlIgnore]
        public bool IsCharacterInfoFailure
        {
            get { return ErrorCode == 522; }
        }

        /// <summary>
        /// Gets true when getting corporation information fails.
        /// </summary>
        [XmlIgnore]
        public bool IsCorporationInfoFailure
        {
            get { return ErrorCode == 523; }
        }
    }
}