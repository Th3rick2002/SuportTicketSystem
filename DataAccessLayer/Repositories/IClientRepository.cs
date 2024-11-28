using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface IClientRepository
{
    DataTable GetClients();
    void InsertClient(Client client);
    void UpdateClient(Client client);
    void DeleteClient(int id);
    Client GetByEmailandPassword(string email, string password);
}