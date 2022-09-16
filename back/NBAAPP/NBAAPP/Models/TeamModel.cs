using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBAAPP.Models
{
    public class TeamModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [JsonIgnore]
        public int ID { get; set; }
        public string? Abbreviation { get; set; }
        public string? City { get; set; }
        public string? Conference { get; set; }
        public string? Division { get; set; }
        public string? FullName { get; set; }
        public string? TeamName { get; set; }
        public List<PlayerModel> Players{ get; set; }
    }
}
