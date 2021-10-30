using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class Student : Entity
{
    private readonly IList<Subscription> _subscriptions;

    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
            sub.Inactivate();
       
        _subscriptions.Add(subscription);
    }
}

