using Flunt.Notifications;
using ProAgil.Domain.Commands;
using ProAgil.Domain.Commands.RedeSociais;
using ProAgil.Domain.Commands.RedeSocial;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Repositories;
using ProAgil.Shared.Commands;
using ProAgil.Shared.Handlers;

namespace ProAgil.Domain.Handlers
{
    public class RedeSocialHandler : Notifiable<Notification>,
        IHandler<AddRedeSocialCommand>,
        IHandler<UpdateRedeSocialCommand>,
        IHandler<DeleteRedeSocialCommand>
    {
        private readonly IProAgilRepository _repository;
        public RedeSocialHandler(IProAgilRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(AddRedeSocialCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível adicionar a Rede Social", command.Notifications);
            
            var redeSocial = new RedeSocial(command.Nome, command.Url);

            _repository.Create(redeSocial);

            return new CommandResult(true, "Rede Social adicionada com sucesso!", command.Notifications);
        }

        public ICommandResult Handle(UpdateRedeSocialCommand command)
        {
            command.Validate();
            
            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível alterar a Rede Social", command.Notifications);
            
            var redeSocial = _repository.GetAllRedeSocialById(command.Id, command.Nome);

            _repository.Update(redeSocial);

            return new CommandResult(true, "Rede Social alterada com sucesso!", command.Notifications);
        }

        public ICommandResult Handle(DeleteRedeSocialCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Não foi possível deletar a Rede Social", command.Notifications);

            var redeSocial = _repository.GetRedeSocialById(command.Id);

            _repository.Delete(redeSocial);

            return new CommandResult(true, "Rede Social deletada com sucesso!", command.Notifications);
        }
    }
}