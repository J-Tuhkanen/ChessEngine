using ChessEngine.Core;
using ChessEngine.Core.Board;
using ChessEngine.Core.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine.Tests
{
    public class PiecesTests
    {
        [Fact]
        public void KnightTakesAKnigthMoveByAnnotationTest()
        {
            GameSession gameSession = new GameSession();
            IEnumerable<BoardTile> tiles = gameSession.GetBoardTiles().Cast<BoardTile>();
            
            gameSession.MovePiece("g1", "f3");
            gameSession.MovePiece("b8", "c6");
            gameSession.MovePiece("f3", "d4");
            gameSession.MovePiece("c6", "d4");

            int countOfKnightsOnBoard = tiles.Count(t => t.ChessPiece is Knight);

            Assert.Equal(3, countOfKnightsOnBoard);
        }

        [Fact]
        public void KnightTakesAKnigthMoveByCoordinatesTest()
        {
            GameSession gameSession = new GameSession();
            IEnumerable<BoardTile> tiles = gameSession.GetBoardTiles().Cast<BoardTile>();
           
            gameSession.MovePiece(Tuple.Create(6, 7), Tuple.Create(5, 5)); // Nf3
            gameSession.MovePiece(Tuple.Create(1, 0), Tuple.Create(2, 2)); // Nc6
            gameSession.MovePiece(Tuple.Create(5, 5), Tuple.Create(3, 4)); // Nd4
            gameSession.MovePiece(Tuple.Create(2, 2), Tuple.Create(3, 4)); // Nxd4

            int countOfKnightsOnBoard = tiles.Count(t => t.ChessPiece is Knight);

            Assert.Equal(3, countOfKnightsOnBoard);
        }

        [Fact]
        public void InitializePiecesAndCountThem()
        {
            GameSession gameSession = new GameSession();
            IEnumerable<BoardTile> tiles = gameSession.GetBoardTiles().Cast<BoardTile>();

            var tilesWithPieces = tiles.Where(t => t.ChessPiece != null);

            Assert.Equal(2, tilesWithPieces.Count(t => t.ChessPiece is Queen));
            Assert.Equal(2, tilesWithPieces.Count(t => t.ChessPiece is King));
            Assert.Equal(4, tilesWithPieces.Count(t => t.ChessPiece is Rook));
            Assert.Equal(4, tilesWithPieces.Count(t => t.ChessPiece is Bishop));
            Assert.Equal(4, tilesWithPieces.Count(t => t.ChessPiece is Knight));
            Assert.Equal(16, tilesWithPieces.Count(t => t.ChessPiece is Pawn));
        }
    }
}
