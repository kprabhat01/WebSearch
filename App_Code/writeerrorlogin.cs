using System;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for writeerrorlogin
/// </summary>
public class writeerrorlogin
{
	public writeerrorlogin()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static void errorwrite(string error)
    {
        try
        {


            string filePath = HttpContext.Current.Server.MapPath("~/logs/logs_" + DateTime.Now.ToString("ddMMMyyyy") + ".txt");
            //FileStream fs = null;
            FileStream fs = null;

            if (!File.Exists(filePath))
            {

                using (fs = File.Create(filePath))
                {



                }

            }
            if (File.Exists(filePath))
            {
                StreamWriter writer = new StreamWriter(filePath, true);
                writer.WriteLine(HttpContext.Current.Request.Url.ToString());
                writer.WriteLine( DateTime.Now.ToString("dd-MMM-yyyy HH:mm:ss") +" "+ error);
                writer.WriteLine("\n");
                writer.Flush();

                writer.Close();

            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            
            
        }
    }
}
