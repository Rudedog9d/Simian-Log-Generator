﻿namespace WCM_Log_Generator
{
    partial class Main
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
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.DirectoryPicker = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSelectSourceDirectory = new System.Windows.Forms.Button();
            this.btnSelectDestDirectory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileExtensions = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Location = new System.Drawing.Point(107, 9);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(327, 20);
            this.txtSourceDirectory.TabIndex = 0;
            this.txtSourceDirectory.Text = "C:\\Temp\\WCM";
            // 
            // DirectoryPicker
            // 
            this.DirectoryPicker.FileName = "DirectoryPicker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source Directrory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Directory";
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Location = new System.Drawing.Point(107, 102);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.Size = new System.Drawing.Size(327, 20);
            this.txtOutputDirectory.TabIndex = 2;
            this.txtOutputDirectory.Text = "C:\\Temp\\WCM\\out";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSelectSourceDirectory
            // 
            this.btnSelectSourceDirectory.Location = new System.Drawing.Point(440, 7);
            this.btnSelectSourceDirectory.Name = "btnSelectSourceDirectory";
            this.btnSelectSourceDirectory.Size = new System.Drawing.Size(106, 23);
            this.btnSelectSourceDirectory.TabIndex = 4;
            this.btnSelectSourceDirectory.Text = "Select Directory...";
            this.btnSelectSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSelectSourceDirectory.Click += new System.EventHandler(this.btnSelectSourceDirectory_Click);
            // 
            // btnSelectDestDirectory
            // 
            this.btnSelectDestDirectory.Location = new System.Drawing.Point(440, 100);
            this.btnSelectDestDirectory.Name = "btnSelectDestDirectory";
            this.btnSelectDestDirectory.Size = new System.Drawing.Size(106, 23);
            this.btnSelectDestDirectory.TabIndex = 5;
            this.btnSelectDestDirectory.Text = "Select Directory...";
            this.btnSelectDestDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDestDirectory.Click += new System.EventHandler(this.btnSelectDestDirectory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File Extensions";
            // 
            // txtFileExtensions
            // 
            this.txtFileExtensions.Location = new System.Drawing.Point(107, 35);
            this.txtFileExtensions.Name = "txtFileExtensions";
            this.txtFileExtensions.Size = new System.Drawing.Size(327, 20);
            this.txtFileExtensions.TabIndex = 6;
            this.txtFileExtensions.Text = "*.mp3";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(440, 306);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFileExtensions);
            this.Controls.Add(this.btnSelectDestDirectory);
            this.Controls.Add(this.btnSelectSourceDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSourceDirectory);
            this.Name = "Main";
            this.Text = "Simian Log Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.OpenFileDialog DirectoryPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSelectSourceDirectory;
        private System.Windows.Forms.Button btnSelectDestDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileExtensions;
        private System.Windows.Forms.Button btnGenerate;
    }
}

