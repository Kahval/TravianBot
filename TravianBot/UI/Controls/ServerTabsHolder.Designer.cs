﻿namespace TravianBot.UI.Controls
{
    partial class ServerTabsHolder
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
            this.svTabs = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // svTabs
            // 
            this.svTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svTabs.Location = new System.Drawing.Point(0, 0);
            this.svTabs.Name = "svTabs";
            this.svTabs.SelectedIndex = 0;
            this.svTabs.Size = new System.Drawing.Size(658, 484);
            this.svTabs.TabIndex = 2;
            // 
            // ServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.svTabs);
            this.Name = "ServerView";
            this.Size = new System.Drawing.Size(658, 484);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl svTabs;
    }
}
