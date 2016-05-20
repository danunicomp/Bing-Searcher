using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;

namespace bing
{

    class clsSearch
    {

        public int NumberOfSearchItems = 0;
        public List<string> searchitems = new List<string>();

        public List<string> ReadSearchList()
        {
            string line;
            this.NumberOfSearchItems = 0;
            StreamReader sr = new StreamReader("SearchTestList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Length > 0 && !line.StartsWith(" ") && NumberOfWords(line) > 1)
                {
                    line = StripLine(line);
                    this.searchitems.Add(line);
                    ++this.NumberOfSearchItems;
                }
            }
            sr.Close();
            return null;
        }

        // this overload reads the raw list. No clean up.
        public List<string> ReadSearchList(int mode)
        {
            string line;
            this.NumberOfSearchItems = 0;
            StreamReader sr = new StreamReader("SearchTestList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Length > 0)
                {
//                    line = StripLine(line);
                    this.searchitems.Add(line);
                    ++this.NumberOfSearchItems;
                }
            }
            sr.Close();
            return null;
        }

        public void WriteSeachList(StringCollection list)
        {
            StreamWriter sw = new StreamWriter("SearchTestList.txt");
            foreach(string line in list)
            {
                sw.WriteLine(line);
            }

            sw.Close();
            return;
        }
        
        private int NumberOfWords(string Line)
        {
            int WordCount = 0;
            WordCount = Line.Trim().Split(' ').Count();

            return (WordCount);
        }

        private string StripLine(string sLine)
        {
            sLine = sLine.Replace(",", "");
            sLine = sLine.Replace(".", "");
            sLine = sLine.Replace(";", "");
            sLine = sLine.Replace("!", "");
            sLine = sLine.Replace("?", "");
            return (sLine);
        }

        //////////////////////////////////
    }

}
