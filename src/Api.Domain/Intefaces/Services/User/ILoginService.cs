using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Intefaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(UserEntity user);
    }
}
