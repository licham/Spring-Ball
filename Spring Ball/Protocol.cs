using System;
using System.IO;
using System.Collections.Generic;

namespace Spring_Ball
{
    public class Protocol
    { 
        public void Update(Utils.State state)
        {
            var format = "{0, -20}";
            var list = new List<string>(2 * state.Count + 1) {
                state.Time.ToString()
            };

            for (var i = 0; i < state.Count; ++i)
            {
                format = format.Insert(format.Length, "{" + (2 * i + 1).ToString() + ", -20}{" + (2 * i + 2).ToString() + ", -20}");
                list.Add(state.Positions[i].ToString());
                list.Add(state.Speeds[i].ToString());
            }

            writer.WriteLine(format, list.ToArray());
            writer.Flush();

            format = "";
            var list_max_left_positions = new List<string>(state.Count);
            var list_max_right_positions = new List<string>(state.Count);

            for (var i = 0; i < state.Count; ++i)
            {
                format = format.Insert(format.Length, "{" + i.ToString() + ", -20}");
                list_max_left_positions.Add("Куля" + i.ToString() + ": " + state.MaxLeftPositions[i].ToString());
                list_max_right_positions.Add("Куля" + i.ToString() + ": " + state.MaxRightPositions[i].ToString());
            }

            var positions_writer = new StreamWriter("QuickPositions.txt");
            positions_writer.WriteLine("Максимальні праві відхилення:");
            positions_writer.WriteLine(format, list_max_right_positions.ToArray());
            positions_writer.WriteLine();
            positions_writer.WriteLine("Максимальні ліві відхилення:");
            positions_writer.WriteLine(format, list_max_left_positions.ToArray());
            positions_writer.Close();
        }

        public void Start(Utils.State state)
        {
            writer = new StreamWriter("QuickProtocol.txt");
            var format = "";
            var masses_list = new List<string>(state.Count);
            var start_positions_list = new List<string>(state.Count);
            var coefficients_list = new List<string>(state.Count + 1);
            var lengths_list = new List<string>(state.Count + 1);
            var header_list = new List<string>(2 * state.Count + 1) {
                "Час"
            };

            for (var i = 0; i < state.Count; ++i)
            {
                format = format.Insert(format.Length, "{" + i.ToString() + ", -20}");
                masses_list.Add("m" + i.ToString() + " = " + state.Masses[i].ToString());
                start_positions_list.Add("x" + i.ToString() + " = " + state.StartPositions[i].ToString());
                coefficients_list.Add("c" + i.ToString() + " = " + state.Coefficients[i].ToString());
                lengths_list.Add("l" + i.ToString() + " = " + (state.BalancedPositions[i] - (i == 0 ? 0 : state.BalancedPositions[i - 1])).ToString());
                header_list.Add("x" + i.ToString());
                header_list.Add("v" + i.ToString());
            }

            writer.WriteLine($"Інтервал оновлення системи = {state.TimeInterval}");
            writer.WriteLine();

            writer.WriteLine($"Коефіціент супротиву = {state.Fading}");
            writer.WriteLine();

            writer.WriteLine($"Кількість куль = {state.Count}  Розмір куль = {state.Radius}");
            writer.WriteLine();

            writer.WriteLine("Маси куль:");
            writer.WriteLine(format, masses_list.ToArray());
            writer.WriteLine();

            writer.WriteLine("Початкові відхилення куль:");
            writer.WriteLine(format, start_positions_list.ToArray());
            writer.WriteLine();

            format = format.Insert(format.Length, "{" + state.Count.ToString() + ", -20}");

            coefficients_list.Add("c" + state.Count.ToString() + " = " + state.Coefficients[state.Count].ToString());
            writer.WriteLine("Коефіціенти жорсткості пружин:");
            writer.WriteLine(format, coefficients_list.ToArray());
            writer.WriteLine();

            lengths_list.Add("l" + state.Count.ToString() + " = " + (state.Width - state.BalancedPositions[state.Count - 1]).ToString());
            writer.WriteLine("Довжини пружин:");
            writer.WriteLine(format, lengths_list.ToArray());
            writer.WriteLine();

            for (var i = state.Count + 1; i < 2 * state.Count + 1; ++i)
            {
                format = format.Insert(format.Length, "{" + i.ToString() + ", -20}");
            }
            writer.WriteLine(format, header_list.ToArray());

            writer.Flush();
        }

        public void Stop() => writer.Close();

        public Utils.State Load(string path, Protocol protocol, Form3 plotter)
        {
            var reader = new StreamReader(path);
            var state = new Utils.State();

            var line = reader.ReadLine();
            float.TryParse(line.Substring(line.IndexOf('=') + 2), out var temp);
            state.TimeInterval = temp;
            reader.ReadLine();

            line = reader.ReadLine();
            float.TryParse(line.Substring(line.IndexOf('=') + 2), out temp);
            state.Fading = temp;
            reader.ReadLine();

            line = reader.ReadLine();
            float.TryParse(line.Substring(line.IndexOf('=') + 2, 2), out temp);
            state.Count = (int)temp;
            float.TryParse(line.Substring(line.LastIndexOf('=') + 2), out temp);
            state.Radius = temp;
            reader.ReadLine();

            reader.ReadLine();
            var s_masses = reader.ReadLine().Split("m".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            state.Masses = new List<float>(state.Count);
            for (var i = 0; i < state.Count; ++i)
            {
                float.TryParse(s_masses[i].Substring(s_masses[i].IndexOf('=') + 2), out temp);
                state.Masses.Add(temp);
            }
            reader.ReadLine();

            reader.ReadLine();
            var s_start_positions = reader.ReadLine().Split("x".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            state.StartPositions = new List<float>(state.Count);
            for (var i = 0; i < state.Count; ++i)
            {
                float.TryParse(s_start_positions[i].Substring(s_start_positions[i].IndexOf('=') + 2), out temp);
                state.StartPositions.Add(temp);
            }
            reader.ReadLine();

            reader.ReadLine();
            var s_coefficients = reader.ReadLine().Split("c".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            state.Coefficients = new List<float>(state.Count + 1);
            for (var i = 0; i < state.Count + 1; ++i)
            {
                float.TryParse(s_coefficients[i].Substring(s_coefficients[i].IndexOf('=') + 2), out temp);
                state.Coefficients.Add(temp);
            }
            reader.ReadLine();

            reader.ReadLine();
            var s_lengths = reader.ReadLine().Split("l".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            state.BalancedPositions = new List<float>(state.Count);
            for (var i = 0; i < state.Count; ++i)
            {
                float.TryParse(s_lengths[i].Substring(s_lengths[i].IndexOf('=') + 2), out temp);
                state.BalancedPositions.Add((i == 0 ? 0 : state.BalancedPositions[i - 1]) + temp);
            }
            float.TryParse(s_lengths[state.Count].Substring(s_lengths[state.Count].IndexOf('=') + 2), out temp);
            state.Width = state.BalancedPositions[state.Count - 1] + temp;
            reader.ReadLine();

            reader.ReadLine();

            plotter.Count = state.Count;
            plotter.TimeInterval = state.TimeInterval;
            plotter.Start();

            state.MaxLeftPositions = new List<float>(state.StartPositions);
            state.MaxRightPositions = new List<float>(state.StartPositions);
            state.Positions = new List<float>(state.StartPositions);
            state.Speeds = Utils.GetValueList(0, state.Count);
            protocol.Start(state);

            while (!reader.EndOfStream)
            {
                var sinfo = reader.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                state.Time += state.TimeInterval;
                state.Positions = new List<float>(state.Count);
                state.Speeds = new List<float>(state.Count);
                for (var i = 0; i < state.Count; ++i)
                {
                    float.TryParse(sinfo[i * 2 + 1], out temp);
                    state.Positions.Add(temp);
                    if (state.Positions[i] > state.MaxRightPositions[i])
                    {
                        state.MaxRightPositions[i] = state.Positions[i];
                    }
                    if (state.Positions[i] < state.MaxLeftPositions[i])
                    {
                        state.MaxLeftPositions[i] = state.Positions[i];
                    }
                    float.TryParse(sinfo[i * 2 + 2], out temp);
                    state.Speeds.Add(temp);
                }
                protocol.Update(state);
                plotter.Update(state.Positions);
            }

            reader.Close();
            return state;
        }

        private StreamWriter writer;
    }
}
