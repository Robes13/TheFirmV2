using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    /// <summary>
    /// This is the super class Employee, because everybody is an employee.
    /// </summary>
    internal class Employee
    {
        #region Fields
        private protected string _firstName;
        private protected string _lastName;
        private protected decimal _salary;
        #endregion Fields

        #region Constructors
        protected internal Employee(string firstName, string lastName, decimal salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
        }
        #endregion Constructors

        #region Properties
        internal string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        internal string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        internal decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        #endregion Properties

        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}";
        }
        #endregion Methods
    }
}
