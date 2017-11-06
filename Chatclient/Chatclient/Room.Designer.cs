namespace Chatclient
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.msgInputBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.ListView();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // msgInputBox
            // 
            this.msgInputBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.msgInputBox.Location = new System.Drawing.Point(13, 378);
            this.msgInputBox.Multiline = true;
            this.msgInputBox.Name = "msgInputBox";
            this.msgInputBox.Size = new System.Drawing.Size(831, 63);
            this.msgInputBox.TabIndex = 11;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(851, 378);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(119, 63);
            this.sendBtn.TabIndex = 12;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = true;
            // 
            // clientList
            // 
            this.clientList.Location = new System.Drawing.Point(851, 13);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(121, 358);
            this.clientList.TabIndex = 13;
            this.clientList.UseCompatibleStateImageBehavior = false;
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(12, 12);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(832, 359);
            this.msgBox.TabIndex = 14;
            this.msgBox.TextChanged += new System.EventHandler(this.msgBox_TextChanged);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox msgInputBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.ListView clientList;
        private System.Windows.Forms.TextBox msgBox;
    }
}