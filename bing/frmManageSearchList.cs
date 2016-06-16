using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bing
{
    public partial class frmManageSearchList : Form
    {
        public Boolean HasChanged = false;

        clsSearch SearchList = new clsSearch();
        StringCollection DisplayList1 = new StringCollection();
        StringCollection LinesToAdd = new StringCollection();

        public frmManageSearchList()
        {
            InitializeComponent();
        }


        private void frmManageSearchList_Load(object sender, EventArgs e)
        {            
            SearchList.ReadSearchList(1);

            this.RefreshDisplay();

            foreach (string line in lstSearchList.Items)
            {
                DisplayList1.Add(line.ToString());
                //Console.WriteLine(line);
            }
            lblNumberOfLines.Text = lstSearchList.Items.Count.ToString();
        }

        private void btnCloseManageSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
           // Console.WriteLine(lstSearchList.SelectedIndex);
            int LineToDelete;
           // List<String> DisplayList;

            LineToDelete = lstSearchList.SelectedIndex;
            lstSearchList.Items.RemoveAt(LineToDelete);
            lstSearchList.Refresh();
            if (LineToDelete > lstSearchList.Items.Count-1)
            {
                LineToDelete = lstSearchList.Items.Count-1;
            }
            lstSearchList.SelectedIndex = LineToDelete;
            HasChanged = true;
        }
        
        private void btnSaveList_Click(object sender, EventArgs e)
        {

            DisplayList1.Clear();

            foreach (string line in lstSearchList.Items)
            {
                DisplayList1.Add(line.ToString());
            }

            SearchList.WriteSeachList(DisplayList1);
            HasChanged = false;
        }

        private void btnAddToSearch_Click(object sender, EventArgs e)
        {
            string NewLine;

            LinesToAdd.Clear();

            foreach(string newline in lstSearchList.Items)
            {
                LinesToAdd.Add(newline);
            }

            foreach (string newline in tboxAddToSearch.Lines)
            {
//                Console.WriteLine("Word Count: " + this.NumberOfWords(newline));
                if (newline.Length != 0 && this.NumberOfWords(newline) >= 1) { 
                    if (cmbCatagory.Text.Length != 0)
                    {
                        NewLine = cmbCatagory.Text + " " + newline;
                    }
                    else
                    {
                        NewLine = newline;
                    }
                    LinesToAdd.Add(NewLine);
                }
            }

      //      DisplayList1.AddRange(tboxAddToSearch.Lines);
            SearchList.WriteSeachList(LinesToAdd);

            this.RefreshDisplay();
        }

        private int NumberOfWords(string Line)
        {
            int WordCount = 0;
            Line = Line.Trim();
            Line = Line.TrimStart();
            Line = Line.TrimEnd();
            WordCount = Line.Trim().Split(' ').Count();

            return (WordCount);
        }

        private void RefreshDisplay()
        {
            lstSearchList.Items.Clear();
            SearchList.ReadSearchList();
            foreach (string line in SearchList.searchitems)
            {
                lstSearchList.Items.Add(line);

            }
        }
    }
}
