namespace Domain.Entities;

public class Priority
{
    public int PriorityId { get; set; }
    
    public string PriorityName { get; set; }
    
    public int ExpectedDuration { get; set; }
}