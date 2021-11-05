using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge.ClassLibrary
{
    public class BadgeRepo
    {
        private readonly List<string> _doorNames = new List<string>();
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

        public KeyValuePair<int, List<string>> GetBadgeID(int badgeID)
        {
            foreach (KeyValuePair<int, List<string>> badge in _badgeDirectory)
            {
                if (badge.Key == badgeID)
                {
                    return badge;
                }
            }
            return default;
        }


    }
}

