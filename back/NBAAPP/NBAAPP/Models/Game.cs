namespace NBAAPP.Models
{
    public class Game
    {
        public int ID { get; set; }
        public DateTime Date{ get; set; }
        public int HomeTeamID{ get; set; }
        public int AwayTeamID { get; set; }

        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public bool IsPostseason{ get; set; }
    }
}
