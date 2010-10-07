using System;
using System.Runtime.Serialization;

namespace ScoreKeeper
{
    [DataContract]
    public class Score : IScore
    {
        public Score(int id, DateTime date)
        {
            ID = id;
            Date = date;
        }

        #region IScore Members

        [DataMember]
        public int ID { get; private set; }
        [DataMember]
        public DateTime Date { get; private set; }
        [DataMember]
        public int Value { get; set; }

        #endregion
    }
}