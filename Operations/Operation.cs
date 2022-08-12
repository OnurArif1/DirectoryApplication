using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace example18._1
{
    class Operation : IOperation
    {

        public void Add(Rehber rehber, ref List<Rehber> rehberList)
        {
            rehberList.Add(rehber);
        }
        public void Delete(Rehber rehber, ref List<Rehber> rehberList)
        {
            try
            {
                rehberList.RemoveAll(i => i.Ad == rehber.Ad &&
                                              i.SoyAd == rehber.SoyAd &&
                                              i.Numara == rehber.Numara);
            }
            catch (Exception)
            {
                Console.WriteLine("Silmek istediğiniz numarayı bulamadık");
                return;

            }
        }
        public void Edit(Rehber eskiRehber, Rehber yeniRehber, ref List<Rehber> rehberList)
        {
            var check = rehberList.Where(i => i.Ad == eskiRehber.Ad &&
                                              i.SoyAd == eskiRehber.SoyAd &&
                                              i.Numara == eskiRehber.Numara
                                         ).FirstOrDefault();
            if (check != null)
            {
                Delete(eskiRehber, ref rehberList);
                Add(yeniRehber, ref rehberList);
            }
            else
            {
                Console.WriteLine("Düzeltmek istdeğiniz numarayı bulamadık");
                return;
            }
        }
        public void Listele(List<Rehber> rehberList)
        {
            foreach (var item in rehberList)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.SoyAd);
                Console.WriteLine(item.Numara);

            }
        }

    }
}
