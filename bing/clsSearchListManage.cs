using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bing
{
    class clsSearchListManage
    {
        
        public Boolean HasChanged = false;      // keep track of if list changed and needs changed

        private int NumberOfWordsInLine(string Line)
        {
            int WordCount = 0;
            Line = Line.Trim();
            Line = Line.TrimStart();
            Line = Line.TrimEnd();
            WordCount = Line.Trim().Split(' ').Count();

            return (WordCount);
        }
    }
}
