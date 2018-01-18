using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for DataHelper
/// </summary>
public class DataHelper
{
    public static DataTable SearchData;
    public static bool getMasterData() {
        try
        {
            SearchData = new DataTable();
            SearchData = SqlHelper.ReturnRows("");
            return true;
        }
        catch (Exception ex)
        {
            writeerrorlogin.errorwrite(ex.Message);
            return false;
        }
    }
    


}