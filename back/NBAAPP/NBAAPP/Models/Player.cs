namespace NBAAPP.Models
{
    public class Player
    {
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Position Position { get; set; }
        public int ID { get; set; }
        public int? Height{ get; set; }
        public int? Weight{ get; set; }
        public int TeamID{ get; set; }


    }
}
