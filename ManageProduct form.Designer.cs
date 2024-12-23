namespace Game
{
    partial class ManageProduct_form
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
            this.gbProductData = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductImg = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtProductImg = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.gbProductInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProductData
            // 
            this.gbProductData.Controls.Add(this.txtSearch);
            this.gbProductData.Controls.Add(this.dtgProduct);
            this.gbProductData.Location = new System.Drawing.Point(306, 30);
            this.gbProductData.Name = "gbProductData";
            this.gbProductData.Size = new System.Drawing.Size(203, 298);
            this.gbProductData.TabIndex = 24;
            this.gbProductData.TabStop = false;
            this.gbProductData.Text = "Product Data";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(119, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // dtgProduct
            // 
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Location = new System.Drawing.Point(6, 49);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.RowHeadersWidth = 51;
            this.dtgProduct.RowTemplate.Height = 24;
            this.dtgProduct.Size = new System.Drawing.Size(191, 243);
            this.dtgProduct.TabIndex = 21;
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.btnUpload);
            this.gbProductInformation.Controls.Add(this.cbCategory);
            this.gbProductInformation.Controls.Add(this.txtProductCode);
            this.gbProductInformation.Controls.Add(this.lblProductName);
            this.gbProductInformation.Controls.Add(this.lblProductImg);
            this.gbProductInformation.Controls.Add(this.btnAdd);
            this.gbProductInformation.Controls.Add(this.txtProductQuantity);
            this.gbProductInformation.Controls.Add(this.lblCategory);
            this.gbProductInformation.Controls.Add(this.txtProductName);
            this.gbProductInformation.Controls.Add(this.lblProductQuantity);
            this.gbProductInformation.Controls.Add(this.btnUpdate);
            this.gbProductInformation.Controls.Add(this.txtProductImg);
            this.gbProductInformation.Controls.Add(this.btnClear);
            this.gbProductInformation.Controls.Add(this.lblProductPrice);
            this.gbProductInformation.Controls.Add(this.lblProductCode);
            this.gbProductInformation.Controls.Add(this.txtProductPrice);
            this.gbProductInformation.Controls.Add(this.btnDelete);
            this.gbProductInformation.Location = new System.Drawing.Point(52, 30);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(248, 292);
            this.gbProductInformation.TabIndex = 23;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Product Information";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(223, 154);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(19, 22);
            this.btnUpload.TabIndex = 19;
            this.btnUpload.Text = "...";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(121, 184);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 24);
            this.cbCategory.TabIndex = 12;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(121, 42);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(121, 22);
            this.txtProductCode.TabIndex = 9;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 76);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductImg
            // 
            this.lblProductImg.AutoSize = true;
            this.lblProductImg.Location = new System.Drawing.Point(12, 162);
            this.lblProductImg.Name = "lblProductImg";
            this.lblProductImg.Size = new System.Drawing.Size(94, 16);
            this.lblProductImg.TabIndex = 2;
            this.lblProductImg.Text = "Product Image";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(121, 126);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(121, 22);
            this.txtProductQuantity.TabIndex = 14;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(12, 190);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(121, 70);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 22);
            this.txtProductName.TabIndex = 10;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Location = new System.Drawing.Point(12, 134);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(104, 16);
            this.lblProductQuantity.TabIndex = 3;
            this.lblProductQuantity.Text = "Product Quantity";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(145, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtProductImg
            // 
            this.txtProductImg.Enabled = false;
            this.txtProductImg.Location = new System.Drawing.Point(121, 156);
            this.txtProductImg.Name = "txtProductImg";
            this.txtProductImg.ReadOnly = true;
            this.txtProductImg.Size = new System.Drawing.Size(99, 22);
            this.txtProductImg.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 259);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(12, 104);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(87, 16);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(12, 48);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(89, 16);
            this.lblProductCode.TabIndex = 4;
            this.lblProductCode.Text = "Product Code";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(121, 98);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(121, 22);
            this.txtProductPrice.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(31, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(52, 328);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // ManageProduct_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbProductInformation);
            this.Controls.Add(this.gbProductData);
            this.Controls.Add(this.btnBack);
            this.Name = "ManageProduct_form";
            this.Text = "ManageProduct_form";
            this.Load += new System.EventHandler(this.ManageProduct_form_Load);
            this.gbProductData.ResumeLayout(false);
            this.gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductData;
        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductImg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtProductImg;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox btnUpload;
    }
}