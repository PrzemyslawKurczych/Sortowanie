using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositioningElements
{
   public class BorderPoint
    {
        public string Number { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public const byte H = 0;
        public byte Rzg { get; set; }
        public byte Stb { get; set; }
        public int Zrd { get; set; }
        public byte Bpp { get; set; }
        private string NewLine;
     
        public BorderPoint(string nr , double x, double y,  byte rzg, byte stb, byte zrd, byte bpp)
        {
            Number = nr;
            X = x;
            Y = y;
            Rzg = rzg;
            Stb = stb;
            if (zrd >= 10) { Zrd = zrd - 10; } else { Zrd = zrd; }
              Bpp = bpp; 

        }
        public string ChangedLine()
        {//zapis lini według założonej kolejności
            NewLine = Number + " " + X.ToString("F3") + " " + Y.ToString("F3") + " " + H.ToString() + " " + Zrd.ToString() + " " + Bpp.ToString() + " " + Stb.ToString() + " " + Rzg.ToString();
            return NewLine;
        }
         public string Line
        {
            get { return NewLine; }
        }

        public static implicit operator List<object>(BorderPoint v)
        {
            throw new NotImplementedException();
        }
    }
}
