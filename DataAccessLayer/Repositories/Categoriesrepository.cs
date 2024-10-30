using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

namespace DataAccessLayer.Repositories;

public class Categoriesrepository
{
    private SqlDataAccess _dbConnection;

    public Categoriesrepository()
    {
        _dbConnection = new SqlDataAccess();
    }
    
    //metodo para traer todas las categorias en forma de lista
    public List<Categories> GetAllCategories()
    {
        List<Categories> cartegories = new List<Categories>();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT NameCategorie FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cartegories.add(reader.GetString(0));
                }
            }
        }

        return tags;
    }

    public void AddCategory(Categories category)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "INSERT INTO Categories (NameCategorie) VALUES (@Name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWitchValues("@Name", category.NameCategorie);
            connection.Open();
                 
            commmand.ExecuteNonQuery();
        }
    }

    public void UpdateCategory(Categories category)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Categories SET NameCategorie = @Name WHERE Id=@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWitchValues("@Name", category.NameCategorie);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    public void DeleteCategory(Categories category)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "DELETE FROM Categories WHERE Id=@Id";
            SqlCommand command = new SqlCommand(query, connection);
            commmand.Parameters.AddWitchValues("@Id", category.Id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}