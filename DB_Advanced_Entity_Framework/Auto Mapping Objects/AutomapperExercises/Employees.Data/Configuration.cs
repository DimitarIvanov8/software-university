﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Data
{
    public static class Configuration
    {
        public static string ConnectionString =>
            @"Server=.;Database=EmployeesDb;Integrated Security=True";
    }
}
