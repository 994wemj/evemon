using System;
using EVEMon.Common.Data;

namespace EVEMon.Common.Controls
{
    /// <summary>
    /// Displays 256 x 256 image of specified EveObject in a separate window.
    /// </summary>
    public partial class EveImagePopUp : EVEMonForm
    {
        private const string TitleBase = "EVEMon Image Viewer";
        private readonly Item m_imageSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="EveImagePopUp"/> class.
        /// </summary>
        /// <param name="imageSource">The image source.</param>
        public EveImagePopUp(Item imageSource)
        {
            InitializeComponent();
            m_imageSource = imageSource;
        }

        /// <summary>
        /// On load, restores the window rectangle from the settings.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = TitleBase;

            if (m_imageSource == null)
                return;

            // Set window title
            Text = String.Format(CultureConstants.DefaultCulture, "{0} - {1}", m_imageSource.Name, TitleBase);
            eveImage.EveItem = m_imageSource;
        }
    }
}