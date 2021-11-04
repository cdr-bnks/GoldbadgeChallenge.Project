using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge.ClassLibrary
{
   public class Badge
    {
        public int BadgeID { get; set; }
        public string ListEachDoorName { get; set; }
        public string BadgeName { get; set; }

        public Badge() { }

        public Badge(int badgeID, string listEachDoorName, string badgeName)
        {
            BadgeID = badgeID;
            ListEachDoorName = listEachDoorName;
            BadgeName = badgeName;
        }
    }
}
