﻿using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using CarRental.Data.Interfaces;

namespace CarRental.Data.Classes;

public class Data : IData
{
    readonly List<IPerson> _persons = new();
    readonly List<IVehicle> _vehicles = new();
    readonly List<IBooking> _bookings = new();

    public Data() => SeedData();
    private void SeedData()
    {
        _persons.Add(new Customer { SSN = 1, FirstName = "John", LastName = "Doe" });
        _persons.Add(new Customer { SSN = 2, FirstName = "The", LastName = "Rock" });
        _persons.Add(new Customer { SSN = 3, FirstName = "Dwayne", LastName = "Johnson" });
        _persons.Add(new Customer { SSN = 4, FirstName = "Bobba", LastName = "Fett" });
        _vehicles.Add(new Car { RegistrationNo = "ABC123", Make = "Volvo", Odometer = 3233, CostPerKm = 1.2, CostPerDay = 300, VehicleType = VehicleType.Van, RentedStatus = RentedStatus.Rented });
        _vehicles.Add(new Car { RegistrationNo = "GGF332", Make = "Opel", Odometer = 3993, CostPerKm = 1.0, CostPerDay = 200, VehicleType = VehicleType.Sedan, RentedStatus = RentedStatus.Available });
        _vehicles.Add(new Car { RegistrationNo = "CBA123", Make = "Volvo", Odometer = 3233, CostPerKm = 1.2, CostPerDay = 300, VehicleType = VehicleType.Combi, RentedStatus = RentedStatus.Rented });
        _vehicles.Add(new Motorcycle { RegistrationNo = "ZZZ666", Make = "Kawazakiiii", Odometer = 666, CostPerKm = 3.0, CostPerDay = 800, VehicleType = VehicleType.Motorcycle, RentedStatus = RentedStatus.Available });

        var todayDate = DateOnly.FromDateTime(DateTime.Today);
        var rentedDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-3));

        _bookings.Add(new Booking { RegistrationNo = "ABC123", Customer = (Customer)_persons[0], KmRented = 3233, KmReturned = 0, Rented = rentedDate, Cost = default, Status = BookingStatus.Open });
        _bookings.Add(new Booking { RegistrationNo = "GGF332", Customer = (Customer)_persons[1], KmRented = 3993, KmReturned = 4001, Rented = rentedDate, Returned = todayDate, Cost = default, Status = BookingStatus.Closed });
        _bookings.Add(new Booking { RegistrationNo = "CBA123", Customer = (Customer)_persons[2], KmRented = 5678, KmReturned = 0, Rented = rentedDate, Cost = default, Status = BookingStatus.Open });
        _bookings.Add(new Booking { RegistrationNo = "ZZZ666", Customer = (Customer)_persons[3], KmRented = 666, KmReturned = 777, Rented = rentedDate, Returned = todayDate, Cost = default, Status = BookingStatus.Closed });
    }
    public void UpdateBooking(IBooking _b, double cost)
    {
        _b = _bookings.FirstOrDefault(b => b.Cost == cost);
    }
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IVehicle> GetVehicles(RentedStatus status = RentedStatus.Available) => _vehicles;
}
