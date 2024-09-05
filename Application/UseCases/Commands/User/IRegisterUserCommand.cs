using Application.DTO;

namespace Application.UseCases.Commands.User;

public interface IRegisterUserCommand : ICommand<UserDto>
{
}