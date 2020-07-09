<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>  
        <asp:Button ID="btnInvoke" runat="server" OnClick="btnInvoke_Click" Text="觸發構建" /><br /><br /><br /><br /><br />
        <asp:TextBox ID="txtWcfParam" runat="server"></asp:TextBox><asp:Button ID="btnWcf" runat="server" Text="測試Wcf服務" OnClick="btnWcf_Click" /><asp:Label ID="lWcfResult" runat="server"></asp:Label>
    </form>
</body>
</html>
