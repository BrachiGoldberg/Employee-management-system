﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Core.Entites
{
    public class Position
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<EmployeePosition> Employees { get; set; }

    }
}
