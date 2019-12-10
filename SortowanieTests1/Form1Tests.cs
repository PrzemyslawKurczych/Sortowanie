using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sortowanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sortowanie.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void PozycjaTest1()
        {
            // Arrange
            string path = "test1.txt";
            sbyte expectedNr = 0;
            sbyte expectedX =1;
            sbyte expectedY = 2;
            sbyte expectedStb = 11;
            sbyte expectedZrd = 12;
            sbyte expectedBpp = 13;
            sbyte expectedRzg = 14;
            Form1 form = new Form1();
            form.path = "test1.txt";
            // Act
            form.Pozycja(path);

            //Assert

            sbyte actualnr = form.Nr;
            Assert.AreEqual(expectedNr, actualnr, "NIe OK NR");
            sbyte actualX = form.X;
            Assert.AreEqual(expectedX, actualX, "NIe OK X");
            sbyte actualY = form.Y;
            Assert.AreEqual(expectedY, actualY, "NIe OK Y");
            sbyte actualStb = form.Stb;
            Assert.AreEqual(expectedStb, actualStb, "NIe OK Stb");
            sbyte actualZrd = form.Zrd;
            Assert.AreEqual(expectedZrd, actualZrd, "NIe OK Zrd");
            sbyte actualBpp = form.Bpp;
            Assert.AreEqual(expectedBpp, actualBpp, "NIe OK Bpp");
            sbyte actualRzg = form.Rzg;
            Assert.AreEqual(expectedRzg, actualRzg, "NIe OK Rzg");



        }
    }
}