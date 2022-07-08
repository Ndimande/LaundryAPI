using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.Application.Requests.Dtos.Identity;

public class UserDto
{
    public string Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? Company { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    public string? UserName { get; set; }
    [MinLength(6)]
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsActive { get; set; } = false;
    public int CountryId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }

}
public class GetUserDto
{
    public string Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; }
    public string? UserName { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsActive { get; set; } = false;
    public int CountryId { get; set; }
    public int StateId { get; set; }
    public int CityId { get; set; }

}