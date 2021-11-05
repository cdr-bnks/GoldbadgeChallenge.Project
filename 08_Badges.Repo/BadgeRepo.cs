using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge.ClassLibrary
{
    public class BadgeRepo
    {
        private Dictionary<int, string> _badgeDirectory = new Dictionary<int, string>();

        public Dictionary<int, string> GetDictonary()
        {
            return _badgeDirectory;
        }

        public void AddBadge(int badge, string accessedDoors)
        {
            _badgeDirectory.Add(badge, accessedDoors);
        }

        public bool AddingDoorToBadge(Badge badge, string )
        {
            string doors = _badgeDirectory[badge];
             doors.Length.
            
        }

        public void RemoveDoorEntry(int badgeid, string doorAccess)
        {
            Badge doors = _badgeDirectory[badgeid];
            doors.Remove(doorAccess);
        }
    }
}

