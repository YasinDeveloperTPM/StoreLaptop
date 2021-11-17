using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop
{
    class Store
    {
        public static void priceLapToP()
        {
            Console.WriteLine("Hello World Welcome To Stroe Laptop.How much money do you have:");
            int PriceLaptop = int.Parse(Console.ReadLine());

            if (PriceLaptop <= 100)
            {
                Console.WriteLine("What model of laptop you want:(Asus= 1,Lenovo= 2)");
                int ModelLaptop100 = int.Parse(Console.ReadLine());
                switch (ModelLaptop100)
                {
                    case 1:
                        {
                            Console.WriteLine("Rum Is : 4G");
                            Console.WriteLine("Hard Is : 250G");
                            Console.WriteLine("Grapgics Is : GTX");
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Rum Is : 4G");
                            Console.WriteLine("Hard Is : 500G");
                            Console.WriteLine("Grapgics Is : GTX");
                        }
                        break;
                }
            }

            if (PriceLaptop > 100 && PriceLaptop <= 200)
            {
                Console.WriteLine("What model of laptop you want:(Asus= 1,Lenovo= 2)");
                int ModelLaptop200 = int.Parse(Console.ReadLine());

                switch (ModelLaptop200)
                {
                    case 1:
                        {
                            Console.WriteLine("Rum Is : 4G");
                            Console.WriteLine("Hard Is : 500G");
                            Console.WriteLine("Grapgics Is : GTX");
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Rum Is : 8G");
                            Console.WriteLine("Hard Is : 500G");
                            Console.WriteLine("Grapgics Is : GTX");
                        }
                        break;
                }
            }

            if (PriceLaptop > 200 && PriceLaptop <= 300)
            {
                Console.WriteLine("What model of laptop you want:(Asus= 1,Lenovo= 2)");
                int ModelLaptop300 = int.Parse(Console.ReadLine());

                switch (ModelLaptop300)
                {
                    case 1:
                        {
                            Console.WriteLine("Rum Is : 8G");
                            Console.WriteLine("Hard Is : 500G");
                            Console.WriteLine("Grapgics Is : RTX");
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Rum Is : 16G");
                            Console.WriteLine("Hard Is : TG");
                            Console.WriteLine("Grapgics Is : GTX");
                        }
                        break;
                }
            }
        }
    }
}

