using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Data.Classes;

public class Data : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();

    public Data() => SeedData();
    
    private void SeedData()
    {
        _persons.Add(new Customer { CustID = 1, FirstName = "John", LastName = "Doe" });
        _vehicles.Add(new Car { RegistrationNo = "ABC123", Make ="Volvo", Odometer = 3233, CostPerKm = 120, CostPerDay = 300, VehicleType = VehicleType.Van , RentedStatus = RentedStatus.Available });
        _bookings.Add(new Booking { RegistrationNo = "ABC123", Customer = null, KmRented = 3233, KmReturned = 3333, Rented = new DateOnly(), Returned = new DateOnly(), Cost = 300, Status = BookingStatus.Open });
    }

    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IVehicle> GetVehicles(RentedStatus status = RentedStatus.Available) => _vehicles;
}
