using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Ticket
{
    public Ticket()
    {
        Attachments = new HashSet<Attachment>();
    }
    public int TicketId { get; set; }
    
    public string Summary { get; set; }
    
    public string? Description { get; set; }
    
    public string Title { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? ClosedDate { get; set; }
    
    public DateTime? ResolvedDate { get; set; }
    
    public DateTime? DueDate { get; set; }
    
    public string AssigneeId { get; set; }
    
    [ForeignKey(nameof(AssigneeId))]
    public User Assignee { get; set; }
    
    public string CreatedBy { get; set; }
    
    [ForeignKey(nameof(CreatedBy))]
    public User? User { get; set; }
    
    public int CategoryId { get; set; }
    
    public Category Category { get; set; }
    
    public int ProductId { get; set; }
    
    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; }
    
    public int PriorityId { get; set; }
    
    [ForeignKey(nameof(PriorityId))]
    public Priority Priority { get; set; }
    
    public string Status { get; set; }
    
    
    public virtual ICollection<Discussion> Discussions { get; set; }
    public virtual ICollection<Attachment> Attachments { get; set; }
}