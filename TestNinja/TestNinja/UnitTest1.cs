using TestNinja.Fundamentals;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationsTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange - Prepare ojects

            var reservation = new Reservation();


            //Act - Call method to test
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert - Verify result

            Assert.
        }
    }
}