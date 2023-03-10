using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("titulo", "gabriel.alves", DateTime.Now);

        [TestMethod]
        public void DadoUmComandoInvalido()
        {            
            _invalidCommand.Validate();

            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void DadoUmComandoValido()
        {            
            _validCommand.Validate();

            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
