using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System;

namespace CA.Application.Requests.Dtos;

public class BasketDto
{
    public int Id { get; set; }
    public int Size { get; set; }
    public string ImageUrl { get; set; }
    public string EstimatedPrize { get; set; }

}
