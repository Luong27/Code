namespace Game
{
    partial class OrderHistory
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
            this.dtgOrderHistory = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbOrderHistory = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderHistory)).BeginInit();
            this.gbOrderHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgOrderHistory
            // 
            this.dtgOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderHistory.Location = new System.Drawing.Point(6, 21);
            this.dtgOrderHistory.Name = "dtgOrderHistory";
            this.dtgOrderHistory.RowHeadersWidth = 51;
            this.dtgOrderHistory.RowTemplate.Height = 24;
            this.dtgOrderHistory.Size = new System.Drawing.Size(318, 213);
            this.dtgOrderHistory.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(249, 240);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // gbOrderHistory
            // 
            this.gbOrderHistory.Controls.Add(this.dtgOrderHistory);
            this.gbOrderHistory.Controls.Add(this.btnBack);
            this.gbOrderHistory.Location = new System.Drawing.Point(37, 26);
            this.gbOrderHistory.Name = "gbOrderHistory";
            this.gbOrderHistory.Size = new System.Drawing.Size(330, 269);
            this.gbOrderHistory.TabIndex = 25;
            this.gbOrderHistory.TabStop = false;
            this.gbOrderHistory.Text = "Purchase history";
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOrderHistory);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderHistory)).EndInit();
            this.gbOrderHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrderHistory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbOrderHistory;
    }
}