using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBCTutorial11
{
    public class ConnectionClass
    {
        String connection_String;
        SqlConnection sqlConnection;
        public void openConnection()
        {          
            connection_String = @"Data Source=LAPTOP-R5VDH913;Initial Catalog=OurDatabase1;Persist Security Info=True;User ID=ashu;Password=ashu";
            sqlConnection = new SqlConnection(connection_String);
            sqlConnection.Open();
        }
        public void closeConnection()
        {
            sqlConnection.Close();
        }
        public void InsertQueryMethod(String query)
        {
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.InsertCommand = new SqlCommand(query,sqlConnection);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("you have signedup successfully");

        }
        public void SelectQueryMethod(String query)
        {
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            String output=null;
            while (sqlDataReader.Read())
            {
                output = output + sqlDataReader.GetValue(0) + "\n";
            }
            MessageBox.Show(output);            
        }
    }
}
/*
 1. connection string
2. SQLConnection obj
3. open conn
 */