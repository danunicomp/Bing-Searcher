namespace bing
{
    partial class frmManageSearchList
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
            this.lstSearchList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToSearch = new System.Windows.Forms.Button();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseManageSearch = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.btnSaveList = new System.Windows.Forms.Button();
            this.tboxAddToSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstSearchList
            // 
            this.lstSearchList.FormattingEnabled = true;
            this.lstSearchList.Location = new System.Drawing.Point(12, 39);
            this.lstSearchList.Name = "lstSearchList";
            this.lstSearchList.Size = new System.Drawing.Size(441, 342);
            this.lstSearchList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add to Search List";
            // 
            // btnAddToSearch
            // 
            this.btnAddToSearch.Location = new System.Drawing.Point(712, 210);
            this.btnAddToSearch.Name = "btnAddToSearch";
            this.btnAddToSearch.Size = new System.Drawing.Size(86, 23);
            this.btnAddToSearch.TabIndex = 3;
            this.btnAddToSearch.Text = "Add to Search";
            this.btnAddToSearch.UseVisualStyleBackColor = true;
            this.btnAddToSearch.Click += new System.EventHandler(this.btnAddToSearch_Click);
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(540, 210);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(166, 21);
            this.cmbCatagory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Search List";
            // 
            // btnCloseManageSearch
            // 
            this.btnCloseManageSearch.Location = new System.Drawing.Point(723, 398);
            this.btnCloseManageSearch.Name = "btnCloseManageSearch";
            this.btnCloseManageSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCloseManageSearch.TabIndex = 6;
            this.btnCloseManageSearch.Text = "Close";
            this.btnCloseManageSearch.UseVisualStyleBackColor = true;
            this.btnCloseManageSearch.Click += new System.EventHandler(this.btnCloseManageSearch_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Location = new System.Drawing.Point(12, 387);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLine.TabIndex = 7;
            this.btnDeleteLine.Text = "Delete Line";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // btnSaveList
            // 
            this.btnSaveList.Location = new System.Drawing.Point(378, 387);
            this.btnSaveList.Name = "btnSaveList";
            this.btnSaveList.Size = new System.Drawing.Size(75, 23);
            this.btnSaveList.TabIndex = 8;
            this.btnSaveList.Text = "Save List";
            this.btnSaveList.UseVisualStyleBackColor = true;
            this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
            // 
            // tboxAddToSearch
            // 
            this.tboxAddToSearch.Location = new System.Drawing.Point(540, 91);
            this.tboxAddToSearch.Multiline = true;
            this.tboxAddToSearch.Name = "tboxAddToSearch";
            this.tboxAddToSearch.Size = new System.Drawing.Size(258, 113);
            this.tboxAddToSearch.TabIndex = 9;
            // 
            // frmManageSearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 433);
            this.Controls.Add(this.tboxAddToSearch);
            this.Controls.Add(this.btnSaveList);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.btnCloseManageSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.btnAddToSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSearchList);
            this.Name = "frmManageSearchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmManageSearchList";
            this.Load += new System.EventHandler(this.frmManageSearchList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSearchList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToSearch;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseManageSearch;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.Button btnSaveList;
        private System.Windows.Forms.TextBox tboxAddToSearch;
    }
}