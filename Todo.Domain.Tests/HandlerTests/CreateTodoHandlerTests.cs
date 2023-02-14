using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        [TestMethod]
        public void DadoUmComandoInvalidoDeveInterromperAExecucao()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var handler = new TodoHandler(new FakeTodoRepository());
            var result = (GenericCommandResult)handler.Handle(command);

            Assert.AreEqual(result.Success, false);
        }

        [TestMethod]
        public void DadoUmComandoValidoDeveCriarATarefa()
        {
            var command = new CreateTodoCommand("titulo tarefa", "gabriel.alves", DateTime.Now);
            var handler = new TodoHandler(new FakeTodoRepository());
            var result = (GenericCommandResult)handler.Handle(command);

            Assert.AreEqual(result.Success, true);
        }
    }
}
