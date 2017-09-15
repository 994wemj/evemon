using EVEMon.Common.Extensions;
using EVEMon.Common.Serialization.Datafiles;

namespace EVEMon.Common.Data
{
    public sealed class ControlTowerFuel : Material
    {
        # region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <exception cref="System.ArgumentNullException">src</exception>
        public ControlTowerFuel(SerializableControlTowerFuel src)
            : base(src)
        {
            src.ThrowIfNull(nameof(src));

            Purpose = src.Purpose;
            MinSecurityLevel = src.MinSecurityLevel;
            FactionName = src.FactionName;
        }

        #endregion


        # region Public Properties

        /// <summary>
        /// Gets the purpose.
        /// </summary>
        public string Purpose { get; private set; }

        /// <summary>
        /// Gets the min security level.
        /// </summary>
        public string MinSecurityLevel { get; private set; }

        /// <summary>
        /// Gets the name of the faction.
        /// </summary>
        /// <value>
        /// The name of the faction.
        /// </value>
        public string FactionName { get; private set; }

        #endregion
    }
}