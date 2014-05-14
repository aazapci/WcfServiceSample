using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceSample.Model;
using WcfServiceSample.DTO;

namespace WcfServiceSample
{
    public class Service1 : IService1
    {
        NorthwindEntities db = new NorthwindEntities();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string ToplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;

            return "İşlemin Sonucu : " + sonuc.ToString();
        }

        public Ogrenci OgrenciEkle(Ogrenci instance)
        {
            instance.Ad = "Öğrenci Adı : " + instance.Ad;
            instance.Soyad = "Öğrenci Soyadı : " + instance.Soyad;

            return instance;
        }

        public CategoriesDTO KategoriSelect(int ID)
        {
            Categories gelenKategori = db.Categories.Where(a => a.CategoryID == ID).SingleOrDefault();

            CategoriesDTO gidenKategori = new CategoriesDTO()
            {
                CategoryName = gelenKategori.CategoryName,
                Description = gelenKategori.Description
            };

            return gidenKategori;
        }

        public List<CategoriesDTO> GetAllCategories()
        {
            List<Categories> gelenKategoriler = db.Categories.ToList();
            List<CategoriesDTO> gidenKategoriler = new List<CategoriesDTO>();

            foreach (Categories item in gelenKategoriler)
            {
                CategoriesDTO cat = new CategoriesDTO()
                {
                    CategoryID = item.CategoryID,
                    CategoryName = item.CategoryName,
                    Description = item.Description
                };

                gidenKategoriler.Add(cat);
            }

            return gidenKategoriler;
        }

        public List<ProductDTO> ProductSelectByCategoryID(int categoryID)
        {
            List<Products> gelenProducts = db.Products.Where(p => p.CategoryID == categoryID).ToList();
            List<ProductDTO> gidenProducts = new List<ProductDTO>();

            foreach (Products item in gelenProducts)
            {
                ProductDTO pro = new ProductDTO();
                pro.ProductName = item.ProductName;
                pro.UnitPrice = (decimal)item.UnitPrice;
                pro.CategoryID = (int)item.CategoryID;
                pro.ProductID = item.ProductID;


                gidenProducts.Add(pro);
            }

            return gidenProducts;
        }



        public int ProductAdd(ProductDTO instance)
        {
            db.Products.Add(new Products()
            {
                ProductName = instance.ProductName,
                UnitPrice = instance.UnitPrice,
                UnitsInStock = (short)instance.UnitsInStock,
                CategoryID = instance.CategoryID
            });

            return db.SaveChanges();
        }

        public int ProductUpdate(ProductDTO instance)
        {
            Products gelenUrun = db.Products.Where(p => p.ProductID == instance.ProductID).SingleOrDefault();

            gelenUrun.ProductName = instance.ProductName;
            gelenUrun.UnitPrice = instance.UnitPrice;
            gelenUrun.UnitsInStock = (short)instance.UnitsInStock;

            return db.SaveChanges();
        }

        public int ProductDelete(int ID)
        {
            Products silinecekUrun = db.Products.Where(p => p.ProductID == ID).SingleOrDefault();

            db.Products.Remove(silinecekUrun);

            return db.SaveChanges();
        }

        public List<ProductDTO> ProductSelect()
        {
            List<Products> gelenUrunler = db.Products.ToList();
            List<ProductDTO> gidenUrunler = new List<ProductDTO>();

            foreach (Products item in gelenUrunler)
            {
                ProductDTO gidecekUrun = new ProductDTO() 
                {
                    ProductName = item.ProductName,
                    ProductID = item.ProductID,
                    CategoryID = (int)item.CategoryID,
                    UnitPrice = (decimal)item.UnitPrice,
                    UnitsInStock = (int)item.UnitsInStock
                };

                gidenUrunler.Add(gidecekUrun);
            }

            return gidenUrunler;
        }

        public ProductDTO ProductSelectByID(int ID)
        {
            Products gelenUrun = db.Products.Where(p => p.ProductID == ID).SingleOrDefault();
            Categories gelenKategori = db.Categories.Where(c => c.CategoryID == gelenUrun.CategoryID).SingleOrDefault();

            ProductDTO gidenUrun = new ProductDTO()
            {
                ProductName = gelenUrun.ProductName,
                UnitPrice = (decimal)gelenUrun.UnitPrice,
                CategoryName = gelenKategori.CategoryName,
                ProductID = gelenUrun.ProductID,
                UnitsInStock = (int)gelenUrun.UnitsInStock
            };

            return gidenUrun;
        }
    }
}
