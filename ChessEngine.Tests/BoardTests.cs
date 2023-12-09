using ChessEngine.Core;
using ChessEngine.Core.Board;
using ChessEngine.Core.Enums;

namespace ChessEngine.Tests
{
    public class BoardTests
    {
        [Fact]
        public void CreateGameSessionCheckAllTilesAreCorrect()
        {
            BoardTile[,] tiles = new GameSession().GetBoardTiles();

            Assert.Equal(BoardTileColor.White, tiles[0, 0].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[0, 1].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[0, 2].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[0, 3].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[0, 4].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[0, 5].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[0, 6].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[0, 7].TileColor);

            Assert.Equal(BoardTileColor.Black, tiles[1, 0].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[1, 1].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[1, 2].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[1, 3].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[1, 4].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[1, 5].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[1, 6].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[1, 7].TileColor);

            Assert.Equal(BoardTileColor.White, tiles[2, 0].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[2, 1].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[2, 2].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[2, 3].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[2, 4].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[2, 5].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[2, 6].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[2, 7].TileColor);

            Assert.Equal(BoardTileColor.Black, tiles[3, 0].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[3, 1].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[3, 2].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[3, 3].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[3, 4].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[3, 5].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[3, 6].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[3, 7].TileColor);

            Assert.Equal(BoardTileColor.White, tiles[4, 0].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[4, 1].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[4, 2].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[4, 3].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[4, 4].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[4, 5].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[4, 6].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[4, 7].TileColor);

            Assert.Equal(BoardTileColor.Black, tiles[5, 0].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[5, 1].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[5, 2].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[5, 3].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[5, 4].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[5, 5].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[5, 6].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[5, 7].TileColor);

            Assert.Equal(BoardTileColor.White, tiles[6, 0].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[6, 1].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[6, 2].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[6, 3].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[6, 4].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[6, 5].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[6, 6].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[6, 7].TileColor);

            Assert.Equal(BoardTileColor.Black, tiles[7, 0].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[7, 1].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[7, 2].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[7, 3].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[7, 4].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[7, 5].TileColor);
            Assert.Equal(BoardTileColor.Black, tiles[7, 6].TileColor);
            Assert.Equal(BoardTileColor.White, tiles[7, 7].TileColor);
        }
    }
}