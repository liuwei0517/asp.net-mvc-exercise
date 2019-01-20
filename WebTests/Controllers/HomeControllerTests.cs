using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            HomeController home = new HomeController();
            int[] v = new int[] { 0, 1};
            foreach(int i in v)
            {
               string re= home.GetName(i);
               Assert.AreNotEqual(re, "");
            }
        }
    }
}