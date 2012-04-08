﻿using EVEMon.Common;
using EVEMon.Common.Controls;

namespace EVEMon.SettingsUI
{
    partial class SettingsFileStorageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alwaysDownloadCheckBox = new System.Windows.Forms.CheckBox();
            this.alwaysUploadCheckBox = new System.Windows.Forms.CheckBox();
            this.downloadSettingsFileButton = new System.Windows.Forms.Button();
            this.uploadSettingsFileButton = new System.Windows.Forms.Button();
            this.apiResponseLabel = new System.Windows.Forms.Label();
            this.useImmediatelyCheckBox = new System.Windows.Forms.CheckBox();
            this.throbber = new EVEMon.Common.Controls.Throbber();
            ((System.ComponentModel.ISupportInitialize)(this.throbber)).BeginInit();
            this.SuspendLayout();
            // 
            // alwaysDownloadCheckBox
            // 
            this.alwaysDownloadCheckBox.AutoSize = true;
            this.alwaysDownloadCheckBox.Location = new System.Drawing.Point(166, 69);
            this.alwaysDownloadCheckBox.Name = "alwaysDownloadCheckBox";
            this.alwaysDownloadCheckBox.Size = new System.Drawing.Size(213, 17);
            this.alwaysDownloadCheckBox.TabIndex = 7;
            this.alwaysDownloadCheckBox.Text = "Always download when EVEMon starts.";
            this.alwaysDownloadCheckBox.UseVisualStyleBackColor = true;
            this.alwaysDownloadCheckBox.CheckedChanged += new System.EventHandler(this.alwaysDownloadCheckBox_CheckedChanged);
            // 
            // alwaysUploadCheckBox
            // 
            this.alwaysUploadCheckBox.AutoSize = true;
            this.alwaysUploadCheckBox.Location = new System.Drawing.Point(166, 7);
            this.alwaysUploadCheckBox.Name = "alwaysUploadCheckBox";
            this.alwaysUploadCheckBox.Size = new System.Drawing.Size(208, 17);
            this.alwaysUploadCheckBox.TabIndex = 6;
            this.alwaysUploadCheckBox.Text = "Always upload before EVEMon closes.";
            this.alwaysUploadCheckBox.UseVisualStyleBackColor = true;
            this.alwaysUploadCheckBox.CheckedChanged += new System.EventHandler(this.alwaysUploadCheckBox_CheckedChanged);
            // 
            // downloadSettingsFileButton
            // 
            this.downloadSettingsFileButton.Location = new System.Drawing.Point(25, 65);
            this.downloadSettingsFileButton.Name = "downloadSettingsFileButton";
            this.downloadSettingsFileButton.Size = new System.Drawing.Size(122, 23);
            this.downloadSettingsFileButton.TabIndex = 5;
            this.downloadSettingsFileButton.Text = "Download settings file";
            this.downloadSettingsFileButton.UseVisualStyleBackColor = true;
            this.downloadSettingsFileButton.Click += new System.EventHandler(this.downloadSettingsFileButton_Click);
            // 
            // uploadSettingsFileButton
            // 
            this.uploadSettingsFileButton.Location = new System.Drawing.Point(25, 3);
            this.uploadSettingsFileButton.Name = "uploadSettingsFileButton";
            this.uploadSettingsFileButton.Size = new System.Drawing.Size(122, 23);
            this.uploadSettingsFileButton.TabIndex = 4;
            this.uploadSettingsFileButton.Text = "Upload settings file";
            this.uploadSettingsFileButton.UseVisualStyleBackColor = true;
            this.uploadSettingsFileButton.Click += new System.EventHandler(this.uploadSettingsFileButton_Click);
            // 
            // apiResponseLabel
            // 
            this.apiResponseLabel.Location = new System.Drawing.Point(0, 30);
            this.apiResponseLabel.Name = "apiResponseLabel";
            this.apiResponseLabel.Size = new System.Drawing.Size(405, 31);
            this.apiResponseLabel.TabIndex = 8;
            this.apiResponseLabel.Text = "BattleClinic\r\nAPI Response";
            this.apiResponseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // useImmediatelyCheckBox
            // 
            this.useImmediatelyCheckBox.AutoSize = true;
            this.useImmediatelyCheckBox.Location = new System.Drawing.Point(185, 89);
            this.useImmediatelyCheckBox.Name = "useImmediatelyCheckBox";
            this.useImmediatelyCheckBox.Size = new System.Drawing.Size(155, 17);
            this.useImmediatelyCheckBox.TabIndex = 10;
            this.useImmediatelyCheckBox.Text = "Use immediately on startup.";
            this.useImmediatelyCheckBox.UseVisualStyleBackColor = true;
            this.useImmediatelyCheckBox.CheckedChanged += new System.EventHandler(this.useImmediatelyCheckBox_CheckedChanged);
            // 
            // throbber
            // 
            this.throbber.Location = new System.Drawing.Point(190, 33);
            this.throbber.MaximumSize = new System.Drawing.Size(24, 24);
            this.throbber.MinimumSize = new System.Drawing.Size(24, 24);
            this.throbber.Name = "throbber";
            this.throbber.Size = new System.Drawing.Size(24, 24);
            this.throbber.State = EVEMon.Common.ThrobberState.Stopped;
            this.throbber.TabIndex = 9;
            this.throbber.TabStop = false;
            // 
            // SettingsFileStorageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.useImmediatelyCheckBox);
            this.Controls.Add(this.apiResponseLabel);
            this.Controls.Add(this.throbber);
            this.Controls.Add(this.alwaysDownloadCheckBox);
            this.Controls.Add(this.alwaysUploadCheckBox);
            this.Controls.Add(this.downloadSettingsFileButton);
            this.Controls.Add(this.uploadSettingsFileButton);
            this.Name = "SettingsFileStorageControl";
            this.Size = new System.Drawing.Size(405, 109);
            this.Load += new System.EventHandler(this.SettingsFileStorageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.throbber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox alwaysDownloadCheckBox;
        private System.Windows.Forms.CheckBox alwaysUploadCheckBox;
        private System.Windows.Forms.Button downloadSettingsFileButton;
        private System.Windows.Forms.Button uploadSettingsFileButton;
        private System.Windows.Forms.Label apiResponseLabel;
        private Throbber throbber;
        private System.Windows.Forms.CheckBox useImmediatelyCheckBox;
    }
}
