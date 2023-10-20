using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if(instance == null)
                    instance = new DataProvider();
                return instance;
            }
        }

        public DataProvider()
        {
        }

        string connectStr = @"Data Source=K1ETHOANG;Initial Catalog=c_product;Integrated Security=True";

        public DataTable execSql(string sql, params object[] args)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(" ");

                    List<string> paramList = new List<string>();

                    foreach (string prm in processSql)
                    {
                        if (prm.StartsWith("@"))
                        {
                            if (prm.EndsWith(","))
                                paramList.Add(prm.Remove(prm.Length - 1));
                            else
                                paramList.Add(prm);
                        }
                    }

                    for (int i = 0; i < args.Length; i++)
                        cmd.Parameters.AddWithValue(paramList[i], args[i]);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }


        // INSERT, UPDATE, DELETE...
        public int execNonSql(string sql, params object[] args)
        {
            int effectedRows = 0;
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(sql, connection);

                if (args.Length > 0)
                {
                    string[] processSql = sql.Split(" ");

                    List<string> paramList = new List<string>();

                    foreach (string prm in processSql)
                    {
                        if (prm.StartsWith("@"))
                        {
                            if (prm.EndsWith(","))
                                paramList.Add(prm.Remove(prm.Length - 1));
                            else
                                paramList.Add(prm);
                        }
                    }

                    for (int i = 0; i < args.Length; i++)
                        cmd.Parameters.AddWithValue(paramList[i], args[i]);
                }

                effectedRows = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return effectedRows;
        }
    }
}
