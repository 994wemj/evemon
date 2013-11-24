﻿using System;
using EVEMon.Common.Attributes;

namespace EVEMon.Common.Notifications
{
    /// <summary>
    /// Represents the categories a <see cref="NotificationEventArgs"/> can have.
    /// </summary>
    public enum NotificationCategory
    {
        /// <summary>
        /// An API key is to expire.
        /// </summary>
        [Header("API key expiration")]
        APIKeyExpiration,
        
        /// <summary>
        /// An account is to expire.
        /// </summary>
        [Header("Account expiration")]
        AccountExpiration,

        /// <summary>
        /// None of the characters are currently in training.
        /// </summary>
        [Header("Account is not training")]
        AccountNotInTraining,

        /// <summary>
        /// A skill training has been completed.
        /// </summary>
        [Header("Skill completion")]
        SkillCompletion,

        /// <summary>
        /// Skill queue has room for more skills.
        /// </summary>
        [Header("Skill queue room availability")]
        SkillQueueRoomAvailable,

        /// <summary>
        /// A certificate is claimable.
        /// </summary>
        [Obsolete]
        ClaimableCertificate,

        /// <summary>
        /// A character has not enough balance to fulfill its buy orders.
        /// </summary>
        [Header("Insufficient balance")]
        InsufficientBalance,

        /// <summary>
        /// A character has not enough skill points on his clone.
        /// </summary>
        [Header("Insufficient clone")]
        InsufficientClone,

        /// <summary>
        /// An error occurred while the querying of the API.
        /// </summary>
        [Header("API problem")]
        QueryingError,

        /// <summary>
        /// The status of EVE server changed.
        /// </summary>
        [Header("EVE server status change")]
        ServerStatusChange,

        /// <summary>
        /// The IGB service has a problem.
        /// </summary>
        [Header("IGB service problem")]
        IgbServiceException,

        /// <summary>
        /// Some orders expired since the last time.
        /// </summary>
        [Header("Market orders expired/fulfilled")]
        MarketOrdersEnding,

        /// <summary>
        /// Some contracts expired since the last time.
        /// </summary>
        [Header("Contracts expired/fulfilled")]
        ContractsEnded,

        /// <summary>
        /// Some contracts are assigned to the character.
        /// </summary>
        [Header("Contracts assigned")]
        ContractsAssigned,

        /// <summary>
        /// An industry job has been completed.
        /// </summary>
        [Header("Industry jobs completion")]
        IndustryJobsCompletion,

        /// <summary>
        /// A new EVE mail message is available.
        /// </summary>
        [Header("New EVE mail message")]
        NewEveMailMessage,

        /// <summary>
        /// A new EVE notification is available.
        /// </summary>
        [Header("New EVE notification")]
        NewEveNotification,

        /// <summary>
        /// Testing notification.
        /// </summary>
        [Header("Test Notification")]
        TestNofitication,
    }
}