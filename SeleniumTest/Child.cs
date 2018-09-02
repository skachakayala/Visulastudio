using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTest
{
    [TestClass]
    class Child
    {
        [TestMethod]
        public  void m1()
        {
            //Child c = new Child();
            Console.WriteLine("base class");
        }
    }
}
