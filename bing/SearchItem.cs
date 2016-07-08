using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace bing
{

    class SearchItem
    {
        public SearchItem()
        {

        }

        public int NumberOfSearchItems=0;
        public List<string> searchitems = new List<string>();



        public void DoASearch(string whatever)
        {

        }

        public List<string> ReadSearchList()
        {
            string line;
            this.NumberOfSearchItems = 0;
            this.searchitems.Clear();
            StreamReader sr = new StreamReader("SearchTestList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Length > 0 && ! line.StartsWith(" ") && NumberOfWords(line) > 1)
                {
                    line = StripLine(line);
                    this.searchitems.Add(line);
                    ++this.NumberOfSearchItems;
                }
            }
            sr.Close();
            return null;
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
           
        private int NumberOfWords(string Line)
        {
            int WordCount = 0;
            WordCount = Line.Trim().Split(' ').Count();
            
            return (WordCount);
        }
        public int SaveSearchList()
        {
            int line;
            StreamWriter sw = new StreamWriter("SearchTestList.txt");
            for (line=0; line <this.NumberOfSearchItems; ++line)
            {
                // Console.WriteLine(this.searchitems[line]);
                sw.WriteLine(this.searchitems[line]);
            }
            sw.Close();
            return(1);
        }

    }
}
