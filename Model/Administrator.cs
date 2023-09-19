using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    internal class Administrator : Ceo
    {
        #region Fields
        private bool _isAdmin;
        #endregion Fields
        #region Constructors
        internal Administrator(string firstName, string lastName, decimal salary, bool isAdmin) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _isAdmin = isAdmin;
        }
        #endregion Constructors
        #region Properties
        internal bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }
        #endregion Propeties
        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nIs Administrator: {_isAdmin}";
        }
        #endregion Methods
    }
}
