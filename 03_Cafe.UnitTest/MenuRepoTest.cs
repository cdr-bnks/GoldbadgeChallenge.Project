using _02_Cafe.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Cafe.UnitTest
{
    //Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    [TestClass]
    public class MenuRepoTest
    {
        private MenuRepo _menuRepo;
        private Menu _Items;

        [TestInitialize]
        public void IntialStep()
        {
            _menuRepo = new MenuRepo();
        }
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
