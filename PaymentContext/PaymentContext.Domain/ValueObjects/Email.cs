using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects;

public class Email
{
    public Email(string address)
    {
        Address = address;
    }

    public string Address { get; private set; }
}


