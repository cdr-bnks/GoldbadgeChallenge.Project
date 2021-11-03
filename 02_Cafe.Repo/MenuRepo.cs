
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
        private readonly DateTime _mealTime = new DateTime();

        public void AddItemsToMenuList(Menu menu)
        {

            _menuList.Add(menu);

        }

        public List<Menu> GetEveryItem()
        {
            return _menuList;
        }

        public Menu GetMealName(string mealName)
        {
            foreach (Menu item in _menuList)
            {
                if (item.MealName.ToUpper() == mealName.ToUpper())
                {
                    return item;
                }
            }
            return null;
        }

        public bool DeleteMenuList(string mealName)
        {
            Menu item = GetMealName(mealName);
            
            if(item == null)
            {
                return false;
            }

            int initialCount = _menuList.Count;
            _menuList.Remove(item);

            if(initialCount > _menuList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CafeHours(string mealTime)
        {
            return _mealTime.AddHours;
        }
    }
}
