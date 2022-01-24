
namespace RecapProject1
{
    partial class Form1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.gbcSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxCategory.SuspendLayout();
            this.gbcSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblKategori);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(964, 122);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(122, 59);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(242, 24);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(30, 62);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(86, 21);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori: ";
            // 
            // gbcSearch
            // 
            this.gbcSearch.Controls.Add(this.tbxSearch);
            this.gbcSearch.Controls.Add(this.lblSearch);
            this.gbcSearch.Location = new System.Drawing.Point(12, 140);
            this.gbcSearch.Name = "gbcSearch";
            this.gbcSearch.Size = new System.Drawing.Size(964, 119);
            this.gbcSearch.TabIndex = 1;
            this.gbcSearch.TabStop = false;
            this.gbcSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(30, 64);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 21);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Ara: ";
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 265);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(964, 224);
            this.dgwProduct.TabIndex = 2;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(82, 64);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(282, 22);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 657);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbcSearch);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbcSearch.ResumeLayout(false);
            this.gbcSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbcSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.TextBox tbxSearch;
    }
}

