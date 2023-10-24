using System.ComponentModel.DataAnnotations;

namespace MyBGList.Models
{
    public class BoardGames_Mechanic
    {
        [Key]
        [Required]
        public int BoardGameId { get; set; }

        [Key]
        [Required]
        public int MechanicId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        //Navigation properties below
        public BoardGame? BoardGame { get; set; }
        
        public Mechanic? Mechanic { get; set; }
    }
}
