using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheBrain.TicTacToeEnums;

/*
 * Nathan Robson
 */

namespace TheBrain
{
    /// <summary>
    /// A class representing a single TicTacToe square. Note: this is not the square itself, just a copy of the square
    /// </summary>
    class TicTacToeCells
    {
        /// <summary>
        /// Property indicating the row of the referenced square (0-2)
        /// </summary>
        public int rowID { get; set; }

        /// <summary>
        /// Property indicating the column of the referenced square (0-2)
        /// </summary>
        public int colID { get; set; }

        /// <summary>
        /// Property indicating the owner of a square
        /// human, computer, open, error(default)
        /// </summary>
        public TicTacToeEnums.CellOwners XorY { get; set; } = CellOwners.Open;
    }
}
