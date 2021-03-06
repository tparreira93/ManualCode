﻿namespace CodeFlow.Forms
{
    partial class ProfilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilesForm));
            this.lstProfiles = new System.Windows.Forms.ListView();
            this.chProfileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chConnection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddProf = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProfiles
            // 
            this.lstProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProfileName,
            this.chConnection});
            this.lstProfiles.FullRowSelect = true;
            this.lstProfiles.GridLines = true;
            this.lstProfiles.Location = new System.Drawing.Point(13, 13);
            this.lstProfiles.MultiSelect = false;
            this.lstProfiles.Name = "lstProfiles";
            this.lstProfiles.Size = new System.Drawing.Size(782, 431);
            this.lstProfiles.TabIndex = 0;
            this.lstProfiles.UseCompatibleStateImageBehavior = false;
            this.lstProfiles.View = System.Windows.Forms.View.Details;
            this.lstProfiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstProfiles_MouseDoubleClick);
            // 
            // chProfileName
            // 
            this.chProfileName.Text = "Profile name";
            this.chProfileName.Width = 200;
            // 
            // chConnection
            // 
            this.chConnection.Text = "Connection string";
            this.chConnection.Width = 780;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::CodeFlow.Properties.Resources.Close_16xLG;
            this.btnExit.Location = new System.Drawing.Point(731, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 24);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddProf
            // 
            this.btnAddProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProf.Image = global::CodeFlow.Properties.Resources.AddUser_16x;
            this.btnAddProf.Location = new System.Drawing.Point(13, 448);
            this.btnAddProf.Name = "btnAddProf";
            this.btnAddProf.Size = new System.Drawing.Size(71, 24);
            this.btnAddProf.TabIndex = 1;
            this.btnAddProf.Text = "New";
            this.btnAddProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProf.UseVisualStyleBackColor = true;
            this.btnAddProf.Click += new System.EventHandler(this.btnAddProf_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Image = global::CodeFlow.Properties.Resources.DeleteUser_16x;
            this.btnRemove.Location = new System.Drawing.Point(90, 448);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 24);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ProfilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(802, 484);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddProf);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstProfiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfilesForm";
            this.Text = "Manage profiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfilesForm_FormClosing);
            this.Load += new System.EventHandler(this.ProfilesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstProfiles;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddProf;
        private System.Windows.Forms.ColumnHeader chProfileName;
        private System.Windows.Forms.ColumnHeader chConnection;
        private System.Windows.Forms.Button btnRemove;
    }
}