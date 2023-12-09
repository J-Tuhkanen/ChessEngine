using ChessEngine.Core.Board;
using ChessEngine.Core.Enums;

namespace ChessEngine.Core.Pieces
{
    public abstract class ChessPiece
    {
        public ChessPieceColor Color { get; }

        internal ChessPiece(ChessPieceColor color)
        {
            Color = color;
        }

        internal virtual bool MoveTo(BoardTile toTile)
        {
            ChessPiece? pieceOnTheTile = toTile.ChessPiece;

            if (pieceOnTheTile != null)
            {
                // Takes.
                
            }

            toTile.ChessPiece = this;

            return true;
        }
    }
}
