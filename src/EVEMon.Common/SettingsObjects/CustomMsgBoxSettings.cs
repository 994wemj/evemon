using System.Windows.Forms;
using System.Xml.Serialization;

namespace EVEMon.Common.SettingsObjects
{
    public sealed class CustomMsgBoxSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMsgBoxSettings"/> class.
        /// </summary>
        public CustomMsgBoxSettings()
        {
            ShowDialogBox = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show dialog box].
        /// </summary>
        /// <value><c>true</c> if [show dialog box]; otherwise, <c>false</c>.</value>
        [XmlAttribute("showDialogBox")]
        public bool ShowDialogBox { get; set; }

        /// <summary>
        /// Gets or sets the dialog result.
        /// </summary>
        /// <value>The dialog result.</value>
        [XmlAttribute("dialogResult")]
        public DialogResult DialogResult { get; set; }
    }
}