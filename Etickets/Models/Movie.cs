using System.ComponentModel.DataAnnotations.Schema;
using Eticket.Data;

namespace Eticket.Models;

public class Movie
{
    [Key]
    public int MovieID { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public MovieCategory MovieCategory { get; set; }
    
    public string ImageURL { get; set; }
    
    
    //relationships
    public List<Actor_Movie> Actors_Movies { get; set; }
    
    
    //Cinema
    public int CinemaId { get; set; }
    [ForeignKey("CinemaId")]
    public Cinema Cinema { get; set; }
    
    //Producer
    public int ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Cinema Producer { get; set; }
}