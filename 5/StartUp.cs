namespace ex5_lab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();

            string[] customers = Console.ReadLine().Split();

            while (customers[0] != "end")
            {

                Customer customer = new Customer();

                customer.FirstName = customers[0];
                customer.LastName = customers[1];
                customer.OrdersName = customers[2];
                customer.StatusName = customers[3];

                foreach (var cus in customerList)
                {
                    if (customer.FirstName == cus.FirstName && customer.LastName == cus.LastName) 
                    {
                        cus.OrdersName = customer.OrdersName;
                        cus.StatusName = customer.StatusName;

                        customerList.RemoveAt(customerList.FindIndex(a => a.FirstName == cus.FirstName));
                        customerList.Add(customer);
                        Console.WriteLine("CHANGED-------------");
                    }
                    
                    
                }
                customerList.Add(customer);
                Console.WriteLine("ADDED------------");

                customers = Console.ReadLine().Split();

            }

            string statuesToPrint = Console.ReadLine();

            foreach (Customer n in customerList.Where(m => m.StatusName == statuesToPrint))
            {

                Console.WriteLine($"{n.FirstName} {n.LastName} has {n.OrdersName} orders.");

            }
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrdersName { get; set; }
        public string StatusName { get; set; }
    }
}
