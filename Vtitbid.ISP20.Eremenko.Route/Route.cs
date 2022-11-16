using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Route
{
    internal class Route
    {
        public string From;
        public string To;
        public string Number;

        public Route(string from, string to, string number)
        {
            From = from;
            To = to;
            Number = number;
        }

        public override string ToString()
        {
            return $"Начальный маршрут: {From}, Конечный маршрут: {To}, Номер маршрута: {Number}";
        }
    }
}
