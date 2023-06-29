using CarRentalConsoleApp.Entities;
using System.Globalization;

namespace CarRentalConsoleApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter rental data:");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup date (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return date (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}