<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="probandoando.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="Content/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="Content/font-awesome/css/font-awesome.css" rel="stylesheet"/>

    <link href="Content/css/animate.css" rel="stylesheet"/>
    <link href="Content/css/style.css" rel="stylesheet"/>

</head>
<body class="gray-bg">
    <form id="form1" runat="server">

    <div class="middle-box text-center loginscreen animated fadeInDown">
        <div>
            <div>

                <h1 class="logo-name text-center">AHM</h1>

            </div>
            <h3>Bienvenido || AHM</h3>
            <p>La mejor solución para tu negocio
                <!--Continually expanded and constantly improved Inspinia Admin Them (IN+)-->
            </p>
            <p>Inicia sesión. Para verla en acción</p>
            <form class="m-t" role="form" action="index.html">
                <div class="form-group">
                        <label>Usuario</label>
                    <label id="lblUsuAst" runat="server" style="color: red">*</label>
                    <input type="text" runat="server" id="txtUsuario" class="form-control" required=""/>
                </div>
                <div class="form-group">
                    <label>Contraseña</label>
                    <label id="lblPassAst" runat="server" style="color: red">*</label>
                    <input type="password" runat="server" id="txtPass" class="form-control" required=""/>
                </div>
                
                <button runat="server" type="submit" class="btn btn-primary block full-width m-b" id="btnLogin" onserverclick="btnLogin_ServerClick">Login</button>

                <a href="#"><small>Forgot password?</small></a>
                <p class="text-muted text-center"><small>Do not have an account?</small></p>
                <a class="btn btn-sm btn-white btn-block" href="register.html">Create an account</a>
            </form>
            <p class="m-t"> <small>Inspinia we app framework base on Bootstrap 3 &copy; 2014</small> </p>
        </div>
    </div>

    <!-- Mainly scripts -->
    <script src="Content/js/jquery-3.1.1.min.js"></script>
    <script src="Content/js/popper.min.js"></script>
    <script src="Content/js/bootstrap.js"></script>
    </form>
</body>
</html>
