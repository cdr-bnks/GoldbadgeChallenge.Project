using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Badge.ClassLibrary
{
    public class BadgeRepo
    {
        protected readonly Dictionary<int, Badge> _badgeDirectory = new Dictionary<int, Badge>();

        public bool AddBadgeToDirectory(Badge badge)
        {
            int badgeNum = _badgeDirectory.Count;
            _badgeDirectory.Add(badgeNum, badge);
            bool badgeAdded = _badgeDirectory.Count > badgeNum ? true : false;
            return badgeAdded;
        }

        public Dictionary<int, Badge> GetEachBadge()
        {
            return _badgeDirectory;
        }
        public bool GetBadgeID()
        {
            int key = _badgeDirectory.Count;
            if (_badgeDirectory.ContainsKey(key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveExistingBadge(Badge existingBadge)
        {
            bool badgeRemoved = _badgeDirectory.Remove(existingBadge.BadgeID);
            return badgeRemoved;
        }
    }
}

