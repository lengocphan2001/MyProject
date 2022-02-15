<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="TestLoginLogoutApplication.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Tên đăng nhập</label>
            <input name="tendn" value="" type="text"/>
            <br />
            <label>Mật khẩu</label>
            <input name="pass" value="" type="password"/>
            <br />
            <label>Nhập lại mật khẩu</label>
            <input name="repass" value="" type="password"/>
            <br />
        </div>
        <input type="submit" name="signup" value="Đăng kí"/>
    </form>
</body>
</html>
