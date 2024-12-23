namespace Game
{
    partial class SaleForm
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
            this.gbSaleFeature = new System.Windows.Forms.GroupBox();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnManageCustomer = new System.Windows.Forms.Button();
            this.gbSaleFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaleFeature
            // 
            this.gbSaleFeature.Controls.Add(this.btnManageCustomer);
            this.gbSaleFeature.Controls.Add(this.btnManageOrder);
            this.gbSaleFeature.Location = new System.Drawing.Point(12, 12);
            this.gbSaleFeature.Name = "gbSaleFeature";
            this.gbSaleFeature.Size = new System.Drawing.Size(776, 426);
            this.gbSaleFeature.TabIndex = 0;
            this.gbSaleFeature.TabStop = false;
            this.gbSaleFeature.Text = "Sale Feature";
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(583, 61);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(172, 77);
            this.btnManageOrder.TabIndex = 1;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.Location = new System.Drawing.Point(24, 61);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(172, 77);
            this.btnManageCustomer.TabIndex = 2;
            this.btnManageCustomer.Text = "Manage Customer";
            this.btnManageCustomer.UseVisualStyleBackColor = true;
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSaleFeature);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.gbSaleFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaleFeature;
        private System.Windows.Forms.Button btnManageCustomer;
        private System.Windows.Forms.Button btnManageOrder;
    }
}