using System;

namespace CA.Application.Requests.Dtos;

public class BookingDto
{
    public int Id { get; set; }
    public int SignUpId { get; set; }
    public string NoOfBasket { get; set; }
    public string PickUpTime { get; set; }
    public string PickUpDate { get; set; }
    public int BusketSize { get; set; }
    public string Prize { get; set; }
}
