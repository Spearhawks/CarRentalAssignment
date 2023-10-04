using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Interfaces;

public interface IPerson
{
    public int SSN { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
