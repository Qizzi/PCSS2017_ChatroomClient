namespace Chatclient
{
    partial class connectWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectWin));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.instructTxt = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(9, 40);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(188, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // instructTxt
            // 
            this.instructTxt.AutoSize = true;
            this.instructTxt.Location = new System.Drawing.Point(44, 17);
            this.instructTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructTxt.Name = "instructTxt";
            this.instructTxt.Size = new System.Drawing.Size(118, 13);
            this.instructTxt.TabIndex = 1;
            this.instructTxt.Text = "Please Enter Username";
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(71, 71);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(66, 25);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 108);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.instructTxt);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "connectWin";
            this.Text = "Blast It! ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label instructTxt;
        private System.Windows.Forms.Button connectBtn;
    }
}

