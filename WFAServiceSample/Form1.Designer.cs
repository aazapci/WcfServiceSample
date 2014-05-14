namespace WFAServiceSample
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
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lsvUrun = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(15, 15);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(221, 33);
            this.cmbCategories.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(248, 14);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(138, 33);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lsvUrun
            // 
            this.lsvUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chProductName});
            this.lsvUrun.FullRowSelect = true;
            this.lsvUrun.GridLines = true;
            this.lsvUrun.Location = new System.Drawing.Point(15, 57);
            this.lsvUrun.Name = "lsvUrun";
            this.lsvUrun.Size = new System.Drawing.Size(371, 219);
            this.lsvUrun.TabIndex = 2;
            this.lsvUrun.UseCompatibleStateImageBehavior = false;
            this.lsvUrun.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chProductName
            // 
            this.chProductName.Text = "Product Name";
            this.chProductName.Width = 305;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(395, 204);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(216, 33);
            this.txtStokMiktari.TabIndex = 3;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(395, 165);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(216, 33);
            this.txtFiyat.TabIndex = 4;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(395, 126);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(216, 33);
            this.txtUrunAd.TabIndex = 5;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(395, 87);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(216, 33);
            this.txtKategoriAd.TabIndex = 6;
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Location = new System.Drawing.Point(395, 14);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(216, 33);
            this.btnUrunSec.TabIndex = 7;
            this.btnUrunSec.Text = "Ürün Seç";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            this.btnUrunSec.Click += new System.EventHandler(this.btnUrunSec_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(395, 243);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(216, 33);
            this.btnUrunGuncelle.TabIndex = 7;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(392, 57);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(63, 25);
            this.lblUrunID.TabIndex = 8;
            this.lblUrunID.Text = "label1";
            this.lblUrunID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 288);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunSec);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.lsvUrun);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.cmbCategories);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "WCF Öğreniyoruz :)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListView lsvUrun;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chProductName;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Label lblUrunID;
    }
}

