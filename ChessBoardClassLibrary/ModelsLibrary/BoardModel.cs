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

namespace ChessBoardClassLibrary.ModelsLibrary;

public class BoardModel
{
   //getters and setter for the size and CellModel class.
    public int Size { get; set; }
    public CellModel[,] Grid { get; set; }
    /// <summary>
    /// Uses a size to create a new boardmodel, as well as uses the initalize board method to initalize the board. 
    /// </summary>
    /// <param name="size"></param>
    public BoardModel(int size)
    {
        //initalizes the size to the size parameter. 
        Size = size;
        //creates a new grid using the cell model class. 
        Grid = new CellModel[size, size];

        InitializeBoard();
    }
    /// <summary>
    /// Initalize board model to place all the components of the board using a nested for loop. 
    /// </summary>
    public void InitializeBoard()
    {
        

        for (int row = 0; row < Size; row++)
        {
            for (int col = 0; col < Size; col++)
            {

                Grid[row, col] = new CellModel(row, col);

            }
        }
    }


}
