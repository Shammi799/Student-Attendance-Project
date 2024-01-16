using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Configuration;
using System.Text;

/// <summary>
/// Summary description for ODApp
/// </summary>
public class ODApp
{
    string URI = ConfigurationManager.AppSettings["URI"];
    
    public ODApp()
    {
     
    }

    public string ApplyOD(ODApply inputs)
    {
        try
        {
            var inputjson = JsonConvert.SerializeObject(inputs);
            using(var client=new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(URI);
                HttpContent inputContent = new StringContent(inputjson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("LeaveManagement/ApplyForOD", inputContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    Result result = JsonConvert.DeserializeObject<Result>(response.Content.ReadAsStringAsync().Result);
                    if (result.response == "OD Request Sent to your Reporting for Approval!")
                    {
                        return "OD Applied Successfully !";
                    }
                    return result.response;
                }
                return "Error Found !";
            }
        }
        catch (Exception ex)
        {
            return "Server Error!";
        }
    }

    public ODgetData CheckODRequest(ODCheck inputs)
    {
        try
        {
            ODgetData result=new ODgetData();
            var inputjson = JsonConvert.SerializeObject(inputs);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(URI);
                HttpContent inputContent = new StringContent(inputjson, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync("Login/ViewAttendanceByDateNew", inputContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<ODgetData>(response.Content.ReadAsStringAsync().Result);
                    if(result.Message== "Data Found")
                    {
                        return result;
                    }
                    else
                    {
                        return null;
                    }
                }
                return result;
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}
public class ODApply
{
    public string EmpCode { get; set; }
    public string RPTEmpCode { get; set; }
    public string Remarks { get; set; }
    public string ODType { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
}
public class Result
{
    public string response { get; set; }
}
public class ODCheck
{
    public string EmpCode { get; set; }
    public string EmpId { get; set; }
    public string Date { get; set; }
}
public class ODgetData
{
    public int Sno { get; set; }
    public string puchin_location { get; set; }
    public string puchin_time { get; set; }
    public string puchout_location { get; set; }
    public string puchout_time { get; set; }
    public string ClickImage { get; set; }
    public string punchoutimage { get; set; }
    public string Status { get; set; }
    public string Message { get; set; }
    public string DateCol { get; set; }
}