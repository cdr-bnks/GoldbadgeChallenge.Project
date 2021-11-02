
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
        private readonly List<Ingredient> _allIngredients = new List<Ingredient>();
        
        public void AddItemsToMenuList (Menu menu)
        {
            
            _menuList.Add(menu);
           
        }
        public void AddIngredientToMenuList(Ingredient ingredient)
        {
            _allIngredients.Add(ingredient);
        }

        public List<Menu> GetEveryItem()
        {
            return _menuList;
        }

        public List<Ingredient> GetEveryIngredient()
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

        public Ingredient GetIngredientName(string nameOfIngredient)
        {
            foreach (Ingredient item in _allIngredients)
            {
                if (item.Spice.ToUpper() == nameOfIngredient.ToUpper())
                {
                    return item;
                }
                else if(item.Dairy.ToUpper() == nameOfIngredient.ToUpper())
                {
                    return item;
                }
                else if(item.Vegetable.ToUpper() == nameOfIngredient.ToUpper())
                {
                    return item;
                }
                else if(item.Meat.ToUpper() == nameOfIngredient.ToUpper())
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
