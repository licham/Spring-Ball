using System;

namespace Spring_Ball
{
    public class Simulator
    {
        public Utils.State State { get; set; }

        public void Update()
        {
            State.Time += State.TimeInterval;

            // Calculate new Speeds
            if (State.Count > 1)
            {
                State.Speeds[0] += (-(State.Coefficients[0] + State.Coefficients[1]) * State.Positions[0] + State.Coefficients[1] * State.Positions[1] - State.Fading * State.Speeds[0]) / State.Masses[0] * State.TimeInterval;
                State.Speeds[State.Count - 1] += (State.Coefficients[State.Count - 1] * State.Positions[State.Count - 2] - (State.Coefficients[State.Count - 1] + State.Coefficients[State.Count]) * State.Positions[State.Count - 1] - State.Fading * State.Speeds[State.Count - 1]) / State.Masses[State.Count - 1] * State.TimeInterval;
            }
            else
            {
                State.Speeds[0] += (-(State.Coefficients[0] + State.Coefficients[1]) * State.Positions[0] - State.Fading * State.Speeds[0]) / State.Masses[0] * State.TimeInterval;
            }
            for (var i = 1; i < State.Count - 1; ++i)
            {
                State.Speeds[i] += (State.Coefficients[i] * State.Positions[i - 1] - (State.Coefficients[i] + State.Coefficients[i + 1]) * State.Positions[i] + State.Coefficients[i + 1] * State.Positions[i + 1] - State.Fading * State.Speeds[i]) / State.Masses[i] * State.TimeInterval;
            }

            // Calculate new Positions
            for (var i = 0; i < State.Count; ++i)
            {
                State.Positions[i] += State.Speeds[i] * State.TimeInterval;
                if (State.Positions[i] > State.MaxRightPositions[i])
                {
                    State.MaxRightPositions[i] = State.Positions[i];
                }
                if (State.Positions[i] < State.MaxLeftPositions[i])
                {
                    State.MaxLeftPositions[i] = State.Positions[i];
                }
            }

            // Check collisions
            if (0 > State.Positions[0] + State.BalancedPositions[0] - State.Radius)
            {
                State.Speeds[0] = Math.Abs(State.Speeds[0]);
                State.Positions[0] = State.Radius - State.BalancedPositions[0];
            }
            if (State.Positions[State.Count - 1] + State.BalancedPositions[State.Count - 1] + State.Radius > State.Width)
            {
                State.Speeds[State.Count - 1] = -Math.Abs(State.Speeds[State.Count - 1]);
                State.Positions[State.Count - 1] = State.Width - State.BalancedPositions[State.Count - 1] - State.Radius;
            }
            for (var i = 0; i < State.Count - 1; ++i)
            {
                if (State.Positions[i] + State.BalancedPositions[i] + State.Radius > State.Positions[i + 1] + State.BalancedPositions[i + 1] - State.Radius)
                {
                    var temp = State.Speeds[i + 1];
                    State.Speeds[i + 1] = (2 * State.Masses[i] * State.Speeds[i] + (State.Masses[i + 1] - State.Masses[i]) * State.Speeds[i + 1]) / (State.Masses[i] + State.Masses[i + 1]);
                    State.Speeds[i] = State.Speeds[i + 1] + temp - State.Speeds[i];

                    temp = State.Positions[i] + State.BalancedPositions[i] + State.Radius - (State.Positions[i + 1] + State.BalancedPositions[i + 1] - State.Radius);
                    State.Positions[i] -= temp / 2;
                    State.Positions[i + 1] += temp / 2;
                }
            }
        }
    }
}
