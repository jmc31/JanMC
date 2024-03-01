using System;
using System.Collections.Generic;

namespace OrderingSystem
{
    class Program
    {
        static List<string> orderList = new List<string>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("___________________________________");
                Console.WriteLine("___________________________________");
                Console.WriteLine("Welcome to the Dokkaebi Bag!");
                Console.WriteLine("1. Add New Item");
                Console.WriteLine("2. View Order Summary");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddNewItem();
                        break;
                    case 2:
                        ViewOrderSummary();
                        break;
                    case 3:
                        PlaceOrder();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;
                }
            }
        }

        static void AddNewItem()
        {
            Console.Write("Please enter the item name: ");
            string newItem = Console.ReadLine();
            orderList.Add(newItem);
            Console.WriteLine("The Item has been added successfully!");
        }

        static void ViewOrderSummary()
        {
            Console.WriteLine("Your Order Summary:");
            if (orderList.Count == 0)
            {
                Console.WriteLine("There are no item/s in the order.");
            }
            else
            {
                for (int i = 0; i < orderList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {orderList[i]}");
                }
            }
        }

        static void PlaceOrder()
        {
            Console.WriteLine("Order Placed!");
            Console.WriteLine("Order Summary:");
            ViewOrderSummary();
            orderList.Clear();
        }
    }
}