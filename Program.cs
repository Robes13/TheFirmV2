using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Controller;
using TheFirmV2.Model;
using TheFirmV2.View;

namespace TheFirmV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating new Controller object and running start method.
            MainController mainController = new MainController();
            mainController.Start();
        }
    }
}
