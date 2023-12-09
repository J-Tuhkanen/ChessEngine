using ChessEngine.Core.Enums;
using ChessEngine.Core.Pieces;

namespace ChessEngine.Core.Board
{
    public class BoardTile
    {
        public int TileId { get; }        
        public string TileName { get; }
        public ChessPiece? ChessPiece { get; internal set; }
        public BoardTileColor TileColor { get; }

        internal BoardTile(int tileId, string tileName, BoardTileColor color)
        {
            if(string.IsNullOrEmpty(tileName)) 
                throw new ArgumentNullException($"Argument missing {nameof(tileName)}");

            if (tileId <= 0)
                throw new ArgumentNullException($"Invalid id for argument for {nameof(BoardTile)}");

            TileId = tileId;
            TileName = tileName;
            TileColor = color;
        }
    }
}
