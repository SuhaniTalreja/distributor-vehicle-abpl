<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="denied.aspx.cs" Inherits="SLIPGENERATION_MASTER.web_pages.denied" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Access Denied</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f9;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            color: #333;
        }
        #form1 {
            text-align: center;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            
        }
        img {
            height: 300px;
            width: auto;
            border-radius: 10px;
            margin-bottom: 10px;
            padding-left:30px;
        }
        h1 {
            font-size: 2em;
            margin-bottom: 20px;
        }
        p {
            font-size: 1.2em;
            margin-bottom: 20px;
        }
        a {
            display: inline-block;
            margin-top: 20px;
            padding: 10px 20px;
            background-color: red;
            color: white;
            text-decoration: none;
            border-radius: 5px;
            transition: background-color 0.3s;
        }
        a:hover {
            background-color: orangered;
        }
        .picture-button{
            display: flex;
            flex-direction:column;
            justify-content: center;
            align-items: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>OOPS!</h1>
            <p>You do not have permission to view this page.</p>
            <div class="picture-button">
                <img src="../pictures/pngtree-access-denied-vip-icon-trespass-photo-picture-image_6503825.jpg" alt="Access Denied" />
                <a href="javascript:history.back()">Go Back</a>
            </div>
        </div>
    </form>
</body>
</html>
