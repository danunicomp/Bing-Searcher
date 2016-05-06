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
            this.button5 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDoSearch = new System.Windows.Forms.Button();
            this.lblSearchLinesRead = new System.Windows.Forms.Label();
            this.txtSearchTermsRead = new System.Windows.Forms.TextBox();
            this.btnBingDashboard = new System.Windows.Forms.Button();
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(396, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 425);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(31, 483);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 76);
            this.textBox2.TabIndex = 8;
            // 
            // btnDoSearch
            // 
            this.btnDoSearch.Location = new System.Drawing.Point(142, 425);
            this.btnDoSearch.Name = "btnDoSearch";
            this.btnDoSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDoSearch.TabIndex = 9;
            this.btnDoSearch.Text = "Do Search";
            this.btnDoSearch.UseVisualStyleBackColor = true;
            this.btnDoSearch.Click += new System.EventHandler(this.btnDoSearch_Click);
            // 
            // lblSearchLinesRead
            // 
            this.lblSearchLinesRead.AutoSize = true;
            this.lblSearchLinesRead.Location = new System.Drawing.Point(671, 445);
            this.lblSearchLinesRead.Name = "lblSearchLinesRead";
            this.lblSearchLinesRead.Size = new System.Drawing.Size(146, 13);
            this.lblSearchLinesRead.TabIndex = 10;
            this.lblSearchLinesRead.Text = "Lines Read From Search List:";
            // 
            // txtSearchTermsRead
            // 
            this.txtSearchTermsRead.Location = new System.Drawing.Point(821, 441);
            this.txtSearchTermsRead.Name = "txtSearchTermsRead";
            this.txtSearchTermsRead.ReadOnly = true;
            this.txtSearchTermsRead.Size = new System.Drawing.Size(49, 20);
            this.txtSearchTermsRead.TabIndex = 11;
            // 
            // btnBingDashboard
            // 
            this.btnBingDashboard.Location = new System.Drawing.Point(1150, 424);
            this.btnBingDashboard.Name = "btnBingDashboard";
            this.btnBingDashboard.Size = new System.Drawing.Size(75, 38);
            this.btnBingDashboard.TabIndex = 12;
            this.btnBingDashboard.Text = "Bing Dashboard";
            this.btnBingDashboard.UseVisualStyleBackColor = true;
            this.btnBingDashboard.Click += new System.EventHandler(this.btnBingDashboard_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 571);
            this.Controls.Add(this.btnBingDashboard);
            this.Controls.Add(this.txtSearchTermsRead);
            this.Controls.Add(this.lblSearchLinesRead);
            this.Controls.Add(this.btnDoSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webMain);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webMain;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDoSearch;
        private System.Windows.Forms.Label lblSearchLinesRead;
        private System.Windows.Forms.TextBox txtSearchTermsRead;
        private System.Windows.Forms.Button btnBingDashboard;
    }
}

