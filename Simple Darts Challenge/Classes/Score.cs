using System;
using Dart;

namespace Simple_Darts_Challenge
{
    public class Score
    {


        // Determine points for a round
        // A player gets 3 throws in a round
        public static int PlayRound(Darts player)
        {
            int _roundScore = 0;
            for (int i = 0; i < 3; i++)
            {
                player.Throw();
                _roundScore += Score.RoundScore(player, player.DartScore);
            }
            return _roundScore;
        }


        // Determine points for a throw
        public static int RoundScore(Darts player, int score)
        {
            if (player.DartPosition == "Inner Bulls-Eye")
                score = 50;
            else if (player.DartPosition == "Outer Bulls-Eye")
                score = 25;
            else if (player.DartPosition == "Outer Ring")
                score *= 2;
            else if (player.DartPosition == "Inner Ring")
                score *= 3;
            return score;
        }
    }
}