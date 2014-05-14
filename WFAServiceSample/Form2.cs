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
    public partial class Form2 : Form
    {
        Service1Client service = new Service1Client();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProductSelect();
            CategoriesDTO[] categories = service.GetAllCategories();
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryID";
        }

        private void ProductSelect()
        {
            lstProducts.Items.Clear();

            ProductDTO[] products = service.ProductSelect();
            CategoriesDTO[] categories = service.GetAllCategories();

            foreach (ProductDTO pro in products)
            {
                ListViewItem li = new ListViewItem();
                li.Text = pro.ProductID.ToString();
                li.SubItems.Add(pro.ProductName);
                foreach (CategoriesDTO cat in categories)
                {
                    if (pro.CategoryID == cat.CategoryID)
                    {
                        li.SubItems.Add(cat.CategoryName);
                    }
                }
                li.SubItems.Add(pro.UnitPrice.ToString());
                li.SubItems.Add(pro.UnitsInStock.ToString());

                lstProducts.Items.Add(li);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ProductDTO eklenecekUrun = new ProductDTO()
            {
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = Convert.ToInt16(txtUnitsInStock.Text),
                CategoryID = Convert.ToInt32(cmbCategories.SelectedValue)
            };

            service.ProductAdd(eklenecekUrun);

            ProductSelect();
        }
    }
}
