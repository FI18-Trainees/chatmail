namespace ChatMail.Views
{
    partial class LoginView
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
            this.userSelectComboBox = new System.Windows.Forms.ComboBox();
            this.userSelectLoginButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginCloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginConsoleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginAdminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userSelectComboBox
            // 
            this.userSelectComboBox.FormattingEnabled = true;
            this.userSelectComboBox.Location = new System.Drawing.Point(256, 103);
            this.userSelectComboBox.Name = "userSelectComboBox";
            this.userSelectComboBox.Size = new System.Drawing.Size(709, 21);
            this.userSelectComboBox.TabIndex = 0;
            // 
            // userSelectLoginButton
            // 
            this.userSelectLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSelectLoginButton.Location = new System.Drawing.Point(256, 364);
            this.userSelectLoginButton.Name = "userSelectLoginButton";
            this.userSelectLoginButton.Size = new System.Drawing.Size(708, 99);
            this.userSelectLoginButton.TabIndex = 1;
            this.userSelectLoginButton.Text = "Login";
            this.userSelectLoginButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFileMenuItem,
            this.loginConsoleMenuItem,
            this.loginAdminMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginFileMenuItem
            // 
            this.loginFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginCloseMenuItem});
            this.loginFileMenuItem.Name = "loginFileMenuItem";
            this.loginFileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loginFileMenuItem.Text = "File";
            // 
            // loginCloseMenuItem
            // 
            this.loginCloseMenuItem.Name = "loginCloseMenuItem";
            this.loginCloseMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginCloseMenuItem.Text = "Close";
            // 
            // loginConsoleMenuItem
            // 
            this.loginConsoleMenuItem.Name = "loginConsoleMenuItem";
            this.loginConsoleMenuItem.Size = new System.Drawing.Size(62, 20);
            this.loginConsoleMenuItem.Text = "Console";
            // 
            // loginAdminMenuItem
            // 
            this.loginAdminMenuItem.Name = "loginAdminMenuItem";
            this.loginAdminMenuItem.Size = new System.Drawing.Size(55, 20);
            this.loginAdminMenuItem.Text = "Admin";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.userSelectLoginButton);
            this.Controls.Add(this.userSelectComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginView";
            this.Text = "ChatMail";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userSelectComboBox;
        private System.Windows.Forms.Button userSelectLoginButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginCloseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginConsoleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginAdminMenuItem;
    }
}