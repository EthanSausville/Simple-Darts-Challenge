using System;
using System.Collections.Generic;
using System.Linq;
using Dart;

namespace Simple_Darts_Challenge
{
    public class Prints
    {


        // Print final player results
        public static string PrintPlayerScore(params Darts[] players)
        {
            string _result = "<div class=\"row text-light\">";
            
            // Creates the string to print with each player's score
            for (int i = 0; i < players.Length; i++)
                _result += string.Format(
                    "<div class=\"col-lg-4 col-md-6 col-12\" id=\"player{0:00}\"><span class=\"btn btn-small btn-primary mx-1\">" +
                    "Player {0:00}'s Score: </span><span class=\"btn btn-small btn-secondary font-weight-bold mx-1\"> " +
                    "{1} </span></div>", (i + 1), players[i].DartScore);
            return _result + "</div >";
        }


        // You can pass in an infinite amount of players
        public static string PrintWinner(params Darts[] players)
        {
            // Creates an array of the DartScores for each player
            List<int> _playerScores = new List<int>();
            for (int i = 0; i < players.Length; i++)
                _playerScores.Add(players[i].DartScore);

            // Determines and prints the winner
            int _winner = _playerScores.ToList().IndexOf(_playerScores.Max()) + 1;
            return "<div class=\"Jumbotron text-center\"><h1 class=\"display-4\">Player "
                + _winner.ToString() + " WINS!</h1></div>";

        }
    }
}