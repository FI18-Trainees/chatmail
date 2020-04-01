namespace ChatMail.Views
{
    partial class ConsoleView
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
            this.consoleViewListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // consoleViewListBox
            // 
            this.consoleViewListBox.FormattingEnabled = true;
            this.consoleViewListBox.Location = new System.Drawing.Point(19, 40);
            this.consoleViewListBox.Name = "consoleViewListBox";
            this.consoleViewListBox.Size = new System.Drawing.Size(769, 342);
            this.consoleViewListBox.TabIndex = 0;
            // 
            // ConsoleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.consoleViewListBox);
            this.Name = "ConsoleView";
            this.Text = "ConsoleView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox consoleViewListBox;
    }
}