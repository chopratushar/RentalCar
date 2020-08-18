<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentalRequest.aspx.cs" Inherits="ProjectDeliverable1.RentalRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Requests</title>

    <style type="text/css">
     body{
         margin:0;
         padding:0;
         background: url(images/cars.jpg);
         background-size: cover;
         
         font-family: sans-serif;
     }
        .box {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
            width: 800px;
            padding: 40px;
            background: rgba(0,0,0,.5);
            box-sizing: border-box;
            box-shadow: 0 15px 25px rgba(0,0,0, .5);
            border-radius: 10px;
        }
        .box h2
        {
            margin:0 0 30px;
            padding:0;
            color: #fff;
            text-align:center;
        }
        .box .inputbox{
            position:relative;
        }
        .box .inputbox .input{
            width:100%;
            padding:10px;
            font-size: 16px;
            color:#03a9f4;
            margin-bottom: 30px;
            border: none;
            border-bottom: 1px solid #fff;
            outline: none;
            background: transparent;
        }
        .box .inputbox .lable{
            position:absolute;
            top:0;
            left:0;
            padding:10px 0;
            font-size: 16px;
            color: #fff;
            pointer-events:none;
            transition:.5s;

        }
        .box .inputbox .input:focus ~ .lable,
        .box .inputbox .input:valid ~ .lable
         {
           
            top:-20px;
            left:0;
            font-size: 18px;
            color: #03a9f4;
        }

       
       
       
       #btnHome{
           margin-left:10px;
       }
        #btnAccept{
           margin-left:10px;
       }
        #btnReject{
           margin-left:10px;
       }
       
       
            
    </style>
</head>
<body>
        <div class="box">
    <form id="form1" runat="server">
    <h2>View Requests</h2>
        <br />
   
       <div class="inputbox">
           



            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False"   
            BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px"   
            CellPadding="4" ForeColor="Black" GridLines="Vertical">  
            <AlternatingRowStyle BackColor="White" />  
            <Columns>  
                <asp:TemplateField HeaderText="ID">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Customer Name">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Name") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Manifacturer">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Manifacturer") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Manifacturer") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  

                <asp:TemplateField HeaderText="Model">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Model") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Model") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Year">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Year") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Year") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                <asp:TemplateField HeaderText="StartDate">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("StartDate") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("StartDate") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="EndDate">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("EndDate") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("EndDate") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Rent Per Day">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("RentPerDay") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("RentPerDay") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Status">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("Approved") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("Approved") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Note">  
                    <EditItemTemplate>  
                        <asp:TextBox ID="TextBox91" runat="server" Text='<%# Bind("Note") %>'></asp:TextBox>  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:Label ID="Label91" runat="server" Text='<%# Bind("Note") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Select Data">  
                    <EditItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
                    </EditItemTemplate>  
                    <ItemTemplate>  
                        <asp:CheckBox ID="CheckBox1" runat="server" />  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
            <FooterStyle BackColor="#CCCC99" />  
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />  
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />  
            <RowStyle BackColor="#F7F7DE" />  
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />  
            <SortedAscendingCellStyle BackColor="#FBFBF2" />  
            <SortedAscendingHeaderStyle BackColor="#848384" />  
            <SortedDescendingCellStyle BackColor="#EAEAD3" />  
            <SortedDescendingHeaderStyle BackColor="#575357" />  
        </asp:GridView>  












          
          
        </div>
        

           
            <br />
            <asp:Button ID="btnAccept"  background-color=" #03a9f4" runat="server" Text="Accept" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnAccept_Click" />
           <asp:Button ID="btnReject"  background-color=" #03a9f4" runat="server" Text="Reject" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnReject_Click" />
            <asp:Button ID="btnHome" background-color=" #03a9f4" runat="server" Text="Home Page" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnHome_Click" />
           
       
            
       
    </form>
    </div>
</body>
</html>
