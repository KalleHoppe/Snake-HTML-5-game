using System.Collections.Generic;

namespace ScoreKeeper
{
    public interface IPlayer
    {
        Score HighScore { get; set; }
        string Name { get; set; }
        List<Score> ScoreList { get; set; }
    }
}