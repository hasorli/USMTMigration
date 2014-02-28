﻿namespace USMTMigration
{
    partial class SettingsGUI
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
            this.BackupLocationText = new System.Windows.Forms.TextBox();
            this.BackupLocationLabel = new System.Windows.Forms.Label();
            this.LogLocationLabel = new System.Windows.Forms.Label();
            this.LogLocationText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ArgumentsText = new System.Windows.Forms.TextBox();
            this.ArgumentsLabel = new System.Windows.Forms.Label();
            this.ComputerNameLabel = new System.Windows.Forms.Label();
            this.ComputerNameText = new System.Windows.Forms.TextBox();
            this.LookUpArgumentsLabel = new System.Windows.Forms.LinkLabel();
            this.OverwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.USMTLocationLabel = new System.Windows.Forms.Label();
            this.USMTLocationText = new System.Windows.Forms.TextBox();
            this.DomainLabel = new System.Windows.Forms.Label();
            this.DomainText = new System.Windows.Forms.TextBox();
            this.OlderThan = new System.Windows.Forms.NumericUpDown();
            this.OlderThanLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OlderThan)).BeginInit();
            this.SuspendLayout();
            // 
            // BackupLocationText
            // 
            this.BackupLocationText.Location = new System.Drawing.Point(109, 32);
            this.BackupLocationText.Name = "BackupLocationText";
            this.BackupLocationText.Size = new System.Drawing.Size(237, 20);
            this.BackupLocationText.TabIndex = 0;
            // 
            // BackupLocationLabel
            // 
            this.BackupLocationLabel.AutoSize = true;
            this.BackupLocationLabel.Location = new System.Drawing.Point(12, 35);
            this.BackupLocationLabel.Name = "BackupLocationLabel";
            this.BackupLocationLabel.Size = new System.Drawing.Size(91, 13);
            this.BackupLocationLabel.TabIndex = 1;
            this.BackupLocationLabel.Text = "Backup Location:";
            // 
            // LogLocationLabel
            // 
            this.LogLocationLabel.AutoSize = true;
            this.LogLocationLabel.Location = new System.Drawing.Point(12, 61);
            this.LogLocationLabel.Name = "LogLocationLabel";
            this.LogLocationLabel.Size = new System.Drawing.Size(72, 13);
            this.LogLocationLabel.TabIndex = 2;
            this.LogLocationLabel.Text = "Log Location:";
            // 
            // LogLocationText
            // 
            this.LogLocationText.Location = new System.Drawing.Point(109, 58);
            this.LogLocationText.Name = "LogLocationText";
            this.LogLocationText.Size = new System.Drawing.Size(237, 20);
            this.LogLocationText.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(316, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(397, 226);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ArgumentsText
            // 
            this.ArgumentsText.Location = new System.Drawing.Point(109, 137);
            this.ArgumentsText.Name = "ArgumentsText";
            this.ArgumentsText.Size = new System.Drawing.Size(237, 20);
            this.ArgumentsText.TabIndex = 6;
            // 
            // ArgumentsLabel
            // 
            this.ArgumentsLabel.AutoSize = true;
            this.ArgumentsLabel.Location = new System.Drawing.Point(12, 140);
            this.ArgumentsLabel.Name = "ArgumentsLabel";
            this.ArgumentsLabel.Size = new System.Drawing.Size(60, 13);
            this.ArgumentsLabel.TabIndex = 7;
            this.ArgumentsLabel.Text = "Arguments:";
            // 
            // ComputerNameLabel
            // 
            this.ComputerNameLabel.AutoSize = true;
            this.ComputerNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ComputerNameLabel.Name = "ComputerNameLabel";
            this.ComputerNameLabel.Size = new System.Drawing.Size(86, 13);
            this.ComputerNameLabel.TabIndex = 8;
            this.ComputerNameLabel.Text = "Computer Name:";
            // 
            // ComputerNameText
            // 
            this.ComputerNameText.Location = new System.Drawing.Point(109, 6);
            this.ComputerNameText.Name = "ComputerNameText";
            this.ComputerNameText.Size = new System.Drawing.Size(237, 20);
            this.ComputerNameText.TabIndex = 9;
            // 
            // LookUpArgumentsLabel
            // 
            this.LookUpArgumentsLabel.AutoSize = true;
            this.LookUpArgumentsLabel.Location = new System.Drawing.Point(351, 140);
            this.LookUpArgumentsLabel.Name = "LookUpArgumentsLabel";
            this.LookUpArgumentsLabel.Size = new System.Drawing.Size(48, 13);
            this.LookUpArgumentsLabel.TabIndex = 10;
            this.LookUpArgumentsLabel.TabStop = true;
            this.LookUpArgumentsLabel.Text = "Look Up";
            this.LookUpArgumentsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LookUpArgumentsLabel_LinkClicked);
            // 
            // OverwriteCheckbox
            // 
            this.OverwriteCheckbox.AutoSize = true;
            this.OverwriteCheckbox.Location = new System.Drawing.Point(15, 189);
            this.OverwriteCheckbox.Name = "OverwriteCheckbox";
            this.OverwriteCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OverwriteCheckbox.Size = new System.Drawing.Size(223, 17);
            this.OverwriteCheckbox.TabIndex = 11;
            this.OverwriteCheckbox.Text = "Overwrite existing backups. (/o argument)";
            this.OverwriteCheckbox.UseVisualStyleBackColor = true;
            // 
            // USMTLocationLabel
            // 
            this.USMTLocationLabel.AutoSize = true;
            this.USMTLocationLabel.Location = new System.Drawing.Point(12, 87);
            this.USMTLocationLabel.Name = "USMTLocationLabel";
            this.USMTLocationLabel.Size = new System.Drawing.Size(85, 13);
            this.USMTLocationLabel.TabIndex = 12;
            this.USMTLocationLabel.Text = "USMT Location:";
            // 
            // USMTLocationText
            // 
            this.USMTLocationText.Location = new System.Drawing.Point(109, 84);
            this.USMTLocationText.Name = "USMTLocationText";
            this.USMTLocationText.Size = new System.Drawing.Size(237, 20);
            this.USMTLocationText.TabIndex = 13;
            // 
            // DomainLabel
            // 
            this.DomainLabel.AutoSize = true;
            this.DomainLabel.Location = new System.Drawing.Point(12, 114);
            this.DomainLabel.Name = "DomainLabel";
            this.DomainLabel.Size = new System.Drawing.Size(46, 13);
            this.DomainLabel.TabIndex = 14;
            this.DomainLabel.Text = "Domain:";
            // 
            // DomainText
            // 
            this.DomainText.Location = new System.Drawing.Point(109, 111);
            this.DomainText.Name = "DomainText";
            this.DomainText.Size = new System.Drawing.Size(237, 20);
            this.DomainText.TabIndex = 15;
            // 
            // OlderThan
            // 
            this.OlderThan.Location = new System.Drawing.Point(188, 163);
            this.OlderThan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.OlderThan.Name = "OlderThan";
            this.OlderThan.Size = new System.Drawing.Size(48, 20);
            this.OlderThan.TabIndex = 16;
            // 
            // OlderThanLabel
            // 
            this.OlderThanLabel.AutoSize = true;
            this.OlderThanLabel.Location = new System.Drawing.Point(12, 165);
            this.OlderThanLabel.Name = "OlderThanLabel";
            this.OlderThanLabel.Size = new System.Drawing.Size(170, 13);
            this.OlderThanLabel.TabIndex = 17;
            this.OlderThanLabel.Text = "Only migrate if accessed in the last";
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Location = new System.Drawing.Point(242, 165);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(32, 13);
            this.DaysLabel.TabIndex = 18;
            this.DaysLabel.Text = "days.";
            // 
            // SettingsGUI
            // 
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.OlderThanLabel);
            this.Controls.Add(this.OlderThan);
            this.Controls.Add(this.DomainText);
            this.Controls.Add(this.DomainLabel);
            this.Controls.Add(this.USMTLocationText);
            this.Controls.Add(this.USMTLocationLabel);
            this.Controls.Add(this.OverwriteCheckbox);
            this.Controls.Add(this.LookUpArgumentsLabel);
            this.Controls.Add(this.ComputerNameText);
            this.Controls.Add(this.ComputerNameLabel);
            this.Controls.Add(this.ArgumentsLabel);
            this.Controls.Add(this.ArgumentsText);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LogLocationText);
            this.Controls.Add(this.LogLocationLabel);
            this.Controls.Add(this.BackupLocationLabel);
            this.Controls.Add(this.BackupLocationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsGUI";
            ((System.ComponentModel.ISupportInitialize)(this.OlderThan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BackupLocationText;
        private System.Windows.Forms.Label BackupLocationLabel;
        private System.Windows.Forms.Label LogLocationLabel;
        private System.Windows.Forms.TextBox LogLocationText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox ArgumentsText;
        private System.Windows.Forms.Label ArgumentsLabel;
        private System.Windows.Forms.Label ComputerNameLabel;
        private System.Windows.Forms.TextBox ComputerNameText;
        private System.Windows.Forms.LinkLabel LookUpArgumentsLabel;
        private System.Windows.Forms.CheckBox OverwriteCheckbox;
        private System.Windows.Forms.Label USMTLocationLabel;
        private System.Windows.Forms.TextBox USMTLocationText;
        private System.Windows.Forms.Label DomainLabel;
        private System.Windows.Forms.TextBox DomainText;
        private System.Windows.Forms.NumericUpDown OlderThan;
        private System.Windows.Forms.Label OlderThanLabel;
        private System.Windows.Forms.Label DaysLabel;

    }
}