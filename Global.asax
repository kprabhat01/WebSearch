﻿<%@ Application Language="C#" %>

<script RunAt="server">
    void Application_Start(object sender, EventArgs e)
    {
        CacheHelper.GetCities();
        CacheHelper.GetCatlist();
    }    
</script>

