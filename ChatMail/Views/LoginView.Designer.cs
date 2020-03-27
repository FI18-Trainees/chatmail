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
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.userSelectLoginButton);
            this.Controls.Add(this.userSelectComboBox);
            this.Name = "LoginView";
            this.Text = "ChatMail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox userSelectComboBox;
        private System.Windows.Forms.Button userSelectLoginButton;
    }
}