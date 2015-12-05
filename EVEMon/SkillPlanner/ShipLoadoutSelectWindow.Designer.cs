
using EVEMon.Common.Controls;
using EVEMon.Common.Enumerations;

namespace EVEMon.SkillPlanner
{
    partial class ShipLoadoutSelectWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipLoadoutSelectWindow));
            this.lblLoadouts = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.persistentSplitContainer = new EVEMon.Common.Controls.PersistentSplitContainer();
            this.lvLoadouts = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.tvLoadout = new System.Windows.Forms.TreeView();
            this.throbberFitting = new EVEMon.Common.Controls.Throbber();
            this.throbberLoadouts = new EVEMon.Common.Controls.Throbber();
            this.lblSubmitDate = new System.Windows.Forms.Label();
            this.SubDateLabel = new System.Windows.Forms.Label();
            this.lblForum = new System.Windows.Forms.LinkLabel();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.LoadoutNameLabel = new System.Windows.Forms.Label();
            this.ShipLabel = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLoadoutName = new System.Windows.Forms.Label();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblPlanned = new System.Windows.Forms.Label();
            this.TrainingTimeLabel = new System.Windows.Forms.Label();
            this.lblTrainTime = new System.Windows.Forms.Label();
            this.btnPlan = new System.Windows.Forms.Button();
            this.cmNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miShowInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.miExportToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.eveImage = new EVEMon.Common.Controls.EveImage();
            this.lowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.persistentSplitContainer)).BeginInit();
            this.persistentSplitContainer.Panel1.SuspendLayout();
            this.persistentSplitContainer.Panel2.SuspendLayout();
            this.persistentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throbberFitting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throbberLoadouts)).BeginInit();
            this.cmNode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoadouts
            // 
            this.lblLoadouts.AutoSize = true;
            this.lblLoadouts.Location = new System.Drawing.Point(114, 82);
            this.lblLoadouts.Name = "lblLoadouts";
            this.lblLoadouts.Size = new System.Drawing.Size(101, 13);
            this.lblLoadouts.TabIndex = 1;
            this.lblLoadouts.Text = "Found {0} Loadouts";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(641, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lowerPanel
            // 
            this.lowerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lowerPanel.Controls.Add(this.persistentSplitContainer);
            this.lowerPanel.Controls.Add(this.throbberLoadouts);
            this.lowerPanel.Location = new System.Drawing.Point(6, 123);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(716, 342);
            this.lowerPanel.TabIndex = 6;
            // 
            // persistentSplitContainer
            // 
            this.persistentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.persistentSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.persistentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.persistentSplitContainer.Name = "persistentSplitContainer";
            // 
            // persistentSplitContainer.Panel1
            // 
            this.persistentSplitContainer.Panel1.Controls.Add(this.lvLoadouts);
            this.persistentSplitContainer.Panel1MinSize = 300;
            // 
            // persistentSplitContainer.Panel2
            // 
            this.persistentSplitContainer.Panel2.Controls.Add(this.tvLoadout);
            this.persistentSplitContainer.Panel2.Controls.Add(this.throbberFitting);
            this.persistentSplitContainer.RememberDistanceKey = null;
            this.persistentSplitContainer.Size = new System.Drawing.Size(716, 342);
            this.persistentSplitContainer.SplitterDistance = 373;
            this.persistentSplitContainer.TabIndex = 5;
            // 
            // lvLoadouts
            // 
            this.lvLoadouts.AllowColumnReorder = true;
            this.lvLoadouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAuthor,
            this.colRating,
            this.colDate});
            this.lvLoadouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLoadouts.FullRowSelect = true;
            this.lvLoadouts.Location = new System.Drawing.Point(0, 0);
            this.lvLoadouts.MinimumSize = new System.Drawing.Size(300, 190);
            this.lvLoadouts.MultiSelect = false;
            this.lvLoadouts.Name = "lvLoadouts";
            this.lvLoadouts.Size = new System.Drawing.Size(373, 342);
            this.lvLoadouts.SmallImageList = this.ilIcons;
            this.lvLoadouts.TabIndex = 0;
            this.lvLoadouts.UseCompatibleStateImageBehavior = false;
            this.lvLoadouts.View = System.Windows.Forms.View.Details;
            this.lvLoadouts.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvLoadouts_ColumnClick);
            this.lvLoadouts.Click += new System.EventHandler(this.lvLoadouts_Click);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 153;
            // 
            // colAuthor
            // 
            this.colAuthor.Text = "Author";
            this.colAuthor.Width = 68;
            // 
            // colRating
            // 
            this.colRating.Text = "Rating";
            this.colRating.Width = 56;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 90;
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "arrow_up.png");
            this.ilIcons.Images.SetKeyName(1, "arrow_down.png");
            this.ilIcons.Images.SetKeyName(2, "16x16Transparant.png");
            // 
            // tvLoadout
            // 
            this.tvLoadout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLoadout.Location = new System.Drawing.Point(0, 0);
            this.tvLoadout.Name = "tvLoadout";
            this.tvLoadout.Size = new System.Drawing.Size(339, 342);
            this.tvLoadout.TabIndex = 3;
            this.tvLoadout.DoubleClick += new System.EventHandler(this.tvLoadout_DoubleClick);
            this.tvLoadout.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvLoadout_MouseUp);
            // 
            // throbberFitting
            // 
            this.throbberFitting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.throbberFitting.BackColor = System.Drawing.SystemColors.Window;
            this.throbberFitting.Location = new System.Drawing.Point(157, 159);
            this.throbberFitting.MaximumSize = new System.Drawing.Size(24, 24);
            this.throbberFitting.MinimumSize = new System.Drawing.Size(24, 24);
            this.throbberFitting.Name = "throbberFitting";
            this.throbberFitting.Size = new System.Drawing.Size(24, 24);
            this.throbberFitting.State = EVEMon.Common.Enumerations.ThrobberState.Stopped;
            this.throbberFitting.TabIndex = 4;
            this.throbberFitting.TabStop = false;
            // 
            // throbberLoadouts
            // 
            this.throbberLoadouts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.throbberLoadouts.BackColor = System.Drawing.Color.Transparent;
            this.throbberLoadouts.Location = new System.Drawing.Point(346, 159);
            this.throbberLoadouts.MaximumSize = new System.Drawing.Size(24, 24);
            this.throbberLoadouts.MinimumSize = new System.Drawing.Size(24, 24);
            this.throbberLoadouts.Name = "throbberLoadouts";
            this.throbberLoadouts.Size = new System.Drawing.Size(24, 24);
            this.throbberLoadouts.State = EVEMon.Common.Enumerations.ThrobberState.Stopped;
            this.throbberLoadouts.TabIndex = 6;
            this.throbberLoadouts.TabStop = false;
            // 
            // lblSubmitDate
            // 
            this.lblSubmitDate.AutoSize = true;
            this.lblSubmitDate.Location = new System.Drawing.Point(204, 51);
            this.lblSubmitDate.Name = "lblSubmitDate";
            this.lblSubmitDate.Size = new System.Drawing.Size(62, 13);
            this.lblSubmitDate.TabIndex = 25;
            this.lblSubmitDate.Text = "SubmitDate";
            // 
            // SubDateLabel
            // 
            this.SubDateLabel.AutoSize = true;
            this.SubDateLabel.Location = new System.Drawing.Point(114, 51);
            this.SubDateLabel.Name = "SubDateLabel";
            this.SubDateLabel.Size = new System.Drawing.Size(89, 13);
            this.SubDateLabel.TabIndex = 24;
            this.SubDateLabel.Text = "Submission Date:";
            // 
            // lblForum
            // 
            this.lblForum.AutoSize = true;
            this.lblForum.Location = new System.Drawing.Point(6, 100);
            this.lblForum.Name = "lblForum";
            this.lblForum.Size = new System.Drawing.Size(101, 13);
            this.lblForum.TabIndex = 23;
            this.lblForum.TabStop = true;
            this.lblForum.Text = "Discuss this loadout";
            this.lblForum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForum_LinkClicked);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(114, 38);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(41, 13);
            this.AuthorLabel.TabIndex = 22;
            this.AuthorLabel.Text = "Author:";
            // 
            // LoadoutNameLabel
            // 
            this.LoadoutNameLabel.AutoSize = true;
            this.LoadoutNameLabel.Location = new System.Drawing.Point(114, 25);
            this.LoadoutNameLabel.Name = "LoadoutNameLabel";
            this.LoadoutNameLabel.Size = new System.Drawing.Size(80, 13);
            this.LoadoutNameLabel.TabIndex = 21;
            this.LoadoutNameLabel.Text = "Loadout Name:";
            // 
            // ShipLabel
            // 
            this.ShipLabel.AutoSize = true;
            this.ShipLabel.Location = new System.Drawing.Point(114, 12);
            this.ShipLabel.Name = "ShipLabel";
            this.ShipLabel.Size = new System.Drawing.Size(31, 13);
            this.ShipLabel.TabIndex = 20;
            this.ShipLabel.Text = "Ship:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(204, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 13);
            this.lblAuthor.TabIndex = 19;
            this.lblAuthor.Text = "AuthorName";
            // 
            // lblLoadoutName
            // 
            this.lblLoadoutName.AutoSize = true;
            this.lblLoadoutName.Location = new System.Drawing.Point(204, 25);
            this.lblLoadoutName.Name = "lblLoadoutName";
            this.lblLoadoutName.Size = new System.Drawing.Size(74, 13);
            this.lblLoadoutName.TabIndex = 18;
            this.lblLoadoutName.Text = "LoadoutName";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(204, 12);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(56, 13);
            this.lblShipName.TabIndex = 17;
            this.lblShipName.Text = "ShipName";
            // 
            // lblPlanned
            // 
            this.lblPlanned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlanned.AutoSize = true;
            this.lblPlanned.Location = new System.Drawing.Point(191, 481);
            this.lblPlanned.Name = "lblPlanned";
            this.lblPlanned.Size = new System.Drawing.Size(0, 13);
            this.lblPlanned.TabIndex = 28;
            // 
            // TrainingTimeLabel
            // 
            this.TrainingTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TrainingTimeLabel.AutoSize = true;
            this.TrainingTimeLabel.Location = new System.Drawing.Point(12, 481);
            this.TrainingTimeLabel.Name = "TrainingTimeLabel";
            this.TrainingTimeLabel.Size = new System.Drawing.Size(173, 13);
            this.TrainingTimeLabel.TabIndex = 26;
            this.TrainingTimeLabel.Text = "Training Time for selected loadout: ";
            // 
            // lblTrainTime
            // 
            this.lblTrainTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTrainTime.AutoSize = true;
            this.lblTrainTime.Location = new System.Drawing.Point(191, 481);
            this.lblTrainTime.Name = "lblTrainTime";
            this.lblTrainTime.Size = new System.Drawing.Size(27, 13);
            this.lblTrainTime.TabIndex = 27;
            this.lblTrainTime.Text = "N/A";
            // 
            // btnPlan
            // 
            this.btnPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlan.Enabled = false;
            this.btnPlan.Location = new System.Drawing.Point(560, 471);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(75, 23);
            this.btnPlan.TabIndex = 29;
            this.btnPlan.Text = "Add To Plan";
            this.btnPlan.UseVisualStyleBackColor = true;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // cmNode
            // 
            this.cmNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShowInBrowser,
            this.miExportToClipboard});
            this.cmNode.Name = "cmNode";
            this.cmNode.Size = new System.Drawing.Size(226, 48);
            // 
            // miShowInBrowser
            // 
            this.miShowInBrowser.Name = "miShowInBrowser";
            this.miShowInBrowser.Size = new System.Drawing.Size(225, 22);
            this.miShowInBrowser.Text = "Show in Items Browser...";
            this.miShowInBrowser.Click += new System.EventHandler(this.tvLoadout_DoubleClick);
            // 
            // miExportToClipboard
            // 
            this.miExportToClipboard.Name = "miExportToClipboard";
            this.miExportToClipboard.Size = new System.Drawing.Size(225, 22);
            this.miExportToClipboard.Text = "Export Loadout To Clipboard";
            this.miExportToClipboard.Click += new System.EventHandler(this.miExportToClipboard_Click);
            // 
            // eveImage
            // 
            this.eveImage.EveItem = null;
            this.eveImage.ImageSize = EVEMon.Common.Enumerations.EveImageSize.x128;
            this.eveImage.Location = new System.Drawing.Point(12, 12);
            this.eveImage.Name = "eveImage";
            this.eveImage.PopUpEnabled = true;
            this.eveImage.Size = new System.Drawing.Size(80, 80);
            this.eveImage.SizeMode = EVEMon.Common.Enumerations.EveImageSizeMode.StretchImage;
            this.eveImage.TabIndex = 30;
            // 
            // ShipLoadoutSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(728, 506);
            this.Controls.Add(this.eveImage);
            this.Controls.Add(this.btnPlan);
            this.Controls.Add(this.lblPlanned);
            this.Controls.Add(this.lblSubmitDate);
            this.Controls.Add(this.TrainingTimeLabel);
            this.Controls.Add(this.SubDateLabel);
            this.Controls.Add(this.lblTrainTime);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.LoadoutNameLabel);
            this.Controls.Add(this.ShipLabel);
            this.Controls.Add(this.lblForum);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblLoadoutName);
            this.Controls.Add(this.lblShipName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblLoadouts);
            this.Controls.Add(this.lowerPanel);
            this.MinimumSize = new System.Drawing.Size(744, 544);
            this.Name = "ShipLoadoutSelectWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loadout Selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadoutSelect_FormClosing);
            this.Load += new System.EventHandler(this.LoadoutSelect_Load);
            this.lowerPanel.ResumeLayout(false);
            this.persistentSplitContainer.Panel1.ResumeLayout(false);
            this.persistentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.persistentSplitContainer)).EndInit();
            this.persistentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.throbberFitting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throbberLoadouts)).EndInit();
            this.cmNode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadouts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvLoadouts;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colAuthor;
        private System.Windows.Forms.ColumnHeader colRating;
        private System.Windows.Forms.ColumnHeader colDate;
        private PersistentSplitContainer persistentSplitContainer;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Label lblSubmitDate;
        private System.Windows.Forms.Label SubDateLabel;
        private System.Windows.Forms.LinkLabel lblForum;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label LoadoutNameLabel;
        private System.Windows.Forms.Label ShipLabel;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLoadoutName;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.TreeView tvLoadout;
        private System.Windows.Forms.Label lblPlanned;
        private System.Windows.Forms.Label TrainingTimeLabel;
        private System.Windows.Forms.Label lblTrainTime;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.ContextMenuStrip cmNode;
        private System.Windows.Forms.ToolStripMenuItem miShowInBrowser;
        private System.Windows.Forms.ToolStripMenuItem miExportToClipboard;
        private Common.Controls.EveImage eveImage;
        private System.Windows.Forms.ImageList ilIcons;
        private Throbber throbberLoadouts;
        private Throbber throbberFitting;
    }
}
