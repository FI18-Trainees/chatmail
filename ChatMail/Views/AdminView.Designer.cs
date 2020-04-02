namespace ChatMail.Views
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            this.adminDataGridView = new System.Windows.Forms.DataGridView();
            this.uIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminAddUserButton = new System.Windows.Forms.Button();
            this.adminFirstnameTextBox = new System.Windows.Forms.TextBox();
            this.adminLastnameTextBox = new System.Windows.Forms.TextBox();
            this.adminDisplaynameTextBox = new System.Windows.Forms.TextBox();
            this.adminFirstnameLabel = new System.Windows.Forms.Label();
            this.adminLastnameLabel = new System.Windows.Forms.Label();
            this.adminDisplaynameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AllowUserToAddRows = false;
            this.adminDataGridView.AllowUserToDeleteRows = false;
            this.adminDataGridView.AutoGenerateColumns = false;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIdDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.displaynameDataGridViewTextBoxColumn});
            this.adminDataGridView.DataSource = this.userBindingSource;
            this.adminDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.adminDataGridView.Location = new System.Drawing.Point(12, 12);
            this.adminDataGridView.MultiSelect = false;
            this.adminDataGridView.Name = "adminDataGridView";
            this.adminDataGridView.ReadOnly = true;
            this.adminDataGridView.Size = new System.Drawing.Size(776, 150);
            this.adminDataGridView.TabIndex = 0;
            // 
            // uIdDataGridViewTextBoxColumn
            // 
            this.uIdDataGridViewTextBoxColumn.DataPropertyName = "UId";
            this.uIdDataGridViewTextBoxColumn.HeaderText = "UId";
            this.uIdDataGridViewTextBoxColumn.Name = "uIdDataGridViewTextBoxColumn";
            this.uIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displaynameDataGridViewTextBoxColumn
            // 
            this.displaynameDataGridViewTextBoxColumn.DataPropertyName = "Displayname";
            this.displaynameDataGridViewTextBoxColumn.HeaderText = "Displayname";
            this.displaynameDataGridViewTextBoxColumn.Name = "displaynameDataGridViewTextBoxColumn";
            this.displaynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.AllowNew = false;
            this.userBindingSource.DataSource = typeof(ChatMail.Models.User);
            // 
            // adminAddUserButton
            // 
            this.adminAddUserButton.Location = new System.Drawing.Point(455, 207);
            this.adminAddUserButton.Name = "adminAddUserButton";
            this.adminAddUserButton.Size = new System.Drawing.Size(130, 40);
            this.adminAddUserButton.TabIndex = 1;
            this.adminAddUserButton.Text = "Add User";
            this.adminAddUserButton.UseVisualStyleBackColor = true;
            // 
            // adminFirstnameTextBox
            // 
            this.adminFirstnameTextBox.Location = new System.Drawing.Point(103, 181);
            this.adminFirstnameTextBox.Name = "adminFirstnameTextBox";
            this.adminFirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminFirstnameTextBox.TabIndex = 2;
            // 
            // adminLastnameTextBox
            // 
            this.adminLastnameTextBox.Location = new System.Drawing.Point(292, 181);
            this.adminLastnameTextBox.Name = "adminLastnameTextBox";
            this.adminLastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminLastnameTextBox.TabIndex = 3;
            // 
            // adminDisplaynameTextBox
            // 
            this.adminDisplaynameTextBox.Location = new System.Drawing.Point(485, 181);
            this.adminDisplaynameTextBox.Name = "adminDisplaynameTextBox";
            this.adminDisplaynameTextBox.Size = new System.Drawing.Size(100, 20);
            this.adminDisplaynameTextBox.TabIndex = 4;
            // 
            // adminFirstnameLabel
            // 
            this.adminFirstnameLabel.AutoSize = true;
            this.adminFirstnameLabel.Location = new System.Drawing.Point(45, 184);
            this.adminFirstnameLabel.Name = "adminFirstnameLabel";
            this.adminFirstnameLabel.Size = new System.Drawing.Size(52, 13);
            this.adminFirstnameLabel.TabIndex = 5;
            this.adminFirstnameLabel.Text = "Firstname";
            // 
            // adminLastnameLabel
            // 
            this.adminLastnameLabel.AutoSize = true;
            this.adminLastnameLabel.Location = new System.Drawing.Point(233, 184);
            this.adminLastnameLabel.Name = "adminLastnameLabel";
            this.adminLastnameLabel.Size = new System.Drawing.Size(53, 13);
            this.adminLastnameLabel.TabIndex = 6;
            this.adminLastnameLabel.Text = "Lastname";
            // 
            // adminDisplaynameLabel
            // 
            this.adminDisplaynameLabel.AutoSize = true;
            this.adminDisplaynameLabel.Location = new System.Drawing.Point(412, 184);
            this.adminDisplaynameLabel.Name = "adminDisplaynameLabel";
            this.adminDisplaynameLabel.Size = new System.Drawing.Size(67, 13);
            this.adminDisplaynameLabel.TabIndex = 7;
            this.adminDisplaynameLabel.Text = "Displayname";
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminDisplaynameLabel);
            this.Controls.Add(this.adminLastnameLabel);
            this.Controls.Add(this.adminFirstnameLabel);
            this.Controls.Add(this.adminDisplaynameTextBox);
            this.Controls.Add(this.adminLastnameTextBox);
            this.Controls.Add(this.adminFirstnameTextBox);
            this.Controls.Add(this.adminAddUserButton);
            this.Controls.Add(this.adminDataGridView);
            this.Name = "AdminView";
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button adminAddUserButton;
        private System.Windows.Forms.TextBox adminFirstnameTextBox;
        private System.Windows.Forms.TextBox adminLastnameTextBox;
        private System.Windows.Forms.TextBox adminDisplaynameTextBox;
        private System.Windows.Forms.Label adminFirstnameLabel;
        private System.Windows.Forms.Label adminLastnameLabel;
        private System.Windows.Forms.Label adminDisplaynameLabel;
    }
}