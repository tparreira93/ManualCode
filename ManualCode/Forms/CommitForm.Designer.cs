﻿namespace CodeFlow
{
    partial class CommitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lstCode = new System.Windows.Forms.ListView();
            this.clCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblManual = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConflict = new System.Windows.Forms.Button();
            this.lblSolutionVersion = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblMerged = new System.Windows.Forms.Label();
            this.lblConflict = new System.Windows.Forms.Label();
            this.lblNotMerged = new System.Windows.Forms.Label();
            this.lblColors = new System.Windows.Forms.Label();
            this.lblDivis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::CodeFlow.Properties.Resources.Close_16xLG;
            this.btnCancel.Location = new System.Drawing.Point(1021, 620);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Exit";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompare.Enabled = false;
            this.btnCompare.Image = global::CodeFlow.Properties.Resources.arrow_merge_16xLG;
            this.btnCompare.Location = new System.Drawing.Point(139, 620);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(184, 30);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare and commit";
            this.btnCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCommit.Enabled = false;
            this.btnCommit.Image = global::CodeFlow.Properties.Resources.Upload_gray_16x;
            this.btnCommit.Location = new System.Drawing.Point(16, 620);
            this.btnCommit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(113, 30);
            this.btnCommit.TabIndex = 1;
            this.btnCommit.Text = "Commit";
            this.btnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lstCode
            // 
            this.lstCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCode.CheckBoxes = true;
            this.lstCode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clCode,
            this.clFile});
            this.lstCode.FullRowSelect = true;
            this.lstCode.Location = new System.Drawing.Point(16, 15);
            this.lstCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstCode.MultiSelect = false;
            this.lstCode.Name = "lstCode";
            this.lstCode.Size = new System.Drawing.Size(1101, 546);
            this.lstCode.TabIndex = 0;
            this.lstCode.UseCompatibleStateImageBehavior = false;
            this.lstCode.View = System.Windows.Forms.View.Details;
            this.lstCode.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lstCode_ItemChecked);
            this.lstCode.SelectedIndexChanged += new System.EventHandler(this.lstCode_SelectedIndexChanged);
            this.lstCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCode_MouseDoubleClick);
            // 
            // clCode
            // 
            this.clCode.Tag = "clCode";
            this.clCode.Text = "Code";
            this.clCode.Width = 797;
            // 
            // clFile
            // 
            this.clFile.Text = "File name";
            this.clFile.Width = 224;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServer,
            this.toolStripStatusLabel1,
            this.lblManual});
            this.statusStrip.Location = new System.Drawing.Point(0, 657);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1137, 25);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "status";
            // 
            // lblServer
            // 
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(63, 20);
            this.lblServer.Text = "SERVER";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(978, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblManual
            // 
            this.lblManual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.ForeColor = System.Drawing.Color.Crimson;
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(76, 20);
            this.lblManual.Text = "MANUAL";
            // 
            // btnConflict
            // 
            this.btnConflict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConflict.Enabled = false;
            this.btnConflict.Image = global::CodeFlow.Properties.Resources.Conflict_16x;
            this.btnConflict.Location = new System.Drawing.Point(437, 620);
            this.btnConflict.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConflict.Name = "btnConflict";
            this.btnConflict.Size = new System.Drawing.Size(130, 30);
            this.btnConflict.TabIndex = 4;
            this.btnConflict.Text = "View conflict";
            this.btnConflict.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConflict.UseVisualStyleBackColor = true;
            this.btnConflict.Click += new System.EventHandler(this.btnConflict_Click);
            // 
            // lblSolutionVersion
            // 
            this.lblSolutionVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSolutionVersion.AutoSize = true;
            this.lblSolutionVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionVersion.Location = new System.Drawing.Point(11, 565);
            this.lblSolutionVersion.Name = "lblSolutionVersion";
            this.lblSolutionVersion.Size = new System.Drawing.Size(132, 17);
            this.lblSolutionVersion.TabIndex = 10;
            this.lblSolutionVersion.Text = "SOLUTION_INFO";
            // 
            // lblProd
            // 
            this.lblProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Location = new System.Drawing.Point(11, 590);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(151, 17);
            this.lblProd.TabIndex = 11;
            this.lblProd.Text = "PRODUCTION ENV.";
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(623, 590);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(500, 18);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "WARNING";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMerge.Enabled = false;
            this.btnMerge.Image = global::CodeFlow.Properties.Resources.Join_16x;
            this.btnMerge.Location = new System.Drawing.Point(333, 620);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(94, 30);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge";
            this.btnMerge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lblMerged
            // 
            this.lblMerged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMerged.AutoSize = true;
            this.lblMerged.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerged.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMerged.Location = new System.Drawing.Point(1043, 565);
            this.lblMerged.Name = "lblMerged";
            this.lblMerged.Size = new System.Drawing.Size(74, 17);
            this.lblMerged.TabIndex = 14;
            this.lblMerged.Text = "MERGED";
            // 
            // lblConflict
            // 
            this.lblConflict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConflict.AutoSize = true;
            this.lblConflict.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConflict.ForeColor = System.Drawing.Color.DarkRed;
            this.lblConflict.Location = new System.Drawing.Point(954, 565);
            this.lblConflict.Name = "lblConflict";
            this.lblConflict.Size = new System.Drawing.Size(83, 17);
            this.lblConflict.TabIndex = 15;
            this.lblConflict.Text = "CONFLICT";
            // 
            // lblNotMerged
            // 
            this.lblNotMerged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotMerged.AutoSize = true;
            this.lblNotMerged.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotMerged.Location = new System.Drawing.Point(836, 565);
            this.lblNotMerged.Name = "lblNotMerged";
            this.lblNotMerged.Size = new System.Drawing.Size(112, 17);
            this.lblNotMerged.TabIndex = 16;
            this.lblNotMerged.Text = "NOT MERGED";
            // 
            // lblColors
            // 
            this.lblColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColors.AutoSize = true;
            this.lblColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColors.Location = new System.Drawing.Point(711, 565);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(119, 17);
            this.lblColors.TabIndex = 17;
            this.lblColors.Text = "Color schemes:";
            // 
            // lblDivis
            // 
            this.lblDivis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivis.AutoSize = true;
            this.lblDivis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivis.Location = new System.Drawing.Point(945, 564);
            this.lblDivis.Name = "lblDivis";
            this.lblDivis.Size = new System.Drawing.Size(12, 17);
            this.lblDivis.TabIndex = 18;
            this.lblDivis.Text = "|";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1034, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "|";
            // 
            // CommitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1137, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDivis);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.lblNotMerged);
            this.Controls.Add(this.lblConflict);
            this.Controls.Add(this.lblMerged);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblSolutionVersion);
            this.Controls.Add(this.btnConflict);
            this.Controls.Add(this.lstCode);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CommitForm";
            this.Text = "Commit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExportForm_FormClosing);
            this.Load += new System.EventHandler(this.ExportForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.ListView lstCode;
        private System.Windows.Forms.ColumnHeader clCode;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btnConflict;
        private System.Windows.Forms.ToolStripStatusLabel lblServer;
        private System.Windows.Forms.ToolStripStatusLabel lblManual;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblSolutionVersion;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ColumnHeader clFile;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblMerged;
        private System.Windows.Forms.Label lblConflict;
        private System.Windows.Forms.Label lblNotMerged;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Label lblDivis;
        private System.Windows.Forms.Label label1;
    }
}