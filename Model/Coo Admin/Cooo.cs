using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    internal class Cooo : Ceo
    {
        #region Fields
        private string _cooId;
        #endregion Fields
        #region Constructors
        internal Cooo(string firstName, string lastName, decimal salary): base (firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
        }
        internal Cooo(string firstName, string lastName, decimal salary, string cooId): base (firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _cooId = cooId;
        }
        #endregion Constructors
        #region Properties
        internal string CooId
        {
            get { return _cooId; }
            set { _cooId = value; }
        }
        #endregion Propeties

        #region Methods
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}\nSalary: {_salary}\nCooId: {_cooId}";
        }
        #endregion Methods
    }
}
