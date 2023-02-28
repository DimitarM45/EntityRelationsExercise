namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Town
{
    public Town()
    {
        Teams = new HashSet<Team>();    
    }

    public int TownId { get; set; }

    [Required]
    [MaxLength(100)]

    public string Name { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; }

    public virtual ICollection<Team> Teams { get; set; }
}

