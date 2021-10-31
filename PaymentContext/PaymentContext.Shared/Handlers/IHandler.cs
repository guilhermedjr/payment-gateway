using PaymentContext.Shared.Commands;
namespace PaymentContext.Shared.Handlers;

public interface IHandler<T> where T : ICommand
{
    Task<ICommandResult> Handle(T command);
}

