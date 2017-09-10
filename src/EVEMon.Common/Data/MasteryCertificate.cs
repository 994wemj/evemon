using System.Linq;
using EVEMon.Common.Extensions;
using EVEMon.Common.Models;
using EVEMon.Common.Serialization.Datafiles;

namespace EVEMon.Common.Data
{
    /// <summary>
    /// Represents a mastery certificate.
    /// </summary>
    public sealed class MasteryCertificate
    {

        #region Constructor

        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        /// <param name="masteryLevel">The mastery level.</param>
        /// <param name="src">The source.</param>
        internal MasteryCertificate(Mastery masteryLevel, SerializableMasteryCertificate src)
        {
            MasteryLevel = masteryLevel;
            Certificate = StaticCertificates.GetCertificateByID(src.ID);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MasteryCertificate"/> class.
        /// </summary>
        /// <param name="character">The character.</param>
        /// <param name="masteryCertificate">The mastery certificate.</param>
        internal MasteryCertificate(Character character, MasteryCertificate masteryCertificate)
        {
            if (masteryCertificate == null)
                return;

            MasteryLevel = masteryCertificate.MasteryLevel;
            Certificate = masteryCertificate.ToCharacter(character);
        }

        #endregion


        #region Public Properties

        /// <summary>
        /// Gets the mastery level.
        /// </summary>
        public Mastery MasteryLevel { get; }

        /// <summary>
        /// Gets or sets the certificate.
        /// </summary>
        public StaticCertificate Certificate { get; }

        /// <summary>
        /// Gets this certificate's representation for the provided character.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">character</exception>
        public Certificate ToCharacter(Character character)
        {
            character.ThrowIfNull(nameof(character));

            return character.Certificates.FirstOrDefault(x => x.ID == Certificate.ID);
        }

        #endregion

    }
}