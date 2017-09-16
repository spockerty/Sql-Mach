using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Gradingsys
{
    class DataHelper
    {
        public SqlConnection cn = new SqlConnection(Properties.Settings.Default.Connection);

        public DataHelper()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ExecuteQuery(string Query)
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(Query, cn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
