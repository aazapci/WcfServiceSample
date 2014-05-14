using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationSample.MyService;
using ConsoleApplicationSample.WeatherService;

namespace ConsoleApplicationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyService1
            //Service1Client svc = new Service1Client();

            //ProductDTO gelenUrun = svc.ProductSelectByID(4);

            //Console.WriteLine(gelenUrun.ProductName + " - " + gelenUrun.CategoryName + " - " + gelenUrun.UnitPrice);

            //Ogrenci gidenOgrenci = new Ogrenci()
            //{
            //    Ad = "Hede",
            //    Soyad = "Bidi"
            //};

            //Ogrenci gelenOgrenci = svc.OgrenciEkle(gidenOgrenci);

            //Console.WriteLine(gelenOgrenci.Ad + " - " + gelenOgrenci.Soyad); 
            #endregion

            #region WeatherService
            //GlobalWeatherSoapClient hava = new GlobalWeatherSoapClient();

            //Console.WriteLine(hava.GetWeather("Ankara / Esenboga", "Turkey"));

            //Console.WriteLine(hava.GetCitiesByCountry("Greece")); 
            #endregion

            #region MyService2
            //Service1Client svc = new Service1Client();

            //CategoriesDTO[] gelenKategoriler = svc.GetAllCategories();

            //foreach (CategoriesDTO item in gelenKategoriler)
            //{
            //    Console.WriteLine(item.CategoryName + " - " + item.Description);
            //}

            //svc.Close(); 
            #endregion

            Service1Client svc = new Service1Client();

            ProductDTO[] gelenPro = svc.ProductSelectByCategoryID(5);

            foreach (ProductDTO item in gelenPro)
            {
                Console.WriteLine(item.ProductName + " - " + item.UnitPrice);
            }
        }
    }
}
