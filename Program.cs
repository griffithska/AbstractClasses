using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicle vehicle = new Vehicle(); //can't do this anymore because it is abstract

            Chevrolet chevy = new Chevrolet();
            Volkswagen vw = new Volkswagen();

            chevy.Make = "Chevrolet";
            chevy.Model = "Equinox";
            chevy.Color = "Blue";

            vw.Make = "Volkswagen";
            vw.Model = "Jetta";
            vw.Color = "Grey";

            System.Console.WriteLine($"The {chevy.Make} {chevy.Model} is {chevy.Color}");

            chevy.Start();
            chevy.Drive();
            chevy.Turn();
            chevy.Park();
            chevy.Stop();

            System.Console.WriteLine($"The {vw.Make} {vw.Model} is {vw.Color}");

            vw.Start();
            vw.Drive();
            vw.Turn();
            vw.Park();
            vw.Stop();

        }
    }
}
