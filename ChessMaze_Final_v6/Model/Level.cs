using System.Collections.Generic;

namespace ChessMaze_Final
{
    public class Level
    {

        private List<List<Part>> _board = new List<List<Part>>();
        public List<List<Part>> Board
        {
            get => _board;
            set => _board = value;
        }

        private int _xMapSize = 0;
        public int XMapSize
        {
            get => _xMapSize;
            set => _xMapSize = value;
        }

        private int _yMapSize = 0;
        public int YMapSize
        {
            get => _yMapSize;
            set => _yMapSize = value;
        }

        private string _mapName;
        public string MapName
        {
            get => _mapName;
            set => _mapName = value;
        }
    }
}
