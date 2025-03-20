/*
*Arie Gerard 
*Activity 2
*Bill Hughes
*02/09/2025
*
 */
using System.Runtime.CompilerServices;
using ChessBoardClassLibrary.ModelsLibrary;
using ChessBoardClassLibrary.Services.BusinessLogicLayer;
//set the inital peice to an empty string.
string piece = " ";
//set the touple logic to false
Tuple<int, int>? result = null;
//instantiate new board logic. 
BoardLogic boardLogic = new BoardLogic();

Console.WriteLine("Welcome, Our Chess Players!");
//instantaiates a new board to the size 8. 
BoardModel board = new BoardModel(8);
Helper.PrintBoard(board);

Console.Write("Enter the type of piece you want to place (knight, rook, bishop, queen, king): ");
piece = Console.ReadLine();
//uses the helper class to get the row and column from the user. 
result = Helper.GetRowAndCol();
//uses the boardLogic class to mark the legal moces for any given peice. 
board = boardLogic.MarkLegalMoves(board, board.Grid[result.Item1, result.Item2], piece);
Helper.PrintBoard(board);

//helper class for the program. 
class Helper
{
    public static void PrintBoard(BoardModel board)
    {
        for (int row = 0; row < board.Size; row++)
        {
            for (int col = 0; col < board.Size; col++)
            {
                CellModel cell = board.Grid[row, col];

                if (cell.IsLegalNextMove)
                {
                    Console.Write(" + ");
                }
                else if (cell.PieceOccupyingCell != "")
                {
                    Console.Write($" {cell.PieceOccupyingCell} ");
                }
                else
                {
                    Console.Write(" . ");
                }
            }
            Console.WriteLine(); // Add a newline after each row
        }
    }

    public static Tuple<int, int> GetRowAndCol()
    {
        Console.Write("Enter the row number of the piece: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter the column number of the piece: ");
        int col = int.Parse(Console.ReadLine());

        return Tuple.Create(row, col);
    }
}
