﻿namespace EVEMon.CharacterMonitoring
{
    internal sealed partial class CharacterAssetsList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterAssetsList));
            this.noAssetsLabel = new System.Windows.Forms.Label();
            this.lvAssets = new System.Windows.Forms.ListView();
            this.chItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.noPricesFoundLabel = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.throbber = new EVEMon.Common.Controls.Throbber();
            this.estimatedCostPanel = new System.Windows.Forms.Panel();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throbber)).BeginInit();
            this.estimatedCostPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // noAssetsLabel
            // 
            this.noAssetsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noAssetsLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.noAssetsLabel.Location = new System.Drawing.Point(0, 0);
            this.noAssetsLabel.Name = "noAssetsLabel";
            this.noAssetsLabel.Size = new System.Drawing.Size(472, 401);
            this.noAssetsLabel.TabIndex = 3;
            this.noAssetsLabel.Text = "No assets are available.";
            this.noAssetsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvAssets
            // 
            this.lvAssets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAssets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chItem,
            this.chQuantity,
            this.chVolume,
            this.chGroup,
            this.chCategory});
            this.lvAssets.ContextMenuStrip = this.contextMenu;
            this.lvAssets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAssets.FullRowSelect = true;
            this.lvAssets.HideSelection = false;
            this.lvAssets.Location = new System.Drawing.Point(0, 0);
            this.lvAssets.Name = "lvAssets";
            this.lvAssets.Size = new System.Drawing.Size(472, 401);
            this.lvAssets.SmallImageList = this.ilIcons;
            this.lvAssets.TabIndex = 3;
            this.lvAssets.UseCompatibleStateImageBehavior = false;
            this.lvAssets.View = System.Windows.Forms.View.Details;
            // 
            // chItem
            // 
            this.chItem.Text = "Item";
            this.chItem.Width = 166;
            // 
            // chQuantity
            // 
            this.chQuantity.Text = "Quantity";
            this.chQuantity.Width = 72;
            // 
            // chVolume
            // 
            this.chVolume.Text = "Volume";
            this.chVolume.Width = 74;
            // 
            // chGroup
            // 
            this.chGroup.Text = "Group";
            this.chGroup.Width = 80;
            // 
            // chCategory
            // 
            this.chCategory.Text = "Category";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVToolStripMenuItem});
            this.contextMenu.Name = "ItemAttributeContextMenu";
            this.contextMenu.Size = new System.Drawing.Size(155, 26);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV...";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "arrow_up.png");
            this.ilIcons.Images.SetKeyName(1, "arrow_down.png");
            this.ilIcons.Images.SetKeyName(2, "16x16Transparant.png");
            // 
            // noPricesFoundLabel
            // 
            this.noPricesFoundLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.noPricesFoundLabel.AutoSize = true;
            this.noPricesFoundLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.noPricesFoundLabel.Location = new System.Drawing.Point(258, 9);
            this.noPricesFoundLabel.Name = "noPricesFoundLabel";
            this.noPricesFoundLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noPricesFoundLabel.Size = new System.Drawing.Size(208, 13);
            this.noPricesFoundLabel.TabIndex = 1;
            this.noPricesFoundLabel.Text = "* Prices for some items could not be found.";
            this.noPricesFoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(3, 9);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(207, 13);
            this.lblTotalCost.TabIndex = 0;
            this.lblTotalCost.Text = "Estimated Cost of shown items: {0:N2} ISK";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // throbber
            // 
            this.throbber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.throbber.Location = new System.Drawing.Point(442, 4);
            this.throbber.MaximumSize = new System.Drawing.Size(24, 24);
            this.throbber.MinimumSize = new System.Drawing.Size(24, 24);
            this.throbber.Name = "throbber";
            this.throbber.Size = new System.Drawing.Size(24, 24);
            this.throbber.State = EVEMon.Common.Enumerations.ThrobberState.Stopped;
            this.throbber.TabIndex = 3;
            this.throbber.TabStop = false;
            this.throbber.Visible = false;
            // 
            // estimatedCostPanel
            // 
            this.estimatedCostPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.estimatedCostPanel.Controls.Add(this.lblTotalCost);
            this.estimatedCostPanel.Controls.Add(this.noPricesFoundLabel);
            this.estimatedCostPanel.Controls.Add(this.throbber);
            this.estimatedCostPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.estimatedCostPanel.Location = new System.Drawing.Point(0, 401);
            this.estimatedCostPanel.Name = "estimatedCostPanel";
            this.estimatedCostPanel.Size = new System.Drawing.Size(472, 33);
            this.estimatedCostPanel.TabIndex = 5;
            // 
            // CharacterAssetsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.lvAssets);
            this.Controls.Add(this.noAssetsLabel);
            this.Controls.Add(this.estimatedCostPanel);
            this.Name = "CharacterAssetsList";
            this.Size = new System.Drawing.Size(472, 434);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.throbber)).EndInit();
            this.estimatedCostPanel.ResumeLayout(false);
            this.estimatedCostPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label noAssetsLabel;
        private System.Windows.Forms.ListView lvAssets;
        private System.Windows.Forms.ColumnHeader chItem;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chVolume;
        private System.Windows.Forms.ColumnHeader chGroup;
        private System.Windows.Forms.ColumnHeader chCategory;
        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label noPricesFoundLabel;
        private Common.Controls.Throbber throbber;
        private System.Windows.Forms.Panel estimatedCostPanel;
    }
}
