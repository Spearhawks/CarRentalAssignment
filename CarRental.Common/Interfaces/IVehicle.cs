using CarRental.Common.Enums;

namespace CarRental.Common.Interfaces;

public interface IVehicle
{
    public string RegistrationNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleType VehicleType { get; init; }
    public double CostPerDay { get; set; }
    public RentedStatus RentedStatus { get; set; }
}
