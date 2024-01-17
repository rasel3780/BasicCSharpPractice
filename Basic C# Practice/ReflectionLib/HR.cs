namespace ReflectionLib
{
    public class HR : IModule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public HR()
        {
            Id = Guid.NewGuid();
            Name = "Accounting";
        }

        public void Start()
        {
            Console.WriteLine("HR start");
        }
    }
}
