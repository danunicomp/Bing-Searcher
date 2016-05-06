﻿using System;
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

            string BaseSearchUrl = "http://www.bing.com/search?q=";
            string searchphrase;
            string line;
            int RandSearchItem;



            Random r = new Random();
            RandSearchItem = r.Next(1,Job.NumberOfSearchItems);

            Console.WriteLine(Job.searchitems[RandSearchItem]);

            // Open the text file using a stream reader.

/*

            Console.WriteLine("searching for " + line);
                searchphrase = SearchUrl + HttpUtility.UrlEncode(line);
                Console.WriteLine("URL = " + searchphrase);
                webMain.Navigate(searchphrase);
*/

        }

        public string DoSearchTerm ()
        {


            return ("Hello");
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
            webMain.Navigate(WholeURL);

        }

        private void btnBingDashboard_Click(object sender, EventArgs e)
        {
            
            webMain.Navigate("https://www.bing.com/rewards/dashboard");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }



}
