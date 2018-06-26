using System;
using System.Collections.Generic;
using Exam.entity;

namespace Exam
{
    class Program
    {
        static List<Product> list = new List<Product>();

        static void Main(string[] args)
        {
            GenerateMenu();
        }

        public static void GenerateMenu()
        {
            int choice;
            string deleteID;
            while (true)
            {
                Console.WriteLine("Product Manager");
                Console.WriteLine("================");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by ID");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                choice =  Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Product ID: ");
                        string productId = Console.ReadLine();
                        Console.WriteLine("Enter Product Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price: ");
                        string price = Console.ReadLine();
                        Product product = new Product(productId, name, price);
                        list.Add(product);
                        break;
                    case 2:
                        Console.WriteLine("{0, -20} {1, -10} {2, -10}", "Product ID", "Product Name", "Price");
                        foreach (var product2 in list)
                        {
                            Console.WriteLine("{0, -20} {1, -10} {2, -10}", product2.ProductId, product2.Name, product2.Price);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter ID of the Product you want to delete: ");
                        deleteID = Console.ReadLine();
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].ProductId == deleteID)
                            {
                                list.RemoveAt(i);
                                break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Good Bye");
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}