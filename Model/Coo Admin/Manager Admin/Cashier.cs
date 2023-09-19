using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFirmV2.Model.Coo;

namespace TheFirmV2.Model.Coo_Admin.Manager_Admin
{
    internal class Cashier : Manager
    {
        #region Fields
        private bool _hasProductScanner;
        #endregion Fields
        #region Constructors
        internal Cashier(string firstName, string lastName, decimal salary, bool hasProductScanner) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _hasProductScanner = hasProductScanner;
        }
        #endregion Constructors
        #region Properties
        internal bool HasProductScanner
        {
            get { return _hasProductScanner; }
            set { _hasProductScanner = value; }
        }
        #endregion Propeties
        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nHas Product Scanner: {_hasProductScanner}";
        }
        #endregion Methods
    }
}
