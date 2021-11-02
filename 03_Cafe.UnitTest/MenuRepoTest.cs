using _02_Cafe.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Cafe.UnitTest
{
    //Create a Test Class for your repository methods. (You don't need to test your constructors or objects, just your methods)
    [TestClass]
    public class MenuRepoTest
    {
        private MenuRepo _menuRepo;
        private Menu _items;
       
        [TestInitialize]
        public void IntialStep()
        {
            _menuRepo = new MenuRepo();

            _items = new Menu("Kids special", MealType.kids_meal, "Fresh fruits, Organic deli meat, milk or water and pastries", "black pepper, celery turkey and milk", 5.78);

            _menuRepo.AddItemsToMenuList(_items);

        }
        [TestMethod]
        public void AddtoCafeList_ShouldReturnNotNull()
        {
            Menu item = new Menu();
            item.MealName = "Kids Special";
           
            MenuRepo repo = new MenuRepo();
            repo.AddItemsToMenuList(item);
            Menu itemFromDirectory = repo.GetMealName("Kids Special");

            Assert.IsNotNull(itemFromDirectory);

        }
    }
}
