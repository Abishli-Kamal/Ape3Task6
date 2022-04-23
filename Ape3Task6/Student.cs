using System;
using System.Collections.Generic;
using System.Text;

namespace Ape3Task6
{
    internal class Student
    {
        public int Id { get; set; }
        public static int count = 0;
        public string Subject { get; set; }
        public string Fullname { get; set; }
        public int Number ;
        public static int num=1000;
        
     
        public string GroupName
        {
            get
            {
                
                return Subject[0].ToString() + Subject[1].ToString().ToUpper() + Number.ToString();
            }
        }

        public Student(string fullname, string subject)
        {
            num++;   
            Number=num;
            count++;
            Id = count;
            Fullname = fullname;
            Subject = subject;

        }
    }
}
