using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Tests
{
    [TestClass()]
    public class ClassSeparatorTests
    {
        [TestMethod()]
        public void ReverseWordWithoutSymbolTest()
        {
            //Arange
            string test = "1fgh! ffgh@";
            ClassSeparator separator = new ClassSeparator();
            //Act
            test = separator.ReverseWordWithoutSymbol(test);

            string correctLine = "1hgf! hgff@";

            
            //Assert
            Assert.AreEqual(correctLine, test);
        }
    }
}