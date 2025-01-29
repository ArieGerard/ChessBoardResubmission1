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

namespace ChessBoardClassLibrary.Moedls
{
    public class BoardMoedl
    {
        // Class level properties
        public int Size { get; set; }
        public CellModel[,] Grid { get; set; }

        public BoardMoedl(int size)
        {
            Size = size;
            // Create a new instance of the CellModel
            // that defines the row and column size

            Grid = new CellModel[size, size];

            // Create the board
            InitializeBoard();
        }
        /// <summary>
        /// Set up a new board
        /// </summary>
        public void InitializeBoard()
        {
            // Now initialize a new Board
            // Outer loop iterates through the rows

            for (int row = 0; row < Size; row++)
            {
                // Inner loop iterates through the columns
                for (int col = 0; col < Size; col++)
                {
                    // Set each index to the new CellModel
                    // using the row and column

                    Grid[row, col] = new CellModel(row, col);

                }
            }
        }


    }
}
