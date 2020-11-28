namespace OpenFoodFactsClient
{
    partial class FrmGetProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGTIN = new System.Windows.Forms.TextBox();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.Text = "Product GTIN :";
            // 
            // tbGTIN
            // 
            this.tbGTIN.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular);
            this.tbGTIN.Location = new System.Drawing.Point(20, 67);
            this.tbGTIN.Name = "tbGTIN";
            this.tbGTIN.Size = new System.Drawing.Size(205, 32);
            this.tbGTIN.TabIndex = 1;
            this.tbGTIN.Text = "737628064502";
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular);
            this.btnGetProduct.Location = new System.Drawing.Point(20, 118);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(205, 132);
            this.btnGetProduct.TabIndex = 2;
            this.btnGetProduct.Text = "Get Product";
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // FrmGetProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnGetProduct);
            this.Controls.Add(this.tbGTIN);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "FrmGetProduct";
            this.Text = "Get Product";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGTIN;
        private System.Windows.Forms.Button btnGetProduct;
    }
}

