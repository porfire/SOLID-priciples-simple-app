using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_example
{
    public class VendingMachine : IVendingMachine
    {

        private IMenuLoader _menuLoader;
        public VendingMachine(IMenuLoader menuLoader)
        {
            _menuLoader = menuLoader;
        }
        public void SayHello()
        {
            Console.WriteLine("Please enter your name");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello Dear {userName}! How are you? \n");
        }

        public void TellTime()
        {
            var currentTime = DateTime.Now;
            Console.WriteLine($"Current time is {currentTime:d} at {currentTime:t}");
        }

        public void DisplayMenu()
        {

            //read menu
            var products = _menuLoader.LoadMenu();

            //show menu
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }

        public void SayBye()
        {
            Console.Write($"Press any key to exit...");
            Console.ReadKey(true);
        }

        public void Start()
        {
            SayHello();
            TellTime();
            DisplayMenu();
            SayBye();
        }
    }
}
