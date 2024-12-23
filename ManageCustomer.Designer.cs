namespace Game
{
    partial class ManageCustomer
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
            this.gbCustomerManager = new System.Windows.Forms.GroupBox();
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblEmployeeList = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.gbCustomerManager.SuspendLayout();
            this.gbCustomerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerManager
            // 
            this.gbCustomerManager.Controls.Add(this.label1);
            this.gbCustomerManager.Controls.Add(this.gbCustomerInformation);
            this.gbCustomerManager.Controls.Add(this.txtSearch);
            this.gbCustomerManager.Controls.Add(this.dtgCustomer);
            this.gbCustomerManager.Controls.Add(this.lblEmployeeList);
            this.gbCustomerManager.Location = new System.Drawing.Point(60, 43);
            this.gbCustomerManager.Name = "gbCustomerManager";
            this.gbCustomerManager.Size = new System.Drawing.Size(647, 298);
            this.gbCustomerManager.TabIndex = 24;
            this.gbCustomerManager.TabStop = false;
            this.gbCustomerManager.Text = "Customer Manager";
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.txtCustomerAddress);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerCode);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerName);
            this.gbCustomerInformation.Controls.Add(this.btnDelete);
            this.gbCustomerInformation.Controls.Add(this.btnClear);
            this.gbCustomerInformation.Controls.Add(this.btnAdd);
            this.gbCustomerInformation.Controls.Add(this.txtCustomerName);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerAddress);
            this.gbCustomerInformation.Controls.Add(this.btnUpdate);
            this.gbCustomerInformation.Controls.Add(this.lblPhonenumber);
            this.gbCustomerInformation.Controls.Add(this.lblCustomerCode);
            this.gbCustomerInformation.Controls.Add(this.txtPhonenumber);
            this.gbCustomerInformation.Location = new System.Drawing.Point(6, 21);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(330, 269);
            this.gbCustomerInformation.TabIndex = 23;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Customer Information";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(121, 21);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(203, 22);
            this.txtCustomerCode.TabIndex = 9;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(11, 49);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(121, 49);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(203, 22);
            this.txtCustomerName.TabIndex = 10;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.Location = new System.Drawing.Point(11, 107);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(58, 16);
            this.lblCustomerAddress.TabIndex = 3;
            this.lblCustomerAddress.Text = "Address";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(249, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(11, 77);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(91, 16);
            this.lblPhonenumber.TabIndex = 5;
            this.lblPhonenumber.Text = "Phonenumber";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(11, 21);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerCode.TabIndex = 4;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(121, 77);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(203, 22);
            this.txtPhonenumber.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(352, 43);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 24;
            this.dtgCustomer.Size = new System.Drawing.Size(289, 232);
            this.dtgCustomer.TabIndex = 21;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(496, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(145, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // lblEmployeeList
            // 
            this.lblEmployeeList.AutoSize = true;
            this.lblEmployeeList.Location = new System.Drawing.Point(349, 18);
            this.lblEmployeeList.Name = "lblEmployeeList";
            this.lblEmployeeList.Size = new System.Drawing.Size(83, 16);
            this.lblEmployeeList.TabIndex = 8;
            this.lblEmployeeList.Text = "Customer list";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(43, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(121, 107);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(203, 127);
            this.txtCustomerAddress.TabIndex = 19;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCustomerManager);
            this.Controls.Add(this.btnBack);
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            this.gbCustomerManager.ResumeLayout(false);
            this.gbCustomerManager.PerformLayout();
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomerManager;
        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblEmployeeList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerAddress;
    }
}