using ChessBoardClassLibrary.Moedls;
using ChessBoardClassLibrary.Services.BusinessLogicLayer;

namespace ChessBoardGUIApp
{
    public partial class FrmChessBoard : Form
    {
        // Class Level variables
        BoardMoedl board = new BoardMoedl(8);
        BoardLogic storeLogic = new BoardLogic();
        Button[,] buttons = new Button[8,8];

        public FrmChessBoard()
        {
            InitializeComponent();
            SetUpButtons();
        }

        /// <summary>
        /// Populate the panel control with buttons
        /// </summary>
        private void SetUpButtons()
        {
            // Calculate the size of each button based on the panel
            // width and number of buttons needed
            int buttonSize = pnlChessBoard.Width / board.Size;
            pnlChessBoard.Height = pnlChessBoard.Width;
            // Use nested for loops to loop through the boards Grid
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    // Set up each individual button
                    // Create a new button in the 2D array
                    buttons[row, col] = new Button();
                    // Set the size for the button
                    buttons[row, col].Width = buttonSize;
                    buttons[row, col].Height = buttonSize;
                    // Set the location of the button
                    // using the left and top sides
                    buttons[row, col].Left = row * buttonSize;
                    buttons[row, col].Top = col * buttonSize;
                    // Attach a click event handler to the button
                    buttons[row, col].Click += BtnSquareClickEH;
                    // Store the location of the button in the tag property using a point object
                    buttons[row, col].Tag = new Point(row, col);
                    // Set the tect for the button
                    buttons[row, col].Text = $"{row}, {col}";
                    // Add the button to the panels controls
                    pnlChessBoard.Controls.Add(buttons[row, col]);
                }
            }
        }// End of SetUpButtons

        /// <summary>
        /// Click Event Hanlder fot the chess board buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSquareClickEH(object? sender, EventArgs e)
        {
            // Declare and initialize
            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;  
            string piece = cmbChessPieces.Text;

            // Show the user their choice
            MessageBox.Show($"You clicked on row {row} and column {col}");
            // Send the board, current cell, and piece to ther business logic layer
            board = storeLogic.MarkLegalMoves(board, board.Grid[row, col], piece);
            // Update the buttons
            UpDateButtons();
        }

        /// <summary>
        /// Update the text for each button based on the board
        /// </summary>
        private void UpDateButtons()
        {

            // Set up a dictionary to get the names of the chess pieces
            Dictionary<string, string> pieceMap = new Dictionary<string, string>
            {
                {"N", "Knight" },
                {"R", "Rook" },
                {"B", "Bishop" },
                {"Q", "Queen" },
                {"K", "King" }
            };

            // Loop through each cell in the grid to update the corresponding button
            for (int row = 0; row < board.Size; row++) 
            {
                for (int col = 0; col < board.Size; col++) 
                {
                    if (board.Grid[row, col].IsLegalNextMove)
                    {
                        // Set the text to show a legal move
                        buttons[row, col].Text = "Legal Move";
                    }
                    else if (board.Grid[row, col].PieceOccupyingCell != "")
                    {
                        // Use the dictionary to get the name of the chess piece
                        string piece = pieceMap[board.Grid[row, col].PieceOccupyingCell];
                        // Update the text for the button
                        buttons[row, col].Text = piece;
                    }
                    else
                    {
                        // Clear the text for any other buttons
                        buttons[row, col].Text = "";
                    }
                }
            }
        } // End of UpdateButtons method
    }
}
