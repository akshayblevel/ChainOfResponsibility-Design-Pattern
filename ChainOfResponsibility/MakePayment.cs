using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class MakePayment : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Payment Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while doing payment.");
                process = null;
            }
        }
    }
}
