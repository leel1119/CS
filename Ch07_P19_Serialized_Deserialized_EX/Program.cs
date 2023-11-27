using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ch07_P19_Serialized_DeSerialized_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Serial_Scores serial_Scores = new Serial_Scores();
            Serial_Scores.DumpContents(serial_Scores.scores);
            serial_Scores.SaveScores();
            Console.WriteLine("--------------------------------");
            List<Score> readback_Scores = serial_Scores.LoadHighScores();
            Serial_Scores.DumpContents(readback_Scores);
            serial_Scores.LoadHighScores();
            Console.ReadLine();
        }
    }

    class Serial_Scores
    {
        public List<Score> scores = new List<Score>()
        {
            new Score("Andy", 12420, 15),
            new Score("Bill", 8865, 9),
            new Score("Carol", 20, 2)
        };

        public void SaveScores()
        {
            List<String> scoreStrings = new List<string>();
            foreach (var e in scores)
            {
                scoreStrings.Add($"{e.Name},{e.Point},{e.Level}");
            }
            File.WriteAllLines("Scores.csv", scoreStrings);
        }
        public List<Score> LoadHighScores()
        {
            string[] scoreStrings = File.ReadAllLines("Scores.csv");
            List<Score> scores = new List<Score>();
            foreach (var e in scoreStrings)
            {
                string[] tokens = e.Split(',');
                Score score = new Score(tokens[0], Convert.ToInt32(tokens[1]), Convert.ToInt32(tokens[2]));
                scores.Add(score);
            }
            return scores;
        }
        public static void DumpContents(List<Score> contents)
        {
            foreach (var e in contents)
            {
                Console.WriteLine($"{e.Name},{e.Point},{e.Level}");
            }
        }
    }

    public record Score(string Name, int Point, int Level);
}
