using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            NewVehicle selection = new SelectVehicle();
            NewVehicle payment = new MakePayment();
            NewVehicle serviceBook = new GenerateServiceBook();
            NewVehicle insurance = new Insurance();
            NewVehicle delivery = new Delivery();

            selection.SetProcess(payment);
            payment.SetProcess(serviceBook);
            serviceBook.SetProcess(insurance);
            insurance.SetProcess(delivery);

            selection.Proceed("Honda Splendor");

            Console.ReadLine();
        }
    }
}
