﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities;

public abstract class Payment
{
    public Payment(DateOnly paidDate, DateOnly expireDate, decimal total, decimal totalPaid, string payer, string document, string address, string email)
    {
        Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Payer = payer;
        Document = document;
        Address = address;
        Email = email;
    }

    public string Number { get; private set; }
    public DateOnly PaidDate { get; private set; }
    public DateOnly ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Payer { get; private set; }
    public string Document { get; private set; }
    public string Address { get; private set; }
    public string Email { get; private set; }
}