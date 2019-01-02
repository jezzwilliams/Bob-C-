<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Challenge004._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="myImage" runat="server" Height="93px" />
&nbsp;Papa Bob&#39;s Pizza and Software<br />
            <br />
            <asp:RadioButton ID="babyRadioButton" runat="server" GroupName="size" Text="Baby Bob Size (10&quot;) - $10" />
            <br />
            <asp:RadioButton ID="mamaRadioButton" runat="server" GroupName="size" Text="Mama Bob Size (13&quot;) - $13" />
            <br />
            <asp:RadioButton ID="papaRadioButton" runat="server" GroupName="size" Text="Papa Bob Size (16&quot;) - $16" />
            <br />
            <br />
            <asp:RadioButton ID="thinRadioButton" runat="server" GroupName="crust" Text="Thin Crust" />
            <br />
            <asp:RadioButton ID="deepRadioButton" runat="server" GroupName="crust" Text="Deep Dish (+$2)" />
            <br />
            <br />
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" Text="Pepperoni (+$1.50)" />
            <br />
            <asp:CheckBox ID="onionsCheckBox" runat="server" Text="Onions (+$0.75)" />
            <br />
            <asp:CheckBox ID="greenCheckBox" runat="server" Text="Green Peppers ($0.50)" />
            <br />
            <asp:CheckBox ID="redCheckBox" runat="server" Text="Red Peppers (+$0.75)" />
            <br />
            <asp:CheckBox ID="anchoviesCheckBox" runat="server" Text="Anchovies (+$2)" />
            <br />
            <br />
            Papa Bob&#39;s Special Deal<br />
            <br />
            Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza.<br />
            <br />
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
            <br />
            <br />
            Total: $<asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            Sorry, at this time you can only order one pizza online, and pick-up only ... we need a better website!</div>
    </form>
</body>
</html>
