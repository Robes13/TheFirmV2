using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model;
using TheFirmV2.Model.Coo;
using TheFirmV2.Model.Coo_Admin.Manager_Admin;
using TheFirmV2.View;

namespace TheFirmV2.Controller
{
    /// <summary>
    /// This class runs the entire program.
    /// </summary>
    internal class MainController
    {
        public void Start()
        {
            // Adding all the employees into our program.
            Ceo ceo = new Ceo("Robert", "Pedersen", 90000, true, true, "1304");
            Cooo coo = new Cooo("Jens","Andersen", 68000, "1812");
            Cfo cfo = new Cfo("Jonas", "Knudsen", 70000, "2709");
            HR hr = new HR("Nicklas", "Jensen", 75000, true);
            Administrator administrator = new Administrator("Tue", "Jürs", 60000, true);
            Manager manager = new Manager("Simon", "Willander", 58000, "2909");
            GarbageMan garbageMan = new GarbageMan("Anders", "Mikkelsen", 48000, true);
            PantWorker pantWorker = new PantWorker("Catja", "Pedersen", 28000, true);
            Cashier cashier = new Cashier("Jesper", "Hansen", 24000, true);
            Employee employeeDina = new Employee("Dina", "Jensen", 30000);
            Employee employeeRikke = new Employee("Rikke", "Gertrud", 60000);
            Employee employeeSigne = new Employee("Signe", "Birke", 28000);

            // Creating new printEmployee object.
            PrintEmployees printEmployees = new PrintEmployees();

            // Printing everything.
            printEmployees.PrintCeo(ceo);
            printEmployees.PrintCoo(coo);
            printEmployees.PrintCfo(cfo);
            printEmployees.PrintHr(hr);
            printEmployees.PrintAdmin(administrator);
            printEmployees.PrintManager(manager);
            printEmployees.PrintGarbageMan(garbageMan);
            printEmployees.PrintPantWorker(pantWorker);
            printEmployees.PrintCashier(cashier);
            printEmployees.PrintEmployee(employeeDina);
            printEmployees.PrintEmployee(employeeRikke);
            printEmployees.PrintEmployee(employeeSigne);

            // Creating read object.
            Read read = new Read();
            read.GoNext();
        }
    }
}
