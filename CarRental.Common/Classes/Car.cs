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
    public string RegistrationNo { get; set; }
    public string Make { get; set; }
    public int Odometer { get; set; }
    public double CostPerKm { get; set; }
    public VehicleType VehicleType { get; set; }
    public double CostPerDay { get; set; }
    public RentedStatus RentedStatus { get; set; }
}
