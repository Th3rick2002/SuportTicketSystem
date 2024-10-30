namespace CommonLayer.Entities;

public class Agent
{
    public int IdAgent { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public bool availability { get; set; }
    public int idRol { get; set; }
}