﻿namespace Chatclient
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.serverList = new System.Windows.Forms.ListBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.joinBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverList
            // 
            this.serverList.FormattingEnabled = true;
            this.serverList.Location = new System.Drawing.Point(9, 10);
            this.serverList.Margin = new System.Windows.Forms.Padding(2);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(638, 355);
            this.serverList.TabIndex = 0;
            this.serverList.SelectedIndexChanged += new System.EventHandler(this.serverList_SelectedIndexChanged);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(671, 10);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(56, 19);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(671, 336);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(56, 23);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // joinBtn
            // 
            this.joinBtn.Location = new System.Drawing.Point(671, 44);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(56, 23);
            this.joinBtn.TabIndex = 3;
            this.joinBtn.Text = "Join";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 368);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.serverList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox serverList;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button joinBtn;
    }
}