using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Lokale
    {
        public int Id;
        public string Name;
        public int[] Position;
        private string[] lines = File.ReadLines("C:\\Users\\christian\\source\\repos\\peopleville\\peopleville\\text\\places.txt").ToArray();
        public Lokale(int id, int[] position)
        {
            Id = id;
            Name = lines[RNG.Random(0, lines.Length)];
            Position = position;
        }
    }
}
