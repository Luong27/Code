namespace Game
{
    partial class ManageEmployee_Form
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
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAuthorityLevel = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeePosition = new System.Windows.Forms.TextBox();
            this.cbAuthorityLevel = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.gbManageEmployee = new System.Windows.Forms.GroupBox();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.gbManageEmployee.SuspendLayout();
            this.gbEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblAuthorityLevel
            // 
            this.lblAuthorityLevel.AutoSize = true;
            this.lblAuthorityLevel.Location = new System.Drawing.Point(12, 107);
            this.lblAuthorityLevel.Name = "lblAuthorityLevel";
            this.lblAuthorityLevel.Size = new System.Drawing.Size(36, 16);
            this.lblAuthorityLevel.TabIndex = 3;
            this.lblAuthorityLevel.Text = "Role";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(12, 21);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(40, 16);
            this.lblEmployeeCode.TabIndex = 4;
            this.lblEmployeeCode.Text = "Code";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 77);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 5;
            this.lblPosition.Text = "Position";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 49);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(62, 16);
            this.lblEmployeeName.TabIndex = 7;
            this.lblEmployeeName.Text = "Fullname";
            this.lblEmployeeName.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Location = new System.Drawing.Point(257, 12);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(92, 16);
            this.lblEmployeeList.TabIndex = 8;
            this.lblEmployeeList.Text = "Employee List";
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(121, 15);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeeCode.TabIndex = 9;
            this.txtEmployeeCode.TextChanged += new System.EventHandler(this.txtEmployeeCode_TextChanged);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(121, 43);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // txtEmployeePosition
            // 
            this.txtEmployeePosition.Location = new System.Drawing.Point(121, 71);
            this.txtEmployeePosition.Name = "txtEmployeePosition";
            this.txtEmployeePosition.Size = new System.Drawing.Size(121, 22);
            this.txtEmployeePosition.TabIndex = 11;
            this.txtEmployeePosition.TextChanged += new System.EventHandler(this.txtEmployeePosition_TextChanged);
            // 
            // cbAuthorityLevel
            // 
            this.cbAuthorityLevel.FormattingEnabled = true;
            this.cbAuthorityLevel.Location = new System.Drawing.Point(121, 99);
            this.cbAuthorityLevel.Name = "cbAuthorityLevel";
            this.cbAuthorityLevel.Size = new System.Drawing.Size(121, 24);
            this.cbAuthorityLevel.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(121, 129);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 22);
            this.txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 157);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(121, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(145, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 232);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(121, 343);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(355, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Location = new System.Drawing.Point(260, 38);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersWidth = 51;
            this.dtgEmployee.RowTemplate.Height = 24;
            this.dtgEmployee.Size = new System.Drawing.Size(240, 254);
            this.dtgEmployee.TabIndex = 21;
            // 
            // gbManageEmployee
            // 
            this.gbManageEmployee.Controls.Add(this.gbEmployeeInformation);
            this.gbManageEmployee.Controls.Add(this.dtgEmployee);
            this.gbManageEmployee.Controls.Add(this.txtSearch);
            this.gbManageEmployee.Controls.Add(this.lblEmployeeList);
            this.gbManageEmployee.Location = new System.Drawing.Point(116, 39);
            this.gbManageEmployee.Name = "gbManageEmployee";
            this.gbManageEmployee.Size = new System.Drawing.Size(508, 298);
            this.gbManageEmployee.TabIndex = 22;
            this.gbManageEmployee.TabStop = false;
            this.gbManageEmployee.Text = "Manage Employee";
            this.gbManageEmployee.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbEmployeeInformation
            // 
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.lblUsername);
            this.gbEmployeeInformation.Controls.Add(this.btnAdd);
            this.gbEmployeeInformation.Controls.Add(this.txtPassword);
            this.gbEmployeeInformation.Controls.Add(this.lblPassword);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.lblAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.btnUpdate);
            this.gbEmployeeInformation.Controls.Add(this.txtUsername);
            this.gbEmployeeInformation.Controls.Add(this.btnClear);
            this.gbEmployeeInformation.Controls.Add(this.lblPosition);
            this.gbEmployeeInformation.Controls.Add(this.lblEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.txtEmployeePosition);
            this.gbEmployeeInformation.Controls.Add(this.cbAuthorityLevel);
            this.gbEmployeeInformation.Controls.Add(this.btnDelete);
            this.gbEmployeeInformation.Location = new System.Drawing.Point(6, 21);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(248, 269);
            this.gbEmployeeInformation.TabIndex = 23;
            this.gbEmployeeInformation.TabStop = false;
            this.gbEmployeeInformation.Text = "Employee Information";
            // 
            // ManageEmployee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbManageEmployee);
            this.Controls.Add(this.btnBack);
            this.Name = "ManageEmployee_Form";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.gbManageEmployee.ResumeLayout(false);
            this.gbManageEmployee.PerformLayout();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAuthorityLevel;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeePosition;
        private System.Windows.Forms.ComboBox cbAuthorityLevel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.GroupBox gbManageEmployee;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
    }
}