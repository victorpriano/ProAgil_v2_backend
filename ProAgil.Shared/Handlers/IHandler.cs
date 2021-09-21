using ProAgil.Shared.Commands;

namespace ProAgil.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand 
    {
         ICommandResult Handle(T command);
    }
}