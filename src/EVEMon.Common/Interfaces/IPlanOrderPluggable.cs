using System;
using System.Threading.Tasks;
using EVEMon.Common.Models;

namespace EVEMon.Common.Interfaces
{
    /// <summary>
    /// Provides a way for implant calculator and attributes optimization form to add a column showing the training time difference.
    /// </summary>
    public interface IPlanOrderPluggable
    {
        /// <summary>
        /// Occurs when [disposed].
        /// </summary>
        event EventHandler Disposed;

        /// <summary>
        /// Updates the statistics.
        /// </summary>
        /// <param name="plan">The plan.</param>
        /// <param name="areRemappingPointsActive">if set to <c>true</c> [are remapping points active].</param>
        void UpdateStatistics(BasePlan plan, out bool areRemappingPointsActive);

        /// <summary>
        /// Updates the on implant set change.
        /// </summary>
        /// <returns></returns>
        Task UpdateOnImplantSetChange();
    }
}