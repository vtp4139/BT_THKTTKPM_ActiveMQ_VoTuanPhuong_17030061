namespace MSSQ_Receive
{
    partial class F_MessageReceive
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
            this.MessagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MessagesRichTextBox
            // 
            this.MessagesRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.MessagesRichTextBox.Name = "MessagesRichTextBox";
            this.MessagesRichTextBox.Size = new System.Drawing.Size(660, 337);
            this.MessagesRichTextBox.TabIndex = 0;
            this.MessagesRichTextBox.Text = "";
            // 
            // F_MessageReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.MessagesRichTextBox);
            this.Name = "F_MessageReceive";
            this.Text = "Message Receive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MessagesRichTextBox;
    }
}

