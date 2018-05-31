namespace SpDeploy
{
    partial class MainForm
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
            this.SitesGroup = new System.Windows.Forms.GroupBox();
            this.AllSitesCheckbox = new System.Windows.Forms.CheckBox();
            this.Site510MARCheckBox = new System.Windows.Forms.CheckBox();
            this.Site430BISCheckbox = new System.Windows.Forms.CheckBox();
            this.Site420TUCCheckBox = new System.Windows.Forms.CheckBox();
            this.Site410LVTCheckbox = new System.Windows.Forms.CheckBox();
            this.Site310BNMCheckbox = new System.Windows.Forms.CheckBox();
            this.MasterCheckbox = new System.Windows.Forms.CheckBox();
            this.EnvironmentsGroup = new System.Windows.Forms.GroupBox();
            this.AllEnvironmentsCheckbox = new System.Windows.Forms.CheckBox();
            this.ProdCheckbox = new System.Windows.Forms.CheckBox();
            this.PilotCheckbox = new System.Windows.Forms.CheckBox();
            this.TestCheckbox = new System.Windows.Forms.CheckBox();
            this.DevCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AllProceduresCheckbox = new System.Windows.Forms.CheckBox();
            this.SPTextBox = new System.Windows.Forms.TextBox();
            this.SPList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DatabaseList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeployButton = new System.Windows.Forms.Button();
            this.GenerateScriptsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SitesGroup.SuspendLayout();
            this.EnvironmentsGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SitesGroup
            // 
            this.SitesGroup.Controls.Add(this.AllSitesCheckbox);
            this.SitesGroup.Controls.Add(this.Site510MARCheckBox);
            this.SitesGroup.Controls.Add(this.Site430BISCheckbox);
            this.SitesGroup.Controls.Add(this.Site420TUCCheckBox);
            this.SitesGroup.Controls.Add(this.Site410LVTCheckbox);
            this.SitesGroup.Controls.Add(this.Site310BNMCheckbox);
            this.SitesGroup.Controls.Add(this.MasterCheckbox);
            this.SitesGroup.Enabled = false;
            this.SitesGroup.Location = new System.Drawing.Point(203, 439);
            this.SitesGroup.Name = "SitesGroup";
            this.SitesGroup.Size = new System.Drawing.Size(297, 113);
            this.SitesGroup.TabIndex = 0;
            this.SitesGroup.TabStop = false;
            this.SitesGroup.Text = "Sites";
            // 
            // AllSitesCheckbox
            // 
            this.AllSitesCheckbox.AutoSize = true;
            this.AllSitesCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllSitesCheckbox.Location = new System.Drawing.Point(6, 90);
            this.AllSitesCheckbox.Name = "AllSitesCheckbox";
            this.AllSitesCheckbox.Size = new System.Drawing.Size(63, 17);
            this.AllSitesCheckbox.TabIndex = 3;
            this.AllSitesCheckbox.Text = "All Sites";
            this.AllSitesCheckbox.UseVisualStyleBackColor = true;
            this.AllSitesCheckbox.CheckedChanged += new System.EventHandler(this.AllSitesCheckbox_CheckedChanged);
            // 
            // Site510MARCheckBox
            // 
            this.Site510MARCheckBox.AutoSize = true;
            this.Site510MARCheckBox.Location = new System.Drawing.Point(221, 19);
            this.Site510MARCheckBox.Name = "Site510MARCheckBox";
            this.Site510MARCheckBox.Size = new System.Drawing.Size(68, 17);
            this.Site510MARCheckBox.TabIndex = 1;
            this.Site510MARCheckBox.Tag = "Site";
            this.Site510MARCheckBox.Text = "510MAR";
            this.Site510MARCheckBox.UseVisualStyleBackColor = true;
            // 
            // Site430BISCheckbox
            // 
            this.Site430BISCheckbox.AutoSize = true;
            this.Site430BISCheckbox.Location = new System.Drawing.Point(149, 65);
            this.Site430BISCheckbox.Name = "Site430BISCheckbox";
            this.Site430BISCheckbox.Size = new System.Drawing.Size(61, 17);
            this.Site430BISCheckbox.TabIndex = 1;
            this.Site430BISCheckbox.Tag = "Site";
            this.Site430BISCheckbox.Text = "430BIS";
            this.Site430BISCheckbox.UseVisualStyleBackColor = true;
            // 
            // Site420TUCCheckBox
            // 
            this.Site420TUCCheckBox.AutoSize = true;
            this.Site420TUCCheckBox.Location = new System.Drawing.Point(149, 42);
            this.Site420TUCCheckBox.Name = "Site420TUCCheckBox";
            this.Site420TUCCheckBox.Size = new System.Drawing.Size(66, 17);
            this.Site420TUCCheckBox.TabIndex = 1;
            this.Site420TUCCheckBox.Tag = "Site";
            this.Site420TUCCheckBox.Text = "420TUC";
            this.Site420TUCCheckBox.UseVisualStyleBackColor = true;
            // 
            // Site410LVTCheckbox
            // 
            this.Site410LVTCheckbox.AutoSize = true;
            this.Site410LVTCheckbox.Location = new System.Drawing.Point(149, 19);
            this.Site410LVTCheckbox.Name = "Site410LVTCheckbox";
            this.Site410LVTCheckbox.Size = new System.Drawing.Size(64, 17);
            this.Site410LVTCheckbox.TabIndex = 1;
            this.Site410LVTCheckbox.Tag = "Site";
            this.Site410LVTCheckbox.Text = "410LVT";
            this.Site410LVTCheckbox.UseVisualStyleBackColor = true;
            // 
            // Site310BNMCheckbox
            // 
            this.Site310BNMCheckbox.AutoSize = true;
            this.Site310BNMCheckbox.Location = new System.Drawing.Point(70, 19);
            this.Site310BNMCheckbox.Name = "Site310BNMCheckbox";
            this.Site310BNMCheckbox.Size = new System.Drawing.Size(68, 17);
            this.Site310BNMCheckbox.TabIndex = 1;
            this.Site310BNMCheckbox.Tag = "Site";
            this.Site310BNMCheckbox.Text = "310BNM";
            this.Site310BNMCheckbox.UseVisualStyleBackColor = true;
            // 
            // MasterCheckbox
            // 
            this.MasterCheckbox.AutoSize = true;
            this.MasterCheckbox.Location = new System.Drawing.Point(6, 19);
            this.MasterCheckbox.Name = "MasterCheckbox";
            this.MasterCheckbox.Size = new System.Drawing.Size(58, 17);
            this.MasterCheckbox.TabIndex = 0;
            this.MasterCheckbox.Tag = "Site";
            this.MasterCheckbox.Text = "Master";
            this.MasterCheckbox.UseVisualStyleBackColor = true;
            // 
            // EnvironmentsGroup
            // 
            this.EnvironmentsGroup.Controls.Add(this.AllEnvironmentsCheckbox);
            this.EnvironmentsGroup.Controls.Add(this.ProdCheckbox);
            this.EnvironmentsGroup.Controls.Add(this.PilotCheckbox);
            this.EnvironmentsGroup.Controls.Add(this.TestCheckbox);
            this.EnvironmentsGroup.Controls.Add(this.DevCheckbox);
            this.EnvironmentsGroup.Enabled = false;
            this.EnvironmentsGroup.Location = new System.Drawing.Point(10, 439);
            this.EnvironmentsGroup.Name = "EnvironmentsGroup";
            this.EnvironmentsGroup.Size = new System.Drawing.Size(187, 113);
            this.EnvironmentsGroup.TabIndex = 0;
            this.EnvironmentsGroup.TabStop = false;
            this.EnvironmentsGroup.Text = "Envrionments";
            // 
            // AllEnvironmentsCheckbox
            // 
            this.AllEnvironmentsCheckbox.AutoSize = true;
            this.AllEnvironmentsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllEnvironmentsCheckbox.Location = new System.Drawing.Point(6, 90);
            this.AllEnvironmentsCheckbox.Name = "AllEnvironmentsCheckbox";
            this.AllEnvironmentsCheckbox.Size = new System.Drawing.Size(104, 17);
            this.AllEnvironmentsCheckbox.TabIndex = 2;
            this.AllEnvironmentsCheckbox.Text = "All Environments";
            this.AllEnvironmentsCheckbox.UseVisualStyleBackColor = true;
            this.AllEnvironmentsCheckbox.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // ProdCheckbox
            // 
            this.ProdCheckbox.AutoSize = true;
            this.ProdCheckbox.Location = new System.Drawing.Point(101, 42);
            this.ProdCheckbox.Name = "ProdCheckbox";
            this.ProdCheckbox.Size = new System.Drawing.Size(77, 17);
            this.ProdCheckbox.TabIndex = 1;
            this.ProdCheckbox.Tag = "Environment";
            this.ProdCheckbox.Text = "Production";
            this.ProdCheckbox.UseVisualStyleBackColor = true;
            // 
            // PilotCheckbox
            // 
            this.PilotCheckbox.AutoSize = true;
            this.PilotCheckbox.Location = new System.Drawing.Point(101, 19);
            this.PilotCheckbox.Name = "PilotCheckbox";
            this.PilotCheckbox.Size = new System.Drawing.Size(46, 17);
            this.PilotCheckbox.TabIndex = 1;
            this.PilotCheckbox.Tag = "Environment";
            this.PilotCheckbox.Text = "Pilot";
            this.PilotCheckbox.UseVisualStyleBackColor = true;
            // 
            // TestCheckbox
            // 
            this.TestCheckbox.AutoSize = true;
            this.TestCheckbox.Location = new System.Drawing.Point(6, 42);
            this.TestCheckbox.Name = "TestCheckbox";
            this.TestCheckbox.Size = new System.Drawing.Size(61, 17);
            this.TestCheckbox.TabIndex = 1;
            this.TestCheckbox.Tag = "Environment";
            this.TestCheckbox.Text = "Testing";
            this.TestCheckbox.UseVisualStyleBackColor = true;
            // 
            // DevCheckbox
            // 
            this.DevCheckbox.AutoSize = true;
            this.DevCheckbox.Location = new System.Drawing.Point(6, 19);
            this.DevCheckbox.Name = "DevCheckbox";
            this.DevCheckbox.Size = new System.Drawing.Size(89, 17);
            this.DevCheckbox.TabIndex = 0;
            this.DevCheckbox.Tag = "Environment";
            this.DevCheckbox.Text = "Development";
            this.DevCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AllProceduresCheckbox);
            this.groupBox3.Controls.Add(this.SPTextBox);
            this.groupBox3.Controls.Add(this.SPList);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ServerList);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DatabaseList);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(10, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 421);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Source";
            // 
            // AllProceduresCheckbox
            // 
            this.AllProceduresCheckbox.AutoSize = true;
            this.AllProceduresCheckbox.Enabled = false;
            this.AllProceduresCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProceduresCheckbox.Location = new System.Drawing.Point(388, 88);
            this.AllProceduresCheckbox.Name = "AllProceduresCheckbox";
            this.AllProceduresCheckbox.Size = new System.Drawing.Size(94, 17);
            this.AllProceduresCheckbox.TabIndex = 10;
            this.AllProceduresCheckbox.Text = "All Procedures";
            this.AllProceduresCheckbox.UseVisualStyleBackColor = true;
            this.AllProceduresCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SPTextBox
            // 
            this.SPTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SPTextBox.Enabled = false;
            this.SPTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPTextBox.Location = new System.Drawing.Point(9, 128);
            this.SPTextBox.Multiline = true;
            this.SPTextBox.Name = "SPTextBox";
            this.SPTextBox.ReadOnly = true;
            this.SPTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SPTextBox.Size = new System.Drawing.Size(473, 278);
            this.SPTextBox.TabIndex = 9;
            this.SPTextBox.WordWrap = false;
            // 
            // SPList
            // 
            this.SPList.Enabled = false;
            this.SPList.FormattingEnabled = true;
            this.SPList.Location = new System.Drawing.Point(102, 86);
            this.SPList.Name = "SPList";
            this.SPList.Size = new System.Drawing.Size(280, 21);
            this.SPList.TabIndex = 8;
            this.SPList.SelectedIndexChanged += new System.EventHandler(this.SPList_SelectedIndexChanged);
            this.SPList.Enter += new System.EventHandler(this.SPList_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stored Procedure:";
            // 
            // ServerList
            // 
            this.ServerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerList.FormattingEnabled = true;
            this.ServerList.Location = new System.Drawing.Point(102, 23);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(380, 21);
            this.ServerList.TabIndex = 6;
            this.ServerList.SelectedIndexChanged += new System.EventHandler(this.ServerList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server:";
            // 
            // DatabaseList
            // 
            this.DatabaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabaseList.Enabled = false;
            this.DatabaseList.FormattingEnabled = true;
            this.DatabaseList.Location = new System.Drawing.Point(102, 55);
            this.DatabaseList.Name = "DatabaseList";
            this.DatabaseList.Size = new System.Drawing.Size(380, 21);
            this.DatabaseList.TabIndex = 4;
            this.DatabaseList.SelectedIndexChanged += new System.EventHandler(this.DatabaseList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database:";
            // 
            // DeployButton
            // 
            this.DeployButton.Enabled = false;
            this.DeployButton.Location = new System.Drawing.Point(425, 556);
            this.DeployButton.Name = "DeployButton";
            this.DeployButton.Size = new System.Drawing.Size(75, 23);
            this.DeployButton.TabIndex = 9;
            this.DeployButton.Text = "Deploy";
            this.DeployButton.UseVisualStyleBackColor = true;
            this.DeployButton.Click += new System.EventHandler(this.DeployButton_Click);
            // 
            // GenerateScriptsButton
            // 
            this.GenerateScriptsButton.Enabled = false;
            this.GenerateScriptsButton.Location = new System.Drawing.Point(306, 556);
            this.GenerateScriptsButton.Name = "GenerateScriptsButton";
            this.GenerateScriptsButton.Size = new System.Drawing.Size(112, 23);
            this.GenerateScriptsButton.TabIndex = 10;
            this.GenerateScriptsButton.Text = "Generate Scripts";
            this.GenerateScriptsButton.UseVisualStyleBackColor = true;
            this.GenerateScriptsButton.Click += new System.EventHandler(this.GenerateScriptsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Location:";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Enabled = false;
            this.LocationTextBox.Location = new System.Drawing.Point(57, 558);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(210, 20);
            this.LocationTextBox.TabIndex = 12;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.LocationTextBox_TextChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.Location = new System.Drawing.Point(267, 556);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(28, 23);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 592);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateScriptsButton);
            this.Controls.Add(this.DeployButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.EnvironmentsGroup);
            this.Controls.Add(this.SitesGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Syteline Stored Procedure Deployment Utitlity";
            this.SitesGroup.ResumeLayout(false);
            this.SitesGroup.PerformLayout();
            this.EnvironmentsGroup.ResumeLayout(false);
            this.EnvironmentsGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SitesGroup;
        private System.Windows.Forms.CheckBox Site510MARCheckBox;
        private System.Windows.Forms.CheckBox Site430BISCheckbox;
        private System.Windows.Forms.CheckBox Site420TUCCheckBox;
        private System.Windows.Forms.CheckBox Site410LVTCheckbox;
        private System.Windows.Forms.CheckBox Site310BNMCheckbox;
        private System.Windows.Forms.CheckBox MasterCheckbox;
        private System.Windows.Forms.GroupBox EnvironmentsGroup;
        private System.Windows.Forms.CheckBox ProdCheckbox;
        private System.Windows.Forms.CheckBox PilotCheckbox;
        private System.Windows.Forms.CheckBox TestCheckbox;
        private System.Windows.Forms.CheckBox DevCheckbox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox SPList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ServerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DatabaseList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeployButton;
        private System.Windows.Forms.Button GenerateScriptsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox SPTextBox;
        private System.Windows.Forms.CheckBox AllSitesCheckbox;
        private System.Windows.Forms.CheckBox AllEnvironmentsCheckbox;
        private System.Windows.Forms.CheckBox AllProceduresCheckbox;
    }
}

