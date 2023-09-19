using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Coo;

namespace TheFirmV2.Model.Coo_Admin.Manager_Admin
{
    internal class PantWorker : Manager
    {
        #region Fields
        private bool _knowsBottles;
        #endregion Fields
        #region Constructors
        internal PantWorker(string firstName, string lastName, decimal salary, bool knowsBottles) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _knowsBottles = knowsBottles;
        }
        #endregion Constructors
        #region Properties
        internal bool KnowsBottles
        {
            get { return _knowsBottles; }
            set { _knowsBottles = value; }
        }
        #endregion Propeties
        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nKnows different type of bottles: {_knowsBottles}";
        }
        #endregion Methods
    }
}
