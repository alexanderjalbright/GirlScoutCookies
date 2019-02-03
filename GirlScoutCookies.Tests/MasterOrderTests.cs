using System;
using Xunit;

namespace GirlScoutCookies.Tests
{
    public class MasterOrderTests
    {
        [Fact]
        public void Create_Master_Order()
        {
            MasterOrder newMaster = new MasterOrder();
        }

        [Fact]
        public void List_is_Empty()
        {
            MasterOrder newMaster = new MasterOrder();

            Assert.Empty(newMaster.Orders);
        }

        [Fact]
        public void Can_Add_to_List()
        {
            MasterOrder newMaster = new MasterOrder();

            newMaster.AddOrder(new CookieOrder("Thin Mints",10));

            Assert.NotEmpty(newMaster.Orders);
        }

        [Fact]
        public void Get_Total_Amount_Of_Orders()
        {
            MasterOrder newMaster = new MasterOrder();
            newMaster.AddOrder(new CookieOrder("Thin Mints", 10));
            newMaster.AddOrder(new CookieOrder("Thin Mints", 10));

            int totalBoxes = newMaster.GetTotalBoxes();

            Assert.Equal(2, totalBoxes);
        }
        [Fact]
        public void Find_Matching_Text()
        {
            MasterOrder newMaster = new MasterOrder();            

            string minMatchfound = newMaster.CookieFinder("Thin");

            Assert.Equal("Thin Mints", minMatchfound);
        }

        [Fact]
        public void Removes_A_Variety()
        {
            MasterOrder newMaster = new MasterOrder();
            newMaster.AddOrder(new CookieOrder("Thin Mints", 10));
            newMaster.AddOrder(new CookieOrder("Thin Mints", 5));
            newMaster.AddOrder(new CookieOrder("S'mores", 3));

            newMaster.RemoveVariety("Thin Mints");

            Assert.Equal("S'mores", newMaster.Orders[0].Variety);
        }

        [Fact]
        public void Gets_Total_Boxes_of_Variety()
        {
            MasterOrder newMaster = new MasterOrder();
            newMaster.AddOrder(new CookieOrder("Thin Mints", 10));
            newMaster.AddOrder(new CookieOrder("Thin Mints", 5));
            newMaster.AddOrder(new CookieOrder("S'mores", 3));

            int varietyTotal = newMaster.GetVarietyBoxes("Thin");

            Assert.Equal(15, varietyTotal);
        }
    }
}
