using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


using System.Data.SqlClient;

/// <summary>
/// Summary description for clsSales
/// </summary>
public class clsSales
{
	public clsSales()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    
    string con_str = ConfigurationManager.ConnectionStrings["VisionTime_Conn"].ConnectionString;
    SqlCommand objCommand;
    SqlConnection objConnection;
    SqlDataAdapter objDataAdapter;
    SqlDataReader dataReader;
    DataSet objDataSet;
    DataTable objDataTable;
    private string _flag;
    public string Flag
    {
        get
        {
            return _flag;
        }
        set
        {
            _flag = value;
        }
    }
   
    private string _first_name;
    public string first_name
    {
        get
        {
            return _first_name;
        }
        set
        {
            _first_name = value;
        }
    }
    private string _last_name;
    public string last_name
    {
        get
        {
            return _last_name;
        }
        set
        {
            _last_name = value;
        }
    }
    private string _phone;
    public string phone
    {
        get
        {
            return _phone;
        }
        set
        {
            _phone = value;
        }
    }
    private string _mobile;
    public string mobile
    {
        get
        {
            return _mobile;
        }
        set
        {
            _mobile = value;
        }
    }
    private string _professional_email;
    public string professional_email
    {
        get
        {
            return _professional_email;
        }
        set
        {
            _professional_email = value;
        }
    }
    private string _personal_email;
    public string personal_email
    {
        get
        {
            return _personal_email;
        }
        set
        {
            _personal_email = value;
        }
    }
    private string _title;
    public string title
    {
        get
        {
            return _title;
        }
        set
        {
            _title = value;
        }
    }
    private string _company;
    public string company
    {
        get
        {
            return _company;
        }
        set
        {
            _company = value;
        }
    }
    private string _street;
    public string street
    {
        get
        {
            return _street;
        }
        set
        {
            _street = value;
        }
    }
    private string _landmark;
    public string landmark
    {
        get
        {
            return _landmark;
        }
        set
        {
            _landmark = value;
        }
    }
    private string _city;
    public string city
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }
    private string _state;
    public string state
    {
        get
        {
            return _state;
        }
        set
        {
            _state = value;
        }
    }
    private string _postal_code;
    public string postal_code
    {
        get
        {
            return _postal_code;
        }
        set
        {
            _postal_code = value;
        }
    }
    private string _fax;
    public string fax
    {
        get
        {
            return _fax;
        }
        set
        {
            _fax = value;
        }
    }

    private string _country;
    public string country
    {
        get
        {
            return _country;
        }
        set
        {
            _country = value;
        }
    }
    private string _Office_id;
    public string Office_id
    {
        get
        {
            return _Office_id;
        }
        set
        {
            _Office_id = value;
        }
    }
   
     private string _created_by;
    public string created_by
    {
        get
        {
            return _created_by;
        }
        set
        {
            _created_by = value;
        }
    }
    private DateTime _created_on;
    public DateTime created_on
    {
        get
        {
            return _created_on;
        }
        set
        {
            _created_on = value;
        }
    }
    private string _modify_by;
    public string modify_by
    {
        get
        {
            return _modify_by;
        }
        set
        {
            _modify_by = value;
        }
    }
    private DateTime _modify_on;
    public DateTime modify_on
    {
        get
        {
            return _modify_on;
        }
        set
        {
            _modify_on = value;
        }
    }
  
    private string _orgpersonal_email;
    public string orgpersonal_email
    {
        get
        {
            return _orgpersonal_email;
        }
        set
        {
            _orgpersonal_email = value;
        }
    }
    
    private string _search_value;
    public string search_value
    {
        get
        {
            return _search_value;
        }
        set
        {
            _search_value = value;
        }
    }
    private string _origin;
    public string origin
    {
        get
        {
            return _origin;
        }
        set
        {
            _origin = value;
        }
    }
    private DateTime _from_date;
    public DateTime from_date
    {
        get
        {
            return _from_date;
        }
        set
        {
            _from_date = value;
        }
    }
    private DateTime _to_date;
    public DateTime to_date
    {
        get
        {
            return _to_date;
        }
        set
        {
            _to_date = value;
        }
    }
    
    private string _serial_no;
    public string serial_no
    {
        get
        {
            return _serial_no;
        }
        set
        {
            _serial_no = value;
        }
    }





    private string _bank_branch;
    public string bank_branch
    {
        get
        {
            return _bank_branch;
        }
        set
        {
            _bank_branch = value;
        }
    }

    private string _amount;
    public string amount
    {
        get
        {
            return _amount;
        }
        set
        {
            _amount = value;
        }
    }

    private string _chequeNo;
    public string chequeNo
    {
        get
        {
            return _chequeNo;
        }
        set
        {
            _chequeNo = value;
        }
    }

    private string _Reciptno;
    public string Reciptno
    {
        get
        {
            return _Reciptno;
        }
        set
        {
            _Reciptno = value;
        }
    }

    private string _service_offer;
    public string service_offer
    {
        get
        {
            return _service_offer;
        }
        set
        {
            _service_offer = value;
        }
    }

    private string _orgaddress;
    public string orgaddress
    {
        get
        {
            return _orgaddress;
        }
        set
        {
            _orgaddress = value;
        }
    }

    private string _orgmobile_no;
    public string orgmobile_no
    {
        get
        {
            return _orgmobile_no;
        }
        set
        {
            _orgmobile_no = value;
        }
    }

    private string _service_details;
    public string service_details
    {
        get
        {
            return _service_details;
        }
        set
        {
            _service_details = value;
        }
    }

    private string _org_Name;
    public string org_Name
    {
        get
        {
            return _org_Name;
        }
        set
        {
            _org_Name = value;
        }
    }

    private string _org_id;
    public string org_id
    {
        get
        {
            return _org_id;
        }
        set
        {
            _org_id = value;
        }
    }

    private string _service_type;
    public string service_type
    {
        get
        {
            return _service_type;
        }
        set
        {
            _service_type = value;
        }
    }
    public string CRMorg_regd_insert(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objConnection.Open();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandTimeout = 0;
            objCommand.CommandText = "CRMorg_regd_insert";
            objCommand.Parameters.AddWithValue("@serial_no", objSales.serial_no);
            objCommand.Parameters.AddWithValue("@service_type", objSales.service_type);
            objCommand.Parameters.AddWithValue("@org_id", objSales.org_id);
            objCommand.Parameters.AddWithValue("@org_Name", objSales.org_Name);
            objCommand.Parameters.AddWithValue("@service_details", objSales.service_details);
            objCommand.Parameters.AddWithValue("@orgmobile_no", objSales.orgmobile_no); 
            objCommand.Parameters.AddWithValue("@orgaddress", objSales.orgaddress); 
            objCommand.Parameters.AddWithValue("@service_offer", objSales.service_offer); 
            objCommand.Parameters.AddWithValue("@Reciptno", objSales.Reciptno); 
            objCommand.Parameters.AddWithValue("@chequeNo", objSales.chequeNo); 
            objCommand.Parameters.AddWithValue("@amount", objSales.amount); 
            objCommand.Parameters.AddWithValue("@bank_branch", objSales.bank_branch);
            objCommand.Parameters.AddWithValue("@orgpersonal_email", objSales.orgpersonal_email);
            objCommand.Parameters.AddWithValue("@phone", objSales.phone);
            
            objCommand.Parameters.AddWithValue("@created_by", objSales.created_by);
            objCommand.Parameters.AddWithValue("@flag", objSales.Flag); 

            dataReader = objCommand.ExecuteReader();
            //int i=objCommand.ExecuteNonQuery();
            string j = "0";
            //if(i>0)
            //{
            //    j = "inserted";
            //}
            if (dataReader.Read())
            {
                j = dataReader[0].ToString();
            }
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            dataReader.Close();
            return j;

        }
    }
   
    public SqlDataReader CRMOffice_Select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMOffice_Select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
   
   

    public SqlDataReader servicetype_dd_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "servicetype_dd_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;

        return dataReader;
    }



    

    public DataTable CRMorg_regd_select(clsSales objSales)
    {
        using (SqlConnection objConnection = new SqlConnection(con_str))
        {
               

            SqlCommand objCommand;
            objCommand = objConnection.CreateCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CRMorg_regd_select";
            objCommand.Parameters.AddWithValue("@Flag", objSales.Flag);
            objCommand.Parameters.AddWithValue("@from_date", objSales.from_date);
            objCommand.Parameters.AddWithValue("@to_date", objSales.to_date);
            objConnection.Open();
            objDataAdapter = new SqlDataAdapter();
            objDataAdapter.SelectCommand = objCommand;
            objDataSet = new DataSet();
            objDataAdapter.Fill(objDataSet);
            objCommand.Dispose();
            objConnection.Close();
            objConnection.Dispose();
            return objDataSet.Tables[0];

        }
    }

    public SqlDataReader crmstate_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "crmstate_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }
    public SqlDataReader gender_dd_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "gender_dd_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader membertype_dd_select(int flag)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "membertype_dd_select";
        objCommand.Parameters.AddWithValue("@Flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        //objConnection.Close();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }
    public SqlDataReader CRMCity_Select(string state_id)
    {
        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMCity_Select";
        objCommand.Parameters.AddWithValue("@flag", state_id);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;
    }



    public SqlDataReader CRMorg_regd_update(string serial_no, int flag)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMorg_regd_update";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }


    public SqlDataReader CRMmember_regd_update(string serial_no,int flag)
    {

        objConnection = new SqlConnection(con_str);
        objConnection.ConnectionString = con_str;
        objConnection.Open();
        objCommand = new SqlCommand();
        objCommand.CommandType = CommandType.StoredProcedure;
        objCommand.CommandTimeout = 0;
        objCommand.CommandText = "CRMmember_regd_update";
        objCommand.Parameters.AddWithValue("@serial_no", serial_no);
        objCommand.Parameters.AddWithValue("@flag", flag);
        objCommand.Connection = objConnection;
        dataReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection);
        objCommand.Dispose();
        objCommand = null;
        objConnection = null;
        return dataReader;

    }

}
