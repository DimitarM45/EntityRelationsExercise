namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Team
{
    public Team()
    {
        HomeGames = new HashSet<Game>();
        AwayGames = new HashSet<Game>();
        Players = new HashSet<Player>();
    }

    public int TeamId { get; set; }

    [Required]
    [MaxLength(50)]

    public string Name { get; set; }

    [MaxLength(2048)]

    public string LogoUrl { get; set; }

    [MaxLength(4)]

    public string Initials { get; set; }

    public decimal Budget { get; set; }

    public int PrimaryKitColorId { get; set; }

    public virtual Color PrimaryKitColor { get; set; }

    public int SecondaryKitColorId { get; set; }

    public virtual Color SecondaryKitColor { get; set; }

    public int TownId { get; set; }

    public virtual Town Town { get; set; }

    [InverseProperty(nameof(Game.HomeTeam))]

    public virtual ICollection<Game> HomeGames { get; set; }

    [InverseProperty(nameof(Game.AwayTeam))]

    public virtual ICollection<Game> AwayGames { get; set; }

    public virtual ICollection<Player> Players { get; set; }
}

