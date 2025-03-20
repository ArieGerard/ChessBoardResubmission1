/*
*Arie Gerard 
*Activity 2
*Bill Hughes
*02/09/2025
*
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessBoardClassLibrary.ModelsLibrary;


namespace ChessBoardClassLibrary.Services.BusinessLogicLayer
{
    public class BoardLogic
    {
       /// <summary>
       /// method for resetting the board, as well as using the BoardModel for a parameter. 
       /// </summary>
       /// <param name="board"></param>
       /// <returns></returns>
        public BoardModel ResetBoard(BoardModel board)
        {
            foreach (CellModel cell in board.Grid)
            {
                cell.IsLegalNextMove = false;
                cell.PieceOccupyingCell = "";

            }
            return board;
        }

       /// <summary>
       /// Logic for checking to see if input is on the board. 
       /// </summary>
       /// <param name="board"></param>
       /// <param name="row"></param>
       /// <param name="col"></param>
       /// <returns></returns>
        public bool IsOnBoard(BoardModel board, int row, int col)
        {
            return (row >= 0 && row < board.Size) && (col >= 0 && col < board.Size);
        }

        /// <summary>
        /// method for showing the legal next moves for a selected peice. 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="currentCell"></param>
        /// <param name="chessPiece"></param>
        /// <returns></returns>
        
        public BoardModel MarkLegalMoves(BoardModel board, CellModel currentCell, string chessPiece)
        {
            board = ResetBoard(board);
            //uses a switch statement for placing the legal next moves for a given peice. 
            switch (chessPiece.ToLower())
            {
                case "knight":
                    board.Grid[currentCell.Row, currentCell.Column].PieceOccupyingCell = "N";
                    int[] knightRowMoves = { 2, 1, -1, -2, -2, -1, 1, 2 };
                    int[] knightColMoves = { 1, 2, 2, 1, -1, -2, -2, -1};
                    for (int i = 0; i < knightRowMoves.Length; i++)
                    {
                        if (IsOnBoard(board, currentCell.Row + knightRowMoves[i], currentCell.Column + knightColMoves[i]))
                        {
                            board.Grid[currentCell.Row + knightRowMoves[i], currentCell.Column + knightColMoves[i]].IsLegalNextMove = true;
                        }
                    }
                    break;

                case "rook":
                    board.Grid[currentCell.Row, currentCell.Column].PieceOccupyingCell = "R";
                    int[] rookRowMoves = { 1, -1, 0, 0 };
                    int[] rookColMoves = { 0, 0, 1, -1 };

                    for (int i = 0; i < rookRowMoves.Length; i++)
                    {
                        int nextRow = currentCell.Row + rookRowMoves[i];
                        int nextCol = currentCell.Column + rookColMoves[i];
                        while (IsOnBoard(board, nextRow, nextCol))
                        {
                            board.Grid[nextRow, nextCol].IsLegalNextMove = true;

                            if (!string.IsNullOrEmpty(board.Grid[nextRow, nextCol].PieceOccupyingCell))
                            {
                                break;
                            }
                            nextRow += rookRowMoves[i];
                            nextCol += rookColMoves[i];
                        }
                    }
                    break;

                case "bishop":
                    board.Grid[currentCell.Row, currentCell.Column].PieceOccupyingCell = "B";

                    int[] bishopRowMoves = { 1, 1, -1, -1 };
                    int[] bishopColMoves = { 1, -1, 1, -1 };

                    for (int i = 0; i < bishopRowMoves.Length; i++)
                    {
                        int nextRow = currentCell.Row + bishopRowMoves[i];
                        int nextCol = currentCell.Column + bishopColMoves[i];

                        while (IsOnBoard(board, nextRow, nextCol))
                        {
                            board.Grid[nextRow, nextCol].IsLegalNextMove = true;

                            if (!string.IsNullOrEmpty(board.Grid[nextRow, nextCol].PieceOccupyingCell))
                            {
                                break;
                            }

                            nextRow += bishopRowMoves[i];
                            nextCol += bishopColMoves[i];
                        }
                    }
                    break;

                case "queen":
                    board.Grid[currentCell.Row, currentCell.Column].PieceOccupyingCell = "Q";

                    int[] queenRowMoves = { 1, -1, 0, 0, 1, 1, -1, -1 };
                    int[] queenColMoves = { 0, 0, 1, -1, 1, -1, 1, -1 };

                    for (int i = 0;i < queenRowMoves.Length; i++)
                    {
                        int nextRow = currentCell.Row + queenRowMoves[i];
                        int nextCol = currentCell.Column + queenColMoves[i];

                        while (IsOnBoard(board, nextRow, nextCol))
                        {
                            board.Grid[nextRow, nextCol].IsLegalNextMove = true;

                            if (!string.IsNullOrEmpty(board.Grid[nextRow, nextCol].PieceOccupyingCell))
                            {
                                break;
                            }

                            nextRow += queenRowMoves[i];
                            nextCol += queenColMoves[i];
                        }
                    }
                    break;

                case "king":
                    board.Grid[currentCell.Row, currentCell.Column].PieceOccupyingCell = "K";

                    int[] kingRowMoves = { 1, -1, 0, 0, 1, 1, -1, -1 };
                    int[] kingColMoves = { 0, 0, 1, -1, 1, -1, 1, -1 };

                    for (int i = 0; i < kingRowMoves.Length; i++)
                    {
                        int nextRow = currentCell.Row + kingRowMoves[i];
                        int nextCol = currentCell.Column + kingColMoves[i];

                            board.Grid[nextRow, nextCol].IsLegalNextMove = true;

                        if (IsOnBoard(board, nextRow, nextCol))
                        {
                            board.Grid[nextRow, nextCol].IsLegalNextMove = true;
                        }

                    }
                    break;

                default:
                    return board;
            }
            return board;
        } 


    }
}
