using System;
using System.Collections.Generic;
using System.ServiceModel.Activation;

namespace ScoreKeeper
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ScoreService : IScoreService
    {
        #region IScoreService Members

        public Player GetPlayer(string id)
        {
            return new Player(int.Parse(id));
        }

        public List<IScore> GetTopScores()
        {
            throw new NotImplementedException();
        }

        public bool SetScore(int score, int playerId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}