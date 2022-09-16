using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

namespace NBAAPP.Models
{
    public class PlayerModel
    {
        [JsonIgnore]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        [JsonProperty("last_name")]
        public string? LastName { get; set; }
        [JsonProperty("position")]
        public string? Position { get; set; }
        [JsonProperty("height_feet")]

        public int? HeightFeet{ get; set; }
        [JsonProperty("height_inches")]

        public int? HeightInches { get; set; }
        [JsonProperty("weight_pounds")]
        public int? WeightPounds{ get; set; }
        public TeamModel Team{ get; set; }
        [ForeignKey("TeamID")]
        public int TeamID { get; set; }


    }
}
