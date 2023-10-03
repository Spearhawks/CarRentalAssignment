using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Business.Classes;

public class BookingManager
{
    private readonly IData _data;

    #region Index.razor related code.
    /// <summary>
    /// Variables and methods for changing what table that is shown.
    /// </summary>
    public string state = "vehicles";
    public void ShowVehicles() => state = "vehicles";
    public void ShowBookings() => state = "bookings";
    public void ShowCustomers() => state = "customers";
    #endregion

    public BookingManager(IData data) => _data = data;
    public IVehicle? GetVehicle(string regNo)
    {
        return _data.GetVehicles().Single(r => r.RegistrationNo == regNo);
    }
    public Booking GetBooking(int custid)
    {
        return (Booking)_data.GetBookings().Where(c => c.Customer.SSN == custid);
    }
    public string CustomerOutputString(Customer c)
    {
        return $"{c.LastName} {c.FirstName} ({c.SSN})";
    }
    public IPerson GetPerson(int custid)
    {
        return _data.GetPersons().Single(p => p.SSN == custid);
    }
    public IEnumerable<IBooking> GetBookings()
    {
        return _data.GetBookings();
    }
    public IEnumerable<Customer> GetCustomers() 
    {
        return _data.GetPersons().OfType<Customer>();
    }
    public IEnumerable<IVehicle> GetVehicles(RentedStatus status = default)
    {
        return _data.GetVehicles();
    }
}
