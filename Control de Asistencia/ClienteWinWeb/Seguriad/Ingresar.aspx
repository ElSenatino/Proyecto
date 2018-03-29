<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ingresar.aspx.cs" Inherits="Ingresar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  
    <title></title>

</head>
<body>

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css"/>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>


     <div class="container">    
        <div id="loginbox" style="margin-top:50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">                    
            <div class="panel panel-info" >
                    <div class="panel-heading">
                        <div class="panel-title">Inicie Sesion</div>
                        <div style="float:right; font-size: 80%; position: relative; top:-10px"><a href="#"  data-toggle="modal" data-target="#exampleModalCenter">Olvido contraseña</a></div>
 
                    </div>     

                    <div style="padding-top:30px" class="panel-body" >

                        <div style="display:none" id="login-alert" class="alert alert-danger col-sm-12"></div>
                            
                        <form id="loginform" class="form-horizontal" role="form">
                                    
                            <div style="margin-bottom: 25px" class="input-group">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                                        <input id="login-username" type="text" class="form-control" name="username" value="" placeholder="Ingrese código o correo" autocomplete="off"/>                                        
                                    </div>
                                
                            <div style="margin-bottom: 25px" class="input-group">
                                        <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                                        <input id="login-password" type="password" class="form-control" name="password" placeholder="Contraseña" autocomplete="off" />
                                    </div>
                                    

                      
                                <div style="margin-top:10px" class="form-group">

                                    <div class="col-sm-12 controls">
                                      <a id="btn-login" href="#" class="btn btn-success">Inciciar</a>
                                    </div>
                                </div>


                                <div class="form-group">
                                    <div class="col-md-12 control">
                                        <div style="border-top: 1px solid#888; padding-top:15px; font-size:85%" >
                                            No te encuetras registrado.
                                        <a href="#" >
                                            Registrate
                                        </a>
                                        </div>
                                    </div>
                                </div>    
                            </form>     



                        </div>                     
                    </div>  
        </div>
         </div>


    <%--Actualizar clave--%>

  


  
  

</body>
</html>
