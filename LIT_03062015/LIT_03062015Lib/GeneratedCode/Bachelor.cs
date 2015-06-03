﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace University
{
    public class Bachelor : Degree
    {
        private Bachelor()
            : this(null, 0, 0, null)
        { }

        public Bachelor(string name, int start, int end)
            : this(name, start, end, null)
        {
            this.CourseList = new List<Course>();
        }
        public Bachelor(string name, int start, int end, List<Course> list)
        {
            this.DegreeName = name;
            this.StartYear = start;
            this.EndYear = end;
            this.CourseList = list;
        }
    }
}
