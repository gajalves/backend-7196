using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracts.Interfaces
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
