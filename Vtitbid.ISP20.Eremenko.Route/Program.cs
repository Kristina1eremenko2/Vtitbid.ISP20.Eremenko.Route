using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Route
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Route[] route = new Route[3];

            for (int i = 0; i < route.Length; i++)
            {
                Console.WriteLine("Начальный пункт маршрута: ");
                string from = Console.ReadLine();
                Console.WriteLine("Конечный пункт маршрута: ");
                string to = Console.ReadLine();
                Console.WriteLine("Номер маршрута: ");
                string number = Console.ReadLine();
                route[i] = new Route(from, to, number);
            }
            Route[] routeSort = route.OrderBy(obj => obj.Number).ToArray();
            for (int i = 0; i < route.Length; i++)
            {
                Console.WriteLine(routeSort[i]);
            }
            Console.WriteLine("Поиск по номеру маршруту: ");
            string ser = Console.ReadLine();

            for (int i = 0; i < route.Length; i++)
            {
                if (ser.ToLower() == routeSort[i].Number.ToLower())
                {
                    Console.WriteLine(routeSort[i]);
                    break;
                }
                if (i == routeSort.Length - 1 && ser.ToLower() != routeSort[i].Number.ToLower())
                {
                    Console.WriteLine("Такого маршрута нет");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
