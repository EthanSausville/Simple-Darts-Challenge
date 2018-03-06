using System;
using System.Collections.Generic;
using Dart;

namespace Simple_Darts_Challenge
{
    public class Game
    {


        // Initilizes a variable number of players
        public static string Play(int numberOfPlayers)
        {
            List<Darts> playersList = new List<Darts>();
            for (int i = 0; i < numberOfPlayers; i++)
                playersList.Add(new Darts());

            Darts[] players = playersList.ToArray();

            return Game.PlayGame(players);
        }


        // Plays the game and returns the result
        public static string PlayGame(params Darts[] players)
        {
            string _result = "";

            Game.PlayRounds(players);
            _result += Prints.PrintWinner(players) + "<br /><br />";
            _result += Prints.PrintPlayerScore(players);

            return _result;
        }
        

        // Plays the rounds
        public static void PlayRounds(params Darts[] players)
        {
            while (players[Game.HighestScore(players)].DartScore < 300)
                for (int i = 0; i < players.Length; i++)
                    players[i].DartScore += Score.PlayRound(players[i]);
        }


        // Determines the highest score at any given moment
        public static int HighestScore(params Darts[] players)
        {
            int j = 0;

            // Finds the index of the highest DartScore in an array of Darts
            for (int i = 0; i < (players.Length - 1); i++)
                if (players[i + 1].DartScore > players[i].DartScore)
                    j++;

            return j;
        }
    }
}