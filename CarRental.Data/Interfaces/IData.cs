using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Data.Interfaces;

public interface IData
{
    IEnumerable<IPerson> GetPersons();
    IEnumerable<IVehicle> GetVehicles(RentedStatus status = default);
    IEnumerable<IBooking> GetBookings();
    public void UpdateBooking(IBooking _b, double cost);
}
