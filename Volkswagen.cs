namespace AbstractClasses
{
    public class Volkswagen : Vehicle
    {
        public string Color  { get; set; }

        public override void Drive()
        {
            System.Console.WriteLine("The VW is driving");
        }

        public override void Start()
        {
            System.Console.WriteLine("The VW has started");
        }

        public override void Park()
        {
            System.Console.WriteLine("The VW has parked");
        }

        public override void Turn()
        {
            System.Console.WriteLine("The VW has turned");
        }

    }
}