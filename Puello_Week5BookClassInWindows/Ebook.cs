using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Adding workspace 
using System.Data;
using System.Data.SqlClient;

namespace Puello_Week5BookClassInWindows
{
    //This is a ebook
    class Ebook: Book  
    {
        private DateTime dateRentalExpires;
        private int bookmarkPage;

        // Public get and set for the rental date
        public DateTime DateRentalExperes
        {
            get
            {
                return dateRentalExpires;
            }
            set
            {
                //This will check for the rental date. It had to be only 14 day+.
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    Feedback += "ERROR: Enter a Rental Date that surpass 14 days from today's date.\n";
                }
            }
        }
        //The Book page mark. 
        public int BookmarkPage
        {
            get
            {
                return bookmarkPage;
            }
            set
            {
                if (value >= 0 && value <= Pages) //Storing pages. The bookmark cannot be higher that the number of pages. 
                {
                    bookmarkPage = value;
                }
                else
                {
                    Feedback += "ERROR:Sorry The book mark is grater than the number of pages."; //Error Message
                }

            }
        }    

        // Thi function inher
        public string AddingRecord()
        {
            string strResult = "";

            //Making a connection object to SQL
            SqlConnection Conn = new SqlConnection();

            //Conn is the new connection and also here we have the connnection like to the SQL server.
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE133_BPuello-Martinez;User Id=SE133_BPuello-Martinez;Password=008013888;";

            //Here we are inserting the connection to SQL columns.
            string strSQL = "INSERT INTO Ebooks (Title, AuthorFirst, AuthorLast, AuthorEmail, Pages, DatePublished, DateRentalExpires, BookmarkPage)" + " VALUES " +
                "(@Title, @AuthorFirst, @AuthorLast,@AuthorEmail, @Pages, @DatePublished, @DateRentalExpires, @BookmarkPage )";

            //Creating a new object in order to command line that connect the Formi to SQL colomns.
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = strSQL;
            Comm.Connection = Conn;
            //Fill the parameter into their owne values.
            //Adding the values
            Comm.Parameters.AddWithValue("@Title", Title);
            Comm.Parameters.AddWithValue("@AuthorFirst", AuthorFirst);
            Comm.Parameters.AddWithValue("@AuthorLast", AuthorLast);
            Comm.Parameters.AddWithValue("@AuthorEmail", Email);
            Comm.Parameters.AddWithValue("@Pages", Pages);
            Comm.Parameters.AddWithValue("@DatePublished", DatePublished);
            Comm.Parameters.AddWithValue("@DateRentalExpires", DateRentalExperes);
            Comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);

            //Attempting to connect to the SQL server
            try
            {
                Conn.Open();
                int intRecs = Comm.ExecuteNonQuery(); //opening connections to DB
                strResult = $"SUCCESS: Inserted {intRecs} Records.";   //Report that we made that connection
                Conn.Close();                                
                                                                
            }
            catch (Exception err)
            {
                strResult = "ERROR:" + err.Message; //This is a trap error and error feedback
            }
            finally
            {

            }

            return strResult; //returning the value
        }

        //#########################################################################################################
        //Adding New Material

        public DataSet SearchEBooks(String strTitle, String strAuthorLast)
        {
            //create a dataset to return filled
            DataSet ds = new DataSet();

            //creating s command for SQL Statement
            SqlCommand Comm = new SqlCommand();



            //writing a select statement to perform
            String strSQL = "SELECT EBOOK_ID, Title, AuthorFirst, AuthorLast From EBook Where 0=0";

            //##########
            SqlConnection Conn = new SqlConnection();

            String strConn = @GetConnected();
            Conn.ConnectionString = strConn;

            //
            Comm.Connection = Conn;
            Comm.CommandText = strSQL;

            //adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = Comm;

            //##########
            //Get Data

        }



        //This is the constructor.
        public Ebook(): base()
        {
            BookmarkPage = 0;
            dateRentalExpires = DateTime.Now.AddDays(14);
        }
                
    }    
}
