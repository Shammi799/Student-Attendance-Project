using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Management;
public partial class app_index : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address, value;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btn_Proceed_Click(object sender, EventArgs e)
    {
        if (Request.QueryString["IMEI"] != null)
        {
            objReader1 = objuser.crm_user_ADMINlogin_Imei(Request.QueryString["IMEI"].ToString());
            if (objReader1.Read())
            {
                Session["user_id"] = objReader1["emp_id"].ToString();
                Session["emp_id"] = objReader1["emp_id"].ToString();
                Session["emp_code"] = objReader1["emp_code"].ToString();
                Session["username"] = objReader1["emp_name"].ToString();
                Session["user_name"] = objReader1["emp_name"].ToString();
                Session["emp_name"] = objReader1["emp_name"].ToString();
                Session["name"] = objReader1["user_name"].ToString();
                Session["personal_email"] = objReader1["personal_email"].ToString();
                Session["role"] = objReader1["role"].ToString();
                Session["location"] = objReader1["location"].ToString();
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("admin-login.aspx?IMEI="+ Request.QueryString["IMEI"].ToString());
            }
        }
        else
        {
            getdata();
        }
    }
    public void getdata()
    {
        Response.Redirect("admin-login.aspx");
        //ManagementClass theClass = new ManagementClass("Win32_Processor");
        //ManagementObjectCollection theCollectionOfResults = theClass.GetInstances();

        //foreach (System.Management.ManagementObject currentResult in theCollectionOfResults)
        //{
        //    string processor_id=(currentResult["ProcessorID"].ToString());
        //    objReader = objuser.crm_user_ADMINlogin_Imei(processor_id);
        //    if (objReader1.Read())
        //    {
        //        Session["user_id"] = objReader["emp_id"].ToString();
        //        Session["emp_id"] = objReader["emp_id"].ToString();
        //        Session["emp_code"] = objReader["emp_code"].ToString();
        //        Session["username"] = objReader["emp_name"].ToString();
        //        Session["user_name"] = objReader["emp_name"].ToString();
        //        Session["emp_name"] = objReader["emp_name"].ToString();
        //        Session["name"] = objReader["user_name"].ToString();
        //        Session["personal_email"] = objReader["personal_email"].ToString();
        //        Session["role"] = objReader["role"].ToString();
        //        Response.Redirect("Default.aspx");
        //    }
        //    else
        //    {
        //        Response.Redirect("admin-login.aspx?IMEI=" + processor_id);
        //    }
        //}
    }
}