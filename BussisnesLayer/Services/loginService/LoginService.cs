using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services;

public class LoginService : ILoginService
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

    public UserDTO Login(string username, string password)
    {
        var admin = _adminRepository.GetByEmailAndPassword(username, password);
        if (admin != null)
        {
            if (admin.idRol == 1)
            {
                return new UserDTO
                {
                    Id = admin.Id,
                    Role = "SuperAdministador",
                    Username = $"{admin.FirstName} {admin.LastName}"
                };
            }else
            {
                return new UserDTO
                {
                    Id = admin.Id,
                    Role = "Administrador",
                    Username = $"{admin.FirstName} {admin.LastName}"
                };
            }
        }
        
        var agent = _agentRepository.GetAgentByEmailAndPassword(username, password);
        if (agent != null)
        {
            return new UserDTO()
            {
                Id = agent.IdAgent,
                Role = "Agente",
                Username = $"{agent.FirstName} {agent.LastName}"
            };
        }
        
        var client = _clientRepository.GetByEmailandPassword(username, password);
        if (client != null)
        {
            return new UserDTO()
            {
                Id = client.IdClient,
                Role = "Cliente",
                Username = $"{client.FirstName} {client.LastName}"
            };
        }
        
        return null;
    }
}