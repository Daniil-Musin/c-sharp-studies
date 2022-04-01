using System;
using NUnit.Framework;
using Hotel;

namespace Hotel.UnitTests
{
    [TestFixture]
    public class RoomUnitTest
    {
        [Test]
        public void ConstructorTest()
        {
            var Room = CreateTestRoom();
            Assert.AreEqual(102, Room.Number);
            Assert.AreEqual(2, Room.BedCount);
            Assert.AreEqual(Direction.North, Room.WindowsDirection);
            Assert.AreEqual(199.99, Room.CostPerNight);
            Assert.AreEqual(new DateTime(2008, 5, 1, 8, 30, 52), Room.TimeOfLeaving);
        }
        [Test]
        public void ToString_Room_Test()
        {
            var Room = CreateTestRoom();
            Assert.AreEqual("Room #102", Room.ToString());
        }

        private Room CreateTestRoom()
        {
            var TestRoom = new Room(102, 2, Direction.North);
            TestRoom.CostPerNight = 199.99;
            TestRoom.TimeOfLeaving = new DateTime(2008, 5, 1, 8, 30, 52);
            return TestRoom;
        }
    }
}
