﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMarks
{
    class Marks
    {
        public void InputData()
        {
            var InputData = new[]
            {
                new {StudentId=1001, Name="Johan", English=89, Math=97, Sub1=85},
                new {StudentId=1002, Name="Scoot", English=40, Math=90, Sub1=70},
                new {StudentId=1003, Name="Ben", English=80, Math=40, Sub1=75}
            };

            Console.WriteLine("Student ID\t Name\t\t English\t Math\t\t Sub1\t\t Overall");

            int TotalStudent = InputData.Count();
            int TotalPass = 0;
            int TotalFail = 0;
            int TgA = 0;
            int TgB = 0;
            int TgC = 0;
            int TgF = 0;

            Grade Gr = new Grade();

            foreach (var a in InputData)
            {
                string En = Gr.Grades(a.English);
                string Mt = Gr.Grades(a.Math);
                string S1 = Gr.Grades(a.Sub1);
                int Avg = (a.English + a.Math + a.Sub1) / 3;
                string Ov = "";

                if (a.English < 50 || a.Math < 50 || a.Sub1 < 50)
                {
                    Ov = Gr.Grades(0);
                }
                else
                {
                    Ov = Gr.Grades(Avg);
                }


                //English
                //if (a.English > 80)
                //{
                //    En = "A";
                //}
                //else if (a.English >= 70)
                //{
                //    En = "B";
                //}
                //else
                //{
                //    En = "F";
                //}

                //Math
                //if (a.Math > 80)
                //{
                //    Mt = "A";
                //}
                //else if (a.Math >= 70)
                //{
                //    Mt = "B";
                //}
                //else
                //{
                //    Mt = "F";
                //}


                //Sub1
                //if (a.Sub1 > 80)
                //{
                //    S1 = "A";
                //}
                //else if (a.Sub1 >= 70)
                //{
                //    S1 = "B";
                //}
                //else
                //{
                //    S1 = "F";
                //}


                //Overall
                //if ((a.English + a.Math + a.Sub1) / 3 > 80)
                //{
                //    Ov = "A";
                //}
                //else if ((a.English + a.Math + a.Sub1) / 3 >= 70)
                //{
                //    Ov = "B";
                //}
                //else
                //{
                //    Ov = "F";
                //}


                //Total pass or fail
                if((a.English + a.Math + a.Sub1) / 3 >= 50)
                {
                    TotalPass++;
                }
                else
                {
                    TotalFail++;
                }


                //Total Grade
                if (Avg >= 85)
                {
                    TgA++;
                }
                else if (Avg >= 70)
                {
                    TgB++;
                }
                else if (Avg >= 50)
                {
                    TgC++;
                }
                else
                {
                    TgF++;
                }

                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t {4}\t {5}", a.StudentId.ToString().PadRight(10), a.Name.PadRight(10), En.PadRight(10), Mt.PadRight(10), S1.PadRight(10), Ov);

            };

            Console.WriteLine("_______________________________________________________________________________________");

            Console.WriteLine("Total pass: {0}", TotalPass);
            Console.WriteLine("Total fail: {0}", TotalFail);

            Console.WriteLine("{0}% passed, {1}% failed", (TotalPass*100)/ TotalStudent, (TotalFail*100)/ TotalStudent);

            Console.WriteLine("{0} student achived A", TgA);
            Console.WriteLine("{0} student achived B", TgB);
            Console.WriteLine("{0} student achived C", TgC);
            Console.WriteLine("{0} student achived F", TgF);
        }//m_InputData
    }//c
}//ns
