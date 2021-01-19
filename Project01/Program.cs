using System;

namespace Project01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BackPack testBackPack = new BackPack();
            Console.WriteLine("Test Back Packs current total weight: {}",
                               testBackPack.GetTotalWeight());

            // Main pocket tests
            if(testBackPack.InsertItemsInMainPocket(10.1))
            {
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("Item was not added successfully");
            }

            if (testBackPack.InsertItemsInMainPocket(8.79))
            {
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("Item was not added successfully");
            }

            // Right pocket test
            if (testBackPack.InsertItemsRightPocket(5.4))
            {
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("Item was not added successfully");
            }

            if (testBackPack.InsertItemsRightPocket(3.67))
            {
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("Item was not added successfully");
            }

            // Left pocket test
            if (testBackPack.InsertItemsLeftPocket(10.1))
            {
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("Item was not added successfully");
            }

            if (testBackPack.InsertItemsLeftPocket(2.39))
            {
                Console.WriteLine("Item added successfully");
            }
            else
            {
                Console.WriteLine("Item was not added successfully");
            }

            Console.WriteLine("Total weight in Test Back Pack is: {}",
                testBackPack.GetTotalWeight());


            Console.WriteLine("Hello World!");
        }
    }
}
