namespace NBAAPP.Models
{
    public class Stat
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int GameID { get; set; }
        public int Point { get; set; }
        public int DefensiveRebound { get; set; }
        public int OffensiveRebound { get; set; }
        public int Assist { get; set; }
        public int Block { get; set; }
        public int Turnover { get; set; }
        public int FieldGoalsAttempts { get; set; }
        public int FieldGoalsMade { get; set; }

        public int ThreePointerAttempts { get; set; }
        public int ThreePointerMade { get; set; }

        public int FreeThrowAttempts { get; set; }
        public int FreeThrowMade { get; set; }
        public double Minutes{ get; set; }
    }
}
