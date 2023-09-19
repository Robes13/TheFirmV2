using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    internal class HR : Ceo
    {
        #region Fields
        private bool _isHr;
        #endregion Fields
        #region Constructors
        internal HR(string firstName, string lastName, decimal salary, bool isHr) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _isHr = isHr;
        }
        #endregion Constructors
        #region Properties
        internal bool IsHr
        {
            get { return _isHr; }
            set { _isHr = value; }
        }
        #endregion Propeties
        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nIs a part of HR: {_isHr}";
        }
        #endregion Methods
    }
}
