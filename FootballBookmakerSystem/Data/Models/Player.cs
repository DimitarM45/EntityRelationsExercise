namespace P02_FootballBetting.Data.Models;

using System.ComponentModel.DataAnnotations;

public class Player
{
    public Player()
    {
        PlayersStatistics = new HashSet<PlayerStatistic>();    
    }

    public int PlayerId { get; set; }

    [Required]
    [MaxLength(100)]

    public string Name { get; set; }

    public int SquadNumber { get; set; }

    public bool IsInjured { get; set; }

    public int TeamId { get; set; }

    public virtual Team Team { get; set; }

    public int PositionId { get; set; }

    public virtual Position Position { get; set; }

    public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }
}
