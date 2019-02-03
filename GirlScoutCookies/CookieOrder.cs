using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookies
{
    public class CookieOrder
    {
        public CookieOrder(int whichKind, int howMany)
        {
            KindsOfCookies = new List<string>()
            {
                "S'mores®",
                "Thin Mints®",
                "Samoas®",
                "Tagalongs®",
                "Trefoils®",
                "Do-si-dos®",
                "Lemonades™",
                "Savannah Smiles®",
                "Thanks-A-Lot®",
                "Toffee-tastic®",
                "Caramel Chocolate Chip"
            };

            Variety = KindsOfCookies[whichKind];

            NumBoxes = howMany;

        }

        public List<string> KindsOfCookies { get; }

        public string Variety { get; private set; }

        public int NumBoxes { get; private set; }
    }
}
