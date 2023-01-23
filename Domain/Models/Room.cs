namespace Domain.Models;

public class Room
{
    public int RoomId { get; set; }

    public int RoomNumber { get; set; }

    public double Surface { get; set; }
    
    public bool NeedsRepair { get; set; }
}