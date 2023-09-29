using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

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
    private int DaysRented() => Returned.DayNumber - Rented.DayNumber;
    private int TotalKm() => KmReturned != 0 ? KmReturned - KmRented : 0;
}
