/*
*Arie Gerard 
*Activity 2
*Bill Hughes
*02/09/2025
*
*
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardClassLibrary.ModelsLibrary
{
    public class CellModel
    {
       //Getters and setters for the row, column, peice occupiying the cell, and a boolean for the legal next move. 
        public int Row { get; set; }
        public int Column { get; set; }
        public string PieceOccupyingCell { get; set; }
        public bool IsLegalNextMove { get; set; }
        /// <summary>
        /// paramaterized constructor for the row and column, as well as setting the default values for the peices ocupying the cell and legal next move. 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        
        public CellModel(int row, int column)
        {
            Row = row;
            Column = column;

            PieceOccupyingCell = "";
            IsLegalNextMove = false;
        }
    }

}
