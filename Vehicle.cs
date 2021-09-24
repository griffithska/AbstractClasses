namespace AbstractClasses
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        
        public string Model  {get; set; }

        public virtual void Start()
        {
            System.Console.WriteLine("Vehicle has started");
        }

        public void Stop()
        {
            System.Console.WriteLine("Vehicle has stopped");
        }
        
        public abstract void Drive();

        public abstract void Park();

        public virtual void Turn()
        {
            System.Console.WriteLine("The vehicle has turned");
        }

    }
}