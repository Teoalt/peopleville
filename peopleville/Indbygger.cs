using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class Indbygger
    {
        public int Id;
        public string Name;
        public float Penge;
        public int[] Position;
        public Hus Hjem;
        public Lokale Mål;

        private string[] lines = File.ReadLines("C:\\Users\\christian\\source\\repos\\peopleville\\peopleville\\text\\navn.txt").ToArray();
        public Indbygger(int id, string name, float penge, int[] position, Hus hjem, Lokale mål)
        {
            Id = id;
            Name = name;
            Penge = penge;
            Position = position;
            Hjem = hjem;
            Mål = mål;
        }
        public Indbygger(int id, Hus hjem, Lokale mål)
        {
            Id = id;
            Name = lines[RNG.Random(0, lines.Length)];
            Penge = (float)RNG.Random(0, 500);
            Position = hjem.Position;
            Hjem = hjem;
            Mål = mål;
        }
        public Indbygger()
        {
            Id = -1;
            Name = "Name";
            Penge = 0f;
            Position = new int[] {0,0};
            Hjem = new Hus(-1, this);
            Mål = new Lokale(-1);
        }
    }
}
