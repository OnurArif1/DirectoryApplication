using System;
using System.Collections.Generic;
using System.Text;

namespace example18._1
{
   static class ValidateHelper
    {
        public static Boolean CheckNumber(string phone)
        {
            if (phone!=null)
            {
                if (phone.Length!=11)
                {
                    Console.WriteLine("Yanlış numara yazdınız");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Numarayı girmediniz");
                return false;
            }
            return true;
        }
        public static Boolean CheckList(List<Rehber> rehberList)
        {
            if (rehberList.Count==0)
            {
                Console.WriteLine("==> Liste boş!");
                return false;
            }
            else
            {
                foreach (var item in rehberList)
                {
                    Console.WriteLine(item.Ad);
                    Console.WriteLine(item.SoyAd);
                    Console.WriteLine(item.Numara);

                }
            }
            return true;
        }
    }
}
