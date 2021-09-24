namespace AbstractClasses
{
    public class Chevrolet : Vehicle
    {
        public string Color  { get; set; }

        public override void Drive()
        {
            System.Console.WriteLine("The Chevrolet is driving");
        }

        public override void Start()
        {
            System.Console.WriteLine("The Chevrolet has started");
        }

        public override void Park()
        {
            System.Console.WriteLine("The Chevrolet has parked");
        }

    }
}