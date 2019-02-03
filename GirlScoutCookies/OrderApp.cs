using System;

namespace GirlScoutCookies
{
    class OrderApp
    {
        static void Main(string[] args)
        {
            MasterOrder myMaster = new MasterOrder();
            bool run = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("Press A to Add order");
                if (myMaster.Orders.Count > 0)
                {
                    Console.WriteLine("Press S to show list of current orders");
                    Console.WriteLine("Press R to Remove order");
                }
                Console.WriteLine("Press C for cookie choices");
                Console.WriteLine("Press Q to quit");

                ConsoleKeyInfo menuChoice = Console.ReadKey();


                switch (menuChoice.Key)
                {
                    case ConsoleKey.A:
                        myMaster = Add(myMaster);
                        break;
                    case ConsoleKey.R:
                        myMaster = Remove(myMaster);
                        break;
                    case ConsoleKey.S:
                        myMaster.ShowList();
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("");
                        foreach (string cookie in myMaster.KindsOfCookies)
                        {
                            Console.WriteLine(cookie);
                        }
                        
                        break;
                    case ConsoleKey.Q:
                        Console.WriteLine("\n\nClosing program...");
                        return;
                    default:
                        break;
                }
                Pause();
            } while (run);            
        }

        static MasterOrder Add(MasterOrder myMaster)
        {
            bool error = false;
            Console.WriteLine("\n\nWhich variety would you like to order?");
            string whichKind = myMaster.CookieFinder(Console.ReadLine());

            

            int howMany;
            do
            {
                Console.WriteLine("How many boxes would you like to order?");
                if (!int.TryParse(Console.ReadLine(), out howMany))
                {
                    Console.WriteLine("Incorrect selection! Try again!");
                    error = true;
                }
            } while (error);
            
            myMaster.AddOrder(new CookieOrder(whichKind, howMany));            

            return myMaster;
        }

        static MasterOrder Remove(MasterOrder myMaster)
        {
            Console.WriteLine("\n\nWhich variety would you like to remove?");
            myMaster.RemoveVariety(Console.ReadLine());
            return myMaster;
        }

        static void Pause()
        {
            Console.WriteLine("\n\nPress any key to continue.");
            Console.ReadLine();
        }
    }
}
