using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1Project.Controllers
{
    public class InnController : ApiController
    {
        public string Get(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Integrated Security = true; Initial Catalog = INNDatabase");

            SqlCommand com = new SqlCommand("select name from Orgamizations where inn =" + id.ToString() + "", con);
            SqlDataAdapter dp = new SqlDataAdapter(com);
            DataTable data = new DataTable();
            dp.Fill(data);

            return data.Rows[0][0].ToString();
        }
    }
}
