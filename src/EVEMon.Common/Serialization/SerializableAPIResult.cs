using System;
using EVEMon.Common.CloudStorageServices;

namespace EVEMon.Common.Serialization
{
    public sealed class SerializableAPIResult<T>
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public T Result { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public SerializableAPIError Error { get; set; }

        /// <summary>
        /// Gets or sets the cache expires.
        /// </summary>
        /// <value>
        /// The cache expires.
        /// </value>
        public DateTime CacheExpires { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has error; otherwise, <c>false</c>.
        /// </value>
        public bool HasError => Error != null;
    }
}