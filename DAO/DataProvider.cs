using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF
{
    class DataProvider
    {
        private static DataProvider instance;


        private String connectionStr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        internal static DataProvider Instance { 
            get { if (instance == null) instance = new DataProvider(); return instance; }  
            private set { instance = value; } 
        }

        private DataProvider() { }

        public DataTable ExcuteQuery(String query, object[] parameter = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection con= new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                if(parameter != null)
                {
                    String[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (String item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                con.Close();
            }
            return dataTable;
        }



        public int ExcuteNonQuery(String query, object[] parameter = null)
        {
            int data = 0 ;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                if (parameter != null)
                {
                    String[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (String item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }



        public object ExcuteNonScalar(String query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection con = new SqlConnection(connectionStr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                if (parameter != null)
                {
                    String[] listParameter = query.Split(' ');
                    int i = 0;
                    foreach (String item in listParameter)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                con.Close();
            }
            return data;
        }
    }
}
