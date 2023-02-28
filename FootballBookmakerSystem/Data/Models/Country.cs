namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Country
{
    public Country()
    {
        Towns = new HashSet<Town>();    
    }

    public int CountryId { get; set; }

    [Required]
    [MaxLength(100)]

    public string Name { get; set; }

    public virtual ICollection<Town> Towns { get; set; }
}

