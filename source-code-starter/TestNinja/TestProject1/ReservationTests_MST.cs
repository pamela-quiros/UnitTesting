//using TestNinja.Fundamentals;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace TestNinja.UnitTests
//{
//    [TestClass]
//    public class ReservationsTests
//    {
//        [TestMethod]
//        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
//        {
//            //Arrange - Prepare ojects

//            var reservation = new Reservation();


//            //Act - Call method to test
//            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

//            //Assert - Verify result

//            Assert.IsTrue(result);
//        }

//        [TestMethod]
//        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
//        {
//            //Arrange
//            var user = new User();
//            var reservation = new Reservation {MadeBy = user};

//            //Act
//            var result = reservation.CanBeCancelledBy(user);

//            //Assert
//            Assert.IsTrue(result);

//        }

//        [TestMethod]
//        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
//        {
//            //Arrange
//            var reservation = new Reservation { MadeBy = new User()};

//            //Act

//            var result = reservation.CanBeCancelledBy(new User());

//            //Assert
//            Assert.IsFalse(result);
//        }

//    }
//}