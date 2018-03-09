<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupSessionList.aspx.cs" Inherits="WebApplication1.Reports.GroupSessionList" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=14.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="margin: 0px; padding: 0px;">
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">               
            </asp:ScriptManager>
            <rsweb:ReportViewer id="gsl" runat ="server"
    Font-Names="Verdana" Font-Size="8pt" Width="100%" ProcessingMode="Remote"
    ShowToolBar="True"  ShowCredentialPrompts="False" 
    ShowFindControls="False" ShowZoomControl="False" CssClass="ReportViewer" >
            </rsweb:ReportViewer>  
        </div>
    </form>
</body>
</html>