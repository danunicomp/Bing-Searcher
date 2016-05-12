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
            this.cmbUserAgent = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webMain
            // 
            this.webMain.Location = new System.Drawing.Point(12, 12);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(1214, 381);
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
            this.btnDoSearch.Location = new System.Drawing.Point(6, 16);
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
            this.lblSearchLinesRead.Location = new System.Drawing.Point(6, 110);
            this.lblSearchLinesRead.Name = "lblSearchLinesRead";
            this.lblSearchLinesRead.Size = new System.Drawing.Size(146, 13);
            this.lblSearchLinesRead.TabIndex = 10;
            this.lblSearchLinesRead.Text = "Lines Read From Search List:";
            this.lblSearchLinesRead.Click += new System.EventHandler(this.lblSearchLinesRead_Click);
            // 
            // txtSearchTermsRead
            // 
            this.txtSearchTermsRead.Location = new System.Drawing.Point(158, 100);
            this.txtSearchTermsRead.Name = "txtSearchTermsRead";
            this.txtSearchTermsRead.ReadOnly = true;
            this.txtSearchTermsRead.Size = new System.Drawing.Size(49, 20);
            this.txtSearchTermsRead.TabIndex = 11;
            // 
            // btnBingDashboard
            // 
            this.btnBingDashboard.Location = new System.Drawing.Point(89, 16);
            this.btnBingDashboard.Name = "btnBingDashboard";
            this.btnBingDashboard.Size = new System.Drawing.Size(75, 38);
            this.btnBingDashboard.TabIndex = 12;
            this.btnBingDashboard.Text = "Bing Dashboard";
            this.btnBingDashboard.UseVisualStyleBackColor = true;
            this.btnBingDashboard.Click += new System.EventHandler(this.btnBingDashboard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUserAgent);
            this.groupBox1.Controls.Add(this.btnDoSearch);
            this.groupBox1.Controls.Add(this.btnBingDashboard);
            this.groupBox1.Controls.Add(this.txtSearchTermsRead);
            this.groupBox1.Controls.Add(this.lblSearchLinesRead);
            this.groupBox1.Location = new System.Drawing.Point(12, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 134);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cmbUserAgent
            // 
            this.cmbUserAgent.Items.AddRange(new object[] {
            "Normal",
            "Mobile"});
            this.cmbUserAgent.Location = new System.Drawing.Point(9, 61);
            this.cmbUserAgent.Name = "cmbUserAgent";
            this.cmbUserAgent.Size = new System.Drawing.Size(121, 21);
            this.cmbUserAgent.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 571);
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
    }
}

