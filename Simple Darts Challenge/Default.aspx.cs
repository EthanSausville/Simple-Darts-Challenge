using System;
using Dart;

namespace Simple_Darts_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = Game.Play(int.Parse(numberOfPlayersTextBox.Text));
        }
    }
}