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

            newMaster.AddOrder(new CookieOrder(1,10));

            Assert.NotEmpty(newMaster.Orders);
        }

        [Fact]
        public void Get_Total_Amount_Of_Orders()
        {
            MasterOrder newMaster = new MasterOrder();
            newMaster.AddOrder(new CookieOrder(1, 10));
            newMaster.AddOrder(new CookieOrder(1, 10));

            int totalBoxes = newMaster.GetTotalBoxes();

            Assert.Equal(2, totalBoxes);
        }
        [Fact]
        public void Find_Match_Point()
        {
            MasterOrder newMaster = new MasterOrder();
            newMaster.AddOrder(new CookieOrder(1, 10));
            

            string minMatchfound = newMaster.MinMatchFinder("Thin Mints");

            Assert.Equal("thi", minMatchfound);
        }

        [Fact]
        public void Removes_A_Variety()
        {
            MasterOrder newMaster = new MasterOrder();
            newMaster.AddOrder(new CookieOrder(1, 10));
            newMaster.AddOrder(new CookieOrder(1, 5));
            newMaster.AddOrder(new CookieOrder(0, 3));

            newMaster.RemoveVariety(newMaster.MinMatchFinder("Thin Mints"));

            Assert.Equal("S'mores®", newMaster.Orders[0].Variety);
        }
    }
}
