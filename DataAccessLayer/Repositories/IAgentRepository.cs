using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface IAgentRepository
{
    DataTable GetAgents();
    void InsertAgent(Agent agent);
    void UpdateAgent(Agent agent);
    void DeleteAgent(int id);
    Agent GetAgentByEmailAndPassword(string email, string password);
}