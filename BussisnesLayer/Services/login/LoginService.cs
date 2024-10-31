using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services;

public class LoginService
{
    private readonly AdministradorRepository _adminRepository;
    private readonly ClientRepository _clientRepository;
    private readonly AgentRepository _agentRepository;

    public LoginService()
    {
        _adminRepository = new AdministradorRepository();
        _clientRepository = new ClientRepository();
        _agentRepository = new AgentRepository();
    }
    
    
}