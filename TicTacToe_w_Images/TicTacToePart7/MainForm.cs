using ExtentionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBrain;
using System.Drawing;
using static TheBrain.TicTacToeLogic;
using GameCellControlNamespace;
using static TheBrain.TicTacToeEnums;

namespace CS_Game_Surface_w_Buttons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private TicTacToeLogic ticTacToeLogic = new TicTacToeLogic();

        private void MainForm_Load(object sender, EventArgs e)
        {
            ticTacToeLogic.CellAssignment +=
                 new TicTacToeLogic.CellAssignmentChanged(this.TicTacToeLogic_CellAssignmentChanged);
        }

        private void txtPlayername_Validated(object sender, EventArgs e)
        {
           ticTacToeLogic.PlayerName = txtPlayerName.Text;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            ticTacToeLogic.ResetGrid();

            foreach (var item in tableLayoutPanel1.Controls)
            {
                var uc = item as GameCellControl;
                if (uc != null)
                {
                    uc.Value = "?";
                    uc.Enabled = true;
                }

            }
        }

        private void btnGoComputer_Click(object sender, EventArgs e)
        {
            ticTacToeLogic.InitiateAutoplay();
            Application.DoEvents();
            CheckForWinner();
        }

        public void TicTacToeLogic_CellAssignmentChanged(object sender, CellAssignmentArgs e)
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                var uc = item as GameCellControl;
                if (uc != null)
                {
                    if ((uc.GameCellRow == e.RowId) && (uc.GameCellCol == e.ColId))
                    {
                        switch (e.SquareOwner)
                        {
                            case TicTacToeEnums.CellOwners.Computer:
                                uc.Value = "O";
                                break;
                            case TicTacToeEnums.CellOwners.Error:
                                uc.Value = "*";
                                break;
                            case TicTacToeEnums.CellOwners.Human:
                                uc.Value = "X";
                                break;
                            case TicTacToeEnums.CellOwners.Open:
                                uc.Value = "?";
                                break;
                            default:
                                uc.Value = "*";
                                break;
                        }
                        uc.Enabled = false;
                    }
                }
            }
        }

        private void TicTacToeButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var uc = sender as GameCellControl;
                if (uc == null) { return; }

                ticTacToeLogic.PlaySquare(uc.GameCellRow, uc.GameCellCol, CellOwners.Human);
                Application.DoEvents();
                CheckForWinner();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Problem with TicTacToeButtonClicked", MessageBoxButtons.OK);
            }
        }

        private void CheckForWinner()
        {
            var winner = ticTacToeLogic.IdentifyWinner();
            if (winner.Length > 0)
            {
                MessageBox.Show(winner, "The winner is:");
            }
        }

        private void gameCellControl10_Load(object sender, EventArgs e)
        {

        }

        private void gameCellControl7_Load(object sender, EventArgs e)
        {

        }

        private void gameCellControl6_Load(object sender, EventArgs e)
        {

        }
    }
}
