# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PErson
{
    class Lecturer : IPersonInformation,IEmployee
    {
        private string firstAndLastName, ePosta, phone, department, task;
        private int accountNumber, accountAmount;
        public string FirstAndLastName
        {
            get
            {
                return firstAndLastName;
            }
            set
            {
                firstAndLastName = value;
            }
        }
        public string EPosta
        {
            get
            {
                return ePosta;
            }
            set
            {
                ePosta = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string Task
        {
            get
            {
                return task;
            }
            set
            {
                task = value;
            }
        }
        public int AccountAmount
        {
            get
            {
                return accountAmount;
            }
            set
            {
                accountAmount = value;
            }
        }
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
    }
}
