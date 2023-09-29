using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes;

public class Customer : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int SSN { get; set; }

    public Customer()
    { }

    public Customer(int ssn, string fn, string ln) => 
        (SSN, FirstName, LastName) = ( ssn, fn, ln);
        
}
