using System.Data;
using CommonLayer.Entities;

namespace BussisnesLayer.Services.userService;

public interface IclientService
{
    public DataTable GetAllClients();
    public void InsertClient(Client client);
    public void UpdateClient(Client client);
    public void DeleteClient(int id);
}