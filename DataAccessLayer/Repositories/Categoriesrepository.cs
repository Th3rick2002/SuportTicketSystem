using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositories;

public class Categoriesrepository : ICategoriesrepository
{
    private ISqlDataAccess _dbConnection;

    public Categoriesrepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //metodo para traer todas las categorias en forma de lista
    public List<Categories> GetAllCategories()
    {
        List<Categories> categories = new List<Categories>();

        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "SELECT Id, NameCategorie FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Categories category = new Categories
                    {
                        Id = reader.GetInt32(0),
                        NameCategorie = reader.GetString(1)
                    };
                    categories.Add(category);
                }
            }
        }

        return categories;
    }

    public void AddCategory(Categories category)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "INSERT INTO Categories (NameCategorie) VALUES (@Name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", category.NameCategorie);
            connection.Open();
                 
            command.ExecuteNonQuery();
        }
    }

    public void UpdateCategory(Categories category)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "UPDATE Categories SET NameCategorie = @Name WHERE Id=@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", category.NameCategorie);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    public void DeleteCategory(Categories category)
    {
        using (var connection = (SqlConnection)_dbConnection.GetConnection())
        {
            string query = "DELETE FROM Categories WHERE Id=@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", category.Id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}