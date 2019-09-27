using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace todoManager
{
    public class dbUtility
    {
        public static void addListItemToDB(String pConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(pConnectionString))
            {
                connection.Open();
                // Do work here; connection closed on following line.

                connection.Close();
            }

        }

    }
}
