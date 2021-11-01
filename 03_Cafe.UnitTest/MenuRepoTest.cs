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
        private List<Ingredient> _ingredientRepo;
        private Ingredient _ingredients;
        private DateTime _mealhours;
       
        [TestInitialize]
        public void IntialStep()
        {
            _menuRepo = new MenuRepo();
            _ingredientRepo = new List<Ingredient>();
            _ingredients = new Ingredient("black pepper", "celery", "turkey", "milk");
            _mealhours = new DateTime(2021, 11, 1, 8, 30, 00);

            _items = new Menu("Kids special", MealType.kids_meal, "Fresh fruits, Organic deli meat, milk or water and pastries", _ingredientRepo, 5.78, _mealhours);

            _menuRepo.AddItemsToMenuList(_items, _ingredients);

        }
        [TestMethod]
        public void AddtoCafeList_ShouldGetNotNull()
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
