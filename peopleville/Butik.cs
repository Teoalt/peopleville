using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Butik : Lokale
    {
        public List<Sværd> Sværder;
        public List<Mad> MadList;

        public Butik(int id, int[] position) : base(id, position)
        {
        }
        public Butik(int id, int[] position, string navn, List<Sværd> sværder, List<Mad> madList) : base(id, position)
        {
            Name += navn;
            Sværder = sværder;
            MadList = madList;
        }
    }
}
