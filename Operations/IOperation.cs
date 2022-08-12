using System;
using System.Collections.Generic;
using System.Text;

namespace example18._1
{
    interface IOperation
    {
        public void Add(Rehber rehber,ref List<Rehber> rehberList);
        public void Edit(Rehber eskiRehber,Rehber yeniRehber,ref List<Rehber> rehberList);
        public void Delete(Rehber rehber,ref List<Rehber> rehberList);
        public void Listele(List<Rehber> rehberList);
        
    }
}
