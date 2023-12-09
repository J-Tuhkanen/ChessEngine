using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessEngine.Core.Enums;

namespace ChessEngine.Core.Board
{
    public class ChessBoard
    {
        internal BoardTile[,] BoardTiles { get; } = new BoardTile[8, 8];

        internal ChessBoard()
        {
            var letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };

            int incerementingId = 1;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    var factor = (x + y) % 2;

                    BoardTileColor boardColor = x + y > 0 
                        ? (BoardTileColor)factor
                        : BoardTileColor.White;

                    BoardTiles[x, y] = new BoardTile(incerementingId++, $"{letters[x]}{8-y}", boardColor);
                }
            }
        }
    }
}
