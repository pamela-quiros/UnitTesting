using TestNinja.Fundamentals;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationsTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            //Arrange - Prepare ojects

            var reservation = new Reservation();


            //Act - Call method to test
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert - Verify result

            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
            //Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation {MadeBy = user};

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            //Arrange
            var reservation = new Reservation { MadeBy = new User()};

            //Act

            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }

    }
}