using CommonLayer.Entities;

namespace BussisnesLayer.Services;

public interface ILoginService
{
    UserDTO Login(string username, string password);
}