using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;


namespace bing
{
    public partial class frmMain : Form
    {

        const String Version = "0.9b";
        const String DateModified = "July 8, 2016";

        SearchItem Job = new SearchItem();
        public frmMain()
        {
            InitializeComponent();
            Job.ReadSearchList();
            txtSearchTermsRead.Text = Job.NumberOfSearchItems.ToString();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //Uri uri = new Uri("something in the way");
            Console.WriteLine(System.Web.HttpUtility.UrlEncode("something in the way's"));

            Job.ReadSearchList();

            

            foreach (string s in Job.searchitems)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(Job.NumberOfSearchItems);
           
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

           // string BaseSearchUrl = "http://www.bing.com/search?q=";
           // string searchphrase;
           // string line;
            int RandSearchItem;



            Random r = new Random();
            RandSearchItem = r.Next(1,Job.NumberOfSearchItems);

            Console.WriteLine(Job.searchitems[RandSearchItem]);

            // Open the text file using a stream reader.

        }

        public async Task PageLoad(int TimeOut)
        {
            TaskCompletionSource<bool> PageLoaded = null;
            PageLoaded = new TaskCompletionSource<bool>();
            int TimeElapsed = 0;
            webMain.DocumentCompleted += (s, e) =>
            {
                if (webMain.ReadyState != WebBrowserReadyState.Complete) return;
                
               //if (webMain.Task.IsCompleted) return;
               PageLoaded.SetResult(true);
            };
            //
            while (PageLoaded.Task.Status != TaskStatus.RanToCompletion)
            {
                await Task.Delay(10);//interval of 10 ms worked good for me
                TimeElapsed++;
                if (TimeElapsed >= TimeOut * 100)
                {
                    PageLoaded.TrySetResult(true);
                    //This prevents your method or thread from waiting forever
                }
            }
        }

        private void btnDoSearch_Click(object sender, EventArgs e)
        {
            string BaseSearchUrl = "http://www.bing.com/search?q=";
            string WholeURL;
            Random r = new Random();
            int RandSearchItem = r.Next(1, Job.NumberOfSearchItems);

            WholeURL = BaseSearchUrl + HttpUtility.UrlEncode(Job.searchitems[RandSearchItem]);
            Console.WriteLine(WholeURL);
            txtUrl.Text = WholeURL;
            if (cmbUserAgent.SelectedIndex == 1)
            {
                webMain.Navigate(WholeURL, null, null, "User-Agent:Mozilla/5.0 (Linux; U; Android 2.0; en-us; Droid Build/ESD20) AppleWebKit/525.10+ (KHTML, like Gecko) Version/3.0.4 Mobile Safari/523.12.2");
                
            }
            else
            {
                webMain.Navigate(WholeURL);
            }
            
        }

        private void btnBingDashboard_Click(object sender, EventArgs e)
        {            
            webMain.Navigate("https://www.bing.com/rewards/dashboard");
            Console.WriteLine(cmbUserAgent.SelectedIndex);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Bing Searcher - Version " + Version + " Modified: " + DateModified;
            cmbUserAgent.SelectedIndex = 0;
        }


        private void linkJoinBing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webMain.Navigate("https://www.bing.com/explore/rewards?PUBL=REFERAFRIEND&CREA=RAW&rrid=_e0a3bea7-391f-c38d-13e8-1401630e4996");
        }

        private void btnReloadList_Click(object sender, EventArgs e)
        {
            Job.ReadSearchList();
            txtSearchTermsRead.Text = Job.NumberOfSearchItems.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Job.SaveSearchList();
        }

        private void btnSearchList_Click(object sender, EventArgs e)
        {
            frmManageSearchList form2 = new frmManageSearchList();
            form2.ShowDialog();
            Job.ReadSearchList();
            txtSearchTermsRead.Text = Job.NumberOfSearchItems.ToString();
        }
    }
}
