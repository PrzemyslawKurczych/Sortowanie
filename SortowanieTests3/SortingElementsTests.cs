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
    public class SortowanieTests
    {
        [TestMethod()]
        public void Test1()
        {
            // Arrange
            string path = "test1.txt";
            sbyte expectedNr = 0;
            sbyte expectedX = 1;
            sbyte expectedY = 2;
            sbyte expectedStb = 11;
            sbyte expectedZrd = 12;
            sbyte expectedBpp = 13;
            sbyte expectedRzg = 14;
            SortingElements pozycje = new SortingElements();
            // Act
            pozycje.PositionsOf(path);
            // Assert
            Assert.AreEqual(expectedNr, pozycje.Nr, "nie OK NR");
            Assert.AreEqual(expectedX, pozycje.X, "nie OK X");
            Assert.AreEqual(expectedY, pozycje.Y, "nie OK Y");
            Assert.AreEqual(expectedStb, pozycje.Stb, "nie OK Stb");
            Assert.AreEqual(expectedZrd, pozycje.Zrd, "nie OK Zrd");
            Assert.AreEqual(expectedBpp, pozycje.Bpp, "nie OK Bpp");
            Assert.AreEqual(expectedRzg, pozycje.Rzg, "nie OK Rzg");

        }
        [TestMethod()]
        public void Test2()
        {
            // Arrange
            string path = "test2.txt";
            sbyte expectedNr = 14;
            sbyte expectedX = 3;
            sbyte expectedY = 4;
            sbyte expectedStb = 8;
            sbyte expectedZrd = 5;
            sbyte expectedBpp = 7;
            sbyte expectedRzg = 9;
            SortingElements pozycje = new SortingElements();
            // Act
            pozycje.PositionsOf(path);
            // Assert
            Assert.AreEqual(expectedNr, pozycje.Nr, "nie OK NR");
            Assert.AreEqual(expectedX, pozycje.X, "nie OK X");
            Assert.AreEqual(expectedY, pozycje.Y, "nie OK Y");
            Assert.AreEqual(expectedStb, pozycje.Stb, "nie OK Stb");
            Assert.AreEqual(expectedZrd, pozycje.Zrd, "nie OK Zrd");
            Assert.AreEqual(expectedBpp, pozycje.Bpp, "nie OK Bpp");
            Assert.AreEqual(expectedRzg, pozycje.Rzg, "nie OK Rzg");

        }
        

        

    }
}