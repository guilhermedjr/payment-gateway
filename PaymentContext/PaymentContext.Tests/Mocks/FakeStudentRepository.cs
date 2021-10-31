using PaymentContext.Domain.Repositories;
namespace PaymentContext.Tests.Mocks;

public class FakeStudentRepository : IStudentRepository
{
    public void CreateSubscription(Student student)
    {
        
    }

    public bool DocumentExists(string document)
    {
        if (document == "999.999.999-99")
            return true;
        return false;
    }

    public bool EmailExists(string email)
    {
        if (email == "teste@gmail.com")
            return true;
        return false;
    }
}

