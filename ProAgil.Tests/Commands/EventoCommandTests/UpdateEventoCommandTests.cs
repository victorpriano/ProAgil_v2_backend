using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProAgil.Domain.Commands.Eventos;

namespace ProAgil.Tests.Commands.EventoCommandTests
{
    [TestClass]
    public class UpdateEventoCommandTests
    {
        private readonly UpdateEventoCommand _invalidCommand = new UpdateEventoCommand(Guid.Empty, "",
            DateTime.Now, "", 10, "teste", "111111111", "teste");
        private readonly UpdateEventoCommand _validCommand = new UpdateEventoCommand(Guid.NewGuid(), "natal",
            DateTime.Now, "teste", 10, "teste", "111111111", "teste@test.com");
        
        [TestMethod]
        public void DadoUmUpdateValido()
        {
            _validCommand.Validate();

            Assert.AreEqual(true, _validCommand.Validate());
        }

        [TestMethod]
        public void DadoUmUpdateInvalido()
        {
            _invalidCommand.Validate();

            Assert.AreEqual(false, _invalidCommand.Validate());
        }
    }
}