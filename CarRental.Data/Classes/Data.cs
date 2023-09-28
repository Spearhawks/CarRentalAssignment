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

    Customer cust1 = new(1, "John", "Doe");
    Customer cust2 = new(1, "The", "Rock");
    Customer cust3 = new(1, "Dwayne", "Johnson");

    public Data() => SeedData();
    
    private void SeedData()
    {
        var todayDate = DateOnly.FromDateTime(DateTime.Today);
        var rentedDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-3));
        _persons.Add(new Customer { Ssn = 1, FirstName = "John", LastName = "Doe" });
        _persons.Add(new Customer { Ssn = 2, FirstName = "The", LastName = "Rock" });
        _persons.Add(new Customer { Ssn = 3, FirstName = "Dwayne", LastName = "Johnson" });
        _persons.Add(new Customer { Ssn = 4, FirstName = "Bobba", LastName = "Fett" });
        _vehicles.Add(new Car { RegistrationNo = "ABC123", Make = "Volvo", Odometer = 3233, CostPerKm = 120, CostPerDay = 300, VehicleType = VehicleType.Van, RentedStatus = RentedStatus.Available });
        _vehicles.Add(new Car { RegistrationNo = "GGF332", Make = "Opel", Odometer = 3993, CostPerKm = 100, CostPerDay = 200, VehicleType = VehicleType.Sedan, RentedStatus = RentedStatus.Rented });
        _vehicles.Add(new Car { RegistrationNo = "ABC123", Make = "Volvo", Odometer = 3233, CostPerKm = 120, CostPerDay = 300, VehicleType = VehicleType.Van, RentedStatus = RentedStatus.Available });
        _bookings.Add(new Booking { RegistrationNo = "ABC123", Customer = cust1, KmRented = 3233, KmReturned = 3333, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Open });
        _bookings.Add(new Booking { RegistrationNo = "GGF332", Customer = cust3, KmRented = 3993, KmReturned = 5677, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Closed });
        _bookings.Add(new Booking { RegistrationNo = "ABC123", Customer = cust2, KmRented = 3233, KmReturned = 3333, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Open });
    }

    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IVehicle> GetVehicles(RentedStatus status = RentedStatus.Available) => _vehicles;
}
