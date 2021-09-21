using Flunt.Notifications;
using ProAgil.Domain.Commands;
using ProAgil.Domain.Commands.Lote;
using ProAgil.Domain.Commands.Lotes;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Repositories;
using ProAgil.Shared.Commands;
using ProAgil.Shared.Handlers;

namespace ProAgil.Domain.Handlers
{
    public class LoteHandler : Notifiable<Notification>,
        IHandler<AddLoteCommand>,
        IHandler<UpdateLoteCommand>,
        IHandler<DeleteLoteCommand>
    {
        private readonly IProAgilRepository _repository;
        public LoteHandler(IProAgilRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(AddLoteCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Por favor insira um lote", command.Notifications);
            
            var lote = new Lote(command.Nome, command.Preco, command.DataInicio, command.DataFim, command.Quantidade);

            _repository.Create(lote);

            return new CommandResult(true, "Lote criado com sucesso!", lote);
        }

        public ICommandResult Handle(UpdateLoteCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possivel realizar as atualizações", command.Notifications);
            
            var lote = _repository.GetAllLoteById(command.Id, command.Nome);

            _repository.Update(lote);

            return new CommandResult(true, "Lote alterado com sucesso!", command.Notifications);
        }

        public ICommandResult Handle(DeleteLoteCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível deletar o lote", command.Notifications);

            var lote = _repository.GetLoteById(command.Id);

            _repository.Delete(lote);

            return new CommandResult(true, "Lote apagado com sucesso!", command.Notifications);
        }
    }
}