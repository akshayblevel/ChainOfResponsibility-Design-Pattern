using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Insurance : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Insurance Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while doing insurance.");
                process = null;
            }
        }
    }
}
