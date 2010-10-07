using System;

namespace ScoreKeeper
{
    public interface IScore
    {
        int ID { get; }
        DateTime Date { get; }
        int Value { get; set; }
    }
}