using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Hus : Lokale
    {
        public Indbygger Ejer;
        public Hus(int id, int[] position, Indbygger ejer) : base(id, position)
        {
            Ejer = ejer;
        }
    }
}
