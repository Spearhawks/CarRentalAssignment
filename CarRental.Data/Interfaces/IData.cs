using CarRental.Common.Classes;
using CarRental.Common.Enums;
using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Data.Interfaces;

public interface IData
{
    IEnumerable<IPerson> GetPersons();
    IEnumerable<IVehicle> GetVehicles(RentedStatus status = default);
    IEnumerable<IBooking> GetBookings();
}
