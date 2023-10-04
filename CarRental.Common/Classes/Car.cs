using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes;

public class Car : IVehicle
{
    public string RegistrationNo { get; init; }
    public string Make { get; init; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleType VehicleType { get; init; }
    public double CostPerDay { get; set; }
    public RentedStatus RentedStatus { get; set; }
}
