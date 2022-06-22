using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SimpleOOP
{
    class ManagerNameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class ManagerNameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class ManagerSurnameDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class ManagerSurnameAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class ManagerSalaryAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class ManagerSalaryDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Manager && y is Manager)
            {
                return ((Manager) y).Salary.CompareTo(((Manager) x).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
    class ManagerBirthDateAscComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }
    }
    class ManagerBirthDateDescComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Manager && y is Manager)
            {
                return ((Manager)y).BirthDate.CompareTo(((Manager)x).Salary);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    //Name ASC - DESC
    //Surname ASC - DESC
    //Salary  ASC - DESC
    //BirthDate ASC - DESC
}
