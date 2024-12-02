using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussisnesLayer.Services.administradorService
{
    internal interface IAdministradorService
    {
        public DataTable GetAllAdmins();
        public void AddAdministrador(administrador administrador);
        public void UpdateAdministrador(administrador administrador);
        public void DeleteAdministrador(int id);
        public administrador GetByEmailAndPassword(string email, string password);
        public bool VerifyEmailExist(string email);
    }
}
