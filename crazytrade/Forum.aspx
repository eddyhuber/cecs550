<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Forum.aspx.cs" Inherits="Forum" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script>
        function myFunction(arg) {
            //document.getElementById("demo").innerHTML = "Hello World";
            var a = arg;
            //alert("Hey there #"+ a);
            __doPostBack('btnSave', arg);
        }
    </script>
    <h1><%: Title %></h1>
    <h3>Welcome for the forums!</h3>

     <input runat="server" id="createbt" type="button" align="right" Value="Create Post" onclick="location.href='CreatePost.aspx'"/>

    <hr width="100%" style="border: 2px dashed #C0C0C0" color="#FFFFFF" size="6"> 

    <%{ Response.Write(DoRead()); }%>
    <%{         if (IsPostBack)
        {
           
            string parameter = Request["__EVENTARGUMENT"];
            Response.Write(LoadPost(parameter));
        }
        }%>

    <article>
        <p>        
            Displays current/top threads that people are talking about.
        </p>
    </article>
</asp:Content>
