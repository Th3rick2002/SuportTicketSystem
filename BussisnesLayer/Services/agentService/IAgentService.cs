using System.Data;
using CommonLayer.Entities;

namespace BussisnesLayer.Services.agentService;

public interface IAgentService
{
    public DataTable GetAllAgents();
    public void InsertAgent(Agent agent);
    public void UpdateAgent(Agent agent);
    public void DeleteAgent(int id);
}