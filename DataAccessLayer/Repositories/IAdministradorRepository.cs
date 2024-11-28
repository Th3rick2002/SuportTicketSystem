using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface IAdministradorRepository
{
    DataTable GetAdmins();
    void AddAdministrador(administrador administrador);
    void UpdateAdministrador(administrador administrador);
    
    void deleteAdministrador(int id);
    administrador GetByEmailAndPassword(string email, string password);
}