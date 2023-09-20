using CarRental.Common.Classes;
using CarRental.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces;

public interface IBooking
{
    string RegistrationNo { get; set; }
    Customer Customer { get; set; }
    int KmRented { get; set; }
    int KmReturned { get; set; }
    DateOnly Rented { get; set; }
    DateOnly Returned { get; set; }
    double Cost { get; set; }
    BookingStatus Status { get; set; }
}
