using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    internal class Cfo : Ceo
    {
        #region Fields
        private string _cfoId;
        #endregion Fields
        #region Constructors
        internal Cfo(string firstName, string lastName, decimal salary) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
        }
        internal Cfo(string firstName, string lastName, decimal salary, string cfoId) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _cfoId = cfoId;
        }
        #endregion Constructors
        #region Properties
        internal string cfoId
        {
            get { return _cfoId; }
            set { _cfoId = value; }
        }
        #endregion Propeties

        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nCfoId: {_cfoId}";
        }
        #endregion Methods
    }
}
