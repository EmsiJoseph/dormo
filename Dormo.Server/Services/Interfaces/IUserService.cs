using Dormo.Server.Data.DTOs;
using Dormo.Server.Data.Models;

namespace Dormo.Server.Services.Interfaces;

public interface IUserService : ICrudService<User, int, BaseFilter, UserDto, PaginatedDto<UserDto>>
{
}