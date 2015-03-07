﻿using System.Collections.Generic;

namespace EVEMon.Common
{
    public sealed class MedalComparer : IEqualityComparer<Medal>
    {
        /// <summary>
        /// Returns an indication whether the specified medals are equal.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool Equals(Medal x, Medal y)
        {
            // Check whether the compared objects reference the same data
            if (ReferenceEquals(x, y))
                return true;

            // Check whether any of the compared objects is null
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            // Check whether the medals' ids are equal
            return x.ID == y.ID;
        }

        /// <summary>
        /// Returns a hash code for this medal.
        /// </summary>
        /// <param name="obj">The medal.</param>
        /// <returns>
        /// A hash code for this medal, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public int GetHashCode(Medal obj)
        {
            // Get hash code
            return ReferenceEquals(obj, null) ? 0 : obj.ID.GetHashCode();

        }
    }
}