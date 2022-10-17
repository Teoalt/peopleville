using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class PeopleVille
    {
        public List<Lokale> Kort;
        public PeopleVille()
        {
            Kort = BySkaber.Kort();
        }
    }
}
