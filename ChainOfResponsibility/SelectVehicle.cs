using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class SelectVehicle : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Vehicle Selection Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while selecting vehicle.");
                process = null;
            }
        }
    }
}
