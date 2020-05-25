using System;
using System.IO;

namespace Number5_9_
{
    public struct Match
    {
        public string team1;
        public int score1;
        public string team2;
        public int score2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree game = PlayMatch();
            game.PreOrderTraversal();
        }
        public static int Score()
        {
            Random random = new Random();
            return random.Next(0, 10);
        }
        public static BinaryTree PlayMatch()
        {
            BinaryTree Matches = new BinaryTree();
            var Final = Matches.AddRoot(new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var Semifinal1 = Matches.AddLeftSide(Final, new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var Semifinal2 = Matches.AddRightSide(Final, new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var Qarterfinal1 = Matches.AddLeftSide(Semifinal1, new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var Qarterfinal2 = Matches.AddRightSide(Semifinal1, new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var Qarterfinal3 = Matches.AddLeftSide(Semifinal2, new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var Qarterfinal4 = Matches.AddRightSide(Semifinal2, new Match() { team1 = "resultTeam", score1 = 0, team2 = "resultTeam", score2 = 0 });
            var match1 = Matches.AddLeftSide(Qarterfinal1, new Match() { team1 = "VUT", score1 = Score(), team2 = "COD", score2 = Score() });
            var match2 = Matches.AddRightSide(Qarterfinal1, new Match() { team1 = "BEL", score1 = Score(), team2 = "USA", score2 = Score() });
            var match3 = Matches.AddLeftSide(Qarterfinal2, new Match() { team1 = "NED", score1 = Score(), team2 = "ISL", score2 = Score() });
            var match4 = Matches.AddRightSide(Qarterfinal2, new Match() { team1 = "JOR", score1 = Score(), team2 = "NIG", score2 = Score() });
            var match5 = Matches.AddLeftSide(Qarterfinal3, new Match() { team1 = "ITA", score1 = Score(), team2 = "JPN", score2 = Score() });
            var match6 = Matches.AddRightSide(Qarterfinal3, new Match() { team1 = "LAO", score1 = Score(), team2 = "TZA", score2 = Score() });
            var match7 = Matches.AddLeftSide(Qarterfinal4, new Match() { team1 = "NER", score1 = Score(), team2 = "RUS", score2 = Score() });
            var match8 = Matches.AddRightSide(Qarterfinal4, new Match() { team1 = "POL", score1 = Score(), team2 = "UKR", score2 = Score() });
            Qarterfinal1.data = Winner(match1, match2);
            Qarterfinal2.data = Winner(match3, match4);
            Qarterfinal3.data = Winner(match5, match6);
            Qarterfinal4.data = Winner(match7, match8);
            Semifinal1.data = Winner(Qarterfinal1, Qarterfinal2);
            Semifinal2.data = Winner(Qarterfinal3, Qarterfinal4);
            Final.data = Winner(Semifinal1, Semifinal2);
            return Matches;
        }
        public static Match Winner(BinaryTreeNode Node1, BinaryTreeNode Node2)
        {
            Match winner;
            string Team1;
            string Team2;
            if (Node1.data.score1 > Node1.data.score2)
            {
                Team1 = Node1.data.team1;
            }
            else
            {
                Team1 = Node1.data.team2;
            }
            if (Node2.data.score1 > Node2.data.score2)
            {
                Team2 = Node2.data.team1;
            }
            else
            {
                Team2 = Node2.data.team2;
            }
            winner = new Match() { team1 = Team1, score1 = Score(), team2 = Team2, score2 = Score() };
            return winner;
        }
    }
}
