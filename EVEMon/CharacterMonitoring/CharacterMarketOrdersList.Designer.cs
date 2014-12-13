﻿using EVEMon.Common.Controls;

namespace EVEMon.CharacterMonitoring
{
    internal sealed partial class CharacterMarketOrdersList
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Sell Orders", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Buy Orders", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterMarketOrdersList));
            this.lvOrders = new System.Windows.Forms.ListView();
            this.itemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.locationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitaryPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.noOrdersLabel = new System.Windows.Forms.Label();
            this.marketExpPanelControl = new EVEMon.Common.Controls.ExpandablePanelControl();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvOrders
            // 
            this.lvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemColumn,
            this.locationColumn,
            this.unitaryPriceColumn,
            this.quantityColumn});
            this.lvOrders.ContextMenuStrip = this.contextMenu;
            this.lvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOrders.FullRowSelect = true;
            listViewGroup1.Header = "Sell Orders";
            listViewGroup1.Name = "sellGroup";
            listViewGroup2.Header = "Buy Orders";
            listViewGroup2.Name = "buyGroup";
            this.lvOrders.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(0, 0);
            this.lvOrders.MultiSelect = false;
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(454, 334);
            this.lvOrders.SmallImageList = this.ilIcons;
            this.lvOrders.TabIndex = 0;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            // 
            // itemColumn
            // 
            this.itemColumn.Text = "Item";
            this.itemColumn.Width = 192;
            // 
            // locationColumn
            // 
            this.locationColumn.Text = "System";
            this.locationColumn.Width = 80;
            // 
            // unitaryPriceColumn
            // 
            this.unitaryPriceColumn.Text = "Unit Price";
            this.unitaryPriceColumn.Width = 92;
            // 
            // quantityColumn
            // 
            this.quantityColumn.Text = "Quantity";
            this.quantityColumn.Width = 88;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVToolStripMenuItem});
            this.contextMenu.Name = "ShipPropertiesContextMenu";
            this.contextMenu.Size = new System.Drawing.Size(161, 26);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export To CSV ...";
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
            // noOrdersLabel
            // 
            this.noOrdersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noOrdersLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.noOrdersLabel.Location = new System.Drawing.Point(0, 0);
            this.noOrdersLabel.Name = "noOrdersLabel";
            this.noOrdersLabel.Size = new System.Drawing.Size(454, 434);
            this.noOrdersLabel.TabIndex = 1;
            this.noOrdersLabel.Text = "No market orders are available.";
            this.noOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // marketExpPanelControl
            // 
            this.marketExpPanelControl.AnimationSpeed = EVEMon.Common.Controls.AnimationSpeed.Medium;
            this.marketExpPanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marketExpPanelControl.EnableContextMenu = false;
            this.marketExpPanelControl.ExpandDirection = EVEMon.Common.Controls.Direction.Down;
            this.marketExpPanelControl.ExpandedHeight = 100;
            this.marketExpPanelControl.ExpandedOnStartup = false;
            this.marketExpPanelControl.HeaderHeight = 30;
            this.marketExpPanelControl.HeaderText = "Header Text";
            this.marketExpPanelControl.ImageCollapse = ((System.Drawing.Bitmap)(resources.GetObject("marketExpPanelControl.ImageCollapse")));
            this.marketExpPanelControl.ImageExpand = ((System.Drawing.Bitmap)(resources.GetObject("marketExpPanelControl.ImageExpand")));
            this.marketExpPanelControl.Location = new System.Drawing.Point(0, 334);
            this.marketExpPanelControl.Name = "marketExpPanelControl";
            this.marketExpPanelControl.Size = new System.Drawing.Size(454, 100);
            this.marketExpPanelControl.TabIndex = 2;
            // 
            // CharacterMarketOrdersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvOrders);
            this.Controls.Add(this.marketExpPanelControl);
            this.Controls.Add(this.noOrdersLabel);
            this.Name = "CharacterMarketOrdersList";
            this.Size = new System.Drawing.Size(454, 434);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.Label noOrdersLabel;
        private System.Windows.Forms.ColumnHeader itemColumn;
        private System.Windows.Forms.ColumnHeader quantityColumn;
        private System.Windows.Forms.ColumnHeader locationColumn;
        private System.Windows.Forms.ColumnHeader unitaryPriceColumn;
        private System.Windows.Forms.ImageList ilIcons;
        private ExpandablePanelControl marketExpPanelControl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
    }
}
