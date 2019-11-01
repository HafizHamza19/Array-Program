using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        public int NumberofStuden;
        public string[] FirstName;
        public string[] LastName;
        public Double[] Exams = new double[3];
        public Double[] Lab = new double[5];
        String[] Studentrecord;
        int number;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.readdata();

        }
       public void readdata()
        {
            Console.WriteLine("Please Enter Number Of Student");
            NumberofStuden = Int32.Parse(Console.ReadLine());
            FirstName = new string[NumberofStuden];
            LastName = new string[NumberofStuden];
            Studentrecord = new string[NumberofStuden];
            for (int i = 0; i < NumberofStuden; i++)
            {
                
                number = i + 1;
                Console.WriteLine("                     Student No " +number);
                Console.WriteLine("Please Enter First Name");
                FirstName[i] = Console.ReadLine();
                Console.WriteLine("Please Enter Last Name");
                LastName[i] = Console.ReadLine();
                
                for (int j = 0; j < 3; j++)
                {
                    number = j + 1;
                    Console.WriteLine("Please Enter Exams "+number+" Record");
                    Exams[j] = Double.Parse(Console.ReadLine());
                    //Studentrecord[j+2] =  Exams[j].ToString();
                }
                for (int k = 0; k < 5; k++)
                {
                    number = k + 1;
                    Console.WriteLine("Please Enter Lab " + number + " Record");
                    Lab[k] = Double.Parse(Console.ReadLine());
                   // Studentrecord[k + 5] = Lab[k].ToString();
                }
                Studentrecord[i] = FirstName[i] + ", " + LastName[i] + "          " + Exams[0] + "      " + Exams[1] + "      " + Exams[2] + "      " + Lab[0] + "      " + Lab[1] + "      " + Lab[2] + "      " + Lab[3] + "      " + Lab[4];
                                
            }
            Program prog = new Program();
           for (int h = 0; h < NumberofStuden; h++)
            {
             prog.DisplayRecord(Studentrecord[h]);
            }  
            
           //for(int t=0;t<NumberofStuden;t++)
           //{
           //    StudentInformation studentinfo = new StudentInformation(LastName[t], FirstName[t], Exams[0], Exams[1], Exams[2], Lab[0], Lab[1], Lab[2], Lab[3], Lab[4]);
           //}
                
            Console.ReadLine();
        }

        void sorting()
        {
        }
        void searchHighestGrade()
        {
        }
        void DisplayRecord(String Stdrecord)
        {
            Boolean con=true;
            if (con)
            {
                Console.WriteLine("\n\nLast Name, First Name   Exam1   Exam2   Exam3   Lab1   Lab2   Lab3   Lab4   Lab5");
                con = false;
            }
            Console.WriteLine(Stdrecord);
        }
    }
}
