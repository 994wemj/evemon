namespace EVEMon.SkillPlanner
{
    partial class SkillEnablesForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillEnablesForm));
            this.grpPlanName = new System.Windows.Forms.GroupBox();
            this.lblSkill = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tvSkills = new System.Windows.Forms.TreeView();
            this.cmSkills = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddL1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddL2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddL3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddL4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddL5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowPrereqs = new System.Windows.Forms.ToolStripMenuItem();
            this.tvShips = new System.Windows.Forms.TreeView();
            this.cmEntity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsShowObjectInBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddObjectToPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowObjectPrereqs = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlShipHeader = new System.Windows.Forms.Panel();
            this.lblShips = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShowBaseOnly = new System.Windows.Forms.CheckBox();
            this.rbShowAlpha = new System.Windows.Forms.RadioButton();
            this.rbShowTree = new System.Windows.Forms.RadioButton();
            this.tmrAutoUpdate = new System.Windows.Forms.Timer(this.components);
            this.grpPlanName.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cmSkills.SuspendLayout();
            this.cmEntity.SuspendLayout();
            this.pnlShipHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlanName
            // 
            this.grpPlanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPlanName.Controls.Add(this.lblSkill);
            this.grpPlanName.Location = new System.Drawing.Point(0, 0);
            this.grpPlanName.Name = "grpPlanName";
            this.grpPlanName.Size = new System.Drawing.Size(561, 42);
            this.grpPlanName.TabIndex = 0;
            this.grpPlanName.TabStop = false;
            this.grpPlanName.Text = "Selected Skill Details";
            // 
            // lblSkill
            // 
            this.lblSkill.AutoSize = true;
            this.lblSkill.Location = new System.Drawing.Point(12, 16);
            this.lblSkill.Name = "lblSkill";
            this.lblSkill.Size = new System.Drawing.Size(35, 13);
            this.lblSkill.TabIndex = 0;
            this.lblSkill.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(491, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 40);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "= other untrained skills needed.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "red";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "= unlocked by this skill level,";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(148, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "dimmed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Normal font = already trained,";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(410, 7);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 319);
            this.panel2.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.tvSkills);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlShipHeader);
            this.splitContainer1.Panel2.Controls.Add(this.tvShips);
            this.splitContainer1.Size = new System.Drawing.Size(566, 319);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 18);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enabled Skills";
            // 
            // tvSkills
            // 
            this.tvSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvSkills.ContextMenuStrip = this.cmSkills;
            this.tvSkills.Location = new System.Drawing.Point(0, 16);
            this.tvSkills.Name = "tvSkills";
            treeNode1.Name = "Node0";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Node0";
            this.tvSkills.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvSkills.ShowNodeToolTips = true;
            this.tvSkills.Size = new System.Drawing.Size(207, 299);
            this.tvSkills.TabIndex = 0;
            this.tvSkills.DoubleClick += new System.EventHandler(this.tsShowInBrowser_Click);
            // 
            // cmSkills
            // 
            this.cmSkills.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddPlan,
            this.tsSwitch,
            this.tsShowInBrowser,
            this.tsShowPrereqs});
            this.cmSkills.Name = "cmSkills";
            this.cmSkills.Size = new System.Drawing.Size(233, 92);
            this.cmSkills.Opening += new System.ComponentModel.CancelEventHandler(this.cmSkills_Opening);
            // 
            // tsAddPlan
            // 
            this.tsAddPlan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddL1,
            this.tsAddL2,
            this.tsAddL3,
            this.tsAddL4,
            this.tsAddL5});
            this.tsAddPlan.Name = "tsAddPlan";
            this.tsAddPlan.Size = new System.Drawing.Size(232, 22);
            this.tsAddPlan.Text = "Add To Plan...";
            // 
            // tsAddL1
            // 
            this.tsAddL1.Name = "tsAddL1";
            this.tsAddL1.Size = new System.Drawing.Size(119, 22);
            this.tsAddL1.Tag = "1";
            this.tsAddL1.Text = "Level 1";
            this.tsAddL1.Click += new System.EventHandler(this.tsAddLevel_Click);
            // 
            // tsAddL2
            // 
            this.tsAddL2.Name = "tsAddL2";
            this.tsAddL2.Size = new System.Drawing.Size(119, 22);
            this.tsAddL2.Tag = "2";
            this.tsAddL2.Text = "Level 2";
            this.tsAddL2.Click += new System.EventHandler(this.tsAddLevel_Click);
            // 
            // tsAddL3
            // 
            this.tsAddL3.Name = "tsAddL3";
            this.tsAddL3.Size = new System.Drawing.Size(119, 22);
            this.tsAddL3.Tag = "3";
            this.tsAddL3.Text = "Level 3";
            this.tsAddL3.Click += new System.EventHandler(this.tsAddLevel_Click);
            // 
            // tsAddL4
            // 
            this.tsAddL4.Name = "tsAddL4";
            this.tsAddL4.Size = new System.Drawing.Size(119, 22);
            this.tsAddL4.Tag = "4";
            this.tsAddL4.Text = "Level 4";
            this.tsAddL4.Click += new System.EventHandler(this.tsAddLevel_Click);
            // 
            // tsAddL5
            // 
            this.tsAddL5.Name = "tsAddL5";
            this.tsAddL5.Size = new System.Drawing.Size(119, 22);
            this.tsAddL5.Tag = "5";
            this.tsAddL5.Text = "Level 5";
            this.tsAddL5.Click += new System.EventHandler(this.tsAddLevel_Click);
            // 
            // tsSwitch
            // 
            this.tsSwitch.Name = "tsSwitch";
            this.tsSwitch.Size = new System.Drawing.Size(232, 22);
            this.tsSwitch.Text = "Show me what this skill unlocks";
            this.tsSwitch.Click += new System.EventHandler(this.tsSwitch_Click);
            // 
            // tsShowInBrowser
            // 
            this.tsShowInBrowser.Name = "tsShowInBrowser";
            this.tsShowInBrowser.Size = new System.Drawing.Size(232, 22);
            this.tsShowInBrowser.Text = "Show Skill In Browser";
            this.tsShowInBrowser.Click += new System.EventHandler(this.tsShowInBrowser_Click);
            // 
            // tsShowPrereqs
            // 
            this.tsShowPrereqs.Name = "tsShowPrereqs";
            this.tsShowPrereqs.Size = new System.Drawing.Size(232, 22);
            this.tsShowPrereqs.Text = "Show Untrained Preqresites";
            this.tsShowPrereqs.Click += new System.EventHandler(this.tsShowPrereqs_Click);
            // 
            // tvShips
            // 
            this.tvShips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvShips.ContextMenuStrip = this.cmEntity;
            this.tvShips.Location = new System.Drawing.Point(3, 15);
            this.tvShips.Name = "tvShips";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.tvShips.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvShips.ShowNodeToolTips = true;
            this.tvShips.Size = new System.Drawing.Size(342, 299);
            this.tvShips.TabIndex = 1;
            this.tvShips.DoubleClick += new System.EventHandler(this.tvShips_DoubleClick);
            // 
            // cmEntity
            // 
            this.cmEntity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowObjectInBrowser,
            this.tsAddObjectToPlan,
            this.tsShowObjectPrereqs});
            this.cmEntity.Name = "cmShips";
            this.cmEntity.Size = new System.Drawing.Size(227, 70);
            this.cmEntity.Opening += new System.ComponentModel.CancelEventHandler(this.cmEntity_Opening);
            // 
            // tsShowObjectInBrowser
            // 
            this.tsShowObjectInBrowser.Name = "tsShowObjectInBrowser";
            this.tsShowObjectInBrowser.Size = new System.Drawing.Size(226, 22);
            this.tsShowObjectInBrowser.Text = "Show Ship In Browser";
            this.tsShowObjectInBrowser.Click += new System.EventHandler(this.tsShowEntity_Click);
            // 
            // tsAddObjectToPlan
            // 
            this.tsAddObjectToPlan.Name = "tsAddObjectToPlan";
            this.tsAddObjectToPlan.Size = new System.Drawing.Size(226, 22);
            this.tsAddObjectToPlan.Text = "Add To Plan...";
            this.tsAddObjectToPlan.Click += new System.EventHandler(this.tsAddEntityToPlan_Click);
            // 
            // tsShowObjectPrereqs
            // 
            this.tsShowObjectPrereqs.Name = "tsShowObjectPrereqs";
            this.tsShowObjectPrereqs.Size = new System.Drawing.Size(226, 22);
            this.tsShowObjectPrereqs.Text = "Show Untrained Prerequisites";
            this.tsShowObjectPrereqs.Click += new System.EventHandler(this.tsShowShipPrereqs_Click);
            // 
            // pnlShipHeader
            // 
            this.pnlShipHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShipHeader.BackColor = System.Drawing.Color.LightCyan;
            this.pnlShipHeader.Controls.Add(this.lblShips);
            this.pnlShipHeader.Location = new System.Drawing.Point(3, 0);
            this.pnlShipHeader.Name = "pnlShipHeader";
            this.pnlShipHeader.Size = new System.Drawing.Size(342, 18);
            this.pnlShipHeader.TabIndex = 0;
            // 
            // lblShips
            // 
            this.lblShips.AutoSize = true;
            this.lblShips.Location = new System.Drawing.Point(3, 0);
            this.lblShips.Name = "lblShips";
            this.lblShips.Size = new System.Drawing.Size(75, 13);
            this.lblShips.TabIndex = 0;
            this.lblShips.Text = "Enabled Ships";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbShowBaseOnly);
            this.groupBox2.Controls.Add(this.rbShowAlpha);
            this.groupBox2.Controls.Add(this.rbShowTree);
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 32);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // cbShowBaseOnly
            // 
            this.cbShowBaseOnly.AutoSize = true;
            this.cbShowBaseOnly.Checked = true;
            this.cbShowBaseOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowBaseOnly.Location = new System.Drawing.Point(269, 12);
            this.cbShowBaseOnly.Name = "cbShowBaseOnly";
            this.cbShowBaseOnly.Size = new System.Drawing.Size(137, 17);
            this.cbShowBaseOnly.TabIndex = 2;
            this.cbShowBaseOnly.Text = "Only show T1/T2 Items";
            this.cbShowBaseOnly.UseVisualStyleBackColor = true;
            this.cbShowBaseOnly.CheckedChanged += new System.EventHandler(this.cbShowBaseOnly_CheckedChanged);
            // 
            // rbShowAlpha
            // 
            this.rbShowAlpha.AutoSize = true;
            this.rbShowAlpha.Checked = true;
            this.rbShowAlpha.Location = new System.Drawing.Point(6, 11);
            this.rbShowAlpha.Name = "rbShowAlpha";
            this.rbShowAlpha.Size = new System.Drawing.Size(124, 17);
            this.rbShowAlpha.TabIndex = 1;
            this.rbShowAlpha.TabStop = true;
            this.rbShowAlpha.Text = "Show Alphabetic List";
            this.rbShowAlpha.UseVisualStyleBackColor = true;
            this.rbShowAlpha.CheckedChanged += new System.EventHandler(this.rbShowAlpha_CheckedChanged);
            // 
            // rbShowTree
            // 
            this.rbShowTree.AutoSize = true;
            this.rbShowTree.Location = new System.Drawing.Point(136, 11);
            this.rbShowTree.Name = "rbShowTree";
            this.rbShowTree.Size = new System.Drawing.Size(127, 17);
            this.rbShowTree.TabIndex = 0;
            this.rbShowTree.Text = "Show Category Trees";
            this.rbShowTree.UseVisualStyleBackColor = true;
            // 
            // tmrAutoUpdate
            // 
            this.tmrAutoUpdate.Interval = 30000;
            this.tmrAutoUpdate.Tick += new System.EventHandler(this.tmrAutoUpdate_Tick);
            // 
            // SkillEnablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPlanName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(425, 480);
            this.Name = "SkillEnablesForm";
            this.Text = "What Is This Skill Used For?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillEnablesForm_FormClosing);
            this.Load += new System.EventHandler(this.SkillEnablesForm_Load);
            this.grpPlanName.ResumeLayout(false);
            this.grpPlanName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.cmSkills.ResumeLayout(false);
            this.cmEntity.ResumeLayout(false);
            this.pnlShipHeader.ResumeLayout(false);
            this.pnlShipHeader.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlanName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbShowBaseOnly;
        private System.Windows.Forms.RadioButton rbShowAlpha;
        private System.Windows.Forms.RadioButton rbShowTree;
        private System.Windows.Forms.Label lblSkill;
        private System.Windows.Forms.TreeView tvSkills;
        private System.Windows.Forms.ContextMenuStrip cmSkills;
        private System.Windows.Forms.ToolStripMenuItem tsAddPlan;
        private System.Windows.Forms.ToolStripMenuItem tsSwitch;
        private System.Windows.Forms.ToolStripMenuItem tsShowInBrowser;
        private System.Windows.Forms.ToolStripMenuItem tsShowPrereqs;
        private System.Windows.Forms.ToolStripMenuItem tsAddL1;
        private System.Windows.Forms.ToolStripMenuItem tsAddL2;
        private System.Windows.Forms.ToolStripMenuItem tsAddL3;
        private System.Windows.Forms.ToolStripMenuItem tsAddL4;
        private System.Windows.Forms.ToolStripMenuItem tsAddL5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvShips;
        private System.Windows.Forms.Panel pnlShipHeader;
        private System.Windows.Forms.Label lblShips;
        private System.Windows.Forms.ContextMenuStrip cmEntity;
        private System.Windows.Forms.ToolStripMenuItem tsAddObjectToPlan;
        private System.Windows.Forms.ToolStripMenuItem tsShowObjectPrereqs;
        private System.Windows.Forms.ToolStripMenuItem tsShowObjectInBrowser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmrAutoUpdate;
    }
}