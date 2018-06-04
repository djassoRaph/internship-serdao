using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace UcRappels
{
    public class BDD
    {
        //Variables
        private static MySqlConnection connection;
       // private string connectionString;
        private static string database;



        private static void Startconnection(string mabase)
        {
            
            database = mabase;

            string connectionString = "SERVER= 10.250.0.231 ; DATABASE= "+mabase+ " ;  UID=  sogetrel ; PASSWORD=  sogetrel;SslMode=none;";

            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private static bool OpenConnection(string mabase)
        {
            Startconnection(mabase);
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator" + ex.ToString());
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        //Close connection
        private static bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }


        //  Insert statement

        public static void InsertOrUpdate(string query, string mabase)
        {
            //open connection
            if (OpenConnection(mabase) == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        // Select statement
        public static DataTable SelectDT(string query, string mabase)
        {
            DataTable table = new DataTable();
            //open connection
            if (OpenConnection(mabase) == true)
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                 
                dataAdapter.Fill(table);
                
                //close connection
                CloseConnection();
                
            }
            return table;
        }    
      
       

    }

}

