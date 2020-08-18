<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCar.aspx.cs" Inherits="ProjectDeliverable1.AddCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Car Page</title>

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
            width: 400px;
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
            color: #fff;
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
           margin-left:0px;
       }
        #btnRequest{
           margin-left:0px;
       }
        #btnAddCar{
           margin-left:10px;
       }
       

       
            
    </style>
</head>
<body>
        <div class="box">
    <form id="form1" runat="server">
    <h2>Add Car</h2>
        <br />
   
       <div class="inputbox">
           <asp:TextBox ID="TextBox1" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Manufacturer</label>
        </div>
        <div  class="inputbox">
            <asp:TextBox ID="TextBox3" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Model</label>
            </div>
        <div  class="inputbox">
            <asp:TextBox ID="TextBox5" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Year</label>
           </div> 
        <div class="inputbox">
            <asp:TextBox ID="TextBox4" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Color</label>

            <div  class="inputbox">
            <asp:TextBox ID="TextBox2" CssClass="input" runat="server" ></asp:TextBox>
           
           <label class="lable">Rent per day</label>
                </div>
            <br />
            <asp:Button ID="btnAddCar"  background-color=" #03a9f4" runat="server" Text="Submit" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnAddCar_Click" />
            <asp:Button ID="btnRequest"  background-color=" #03a9f4" runat="server" Text="View Requests" BorderColor="#00CCFF" Height="39px" Width="119px" OnClick="btnRequest_Click" />
            <asp:Button ID="btnHome" background-color=" #03a9f4" runat="server" Text="Home Page" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnHome_Click" />
           
        </div> 
            
       
    </form>
    </div>
</body>
</html>
