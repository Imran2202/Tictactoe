//Written by Imran Ali
//6/4/2022


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n   Player 1 - X           Player 2 - O \n");
            Console.WriteLine("   Let the games begin: Player 1 starts\n\n");

            Tictactoe board1 = new Tictactoe();
            board1.Game();

        }
    }   

}

public class Tictactoe
{
    Player current;
    int turn = 0;
    char[] board = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }  ;
    public void Board()
    {
        Console.WriteLine("        |     |      ");
        Console.WriteLine("     {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
        Console.WriteLine("   _____|_____|_____ ");
        Console.WriteLine("        |     |      ");
        Console.WriteLine("     {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
        Console.WriteLine("   _____|_____|_____ ");
        Console.WriteLine("        |     |      ");
        Console.WriteLine("     {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
        Console.WriteLine("        |     |      ");
    }

    public void Game()
    {
        
        int input;
        while (turn < 9)
        {
            Board();
            if (turn % 2 == 0)
                current = Player.Player1;
            else
                current = Player.Player2;
            Console.WriteLine("It is {0}'s turn ({1}), where do you want to play: ", current, (char)current) ;
            input = Convert.ToInt32(Console.ReadLine());
            board[input-1] = (char)current;
            

            if (Check() == 1)
            {
                Console.WriteLine("{0} Won!",current);
                break;
            }
            else if(Check() == 2)
                Console.WriteLine("It's a Draw");

            turn += 1;
        }
            
    }
    public int Check()
    {
        if (board[0] == board[1] && board[1] == board[2]) return 1;
        if (board[3] == board[4] && board[4] == board[5]) return 1;
        if (board[6] == board[7] && board[7] == board[8]) return 1;

        if (board[0] == board[3] && board[3] == board[6]) return 1;
        if (board[1] == board[4] && board[4] == board[7]) return 1;
        if (board[2] == board[5] && board[5] == board[8]) return 1;

        if (board[0] == board[4] && board[4] == board[8]) return 1;
        if (board[6] == board[4] && board[4] == board[2]) return 1;

        //Draw
        else if (turn == 8) return 2;

        else
            return 0;

    }
}
enum Player { Player1 = 'X', Player2 = 'O'}





