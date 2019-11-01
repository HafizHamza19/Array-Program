using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class StudentInformation
    {

        public StudentInformation(String Fname, String Lname, Double exams1, Double exams2, Double exams3, Double labs1, Double labs2, Double lab3, Double labs4, Double labs5)
        {
            Console.WriteLine("\n\nLast Name, First Name   Exam1   Exam2   Exam3   Lab1   Lab2   Lab3   Lab4   Lab5");
            Console.WriteLine(Lname + ", " + Fname + "          " + exams1 + "      " + exams2 + "      " + exams3 + "      " + labs1 + "      " + labs2 + "      " + lab3 + "      " + labs4 + "    " + labs5);
        }
    }
}
