namespace ChessBoardGUIApp
{
    partial class FrmChessBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(567, 25);
            label1.TabIndex = 0;
            label1.Text = "Select a chess piece and its location on the board and see legal moves";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 9);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "Pieces: ";
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(12, 37);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(500, 500);
            pnlChessBoard.TabIndex = 2;
            // 
            // cmbChessPieces
            // 
            cmbChessPieces.FormattingEnabled = true;
            cmbChessPieces.Items.AddRange(new object[] { "King", "Queen", "Bishop", "Knight", "Rook" });
            cmbChessPieces.Location = new Point(634, 52);
            cmbChessPieces.Name = "cmbChessPieces";
            cmbChessPieces.Size = new Size(182, 33);
            cmbChessPieces.TabIndex = 3;
            // 
            // FrmChessBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 572);
            Controls.Add(cmbChessPieces);
            Controls.Add(pnlChessBoard);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmChessBoard";
            Text = "Chess Board";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pnlChessBoard;
        private ComboBox cmbChessPieces;
    }
}
