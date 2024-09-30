namespace Etickets.Models;

public class Actor
{
    [Key]
    public int ActorId { get; set; }

    [Display(Name = "Profile Picture URL")]
    public string ProfilePictureURL { get; set; }

    [Display(Name = "Full Name")]
    public string FullName { get; set; }

    [Display(Name = "Bio")]
    public string Bio { get; set; }

    // Relationships
    public List<Actor_Movie> Actors_Movies { get; set; } = new List<Actor_Movie>(); // Initialize the list
}