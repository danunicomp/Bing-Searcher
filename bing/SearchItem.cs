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
            StreamReader sr = new StreamReader("SearchTestList.txt");
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Length > 0 && ! line.StartsWith(" "))
                {
                    this.searchitems.Add(line);
                    ++this.NumberOfSearchItems;
                }
            }

            return null;
        }
         

    }
}
