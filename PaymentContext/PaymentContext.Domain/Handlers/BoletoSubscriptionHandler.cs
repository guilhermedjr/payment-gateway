namespace PaymentContext.Domain.Handlers;

public class BoletoSubscriptionHandler : IHandler<CreateBoletoSubscriptionCommand>
{
    private readonly IStudentRepository _studentsRepository;
    private readonly IEmailService _emailService;

    public BoletoSubscriptionHandler(
        IStudentRepository studentRepository,
        IEmailService emailService
       )
    {
        _studentsRepository = studentRepository;
        _emailService = emailService;
    }

    public async Task<ICommandResult> Handle(CreateBoletoSubscriptionCommand command)
    {
        if (_studentsRepository.DocumentExists(command.Document))
            return new CommandResult(false, "Este CPF já está em uso");

        if (_studentsRepository.EmailExists(command.Email))
            return new CommandResult(false, "Este email já está em uso");

        Name name = new (command.FirstName, command.LastName);
        Document document = new (command.Document, EDocumentType.CPF);
        Email email = new (command.Email);
        Address address = new (command.Street, command.Number, command.Neighborhood,
            command.City, command.State, command.Country, command.ZipCode);

        Student student = new (name, document, email);
        Subscription subscription = new (DateTime.Now.AddMonths(1));
        BoletoPayment payment = new(command.BarCode, command.BoletoNumber, command.PaidDate,
            command.ExpireDate, command.Total, command.TotalPaid, command.Payer,
            new Document(command.PayerDocument, command.PayerDocumentType), 
            address, email);

        subscription.AddPayment(payment);
        student.AddSubscription(subscription);

        _studentsRepository.CreateSubscription(student);

        await _emailService.SendEmailAsync(student.Email.Address, "Bem-vindo ao Cursos.com!",
            $"Olá, {student.Name.FirstName} {student.Name.LastName}, bem vindo!", false);

        return new CommandResult(true, "Assinatura realizada com sucesso");
    }
}

