using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueriesTests
    {
        private List<TodoItem> _items;

        public TodoQueriesTests()
        {
            _items = new List<TodoItem>()
            {
                new TodoItem("Tarefa 1", DateTime.Now, "usuario1" ),
                new TodoItem("Tarefa 2", DateTime.Now, "usuario2" ),
                new TodoItem("Tarefa 3", DateTime.Now, "gabriel.alves" ),
                new TodoItem("Tarefa 4", DateTime.Now, "gabriel.alves" ),
                new TodoItem("Tarefa 5", DateTime.Now, "gabriel.alves" ),
            };
        }

        [TestMethod]
        public void DeveRetornarApenasAsTarefasDoUsuarioGabrielAlves()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("gabriel.alves"));

            Assert.AreEqual(result.Count(), 3);
        }
    }
}
