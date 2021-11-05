using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge.ClassLibrary
{
    public class BadgeRepo
    {
        private Dictionary<int, List<string>> _badgeDirectory = new Dictionary<int, List<string>>();

        public Dictionary<int, List<string>> GetlistFromDirectory()
        {
            return _badgeDirectory;
        }

        public void AddBadge(Badge badge)
        {
            _badgeDirectory.Add(badge.BadgeID, badge.ListEachDoorName);
        }

        public void AddingDoorToBadge(int badgeNum, string accessedDoors)
        {
            List<string> doors = _badgeDirectory[badgeNum];
            doors.Add(accessedDoors);
        }

        public void RemoveDoorEntry(int badgeid, string accessedDoor)
        {
            List<string> doors = _badgeDirectory[badgeid];
            doors.Remove(accessedDoor);
        }
    }
}

