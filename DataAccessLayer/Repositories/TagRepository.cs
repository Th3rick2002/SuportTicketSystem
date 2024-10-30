using CommonLayer.Entities;
using DataAccessLayer.DbConnection;

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
                    tags.add(reader.GetString(0));
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
            command.Parameters.AddWhitchValues("@TagName", tag.NameTag);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }

    public void UpdateTags(Tag tag)
    {
        using (var connection = _dbConnection.GetConnection())
        {
            string query = "UPDATE Tags SET TagName = @TagName WHERE NameTag = @NameTag";
            Sqlcommand command = new Sqlcommand(query, connection);
            command.Parameters.AddWhitchValues("@NameTag", tag.NameTag);
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
            command.Parameters.AddWhitchValues("@TagId", id);
            connection.Open();
            
            command.ExecuteNonQuery();
        }
    }
}