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

            KindsOfCookies = new List<string>()
            {
                "S'mores",
                "Thin Mints",
                "Samoas",
                "Tagalongs",
                "Trefoils",
                "Do-si-dos",
                "Lemonades",
                "Savannah Smiles",
                "Thanks-A-Lot",
                "Toffee-tastic",
                "Caramel Chocolate Chip"
            };
        
        }

        public List<CookieOrder> Orders { get; private set; }

        public List<string> KindsOfCookies { get; }

        public void AddOrder(CookieOrder newOrder)
        {
            Orders.Add(newOrder);
        }

        public int GetTotalBoxes()
        {
            return Orders.Count;
        }

        public string CookieFinder(string whichKind)
        {
            // since I am a terrible speller this helps find a close match of variety
            int matchPoint = 0;

            for (int i = 1; i <= KindsOfCookies.Count; i++)
            {
                string temp = whichKind.Remove(i).ToLower();
                int matches = 0;
                for (int j = 0; j < KindsOfCookies.Count; j++)
                {
                    if (temp.Equals(KindsOfCookies[j].Remove(i).ToLower()))
                    {
                        matches++;
                    }
                }
                if (matches == 1)
                {
                    matchPoint = i;
                    foreach(string cookie in KindsOfCookies)
                    {
                        if(whichKind.Remove(matchPoint).ToLower().Equals(cookie.Remove(matchPoint).ToLower()))
                        {
                            whichKind = cookie;
                        }
                    }
                    break;
                }

            }
            return whichKind;
        }

        public void RemoveVariety(string whichKind)
        {
            whichKind = CookieFinder(whichKind);
            if (Orders.Count > 0)
            {
                // Can't use the same list in a foreach that you remove from
                for (int i = 0; i < Orders.Count; i++)
                {
                    if (whichKind.Equals(Orders[i].Variety))
                    {
                        Orders.RemoveAt(i);
                        i--;
                    }
                }
                
            }
        }

        public int GetVarietyBoxes(string whichKind)
        {
            whichKind = CookieFinder(whichKind);
            int amount = 0;
            foreach (CookieOrder order in Orders)
            {
                if(whichKind.Equals(order.Variety))
                {
                    amount += order.NumBoxes;
                }
            }

            return amount;
        }

        public void ShowList()
        {
            Console.WriteLine("\nCurrent Order");
            int itemNumber = 1;
            foreach (CookieOrder order in Orders)
            {
                Console.WriteLine(itemNumber + ". Variety: " + order.Variety + " Boxes: " + order.NumBoxes);
                itemNumber++;
            }
        }
    }
}
