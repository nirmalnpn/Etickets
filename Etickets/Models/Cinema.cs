using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eticket.Models;

public class Cinema
{
    [Key]
    public int CinemaID { get; set; }
    
    [Display(Name = "Cinema Logo")]
    public string Logo { get; set; }
    
    [Display(Name = "Cinema Name")]
    public string Name { get; set; }
    
    [Display(Name = "Cinema Description")]
    public string Description { get; set; }
    
    
    //relationships
     // public List<Movie> Movies { get; set; }
}