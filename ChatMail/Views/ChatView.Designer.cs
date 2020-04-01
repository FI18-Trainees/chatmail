namespace ChatMail.Views
{
    partial class ChatView
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
            this.sendMessageInputTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageSubmitButton = new System.Windows.Forms.Button();
            this.sendMessageReceiverLabel = new System.Windows.Forms.Label();
            this.sendMessageReceiverListBox = new System.Windows.Forms.ListBox();
            this.receivedMessageGroupBox = new System.Windows.Forms.GroupBox();
            this.receivedMessagesTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chatFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatConsoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatAdminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageGroupBox.SuspendLayout();
            this.receivedMessageGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMessageGroupBox
            // 
            this.sendMessageGroupBox.Controls.Add(this.sendMessageInputTextBox);
            this.sendMessageGroupBox.Controls.Add(this.sendMessageSubmitButton);
            this.sendMessageGroupBox.Controls.Add(this.sendMessageReceiverLabel);
            this.sendMessageGroupBox.Controls.Add(this.sendMessageReceiverListBox);
            this.sendMessageGroupBox.Location = new System.Drawing.Point(12, 53);
            this.sendMessageGroupBox.Name = "sendMessageGroupBox";
            this.sendMessageGroupBox.Size = new System.Drawing.Size(1240, 318);
            this.sendMessageGroupBox.TabIndex = 0;
            this.sendMessageGroupBox.TabStop = false;
            this.sendMessageGroupBox.Text = "Send message";
            // 
            // sendMessageInputTextBox
            // 
            this.sendMessageInputTextBox.Location = new System.Drawing.Point(6, 86);
            this.sendMessageInputTextBox.Multiline = true;
            this.sendMessageInputTextBox.Name = "sendMessageInputTextBox";
            this.sendMessageInputTextBox.Size = new System.Drawing.Size(1228, 226);
            this.sendMessageInputTextBox.TabIndex = 3;
            // 
            // sendMessageSubmitButton
            // 
            this.sendMessageSubmitButton.Location = new System.Drawing.Point(366, 34);
            this.sendMessageSubmitButton.Name = "sendMessageSubmitButton";
            this.sendMessageSubmitButton.Size = new System.Drawing.Size(868, 43);
            this.sendMessageSubmitButton.TabIndex = 2;
            this.sendMessageSubmitButton.Text = "Submit";
            this.sendMessageSubmitButton.UseVisualStyleBackColor = true;
            // 
            // sendMessageReceiverLabel
            // 
            this.sendMessageReceiverLabel.AutoSize = true;
            this.sendMessageReceiverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessageReceiverLabel.Location = new System.Drawing.Point(2, 44);
            this.sendMessageReceiverLabel.Name = "sendMessageReceiverLabel";
            this.sendMessageReceiverLabel.Size = new System.Drawing.Size(75, 20);
            this.sendMessageReceiverLabel.TabIndex = 1;
            this.sendMessageReceiverLabel.Text = "Receiver:";
            // 
            // sendMessageReceiverListBox
            // 
            this.sendMessageReceiverListBox.FormattingEnabled = true;
            this.sendMessageReceiverListBox.Location = new System.Drawing.Point(83, 34);
            this.sendMessageReceiverListBox.Name = "sendMessageReceiverListBox";
            this.sendMessageReceiverListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.sendMessageReceiverListBox.Size = new System.Drawing.Size(277, 43);
            this.sendMessageReceiverListBox.TabIndex = 0;
            // 
            // receivedMessageGroupBox
            // 
            this.receivedMessageGroupBox.Controls.Add(this.receivedMessagesTextBox);
            this.receivedMessageGroupBox.Location = new System.Drawing.Point(12, 377);
            this.receivedMessageGroupBox.Name = "receivedMessageGroupBox";
            this.receivedMessageGroupBox.Size = new System.Drawing.Size(1240, 292);
            this.receivedMessageGroupBox.TabIndex = 2;
            this.receivedMessageGroupBox.TabStop = false;
            this.receivedMessageGroupBox.Text = "Received messages";
            // 
            // receivedMessagesTextBox
            // 
            this.receivedMessagesTextBox.Location = new System.Drawing.Point(6, 19);
            this.receivedMessagesTextBox.Multiline = true;
            this.receivedMessagesTextBox.Name = "receivedMessagesTextBox";
            this.receivedMessagesTextBox.ReadOnly = true;
            this.receivedMessagesTextBox.Size = new System.Drawing.Size(1228, 308);
            this.receivedMessagesTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatFileMenuItem,
            this.chatConsoleMenuItem,
            this.chatAdminMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chatFileMenuItem
            // 
            this.chatFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chatCloseMenuItem});
            this.chatFileMenuItem.Name = "chatFileMenuItem";
            this.chatFileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.chatFileMenuItem.Text = "File";
            // 
            // chatCloseMenuItem
            // 
            this.chatCloseMenuItem.Name = "chatCloseMenuItem";
            this.chatCloseMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chatCloseMenuItem.Text = "Close";
            // 
            // chatConsoleMenuItem
            // 
            this.chatConsoleMenuItem.Name = "chatConsoleMenuItem";
            this.chatConsoleMenuItem.Size = new System.Drawing.Size(62, 20);
            this.chatConsoleMenuItem.Text = "Console";
            // 
            // chatAdminMenuItem
            // 
            this.chatAdminMenuItem.Name = "chatAdminMenuItem";
            this.chatAdminMenuItem.Size = new System.Drawing.Size(55, 20);
            this.chatAdminMenuItem.Text = "Admin";
            // 
            // ChatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.receivedMessageGroupBox);
            this.Controls.Add(this.sendMessageGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChatView";
            this.Text = "ChatMail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatView_FormClosing);
            this.sendMessageGroupBox.ResumeLayout(false);
            this.sendMessageGroupBox.PerformLayout();
            this.receivedMessageGroupBox.ResumeLayout(false);
            this.receivedMessageGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sendMessageGroupBox;
        private System.Windows.Forms.TextBox sendMessageInputTextBox;
        private System.Windows.Forms.Button sendMessageSubmitButton;
        private System.Windows.Forms.Label sendMessageReceiverLabel;
        private System.Windows.Forms.ListBox sendMessageReceiverListBox;
        private System.Windows.Forms.GroupBox receivedMessageGroupBox;
        private System.Windows.Forms.TextBox receivedMessagesTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chatFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatCloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatConsoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatAdminMenuItem;
    }
}

