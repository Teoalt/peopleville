using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Mad : Genstand, IPris
    {
        public Mad(int id, string name, int ownerId, float pris) : base(id, name, ownerId)
        {
            Pris = pris;
        }

        public float Pris { get; set; }
    }
}
