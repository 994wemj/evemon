using System.Collections.Generic;

namespace EVEMon.Common
{
    public sealed class PlanEntryComparer : IEqualityComparer<PlanEntry>
    {
        /// <summary>
        /// Returns an indication whether the specified entries are equal.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public bool Equals(PlanEntry x, PlanEntry y)
        {
            // Check whether the compared objects reference the same data
            if (ReferenceEquals(x, y))
                return true;

            // Check whether any of the compared objects is null
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;

            // Check whether the entries' properties are equal
            return x.Skill == y.Skill;
        }

        /// <summary>
        /// Returns a hash code for this entry.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <returns>
        /// A hash code for this entry, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public int GetHashCode(PlanEntry entry)
        {
            // Check whether the entry is null
            if (ReferenceEquals(entry, null))
                return 0;

            // Get hash code for the entry's skill, if it is not null
            return entry.Skill == null ? 0 : entry.Skill.GetHashCode();
        }

    }
}