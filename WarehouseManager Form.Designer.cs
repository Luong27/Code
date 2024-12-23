namespace Game
{
    partial class Warehouse_Manager_Form
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
            this.gbWarehouseManagerFeature = new System.Windows.Forms.GroupBox();
            this.btnManageProduct = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbWarehouseManagerFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWarehouseManagerFeature
            // 
            this.gbWarehouseManagerFeature.Controls.Add(this.btnManageProduct);
            this.gbWarehouseManagerFeature.Location = new System.Drawing.Point(34, 12);
            this.gbWarehouseManagerFeature.Name = "gbWarehouseManagerFeature";
            this.gbWarehouseManagerFeature.Size = new System.Drawing.Size(514, 289);
            this.gbWarehouseManagerFeature.TabIndex = 0;
            this.gbWarehouseManagerFeature.TabStop = false;
            this.gbWarehouseManagerFeature.Text = "Warehouse manager features ";
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.Location = new System.Drawing.Point(12, 20);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(176, 60);
            this.btnManageProduct.TabIndex = 3;
            this.btnManageProduct.Text = "Manage product";
            this.btnManageProduct.UseVisualStyleBackColor = true;
            // 
            // Warehouse_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbWarehouseManagerFeature);
            this.Name = "Warehouse_Manager_Form";
            this.Text = "Warehouse_Manager_Form";
            this.Load += new System.EventHandler(this.Warehouse_Manager_Form_Load);
            this.gbWarehouseManagerFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWarehouseManagerFeature;
        private System.Windows.Forms.Button btnManageProduct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}