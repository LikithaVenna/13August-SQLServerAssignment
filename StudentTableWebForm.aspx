<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentTableWebForm.aspx.cs" Inherits="StudentDataTableAssignment.StudentTableWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="222px" Width="292px">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            StudRollNo&nbsp;&nbsp;
            <asp:TextBox ID="txtRollNo" runat="server" style="height: 22px"></asp:TextBox>
        </p>
        <p>
            StudName&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p id="txtGrade">
            StudBranch&nbsp;&nbsp;
            <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
        </p>
        <p>
            StudGrade&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtGrade" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" BackColor="Red" BorderColor="#FF9900" ForeColor="White"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnInsertWithPara" runat="server" OnClick="BtnInsertWithPara_Click" Text="InsertWithParameters" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnInsertWithSp" runat="server" OnClick="btnInsertWithSp_Click" Text="InsertWithSp" />
        </p>
        <p>
            <asp:Button ID="btnUpdateWithQuotes" runat="server" OnClick="btnUpdateWithQuotes_Click" Text="UpdateWithQuotes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdateWithSp" runat="server" OnClick="btnUpdateWithSp_Click" Text="UpdateWithSp" />
        </p>
        <p>
            <asp:Button ID="btnSearchWithQuotes" runat="server" OnClick="btnSearchWithQuotes_Click" Text="SearchWithQuotes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearchWithPara" runat="server" OnClick="btnSearchWithPara_Click" Text="SearchWithParameters" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
    
</body>
</html>
