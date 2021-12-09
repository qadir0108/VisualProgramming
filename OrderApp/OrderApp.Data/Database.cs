using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Data
{
    public sealed class Database
    {
        public static readonly string ConnectionString = @"Server=QADIR\SQLEXPRESS;Database=OrderApp;Trusted_Connection=True;";
    }
}
