using Microsoft.VisualStudio.TestTools.UnitTesting;
using PositioningElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositioningElements.Tests
{
    [TestClass()]
    public class PunktGranicznyTests
    {
        [TestMethod()]
        public void Test1()
        {
            //Arrange
            string Numer = "NR1";
            double X = 100.01;
            double Y = 100.02;
            byte Rzg = 1;
            byte Stb = 1;
            byte Zrd = 1;
            byte Bpp = 1;
            string expected = Numer + " " + X.ToString("F3") + " " + Y.ToString("F3") + " " + "0" + " " + Zrd.ToString() + " " + Bpp.ToString() + " " + Stb.ToString() + " " + Rzg.ToString();
            BorderPoint pkt = new BorderPoint(Numer, X, Y, Rzg, Stb, Zrd, Bpp);
            // Act
            pkt.ChangedLine();

            //Assert
            string actual = pkt.Line;
            Assert.AreEqual(expected, actual, "Nie OK");
        }
        [TestMethod()]
        public void Test2()
        {
            //Arrange
            string Numer = "NR";
            double X = 100.01;
            double Y = 100.02;
            byte Rzg = 1;
            byte Stb = 1;
            byte Zrd = 1;
            byte Bpp = 1;
            int j = 0;
            BorderPoint[] pkt = new BorderPoint[100]; 
            string[] expected = new string[100];
            for (int i = 0; i < 100; i++)
            { pkt[i] = new BorderPoint(Numer + i, X * i, Y * i, Rzg, Stb, Zrd, Bpp);
               
                expected[i] = (Numer + i) + " " + (X * i).ToString("F3") + " " + (Y * i).ToString("F3") + " " + "0" + " " + Zrd.ToString() + " " + Bpp.ToString() + " " + Stb.ToString() + " " + Rzg.ToString();
            }

            // Act
            foreach (BorderPoint p in pkt)
            {
                p.ChangedLine();

                //Assert
                string actual = p.Line;
                Assert.AreEqual(expected[j], actual, "Nie OK");
                j++;
            }
        } 
    }
}