using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Classes;

public class BookingManager
{
    // Data variables.
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

    // Constructor
    public BookingManager(IData data) => _data = data;

    public IVehicle? GetVehicle(string regNo)
    {
        return _data.GetVehicles().FirstOrDefault(r => r.RegistrationNo == regNo);
    }
    public Booking GetBooking(int custid)
    {
        return (Booking)_data.GetBookings().Where(c => c.Customer.SSN == custid);
    }

    public string CustomerData(Customer c)
    {
        return $"{c.LastName} {c.FirstName} ({c.SSN})";
    }

    public IPerson GetPerson(int custid)
    {
        return (IPerson)_data.GetPersons().Where(p => p.SSN == custid);
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
