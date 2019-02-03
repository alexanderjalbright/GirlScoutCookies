using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookies
{
    public class MasterOrder
    {
        public MasterOrder()
        {
            Orders = new List<CookieOrder>();
        
        }

        public List<CookieOrder> Orders { get; private set; }

        public void AddOrder(CookieOrder newOrder)
        {
            Orders.Add(newOrder);
        }

        public int GetTotalBoxes()
        {
            return Orders.Count;
        }

        public string MinMatchFinder(string whichKind)
        {
            // Since I use the ®/™ symbols, it must find the closest match
            // also this helps with users that have my level of spelling
            int matchPoint = 0;
            for (int i = 1; i <= Orders[0].KindsOfCookies.Count; i++)
            {
                string temp = whichKind.Remove(i).ToLower();
                int matches = 0;
                foreach (string kind in Orders[0].KindsOfCookies)
                {
                    if (temp.Equals(kind.Remove(i).ToLower()))
                    {
                        matches++;
                    }
                }
                if (matches == 1)
                {
                    matchPoint = i;
                    break;
                }

            }
            return whichKind.Remove(matchPoint).ToLower();
        }

        public void RemoveVariety(string whichKind)
        {
            int matchPoint = whichKind.ToCharArray().Length;
            if (Orders.Count > 0)
            {
                
                if (matchPoint != 0)
                {
                    // Can't use the same list in a foreach that you remove from
                    for (int i = 0; i < Orders.Count; i++)
                    {
                        if (whichKind.Equals(Orders[i].Variety.Remove(matchPoint).ToLower()))
                        {
                            Orders.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }
    }
}
