using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    /// <summary>
    /// This class only reads.
    /// </summary>
    internal class Read
    {
        /// <summary>
        ///  This GoNext method just waits for the user to hit any key.
        /// </summary>
        internal void GoNext()
        {
            Console.ReadKey();
        }
    }
}
