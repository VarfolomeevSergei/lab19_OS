namespace Lab1.Tests
{
    public class RealEstateTests
    {
       
        [Theory]
        [InlineData(-1)]
        public void Constructor_InvalidFloor_ThrowsArgumentException2(int floor)
        {
            int area = 50;
            int rooms = 2;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíûé ýòàæ.", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        public void Constructor_InvalidRooms_ThrowsArgumentException2(int rooms)
        {
            int area = 50;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíîå êîëè÷åñòâî êîìíàò.", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        public void Constructor_InvalidArea_ThrowsArgumentException2(int area)
        {
            int rooms = 2;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíàÿ ïëîùàäü.", exception.Message);
        }

        [Theory]
        [InlineData("äà÷à")]
        [InlineData("")]
        public void Constructor_InvalidPropertyType_ThrowsArgumentException2(string propertyType)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíûé òèï íåäâèæèìîñòè.", exception.Message);
        }

        [Theory]
        [InlineData("ëåñîïîëîñà")]
        [InlineData("")]
        public void Constructor_InvalidLocation_ThrowsArgumentException2(string location)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíîå ðàñïîëîæåíèå.", exception.Message);
        }

        //
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidArea_ThrowsArgumentException(int area)
        {
            int rooms = 2;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíàÿ ïëîùàäü.", exception.Message);
        }

        

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidRooms_ThrowsArgumentException(int rooms)
        {
            int area = 50;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíîå êîëè÷åñòâî êîìíàò.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidFloor_ThrowsArgumentException(int floor)
        {
            int area = 50;
            int rooms = 2;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíûé ýòàæ.", exception.Message);
        }

        [Theory]
        [InlineData("îôèñ")]
        [InlineData("")]
        public void Constructor_InvalidPropertyType_ThrowsArgumentException(string propertyType)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string condition = "íîâîå";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíûé òèï íåäâèæèìîñòè.", exception.Message);
        }

        [Theory]
        [InlineData("ñòàðîå")]
        [InlineData("")]
        public void Constructor_InvalidCondition_ThrowsArgumentException(string condition)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string location = "öåíòð";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíîå ñîñòîÿíèå îáúåêòà.", exception.Message);
        }

        [Theory]
        [InlineData("ëåñ")]
        [InlineData("")]
        public void Constructor_InvalidLocation_ThrowsArgumentException(string location)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "êâàðòèðà";
            string condition = "íîâîå";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Íåêîððåêòíîå ðàñïîëîæåíèå.", exception.Message);
        }

        [Theory]
        [InlineData(50, 1, 1, "êâàðòèðà", "íîâîå", "öåíòð", 1763437.50)]
        [InlineData(50, 4, 6, "äîì", "õîðîøåå", "ïðèãîðîä", 2530000)]
        [InlineData(50, 3, 5, "ñòóäèÿ", "òðåáóåò ðåìîíòà", "îòäàëåííûé ðàéîí", 50 * 25000 * 0.80)]
        [InlineData(100, 5, 7, "êâàðòèðà", "íîâîå", "öåíòð", 5218125)]
        [InlineData(30, 2, 3, "äîì", "òðåáóåò ðåìîíòà", "ïðèãîðîä", 30 * 40000 * 0.80)]
        [InlineData(70, 3, 10, "êâàðòèðà", "õîðîøåå", "öåíòð", 70 * 30000 * 1.15 * 1.25)]
        public void CalculatePrice_VariousParameters_ReturnsCorrectPrice(int area, int rooms, int floor, string propertyType, string condition, string location, decimal expectedPrice)
        {
            var realEstate = new RealEstate(area, rooms, floor, propertyType, condition, location);
            decimal price = realEstate.CalculatePrice();
            Assert.Equal(expectedPrice, price, precision: 2);
        }
    }
}



















//namespace Lab1.Tests
//{
//    public class RealEstateTests
//    {
//        [Theory]
//        [InlineData(0)]
//        [InlineData(-1)]
//        public void Constructor_InvalidArea_ThrowsArgumentException(int area)
//        {
//            // Arrange
//            int rooms = 2;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            // Act & Assert
//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíàÿ ïëîùàäü.", exception.Message);
//        }

//        [Theory]
//        [InlineData(0)]
//        [InlineData(-1)]
//        public void Constructor_InvalidRooms_ThrowsArgumentException(int rooms)
//        {
//            int area = 50;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíîå êîëè÷åñòâî êîìíàò.", exception.Message);
//        }

//        [Theory]
//        [InlineData(0)]
//        [InlineData(-1)]
//        public void Constructor_InvalidFloor_ThrowsArgumentException(int floor)
//        {
//            int area = 50;
//            int rooms = 2;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíûé ýòàæ.", exception.Message);
//        }

//        [Theory]
//        [InlineData("îôèñ")]
//        [InlineData("")]
//        public void Constructor_InvalidPropertyType_ThrowsArgumentException(string propertyType)
//        {
//            int area = 50;
//            int rooms = 2;
//            int floor = 1;
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíûé òèï íåäâèæèìîñòè.", exception.Message);
//        }

//        [Theory]
//        [InlineData("ñòàðîå")]
//        [InlineData("")]
//        public void Constructor_InvalidCondition_ThrowsArgumentException(string condition)
//        {
//            int area = 50;
//            int rooms = 2;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíîå ñîñòîÿíèå îáúåêòà.", exception.Message);
//        }

//        [Theory]
//        [InlineData("ëåñ")]
//        [InlineData("")]
//        public void Constructor_InvalidLocation_ThrowsArgumentException(string location)
//        {
//            int area = 50;
//            int rooms = 2;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíîå ðàñïîëîæåíèå.", exception.Message);
//        }

//        [Theory]
//        [InlineData(50, 1, 1, "êâàðòèðà", "íîâîå", "öåíòð", 1763437.50)]
//        [InlineData(50, 4, 6, "äîì", "õîðîøåå", "ïðèãîðîä", 2530000)]
//        [InlineData(50, 3, 5, "ñòóäèÿ", "òðåáóåò ðåìîíòà", "îòäàëåííûé ðàéîí", 50 * 25000 * 0.80)]
//        [InlineData(100, 5, 7, "êâàðòèðà", "íîâîå", "öåíòð", 5218125)]
//        public void CalculatePrice_VariousParameters_ReturnsCorrectPrice(int area, int rooms, int floor, string propertyType, string condition, string location, decimal expectedPrice)
//        {
//            var realEstate = new RealEstate(area, rooms, floor, propertyType, condition, location);
//            decimal price = realEstate.CalculatePrice();
//            Assert.Equal(expectedPrice, price);
//        }
//    }
//}



//namespace Lab1.Tests
//{
//    public class RealEstateTests
//    {
//        [Theory]
//        [InlineData(0)]
//        [InlineData(-1)]
//        public void Constructor_InvalidArea_ThrowsArgumentException(int area)
//        {
//            int rooms = 2;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíàÿ ïëîùàäü.", exception.Message);
//        }

//        [Theory]
//        [InlineData(0)]
//        [InlineData(-1)]
//        public void Constructor_InvalidRooms_ThrowsArgumentException(int rooms)
//        {
//            int area = 50;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíîå êîëè÷åñòâî êîìíàò.", exception.Message);
//        }

//        [Theory]
//        [InlineData(0)]
//        [InlineData(-1)]
//        public void Constructor_InvalidFloor_ThrowsArgumentException(int floor)
//        {
//            int area = 50;
//            int rooms = 2;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíûé ýòàæ.", exception.Message);
//        }

//        [Theory]
//        [InlineData("îôèñ")]
//        [InlineData("")]
//        public void Constructor_InvalidPropertyType_ThrowsArgumentException(string propertyType)
//        {
//            int area = 50;
//            int rooms = 2;
//            int floor = 1;
//            string condition = "íîâîå";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíûé òèï íåäâèæèìîñòè.", exception.Message);
//        }

//        [Theory]
//        [InlineData("ñòàðîå")]
//        [InlineData("")]
//        public void Constructor_InvalidCondition_ThrowsArgumentException(string condition)
//        {
//            int area = 50;
//            int rooms = 2;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string location = "öåíòð";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíîå ñîñòîÿíèå îáúåêòà.", exception.Message);
//        }

//        [Theory]
//        [InlineData("ëåñ")]
//        [InlineData("")]
//        public void Constructor_InvalidLocation_ThrowsArgumentException(string location)
//        {
//            int area = 50;
//            int rooms = 2;
//            int floor = 1;
//            string propertyType = "êâàðòèðà";
//            string condition = "íîâîå";

//            var exception = Assert.Throws<ArgumentException>(() =>
//                new RealEstate(area, rooms, floor, propertyType, condition, location));
//            Assert.Equal("Íåêîððåêòíîå ðàñïîëîæåíèå.", exception.Message);
//        }


//        [Theory]
//        [InlineData(50, 1, 1, "êâàðòèðà", "íîâîå", "öåíòð", 1763437.500)]
//        [InlineData(50, 4, 6, "äîì", "õîðîøåå", "ïðèãîðîä", 2530000)]
//        [InlineData(50, 3, 5, "ñòóäèÿ", "òðåáóåò ðåìîíòà", "îòäàëåííûé ðàéîí", 50 * 25000 * 0.80)]
//        [InlineData(100, 5, 7, "êâàðòèðà", "íîâîå", "öåíòð", 5218125)]
//		[InlineData(50, 1, 3, "êâàðòèðà", "õîðîøåå", "öåíòð", 1781250)]
//		[InlineData(50, 4, 3, "êâàðòèðà", "õîðîøåå", "öåíòð", 2062500)]
//		[InlineData(50, 2, 1, "êâàðòèðà", "õîðîøåå", "öåíòð", 1687500)]
//		[InlineData(50, 2, 6, "êâàðòèðà", "õîðîøåå", "öåíòð", 2156250)]
//		[InlineData(50, 2, 3, "êâàðòèðà", "íîâîå", "öåíòð", 2062500)]
//		[InlineData(50, 2, 3, "êâàðòèðà", "òðåáóåò ðåìîíòà", "öåíòð", 1500000)]
//		public void CalculatePrice_VariousParameters_ReturnsCorrectPrice(int area, int rooms, int floor, string propertyType, string condition, string location, decimal expectedPrice)
//        {
//            var realEstate = new RealEstate(area, rooms, floor, propertyType, condition, location);

//            decimal price = realEstate.CalculatePrice();

//            Assert.Equal(expectedPrice, price);
//        }
//    }
//}
