using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirmV2.Model
{
    internal class Ceo : Employee
    {
        #region Fields
        private bool _superAccountAccess;
        private bool _ownsFirm;
        private string _ceoId;
        #endregion Fields
        #region Constructors
        internal Ceo(string firstName, string lastName, decimal salary) : base (firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
        }
        internal Ceo(string firstName, string lastName, decimal salary, bool superAccountAcces, bool ownsFirm, string ceoId) : base(firstName, lastName, salary)
        {
            _firstName = firstName;
            _lastName = lastName;
            _salary = salary;
            _superAccountAccess = superAccountAcces;
            _ownsFirm = ownsFirm;
            _ceoId = ceoId;
        }
        #endregion Constructors

        #region Properties
        private bool SuperAccountAccess
        {
            get { return _superAccountAccess; }
            set { _superAccountAccess = value; }
        }

        private bool OwnsFirm
        {
            get { return _ownsFirm; }
            set { _ownsFirm = value; }
        }

        private string CeoId
        {
            get { return _ceoId; }
            set { _ceoId = value; }
        }
        #endregion Properties

        #region Methods
        public override string ToString()
        {
            return $"{base.ToString()}\nCeoId: {_ceoId}";
        }
        #endregion Methods
    }
}
