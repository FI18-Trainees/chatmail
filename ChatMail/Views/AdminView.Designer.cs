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
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDataGridView
            // 
            this.adminDataGridView.AllowUserToDeleteRows = false;
            this.adminDataGridView.AutoGenerateColumns = false;
            this.adminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIdDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.displaynameDataGridViewTextBoxColumn});
            this.adminDataGridView.DataSource = this.userBindingSource;
            this.adminDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.adminDataGridView.Location = new System.Drawing.Point(12, 12);
            this.adminDataGridView.MultiSelect = false;
            this.adminDataGridView.Name = "adminDataGridView";
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
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminDataGridView);
            this.Name = "AdminView";
            this.Text = "AdminView";
            ((System.ComponentModel.ISupportInitialize)(this.adminDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}