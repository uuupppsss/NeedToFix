using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp13.Model
{
    internal class DBManager
    {
        static DB context=new DB();
        public static DB Instance
        {
            get => context;
        }
    }
}
