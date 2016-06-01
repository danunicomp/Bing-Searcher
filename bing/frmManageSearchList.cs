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

            //            for (int x=0; x< SearchList.searchitems.Count;++x)
            //            {
            //               
            //            }

            this.RefreshDisplay();

            foreach (string line in lstSearchList.Items)
            {
                DisplayList1.Add(line.ToString());
                //Console.WriteLine(line);
            }

        }


       

        private void btnCloseManageSearch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lstSearchList.SelectedIndex);
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

        }
        
        private void btnSaveList_Click(object sender, EventArgs e)
        {

            DisplayList1.Clear();

            foreach (string line in lstSearchList.Items)
            {
                DisplayList1.Add(line.ToString());
                //Console.WriteLine(line);
            }

            SearchList.WriteSeachList(DisplayList1);
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
                if (newline.Length != 0) { 
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
            /*

            lstSearchList.Items.Clear();
            foreach (string line in DisplayList1)
            {
                
                lstSearchList.Items.Add(line);

            }
            lstSearchList.Refresh();
            */
        }

        private void RefreshDisplay()
        {
            lstSearchList.Items.Clear();
            foreach (string line in SearchList.searchitems)
            {
                lstSearchList.Items.Add(line);

            }
        }
    }
}
