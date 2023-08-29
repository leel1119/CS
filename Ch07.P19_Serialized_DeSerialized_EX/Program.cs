using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07_P19_Serialized_DeSerialized_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            Serial_Scores serial_Scores = new Serial_Scores();
            Serial_Scores.DumpContents(serial_Scores.scores);
            serial_Scores.SaveScores();
            Console.WriteLine("");
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