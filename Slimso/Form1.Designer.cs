using System;
using System.Windows.Forms;

namespace Slimso
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVRentals = new System.Windows.Forms.DataGridView();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.btnAdCu = new System.Windows.Forms.Button();
            this.btnAdMov = new System.Windows.Forms.Button();
            this.btnDelMov = new System.Windows.Forms.Button();
            this.btnUpCus = new System.Windows.Forms.Button();
            this.btnDelCus = new System.Windows.Forms.Button();
            this.btnUpMov = new System.Windows.Forms.Button();
            this.TbxIdCu = new System.Windows.Forms.TextBox();
            this.TbxNamCu = new System.Windows.Forms.TextBox();
            this.TbxSnamCu = new System.Windows.Forms.TextBox();
            this.TbxAdrCu = new System.Windows.Forms.TextBox();
            this.TbxPh = new System.Windows.Forms.TextBox();
            this.TbxMovID = new System.Windows.Forms.TextBox();
            this.TbxMovNam = new System.Windows.Forms.TextBox();
            this.TbxGenre = new System.Windows.Forms.TextBox();
            this.TbxMovPrice = new System.Windows.Forms.TextBox();
            this.TbxMovRelDate = new System.Windows.Forms.TextBox();
            this.BtnAlRen = new System.Windows.Forms.Button();
            this.BtnOutRen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAlMovies = new System.Windows.Forms.Button();
            this.TbxDaRen = new System.Windows.Forms.TextBox();
            this.TbxRat = new System.Windows.Forms.TextBox();
            this.TbxNuCopys = new System.Windows.Forms.TextBox();
            this.TbxMovPlot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxMovRMID = new System.Windows.Forms.TextBox();
            this.TbxIssTime = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(888, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(880, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.Size = new System.Drawing.Size(874, 437);
            this.DGVCustomers.TabIndex = 0;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(880, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.Size = new System.Drawing.Size(874, 437);
            this.DGVMovies.TabIndex = 0;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVRentals);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(880, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVRentals
            // 
            this.DGVRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRentals.Location = new System.Drawing.Point(3, 3);
            this.DGVRentals.Name = "DGVRentals";
            this.DGVRentals.Size = new System.Drawing.Size(874, 437);
            this.DGVRentals.TabIndex = 0;
            this.DGVRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentals_CellContentClick);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.Location = new System.Drawing.Point(6, 10);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(94, 65);
            this.btnReturnMovie.TabIndex = 2;
            this.btnReturnMovie.Text = "Return\r\nMovie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.Location = new System.Drawing.Point(100, 10);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(97, 65);
            this.btnIssueMovie.TabIndex = 3;
            this.btnIssueMovie.Text = "Issue\r\nMovie\r\n";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // btnAdCu
            // 
            this.btnAdCu.Location = new System.Drawing.Point(16, 480);
            this.btnAdCu.Name = "btnAdCu";
            this.btnAdCu.Size = new System.Drawing.Size(118, 63);
            this.btnAdCu.TabIndex = 6;
            this.btnAdCu.Text = "Add\r\nCustomer";
            this.btnAdCu.UseVisualStyleBackColor = true;
            this.btnAdCu.Click += new System.EventHandler(this.btnAdCu_Click);
            // 
            // btnAdMov
            // 
            this.btnAdMov.Location = new System.Drawing.Point(16, 549);
            this.btnAdMov.Name = "btnAdMov";
            this.btnAdMov.Size = new System.Drawing.Size(118, 63);
            this.btnAdMov.TabIndex = 7;
            this.btnAdMov.Text = "Add Movie";
            this.btnAdMov.UseVisualStyleBackColor = true;
            this.btnAdMov.Click += new System.EventHandler(this.btnAdMov_Click);
            // 
            // btnDelMov
            // 
            this.btnDelMov.Location = new System.Drawing.Point(16, 618);
            this.btnDelMov.Name = "btnDelMov";
            this.btnDelMov.Size = new System.Drawing.Size(120, 26);
            this.btnDelMov.TabIndex = 8;
            this.btnDelMov.Text = "Delete Movie";
            this.btnDelMov.UseVisualStyleBackColor = true;
            // 
            // btnUpCus
            // 
            this.btnUpCus.Location = new System.Drawing.Point(185, 480);
            this.btnUpCus.Name = "btnUpCus";
            this.btnUpCus.Size = new System.Drawing.Size(135, 20);
            this.btnUpCus.TabIndex = 9;
            this.btnUpCus.Text = "Update Customer";
            this.btnUpCus.UseVisualStyleBackColor = true;
            // 
            // btnDelCus
            // 
            this.btnDelCus.Location = new System.Drawing.Point(326, 480);
            this.btnDelCus.Name = "btnDelCus";
            this.btnDelCus.Size = new System.Drawing.Size(147, 20);
            this.btnDelCus.TabIndex = 10;
            this.btnDelCus.Text = "Delete Customer";
            this.btnDelCus.UseVisualStyleBackColor = true;
            // 
            // btnUpMov
            // 
            this.btnUpMov.Location = new System.Drawing.Point(16, 650);
            this.btnUpMov.Name = "btnUpMov";
            this.btnUpMov.Size = new System.Drawing.Size(120, 26);
            this.btnUpMov.TabIndex = 11;
            this.btnUpMov.Text = "Update Movie";
            this.btnUpMov.UseVisualStyleBackColor = true;
            // 
            // TbxIdCu
            // 
            this.TbxIdCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxIdCu.Location = new System.Drawing.Point(135, 480);
            this.TbxIdCu.Name = "TbxIdCu";
            this.TbxIdCu.Size = new System.Drawing.Size(44, 26);
            this.TbxIdCu.TabIndex = 24;
            // 
            // TbxNamCu
            // 
            this.TbxNamCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNamCu.Location = new System.Drawing.Point(135, 517);
            this.TbxNamCu.Name = "TbxNamCu";
            this.TbxNamCu.Size = new System.Drawing.Size(111, 26);
            this.TbxNamCu.TabIndex = 25;
            // 
            // TbxSnamCu
            // 
            this.TbxSnamCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSnamCu.Location = new System.Drawing.Point(252, 517);
            this.TbxSnamCu.Name = "TbxSnamCu";
            this.TbxSnamCu.Size = new System.Drawing.Size(112, 26);
            this.TbxSnamCu.TabIndex = 26;
            // 
            // TbxAdrCu
            // 
            this.TbxAdrCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxAdrCu.Location = new System.Drawing.Point(370, 517);
            this.TbxAdrCu.Name = "TbxAdrCu";
            this.TbxAdrCu.Size = new System.Drawing.Size(288, 26);
            this.TbxAdrCu.TabIndex = 27;
            // 
            // TbxPh
            // 
            this.TbxPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPh.Location = new System.Drawing.Point(664, 517);
            this.TbxPh.Name = "TbxPh";
            this.TbxPh.Size = new System.Drawing.Size(117, 26);
            this.TbxPh.TabIndex = 28;
            // 
            // TbxMovID
            // 
            this.TbxMovID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMovID.Location = new System.Drawing.Point(135, 549);
            this.TbxMovID.Name = "TbxMovID";
            this.TbxMovID.Size = new System.Drawing.Size(32, 26);
            this.TbxMovID.TabIndex = 29;
            // 
            // TbxMovNam
            // 
            this.TbxMovNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMovNam.Location = new System.Drawing.Point(185, 549);
            this.TbxMovNam.Name = "TbxMovNam";
            this.TbxMovNam.Size = new System.Drawing.Size(292, 26);
            this.TbxMovNam.TabIndex = 30;
            // 
            // TbxGenre
            // 
            this.TbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxGenre.Location = new System.Drawing.Point(185, 581);
            this.TbxGenre.Name = "TbxGenre";
            this.TbxGenre.Size = new System.Drawing.Size(234, 26);
            this.TbxGenre.TabIndex = 31;
            // 
            // TbxMovPrice
            // 
            this.TbxMovPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMovPrice.Location = new System.Drawing.Point(597, 549);
            this.TbxMovPrice.Name = "TbxMovPrice";
            this.TbxMovPrice.Size = new System.Drawing.Size(61, 26);
            this.TbxMovPrice.TabIndex = 32;
            // 
            // TbxMovRelDate
            // 
            this.TbxMovRelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMovRelDate.Location = new System.Drawing.Point(770, 549);
            this.TbxMovRelDate.Name = "TbxMovRelDate";
            this.TbxMovRelDate.Size = new System.Drawing.Size(117, 26);
            this.TbxMovRelDate.TabIndex = 33;
            // 
            // BtnAlRen
            // 
            this.BtnAlRen.Location = new System.Drawing.Point(6, 81);
            this.BtnAlRen.Name = "BtnAlRen";
            this.BtnAlRen.Size = new System.Drawing.Size(94, 76);
            this.BtnAlRen.TabIndex = 34;
            this.BtnAlRen.Text = "All Rented";
            this.BtnAlRen.UseVisualStyleBackColor = true;
            this.BtnAlRen.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnOutRen
            // 
            this.BtnOutRen.Location = new System.Drawing.Point(103, 81);
            this.BtnOutRen.Name = "BtnOutRen";
            this.BtnOutRen.Size = new System.Drawing.Size(97, 76);
            this.BtnOutRen.TabIndex = 34;
            this.BtnOutRen.Text = "Out Rented";
            this.BtnOutRen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAlMovies);
            this.groupBox1.Controls.Add(this.BtnOutRen);
            this.groupBox1.Controls.Add(this.btnReturnMovie);
            this.groupBox1.Controls.Add(this.BtnAlRen);
            this.groupBox1.Controls.Add(this.btnIssueMovie);
            this.groupBox1.Location = new System.Drawing.Point(919, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 241);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnAlMovies
            // 
            this.BtnAlMovies.Location = new System.Drawing.Point(6, 163);
            this.BtnAlMovies.Name = "BtnAlMovies";
            this.BtnAlMovies.Size = new System.Drawing.Size(94, 72);
            this.BtnAlMovies.TabIndex = 35;
            this.BtnAlMovies.Text = "All Movies";
            this.BtnAlMovies.UseVisualStyleBackColor = true;
            this.BtnAlMovies.Click += new System.EventHandler(this.BtnAlMovies_Click);
            // 
            // TbxDaRen
            // 
            this.TbxDaRen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDaRen.Location = new System.Drawing.Point(787, 517);
            this.TbxDaRen.Name = "TbxDaRen";
            this.TbxDaRen.Size = new System.Drawing.Size(100, 26);
            this.TbxDaRen.TabIndex = 35;
            // 
            // TbxRat
            // 
            this.TbxRat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxRat.ForeColor = System.Drawing.Color.Red;
            this.TbxRat.Location = new System.Drawing.Point(483, 549);
            this.TbxRat.Name = "TbxRat";
            this.TbxRat.Size = new System.Drawing.Size(83, 26);
            this.TbxRat.TabIndex = 36;
            // 
            // TbxNuCopys
            // 
            this.TbxNuCopys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxNuCopys.Location = new System.Drawing.Point(698, 549);
            this.TbxNuCopys.Name = "TbxNuCopys";
            this.TbxNuCopys.Size = new System.Drawing.Size(45, 26);
            this.TbxNuCopys.TabIndex = 37;
            // 
            // TbxMovPlot
            // 
            this.TbxMovPlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxMovPlot.Location = new System.Drawing.Point(906, 284);
            this.TbxMovPlot.Multiline = true;
            this.TbxMovPlot.Name = "TbxMovPlot";
            this.TbxMovPlot.Size = new System.Drawing.Size(336, 190);
            this.TbxMovPlot.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "$";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TbxMovRMID
            // 
            this.TbxMovRMID.Location = new System.Drawing.Point(135, 582);
            this.TbxMovRMID.Name = "TbxMovRMID";
            this.TbxMovRMID.Size = new System.Drawing.Size(32, 20);
            this.TbxMovRMID.TabIndex = 40;
            // 
            // TbxIssTime
            // 
            this.TbxIssTime.Location = new System.Drawing.Point(437, 581);
            this.TbxIssTime.Multiline = true;
            this.TbxIssTime.Name = "TbxIssTime";
            this.TbxIssTime.Size = new System.Drawing.Size(100, 26);
            this.TbxIssTime.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 706);
            this.Controls.Add(this.TbxIssTime);
            this.Controls.Add(this.TbxMovRMID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxMovPlot);
            this.Controls.Add(this.TbxNuCopys);
            this.Controls.Add(this.TbxRat);
            this.Controls.Add(this.TbxDaRen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TbxMovRelDate);
            this.Controls.Add(this.TbxMovPrice);
            this.Controls.Add(this.TbxGenre);
            this.Controls.Add(this.TbxMovNam);
            this.Controls.Add(this.TbxMovID);
            this.Controls.Add(this.TbxPh);
            this.Controls.Add(this.TbxAdrCu);
            this.Controls.Add(this.TbxSnamCu);
            this.Controls.Add(this.TbxNamCu);
            this.Controls.Add(this.TbxIdCu);
            this.Controls.Add(this.btnUpMov);
            this.Controls.Add(this.btnDelCus);
            this.Controls.Add(this.btnUpCus);
            this.Controls.Add(this.btnDelMov);
            this.Controls.Add(this.btnAdMov);
            this.Controls.Add(this.btnAdCu);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridView DGVRentals;
        private System.Windows.Forms.Button btnAdCu;
        private System.Windows.Forms.Button btnAdMov;
        private System.Windows.Forms.Button btnDelMov;
        private System.Windows.Forms.Button btnUpCus;
        private System.Windows.Forms.Button btnDelCus;
        private System.Windows.Forms.Button btnUpMov;
        private System.Windows.Forms.TextBox TbxIdCu;
        private System.Windows.Forms.TextBox TbxNamCu;
        private System.Windows.Forms.TextBox TbxSnamCu;
        private System.Windows.Forms.TextBox TbxAdrCu;
        private System.Windows.Forms.TextBox TbxPh;
        private System.Windows.Forms.TextBox TbxMovID;
        private System.Windows.Forms.TextBox TbxMovNam;
        private System.Windows.Forms.TextBox TbxGenre;
        private System.Windows.Forms.TextBox TbxMovPrice;
        private System.Windows.Forms.TextBox TbxMovRelDate;
        private System.Windows.Forms.Button BtnAlRen;
        private System.Windows.Forms.Button BtnOutRen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAlMovies;
        private System.Windows.Forms.TextBox TbxDaRen;
        private System.Windows.Forms.TextBox TbxRat;
        private System.Windows.Forms.TextBox TbxNuCopys;
        private TextBox TbxMovPlot;
        private Label label1;
        private TextBox TbxMovRMID;
        private TextBox TbxIssTime;
    }
}

