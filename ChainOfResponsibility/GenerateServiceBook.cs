using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class GenerateServiceBook : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Generating Service Book Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while generating service book.");
                process = null;
            }
        }
    }
}
