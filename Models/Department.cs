﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentEmployees.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DeptName { get; internal set; }
    }
}
