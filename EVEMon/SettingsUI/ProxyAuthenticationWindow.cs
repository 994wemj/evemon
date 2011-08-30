using System;
using System.Windows.Forms;
using EVEMon.Common.Controls;
using EVEMon.Common.SettingsObjects;

namespace EVEMon.SettingsUI
{
    public partial class ProxyAuthenticationWindow : EVEMonForm
    {
        private readonly ProxySettings m_proxySetting;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="settings"></param>
        public ProxyAuthenticationWindow(ProxySettings settings)
        {
            InitializeComponent();
            m_proxySetting = settings;
            UpdateFields();
        }

        /// <summary>
        /// Updates the fields.
        /// </summary>
        private void UpdateFields()
        {
            if (m_proxySetting == null)
                return;

            switch (m_proxySetting.Authentication)
            {
                case ProxyAuthentication.None:
                    rbNoAuth.Checked = true;
                    break;

                case ProxyAuthentication.SystemDefault:
                    rbSystemDefault.Checked = true;
                    break;

                case ProxyAuthentication.Specified:
                    tbUsername.Text = m_proxySetting.Username;
                    tbPassword.Text = m_proxySetting.Password;
                    rbSuppliedAuth.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the rbSuppliedAuth control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void rbSuppliedAuth_CheckedChanged(object sender, EventArgs e)
        {
            tlpSpecifiedAuth.Enabled = rbSuppliedAuth.Checked;
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Handles the Click event of the btnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rbNoAuth.Checked)
            {
                m_proxySetting.Authentication = ProxyAuthentication.None;
            }
            else if (rbSystemDefault.Checked)
            {
                m_proxySetting.Authentication = ProxyAuthentication.SystemDefault;
            }
            else if (rbSuppliedAuth.Checked)
            {
                m_proxySetting.Authentication = ProxyAuthentication.Specified;
                m_proxySetting.Username = tbUsername.Text;
                m_proxySetting.Password = tbPassword.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}