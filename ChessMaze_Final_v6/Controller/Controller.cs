using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace ChessMaze_Final

{
    public class Controller
    {
        IGame game = new Game();

        // Starts the game
        public void Go(string levelString)
        {
            game.Load(levelString);
            // Easy level level "rEN\nEER\nBBQ"
            // Medium Level "qBBBRK\nEEREBN\nNEREEE\nBNEBNB\nNBEBER\nBBEBNQ"
            // Hard Level "qEKBEERK\nEEERENEB\nENEEENEN\nEBEERBEB\nEBNEERER\nEEBBREEE\nBEEEEERE\nREEREEEK"
        }

        // Undoes moves in the model

        public void UndoMove()
        {
            game.Undo();
        }

        public int GetMoveCount()
        {
            int theMoveCount = game.GetMoveCount();
            return theMoveCount;
        }

        public Part WhatsAt(int row, int column)
        {
            Part part = game.WhatsAt(row,column);
            return part;
        }

        public void RestartGame()
        {
            game.Restart();
        }

        public Tuple<int, int> GetPlayerPosition()
        {
            return game.GetPlayerPosition();
        }

        public void UpdatePlayerDestination(int x, int y)
        {
            game.UpdatePlayerDest(x,y);
        }

        // This makes a move
        public void Move(Direction direction)
        {
            game.Move(direction);
        }

        public void CheckGameFinished()
        {
            if (game.IsFinished() == true)
            {
                MessageBox.Show("You have won the game!");
            }
        }

        public int GetColumnCount()
        {
            return game.GetColumnCount();
        }

        public int GetRowCount()
        {
            return game.GetRowCount();
        }

        //This loads a level from a file. Only use when no level is loaded
        public void LoadLevel(GameFile file)
        {
            string levelString = file.ReturnStringBoard();
            game.Load(levelString, file.ExportPlayerMoveListXAxis, file.ExportPlayerMoveListYAxis, file.exportMoveCount);
        }

        // This saves a level from a file
        public GameFile SaveLevel(string levelName)
        {
            GameFile savedGame = game.ExportGameData();
            return savedGame;
        }

        // This method loads all pictures for a board. Further information in comments inside
        public void LoadPictureBoxes(List<PictureBox> pictureBoxesForDisplay, List<List<PictureBox>> allPictureBoxes, Form form, bool restart = false)
        {
            // Clears existing list in restarts
            if (restart == true)
            {
                pictureBoxesForDisplay.Clear();
            }
            else
            { }
            int xCounter = 0;
            int yCounter = 0;
            int columnCount = GetColumnCount();
            int rowCount = GetRowCount();
            // This code adds the required pictureboxs from the main list into a smaller list of pictureboxes that will be shown
            foreach (List<PictureBox> row in allPictureBoxes)
            {
                while (columnCount != xCounter)
                {
                    pictureBoxesForDisplay.Add(row[xCounter]);
                    xCounter++;
                }
                // Resizes the form based on its size
                form.Size = new Size(columnCount * 65 + 120, rowCount * 65 + 210);
                xCounter = 0;
                yCounter++;
                if (rowCount == yCounter)
                {
                    break;
                }
            }
            int xVal = 1;
            int yVal = 1;
            // Colours the square based on a normal chess board pattern
            foreach (PictureBox element in pictureBoxesForDisplay)
            {

                Part part = Part.PlayerOnEmpty;
                part = WhatsAt(xVal, yVal);
                ImageSetter(part, element);
                if (xVal % 2 == 0 ^ yVal % 2 == 0)
                {
                    element.BackColor = Color.White;
                }
                else
                {
                    element.BackColor = Color.RoyalBlue;
                }
                if (xVal < columnCount)
                {
                    xVal++;
                }
                else if (xVal == columnCount)
                {
                    yVal++;
                    xVal = 1;
                }
            }
        }

        // This function selects an image based on the square input
        private void ImageSetter(Part part, PictureBox element)
        {
            if (part == Part.PlayerOnRook)
            {
                element.Image = Image.FromFile(@"Image\w_rook.png");
            }
            else if (part == Part.PlayerOnBishop)
            {
                element.Image = Image.FromFile(@"Image\w_bishop.png");
            }
            else if (part == Part.PlayerOnQueen)
            {
                element.Image = Image.FromFile(@"Image\w_queen.png");
            }
            else if (part == Part.PlayerOnKing)
            {
                element.Image = Image.FromFile(@"Image\w_king.png");
            }
            else if (part == Part.PlayerOnKnight)
            {
                element.Image = Image.FromFile(@"Image\w_knight.png");
            }
            else if (part == Part.Rook)
            {
                element.Image = Image.FromFile(@"Image\b_rook.png");
            }
            else if (part == Part.Bishop)
            {
                element.Image = Image.FromFile(@"Image\b_bishop.png");
            }
            else if (part == Part.Queen)
            {
                element.Image = Image.FromFile(@"Image\b_queen.png");
            }
            else if (part == Part.King)
            {
                element.Image = Image.FromFile(@"Image\b_king.png");
            }
            else if (part == Part.Knight)
            {
                element.Image = Image.FromFile(@"Image\b_knight.png");
            }
            else if (part == Part.Empty)
            {
                element.Image = null;
            }
        }
        // This function takes the current player and destination to determine the direction of the move
        public Direction DetMove()
        {
            Tuple <int,int> playerPos = game.GetPlayerPosition();
            Tuple <int,int> playerDest = game.GetPlayerDestination();

            if (playerPos.Item1 != playerDest.Item1 && playerPos.Item2 == playerDest.Item2)
            {
                if (playerDest.Item1 > playerPos.Item1)
                {
                    return Direction.Right;
                }
                else { return Direction.Left; }
            } else if (playerPos.Item1 == playerDest.Item1 && playerPos.Item2 != playerDest.Item2)
            {
                if (playerDest.Item2 > playerPos.Item2)
                {
                    return Direction.Down;
                } else { return Direction.Up; }
            } else if (Math.Abs(playerPos.Item1 - playerDest.Item1) == Math.Abs(playerPos.Item2 - playerDest.Item2))
            {
                if ((playerDest.Item1 < playerPos.Item1) && (playerDest.Item2 < playerPos.Item2))
                {
                    return Direction.UpLeft;
                } else if ((playerDest.Item1 < playerPos.Item1) && (playerDest.Item2 > playerPos.Item2))
                {
                    return Direction.DownLeft;
                } else if ((playerDest.Item1 > playerPos.Item1) && (playerDest.Item2 < playerPos.Item2))
                {
                    return Direction.UpRight;
                } else
                {
                    return Direction.DownRight;
                }
            } else if (Math.Abs(playerPos.Item1 - playerDest.Item1) == 1 && Math.Abs(playerPos.Item2 - playerDest.Item2) == 2 ||
                Math.Abs(playerPos.Item1 - playerDest.Item1) == 2 && Math.Abs(playerPos.Item2 - playerDest.Item2) == 1)
            {
                if ((playerDest.Item1 < playerPos.Item1) && (playerDest.Item2 < playerPos.Item2))
                {
                    if (Math.Abs(playerDest.Item2 - playerPos.Item2) == 2)
                    {
                        return Direction.KMUpLeft;
                    } else
                    {
                        return Direction.KMLeftUp;
                    }
                }
                else if ((playerDest.Item1 < playerPos.Item1) && (playerDest.Item2 > playerPos.Item2))
                {
                    if (Math.Abs(playerDest.Item2 - playerPos.Item2) == 2)
                    {
                        return Direction.KMDownLeft;
                    }
                    else
                    {
                        return Direction.KMLeftDown;
                    }
                }
                else if ((playerDest.Item1 > playerPos.Item1) && (playerDest.Item2 < playerPos.Item2))
                {
                    if (Math.Abs(playerDest.Item2 - playerPos.Item2) == 2)
                    {
                        return Direction.KMUpRight;
                    }
                    else
                    {
                        return Direction.KMRightUp;
                    }
                }
                else
                {
                    if(Math.Abs(playerDest.Item2 - playerPos.Item2) == 2)
                    {
                        return Direction.KMDownRight;
                    }
                    else
                    {
                        return Direction.KMRightDown;
                    }
                }
            }
            else
            {
                return Direction.NoMove;
            }
        }

        //This function updates the view based on the model. See additional comments for further detail
        public void UpdateView(int xPos, int yPos, PictureBox currentSquare, List<List<PictureBox>> allPictureBoxes, TextBox moveCount, bool undo = false)
        {
            // Empty square logic
            if (currentSquare.Image == null)
            {
                MessageBox.Show("You cannot move to an empty square.");
                return;
            }
            else
            {
                Tuple<int, int> destSquare = new Tuple<int, int>(xPos, yPos);
                Tuple<int, int> playerPos = GetPlayerPosition();
                // Same square logic
                bool samePosition = destSquare.Equals(playerPos);
                if (samePosition == true && undo is false)
                {
                    MessageBox.Show("You are already on this square");
                }
                else
                {
                    UpdatePlayerDestination(xPos, yPos);
                    PictureBox prevPosBox = DetPlayerPos(allPictureBoxes);
                    Direction moveDir = DetMove();
                    Part part = Part.PlayerOnEmpty;
                    // No moves made
                    if (undo is true && (GetMoveCount() >= 0))
                    {
                        // Do nothing
                    }
                    else
                    {
                        // King move logic
                        part = WhatsAt(playerPos.Item1 + 1, playerPos.Item2 + 1);
                        if (part == Part.PlayerOnKing && ((Math.Abs(xPos - playerPos.Item1) > 1) | (Math.Abs(yPos - playerPos.Item2) > 1)))
                        {
                            MessageBox.Show("A king can only move one square, please try again");
                            return;
                        }
                        else
                        {
                            // Invalid move logic
                            try
                            {
                                Move(moveDir);
                            }
                            catch (InvalidOperationException)
                            {
                                MessageBox.Show("You have made an invalid move, please try again");
                                return;
                            }
                        }
                    }
                    PictureBox actualPosBox = DetPlayerPos(allPictureBoxes);
                    // Undo move logic
                    if (actualPosBox != currentSquare && undo is false)
                    {
                        UndoMove();
                    }
                    else
                    {
                        part = WhatsAt(playerPos.Item1 + 1, playerPos.Item2 + 1);
                        ImageSetter(part, prevPosBox);
                        part = WhatsAt(xPos + 1, yPos + 1);
                        ImageSetter(part, currentSquare);
                        moveCount.Text = GetMoveCount().ToString();
                        CheckGameFinished();
                    }
                }
            }

        }

        //This determines where in the 2D list that the player is located and return the approriate picturebox
        public PictureBox DetPlayerPos(List<List<PictureBox>> allPictureBoxes)
        {
            Tuple<int, int> playerPos = GetPlayerPosition();
            if (playerPos.Item1 == 0)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][0];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][0];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][0];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][0];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][0];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][0];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][0];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][0];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 1)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][1];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][1];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][1];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][1];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][1];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][1];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][1];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][1];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 2)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][2];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][2];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][2];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][2];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][2];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][2];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][2];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][2];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 3)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][3];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][3];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][3];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][3];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][3];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][3];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][3];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][3];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 4)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][4];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][4];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][4];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][4];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][4];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][4];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][4];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][4];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 5)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][5];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][5];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][5];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][5];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][5];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][5];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][5];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][5];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 6)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][6];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][6];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][6];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][6];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][6];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][6];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][6];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][6];
                }
                else
                {
                    return null;
                }
            }
            else if (playerPos.Item1 == 7)
            {
                if (playerPos.Item2 == 0)
                {
                    return allPictureBoxes[0][7];
                }
                else if (playerPos.Item2 == 1)
                {
                    return allPictureBoxes[1][7];
                }
                else if (playerPos.Item2 == 2)
                {
                    return allPictureBoxes[2][7];
                }
                else if (playerPos.Item2 == 3)
                {
                    return allPictureBoxes[3][7];
                }
                else if (playerPos.Item2 == 4)
                {
                    return allPictureBoxes[4][7];
                }
                else if (playerPos.Item2 == 5)
                {
                    return allPictureBoxes[5][7];
                }
                else if (playerPos.Item2 == 6)
                {
                    return allPictureBoxes[6][7];
                }
                else if (playerPos.Item2 == 7)
                {
                    return allPictureBoxes[7][7];
                }
                else
                {
                    return null;
                }
            }
            else
                return null;
        }
    }
}