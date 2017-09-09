using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Nathan Robson
 */

namespace TheBrain
{
    public class TicTacToeEnums
    {
        /// <summary>
        /// CellOwners is the set of possible cell states
        /// </summary>
        public enum CellOwners
        {
            Error,      // default if not initialized
            Open,
            Human,
            Computer,
            WildCard
        }
    }
}
