using System;
using System.Data;
using System.Collections.Generic;

public class AreaInfo
{
    public int AreaID { get; set; }
    public string AreaName { get; set; }
    public int LiesIn { get; set; }
    public int StateId { get; set; }

}

public class CategoryInfo
{
    public int catid { get; set; }
    public string CategoryName { get; set; }
    public int LiesIn { get; set; }


}
public class CacheHelper
{
    public static List<AreaInfo> CitiLst;
    public static List<CategoryInfo> CatLst;

    public static void GetCities()
    {
        try
        {
           
            CitiLst = new List<AreaInfo>();
            DataTable dt = new DataTable();
            dt = SqlHelper.ReturnRows("SELECT id, areaname,liesin,stateinfo FROM areadetail WHERE deleteflag =0 ORDER BY Areaname");
            if (dt.Rows.Count >= 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    CitiLst.Add(new AreaInfo
                    {
                        AreaID = Convert.ToInt32(dr["id"].ToString()),
                        AreaName = dr["areaname"].ToString(),
                        LiesIn = Convert.ToInt32(dr["liesin"].ToString()),
                        StateId = Convert.ToInt32(dr["stateinfo"].ToString())
                    });
                }
            }
        }
        catch (Exception ex)
        {
            writeerrorlogin.errorwrite(ex.StackTrace);
        }
    }
    public static void GetCatlist()
    {
        try
        {
            DataTable dt = new DataTable();
            CatLst = new List<CategoryInfo>();
            dt = SqlHelper.ReturnRows("SELECT id, catname, liesin FROM categories WHERE deleteflag=0 ORDER BY catname");
           
                foreach (DataRow dr in dt.Rows)
                {
                    CatLst.Add(new CategoryInfo
                    {
                        catid = Convert.ToInt32(dr["id"].ToString()),
                        CategoryName = dr["catname"].ToString(),
                        LiesIn = Convert.ToInt32(dr["liesin"].ToString())
                    });
                }
            
        }
        catch (Exception ex)
        {
            writeerrorlogin.errorwrite(ex.StackTrace);
        }
    }


}
