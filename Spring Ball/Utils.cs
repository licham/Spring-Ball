using System.Collections.Generic;

namespace Spring_Ball
{
    public class Utils
    {
        public class State
        {
            public int Count { get; set; } = 0;
            public float Radius { get; set; } = 0;
            public float Time { get; set; } = 0;
            public float TimeInterval { get; set; } = 0;
            public float Fading { get; set; } = 0;
            public float Width { get; set; } = 0;
            public List<float> Speeds { get; set; } = new List<float>();
            public List<float> Coefficients { get; set; } = new List<float>();
            public List<float> Masses { get; set; } = new List<float>();
            public List<float> Positions { get; set; } = new List<float>();
            public List<float> StartPositions { get; set; } = new List<float>();
            public List<float> BalancedPositions { get; set; } = new List<float>();
            public List<float> MaxRightPositions { get; set; } = new List<float>();
            public List<float> MaxLeftPositions { get; set; } = new List<float>();

            public State Clone()
            {
                var state = new State()
                {
                    Count = Count,
                    Radius = Radius,
                    Time = Time,
                    TimeInterval = TimeInterval,
                    Fading = Fading,
                    Width = Width,
                    Speeds = new List<float>(Speeds),
                    Coefficients = new List<float>(Coefficients),
                    Masses = new List<float>(Masses),
                    Positions = new List<float>(Positions),
                    StartPositions = new List<float>(StartPositions),
                    BalancedPositions = new List<float>(BalancedPositions),
                    MaxRightPositions = new List<float>(MaxRightPositions),
                    MaxLeftPositions = new List<float>(MaxLeftPositions)
                };
                return state;
            }
        }

        public static List<float> GetValueList(int value, int count)
        {
            var list = new List<float>(count);
            for (var i = 0; i < count; ++i)
            {
                list.Add(value);
            }
            return list;
        }
    }
}
