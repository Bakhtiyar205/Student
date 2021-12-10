using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class NewStudent
    {
        public string FullName;
        public static int N = 0;
        public NewStudent(string fullName)
        {
            FullName = fullName;
            
            N++;
            Console.WriteLine(N+" "+fullName );
        }
    }
}
