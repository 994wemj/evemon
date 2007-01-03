namespace EVEMon.SkillPlanner
{
    partial class ItemBrowserControl
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
            this.splitContainer1 = new EVEMon.SkillPlanner.PersistentSplitContainer();
            this.itemSelectControl1 = new EVEMon.SkillPlanner.ItemSelectControl();
            this.lvItemProperties = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnItemSkillsAdd = new System.Windows.Forms.Button();
            this.lblItemTimeRequired = new System.Windows.Forms.Label();
            this.lblItemSkill3 = new System.Windows.Forms.Label();
            this.lblItemSkill2 = new System.Windows.Forms.Label();
            this.lblItemSkill1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.pbItemIcon = new System.Windows.Forms.PictureBox();
            this.btnCompareWith = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.itemSelectControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvItemProperties);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemDescription);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemName);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemCategory);
            this.splitContainer1.Panel2.Controls.Add(this.pbItemIcon);
            this.splitContainer1.RememberDistanceKey = null;
            this.splitContainer1.Size = new System.Drawing.Size(867, 508);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // itemSelectControl1
            // 
            this.itemSelectControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemSelectControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemSelectControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSelectControl1.Location = new System.Drawing.Point(0, 0);
            this.itemSelectControl1.Margin = new System.Windows.Forms.Padding(5);
            this.itemSelectControl1.Name = "itemSelectControl1";
            this.itemSelectControl1.Plan = null;
            this.itemSelectControl1.SelectedItem = null;
            this.itemSelectControl1.Size = new System.Drawing.Size(163, 508);
            this.itemSelectControl1.TabIndex = 1;
            this.itemSelectControl1.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.itemSelectControl1_SelectedItemChanged);
            // 
            // lvItemProperties
            // 
            this.lvItemProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItemProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvItemProperties.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lvItemProperties.FullRowSelect = true;
            this.lvItemProperties.Location = new System.Drawing.Point(4, 90);
            this.lvItemProperties.Margin = new System.Windows.Forms.Padding(4);
            this.lvItemProperties.Name = "lvItemProperties";
            this.lvItemProperties.Size = new System.Drawing.Size(324, 414);
            this.lvItemProperties.TabIndex = 8;
            this.lvItemProperties.UseCompatibleStateImageBehavior = false;
            this.lvItemProperties.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Attribute";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 140;
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDescription.Location = new System.Drawing.Point(338, 90);
            this.lblItemDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(357, 265);
            this.lblItemDescription.TabIndex = 10;
            this.lblItemDescription.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCompareWith);
            this.groupBox2.Controls.Add(this.btnItemSkillsAdd);
            this.groupBox2.Controls.Add(this.lblItemTimeRequired);
            this.groupBox2.Controls.Add(this.lblItemSkill3);
            this.groupBox2.Controls.Add(this.lblItemSkill2);
            this.groupBox2.Controls.Add(this.lblItemSkill1);
            this.groupBox2.Location = new System.Drawing.Point(338, 358);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(357, 146);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Required Skills";
            // 
            // btnItemSkillsAdd
            // 
            this.btnItemSkillsAdd.Location = new System.Drawing.Point(173, 107);
            this.btnItemSkillsAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemSkillsAdd.Name = "btnItemSkillsAdd";
            this.btnItemSkillsAdd.Size = new System.Drawing.Size(172, 28);
            this.btnItemSkillsAdd.TabIndex = 9;
            this.btnItemSkillsAdd.Text = "Add Skills to Plan";
            this.btnItemSkillsAdd.UseVisualStyleBackColor = true;
            this.btnItemSkillsAdd.Click += new System.EventHandler(this.btnItemSkillsAdd_Click);
            // 
            // lblItemTimeRequired
            // 
            this.lblItemTimeRequired.AutoSize = true;
            this.lblItemTimeRequired.Location = new System.Drawing.Point(20, 86);
            this.lblItemTimeRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemTimeRequired.Name = "lblItemTimeRequired";
            this.lblItemTimeRequired.Size = new System.Drawing.Size(105, 17);
            this.lblItemTimeRequired.TabIndex = 8;
            this.lblItemTimeRequired.Text = "Time Required:";
            // 
            // lblItemSkill3
            // 
            this.lblItemSkill3.AutoSize = true;
            this.lblItemSkill3.Location = new System.Drawing.Point(20, 59);
            this.lblItemSkill3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemSkill3.Name = "lblItemSkill3";
            this.lblItemSkill3.Size = new System.Drawing.Size(46, 17);
            this.lblItemSkill3.TabIndex = 7;
            this.lblItemSkill3.Text = "label4";
            // 
            // lblItemSkill2
            // 
            this.lblItemSkill2.AutoSize = true;
            this.lblItemSkill2.Location = new System.Drawing.Point(20, 43);
            this.lblItemSkill2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemSkill2.Name = "lblItemSkill2";
            this.lblItemSkill2.Size = new System.Drawing.Size(46, 17);
            this.lblItemSkill2.TabIndex = 6;
            this.lblItemSkill2.Text = "label3";
            // 
            // lblItemSkill1
            // 
            this.lblItemSkill1.AutoSize = true;
            this.lblItemSkill1.Location = new System.Drawing.Point(20, 27);
            this.lblItemSkill1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemSkill1.Name = "lblItemSkill1";
            this.lblItemSkill1.Size = new System.Drawing.Size(46, 17);
            this.lblItemSkill1.TabIndex = 5;
            this.lblItemSkill1.Text = "label2";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(93, 20);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 23);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "label3";
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(93, 4);
            this.lblItemCategory.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(46, 17);
            this.lblItemCategory.TabIndex = 6;
            this.lblItemCategory.Text = "label2";
            // 
            // pbItemIcon
            // 
            this.pbItemIcon.Location = new System.Drawing.Point(4, 4);
            this.pbItemIcon.Margin = new System.Windows.Forms.Padding(4);
            this.pbItemIcon.Name = "pbItemIcon";
            this.pbItemIcon.Size = new System.Drawing.Size(85, 79);
            this.pbItemIcon.TabIndex = 5;
            this.pbItemIcon.TabStop = false;
            // 
            // btnCompareWith
            // 
            this.btnCompareWith.Location = new System.Drawing.Point(8, 107);
            this.btnCompareWith.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompareWith.Name = "btnCompareWith";
            this.btnCompareWith.Size = new System.Drawing.Size(127, 28);
            this.btnCompareWith.TabIndex = 10;
            this.btnCompareWith.Text = "Compare With�";
            this.btnCompareWith.UseVisualStyleBackColor = true;
            this.btnCompareWith.Click += new System.EventHandler(this.btnCompareWith_Click);
            // 
            // ItemBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemBrowserControl";
            this.Size = new System.Drawing.Size(867, 508);
            this.Load += new System.EventHandler(this.ItemBrowserControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EVEMon.SkillPlanner.PersistentSplitContainer splitContainer1;
        private EVEMon.SkillPlanner.ItemSelectControl itemSelectControl1;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.PictureBox pbItemIcon;
        private System.Windows.Forms.Button btnItemSkillsAdd;
        private System.Windows.Forms.Label lblItemTimeRequired;
        private System.Windows.Forms.Label lblItemSkill3;
        private System.Windows.Forms.Label lblItemSkill2;
        private System.Windows.Forms.Label lblItemSkill1;
        private System.Windows.Forms.ListView lvItemProperties;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCompareWith;
    }
}
