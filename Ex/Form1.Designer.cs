
namespace Ex
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPersonalDetails = new System.Windows.Forms.TabPage();
            this.btnNextPD = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.txtSn = new System.Windows.Forms.TextBox();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBanking = new System.Windows.Forms.TabPage();
            this.btnBackBD = new System.Windows.Forms.Button();
            this.btnNextBD = new System.Windows.Forms.Button();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.txtACC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabSubmit = new System.Windows.Forms.TabPage();
            this.btnNextS = new System.Windows.Forms.Button();
            this.btnBackS = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabDataGrid = new System.Windows.Forms.TabPage();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPersonalDetails.SuspendLayout();
            this.tabBanking.SuspendLayout();
            this.tabSubmit.SuspendLayout();
            this.tabDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPersonalDetails);
            this.tabControl1.Controls.Add(this.tabBanking);
            this.tabControl1.Controls.Add(this.tabSubmit);
            this.tabControl1.Controls.Add(this.tabDataGrid);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPersonalDetails
            // 
            this.tabPersonalDetails.Controls.Add(this.btnNextPD);
            this.tabPersonalDetails.Controls.Add(this.dtpDOB);
            this.tabPersonalDetails.Controls.Add(this.cmbCounty);
            this.tabPersonalDetails.Controls.Add(this.txtSn);
            this.tabPersonalDetails.Controls.Add(this.txtFn);
            this.tabPersonalDetails.Controls.Add(this.label4);
            this.tabPersonalDetails.Controls.Add(this.label3);
            this.tabPersonalDetails.Controls.Add(this.label2);
            this.tabPersonalDetails.Controls.Add(this.label1);
            this.tabPersonalDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPersonalDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPersonalDetails.Name = "tabPersonalDetails";
            this.tabPersonalDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPersonalDetails.Size = new System.Drawing.Size(524, 270);
            this.tabPersonalDetails.TabIndex = 0;
            this.tabPersonalDetails.Text = "Personal Details";
            this.tabPersonalDetails.UseVisualStyleBackColor = true;
            // 
            // btnNextPD
            // 
            this.btnNextPD.Location = new System.Drawing.Point(155, 214);
            this.btnNextPD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextPD.Name = "btnNextPD";
            this.btnNextPD.Size = new System.Drawing.Size(109, 26);
            this.btnNextPD.TabIndex = 8;
            this.btnNextPD.Text = ">";
            this.btnNextPD.UseVisualStyleBackColor = true;
            this.btnNextPD.Click += new System.EventHandler(this.btnNextPD_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(165, 166);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(151, 20);
            this.dtpDOB.TabIndex = 7;
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(165, 133);
            this.cmbCounty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(92, 21);
            this.cmbCounty.TabIndex = 6;
            // 
            // txtSn
            // 
            this.txtSn.Location = new System.Drawing.Point(165, 103);
            this.txtSn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSn.Name = "txtSn";
            this.txtSn.Size = new System.Drawing.Size(139, 20);
            this.txtSn.TabIndex = 5;
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(165, 71);
            this.txtFn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(139, 20);
            this.txtFn.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "County";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // tabBanking
            // 
            this.tabBanking.Controls.Add(this.btnBackBD);
            this.tabBanking.Controls.Add(this.btnNextBD);
            this.tabBanking.Controls.Add(this.cmbBank);
            this.tabBanking.Controls.Add(this.txtACC);
            this.tabBanking.Controls.Add(this.label6);
            this.tabBanking.Controls.Add(this.label5);
            this.tabBanking.Location = new System.Drawing.Point(4, 22);
            this.tabBanking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBanking.Name = "tabBanking";
            this.tabBanking.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBanking.Size = new System.Drawing.Size(524, 270);
            this.tabBanking.TabIndex = 1;
            this.tabBanking.Text = "Banking Details";
            this.tabBanking.UseVisualStyleBackColor = true;
            // 
            // btnBackBD
            // 
            this.btnBackBD.Location = new System.Drawing.Point(22, 148);
            this.btnBackBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackBD.Name = "btnBackBD";
            this.btnBackBD.Size = new System.Drawing.Size(56, 30);
            this.btnBackBD.TabIndex = 5;
            this.btnBackBD.Text = "<";
            this.btnBackBD.UseVisualStyleBackColor = true;
            this.btnBackBD.Click += new System.EventHandler(this.btnBackBD_Click);
            // 
            // btnNextBD
            // 
            this.btnNextBD.Location = new System.Drawing.Point(106, 148);
            this.btnNextBD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextBD.Name = "btnNextBD";
            this.btnNextBD.Size = new System.Drawing.Size(56, 30);
            this.btnNextBD.TabIndex = 4;
            this.btnNextBD.Text = ">";
            this.btnNextBD.UseVisualStyleBackColor = true;
            this.btnNextBD.Click += new System.EventHandler(this.btnNextBD_Click);
            // 
            // cmbBank
            // 
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(189, 80);
            this.cmbBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(92, 21);
            this.cmbBank.TabIndex = 3;
            // 
            // txtACC
            // 
            this.txtACC.Location = new System.Drawing.Point(189, 41);
            this.txtACC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtACC.Name = "txtACC";
            this.txtACC.Size = new System.Drawing.Size(76, 20);
            this.txtACC.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account Number";
            // 
            // tabSubmit
            // 
            this.tabSubmit.Controls.Add(this.btnNextS);
            this.tabSubmit.Controls.Add(this.btnBackS);
            this.tabSubmit.Controls.Add(this.btnSubmit);
            this.tabSubmit.Location = new System.Drawing.Point(4, 22);
            this.tabSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSubmit.Name = "tabSubmit";
            this.tabSubmit.Size = new System.Drawing.Size(524, 270);
            this.tabSubmit.TabIndex = 2;
            this.tabSubmit.Text = "Submit";
            this.tabSubmit.UseVisualStyleBackColor = true;
            // 
            // btnNextS
            // 
            this.btnNextS.Location = new System.Drawing.Point(218, 184);
            this.btnNextS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextS.Name = "btnNextS";
            this.btnNextS.Size = new System.Drawing.Size(88, 30);
            this.btnNextS.TabIndex = 2;
            this.btnNextS.Text = ">";
            this.btnNextS.UseVisualStyleBackColor = true;
            this.btnNextS.Click += new System.EventHandler(this.btnNextS_Click);
            // 
            // btnBackS
            // 
            this.btnBackS.Location = new System.Drawing.Point(116, 184);
            this.btnBackS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackS.Name = "btnBackS";
            this.btnBackS.Size = new System.Drawing.Size(88, 30);
            this.btnBackS.TabIndex = 1;
            this.btnBackS.Text = "<";
            this.btnBackS.UseVisualStyleBackColor = true;
            this.btnBackS.Click += new System.EventHandler(this.btnBackS_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(116, 83);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 30);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tabDataGrid
            // 
            this.tabDataGrid.Controls.Add(this.btnAddNew);
            this.tabDataGrid.Controls.Add(this.dgv);
            this.tabDataGrid.Controls.Add(this.btnShowData);
            this.tabDataGrid.Location = new System.Drawing.Point(4, 22);
            this.tabDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabDataGrid.Name = "tabDataGrid";
            this.tabDataGrid.Size = new System.Drawing.Size(524, 270);
            this.tabDataGrid.TabIndex = 3;
            this.tabDataGrid.Text = "DataGrid";
            this.tabDataGrid.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(207, 38);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(147, 19);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New Customer";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(29, 124);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(422, 122);
            this.dgv.TabIndex = 3;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(35, 27);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(88, 30);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 312);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "BankDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPersonalDetails.ResumeLayout(false);
            this.tabPersonalDetails.PerformLayout();
            this.tabBanking.ResumeLayout(false);
            this.tabBanking.PerformLayout();
            this.tabSubmit.ResumeLayout(false);
            this.tabDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPersonalDetails;
        private System.Windows.Forms.TabPage tabBanking;
        private System.Windows.Forms.Button btnNextPD;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.TextBox txtSn;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackBD;
        private System.Windows.Forms.Button btnNextBD;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.TextBox txtACC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabSubmit;
        private System.Windows.Forms.Button btnBackS;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNextS;
        private System.Windows.Forms.TabPage tabDataGrid;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnAddNew;
    }
}

