# Payment Gateway 

This is a small project to practice **Software Architecture**, **Design Patterns** and **Unit Tests**, developed
through the **DDD** (Domain-Driven Design).

## The business

An educational technology website, where you can pay a monthly **subscription** to access various courses.
The company needs a service to **integrate with payment gateways**, enabling **students** to create a subscription 
on the website via PayPal, credit card or billet.

## Focus on domain

There is no data persistence in a database, but it can be easily implemented later in a infrastructure layer. There is also no integration with external services essential to a payment gateway: bank API's to generating billets, authentication and charging via credit card brands (Visa/Mastercard) or PayPal, but it can be also implemented later.

Here, we focus on the domain, on the business. We define the ubiquitous language and so we map the real world entities to
our classes, making abstractions and thinking from the generic to more specific characteristics and behaviors of each entity. 

We also created tests.They are as they should be: no integration with 
database or external services, allowing us to make sure the domain was well represented before developing the rest of the 
application.

## Design Patterns I have used

- **DI** (Dependency Injection, applied together with the DIP of the SOLID)
- **CQRS** (Command Query Responsibility Segregation)
- **Handler "pattern"** (something close to the **Chain Of Responsibility** pattern)
- **Repository**

## C# new features 

I'm using .NET 6 and **C# 10** in preview. Among the new features of the language are the
**global using directives** and **file-scoped namespaces**, which I explored in this project.




