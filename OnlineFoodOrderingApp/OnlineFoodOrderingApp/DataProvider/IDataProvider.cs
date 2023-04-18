using OnlineFoodOrderingApp.Model;

namespace OnlineFoodOrderingApp.DataProvider
{
    public interface IDataProvider
    {
        List<Hotel>  GetHotelDetails();
        List<MenuItem> GetHotelMenu(string hotelName);
        string OrderStatus(int orderID);

        void PlaceOrder(User order);
    }
}
