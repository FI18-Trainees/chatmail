namespace ChatMail
{
    partial class ChatGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.recievedMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.recievedMessagesTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageRecieverListBox = new System.Windows.Forms.ListBox();
            this.sendMessageRecieverLabel = new System.Windows.Forms.Label();
            this.sendMessageSubmitButton = new System.Windows.Forms.Button();
            this.sendMessageInputTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageGroupBox.SuspendLayout();
            this.recievedMessageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMessageGroupBox
            // 
            this.sendMessageGroupBox.Controls.Add(this.sendMessageInputTextBox);
            this.sendMessageGroupBox.Controls.Add(this.sendMessageSubmitButton);
            this.sendMessageGroupBox.Controls.Add(this.sendMessageRecieverLabel);
            this.sendMessageGroupBox.Controls.Add(this.sendMessageRecieverListBox);
            this.sendMessageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.sendMessageGroupBox.Name = "sendMessageGroupBox";
            this.sendMessageGroupBox.Size = new System.Drawing.Size(1240, 318);
            this.sendMessageGroupBox.TabIndex = 0;
            this.sendMessageGroupBox.TabStop = false;
            this.sendMessageGroupBox.Text = "Send message";
            // 
            // recievedMessageGroupBox
            // 
            this.recievedMessageGroupBox.Controls.Add(this.recievedMessagesTextBox);
            this.recievedMessageGroupBox.Location = new System.Drawing.Point(12, 336);
            this.recievedMessageGroupBox.Name = "recievedMessageGroupBox";
            this.recievedMessageGroupBox.Size = new System.Drawing.Size(1240, 333);
            this.recievedMessageGroupBox.TabIndex = 2;
            this.recievedMessageGroupBox.TabStop = false;
            this.recievedMessageGroupBox.Text = "Recieved messages";
            // 
            // recievedMessagesTextBox
            // 
            this.recievedMessagesTextBox.Location = new System.Drawing.Point(6, 19);
            this.recievedMessagesTextBox.Multiline = true;
            this.recievedMessagesTextBox.Name = "recievedMessagesTextBox";
            this.recievedMessagesTextBox.Size = new System.Drawing.Size(1228, 308);
            this.recievedMessagesTextBox.TabIndex = 0;
            // 
            // sendMessageRecieverListBox
            // 
            this.sendMessageRecieverListBox.FormattingEnabled = true;
            this.sendMessageRecieverListBox.Location = new System.Drawing.Point(123, 34);
            this.sendMessageRecieverListBox.Name = "sendMessageRecieverListBox";
            this.sendMessageRecieverListBox.Size = new System.Drawing.Size(237, 43);
            this.sendMessageRecieverListBox.TabIndex = 0;
            // 
            // sendMessageRecieverLabel
            // 
            this.sendMessageRecieverLabel.AutoSize = true;
            this.sendMessageRecieverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageRecieverLabel.Location = new System.Drawing.Point(6, 37);
            this.sendMessageRecieverLabel.Name = "sendMessageRecieverLabel";
            this.sendMessageRecieverLabel.Size = new System.Drawing.Size(71, 20);
            this.sendMessageRecieverLabel.TabIndex = 1;
            this.sendMessageRecieverLabel.Text = "Reciever";
            // 
            // sendMessageSubmitButton
            // 
            this.sendMessageSubmitButton.Location = new System.Drawing.Point(528, 34);
            this.sendMessageSubmitButton.Name = "sendMessageSubmitButton";
            this.sendMessageSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.sendMessageSubmitButton.TabIndex = 2;
            this.sendMessageSubmitButton.Text = "Submit";
            this.sendMessageSubmitButton.UseVisualStyleBackColor = true;
            // 
            // sendMessageInputTextBox
            // 
            this.sendMessageInputTextBox.Location = new System.Drawing.Point(6, 86);
            this.sendMessageInputTextBox.Multiline = true;
            this.sendMessageInputTextBox.Name = "sendMessageInputTextBox";
            this.sendMessageInputTextBox.Size = new System.Drawing.Size(1228, 226);
            this.sendMessageInputTextBox.TabIndex = 3;
            // 
            // ChatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.recievedMessageGroupBox);
            this.Controls.Add(this.sendMessageGroupBox);
            this.Name = "ChatGUI";
            this.Text = "ChatMail";
            this.sendMessageGroupBox.ResumeLayout(false);
            this.sendMessageGroupBox.PerformLayout();
            this.recievedMessageGroupBox.ResumeLayout(false);
            this.recievedMessageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sendMessageGroupBox;
        private System.Windows.Forms.TextBox sendMessageInputTextBox;
        private System.Windows.Forms.Button sendMessageSubmitButton;
        private System.Windows.Forms.Label sendMessageRecieverLabel;
        private System.Windows.Forms.ListBox sendMessageRecieverListBox;
        private System.Windows.Forms.GroupBox recievedMessageGroupBox;
        private System.Windows.Forms.TextBox recievedMessagesTextBox;
    }
}

