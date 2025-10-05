
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("choose the name of your Laptop:");
            string name = Console.ReadLine();
            bool commanding = true;
            Laptop mypc = new Laptop("windows", "AMD",name);
            while (commanding){
                Console.Write($"Turn {name} ON? (Y/N)");
                string userResponse = Console.ReadLine().ToLower();
                while (userResponse != "y" && userResponse!="n")
                {
                    Console.Write("what to do with pc? (Y/N)");
                    userResponse = Console.ReadLine().ToLower();
                }
                mypc.Power(userResponse =="y");
                Console.WriteLine("continue?");
                commanding = (Console.ReadLine().ToLower() != "n");
            }
        }
    }
    class Laptop
    {
        public string OS { get; set; }
        public string CPUModel { get; set; }
        public string LaptopName { get; set; }
        static bool isON;
        public Laptop(string os, string cpu, string name)
        {
            OS = os;
            CPUModel = cpu;
            LaptopName = name;
            isON = false;
        }
        public void Power(bool start)
        {
            if (start && isON == false)
            {
                Console.WriteLine(LaptopName + " is Turning ON...");
                isON = true;
            }
            else if (start && isON)
            {
                Console.WriteLine(LaptopName + " is already ON");
            }
            else if (!start && isON == false)
            {
                Console.WriteLine(LaptopName + " is already OFF");
            }
            else if (!start && isON)
            {
                Console.WriteLine(LaptopName + " Is Turning OFF...");
                isON = false;
            }
            else
            {
                Console.WriteLine("Sorry! i didn't understand!");
            }
        }
    }
}