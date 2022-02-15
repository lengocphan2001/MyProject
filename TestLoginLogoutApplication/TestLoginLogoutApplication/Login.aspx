<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestLoginLogoutApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Tên đăng nhập</label>
            <input type="text" value="" name="name"/>
            <br />
            <label>Mật khẩu</label>
            <input type="password" value="" name="pass"/>
            <br />
        </div>
        <input type="submit" value="Đăng nhập" name="login"/>
        <a href="signup.aspx">Chưa có tài khoản? Đăng kí</a>
    </form>
</body>
</html>
