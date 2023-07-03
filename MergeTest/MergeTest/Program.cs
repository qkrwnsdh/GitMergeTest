using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rular rular = new Rular(10);
            rular.Run();
        }
    }

    public class Rular
    {
        private const float ONE_INCH = 2.54F;

        public int Centimeter { get; set; } = 0;

        public float Inch
        {
            get { return Centimeter * ONE_INCH; }

            // {    2023.   07. 03      Add private _SetInch function   /   people3
            private set { this._SetInch(value); }
        }

        public Rular(int cmValue) { Centimeter = cmValue; }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {this.Inch}inch 입니다.");
        }

        private void _SetInch(float inchValue) { Centimeter = (int)(inchValue / ONE_INCH); }
        // }    2023.   07. 03      Add private _SetInch function   /   people3
    }
}
