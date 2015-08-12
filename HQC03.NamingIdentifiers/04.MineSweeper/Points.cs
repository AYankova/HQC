namespace MineSweeper
{
    public class Points
    {
        private string playerName;
        private int playerPoints;

        public Points(string playerName, int playerPoints)
        {
            this.PlayerName = playerName;
            this.PlayerPoints = playerPoints;
        }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            private set
            {
                this.playerName = value;
            }
        }

        public int PlayerPoints
        {
            get
            {
                return this.playerPoints;
            }

            private set
            {
                this.playerPoints = value;
            }
        }
    }
}