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
    public int CustID { get; set; }

    public Customer()
    { }

    public Customer(int id, string fn, string ln) => 
        (CustID, FirstName, LastName) = ( id, fn, ln);
}
