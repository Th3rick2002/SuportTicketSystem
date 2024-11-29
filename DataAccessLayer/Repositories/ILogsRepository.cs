using System.Data;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories;

public interface ILogsRepository
{
    DataTable GetAllLogs();
}