namespace CommonLayer.Entities;

public class Client
{
    public int IdClient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public string VerifyPassword { get; set; }
    public int idRol { get; set; }
}