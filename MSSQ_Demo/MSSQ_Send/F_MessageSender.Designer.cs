namespace MSSQ_Send
{
    partial class F_MessageSender
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SendObjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(660, 203);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(12, 231);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(124, 50);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Send Text";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // SendObjectButton
            // 
            this.SendObjectButton.Location = new System.Drawing.Point(142, 231);
            this.SendObjectButton.Name = "SendObjectButton";
            this.SendObjectButton.Size = new System.Drawing.Size(124, 50);
            this.SendObjectButton.TabIndex = 1;
            this.SendObjectButton.Text = "Send Object";
            this.SendObjectButton.UseVisualStyleBackColor = true;
            this.SendObjectButton.Click += new System.EventHandler(this.SendObjectButton_Click_1);
            // 
            // F_MessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.SendObjectButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "F_MessageSender";
            this.Text = "Message Sender";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button SendObjectButton;
    }
}

