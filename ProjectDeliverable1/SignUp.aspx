<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ProjectDeliverable1.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign-Up Page</title>

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

       
       
       
       #btnLogin{
           margin-left:70px;
       }
        #btnSubmit{
           margin-left:30px;
       }
       
       
            
    </style>
</head>
<body>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Customer]"></asp:SqlDataSource>
        <div class="box">
    <form id="form1" runat="server">
    <h2>Sign-Up</h2>
   
       <div class="inputbox">
           <asp:TextBox ID="TextBox1" CssClass="input" runat="server" ></asp:TextBox>
          
          <label class="lable">Name</label>
        </div>
        <div  class="inputbox">
            <asp:TextBox ID="TextBox3" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Address</label>
            </div>
        <div  class="inputbox">
            <asp:TextBox ID="TextBox5" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Occupation</label>
           </div> 
        <div class="inputbox">
            <asp:TextBox ID="TextBox4" CssClass="input" runat="server"></asp:TextBox>
          
          <label class="lable">Username</label>
            </div>
            <div  class="inputbox">
            <asp:TextBox ID="TextBox2" CssClass="input" runat="server" TextMode="Password"></asp:TextBox>
           
           <label class="lable">Password</label>
                </div>
            <br />
            <asp:Button ID="btnSubmit"  background-color=" #03a9f4" runat="server" Text="Submit" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnSubmit_Click" />
           
            <asp:Button ID="btnLogin" background-color=" #03a9f4" runat="server" Text="Login" BorderColor="#00CCFF" Height="39px" Width="89px" OnClick="btnLogin_Click"  />
           
        
            
       
    </form>
    </div>
</body>
</html>
