using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        [TestMethod]
        public void DadoUmNovoTodoOMesmoNaoPodeSerConcluido()
        {
            var todo = new TodoItem("titulo todo",DateTime.Now, "gabriel.alves");

            Assert.AreEqual(todo.Done, false);
        }
    }
}
