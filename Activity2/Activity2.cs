using System;

namespace Activity2
{
    public class Car
    {
        public string Brand { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public void Honk(string stringVariable)
        {
            Console.WriteLine($"{stringVariable}: Honk!!");
        }
    }//end class car

    //main method
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> list = new List<Car>();

            while (true)
            {
                Console.WriteLine("Enter new data? [Y/N]");

                if (Console.ReadLine() == "N" || Console.ReadLine().ToLower() == "n")
                {
                    break;
                }//end if

                Car car1 = new Car();

                Console.Write("Enter Car Brand = ");
                car1.Brand = Console.ReadLine();

                Console.Write("Enter Car Color = ");
                car1.Color = Console.ReadLine();

                Console.Write("Enter Car Price = ");
                car1.Price = int.Parse(Console.ReadLine());

                list.Add(car1);
            }//end while loop



            list.ForEach(x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
            });
        }//end main
    }//end class Program
}//end namespace