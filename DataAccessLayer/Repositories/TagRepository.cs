using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using System.Data.SqlClient;

namespace DataAccessLayer.Repositories;

public class TagRepository
{
    private SqlDataAccess _dbConnection;

    public TagRepository()
    {
        _dbConnection = new SqlDataAccess();
    }

    //metodo para traer todas las etiquetas en forma de lista
    public List<Tag> GetAllTags()
    {
        List<Tag> tags = new List<Tag>();

        using (var connection = _dbConnection.GetConnection())
        {
            string query = "SELECT NameTag FROM Tags";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Tag tag = new Tag()
                    {
                        NameTag = reader.GetString(0)
                    };
                    tags.Add(tag);
                }
            }
        }

        return tags;
    }

    //metodo para agregar etiquetas
    public void addTag(Tag tag)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "INSERT INTO Tags (NameTag) VALUES (@TagName)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TagName", tag.NameTag);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    public void UpdateTags(Tag tag)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Tags SET TagName = @TagName WHERE NameTag = @NameTag";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NameTag", tag.NameTag);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    public void DeleteTags(int id)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "DELETE FROM Tags WHERE TagId = @TagId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TagId", id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}