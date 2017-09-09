using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheBrain.TicTacToeEnums;

// Nathan Robson

namespace TheBrain
{
     

    /// <summary>
    /// TicTacToeLogic is used to perform all of the processing. This class must track
    /// --- the player's name
    /// --- the winner
    /// --- the collection of game cells
    /// --- the three-cell combinations representing rows, columns, and diagonals
    /// </summary>
    public class TicTacToeLogic
    {
        /// <summary>
        /// PlayerName Provides an identifier for the human player
        /// public to allow simple switching between turns
        /// getters and setters are defined in TicTacToeLogic class
        /// </summary>
        public string PlayerName { get; set; } = "Human";


        /// <summary>
        /// Winner is a property to identify the winner
        /// public so that it can be called when "win" conditions are met
        /// The private setter must be called when the "win" conditions are met
        /// </summary>
        public CellOwners Winner { get; private set; }


        /// <summary>
        /// Acts as a virtual representation of the board, for game logic purposes
        /// players shouldn't be able to directly modify it
        /// methods defined in TicTacToeLogic
        /// </summary>
        private Collection<TicTacToeCells> _ticTacToeCells = new Collection<TicTacToeCells>();


        /// <summary>
        /// This is a collection of 8 possible winning patterns. Each element of the collection references DIRECTLY into the
        /// _ticTacToeCells elements. When populated, the 8 collections (rows, columns, diagonals) will contain collections of
        /// the cells in those sets. In other words, each of the secondary collections will consist of three cell locations. 
        /// For example: 0-0, 0-1, 0-2 (the first row)
        /// </summary>
        private Collection<Collection<TicTacToeCells>> _scanMatrix = new Collection<Collection<TicTacToeCells>>();


        /// <summary>
        /// --- Identified as a constructor because it shares the same name as the class it is located in
        /// --- executed when the grid should be reset (when a new board should be generated)
        /// </summary>
        public TicTacToeLogic()
        {
            ResetGrid();
        }


        /// <summary>
        /// Generates a new board for play
        /// Public so that it can be modified outside of local scope
        /// Used when a new board/game is requested
        /// </summary>
        public void ResetGrid()
        {
            // clear the current board for a new game
            _ticTacToeCells.Clear();
            _scanMatrix.Clear();

            // 25 "spaces" are assigned the values of rowNo and colNo simulating a 5 x 5 board
            for (var rowNo = 0; rowNo < 5; rowNo++)
            {
                for (var colNo = 0; colNo < 5; colNo++)
                {
                    // sets the "free" space
                    if(rowNo == 2 && colNo == 2)
                    {
                        _ticTacToeCells.Add(new TicTacToeCells
                        {
                            rowID = rowNo,
                            colID = colNo,
                            // Wild card denotes the free space
                            XorY = CellOwners.WildCard
                        });
                    }

                    // sets the playing spaces
                    else
                    {
                        _ticTacToeCells.Add(new TicTacToeCells
                        {
                            rowID = rowNo,
                            colID = colNo,
                            // XorY property is determined in the game, not initially
                            XorY = CellOwners.Open
                        });
                    }
                }
            }
        

            #region 
            // Adding the three collections of 5 rows to the _scanMatrix
            for (var rowNo = 0; rowNo < 5; rowNo++)
            {
                // scanMatrixSet will hold columns 0, 1, and 2 for a given row
                var scanMatrixSet = new Collection<TicTacToeCells>(); 
                for (int colNo = 0; colNo < 5; colNo++)
                {
                    scanMatrixSet.Add(_ticTacToeCells.First(ttts => ttts.rowID == rowNo && ttts.colID == colNo));
                }
                _scanMatrix.Add(scanMatrixSet); // just added a row of cells to the scan matrix
            }

            // Adding the columns to the _scanMatrix
            for (var colNo = 0; colNo < 5; colNo++)
            {
                var scanMatrixSet = new Collection<TicTacToeCells>();
                for (int rowNo = 0; rowNo < 5; rowNo++)
                {
                    scanMatrixSet.Add(_ticTacToeCells.First(ttts => ttts.rowID == rowNo && ttts.colID == colNo));
                }
                _scanMatrix.Add(scanMatrixSet);
            }

            // Adding the first diagonal to the _scanMatrix
            _scanMatrix.Add(new Collection<TicTacToeCells>
            {
                _ticTacToeCells.First(ttts => ttts.rowID == 0 && ttts.colID == 0),
                _ticTacToeCells.First(ttts => ttts.rowID == 1 && ttts.colID == 1),
                _ticTacToeCells.First(ttts => ttts.rowID == 2 && ttts.colID == 2),
                _ticTacToeCells.First(ttts => ttts.rowID == 3 && ttts.colID == 3),
                _ticTacToeCells.First(ttts => ttts.rowID == 4 && ttts.colID == 4)
            });

            // Adding the second diagonal to the _scanMatrix
            _scanMatrix.Add(new Collection<TicTacToeCells>
            {
                _ticTacToeCells.First(ttts => ttts.rowID == 4 && ttts.colID == 0),
                _ticTacToeCells.First(ttts => ttts.rowID == 3 && ttts.colID == 1),
                _ticTacToeCells.First(ttts => ttts.rowID == 2 && ttts.colID == 2),
                _ticTacToeCells.First(ttts => ttts.rowID == 1 && ttts.colID == 3),
                _ticTacToeCells.First(ttts => ttts.rowID == 0 && ttts.colID == 4),
            });
            #endregion


            // Reset winner as open, since there is no winner at this point yet
            Winner = CellOwners.Open;
            IdentifyWinner();
        }


        /// <summary>
        /// Finds a cell and identifies the cellOwner
        /// </summary>
        /// <param name="rowNo">Row number of the cell to check</param>
        /// <param name="colNo">column number of the cell to check</param>
        /// <returns>CellOwners</returns>
        public CellOwners IdentifySquare(int rowNo, int colNo)
        {
            // Query for the "square" with a matching row and column
            var targetSquare = _ticTacToeCells
                .FirstOrDefault(ttts => ttts.rowID == rowNo && ttts.colID == colNo);

            // The Elvis operator returns XorY if targetSquare has a non-null value
            return targetSquare?.XorY ?? CellOwners.Error;
        }

        /// <summary>
        /// Method called when a play is made in-game
        /// </summary>
        /// <param name="rowNo">Row number of the selected square</param>
        /// <param name="colNo">Column number of the selected square</param>
        /// <param name="squareOwner">Owner of the square (human, computer, open, error)</param>
        public void PlaySquare(int rowNo, int colNo, CellOwners squareOwner)
        {
            var targetSquare = _ticTacToeCells
                .FirstOrDefault(ttts => ttts.rowID == rowNo && ttts.colID == colNo);

            // there may be bad input
            if (targetSquare != null)
            {
                targetSquare.XorY = squareOwner;

                // new event argument with a row, column, and XorY property
                var eventArgs = new CellAssignmentArgs(targetSquare.rowID, targetSquare.colID, targetSquare.XorY);

                // assigns the new arguments to the selected square, if the cell selected isnt null
                if (this.CellAssignment != null)
                    this.CellAssignment(this, eventArgs);

                
            }
        }


        /// <summary>
        /// Creates an object with info detailing Row/Column/User claiming a square
        /// Called whenever a player makes a move in-game to pass along to the playSquare method
        /// </summary>
        public class CellAssignmentArgs : EventArgs
        {
            public int RowId { get; private set; }
            public int ColId { get; private set; }
            public CellOwners SquareOwner { get; private set; }

            // accepts info from the player's choice (row, column, Human/Computer)
            public CellAssignmentArgs(int rowID, int colID, CellOwners squareOwner)
            {
                this.RowId = rowID;
                this.ColId = colID;
                this.SquareOwner = squareOwner;
            }
        }


        /// <summary>
        /// A delegate is a unique type used to call methods when the specified datatype is created
        /// This delegate is used when a cell assignment is changed (when a play is made)
        /// </summary>
        /// <param name="sender">Player who has made the move</param>
        /// <param name="e">Info from the user selection (row, column, human/computer)</param>
        public delegate void CellAssignmentChanged(object sender, CellAssignmentArgs e);


        /// <summary>
        /// Used to call relevant methods when specified actions happen
        /// It is used with classes and delegates to handle user input in this program
        /// </summary>
        public event CellAssignmentChanged CellAssignment;


        /// <summary>
        /// The computer is expected to make a semi-intelligent move
        /// </summary>
        public void InitiateAutoplay()
        {
            TicTacToeCells targetCellRowCol; // null

            // there are 8 elements to the _scanMatrix. Each toplevel element
            // consists of references to 3 elements in the _ticTacToeCells collection
            // so this LINQ statement is checking each of those 8 combinations and looking
            // for a combination of 2 computer owned cells and 1 open cell.
            // this is the cell to make the computer the winner
            var needsPlayed = _scanMatrix
                .FirstOrDefault(p =>
                    p.Count(q => q.XorY == CellOwners.Computer) == (p.Count - 1) &&
                    p.Count(q => q.XorY == CellOwners.Open) == 1);

            // the computer is checking for a defensive move to prevent the human from winning
            var needsBlocked = _scanMatrix
                .FirstOrDefault(p =>
                    p.Count(q => q.XorY == CellOwners.Human) >= 3 &&
                    p.Count(q => q.XorY == CellOwners.Open) == 1);

            // the decision on where to play is being made
            if (needsPlayed != null)
            {
                targetCellRowCol = needsPlayed.FirstOrDefault(q => q.XorY == CellOwners.Open);
                if (targetCellRowCol == null) return;
            }
            else if (needsBlocked != null)
            {
                targetCellRowCol = needsBlocked.FirstOrDefault(q => q.XorY == CellOwners.Open);
                if (targetCellRowCol == null) return;
            }
            else
            {
                targetCellRowCol = _ticTacToeCells.FirstOrDefault(cell => cell.XorY == CellOwners.Open);
            }
            
            // None of the previous conditions were met (first move of the game for example)
            if (targetCellRowCol == null) return;

            // final step!
            // play the cell choosen!
            PlaySquare(targetCellRowCol.rowID, targetCellRowCol.colID, CellOwners.Computer);
        }


        /// <summary>
        /// Method to identify the winner of the game
        /// </summary>
        /// <returns>String with the name of the game winner (playerName, or "Computer")</returns>
        public string IdentifyWinner()
        {
            // _scanMatrix is a Collection<Collection<TicTacToeCell>>
            foreach (var scanpattern in _scanMatrix)
            {
                // scanpattern is a Collection<TicTacToeCell>, consists of three cells in a row - cells to be checked
                var theseFiveOwners = new Collection<CellOwners>();
                foreach (var scancell in scanpattern)
                {
                    theseFiveOwners.Add(scancell.XorY);
                }

                // now check the cellOwners - are they ALL human?
                var winnerHuman = theseFiveOwners.All(cell => ((cell == CellOwners.Human) || (cell == CellOwners.WildCard)));
                if (winnerHuman)
                {
                    Winner = CellOwners.Human;
                }

                // now check the cellOwners - are they ALL computer?
                var winnerComputer = theseFiveOwners.All(cell => ((cell == CellOwners.Computer) || (cell == CellOwners.WildCard)));
                if (winnerComputer)
                {
                    Winner = CellOwners.Computer;
                }
            }

            switch (Winner)
            {
                case CellOwners.Human:
                    return PlayerName;
                case CellOwners.Computer:
                    return "Computer";
                default:
                    return string.Empty;
            }
        }
    }
}
