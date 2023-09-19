using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model;
using TheFirmV2.Model.Coo;
using TheFirmV2.Model.Coo_Admin.Manager_Admin;

namespace TheFirmV2.View
{
    /// <summary>
    /// This class is responsible for handling everything gui related.
    /// </summary>
    internal class PrintEmployees
    {
        internal void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"Employee\n{employee.ToString()}\n");
        }
        internal void PrintCeo(Ceo ceo)
        {
            Console.WriteLine($"Ceo\n{ceo.ToString()}\n");
        }
        internal void PrintCoo(Cooo coo)
        {
            Console.WriteLine($"Coo\n{coo.ToString()}\n");
        }
        internal void PrintManager(Manager manager)
        {
            Console.WriteLine($"Manager\n{manager.ToString()}\n");
        }
        internal void PrintGarbageMan(GarbageMan garbageMan)
        {
            Console.WriteLine($"Garbage Man\n{garbageMan.ToString()}\n");
        }
        internal void PrintPantWorker(PantWorker pantWorker)
        {
            Console.WriteLine($"Pant Worker\n{pantWorker.ToString()}\n");
        }
        internal void PrintCashier(Cashier cashier)
        {
            Console.WriteLine($"Cashier\n{cashier.ToString()}\n");
        }
        internal void PrintHr(HR hr)
        {
            Console.WriteLine($"HR\n{hr.ToString()}\n");
        }
        internal void PrintAdmin(Administrator administrator)
        {
            Console.WriteLine($"Administrator\n{administrator.ToString()}\n");
        }
        internal void PrintCfo(Cfo cfo)
        {
            Console.WriteLine($"Cfo\n{cfo.ToString()}\n");
        }
    }
}
