<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Challenge003._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <span class="auto-style1">Your Note Taking Preference</span><br class="auto-style1" />
            <br />
            <asp:RadioButton ID="pencilRadioButton" runat="server" CssClass="auto-style2" GroupName="NoteTaking" OnCheckedChanged="pencilRadioButton_CheckedChanged" Text="Pencil" />
            <br class="auto-style2" />
            <asp:RadioButton ID="penRadioButton" runat="server" CssClass="auto-style2" GroupName="NoteTaking" Text="Pen" />
            <br class="auto-style2" />
            <asp:RadioButton ID="phoneRadioButton" runat="server" CssClass="auto-style2" GroupName="NoteTaking" Text="Phone" />
            <br class="auto-style2" />
            <asp:RadioButton ID="tabletRadioButton" runat="server" CssClass="auto-style2" GroupName="NoteTaking" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#FFFFCC" style="font-size: x-large"></asp:Label>
            <br />
            <br />
            <asp:Image ID="myImage" runat="server" Height="101px" Width="119px" />
        </div>
    </form>
</body>
</html>
