using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totito
{
    internal class TotitO
    {
        static char[,] board = new char[3, 3]; // Tablero 3x3
        static char currentPlayer = 'X'; // Jugador actual (X o O)

        static void Main(string[] args)
        {
            InitializeBoard();
            PrintBoard();

            while (true)
            {
                Console.WriteLine($"Turno del Jugador {currentPlayer}");
                Console.Write("Ingrese la fila (0-2): ");
                int row = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la columna (0-2): ");
                int col = int.Parse(Console.ReadLine());

                if (IsValidMove(row, col))
                {
                    board[row, col] = currentPlayer;
                    PrintBoard();

                    if (CheckWin())
                    {
                        Console.WriteLine($"¡Jugador {currentPlayer} gana!");
                        break;
                    }
                    else if (CheckDraw())
                    {
                        Console.WriteLine("¡Empate!");
                        break;
                    }

                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X'; // Aca caombiamos de jugador
                }
                else
                {
                    Console.WriteLine("Movimiento inválido. Intente nuevamente.");
                }
            }
        }

        static void InitializeBoard()
        {
            // Inicio de tablas en blanco
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
        }

        static void PrintBoard()
        {
            // Impresion del tablero en la consola
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValidMove(int row, int col)
        {
            // Ver si la casilla está vacía y dentro de los límites del tablero
            return row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ';
        }

        static bool CheckWin()
        {
            // Ver si hay una línea horizontal, vertical o diagonal del mismo jugador
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != ' ' && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                    return true;
                if (board[0, i] != ' ' && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    return true;
            }
            if (board[0, 0] != ' ' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return true;
            if (board[0, 2] != ' ' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return true;

            return false;
        }

        static bool CheckDraw()
        {
            //  si no hay más movimientos posibles abra un (empate)
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }
    }
}
