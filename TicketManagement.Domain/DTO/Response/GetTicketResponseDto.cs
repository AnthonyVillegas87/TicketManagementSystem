namespace Domain.Interfaces;

public class GetTicketResponseDto
{
    public int TicketId { get; set; }

    public string TicketIdView
    {
        get
        {
            return "TKT-" + TicketId.ToString().PadLeft(4, '0');
        }
    }
    
    public string Summary { get; set; }
    
    public string Description{ get; set; }
    
    public int ProductId { get; set; }
    public string Product { get; set; }
    
    public int CategoryId { get; set; }
    public string Category { get; set; }
    
    public int PriorityId { get; set; }
    public string Priority { get; set; }
    
    public string Status { get; set; }
    
    public string CreatedBy { get; set; }
    
    public DateTime CreatedDate { get; set; }
    public DateTime? DueDate { get; set; }
}