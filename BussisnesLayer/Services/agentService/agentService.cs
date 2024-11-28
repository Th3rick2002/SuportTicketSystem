using System.Data;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;

namespace BussisnesLayer.Services.agentService;

public class agentService: IAgentService
{
    private readonly AgentRepository _agentRepository;

    public agentService()
    {
        _agentRepository = new AgentRepository();
    }
    
    public DataTable GetAllAgents()
    {
        return _agentRepository.GetAgents();
    }

    public void InsertAgent(Agent agent)
    {
        _agentRepository.InsertAgent(agent);
    }

    public void UpdateAgent(Agent agent)
    {
        _agentRepository.UpdateAgent(agent);
    }

    public void DeleteAgent(int id)
    {
        _agentRepository.DeleteAgent(id);
    }
}