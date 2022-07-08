using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;

public class Basket
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public int? Size { get; set; }
    public string? EstimatedPrize { get; set; }
}
