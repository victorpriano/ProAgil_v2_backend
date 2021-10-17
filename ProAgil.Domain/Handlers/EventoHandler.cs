using Flunt.Notifications;
using ProAgil.Domain.Commands;
using ProAgil.Domain.Commands.Evento;
using ProAgil.Domain.Commands.Eventos;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Repositories;
using ProAgil.Shared.Commands;
using ProAgil.Shared.Handlers;

namespace ProAgil.Domain.Handlers
{
    public class EventoHandler : Notifiable<Notification>,
        IHandler<AddEventoCommand>,
        IHandler<UpdateEventoCommand>,
        IHandler<DeleteEventoCommand>
    {
        private readonly IProAgilRepository _repository;

        public EventoHandler(IProAgilRepository repository)
        {
            _repository = repository;
        }
        
        public ICommandResult Handle(AddEventoCommand command)
        {
            command.Validate();
            
            if(!command.IsValid)
                return new CommandResult(false, "Há algo de errado no seu evento!", command.Notifications);
            
            var evento = new Evento(command.Local, command.DataEvento, command.Tema, 
                command.QtdPessoas, command.ImagemUrl, command.Telefone, command.Email);
            
            _repository.Create(evento);

            return new CommandResult(true, "Evento criado com sucesso!", evento);
        }

        public ICommandResult Handle(UpdateEventoCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Há algo de errado no seu evento!", command.Notifications);
            
            var evento = _repository.GetAllEventosById(command.Id, command.Tema);

            _repository.Update(evento);

            return new CommandResult(true, "Evento alterado com sucesso!", evento);
        }

        public ICommandResult Handle(DeleteEventoCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new CommandResult(false, "Há algo de errado no seu evento!", command.Notifications);
            
            var evento = _repository.GetEventoId(command.Id);

            _repository.Delete(evento);

            return new CommandResult(true, "Evento apagado com sucesso!", evento);
        }
    }
}