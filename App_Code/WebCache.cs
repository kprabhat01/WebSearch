using System.Linq;
using System.Web.Services;
using System.Collections.Generic;
using System;
using System.Web;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class WebCache : System.Web.Services.WebService
{

    [WebMethod]
    public List<CategoryInfo> GetCategoryList(int LiesIn)
    {
        var ReturnValue = CacheHelper.CatLst.Where(P => P.LiesIn == LiesIn).OrderBy(P => P.CategoryName);
        return ReturnValue.ToList();

    }
    [WebMethod]
    public List<AreaInfo> GetCities(int LiesINValue)
    {
        var ReturnValue = CacheHelper.CitiLst.Where(P => P.LiesIn == LiesINValue);
        return ReturnValue.ToList();
    }
    [WebMethod]
    public void SetCookies(int CookiesType, string value)
    {
        switch (CookiesType)
        {

            case 1:                
                HttpCookie Cattype = new HttpCookie("Catcookies");
                Cattype.Value = value;
                HttpContext.Current.Response.SetCookie(Cattype);
                break;
            case 2:
                HttpCookie AreaType = new HttpCookie("Areacookies");
                AreaType.Value = value;
                HttpContext.Current.Response.SetCookie(AreaType);
                break;
        }
    }

}

