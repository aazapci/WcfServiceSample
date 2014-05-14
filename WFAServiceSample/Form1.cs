using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAServiceSample.MyService;

namespace WFAServiceSample
{
    public partial class Form1 : Form
    {
        Service1Client svc = new Service1Client();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoriesDTO[] categories = svc.GetAllCategories();

            cmbCategories.DataSource = categories;
            cmbCategories.ValueMember = "CategoryID";
            cmbCategories.DisplayMember = "CategoryName";
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            lsvUrun.Items.Clear();

            ProductDTO[] products = svc.ProductSelectByCategoryID(Convert.ToInt32(cmbCategories.SelectedValue));

            foreach (ProductDTO item in products)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.ProductID.ToString();
                li.SubItems.Add(item.ProductName);
                lsvUrun.Items.Add(li);
            }
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            TextTemizle();

            ProductDTO gelenUrun = svc.ProductSelectByID(Convert.ToInt32(lsvUrun.SelectedItems[0].Text));
            lblUrunID.Text = gelenUrun.ProductID.ToString();
            txtUrunAd.Text = gelenUrun.ProductName;
            txtKategoriAd.Text = gelenUrun.CategoryName;
            txtFiyat.Text = gelenUrun.UnitPrice.ToString();
            txtStokMiktari.Text = gelenUrun.UnitsInStock.ToString();

            if (gelenUrun.UnitsInStock < 10)
            {
                txtStokMiktari.BackColor = Color.Red;
            }
            else
            {
                txtStokMiktari.BackColor = Color.Green;
            }
        }

        private void TextTemizle()
        {
            lblUrunID.Text = txtFiyat.Text = txtKategoriAd.Text = txtStokMiktari.Text = txtUrunAd.Text = string.Empty;
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            ProductDTO guncellenecekUrun = new ProductDTO()
            {
                ProductID = Convert.ToInt32(lblUrunID.Text),
                ProductName = txtUrunAd.Text,
                UnitPrice = Convert.ToDecimal(txtFiyat.Text),
                UnitsInStock = Convert.ToInt32(txtStokMiktari.Text)
            };

            int sonuc = svc.ProductUpdate(guncellenecekUrun);

            if (sonuc > 0)
            {
                MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti.");
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi Sırasında Bir Hata Oluştu!");
            }
            TextTemizle();
        }
    }
}
