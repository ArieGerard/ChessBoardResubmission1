/* CST-250
 * 01/31/2025 
 * ChessGameConsoleApp
 * Reference
 * In class activity
 */
using System.Runtime.CompilerServices;
using ChessBoardClassLibrary.Moedls;
using ChessBoardClassLibrary.Services.BusinessLogicLayer;

// ------------------------------------------
// Start of Main Method
//-------------------------------------------
// Declear and initialize
string piece = " ";
Tuple<int, int>? result = null;
// Create an instance of our Business layer
BoardLogic boardLogic = new BoardLogic();
// Welcome the user

Console.WriteLine("Welcome, Our Chess Players!");

// Create a new chess board
BoardMoedl board = new BoardMoedl(8);
//Show the empty chess board
Healper.PrintBoard(board);
// Prompt the user for the type of chess piece
Console.Write("Enter the type of piece you want to place (knight, Rook, Bishop, queen, king): ");
piece = Console.ReadLine();
// prompt the user for the location of the chess piece
result = Healper.GetRowAndCol();
// Mark the legal move based on the input
board = boardLogic.MarkLegalMoves(board, board.Grid[result.Item1, result.Item2], piece);
// Print the new chess board
Healper.PrintBoard(board);



//----------------------------------------------
// End of Main Method
//---------------------------------------------



//---------------------------------------------
// Define Utility Class

class Healper
{
    /// <summary>
    /// Print the given board to the console
    /// </summary>
    /// <param name="board"></param>
    public static void PrintBoard(BoardMoedl board)
    {
        // Loop over the rows of the board
        for (int row = 0; row < board.Size; row++)
        {
            for (int col = 0; col < board.Size; col++)
            {
                // get the current cell from the grid
                CellModel cell = board.Grid[row, col];
                // Check if the current cell is a legal move
                if (cell.IsLegalNextMove)
                {
                    // Print a + sign for a legal move
                    Console.Write(" + ");
                }
                // Check if there is a piece on there or not
                else if (cell.PieceOccupyingCell != "")
                {
                    // Print chess piece letter
                    Console.Write($" {cell.PieceOccupyingCell} ");
                }
                else
                {
                    // Print a . for anything else
                    Console.Write(" . ");
                }
            }
            //Start a new line after every row
            Console.WriteLine();
        } // end of outter for loop
    } // end of PrintBoard method

    public static Tuple<int, int> GetRowAndCol()
    {
        // Declear initialize
        int rwo = -1, col = -1;

        Console.Write("Enter the row number of the piece: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter the col number of the piece: ");
        col = int.Parse(Console.ReadLine());

        return Tuple.Create(row, col);
    }
}