using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities;

public class Subscription
{
    public DateOnly CreateDate { get; set; }
    public DateOnly LastUpdateDate { get; set; }
    public DateOnly? ExpireDate { get; set; }
    public bool Active { get; set; }
    public List<Payment> Payments { get; set; }
}

