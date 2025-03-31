using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLNedirNasilKullanilir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //xml extendible Marcub language açılımı olan genişletilebilir işaretleme dili olarak tanımlanabilir.
            //Html gibi etiketler kullanılarak oluşturulur. ancak xml'de etiketleri biz belirleriz.
            //Amacı veri depolamak veya farklı platformlar arasında veri transferi sağlamaktır.
            //RSS,Ajax,Web servisleri oluşturulabilir
            //XML ile tanımlama yaparken hergangi bir standart yoktur.Ancak bazı kurallara uyulması gerekir.
            //En önemli kural Xml dosyasının başında Xml tanımlayıcısının oluşturulması gerekir
            //<?xml versiyon="1.0" encoding="UTF-8"?>

            #endregion
            #region Xml Verilerini Okuyalım
            //XDocument dokuman = XDocument.Load("../../Kisiler.xml");
            //XElement rootelement = dokuman.Root;
            //foreach (XElement item in rootelement.Elements())
            //{
            //    int id = Convert.ToInt32(item.Attribute("id").Value);
            //    string isim = item.Element("adi").Value;
            //    string soyisim = item.Element("soyadi").Value;
            //    Console.WriteLine($"{id} ) {isim} {soyisim}");
            //}
            #endregion
            #region Merkez Bankası Döviz Kurlarını Okuyalım

            //XDocument kurlar = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
            //XElement rootElement = kurlar.Root;
            //foreach (XElement item in rootElement.Elements())
            //{
            //    string kod = item.Attribute("Kod").Value;
            //    string isim = item.Element("Isim").Value;
            //    int unit = int.Parse(item.Element("Unit").Value);
            //    double ForexSelling = 0;
            //    if(!string.IsNullOrEmpty(item.Element("ForexSelling").Value) )
            //    {
            //        ForexSelling = Convert.ToDouble(item.Element("ForexSelling").Value.Replace('.', ','));
            //    }
            //    double satis = ForexSelling/unit;
            //    Console.WriteLine($"{kod} - {isim} = {satis} TL");
            //}

            #endregion
            #region Xml Verilerini Ekleme
            //Console.Write("ID = \t");
            //string id = Console.ReadLine();

            //Console.Write("İsim = \t");
            //string isim = Console.ReadLine();

            //Console.Write("Soyisim = \t");
            //string soyisim = Console.ReadLine();

            //string path = "../../Kisiler.xml";
            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //XElement yeniEleman = new XElement("kisi");

            ////string guid=Guid.NewGuid().ToString();
            //XAttribute idAttribute = new XAttribute("id", id);
            //XElement isimElement = new XElement("adi", isim);
            //XElement soyisimElement = new XElement("soyadi", soyisim);

            //yeniEleman.Add(idAttribute,isimElement,soyisimElement);

            //rootElement.Add(yeniEleman);

            //dokuman.Save(path);
            #endregion
            #region Verileri Güncelleme

            //string path = "../../Kisiler.xml";
            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //foreach (XElement item in rootElement.Elements())
            //{
            //    Console.WriteLine($"{item.Attribute("id").Value}{item.Element("adi").Value}{item.Element("soyadi").Value}");
            //}
            //Console.WriteLine("Güncellemek istediğiniz kişinin id numarasını yazınız");
            //string id = Console.ReadLine();

            //Console.WriteLine("isim = ");
            //string isim = Console.ReadLine();

            //Console.WriteLine("soyisim = ");
            //string soyisim = Console.ReadLine();

            //foreach (XElement item in rootElement.Elements())
            //{
            //    if(item.Attribute("id").Value == id)
            //    {
            //        item.Element("adi").Value = isim;
            //        item.Element("soyadi").Value= soyisim;
            //        break;
            //    }
            //}
            //dokuman.Save(path);

            #endregion
            #region Veri Silme

            //string path = "../../Kisiler.xml";
            //XDocument dokuman = XDocument.Load(path);
            //XElement rootElement = dokuman.Root;

            //Console.WriteLine("Silmek istediğiniz id numarasını giriniz");
            //string id = Console.ReadLine();


            //foreach(XElement item in rootElement.Elements())
            //{
            //    if(item.Attribute("id").Value == id)
            //    {
            //        item.Remove();
            //    }
            //}
            //dokuman.Save(path);
            #endregion
        }
    }
}
