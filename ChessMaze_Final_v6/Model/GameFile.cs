using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessMaze_Final
{
    public class GameFile : IFiler
    {
        public string name { get; set; }
        
        private List<List<Part>> _exportBoard = new List<List<Part>>();
        public List<List<Part>> ExportBoard
        {
            get { return _exportBoard; }
            set { _exportBoard = value; }
        }

        private List<int> _exportPlayerMoveListXAxis = new List<int>();
        public List<int> ExportPlayerMoveListXAxis
        {
            get { return _exportPlayerMoveListXAxis; }
            set { _exportPlayerMoveListXAxis = value; }
        }

        private List<int> _exportPlayerMoveListYAxis = new List<int>();
        public List<int> ExportPlayerMoveListYAxis
        {
            get { return _exportPlayerMoveListYAxis; }
            set { _exportPlayerMoveListYAxis = value; }
        }

        public string ReturnStringBoard()
        {
            string stringBoard = "";
            foreach (List<Part> line in _exportBoard)
            {
                foreach (Part n in line)
                {
                    stringBoard += (char)n;
                }
                stringBoard += "\n";
            }
            stringBoard = stringBoard.Remove(stringBoard.Length - 1);
            return stringBoard;
        }

        public int exportMoveCount { get; set; }

        public string Load(string filename)
        {
            string _level = "Filler Text";
            return _level;
        }

        public void Save(string filename)
        {
            
        }
    }
}
