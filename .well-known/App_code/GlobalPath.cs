using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GlobalPath
/// </summary>
public static class GlobalPath
{
    private static string _ConnectionString;
    static GlobalPath()
    {
        _ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["VisionTime_Conn"].ToString();
    }
    /// <summary>
    /// Properties For Global Path For Connection String For Access String Globally in Application.  
    /// </summary>
    public static string ConnectionString
    {
        get { return _ConnectionString; }
    }
}