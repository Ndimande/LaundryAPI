namespace CleanArchitecture.Domain.Entities;

public class Booking : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int? BusketSize { get; set; }
    public string? PickUpDate { get; set; }
    public string? NoOfBasket { get; set; }

    public string? EstimatedPrize { get; set; }

}
