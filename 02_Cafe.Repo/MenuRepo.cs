﻿using _02_Cafe.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Cafe.ClassLibrary
{
    //Your Task:

    //Create a MenuRepository Class that has methods needed.(You don't need to test your constructors or objects, just your methods)

    //Create a Program file that allows the cafe manager to add, delete, and see all items in the menu list.
    public class MenuRepo
    {
        private readonly List<Menu> _menuList = new List<Menu>();
        private readonly List<Ingredients> _allIngredients = new List<Ingredients>();
        public bool AddItemsToMenuList (Menu menu)
        {
            int MenuCount = _menuList.Count;
            _menuList.Add(menu);
            return _menuList.Count > MenuCount;
        }

        public List<Menu> GetAllItems()
        {
            return _menuList;
        }

        public List<Ingredients> GetAllIngredients()
        {
            return _allIngredients;
        }

        public Menu GetMealName(string mealName)
        {
            foreach(Menu item in _menuList)
            {
                if(item.MealName.ToUpper() == mealName.ToUpper())
                {
                    return item;
                }
            }
            return null;
        }

        public bool DeleteMenuList(Menu itemlist)
        {
          bool deleteList = _menuList.Remove(itemlist);
            return deleteList;
        }

       
    }
}