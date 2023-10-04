using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Motorcycle : IVehicle
{
    public string RegistrationNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleType VehicleType { get; init; } = VehicleType.Motorcycle;
    public double CostPerDay { get; set; }
    public RentedStatus RentedStatus { get; set; }
}
