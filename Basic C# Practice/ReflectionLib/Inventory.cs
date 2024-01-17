namespace ReflectionLib
{
    public class Inventory: IModule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Inventory()
        {
            Id = Guid.NewGuid();
            Name = "Accounting";
        }

        public void Start()
        {
            Console.WriteLine("Inventory start");
        }
    }
}
