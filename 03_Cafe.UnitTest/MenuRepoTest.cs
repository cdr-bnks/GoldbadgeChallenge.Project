using _02_Cafe.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Cafe.UnitTest
{
    [TestClass]
    public class MenuRepoTest
    {
        private MenuRepo _menuRepo;
        private Menu _items;

        [TestInitialize]
        public void IntialStep()
        {
            _menuRepo = new MenuRepo();

            _items = new Menu("Kids special", MealType.kids_meal, "Fresh fruits, Organic deli meat, milk or water and pastries", "black pepper, celery turkey and milk", 5.78, DateTime.Parse("HH:mm:tt"));

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

        [TestMethod]
        public void GetMealName_ShouldReturnName()
        {
            Menu menu = new Menu();
            menu.MealName = "Turkey";

            MenuRepo repo = new MenuRepo();
            repo.GetMealName(menu.ToString());
            Menu menuFromDirectory = repo.GetMealName("Turkey");

            Assert.IsNotNull(menuFromDirectory);
        }




        [TestMethod]
        public void DeletMenuList_ShouldReturnTrue()
        {

        }
    }
}

