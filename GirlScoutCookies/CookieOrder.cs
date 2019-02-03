using System;
using System.Collections.Generic;
using System.Text;

namespace GirlScoutCookies
{
    public class CookieOrder
    {
        public CookieOrder(string whichKind, int howMany)
        {
            Variety = whichKind;

            NumBoxes = howMany;
        }

        public List<string> KindsOfCookies { get; }

        public string Variety { get; private set; }

        public int NumBoxes { get; private set; }
    }
}
