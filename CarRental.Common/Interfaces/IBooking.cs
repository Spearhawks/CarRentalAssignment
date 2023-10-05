using CarRental.Common.Classes;
using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IBooking
{
    public string RegistrationNo { get; init; }
    public Customer Customer { get; init; }
    public int KmRented { get; init; }
    public int KmReturned { get; set; }
    public DateOnly Rented { get; init; }
    public DateOnly Returned { get; set; }
    public double Cost { get; set; }
    public BookingStatus Status { get; set; }
    public void ReturnVehicle(IVehicle vehicle);
    public string CustomerOut(Customer c);
}
