using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicamentRemains
{
    public class NetHelper
    {
        public static bool IsConnectedToInternet()
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            try
            {
                using (System.IO.Stream str = wc.OpenRead("http://google.com"))
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsDatabaseAvailable()
        {
            string cnStr = System.Configuration.ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;

            try
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(cnStr))
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
