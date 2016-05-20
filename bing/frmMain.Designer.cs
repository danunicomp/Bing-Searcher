namespace bing
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDoSearch = new System.Windows.Forms.Button();
            this.lblSearchLinesRead = new System.Windows.Forms.Label();
            this.txtSearchTermsRead = new System.Windows.Forms.TextBox();
            this.btnBingDashboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkJoinBing = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReloadList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserAgent = new System.Windows.Forms.ComboBox();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webMain
            // 
            this.webMain.Location = new System.Drawing.Point(12, 12);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(1061, 381);
            this.webMain.TabIndex = 0;
            this.webMain.Url = new System.Uri("http://bing.com", System.UriKind.Absolute);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(12, 399);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(1214, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // btnDoSearch
            // 
            this.btnDoSearch.Location = new System.Drawing.Point(37, 16);
            this.btnDoSearch.Name = "btnDoSearch";
            this.btnDoSearch.Size = new System.Drawing.Size(75, 38);
            this.btnDoSearch.TabIndex = 9;
            this.btnDoSearch.Text = "Do Search";
            this.btnDoSearch.UseVisualStyleBackColor = true;
            this.btnDoSearch.Click += new System.EventHandler(this.btnDoSearch_Click);
            // 
            // lblSearchLinesRead
            // 
            this.lblSearchLinesRead.AutoSize = true;
            this.lblSearchLinesRead.Location = new System.Drawing.Point(6, 16);
            this.lblSearchLinesRead.Name = "lblSearchLinesRead";
            this.lblSearchLinesRead.Size = new System.Drawing.Size(120, 13);
            this.lblSearchLinesRead.TabIndex = 10;
            this.lblSearchLinesRead.Text = "Lines Read Search List:";
            this.lblSearchLinesRead.Click += new System.EventHandler(this.lblSearchLinesRead_Click);
            // 
            // txtSearchTermsRead
            // 
            this.txtSearchTermsRead.Location = new System.Drawing.Point(9, 32);
            this.txtSearchTermsRead.Name = "txtSearchTermsRead";
            this.txtSearchTermsRead.ReadOnly = true;
            this.txtSearchTermsRead.Size = new System.Drawing.Size(49, 20);
            this.txtSearchTermsRead.TabIndex = 11;
            // 
            // btnBingDashboard
            // 
            this.btnBingDashboard.Location = new System.Drawing.Point(37, 60);
            this.btnBingDashboard.Name = "btnBingDashboard";
            this.btnBingDashboard.Size = new System.Drawing.Size(75, 38);
            this.btnBingDashboard.TabIndex = 12;
            this.btnBingDashboard.Text = "Bing Dashboard";
            this.btnBingDashboard.UseVisualStyleBackColor = true;
            this.btnBingDashboard.Click += new System.EventHandler(this.btnBingDashboard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchList);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.linkJoinBing);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbUserAgent);
            this.groupBox1.Controls.Add(this.btnDoSearch);
            this.groupBox1.Controls.Add(this.btnBingDashboard);
            this.groupBox1.Location = new System.Drawing.Point(1079, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 381);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkJoinBing
            // 
            this.linkJoinBing.AutoSize = true;
            this.linkJoinBing.Location = new System.Drawing.Point(46, 356);
            this.linkJoinBing.Name = "linkJoinBing";
            this.linkJoinBing.Size = new System.Drawing.Size(50, 13);
            this.linkJoinBing.TabIndex = 17;
            this.linkJoinBing.TabStop = true;
            this.linkJoinBing.Text = "Join Bing";
            this.linkJoinBing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkJoinBing_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReloadList);
            this.groupBox2.Controls.Add(this.lblSearchLinesRead);
            this.groupBox2.Controls.Add(this.txtSearchTermsRead);
            this.groupBox2.Location = new System.Drawing.Point(8, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 70);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btnReloadList
            // 
            this.btnReloadList.Location = new System.Drawing.Point(66, 31);
            this.btnReloadList.Name = "btnReloadList";
            this.btnReloadList.Size = new System.Drawing.Size(50, 22);
            this.btnReloadList.TabIndex = 15;
            this.btnReloadList.Text = "Reload";
            this.btnReloadList.UseVisualStyleBackColor = true;
            this.btnReloadList.Click += new System.EventHandler(this.btnReloadList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mode";
            // 
            // cmbUserAgent
            // 
            this.cmbUserAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserAgent.Items.AddRange(new object[] {
            "Normal",
            "Mobile"});
            this.cmbUserAgent.Location = new System.Drawing.Point(14, 124);
            this.cmbUserAgent.Name = "cmbUserAgent";
            this.cmbUserAgent.Size = new System.Drawing.Size(121, 21);
            this.cmbUserAgent.TabIndex = 13;
            // 
            // btnSearchList
            // 
            this.btnSearchList.Location = new System.Drawing.Point(9, 290);
            this.btnSearchList.Name = "btnSearchList";
            this.btnSearchList.Size = new System.Drawing.Size(103, 24);
            this.btnSearchList.TabIndex = 19;
            this.btnSearchList.Text = "Manage Search";
            this.btnSearchList.UseVisualStyleBackColor = true;
            this.btnSearchList.Click += new System.EventHandler(this.btnSearchList_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bing Searcher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDoSearch;
        private System.Windows.Forms.Label lblSearchLinesRead;
        private System.Windows.Forms.TextBox txtSearchTermsRead;
        private System.Windows.Forms.Button btnBingDashboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbUserAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkJoinBing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReloadList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSearchList;
    }
}

