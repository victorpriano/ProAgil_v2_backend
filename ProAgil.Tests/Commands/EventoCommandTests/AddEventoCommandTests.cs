using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProAgil.Domain.Commands.Eventos;

namespace ProAgil.Tests.Commands.EventoCommandTests
{
    [TestClass]
    public class AddEventoCommandTests
    {
        private readonly AddEventoCommand _invalidCommand = new AddEventoCommand(null, DateTime.Now, null, 5, 
            "teste", "111111111", "teste");
        
        private readonly AddEventoCommand _validCommand = new AddEventoCommand("Natal", DateTime.Now, "csharp", 10, 
            "teste", "11111111", "teste@te.com.br");

        [TestMethod]
        public void DadoUmAddValido()
        {
            _validCommand.Validate();
            Assert.AreEqual(true, _validCommand.Validate());

        }

        [TestMethod]
        public void DadoUmAddInvalido()
        {
            _invalidCommand.Validate();
            Assert.AreEqual(false, _invalidCommand.Validate());
        }
    }
}