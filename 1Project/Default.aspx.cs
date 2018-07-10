using System;
using System.Net.Http;

namespace _1Project
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            var response = client.GetStringAsync("http://localhost:1429/api/inn/1");
        }
    }
}