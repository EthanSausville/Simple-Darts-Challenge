<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Simple_Darts_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
		<!-- Required meta tags -->
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

		<!-- CSS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"/>
        <link rel="stylesheet" href="Style.css" />

		<title>Play Darts</title>
	</head>
<body>
    <form id="form1" runat="server" class="container-fluid bg-info m-0">
        <div>
            <div class="container bg-white text-dark">
                <div class="jumbotron">
                    <h1 class="display-4">Play a game of Darts</h1>
                    <p class="lead">You get 3 tosses on a round, all players get an equal number of rounds. The game ends when at least
                        one player reaches 300 points. Then the player with the most points wins</p>
                    <hr class="my-4">
                    <p>How Many Players? <asp:TextBox ID="numberOfPlayersTextBox" runat="server" MaxLength="2">2</asp:TextBox></p>
                    <div><asp:Button class="btn btn-danger my-3 btn-lg" ID="playButton" runat="server" OnClick="playButton_Click" Text="Play!" /></div>
                    <div class="pt-4 mt-4"> </div>
                    <asp:Label ID="resultLabel" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
