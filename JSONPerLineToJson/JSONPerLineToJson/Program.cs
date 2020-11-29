using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JSONPerLineToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var f in Directory.EnumerateFiles("/Users/nadiawood/Documents/GitHub/CourseProject/data"))
            {
                if (f.StartsWith(".")) continue;
                var lines = File.ReadAllLines(f);
                var output = new List<string>();
                output.Add("[");
                output.AddRange(lines.Select(line => line.ToLowerInvariant() + ","));

                string last = output[output.Count - 1];
                last = last.Substring(0, last.Length - 1);
                output[output.Count - 1] = last;

                output.Add("]");
                File.WriteAllLines(f.Replace("/data", "/data/converted"), output);
            }

        }
    }
}
