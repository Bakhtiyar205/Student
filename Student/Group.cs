using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class Group
    {

        public string Name;
        public static int groupNum = 100;
        
        public Group(string n)
        {
            Name = n;
            groupNum++;
            Console.WriteLine(n.Substring(0, 1) + groupNum);
        }
    }
}
