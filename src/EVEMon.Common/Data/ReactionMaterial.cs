using EVEMon.Common.Extensions;
using EVEMon.Common.Serialization.Datafiles;

namespace EVEMon.Common.Data
{
    public sealed class ReactionMaterial : Material
    {
        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="src">The source.</param>
        /// <exception cref="System.ArgumentNullException">src</exception>
        public ReactionMaterial(SerializableReactionInfo src)
            : base(src)
        {
            src.ThrowIfNull(nameof(src));

            IsInput = src.IsInput;
        }

        #endregion


        # region Public Properties

        /// <summary>
        /// Gets a value indicating whether the item is a resource or a product.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is input; otherwise, <c>false</c>.
        /// </value>
        public bool IsInput { get; }

        #endregion

    }
}