<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackEx.aspx.cs" Inherits="PostBack.PostBackEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
        <asp:TextBox ID="TextBox1" runat="server"  style="margin-bottom: 41px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    </form>
</body>
</html>
