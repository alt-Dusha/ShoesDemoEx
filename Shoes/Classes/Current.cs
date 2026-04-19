using Shoes.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Classes
{
    public static class Current
    {
        public static User CurrentUser { get; set; }
    }
}
