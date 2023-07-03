using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTest
{
    internal class Program
    {
        // {        2023.   07. 03. Modified class position / people1
        public class Rular
        {
            private const float ONE_INCH = 2.54F;

            public int Centimeter { get; set; } = 0;

            public float Inch
            {
                get { return Centimeter * ONE_INCH; }
                private set { Centimeter = (int)(value / ONE_INCH); }
            }

            public Rular(int cmValue) { Centimeter = cmValue; }

            public void Run()
            {
                Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
            }
        }
        // }        2023.   07. 03. Modified class position / people1

        static void Main(string[] args)
        {
            Rular rular = new Rular(10);
            rular.Run();
        }

    }
}
