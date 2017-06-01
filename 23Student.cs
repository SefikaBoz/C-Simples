# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PErson
{
    class Student : IPersonInformation
    {
        private string firstAndLastName, ePosta, phone;
        public int ExamGrade { get; set; }

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

    }
}
