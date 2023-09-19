using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Coo;

namespace TheFirmV2.Model.Coo_Admin.Manager_Admin
{
    internal class GarbageMan : Manager
    {
        #region Fields
        private bool _hasGarbageTruck;
        #endregion Fields
        #region Constructors
        internal GarbageMan(string firstName, string lastName, decimal salary, bool hasGarbageTruck) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _hasGarbageTruck = hasGarbageTruck;
        }
        #endregion Constructors
        #region Properties
        internal bool HasGarbageTruck
        {
            get { return _hasGarbageTruck; }
            set { _hasGarbageTruck = value; }
        }
        #endregion Propeties
        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nDrives Garbage Truck: {_hasGarbageTruck}";
        }
        #endregion Methods
    }
}
