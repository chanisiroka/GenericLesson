using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLesson
{
    class Check <T>
    {

        public bool Compare(T var1,T var2) {

            if (var1.Equals(var2))
                return true;
            return false;

        }
    }
}
