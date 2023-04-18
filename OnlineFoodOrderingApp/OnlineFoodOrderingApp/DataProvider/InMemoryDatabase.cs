using OnlineFoodOrderingApp.Model;

namespace OnlineFoodOrderingApp.DataProvider
{
    public class InMemoryDatabase : IDataProvider
    {

        List<HotelDetails>? _hotelDetails;
        List<Hotel>? _hotels;
        Dictionary<string, List<MenuItem>>? _hotelMenu;
        List<User> _orderList;
        
        public InMemoryDatabase()
        {
            _orderList = new List<User>();

            // menu item for each hotels
            var hotelOneMenu = new List<MenuItem>()
            {
                new MenuItem()
                {
                    Id = 1,
                    FoodName = "Mutton Biriyani",
                    Category = "Biriyani",
                    Price = 270
                },
                new MenuItem()
                {
                    Id = 2,
                    FoodName = "Chicken Biriyani",
                    Category = "Biriyani",
                    Price = 260
                },
                new MenuItem()
                {
                    Id = 3,
                    FoodName = "Egg Biriyani",
                    Category = "Biriyani",
                    Price = 250
                }

            };

            // hotel details
            _hotels = new List<Hotel>();
            _hotels.Add(new Hotel()
            {
                HotelName = "Arthi",
                Location = "CBE"
            });
            _hotels.Add(new Hotel()
            {
                HotelName = "Vasanth",
                Location = "PONDI",
            });
            _hotels.Add(new Hotel()
            {
                HotelName = "Hari",
                Location = "SIVAKASI"
            });

            // hotel details with menu items
            _hotelDetails = new List<HotelDetails>();
            _hotelDetails.Add(
                new HotelDetails()
                {
                    Hotel = _hotels[0],
                    Menu = hotelOneMenu
                });
            _hotelDetails.Add(
                new HotelDetails()
                {
                    Hotel = _hotels[1],
                    Menu = hotelOneMenu
                });
            _hotelDetails.Add(
                new HotelDetails()
                {
                    Hotel = _hotels[2],
                    Menu = hotelOneMenu
                });

            _hotelMenu = new Dictionary<string, List<MenuItem>>();
            _hotelMenu[_hotels[0].HotelName] = hotelOneMenu;
            _hotelMenu[_hotels[1].HotelName] = hotelOneMenu;
            _hotelMenu[_hotels[2].HotelName] = hotelOneMenu;
        }

        

        public string OrderStatus(int OrderID)
        {
            if (OrderID == 1)
                return "Order placed";
            return "No order found";
        }

        public List<Hotel> GetHotelDetails()
        {
            return _hotels;
        }
        public List<MenuItem> GetHotelMenu(string hotelName)
        {
            return _hotelMenu[hotelName];
        }

        public void PlaceOrder(User order)
        {
            _orderList.Add(order);
        }
    }
}
