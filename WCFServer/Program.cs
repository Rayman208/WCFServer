using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using StockLibrary;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceHost host = new ServiceHost(typeof(Stock), new Uri("http://localhost:53284/Stock"));
            //host.AddServiceEndpoint(typeof(IStock), new BasicHttpBinding(),"");

            ServiceHost host = new ServiceHost(typeof(Stock));
            host.Open();

            Console.WriteLine("Сервер запущен!");
            Console.WriteLine("Для окончания работы нажмите любую клавишу");
            Console.ReadKey();

            host.Close();
        }
    }
}
