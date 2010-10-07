using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ScoreKeeper
{
    [DataContract]
    public class Player : IPlayer
    {
        public Player(int playerID)
        {
            ID = playerID;
        }

        [DataMember]
        public int ID { get; private set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Score> ScoreList { get; set; }
        [DataMember]
        public Score HighScore { get; set; }
    }
}