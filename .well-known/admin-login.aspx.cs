using System;
using System.Web;
using System.Data.SqlClient;

public partial class admin_loginaspx : System.Web.UI.Page
{
    clsSales objsales = new clsSales();
    clsUser objuser = new clsUser();
    SqlDataReader objReader, objReader1, objReader2;
    string password, empcode, ip_address,value;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string ip_address = HttpContext.Current.Request.UserHostAddress;
        
        objReader = objuser.UspTblStudentSelectByID(txtcode.Text, txtPassword.Text);

        if (objReader.Read())
        {
            rfvEngPass.Validate();
            rfvempcode.Validate();
            if (rfvempcode.IsValid && rfvEngPass.IsValid)
            {
                password = txtPassword.Text.Trim();
                empcode = txtcode.Text.Trim();
                objReader = objuser.UspTblStudentSelectByID(txtcode.Text, txtPassword.Text);
                if (objReader.Read())
                {
                    string mac_address = objReader["IMEI"].ToString();

                    if (mac_address == null || mac_address == "")
                    {
                        Session["user_id"] = objReader["Sno"].ToString();
                        Session["emp_id"] = objReader["Sno"].ToString();
                        Session["emp_code"] = objReader["StudentID"].ToString();
                        Session["username"] = objReader["StudentName"].ToString();
                        Session["user_name"] = objReader["StudentName"].ToString();
                        Session["emp_name"] = objReader["StudentName"].ToString();
                        Session["name"] = objReader["StudentName"].ToString();
                        Session["personal_email"] = objReader["Email"].ToString();
                        Session["MobileNo"] = objReader["MobileNo"].ToString();
                        Session["password"] = objReader["Password"].ToString();
                        Session["location"] = objReader["Location"].ToString();
                        if (Request.QueryString["IMEI"] != null)
                        {
                            value = objuser.crm_user_ADMINlogin_imei_update(txtcode.Text, txtPassword.Text, Request.QueryString["IMEI"].ToString());
                        }
                        Response.Redirect("Default.aspx");
                    }
                    if (Request.QueryString["IMEI"] == null)
                    {
                        objReader = objuser.UspTblStudentSelectByID(txtcode.Text, txtPassword.Text);
                        if (objReader.Read())
                        {
                            string mac_address1 = objReader["IMEI"].ToString();
                            if (mac_address1 != null)
                            {
                                lblmsg.Visible = true;
                                lblmsg.Text = "Visiontime already install in your mobile, you can't login through browser.";
                                Session.Abandon();
                                return;
                            }
                        }
                    }
                    if (mac_address != Request.QueryString["IMEI"].ToString())
                    {
                        lblmsg.Visible = true;
                        lblmsg.Text = "you are not authorized to access.";
                        Session.Abandon();
                        return;
                    }



                }
                else
                {
                    lblmsg.Visible = true;
                    lblmsg.Text = "Please enter correct login details.";
                    Session.Abandon();
                    return;
                }
            }
            objReader.Close();
        }

        else
        {
            lblmsg.Visible = true;
            lblmsg.Text = "Please enter correct login details.";
            Session.Abandon();
            return;
        }
    }
}