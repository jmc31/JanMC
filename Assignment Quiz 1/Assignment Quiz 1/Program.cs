using System;

namespace AssQuiz1
{

   public class Person
    {

        public string Name { get; set; }
    
        public int Weight { get; set; }

        public int Age { get; set; }
    
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            while (true)
            {
                Console.WriteLine("Enter new data? [Y/N?]");

                if (Console.ReadLine() == "N")
                {
                    break;
                }

                Person person1 = new Person();

                Console.Write("Enter Person's Name = ");
                person1.Name = Console.ReadLine();

                Console.Write("Enter Person's Weight = ");
                person1.Weight = int.Parse(Console.ReadLine());

                Console.Write("Enter Person's Age = ");
                person1.Age = int.Parse(Console.ReadLine());

                list.Add(person1);

            }//end while
                
            list.ForEach(x =>
                    {
                        Console.WriteLine(x.Name);
                        Console.WriteLine(x.Weight);
                        Console.WriteLine(x.Age);
                        Console.WriteLine("---------------");
                    });
        }//end main
    
    
    
    }//end class program




}//end namespace