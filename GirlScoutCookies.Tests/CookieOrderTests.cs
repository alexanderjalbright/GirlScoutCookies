using System;
using Xunit;

namespace GirlScoutCookies.Tests
{
    public class CookieOrderTests
    {
        [Fact]
        public void Create_Instance()
        {
            CookieOrder newOrder = new CookieOrder(1,10);
        }

        [Fact]
        public void Variety_Can_Be_Set()
        {
            CookieOrder newOrder = new CookieOrder(1,10);
            
            Assert.Equal("Thin Mints®", newOrder.Variety);
        }

        [Fact]
        public void Set_NumBoxes()
        {
            CookieOrder newOrder = new CookieOrder(1,10);
            
            Assert.Equal(10, newOrder.NumBoxes);
        }
    }
}
