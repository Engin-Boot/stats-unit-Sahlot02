using System;
using System.Collections.Generic;

namespace Statistics
{
    public static class StatsComputer
    {
        public static computedStats CalculateStatistics(List<float> numbers)
        {
            computedStats computedStatsValue = new computedStats();
            if (numbers.Capacity == 0) return computedStatsValue;
            float average = 0;
            float min = float.MaxValue;
            float max = float.MinValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                average += numbers[i];

            }
            average = average / numbers.Count;
            computedStatsValue.average = average;
            computedStatsValue.max = max;
            computedStatsValue.min = min;
            return computedStatsValue;
        }
    }
}
