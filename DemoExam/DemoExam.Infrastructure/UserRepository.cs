using DemoExam.Domain.Extensions;
using DemoExam.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DemoExam.Infrastructure;

internal partial class UserRepository(TradeContext tradeContext) : IUserRepository
{
    public Task<User?> GetUser(string login, string password)
    {
        return tradeContext.Users
            .Include(x => x.UserRoleNavigation)
            .FirstOrDefaultAsync(x => x.Login == login && x.Password == password.ComputeHash());
    }

    public Task<User?> GetUser(string login)
    {
        return tradeContext.Users
            .Include(x => x.UserRoleNavigation)
            .FirstOrDefaultAsync(x => x.Login == login);
    }

    public async Task CreateUser(string login, string password, string userName, string userSurname, string userPatronymic)
    {
        var clientRoleId = await tradeContext.Roles.FirstAsync(x => x.Name == Role.ClientRoleName).ConfigureAwait(false);
        await tradeContext.Users.AddAsync(new User()
        {
            Login = login,
            Password = password.ComputeHash(),
            Name = userName,
            Surname = userSurname,
            Patronymic = userPatronymic,
            RoleId = clientRoleId.Id
        })
            .ConfigureAwait(false);
        await tradeContext.SaveChangesAsync().ConfigureAwait(false);
    }
}