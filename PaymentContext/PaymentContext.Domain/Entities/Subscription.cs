﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities;

public class Subscription
{
    private readonly IList<Payment> _payments;

    public Subscription(DateTime? expireDate)
    {
        CreateDate = DateTime.Now;
        LastUpdateDate = DateTime.Now;
        ExpireDate = expireDate;
        Active = true;
        Payments = new List<Payment>();
    }

    public DateTime CreateDate { get; private set; }
    public DateTime LastUpdateDate { get; private set; }
    public DateTime? ExpireDate { get; private set; }
    public bool Active { get; private set; }
    public IReadOnlyCollection<Payment> Payments { get; private set; }

    public void AddPayment(Payment payment)
    {
        _payments.Add(payment);
    }

    public void Activate()
    {
        Active = true;
        LastUpdateDate = DateTime.Now;
    }

    public void Inactivate()
    {
        Active = false;
        LastUpdateDate = DateTime.Now;
    }
}

