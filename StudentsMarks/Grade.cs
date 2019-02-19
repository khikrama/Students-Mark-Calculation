using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsMarks
{
    class Grade
    {
        
        string Grd = "";
        public string Grades(int Numb)
        {
            if(Numb >= 85)
            {
                Grd = "A";
            }
            else if(Numb >= 70)
            {
                Grd = "B";
            }
            else if(Numb >= 50)
            {
                Grd = "C";
            }
            else
            {
                Grd = "F";
            }

            return Grd;
        }
    }
}
