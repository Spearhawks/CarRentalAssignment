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
        var todayDate = DateOnly.FromDateTime(DateTime.Today);
        var rentedDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-3));
        _persons.Add(new Customer { SSN = 1, FirstName = "John", LastName = "Doe" });
        _persons.Add(new Customer { SSN = 2, FirstName = "The", LastName = "Rock" });
        _persons.Add(new Customer { SSN = 3, FirstName = "Dwayne", LastName = "Johnson" });
        _persons.Add(new Customer { SSN = 4, FirstName = "Bobba", LastName = "Fett" });
        _vehicles.Add(new Car { RegistrationNo = "ABC123", Make = "Volvo", Odometer = 3233, CostPerKm = 120, CostPerDay = 300, VehicleType = VehicleType.Van, RentedStatus = RentedStatus.Rented });
        _vehicles.Add(new Car { RegistrationNo = "GGF332", Make = "Opel", Odometer = 3993, CostPerKm = 100, CostPerDay = 200, VehicleType = VehicleType.Sedan, RentedStatus = RentedStatus.Available });
        _vehicles.Add(new Car { RegistrationNo = "CBA123", Make = "Volvo", Odometer = 3233, CostPerKm = 120, CostPerDay = 300, VehicleType = VehicleType.Van, RentedStatus = RentedStatus.Rented });
        _vehicles.Add(new Car { RegistrationNo = "ZZZ666", Make = "Jaguar", Odometer = 666, CostPerKm = 300, CostPerDay = 800, VehicleType = VehicleType.Motorcycle, RentedStatus = RentedStatus.Available });
        _bookings.Add(new Booking { RegistrationNo = "ABC123", Customer = (Customer)_persons.FirstOrDefault(c => c.SSN == 1), KmRented = 3233, KmReturned = 0, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Open });
        _bookings.Add(new Booking { RegistrationNo = "GGF332", Customer = (Customer)_persons.FirstOrDefault(c => c.SSN == 2), KmRented = 3993, KmReturned = 5677, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Closed });
        _bookings.Add(new Booking { RegistrationNo = "CBA123", Customer = (Customer)_persons.FirstOrDefault(c => c.SSN == 3), KmRented = 5678, KmReturned = 0, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Open });
        _bookings.Add(new Booking { RegistrationNo = "ZZZ666", Customer = (Customer)_persons.FirstOrDefault(c => c.SSN == 4), KmRented = 666, KmReturned = 4091, Rented = rentedDate, Returned = todayDate, Cost = 0, Status = BookingStatus.Closed });
    }
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IVehicle> GetVehicles(RentedStatus status = RentedStatus.Available) => _vehicles;
}
