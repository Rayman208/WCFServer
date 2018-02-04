using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using StockLibrary;



namespace WCFServer
{
    class Stock : IStock
    {
        public double GetCurrentRubleCourse()
        {
            Console.WriteLine(OperationContext.Current.RequestContext.RequestMessage);

            System.Threading.Thread.Sleep(5000);
            
            return 56.04;
        }
    }
}
