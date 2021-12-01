using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Adding workspace 
using System.Data;
using System.Data.SqlClient;

namespace Puello_WindowsAssigment
{
    class PersonV2: Person //inhereting Person 
    {
        //Private strings for cellphones and URLinstagram email.
        private string cellphone;
        private string urlemail;

        public string Cellphone //Name of the public string for Cellphone passing value to lowercase cellphone
        {
            get
            {
                return cellphone;
            }
            set
            {
                //This Funtion will be checking for the length
                if (ValidationLibrary.CheckingForLength(value, 10))
                {
                    cellphone = value;
                }
                else
                {
                    //This is the error message
                    feedback += "ERROR: Pleas enter your cellPhone's .\n";
                }
            }


        }
        public string URLEmail  //Creating public string for URLEmail
        { 
            get
            {
                return urlemail;
            }
            set
            {
                //This is fuction will check for length of 5 and that is not null.
                if (ValidationLibrary.IsValidEmail(value))
                {
                    urlemail = value;
                }
                else
                {
                    feedback += "ERROR: Enter a valid email.\n";
                }
            }
        }


        //Creating a function that will connect to SQL.
        public string AddingRecord()
        {
            //This is an empty string for the reasult message.
            string strResult = "";

            //Making a connection object to SQL
            SqlConnection Conn = new SqlConnection();

            //Conn is the new connector that will allow the program to connect to the right SQL server.
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=SE133_BPuello-Martinez;User Id=SE133_BPuello-Martinez;Password=008013888;";

            //This will allow the program to insert the new information entered in the Form1. Each one has to be in order to each other in order to the program work the right way. 
            string strSQL = "INSERT INTO Persons (FirstN, MiddleN, LastN, FirstS, SecondS, City, State, Zip, Email, Phone, Cellphone, URLEmail) " + "VALUES" + "(@FirstN, @MiddleN, @LastN, @FirstS, @SecondS, @City, @State, @Zip, @Email, @Phone, @Cellphone, @URLEmail)";

            //Creating a New Object in order to command line.
            SqlCommand Comm = new SqlCommand();
            Comm.CommandText = strSQL;

            //This is the connector. 
            Comm.Connection = Conn;

            //Colums Fiels fot the Persons table witch they are set as a parameters.
            Comm.Parameters.AddWithValue("FirstN", FirstN);
            Comm.Parameters.AddWithValue("MiddleN", MiddleN);
            Comm.Parameters.AddWithValue("LastN", LastN);
            Comm.Parameters.AddWithValue("FirstS", FirstS);
            Comm.Parameters.AddWithValue("SecondS", SecondS);
            Comm.Parameters.AddWithValue("City", City);
            Comm.Parameters.AddWithValue("State", State);
            Comm.Parameters.AddWithValue("Zip", Zip);
            Comm.Parameters.AddWithValue("Email", Email);
            Comm.Parameters.AddWithValue("Phone", Phone);
            Comm.Parameters.AddWithValue("Cellphone", Cellphone);
            Comm.Parameters.AddWithValue("URLEmail", URLEmail);
            

            //Attempting to connect to SQL Server.
            try
            {
                Conn.Open();
                int intRecs = Comm.ExecuteNonQuery();
                //This is the message that will let as know that the process was completed.
                strResult = $"SUCCESS: Inserted {intRecs} Records.";
                Conn.Close();
            }
            catch(Exception err)
            {
                strResult = "ERROR" + err.Message;  //Creating a trap error that will let as know what went wrong.
            }
            finally
            {

            }
            return strResult;

        }

        //Creating a Constructor for the PersonV2
        public PersonV2() : base()
        {
            cellphone = "";
        
            urlemail = "";
        }

    }
}
