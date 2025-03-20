/*
*Arie Gerard 
*Activity 2
*Bill Hughes
*02/09/2025
*
 */
namespace ChessBoardGUIApp
{
    partial class FrmChessBoard
    {
      
        private System.ComponentModel.IContainer components = null;

       /// <summary>
       /// Method to dispose of unused assets. 
       /// </summary>
       /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChessBoard));
            label1 = new Label();
            label2 = new Label();
            pnlChessBoard = new Panel();
            cmbChessPieces = new ComboBox();
            cmbColor = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 40);
            label1.TabIndex = 0;
            label1.Text = "Select a chess peice and place. \r\n\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(507, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Choose Piece:";
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(10, 30);
            pnlChessBoard.Margin = new Padding(2);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(400, 400);
            pnlChessBoard.TabIndex = 2;
            // 
            // cmbChessPieces
            // 
            cmbChessPieces.FormattingEnabled = true;
            cmbChessPieces.Items.AddRange(new object[] { "King", "Queen", "Bishop", "Knight", "Rook" });
            cmbChessPieces.Location = new Point(507, 42);
            cmbChessPieces.Margin = new Padding(2);
            cmbChessPieces.Name = "cmbChessPieces";
            cmbChessPieces.Size = new Size(146, 28);
            cmbChessPieces.TabIndex = 3;
            cmbChessPieces.SelectedIndexChanged += cmbChessPieces_SelectedIndexChanged;
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Warm", "Cool ", "Forest" });
            cmbColor.Location = new Point(507, 95);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(151, 28);
            cmbColor.TabIndex = 4;
            // 
            // FrmChessBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 458);
            Controls.Add(cmbColor);
            Controls.Add(cmbChessPieces);
            Controls.Add(pnlChessBoard);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmChessBoard";
            Text = "Chess Board";
            Load += FrmChessBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pnlChessBoard;
        private ComboBox cmbChessPieces;
        private ComboBox cmbColor;
    }
}
