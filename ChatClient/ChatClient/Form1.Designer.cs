namespace ChatClient
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChatBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 67);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(56, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Enter Text";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(74, 64);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(159, 20);
            this.txtMessage.TabIndex = 3;
            // 
            // txtChatBox
            // 
            this.txtChatBox.BackColor = System.Drawing.SystemColors.Window;
            this.txtChatBox.Location = new System.Drawing.Point(12, 90);
            this.txtChatBox.Multiline = true;
            this.txtChatBox.Name = "txtChatBox";
            this.txtChatBox.ReadOnly = true;
            this.txtChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtChatBox.Size = new System.Drawing.Size(257, 209);
            this.txtChatBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 311);
            this.Controls.Add(this.txtChatBox);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Levelup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtChatBox;
    }
}

