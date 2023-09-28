using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public string RegistrationNo { get; set; }
    public Customer Customer { get; set; }
    public int KmRented { get; set; }
    public int KmReturned { get; set; }
    public DateOnly Rented { get; set; }
    public DateOnly Returned { get; set; }
    public double Cost { get; set; }
    public BookingStatus Status { get; set; }

    public void ReturnVehicle(IVehicle vehicle)
    {
        Cost = DaysRented() * vehicle.CostPerDay + TotalKm() * vehicle.CostPerKm;
    }

    private int DaysRented()
    {
        return Returned.DayNumber - Rented.DayNumber;
    }

    private int TotalKm()
    {
        if (KmReturned != null)
            return KmReturned - KmRented;
        else return 0;
    }

    public string CustomerData(Customer c)
    {
        return $"{c.LastName} {c.FirstName} ({c.Ssn})";
    }
}
