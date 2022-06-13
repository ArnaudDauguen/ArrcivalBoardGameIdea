using BoardGameIdea.Entities;
using static BoardGameIdea.Entities.Helper;
using static BoardGameIdea.Entities.Helper.TileType;

namespace BoardGameIdea.Tests.HelperTest;

public class PatternMatchTest
{
    [Test]
    public void TestPatternMatchOne()
    {
        TileType[,] board = new TileType[,]
        {
            { EMPTY, BLACK, BLACK },
            { WHITE, EMPTY, WHITE }
        };
        bool[,] pattern = new bool[,]
        {
            { true, true }
        };
        Assert.IsTrue(CanPatternWork(board, pattern, 0, 1, BLACK));
    }

    [Test]
    public void TestPatternMatchTwo()
    {
        TileType[,] board = new TileType[,]
        {
            { EMPTY, BLACK, WHITE },
            { WHITE, EMPTY, BLACK }
        };
        bool[,] pattern = new bool[,]
        {
            { true, false },
            { false, true },
        };
        Assert.IsTrue(CanPatternWork(board, pattern, 0, 1, BLACK));
    }
    [Test]
    public void TestPatternMatchBig()
    {
        TileType[,] board = new TileType[,]
        {
            { EMPTY, EMPTY, WHITE, BLACK, BLACK },
            { EMPTY, WHITE, EMPTY, EMPTY, EMPTY },
            { EMPTY, EMPTY, EMPTY, EMPTY, EMPTY },
            { EMPTY, WHITE, EMPTY, EMPTY, EMPTY },
            { EMPTY, EMPTY, EMPTY, EMPTY, EMPTY }
        };
        bool[,] pattern = new bool[,]
        {
            { false, true },
            { true, false},
            { false, false},
            { true, false},
        };
        Assert.IsTrue(CanPatternWork(board, pattern, 0, 1, WHITE));
    }
}