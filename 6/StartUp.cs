namespace ex1_ex
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("/");

            List<Car> listofCars = new List<Car>();

            while (input[0] != "end")
            {
                Car car = new Car();

                car.Name = input[0];
                car.Model = input[1];
                car.Engine = input[2];

                listofCars.Add(car);

                input = Console.ReadLine().Split("/");
            }

            foreach (var car in listofCars.OrderBy(x => x.Name).ThenBy(x => x.Model).ToList())
            {
                Console.WriteLine($"Car - {car.Name} {car.Model} with engine {car.Engine}.");
            }
        }
    }

    class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
    }
}
