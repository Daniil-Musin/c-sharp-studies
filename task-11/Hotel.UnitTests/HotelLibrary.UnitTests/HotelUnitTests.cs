using System;
using NUnit.Framework;
using HotelLibrary;

namespace HotelLibrary.UnitTests
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
        public void GetInfo_Room_Test()
        {
            var Room = CreateTestRoom();
            var Info = Room.GetInfo();
                
            Assert.AreEqual(5, Info.Length);
            Assert.AreEqual($"Room's number is {102}", Info[0]);
            Assert.AreEqual($"Room's bedcount is {2}", Info[1]);
            Assert.AreEqual($"Room's windows' direction is {Direction.North}", Info[2]);
            Assert.AreEqual($"Room's cost per night is {199.99}", Info[3]);
            Assert.AreEqual($"Room will be freed on {new DateTime(2008, 5, 1, 8, 30, 52)}", Info[4]);
        }

        [Test]
        public void GetInfo_SemiLux_Test()
        {
            var SemiLux = CreateTestSemiLux();
            var Info = SemiLux.GetInfo();

            Assert.AreEqual($"This room has: {"Sofa"}", Info[4]);
        }

        [Test]
        public void GetInfo_Lux_Test()
        {
            var Lux = CreateTestLux();
            var Info = Lux.GetInfo();

            Assert.AreEqual($"Number of inner rooms: {4}", Info[5]);
            Assert.AreEqual($"Minimum duration of staying: {2}", Info[6]);
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

        private SemiLux CreateTestSemiLux()
        {
            var room = CreateTestRoom();
            var TestSemiLux = new SemiLux(
                room.Number, room.BedCount, room.WindowsDirection,
                "Sofa");
            TestSemiLux.CostPerNight = room.CostPerNight;
            TestSemiLux.TimeOfLeaving = room.TimeOfLeaving;
            return TestSemiLux;
        }

        private Lux CreateTestLux()
        {
            var semiLux = CreateTestSemiLux();
            var TestLux = new Lux(
                semiLux.Number, semiLux.BedCount, semiLux.WindowsDirection, semiLux.AvailableFacilities,
                4, 2);
            TestLux.CostPerNight = semiLux.CostPerNight;
            TestLux.TimeOfLeaving = semiLux.TimeOfLeaving;
            return TestLux;
        }
    }
}
