<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ejercicio1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link type="text/css" rel="stylesheet" href="Style1.css"/>
    <title>Mi primera pagina</title>
    <style type="text/css">
        .auto-style1 {
            border: 2px solid #000000;
            background-color: #C0C0C0;
        }
    </style>
</head>
<body>
    <!--Aca iba un <form> WTF!??? -->
        <div>
            <h2 style="text-align:center">Curso de XHTML</h2>
            <h1>Ejemplo de etiquetas CITE & BLOCKQUOTE </h1>

              <cite>
                  Como dijo Mahatma Ghandi:
              </cite>
              <blockquote>
                  <p>
                    Vive como si fueras a morir mañana, y aprende como si
                    fueras a vivir para siempre. 
                  </p>    
              </blockquote>

            <ol> 
                <li>Argentina</li>
                <li>Brasil</li>
                <li>Uruguay</li>
            </ol>

            <div>
               

                <table align="center" cellpadding="3" cellspacing="3" class="auto-style1">
                    <tr>
                        <td>A-1</td>
                        <td>B-1</td>
                        <td>C-1</td>
                    </tr>
                    <tr>
                        <td>A-2</td>
                        <td>B-2</td>
                        <td>C-2</td>
                    </tr>
                </table>
               

            </div>

            <a href="Pagina2.aspx" target="_blank" >Link a Microsoft</a>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#" Target="_blank">Link con ASP</asp:HyperLink>
        
        </div>
    
</body>
</html>
