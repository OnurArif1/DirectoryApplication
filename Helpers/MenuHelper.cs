using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace example18._1
{
    static class MenuHelper
    {
        
        private static Operation operation = new Operation();
        public static void Menu()
        {
                Console.WriteLine("\t\t******************************TELEFON REHBERİNE HOŞGELDİNİZ******************************"+"\n");
                Console.WriteLine("\t\t\t=======>>>>>>> Lütfen yapmak istediğiniz işlemi seçiniz <<<<<<<=======" + "\n");
                Console.WriteLine("\t\t\t\t\t==>  Numara Eklmek için '1' e basın  <==");
                Console.WriteLine("\t\t\t\t\t==>  Numara Silmek için '2' e basın  <==");
                Console.WriteLine("\t\t\t\t\t==>  Numara Düzenlemek için '3' e basın  <==");
                Console.WriteLine("\t\t\t\t\t==>  Rehberi listelemek için '4' e basın  <==");
                Console.WriteLine("\t\t\t\t\t==>  Rehberden çıkmak için '5' e basın  <==" + "\n");
                Console.Write("==>Lütfen Seçim Yapınız:");
        }
        public static void ReadInput(string ınput,ref List<Rehber> rehberList)
        {
            if (ınput=="1")
            {
                add(ref rehberList);
            
            }
            else if (ınput =="2")
            {
                delete(rehberList);
            }
            else if (ınput=="3")
            {
                edit(ref rehberList);
            }
            else if (ınput =="4")
            {
                listele( rehberList);
            }
        }
        private static void add(ref List<Rehber> rehberList)
        {
            Rehber rehber = new Rehber();
            Console.Write("\n=> Eklemek istedğiniz  adı girin:");
            rehber.Ad = Console.ReadLine().ToUpper();
            Console.Write("=> Eklemek itedğiniz SoyAdı girin:");
            rehber.SoyAd = Console.ReadLine().ToUpper();
            Console.Write("=> Eklemek istediğiniz Numara girin:");
            rehber.Numara = Console.ReadLine();
            if (!ValidateHelper.CheckNumber(rehber.Numara))
            {
                return;
            }
            operation.Add(rehber, ref rehberList);
        }
        private static void delete(List<Rehber> rehberList)
        {
            Rehber rehber = new Rehber();
            Console.Write("\n=> Silmek istedğiniz  adı girin:");
            rehber.Ad = Console.ReadLine().ToUpper();
            Console.Write("=> Silmek itedğiniz SoyAdı girin:");
            rehber.SoyAd = Console.ReadLine().ToUpper();
            Console.Write("=> Silmek istediğiniz Numara girin:");
            rehber.Numara = Console.ReadLine();
            operation.Delete(rehber, ref rehberList);
        }
        private static void edit(ref List<Rehber> rehberList)
        {
            Rehber eskiRehber = new Rehber();
            Rehber yeniRehber = new Rehber();
            Console.Write("\n=> Değiştirmek istdediğiniz Ad giriniz:");
            eskiRehber.Ad = Console.ReadLine().ToUpper();
            Console.Write("=> Değiştirmek istdediğiniz Soyad giriniz:");
            eskiRehber.SoyAd = Console.ReadLine().ToUpper();
            Console.Write("=> Değiştirmek istdediğiniz Numara giriniz:");
            eskiRehber.Numara = Console.ReadLine();
            Console.Write("\n=> Yeni Adı giriniz:");
            yeniRehber.Ad = Console.ReadLine().ToUpper();
            Console.Write("=> Yeni Soyad giriniz:");
            yeniRehber.SoyAd = Console.ReadLine().ToUpper();
            Console.Write("=> Yeni Numarayı giriniz:");
            yeniRehber.Numara = Console.ReadLine();
            operation.Edit(eskiRehber, yeniRehber, ref rehberList);
        }
        private static void listele( List<Rehber> rehberList)
        {
            if (ValidateHelper.CheckList(rehberList))
            {
                return;
            }
            operation.Listele( rehberList);
        }
    }
}
