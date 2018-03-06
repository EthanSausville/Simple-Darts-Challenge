using System;

namespace Dart
{
    public class Darts
    {
        // Set random number, for use in the Throw() method
        private static Random randomNum = new Random();


        // Set properties of Darts
        public int DartScore { get; set; }
        public string DartPosition { get; set; }


        // Define constructor method
        public Darts()
        {
            this.DartScore = 0;
            this.DartPosition = "";
        }


        // Method returns a random result of a simulated Dart throw
        public void Throw()
        {
            DartScore = randomNum.Next(0,21);

            // If Bulls-eye, check what type of Bulls-eye
            if (DartScore == 0)
            {
                if (randomNum.Next(1, 101) <= 5) DartPosition = "Inner Bulls-Eye";
                else DartPosition = "Outer Bulls-Eye";
            }
            // If not a Bulls-eye check to see if the rings were hit
            else
            {
                if (randomNum.Next(1, 101) <= 5) DartPosition = "Outer Ring";
                else if (randomNum.Next(1, 101) <= 10) DartPosition = "Inner Ring";
                else DartPosition = "Normal";
            }
        }
    }
}
