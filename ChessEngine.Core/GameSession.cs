using ChessEngine.Core.Board;
using ChessEngine.Core.Enums;
using ChessEngine.Core.Pieces;

namespace ChessEngine.Core
{
    public class GameSession
    {
        private readonly ChessBoard _board;
        private ChessPieceColor _currentPlayersTurn;

        public GameSession()
        {
            _currentPlayersTurn = ChessPieceColor.White;
            _board = new ChessBoard();
            InitializePieces();
        }

        public ChessPiece? GetPieceOnCoordinate(int x, int y)
            => _board.BoardTiles[x, y].ChessPiece;

        public BoardTile GetTileOnCoordinate(int x, int y)
            => _board.BoardTiles[x, y];

        public bool MovePiece(int fromTileId, int toTileId)
        {
            BoardTile? fromTile = null;
            BoardTile? toTile = null;

            foreach (BoardTile tile in _board.BoardTiles)
            {
                if (tile.TileId == fromTileId)
                {
                    fromTile = tile;
                    break;
                }
            }

            foreach (BoardTile tile in _board.BoardTiles)
            {
                if (tile.TileId == toTileId)
                {
                    toTile = tile;
                    break;
                }
            }

            return fromTile != null && toTile != null 
                ? MovePiece(fromTile, toTile) 
                : false;
        }

        public bool MovePiece(string fromTileNotation, string toTileNotation)
        {
            BoardTile? fromTile = null;
            BoardTile? toTile = null;

            foreach (BoardTile tile in _board.BoardTiles)
            {
                if (tile.TileName == fromTileNotation)
                {
                    fromTile = tile;
                    break;
                }
            }

            foreach (BoardTile tile in _board.BoardTiles)
            {
                if (tile.TileName == toTileNotation)
                {
                    toTile = tile;
                    break;
                }
            }

            return fromTile != null && toTile != null
                ? MovePiece(fromTile, toTile)
                : false;
        }

        public bool MovePiece(Tuple<int, int> fromTile, Tuple<int, int> toTile)
        {
            return MovePiece(_board.BoardTiles[fromTile.Item1, fromTile.Item2], _board.BoardTiles[toTile.Item1, toTile.Item2]);
        }

        private bool MovePiece(BoardTile fromTile, BoardTile toTile)
        {
            var tileOccupyingPiece = fromTile.ChessPiece;

            if (tileOccupyingPiece == null || 
                tileOccupyingPiece.Color != _currentPlayersTurn || 
                tileOccupyingPiece.MoveTo(toTile) == false)
                return false;

            fromTile.ChessPiece = null;

            CheckBoardState();
            ToggleTurn();

            return true;
        }

        private void CheckBoardState()
        {
            // Check for checks and or mates
        }

        private void ToggleTurn()
        {
            _currentPlayersTurn = _currentPlayersTurn == ChessPieceColor.Black 
                ? ChessPieceColor.White 
                : ChessPieceColor.Black;
        }

        private void InitializePieces()
        {
            InitializePawns();
            InitializeOfficers();
        }        

        private void InitializePawns() 
        {
            for(int i = 0; i < 8; i++)
            {
                _board.BoardTiles[i, 6].ChessPiece = new Pawn(ChessPieceColor.White);
                _board.BoardTiles[i, 1].ChessPiece = new Pawn(ChessPieceColor.Black);
            }
        }

        private void InitializeOfficers()
        {
            // White officers
            _board.BoardTiles[0, 7].ChessPiece = new Rook(ChessPieceColor.White);
            _board.BoardTiles[1, 7].ChessPiece = new Knight(ChessPieceColor.White);
            _board.BoardTiles[2, 7].ChessPiece = new Bishop(ChessPieceColor.White);
            _board.BoardTiles[3, 7].ChessPiece = new Queen(ChessPieceColor.White);
            _board.BoardTiles[4, 7].ChessPiece = new King(ChessPieceColor.White);
            _board.BoardTiles[5, 7].ChessPiece = new Bishop(ChessPieceColor.White);
            _board.BoardTiles[6, 7].ChessPiece = new Knight(ChessPieceColor.White);
            _board.BoardTiles[7, 7].ChessPiece = new Rook(ChessPieceColor.White);

            // Black officers
            _board.BoardTiles[0, 0].ChessPiece = new Rook(ChessPieceColor.Black);
            _board.BoardTiles[1, 0].ChessPiece = new Knight(ChessPieceColor.Black);
            _board.BoardTiles[2, 0].ChessPiece = new Bishop(ChessPieceColor.Black);
            _board.BoardTiles[3, 0].ChessPiece = new Queen(ChessPieceColor.Black);
            _board.BoardTiles[4, 0].ChessPiece = new King(ChessPieceColor.Black);
            _board.BoardTiles[5, 0].ChessPiece = new Bishop(ChessPieceColor.Black);
            _board.BoardTiles[6, 0].ChessPiece = new Knight(ChessPieceColor.Black);
            _board.BoardTiles[7, 0].ChessPiece = new Rook(ChessPieceColor.Black);
        }
        
        public BoardTile[,] GetBoardTiles() 
            => _board.BoardTiles;
    }
}
