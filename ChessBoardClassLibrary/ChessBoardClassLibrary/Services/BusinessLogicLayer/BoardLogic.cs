/*
 * Pang Ruitong
 * CST-250
 * 01/29/2025
 * In class Activity
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBoardClassLibrary.Moedls;

namespace ChessBoardClassLibrary.Services.BusinessLogicLayer
{
    public class BoardLogic
    {
        /// <summary>
        /// Reset the board by setting the cell proparties
        /// back to default value
        /// </summary>
        /// <param name="boardMoedl"></param>
        /// <returns></returns>
        public BoardMoedl ResetBoard(BoardMoedl board)
        {
            // use a foreach loop to iterater over every cell
            foreach (CellModel cell in board.Grid)
            {
                // Set the cell properties to their defaults
                cell.IsLegalNextMove = false;
                cell.PieceOccupyingCell = "";

            }
            //Return the board back to the presentation layer
            return board;
        }

        /// <summary>
        /// Check if a row/col location is on chess board
        /// </summary>
        /// <param name="board"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        public bool IsOnBoard(BoardMoedl board, int row, int col)
        {
            // Check to see if the cell is on the board
            return (row >= 0 && row < board.Size) && (col >= 0 && col < board.Size);
        }

        /// <summary>
        /// mark the legal move for a given chess piece and location
        /// </summary>
        /// <param name="board"></param>
        /// <param name="currentCell"></param>
        /// <param name="chessPiece"></param>
        /// <returns></returns>
        public BoardMoedl MarkLegalMoves(BoardMoedl board, CellModel currentCell, string chessPiece)
        {
            // Reset the board
            board = ResetBoard(board);

            // Use switch statement to determine the behavior of the piecr
            // Use ToLower() so casing does not matter
            switch (chessPiece.ToLower())
            {
                case "knight":
                    // Set the occupying property of CellModel for the current cell
                    board.Grid[currentCell.Row, currentCell.Column].PieceOccupyingCell = "N";
                    // Possible move for knight row
                    int[] knightRowMoves = { 2, 1, -1, -2, -2, -1, 1, 2 };
                    // Possible move for knight column
                    int[] knightColMoves = { 1, 2, 2, 1, -1, -2, -2, -1};
                    // loop through the knight moves
                    for (int i = 0; i < knightRowMoves.Length; i++)
                    {
                        // Check if each move is on the board
                        if (IsOnBoard(board, currentCell.Row + knightRowMoves[i], currentCell.Column + knightColMoves[i]))
                        {
                            // If the cell is on board, label it as a possible move
                            board.Grid[currentCell.Row + knightRowMoves[i], currentCell.Column + knightColMoves[i]].IsLegalNextMove = true;
                        }
                    }
                    break;

                case "rook":
                   
                    break;

                default:
                    //if chessPiece is not valid, return the board as is
                    return board;
            }
            // Return the updated board
            return board;
        } // End of the mark legal move method


    }
}
