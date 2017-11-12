using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Slimso


//todo change all list box to Text Box
//todo page 315 intro to C#
//todo make a method to hold the connection string
{
    class Data


    

    {

        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        //The constructor sets the defaults upon loading the class, basic com stuff

        public Data()
        {
            
            //this must not be left in place , connection string, 
            Connection.ConnectionString = @"Data Source=MELNICK271\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            Command.Connection = Connection;
        }
        public void ReturnMovie(string rentalid, string result)//DateTime date
        {
            //this updates existing data in the database where the ID of the data equals the ID in the ext box
            
            var myCommand = new SqlCommand("Update RentedMovies set DateReturned=@DateReturned where RMID=@RMID", Connection);

            // create the parameters and pass the data from the textboxes 
            myCommand.Parameters.AddWithValue("@RMID", rentalid);
            myCommand.Parameters.AddWithValue("@DateReturned", result);//date

            Connection.Open();

            myCommand.ExecuteNonQuery();
            Connection.Close();
        }
        public DataTable Loadcustomers()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Customer", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView


        }

        public DataTable LoadMovies()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Movies", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }

        public DataTable LoadRentedMovies()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from RentedMovies", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);
                //fill the datatable from the SQL
                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView
        }

        public DataTable LoadAllRentedMovies()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from test1", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }




        public void AddCustomer (string[]AllCustomerDetails)
        {
            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES ( @FirstName, @LastName, @Address, @Phone)";
             SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = @"Data Source=MELNICK271\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            using (SqlCommand newdata = new SqlCommand(NewEntry, Connection))

            {
                
                newdata.Parameters.AddWithValue("@FirstName", AllCustomerDetails[0]);
                newdata.Parameters.AddWithValue("@LastName", AllCustomerDetails[1]);
                newdata.Parameters.AddWithValue("@Address", AllCustomerDetails[2]);
                newdata.Parameters.AddWithValue("@Phone", AllCustomerDetails[3]);

                Connection.Open();
                newdata.ExecuteNonQuery();
        
            }

        }

        public void AddRented(string[]NewRental)
        {
            string NewRentalEntry = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES ( @MovieIDFK, @CustIDFK, @DateRented)";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = @"Data Source=MELNICK271\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            using (SqlCommand newdataRental = new SqlCommand(NewRentalEntry, Connection))
            {
                newdataRental.Parameters.AddWithValue("@MovieIDFK", NewRental[0]);
                newdataRental.Parameters.AddWithValue("@CustIDFK", NewRental[1]);
                newdataRental.Parameters.AddWithValue("@DateRented", Convert.ToDateTime(NewRental[2]));
                Connection.Open();
                newdataRental.ExecuteNonQuery();


            }
        }

       public void AddMovie (string[]AllMoviesDetails)
        
        {
            string NewMovieEntry = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) VALUES ( @Rating, @Title, @Year, @Rental_cost, @Copies, @Plot, @Genre)";
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = @"Data Source=MELNICK271\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            using (SqlCommand newdataMovie = new SqlCommand(NewMovieEntry, Connection))
            {
                newdataMovie.Parameters.AddWithValue("@Rating", AllMoviesDetails[0]);
                newdataMovie.Parameters.AddWithValue("@Title", AllMoviesDetails[1]);
                newdataMovie.Parameters.AddWithValue("@Year", AllMoviesDetails[2]);
                newdataMovie.Parameters.AddWithValue("@Rental_cost", AllMoviesDetails[3]);
                newdataMovie.Parameters.AddWithValue("@Copies", AllMoviesDetails[4]);
                newdataMovie.Parameters.AddWithValue("@Plot", AllMoviesDetails[5]);
                newdataMovie.Parameters.AddWithValue("@Genre", AllMoviesDetails[6]);
                Connection.Open();
                newdataMovie.ExecuteNonQuery();


            }

        }

    }

    //private void DGVOwner_CellContentClick(Object sender, DataGridViewCellEventArgs e)
    //{
    //    int OwnerID = 0;
    //    //these are the cell clicks for the values in the row that you click on
    //    try
    //    {
    //        OwnerID = (int)DGVOwner.Rows[e.RowIndex].Cells[0].Value;
    //        txtFN.Text = DGVOwner.Rows[e.RowIndex].Cells[1].Value.ToString();
    //        txtLN.Text = DGVOwner.Rows[e.RowIndex].Cells[2].Value.ToString();
    //        //if you are clicking on a row and not outside it
    //        if (e.RowIndex >= 0)
    //        {
    //            //Fill the next CD DGV with the OwnerID DGVCD.DataSource = myDatabase.FillDGVCDWithOwnerClick(OwnerID.ToString());
    //            DGVCD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
    //            TxtOwnerID.Text = OwnerID.ToString();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message);
    //    }
    //}
}

