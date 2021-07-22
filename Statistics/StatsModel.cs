using System;
using System.Collections.Generic;


namespace Statistics
{
    public class computedStats
    {
        public float average { get; set; }
        public float min { get; set; }
        public float max { get; set; }

        public computedStats()
        {
            this.average = float.NaN;
            this.min = float.NaN;
            this.max = float.NaN;
        }
    }

}
