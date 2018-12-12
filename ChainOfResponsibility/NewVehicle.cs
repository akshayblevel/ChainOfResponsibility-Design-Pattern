using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class NewVehicle
    {
        protected NewVehicle process;

        public void SetProcess(NewVehicle process)
        {
            this.process = process;
        }

        public abstract void Proceed(string request);
    }
}
