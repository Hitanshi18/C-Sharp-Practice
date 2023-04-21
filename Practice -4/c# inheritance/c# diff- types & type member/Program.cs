using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__diff__types___type_member
{
  public class Customer
        // class has 3 private field, 3 public property, 1 method
    {
        #region Fields
        private int _id;
        private string _firstname;
        private string _lastname;
        #endregion

        #region Properties
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        #endregion

        #region Methods
        public string GetFullNmae()
        {
            return this._firstname + " " + this._lastname;
        }
        #endregion
    }
}