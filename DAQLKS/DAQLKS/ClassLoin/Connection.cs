﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQLKS
{
    internal class Connection
    {
        private static string stringConnection = "Data Source=DESKTOP-F68SOUJ\\SQLEXPRESS;Initial Catalog=PTTKHDT;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
