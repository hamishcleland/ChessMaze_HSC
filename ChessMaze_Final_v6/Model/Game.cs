using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessMaze_Final
{
    public class Game : IGame
    {

        // The two player lists containing the players moves in the x and y axis
        public List<int> playerMoveListXAxis = new List<int>() {0};
        public List<int> playerMoveListYAxis = new List<int>() {0};
        // The position the player is going to and currently are
        public int xAxisDest { get; set; }
        public int yAxisDest { get; set; }
        public int xAxisPosition { get; set; }
        public int yAxisPosition { get; set; }
        public int moveCount { get; set; }

        // The object that the board is updated to
        private List<List<Part>> _newBoard = new List<List<Part>>();

        public bool _gameFinished = false;

        public Level level = new Level();
        public GameFile file = new GameFile();

        // This function loads the level from a string.
        public void Load(string newLevel)
        {
            xAxisPosition = yAxisPosition = xAxisDest = yAxisDest = moveCount = 0;
            // The new line characters are removed
            string _stringChars = newLevel.Replace("\n", "");
            // Map size is determined by the criteria below
            int _xMapSize = newLevel.IndexOf("\n", 0);
            int _yMapSize = newLevel.Count(c => c.Equals('\n')) + 1;
            // String is iterated through and added to a new line of the board
            // Nested loop with map sizes as the parameters is used to add to the board
            List<Part> _boardLine = new List<Part>();
            int _stringIndex = 0;

            for (int i = 0; i < _yMapSize; i++)
            {
                for (int j = 0; j < _xMapSize; j++)
                {
                    int _asciiId = _stringChars[_stringIndex];
                    Part piece = (Part)_asciiId;
                    _boardLine.Add(piece);
                    _stringIndex++;
                }
                List<Part> newLine = new List<Part>(_boardLine);
                _newBoard.Add(newLine);
                _boardLine.Clear();
            }

            // Level information is sent to level object
            level.Board = _newBoard;
            level.XMapSize = _xMapSize;
            level.YMapSize = _yMapSize;
        }

        public void Load(string newLevel, List<int> playerMoveListXAxis, List<int> playerMoveListYAxis, int moveCount)
        {
            xAxisDest = yAxisDest = 0;
            // The new line characters are removed
            string _stringChars = newLevel.Replace("\n", "");
            // Map size is determined by the criteria below
            int _xMapSize = newLevel.IndexOf("\n", 0);
            int _yMapSize = newLevel.Count(c => c.Equals('\n')) + 1;
            // String is iterated through and added to a new line of the board
            // Nested loop with map sizes as the parameters is used to add to the board
            List<Part> _boardLine = new List<Part>();
            int _stringIndex = 0;

            for (int i = 0; i < _yMapSize; i++)
            {
                for (int j = 0; j < _xMapSize; j++)
                {
                    int _asciiId = _stringChars[_stringIndex];
                    Part piece = (Part)_asciiId;
                    _boardLine.Add(piece);
                    _stringIndex++;
                }
                List<Part> newLine = new List<Part>(_boardLine);
                _newBoard.Add(newLine);
                _boardLine.Clear();
            }

            // Level information is sent to level object
            level.Board = _newBoard;
            level.XMapSize = _xMapSize;
            level.YMapSize = _yMapSize;
            this.moveCount = moveCount;
            this.xAxisPosition = playerMoveListXAxis.Last();
            this.yAxisPosition = playerMoveListYAxis.Last();
            this.playerMoveListXAxis = playerMoveListXAxis;
            this.playerMoveListYAxis = playerMoveListYAxis;
        }

        public void Move(Direction moveDirection)
        {
            // The _UpdateDest function updates the coordinates of where the move is going
            try
            {
                _UpdateDest(moveDirection);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new InvalidOperationException("You can't move outside the board");
            }
            List<List<Part>> _newBoard = level.Board;
            Part _newSquarePart = _newBoard[yAxisDest][xAxisDest];
            Part _currentSquarePart = _newBoard[yAxisPosition][xAxisPosition];
            // The move valid subfunction checks the Part the player is on and checks the validity of the move
            bool _aValidMove = _MoveValid(moveDirection);
            if (_aValidMove == false)
            {
                throw new InvalidOperationException("You are making an invalid move");
            }
            else
            {
                if (moveDirection != Direction.NoMove)
                {
                    // The board is updated by modifying the current square from player on to player off by changing from lower to upper case
                    // This is done by modifying the int value by + or - 32 as this is the ascii difference between the two
                    int _currentAsciiValue = (int)_currentSquarePart - 32;
                    _newBoard[yAxisPosition][xAxisPosition] = (Part)_currentAsciiValue;
                    int _newAsciiValue = (int)_newSquarePart + 32;
                    _newBoard[yAxisDest][xAxisDest] = (Part)_newAsciiValue;
                    level.Board = _newBoard;
                    // Once the board is updated, the move is added to the player list, destination updated to current position and move count incremented
                    playerMoveListXAxis.Add(xAxisDest);
                    playerMoveListYAxis.Add(yAxisDest);
                    xAxisPosition = xAxisDest;
                    yAxisPosition = yAxisDest;
                    moveCount++;
                }
            }
        }

        // This checks if a move is diagonal by checking if the difference between the destination and current position is even to each other
        private bool _IsDiagonalMove()
        {
            bool _isDiagonalMove = Math.Abs(xAxisPosition - xAxisDest) == Math.Abs(yAxisPosition - yAxisDest);
            return _isDiagonalMove;
        }

        // This checks if a move is vertical by checking if the x axis does not change and the y axis does
        private bool _IsVerticalMove()
        {
            bool _isVerticalMove = xAxisPosition == xAxisDest && yAxisPosition != yAxisDest;
            return _isVerticalMove;
        }

        // This checks if a move is horizontal by checking if the y axis does not change and the x axis does
        private bool _IsHorizontalMove()
        {
            bool _isHorizontalMove = xAxisPosition != xAxisDest && yAxisPosition == yAxisDest;
            return _isHorizontalMove;
        }

        // This checks for a knight move by checking if the move goes 2 vertical, 1 across or 2 across, 1 vertical
        private bool _IsKnightMove()
        {
            bool _isKnightMove =
                Math.Abs(xAxisPosition - xAxisDest) == 1 && Math.Abs(yAxisPosition - yAxisDest) == 2 ||
                Math.Abs(xAxisPosition - xAxisDest) == 2 && Math.Abs(yAxisPosition - yAxisDest) == 1;
            return _isKnightMove;
        }

        // This checks for a king move by only allowing the player to move 1 square
        private bool _IsKingMove()
        {
            bool _isKingMove = Math.Abs(xAxisPosition - xAxisDest) <= 1 && Math.Abs(yAxisPosition - yAxisDest) <= 1;
            return _isKingMove;
        }


        // This function checks the current piece and applies the above functions as criteria to check for a valid move
        private bool _MoveValid(Direction direction)
        {
            List<List<Part>> _aBoard = level.Board;
            bool _validMove = false;
            Part _currentSquare = _aBoard[yAxisPosition][xAxisPosition];
            switch (_currentSquare)
            {
                case Part.PlayerOnBishop:
                    _validMove = _IsDiagonalMove();
                    break;

                case Part.PlayerOnRook:
                    _validMove = _IsVerticalMove() || _IsHorizontalMove();
                    break;

                case Part.PlayerOnQueen:
                    _validMove = _IsVerticalMove() || _IsHorizontalMove() || _IsDiagonalMove();
                    break;

                case Part.PlayerOnKnight:
                    _validMove = _IsKnightMove();
                    break;

                case Part.PlayerOnKing:
                    _validMove = (_IsVerticalMove() || _IsHorizontalMove() || _IsDiagonalMove()) && _IsKingMove();
                    break;

                default:
                    break;
            }
            return _validMove;
        }

        // This function updates the position a player is going to by looping through squares in the direction of the move until a non empty square is reached
        // Knight moves are directly updated as they can jump pieces
        public void _UpdateDest(Direction direction)
        {
            string _theDirection = direction.ToString();
            List<List<Part>> _aBoard = this.level.Board;
            Part _nextSquare = Part.Empty;
            int _xMovement = 1;
            int _yMovement = 1;
            switch (_theDirection)
            {
                case "Up":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition - _yMovement][xAxisPosition];
                        if (_nextSquare == Part.Empty)
                        {
                            _yMovement++;
                        }
                    }
                    yAxisDest = yAxisPosition - _yMovement;
                    break;

                case "Down":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition];
                        if (_nextSquare == Part.Empty)
                        {
                            _yMovement++;
                        }
                    }
                    yAxisDest = yAxisPosition + _yMovement;
                    break;

                case "Left":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition][xAxisPosition - _xMovement];
                        if (_nextSquare == Part.Empty)
                        {
                            _xMovement++;
                        }
                    }
                    xAxisDest = xAxisPosition - _xMovement;
                    break;

                case "Right":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition][xAxisPosition + _xMovement];
                        if (_nextSquare == Part.Empty)
                        {
                            _xMovement++;
                        }
                    }
                    xAxisDest = xAxisPosition + _xMovement;
                    break;

                case "UpLeft":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition - _yMovement][xAxisPosition - _xMovement];
                        if (_nextSquare == Part.Empty)
                        {
                            _xMovement++;
                            _yMovement++;
                        }
                    }
                    xAxisDest = xAxisPosition - _xMovement;
                    yAxisDest = yAxisPosition - _yMovement;
                    break;

                case "UpRight":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition - _yMovement][xAxisPosition + _xMovement];
                        if (_nextSquare == Part.Empty)
                        {
                            _xMovement++;
                            _yMovement++;
                        }
                    }
                    xAxisDest = xAxisPosition + _xMovement;
                    yAxisDest = yAxisPosition - _yMovement;
                    break;

                case "DownLeft":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition - _xMovement];
                        if (_nextSquare == Part.Empty)
                        {
                            _xMovement++;
                            _yMovement++;
                        }
                    }
                    xAxisDest = xAxisPosition - _xMovement;
                    yAxisDest = yAxisPosition + _yMovement;
                    break;

                case "DownRight":
                    while (_nextSquare == Part.Empty)
                    {
                        _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                        if (_nextSquare == Part.Empty)
                        {
                            _xMovement++;
                            _yMovement++;
                        }
                    }
                    xAxisDest = xAxisPosition + _xMovement;
                    yAxisDest = yAxisPosition + _yMovement;
                    break;

                case "KMUpLeft":
                    _xMovement = -1;
                    _yMovement = -2;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMUpRight":
                    _xMovement = 1;
                    _yMovement = -2;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMDownLeft":
                    _xMovement = -1;
                    _yMovement = 2;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMDownRight":
                    _xMovement = 1;
                    _yMovement = 2;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMLeftUp":
                    _xMovement = -2;
                    _yMovement = -1;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMLeftDown":
                    _xMovement = -2;
                    _yMovement = 1;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMRightUp":
                    _xMovement = 2;
                    _yMovement = -1;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "KMRightDown":
                    _xMovement = 2;
                    _yMovement = 1;
                    _nextSquare = _aBoard[yAxisPosition + _yMovement][xAxisPosition + _xMovement];
                    if (_nextSquare != Part.Empty)
                    {
                        xAxisDest = xAxisPosition + _xMovement;
                        yAxisDest = yAxisPosition + _yMovement;
                    }
                    break;

                case "NoMove":
                    break;

                default:
                    break;
            }
        }

        // This function returns the move count
        public int GetMoveCount()
        {
            int _theMoveCount = moveCount;
            return _theMoveCount;
        }

        // This function checks the size of the level and determines wheather the player has navigated to the bottom right corner
        public bool IsFinished()
        {
            int _xMapSize = level.XMapSize;
            int _yMapSize = level.YMapSize;
            if (xAxisPosition == _xMapSize - 1 && yAxisPosition == _yMapSize - 1)
            {
                _gameFinished = true;
            }
            return _gameFinished;
        }

        // This function restarts the level. The move count lists are cleared and the players position and board reset to how they were at the start of the game
        public void Restart()
        {
            if (moveCount == 0)
            {
                // Do nothing
            }
            else
            {
                _newBoard = level.Board;
                xAxisDest = yAxisDest = moveCount = 0;
                _gameFinished = false;
                playerMoveListXAxis.Clear();
                playerMoveListXAxis.Add(0);
                playerMoveListYAxis.Clear();
                playerMoveListYAxis.Add(0);
                Part _newSquarePart = _newBoard[yAxisDest][xAxisDest];
                Part _currentSquarePart = _newBoard[yAxisPosition][xAxisPosition];
                int _currentAsciiValue = (int)_currentSquarePart - 32;
                _newBoard[yAxisPosition][xAxisPosition] = (Part)_currentAsciiValue;
                int _newAsciiValue = (int)_newSquarePart + 32;
                _newBoard[yAxisDest][xAxisDest] = (Part)_newAsciiValue;
                level.Board = _newBoard;
                xAxisPosition = yAxisPosition = 0;
            }
        }

        // This function winds back the last move of the player by removing the last move from the list and resetting the board to how it was at that time
        public void Undo()
        {
            if (playerMoveListXAxis.Count > 1)
            {
                playerMoveListXAxis.RemoveAt(playerMoveListXAxis.Count - 1);
                playerMoveListYAxis.RemoveAt(playerMoveListYAxis.Count - 1);
                xAxisDest = playerMoveListXAxis.Last();
                yAxisDest = playerMoveListYAxis.Last();
                List<List<Part>> currentBoard = level.Board;
                Part _currentSquarePart = currentBoard[yAxisPosition][xAxisPosition];
                int _currentAsciiValue = (int)_currentSquarePart - 32;
                currentBoard[yAxisPosition][xAxisPosition] = (Part)_currentAsciiValue;
                Part _newSquarePart = currentBoard[yAxisDest][xAxisDest];
                int _newAsciiValue = (int)_newSquarePart + 32;
                currentBoard[yAxisDest][xAxisDest] = (Part)_newAsciiValue;
                level.Board = currentBoard;
                xAxisPosition = xAxisDest;
                yAxisPosition = yAxisDest;
                moveCount--;
            }
            else
            {
                return;
            }
            
        }


        // This function exports the current data of the game to a file class so that it can be saved to a file
        public GameFile ExportGameData()
        {
            file.ExportBoard = level.Board;
            file.ExportPlayerMoveListXAxis = playerMoveListXAxis;
            file.ExportPlayerMoveListYAxis = playerMoveListYAxis;
            file.exportMoveCount = moveCount;
            return file;
        }

        public void ImportGameData(GameFile file)
        {
            level.Board = file.ExportBoard;
            playerMoveListXAxis = file.ExportPlayerMoveListXAxis;
            playerMoveListYAxis = file.ExportPlayerMoveListYAxis;
            moveCount = file.exportMoveCount;
        }

        public Tuple<int,int> GetPlayerPosition()
        {
            int xPos = xAxisPosition;
            int yPos = yAxisPosition;
            return Tuple.Create(xPos,yPos);
        }

        public void UpdatePlayerDest(int x, int y)
        {
            xAxisDest = x;
            yAxisDest = y;
        }

        public Tuple<int, int> GetPlayerDestination()
        {
            int xPos = xAxisDest;
            int yPos = yAxisDest;
            return Tuple.Create(xPos, yPos);
        }

        // The two functions below return the size of the level
        public int GetColumnCount()
        {
            return level.YMapSize;
        }

        public int GetRowCount()
        {
            return level.XMapSize;
        }

        // This functions a Part of the current piece at a specfic destination
        public Part WhatsAt(int row, int column)
        {
            Part _currentSquare = level.Board[column - 1][row - 1];
            return _currentSquare;
        }
    }
}


