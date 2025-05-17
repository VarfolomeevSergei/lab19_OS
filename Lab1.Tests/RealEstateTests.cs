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
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректный этаж.", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        public void Constructor_InvalidRooms_ThrowsArgumentException2(int rooms)
        {
            int area = 50;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное количество комнат.", exception.Message);
        }

        [Theory]
        [InlineData(-1)]
        public void Constructor_InvalidArea_ThrowsArgumentException2(int area)
        {
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректная площадь.", exception.Message);
        }

        [Theory]
        [InlineData("дача")]
        [InlineData("")]
        public void Constructor_InvalidPropertyType_ThrowsArgumentException2(string propertyType)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректный тип недвижимости.", exception.Message);
        }

        [Theory]
        [InlineData("лесополоса")]
        [InlineData("")]
        public void Constructor_InvalidLocation_ThrowsArgumentException2(string location)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное расположение.", exception.Message);
        }

        //
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidArea_ThrowsArgumentException(int area)
        {
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректная площадь.", exception.Message);
        }

        

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidRooms_ThrowsArgumentException(int rooms)
        {
            int area = 50;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное количество комнат.", exception.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Constructor_InvalidFloor_ThrowsArgumentException(int floor)
        {
            int area = 50;
            int rooms = 2;
            string propertyType = "квартира";
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректный этаж.", exception.Message);
        }

        [Theory]
        [InlineData("офис")]
        [InlineData("")]
        public void Constructor_InvalidPropertyType_ThrowsArgumentException(string propertyType)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string condition = "новое";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректный тип недвижимости.", exception.Message);
        }

        [Theory]
        [InlineData("старое")]
        [InlineData("")]
        public void Constructor_InvalidCondition_ThrowsArgumentException(string condition)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string location = "центр";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное состояние объекта.", exception.Message);
        }

        [Theory]
        [InlineData("лес")]
        [InlineData("")]
        public void Constructor_InvalidLocation_ThrowsArgumentException(string location)
        {
            int area = 50;
            int rooms = 2;
            int floor = 1;
            string propertyType = "квартира";
            string condition = "новое";

            var exception = Assert.Throws<ArgumentException>(() =>
                new RealEstate(area, rooms, floor, propertyType, condition, location));
            Assert.Equal("Некорректное расположение.", exception.Message);
        }

        [Theory]
        [InlineData(50, 1, 1, "квартира", "новое", "центр", 1763437.50)]
        [InlineData(50, 4, 6, "дом", "хорошее", "пригород", 2530000)]
        [InlineData(50, 3, 5, "студия", "требует ремонта", "отдаленный район", 50 * 25000 * 0.80)]
        [InlineData(100, 5, 7, "квартира", "новое", "центр", 5218125)]
        [InlineData(30, 2, 3, "дом", "требует ремонта", "пригород", 30 * 40000 * 0.80)]
        [InlineData(70, 3, 10, "квартира", "хорошее", "центр", 70 * 30000 * 1.15 * 1.25)]
        public void CalculatePrice_VariousParameters_ReturnsCorrectPrice(int area, int rooms, int floor, string propertyType, string condition, string location, decimal expectedPrice)
        {
            var realEstate = new RealEstate(area, rooms, floor, propertyType, condition, location);
            decimal price = realEstate.CalculatePrice();
            Assert.Equal(expectedPrice, price, precision: 2);
        }
    }
}
