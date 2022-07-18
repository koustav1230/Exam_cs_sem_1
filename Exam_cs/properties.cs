//Write the program which will implement the concept of properties in c#.
//Demonstrate Read only, Write only and auto implemented property.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_cs
{
    internal class properties
    {
        private int _passMarks = 35;
        private int _id;
        private string _name;


        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("ID Can Not Be Negative Value");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Student Name Can Not Be Empty");
                }
                else
                {
                    _name =Name;
                }

            }
        }

        public int PassMarks
        {
            get
            {
                return _passMarks;
            }
        }


        public string City
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
