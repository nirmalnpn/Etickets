namespace Eticket.Models;

public class Producer
{
    [Key]
    public int ProducerID { get; set; }
    
    [Display(Name = "Profile Picture")]
    public string ProfilePictureURL { get; set; }
    
    [Display(Name = "First Name")]
    public string FullName { get; set; }
    
    [Display(Name = "Bio")]
    public string Bio { get; set; }
    
    //relationships
    public List<Movie> Movies { get; set; }
}