using Application.DTO;

namespace Application.UseCases.Queries.User;

public interface IGetUsersQuery : IQuery<PagedResp<UserDto>, UserSearch>
{
}