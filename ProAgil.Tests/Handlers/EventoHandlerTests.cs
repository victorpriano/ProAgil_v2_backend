using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProAgil.Domain.Commands;
using ProAgil.Domain.Commands.Evento;
using ProAgil.Domain.Commands.Eventos;
using ProAgil.Domain.Handlers;

namespace ProAgil.Tests.Handlers
{
    [TestClass]
    public class EventoHandlerTests
    {
        private readonly AddEventoCommand _invalidCreateCommand = new AddEventoCommand("", DateTime.Now, "", 10, 
            "img.jpg", "9898989898", "teste");
        
        private readonly AddEventoCommand _validCreateCommand = new AddEventoCommand("Natal", DateTime.Now, "csharp", 10, 
            "teste", "11111111", "teste@test.com");

        private readonly DeleteEventoCommand _invalidDeleteCommand = new DeleteEventoCommand(Guid.Empty);

        private readonly DeleteEventoCommand _validDeleteCommand = new DeleteEventoCommand(Guid.NewGuid());
        // Corrigir o delete

        private readonly UpdateEventoCommand _invalidUpdateCommand = new UpdateEventoCommand(Guid.Empty, "", DateTime.Now,
            "", 10, "teste.jpg", "98989898", "teste");

        private readonly UpdateEventoCommand _validUpdateCommand = new UpdateEventoCommand(Guid.NewGuid(), "natal", DateTime.Now,
            "c#", 10, "teste.jpg", "98989898", "teste@test.com");

        private readonly EventoHandler _eventoHandler = new EventoHandler(new MockProAgilRepository());

        private CommandResult _result = new CommandResult();

        [TestMethod]
        public void DadoUmComandoValidoCriarEvento()
        {
            _result = (CommandResult)_eventoHandler.Handle(_validCreateCommand);

            Assert.AreEqual(_result.Success, true);
        }

        [TestMethod]
        public void DadoUmComandoInvalidoNaoCriarEvento()
        {
            _result = (CommandResult)_eventoHandler.Handle(_invalidCreateCommand);

            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void DadoUmComandoValidoAtualizarEvento()
        {
            _result = (CommandResult)_eventoHandler.Handle(_validUpdateCommand);

            Assert.AreEqual(_result.Success, true);
        }

        [TestMethod]
        public void DadoUmComandoInvalidoNaoAtualizarEvento()
        {
            _result = (CommandResult)_eventoHandler.Handle(_invalidCreateCommand);

            Assert.AreEqual(_result.Success, false);
        }

        [TestMethod]
        public void DadoUmComandoValidoDeletarEvento()
        {
            _result = (CommandResult)_eventoHandler.Handle(_validDeleteCommand);

            Assert.AreEqual(_result.Success, true);
        }

        [TestMethod]
        public void DadoUmComandoInvalidoNaoDeletarEvento()
        {
            _result = (CommandResult)_eventoHandler.Handle(_invalidDeleteCommand);

            Assert.AreEqual(_result.Success, false);
        }
    }
}