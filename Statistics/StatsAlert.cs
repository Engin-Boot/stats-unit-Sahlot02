using System.Collections.Generic;


namespace Statistics
{
    public class StatsAlerter
    {
        float maxThreshold;
        IAlert[] Allalerters;

        public StatsAlerter(float maxThreshold, IAlert[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.Allalerters = alerters;
        }

        public void checkAndAlert(List<float> numbers)
        {
            computedStats computedStatsValues = StatsComputer.CalculateStatistics(numbers);
            if (computedStatsValues.max > maxThreshold)
            {
                for(int i = 0; i < Allalerters.Length; i++)
                {
                    Allalerters[i].Alert();
                }
            }
        }
    }
}