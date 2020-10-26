using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using uploadetsy.MyForm;

namespace uploadetsy.Action
{
    class CheckNullText
    {
        public static bool Check(String text , String error , Thread thread)
        {
            if (text.Length == 0)
            {
                FormMess.Show("Lỗi", error, false);
                thread.Abort();
                return false;
            }
            return true;
           
        }
    }
}
