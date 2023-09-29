using CarRental.Common.Enums;

namespace CarRental.Common.Classes;

public class Motorcycle
{
    public string RegistrationNo { get; set; }
    public string Make { get; set; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleType VehicleType { get; } = VehicleType.Motorcycle;
    public double CostPerDay { get; set; }
    public RentedStatus RentedStatus { get; set; }
}
