using CarRental.Common.Enums;
using CarRental.Common.Interfaces;

namespace CarRental.Common.Classes;

public class Motorcycle : IVehicle
{
    public string RegistrationNo { get; set; }
    public string Make { get; set; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleType VehicleType { get; set; } = VehicleType.Motorcycle;
    public double CostPerDay { get; set; }
    public RentedStatus RentedStatus { get; set; }
}
