namespace API.DTOs;

public class MemberDTO
{
    public int Id { get; set; }

    public string? Username { get; set; }

    //  AutoMapper conventions allow it to read the related method from the AppUser class and map it to this property
    public int Age { get; set; }

    public string? PhotoUrl { get; set; }
 
    public string? KnownAs { get; set; }

    public DateTime Created { get; set; }

    public DateTime LastActive { get; set; }

    public string? Gender { get; set; }

    public string? Interests { get; set; }

    public string? Introduction { get; set; }

    public string? LookingFor { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    // this is a navigation property
    // having a one to many relationship. One AppUser many Photos
    public List<PhotoDTO>? Photos { get; set; }

}

