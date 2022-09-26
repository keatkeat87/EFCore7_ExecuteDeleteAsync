using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore7;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public Address Address { get; set; } = null!;
}

public class Address
{
    public string Line1 { get; set; } = "";
    public string Line2 { get; set; } = "";
}

