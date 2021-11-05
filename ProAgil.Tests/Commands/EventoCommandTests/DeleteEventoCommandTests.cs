using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProAgil.Domain.Commands.Evento;

namespace ProAgil.Tests.Commands.EventoCommandTests
{
    [TestClass]
    public class DeleteEventoCommandTests
    {
        private readonly DeleteEventoCommand _invalidCommand = new DeleteEventoCommand(Guid.Empty);
        private readonly DeleteEventoCommand _validCommand = new DeleteEventoCommand(Guid.NewGuid());

        [TestMethod]
        public void DadoUmDeleteValido()
        {
            _validCommand.Validate();

            Assert.AreEqual(true, _validCommand.Validate());
        }

        [TestMethod]
        public void DadoUmDeleteInvalido()
        {
            _invalidCommand.Validate();

            Assert.AreEqual(false, _invalidCommand.Validate());
        }
    }
}