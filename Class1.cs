using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOp1
{
    internal class Class1
    {
        public int count(string text, string word)
        {
            
            int times = 0;
            int start = text.ToLower().IndexOf(word.ToLower());

            while (start != -1)
            {
                times++;
                start = text.ToLower().IndexOf(word.ToLower(), start + 1);
            }
            return times;

        }
    }
}
