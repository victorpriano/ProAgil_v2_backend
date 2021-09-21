using Flunt.Notifications;
using ProAgil.Domain.Commands;
using ProAgil.Domain.Commands.Palestrante;
using ProAgil.Domain.Commands.Palestrantes;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Repositories;
using ProAgil.Shared.Commands;
using ProAgil.Shared.Handlers;

namespace ProAgil.Domain.Handlers
{
    public class PalestranteHandler : Notifiable<Notification>,
        IHandler<AddPalestranteCommand>,
        IHandler<UpdatePalestranteCommand>,
        IHandler<DeletePalestranteCommand>
    {
        private readonly IProAgilRepository _repository;
        public PalestranteHandler(IProAgilRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(AddPalestranteCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível criar um palestrante", command.Notifications);
            
            var palestrante = new Palestrante(command.Nome, command.MiniCurriculo, 
                command.ImagemUrl, command.Telefone, command.Email);
            
            _repository.Create(palestrante);

            return new CommandResult(true, "Palestrante criado com sucesso!", command.Notifications);
        }

        public ICommandResult Handle(UpdatePalestranteCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível alterar um palestrante", command.Notifications);
            
            var palestrante = _repository.GetAllPalestranteById(command.Id, command.Nome);

            _repository.Update(palestrante);

            return new CommandResult(true, "Palestrante alterado com sucesso!", command.Notifications);
        }

        public ICommandResult Handle(DeletePalestranteCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível deletar um palestrante", command.Notifications);

            var palestrante = _repository.GetPalestranteById(command.Id);

            _repository.Delete(palestrante);

            return new CommandResult(true, "Palestrante deletado com sucesso!", command.Notifications);
        }
    }
}