using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_OOP
{
    /// <summary>
    /// Администратор сервера
    /// использованный паттерн Singleton
    /// </summary>
    class Admin
    {
        public static Admin single = null;

        protected Admin() { }

        public static Admin Create()
        {
            if(single == null)
                single = new Admin();

            return single;
        }
    }
}
