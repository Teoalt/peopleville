using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public class BySkaber
    {
        private static readonly int x = 5;
        private static readonly int y = 5;
        private static int count = 0;
        public static List<Lokale> Kort()
        {
            List<Lokale> kort =  new List<Lokale>();
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    NyByDel(CheckEfterVej(kort, j, i),j,i);
                }
            }
            return kort;
        }
        private static bool CheckEfterVej(List<Lokale> kort, int x, int y)
        {
            bool adgangTilVej = false;
            if (kort is null)
                return adgangTilVej;
            if (kort.Count > 0)
                return adgangTilVej;

            if (kort.Find(z => z.Position == new int[] {--x,y}) is Vej)
                adgangTilVej = true;
            if (kort.Find(z => z.Position == new int[] { ++x, y }) is Vej)
                adgangTilVej = true;
            if (kort.Find(z => z.Position == new int[] { x, --y }) is Vej)
                adgangTilVej = true;
            if (kort.Find(z => z.Position == new int[] { x, ++y }) is Vej)
                adgangTilVej = true;

            return adgangTilVej;
        }
        private static Lokale NyByDel(bool adgangTilVej, int x, int y)
        {
            if (adgangTilVej)
            {
                count++;
                return new Vej(count, new int[] { x, y });
            }
            switch (RNG.Random(0,2))
            {
                case 0:
                    count++;
                    return new Butik(count, new int[] {x,y}, " Butik", new List<Sværd>() { new Sværd(-1, "Sværd", -1, 20f) }, new List<Mad>() { new Mad(-1, "Mad", -1, 5f) });
                case 1:
                    count++;
                    return new Hus(count, new int[] { x, y }, new Indbygger());
                case 2:
                    count++;
                    return new Vej(count, new int[] { x, y });
                default:
                    count++;
                    return new Vej(count, new int[] { x, y });
            }
        }
    }
}
