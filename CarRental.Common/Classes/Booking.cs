using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public string RegistrationNo { get; init; }
    public Customer Customer { get; init; }
    public int KmRented { get; init; }
    public int KmReturned { get; set; }
    public DateOnly Rented { get; init; }
    public DateOnly Returned { get; set; }
    public double Cost { get; set; }
    public BookingStatus Status { get; set; }

    public Booking() { }
    public void ReturnVehicle(IVehicle vehicle)
    {
        Cost =  CalculateDays() * vehicle.CostPerDay + (KmReturned != 0 ? KmReturned - KmRented : 0) * vehicle.CostPerKm;
    }
    private int CalculateDays()
    {
        if(KmReturned != 0)
        {
            return Returned.DayNumber - Rented.DayNumber;
        }
        else { return 0; }
    }
    public string CustomerOut(Customer c)
    {
        return $"{c.LastName} {c.FirstName} ({c.SSN})";
    }
}
