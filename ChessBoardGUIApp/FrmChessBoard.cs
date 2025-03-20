using ChessBoardClassLibrary.ModelsLibrary;
using ChessBoardClassLibrary.Services.BusinessLogicLayer;

namespace ChessBoardGUIApp
{
    public partial class FrmChessBoard : Form
    {
        BoardModel board = new BoardModel(8);
        BoardLogic storeLogic = new BoardLogic();
        Button[,] buttons = new Button[8, 8];

        public FrmChessBoard()
        {
            //Calls the initalize components methods to 
            InitializeComponent();
            SetUpButtons();
        }

        /// <summary>
        /// Method to set up the buttons. 
        /// </summary>

        private void SetUpButtons()
        {

            int buttonSize = pnlChessBoard.Width / board.Size;
            pnlChessBoard.Height = pnlChessBoard.Width;

            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    //instantiating the buttons to the row and columns 

                    buttons[row, col] = new Button();
                    buttons[row, col].Width = buttonSize;
                    buttons[row, col].Height = buttonSize;

                    buttons[row, col].Left = row * buttonSize;
                    buttons[row, col].Top = col * buttonSize;
                    buttons[row, col].Click += BtnSquareClickEH;
                    buttons[row, col].Tag = new Point(row, col);
                    buttons[row, col].Text = $"{row}, {col}";
                    pnlChessBoard.Controls.Add(buttons[row, col]);
                }
            }
        }
        /// <summary>
        /// method to tell the user what cell they clicked on. Didnt impliment outprint message because it hinders playability. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnSquareClickEH(object? sender, EventArgs e)
        {

            Button button = (Button)sender;
            Point point = (Point)button.Tag;
            int row = point.X;
            int col = point.Y;
            string piece = cmbChessPieces.Text;


            board = storeLogic.MarkLegalMoves(board, board.Grid[row, col], piece);

            UpdateButtons();
        }

        /// <summary>
        /// Method to update the buttons 
        /// </summary>
        private void UpdateButtons()
        {
            Dictionary<string, string> pieceMap = new Dictionary<string, string>
    {
        {"N", "Knight" },
        {"R", "Rook" },
        {"B", "Bishop" },
        {"Q", "Queen" },
        {"K", "King" }
    };

            string selectedTheme;
            Color legalMoveColor;

            // Validate cmbColor.SelectedItem and handle potential null or invalid values
            if (cmbColor.SelectedItem == null || string.IsNullOrWhiteSpace(cmbColor.SelectedItem.ToString()))
            {
                // Default to a neutral theme if no selection is made
                selectedTheme = "Default";
            }
            else
            {
                selectedTheme = cmbColor.SelectedItem.ToString();
            }

            // Switch case to determine the legal move colors based on the selected theme
            switch (selectedTheme)
            {
                case "Warm":
                    legalMoveColor = Color.Orange;
                    break;
                case "Cool":
                    legalMoveColor = Color.Blue;
                    break;
                case "Forest":
                    legalMoveColor = Color.Green;
                    break;
                default:
                    legalMoveColor = Color.Gray; // Default color
                    break;
            }

            // Loop to mark legal next moves
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    if (board.Grid[row, col].IsLegalNextMove)
                    {
                        buttons[row, col].BackColor = legalMoveColor;
                        buttons[row, col].Text = "Legal Move";
                    }
                    else if (!string.IsNullOrEmpty(board.Grid[row, col].PieceOccupyingCell))
                    {
                        string piece;
                        if (pieceMap.TryGetValue(board.Grid[row, col].PieceOccupyingCell, out piece))
                        {
                            buttons[row, col].BackColor = DefaultBackColor;
                            buttons[row, col].Text = piece;
                        }
                        else
                        {
                            // Handle invalid piece code gracefully
                            buttons[row, col].BackColor = DefaultBackColor;
                            buttons[row, col].Text = "Unknown Piece";
                        }
                    }
                    else
                    {
                        buttons[row, col].BackColor = DefaultBackColor;
                        buttons[row, col].Text = "";
                    }
                }
            }
        }


        private void FrmChessBoard_Load(object sender, EventArgs e)
        {

        }

        private void cmbChessPieces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
