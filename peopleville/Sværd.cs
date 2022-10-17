using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Sværd : Genstand, IPris
    {
        public float Pris { get; set; }
        public Sværd(int id, string name, int ownerId, float pris) : base(id, name, ownerId)
        {
            Pris = pris;
        }

    }
}
