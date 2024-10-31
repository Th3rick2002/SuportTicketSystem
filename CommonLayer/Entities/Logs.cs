namespace CommonLayer.Entities;

public class Logs
{
    public int Id { get; set; }
    public int TicketId { get; set; }
    public int ClienteId { get; set; }
    public int AgentId { get; set; }
    public DateTime Date { get; set; }
    public string Details { get; set; }
}