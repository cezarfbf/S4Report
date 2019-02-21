using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4Report
{
    class DataAccess
    {
        SqlConnection conn = new SqlConnection(@"Data Source = 172.16.1.99; Initial Catalog = sst_teste; Integrated Security = True"); 

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            try { 
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            adapter.Fill(dt);
        
            }catch(SqlException e)
            {
                Console.Write(e);
            }

            return dt;
        }
    }
}
