# C-Simples


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAndEnumerations
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Lesson> Lessons { get; set; }
        public Field Field { get; set; }
        public decimal Average
        {
            get
            {
                decimal total = 0;
                foreach (Lesson note in Lessons)
                {
                    total += note.Average;
                }
                return total / Lessons.Count();
            }
        }
        public StudentStatus Status
        {
            get
            {
                if (Average >= 70)
                    return StudentStatus.Gecti;
                else if (Average >= 50)
                    return StudentStatus.SartliGecti;
                else
                    return StudentStatus.Kaldi;
            }
        }

    }
    struct Lesson
    {
        public string Name { get; set; }
        public decimal Exam1 { get; set; }
        public decimal Final { get; set; }
        public decimal Average
        {
            get
            {
                return Exam1 * 0.4m + Final * 0.6m;
            }
        }
    }
    enum Field
    {
        Digital,
        Verbal,
        Equalweight,
        Language
    }
    enum StudentStatus { Gecti, Kaldi, SartliGecti}

}
