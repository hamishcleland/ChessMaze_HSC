using System;
using System.Collections.Generic;

namespace ChessMaze_Final
{
    public interface IGame
    {
        void Move(Direction moveDirection);
        int GetMoveCount();
        void Undo();
        void Restart();
        bool IsFinished();
        void Load(string newLevel, List<int> playerMoveListXAxis, List<int> playerMoveListYAxis, int moveCount);
        void Load(string newLevel);
        Tuple<int, int> GetPlayerPosition();
        Tuple<int, int> GetPlayerDestination();
        void UpdatePlayerDest(int x, int y);
        Part WhatsAt(int row, int column);
        int GetColumnCount();
        int GetRowCount();
        public GameFile ExportGameData();
        public void ImportGameData(GameFile file);
    }
}
