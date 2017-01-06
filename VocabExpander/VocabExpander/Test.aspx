<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="VocabExpander.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="word" HeaderText="word" SortExpression="word" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:VocabularyConnectionString %>" SelectCommand="SELECT * FROM [Vocab]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
