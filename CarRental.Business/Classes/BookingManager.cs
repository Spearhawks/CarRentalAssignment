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
    private readonly IData _data;

    public BookingManager(IData data) => _data = data;

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
