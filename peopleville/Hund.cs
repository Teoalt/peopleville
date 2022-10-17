using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Hund : Genstand
    {
        public Hund(int id, string name, int ownerId) : base(id, name, ownerId)
        {
        }
    }
}
