using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using API.Extensions;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }

    // UserName should never be null, so we add the required modifier
    public required string UserName { get; set; }

    public byte[] PasswordHash { get; set; } = [];

    // the Salt scrambles the Hash for increased security
    public byte[] PasswordSalt { get; set; } = [];

    public DateOnly DateofBirth { get; set; }

    public required string KnownAs { get; set; }

    public DateTime Created { get; set; } = DateTime.UtcNow;

    public DateTime LastActive { get; set; } = DateTime.UtcNow;

    public required string Gender { get; set; }

    public string? Interests { get; set; }

    public string? Introduction { get; set; }

    public string? LookingFor { get; set; }

    public required string City { get; set; }

    public required string Country { get; set; }

    // this is a navigation property
    // having a one to many relationship. One AppUser many Photos
    public List<Photo> Photos { get; set; }

    public int GetAge()
    {
        return DateofBirth.CalculateAge();
    }



}
