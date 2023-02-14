using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notifiable, ICommand
    {
        public Guid Id { get; set; }

        public string User { get; set; }

        public string Title { get; set; }

        public UpdateTodoCommand()
        {

        }

        public UpdateTodoCommand(Guid id, string user, string title)
        {
            Id = id;
            User = user;
            Title = title;
        }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                        .Requires()
                        .HasMinLen(Title, 3, "Title", "Descreva melhor a tarefa")
                        .HasMinLen(User, 6, "User", "Usuário Inválido"));
        }
    }
}
