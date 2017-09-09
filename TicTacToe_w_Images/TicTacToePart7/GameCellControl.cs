using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBrain;
using static TheBrain.TicTacToeLogic;
using static TheBrain.TicTacToeEnums;
using CS_Game_Surface_w_Buttons;

namespace GameCellControlNamespace
{
    public partial class GameCellControl : UserControl
    {
        public GameCellControl()
        {
            InitializeComponent();
        }

        public int GameCellRow { get; set; }
        public int GameCellCol { get; set; }

        private string _valueBackingValue = "*";
        public string Value
        {
            get { return _valueBackingValue; }
            set
            {
                _valueBackingValue = value;
                switch (_valueBackingValue.ToUpper())
                {
                    case "X":
                        this.BackColor = Color.Transparent;
                        pictureBox1.Image = GameCellControlNamespace.Properties.Resources.Player_X;
                        break;
                    case "O":
                        this.BackColor = Color.Transparent;
                        pictureBox1.Image = GameCellControlNamespace.Properties.Resources.Player_O;
                        break;
                    case "?":
                        this.BackColor = Color.Transparent;
                        pictureBox1.Image = null;
                        break;
                    case "!":
                        this.BackColor = Color.Transparent;
                        pictureBox1.Image = null;
                        break;
                    default:
                        this.BackColor = Color.Red;
                        pictureBox1.Image = null;
                        break;
                }
            }
        }

        public delegate void EventHandler(object sender, EventArgs e);

        public event EventHandler ButtonClick;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(ButtonClick != null)
                ButtonClick(this, new EventArgs());
        }
    }

    

}
