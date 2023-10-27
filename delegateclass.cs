using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateMyDelegate
{
   
    public class delegateclass
    {
        public delegate void CallBack(int i);
        public void MethodA(CallBack obj)
        {
            for (int i = 0; i < 1000; i++) 
            {
                obj(i);
            }
        }
       
    }
}
