using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;
using ConsoleApplication1.WeatherService;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Service1Client src = new Service1Client();
            //ProductDTO gelenUrun = src.UrunSelect(4);
            //Console.WriteLine(gelenUrun.UrunAd + " - " + gelenUrun.KategoriAdi + " - " + gelenUrun.UnitPrice);
            //Ogrenci gidenOgrenci = new Ogrenci()
            //{
            //    Ad = "GG",
            //    Soyad = "Ç"
            //};

            //Ogrenci gelenOgrenci = svc.OgrenciEkle(gidenOgrenci);

            //Console.WriteLine(gelenOgrenci.Ad + " - " + gelenOgrenci.Soyad); 
            #endregion

            #region MyRegion
            //GlobalWeatherSoapClient hava = new GlobalWeatherSoapClient();

            //Console.WriteLine(hava.GetWeather("Ankara","Turkey"));
            //Console.WriteLine(hava.GetCitiesByCountry("Turkey")); 
            #endregion

            #region MyRegion
            //Service1Client svc = new Service1Client();
            //CategoriDTO[] gelenkategoriler = svc.kategoriSec();

            //foreach (CategoriDTO item in gelenkategoriler)
            //{
            //    Console.WriteLine(item.CategoryName + "-" + item.Description);
            //}
            //svc.Close(); 
            #endregion


            Service1Client svc = new Service1Client();

            ProductDTO[] gelenUrunler = svc.UrunSec(5);

            foreach (ProductDTO item in gelenUrunler)
            {
                Console.WriteLine(item.KategoriAdi + "-" + item.UrunAd);
            }
            svc.Close();

        }
    }
}
