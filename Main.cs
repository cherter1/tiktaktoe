// See https://aka.ms/new-console-template for more information

using ticktacktoe;
const int SinglePlayer = 1;
const int MultiPlayer = 2;

StartMenu menu = new StartMenu();
menu.AskInstructions();

do
{
    if (menu.GetMode() == SinglePlayer)
    {
        Player player = new Player();

        while (!player.GameOver)
        {
            Console.Write("Player One Take Your turn: ");
            player.TakeTurn('X');
            player.PrintBoard();
            player.CheckForp1Win();
            player.CheckForp2Win();
            player.CheckForTie();
            if (player.GameOver)
            {
                break;
            }
            Console.WriteLine("AI's turn: ");
            player.AiTakeTurn('O');
            player.PrintBoard();
            player.CheckForp1Win();
            player.CheckForp2Win();
            player.CheckForTie();
        }
        menu.Replay();
    }
    if (menu.GetMode() == MultiPlayer)
    {
        Player player = new Player();

        while (!player.GameOver)
        {
            Console.Write("Player One Take Your turn: ");
            player.TakeTurn('X');
            player.PrintBoard();
            player.CheckForp1Win();
            player.CheckForp2Win();
            player.CheckForTie();
            if (player.GameOver)
            {
                break;
            }
            Console.WriteLine("Player Two Take Your turn");
            player.TakeTurn('O');
            player.PrintBoard();
            player.CheckForp1Win();
            player.CheckForp2Win();
            player.CheckForTie();
        }
        menu.Replay();
    }
}
while (menu.playAgain);