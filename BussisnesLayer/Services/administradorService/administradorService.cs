using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System.Data;

namespace BussisnesLayer.Services.administradorService
{
    internal class administradorService : IAdministradorService
    {
        private readonly AdministradorRepository _administradorRepository;

        public administradorService()
        {
            _administradorRepository = new AdministradorRepository();
        }
        public void AddAdministrador(administrador administrador)
        {
            _administradorRepository.AddAdministrador(administrador);
        }

        public void DeleteAdministrador(int id)
        {
            _administradorRepository.deleteAdministrador(id);
        }

        public DataTable GetAllAdmins()
        {
            return _administradorRepository.GetAdmins();
        }

        public administrador GetByEmailAndPassword(string email, string password)
        {
            return _administradorRepository.GetByEmailAndPassword(email, password);
        }

        public void UpdateAdministrador(administrador administrador)
        {
            _administradorRepository.UpdateAdministrador(administrador);
        }

        public bool VerifyEmailExist(string email)
        {
            return _administradorRepository.VerifyEmailExist(email);
        }
    }
}
