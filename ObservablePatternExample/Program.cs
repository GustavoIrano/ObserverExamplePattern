using System;
using System.Threading;

namespace ObservablePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var buck = new Observer("Buck");

            var phWater = new PhControl(RandomPh());

            phWater.Subscribe(buck);
            Console.WriteLine();

            do
            {
                phWater.PhValue = RandomPh();
                Thread.Sleep(1500);
            } while (phWater.PhValue != 34);

        }

        public static int RandomPh() 
        {
            return new Random().Next(0, 50);
        }
    }
}
