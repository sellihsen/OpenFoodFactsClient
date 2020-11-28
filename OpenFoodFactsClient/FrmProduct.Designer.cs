namespace OpenFoodFactsClient
{
    partial class FrmProduct
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
            this.lbID = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lbID.Location = new System.Drawing.Point(13, 17);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 20);
            this.lbID.Text = "ID";
            // 
            // lbProductId
            // 
            this.lbProductId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbProductId.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lbProductId.Location = new System.Drawing.Point(48, 12);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(177, 25);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.Text = "Name";
            // 
            // lbProductName
            // 
            this.lbProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbProductName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.lbProductName.Location = new System.Drawing.Point(15, 72);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(210, 40);
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(15, 123);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(210, 137);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.pbProductImage);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbID);
            this.Menu = this.mainMenu1;
            this.Name = "FrmProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbProductId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.PictureBox pbProductImage;
    }
}