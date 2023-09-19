using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model.Coo
{
    internal class Manager : Cooo
    {
        #region Fields
        private string _managerId;
        #endregion Fields
        #region Constructors
        internal Manager(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
        }
        internal Manager(string firstName, string lastName, decimal salary, string managerId) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _managerId = managerId;
        }
        #endregion Constructors
        #region Properties
        internal string ManagerId
        {
            get { return _managerId; }
            set { _managerId = value; }
        }
        #endregion Propeties

        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nManagerId: {_managerId}";
        }
        #endregion Methods
    }
}
