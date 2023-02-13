using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"my car sounds like {engineNoise}" );
        }
        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"my car horn sounds like {honkNoise}");
        }
    }
}

