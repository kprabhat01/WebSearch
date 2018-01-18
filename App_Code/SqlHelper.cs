using System;
using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for SqlHelper
/// </summary>
public class SqlHelper
{
    public static string SqlStrig = System.Configuration.ConfigurationSettings.AppSettings.Get("con");

    public static DataTable ReturnRows(string query)
    {
        DataTable dt = new DataTable();
        try
        {
            MySqlConnection con = new MySqlConnection(SqlStrig);
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                {
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                writeerrorlogin.errorwrite(ex.StackTrace);
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
        }
        catch (Exception ex)
        {
            writeerrorlogin.errorwrite(ex.StackTrace);
        }
        return dt;
    }
}
