﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Challenge001._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you?
            <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            How much money do you have in your pocket? <asp:TextBox ID="moneyTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="resultButton" runat="server" OnClick="resultButton_Click" Text="Click Me To See Your Future" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
