/*
*Arie Gerard 
*Activity 2
*Bill Hughes
*02/09/2025
*
*
 */
namespace ChessBoardGUIApp
{
    internal static class Program
    {
       /// <summary>
       /// Main access point for the game. 
       /// </summary>
       /// 

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmChessBoard());
        }
    }
}