using CarRental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces;

public interface IVehicle
{
    string RegistrationNo { get; set; }
    string Make { get; set; }
    int Odometer { get; set; }
    double CostPerKm { get; set; }
    VehicleType VehicleType { get; set; }
    double CostPerDay { get; set; }
    RentedStatus RentedStatus { get; set; }
}
