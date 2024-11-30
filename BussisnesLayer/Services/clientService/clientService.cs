using System.Data;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services.userService;

public class clientService: IclientService
{
    private readonly ClientRepository _clientRepository;

    public clientService()
    {
        _clientRepository = new ClientRepository();
    }

    public DataTable GetAllClients()
    {
        return _clientRepository.GetClients();
    }

    public void InsertClient(Client client)
    {
        _clientRepository.InsertClient(client);
    }

    public void UpdateClient(Client client)
    {
        _clientRepository.UpdateClient(client);
    }

    public void DeleteClient(int id)
    {
        _clientRepository.DeleteClient(id);
    }

    public bool VerifyEmailExist(string email)
    {
        return _clientRepository.VerifyEmailExist(email);
    }
}