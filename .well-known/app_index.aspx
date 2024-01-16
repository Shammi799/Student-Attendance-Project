<%@ Page Language="C#" AutoEventWireup="true" CodeFile="app_index.aspx.cs" Inherits="app_index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>::  Attendance System ::</title>

<meta name="viewport" content="width=device-width,initial-scale=1,maximum-scale=1,user-scalable=no"/>
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
<meta name="HandheldFriendly" content="true"/>

<!-- FAVICON -->

<link rel="shortcut icon" href="images/favicon.ico" /> 
  
<!-- STYSHEET -->  
<link href="css/style.css" rel="stylesheet" type="text/css" />

<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.3.0/css/font-awesome.min.css" />
<link rel="stylesheet prefetch" href="https://fonts.googleapis.com/css?family=Neuton|Oswald"/>
<link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,600,300italic,600italic,300italic,300,200italic,200,700,700italic,900,900italic" rel="stylesheet" type="text/css" />
<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet" type="text/css"/>

</head>

<body style="background-color:#272727">
<form id="form1" runat="server">

<center>

<div class="logopos">
    <img alt="Galgotia University" src="images/galgotias-university-vector-logo.png" width="300" />
</div>

<br />

    
<div class="content" style="border-top:4px double #56585A;border-bottom:4px double #56585A">
<p><span>    Attendance App  </span> </p>

<p style="color:#F8F8F8; letter-spacing:unset; margin-top:-15px; width:100%; padding:0px 0px 10px 0px; font-family:'Lato', sans-serif; font-size:14px; font-weight:600;">
    Attendance Management System</p>
</div>


<br /><br />
    <asp:Button ID="Btn_Proceed" CssClass="w3-button w3-red" runat="server" Text="PROCEED" OnClick="Btn_Proceed_Click"></asp:Button>
<%--<a href="admin-login.aspx" class="w3-button w3-red"><i class="fa fa-sign-in" aria-hidden="true"></i> &nbsp; PROCEED &nbsp; </a>--%>




</center>





</form>
</body>
</html>
