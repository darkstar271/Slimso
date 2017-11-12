using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace Slimso


// Page 323    click event for movies and
//todo DateTime DateNow = DateTime.Now; setup a way to enter date and time for issue and return movies

{
    public partial class Form1 : Form
    {
        
        Data myData = new Data();
        private string rentalid;
        private string result;
        private string issue;


        public Form1()
        {
            InitializeComponent();
            LoadDB();
        }

        public void LoadDB()
        {
            //load the customer DGV
            //clear out the old data
            DGVCustomers.DataSource = null;
            DGVMovies.DataSource = null;
            DGVRentals.DataSource = null;

            try
            {
                DGVCustomers.DataSource = myData.Loadcustomers();
                // DGVMovies.DataSource = myData.LoadMovies();
                DGVRentals.DataSource = myData.LoadRentedMovies();
                //pass the datatable data to the DataGridView
                // DGVCustomers.AutoResizeColumn(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //DGVRentals.DataSource = myData.LoadAllRentedMovies();
        }

        private void radAllRented_CheckedChanged(object sender, EventArgs e)
        {
            //DGVRentals.DataSource = myData.LoadAllRentedMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVRentals.DataSource = myData.LoadAllRentedMovies();
        }

        private void BtnAlMovies_Click(object sender, EventArgs e)
        {
            DGVMovies.DataSource = myData.LoadMovies();



        }

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            int OwnerID = 0;
            try
            {
                TbxIdCu.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                TbxNamCu.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                TbxSnamCu.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                TbxAdrCu.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                TbxPh.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();

                //if (e.RowIndex >= 0)
                //{
                //    DGVCustomers.DataSource = myData.Fill(OwnerID.ToString());
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }


        private void DGVMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
        //private void DGVRentedMovies_
        private void DGVMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //  TbxIdCu.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                TbxMovID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                TbxMovNam.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                TbxGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                TbxRat.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                TbxMovPrice.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                TbxNuCopys.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                TbxMovRelDate.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                TbxMovPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[6].Value.ToString();


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdCu_Click(object sender, EventArgs e)
        {
            //update  or new

            string[] AllCustomerDetails = {TbxNamCu.Text, TbxSnamCu.Text, TbxAdrCu.Text, TbxPh.Text}; //new string[];

            myData.AddCustomer(AllCustomerDetails);
            LoadDB();


        }

        //TbxMovID.Text 
        //TbxMovNam.Text
        //TbxGenre.Text 
        //TbxRat.Text
        //TbxMovPrice.Text 
        //TbxNuCopys.Text = 
        //TbxMovRelDate.Text = 
        //TbxMovPlot.Text = 
        private void btnAdMov_Click(object sender, EventArgs e)
        {
            // Add more movies
            string[] AllMoviesDetails =
            {
                TbxMovNam.Text, TbxGenre.Text, TbxRat.Text, TbxMovPrice.Text, TbxNuCopys.Text, TbxMovRelDate.Text,
                TbxMovPlot.Text
            };
            myData.AddMovie(AllMoviesDetails);
            LoadDB();


        }


        private void DGVRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TbxMovRMID.Text = DGVRentals.Rows[e.RowIndex].Cells[0].Value.ToString();
                rentalid = TbxMovRMID.Text;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            // use space after s to avoid one-char date format.
            string result = now.ToString();
            //WriteLine($"{now} [s] = {result}");
            this.Text = result;// shows the time
            myData.ReturnMovie(rentalid, result);
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string issue = now.ToString();
            this.Text = issue;
            TbxIssTime.Text = issue;
      

            string[] NewRental = { TbxMovID.Text, TbxIdCu.Text, TbxIssTime.Text, }; //new string[];
            myData.AddRented(NewRental);
            LoadDB();
            
            
            //myData.AddCustomer(AllCustomerDetails);
            //LoadDB();






        }
    }
}
