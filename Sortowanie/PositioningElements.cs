using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositioningElements
{
    public class SortingElements
    {
        sbyte positionnr;
        sbyte positionx = -1;
        sbyte positiony = -1;
        sbyte positionstb;
        sbyte positionzrd;
        sbyte positionbpp;
        sbyte positionrzg;
        public (sbyte, sbyte, sbyte, sbyte, sbyte, sbyte, sbyte) PositionsOf(string path)
        {

            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(path);
            string s = sr.ReadLine();
            string[] line = s.Split('\t');

            sbyte i=0;
            while (i < line.Length)
            {
                if (line[i].Contains("numer") == true) { positionnr = i; }
                if (positionx == -1)
                {
                    if (line[i].Contains("x") == true) { positionx = i; }
                }
                if (positiony == -1)
                {
                    if (line[i].Contains("y") == true) { positiony = i; }
                }
                if (line[i].Contains("stb") == true) { positionstb = i; }
                if (line[i].Contains("zrd") == true) { positionzrd = i; }
                if (line[i].Contains("bpp") == true) { positionbpp = i; }
                if (line[i].Contains("rzg") == true) { positionrzg = i; }
                i++;
            }
            sr.Close();
            return (positionnr, positionx, positiony, positionstb, positionzrd, positionbpp, positionrzg);
        }
        public sbyte Nr
        {
            get { return positionnr; }
        }
        public sbyte X
        {
            get { return positionx; }
        }
        public sbyte Y
        {
            get { return positiony; }
        }
        public sbyte Stb
        {
            get { return positionstb; }
        }
        public sbyte Zrd
        {
            get { return positionzrd; }
        }
        public sbyte Bpp
        {
            get { return positionbpp; }
        }
        public sbyte Rzg
        {
            get { return positionrzg; }
        }
    }
}

