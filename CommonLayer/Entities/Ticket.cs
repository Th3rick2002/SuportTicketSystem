namespace CommonLayer.Entities;

public class Ticket
{
    public int IdTicket { get; set; }
    public string NameTicket { get; set; }
    public string DescriptionTicket { get; set; }
    public string Priority { get; set; } 
    public string Status { get; set; } 
    public int IdClient { get; set; }
    public int? IdAgent { get; set; }  // null
}
