<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin-login.aspx.cs" Inherits="admin_loginaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Attendance Management System</title>
<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
<meta content="width=device-width, initial-scale=1" name="viewport" />
<meta content="Preview page of Metronic Admin Theme #4 for " name="description" />
<meta content="" name="author" />

<!-- BEGIN GLOBAL MANDATORY STYLES -->
<link href="http://fonts.googleapis.com/css?family=Open+Sans:400,300,600,700&amp;subset=all" rel="stylesheet" type="text/css" />
<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
<link href="~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css" rel="stylesheet" type="text/css" />
<!-- END GLOBAL MANDATORY STYLES -->

<!-- BEGIN THEME GLOBAL STYLES -->
<link href="~/assets/global/css/components.min.css" rel="stylesheet" id="style_components" type="text/css" />
<link href="~/assets/global/css/plugins.min.css" rel="stylesheet" type="text/css" />
<!-- END THEME GLOBAL STYLES -->

<!-- BEGIN PAGE LEVEL STYLES -->
<link href="~/assets/pages/css/login-4.min.css" rel="stylesheet" type="text/css" />
<!-- END PAGE LEVEL STYLES -->
<!-- BEGIN THEME LAYOUT STYLES -->

<!-- END THEME LAYOUT STYLES -->
<link rel="shortcut icon" href="images/favicon.ico" /> 


<!-- STYSHEET -->  
<link href="css/style.css" rel="stylesheet" type="text/css" />

<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css" type="text/css"/>


<style type="text/css">
.headbox h1{ width:100%; border:2px solid #f5f5f5; background-color:#e6e6e6; padding:10px; color:#e21f26; 
           border-radius:2px;font-weight:bold; font-size:17px;text-align:center ; font-family:'Lato', sans-serif}
</style>
</head>
<body class=" login">
    <form id="form1" runat="server" defaultbutton="btnlogin">
     <!-- BEGIN LOGO -->
        <div class="logo">
            <a href="admin_login.aspx">
                <img src="images/galgotias-university-vector-logo.png" alt="Galgotia University" style="width:250px"/> </a>
        </div>
        <!-- END LOGO -->

       
        <div class="content">
            <div style="margin-top:-25px">
            <p> <span>    Attendance App   </span>  </p>
            </div>

                <div class="alert alert-danger display-hide">
                    <button class="close" data-close="alert"></button>
                    <span> Enter any username and password. </span>
                </div>
                <div class="form-group">
                    <!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
                    <label class="control-label visible-ie8 visible-ie9">Username</label>
                    <div class="input-icon">
                        <i class="fa fa-user"></i>
                        <asp:TextBox ID="txtcode" runat="server" CssClass="form-control placeholder-no-fix" placeholder="Enter Username"></asp:TextBox> 
                    <asp:RequiredFieldValidator ID="rfvempcode" runat="server" ControlToValidate="txtcode" ForeColor="Red"
                     Display="Dynamic" ErrorMessage="Please Enter correct User Code" ValidationGroup="Eng"></asp:RequiredFieldValidator>
                       <%-- <input class="form-control placeholder-no-fix" type="text" autocomplete="off" placeholder="Username" name="username" /> --%></div>
                </div>

                <div class="form-group">
                    <label class="control-label visible-ie8 visible-ie9">Password</label>
                    <div class="input-icon">
                        <i class="fa fa-lock"></i>
                     <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control placeholder-no-fix" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="rfvEngPass" runat="server" ControlToValidate="txtPassword" ForeColor="Red"
                Display="Dynamic" ErrorMessage="Please Enter correct Password" ValidationGroup="Eng"></asp:RequiredFieldValidator></div>
                </div>

                <div class="form-actions">
                  <asp:Button runat="server" ID="btnlogin" CssClass="btn red pull-right" Text="LOGIN" OnClick="btnlogin_Click" CausesValidation="true" style="padding:6px 20px !important"/>
               
                     <asp:Label ID="lblmsg" runat="server"  ForeColor="Red" ></asp:Label>
                  <br />
                </div>
		
		

           
            <!-- END LOGIN FORM -->
        
        </div>
        <!-- END LOGIN -->
        <!-- BEGIN COPYRIGHT -->
        <div class="copyright">Copyright @2017 Vision India - All rights Reserved.</div>
        <!-- END COPYRIGHT -->
       

       

    </form>
</body>
</html>
