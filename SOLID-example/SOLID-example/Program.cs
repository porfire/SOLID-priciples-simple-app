// See https://aka.ms/new-console-template for more information
using SOLID_example;

class Program
{
    static void Main(string[] args)
    {
        var menuLoader = new CsvMenuLoader();
        var vendingMachine = new VendingMachine(menuLoader);
        vendingMachine.Start();
    }
}