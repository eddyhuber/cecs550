<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CreatePost.aspx.cs" Inherits="Forum" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <script>
        function myFunction(arg) {
            //document.getElementById("demo").innerHTML = "Hello World";
            var a = arg;
            alert("Hey there #"+ a);
        }
    </script>
    <h1><%: Title %></h1>
    <h3>Welcome for the forums!</h3>
    <asp:Label id="label1" runat="server"/>
    <div>
        <div class="subtitlebox" ">
            Subtitle <input runat="server" id="textboxfield" type="text" />
        </div>
        <div width="600px" class="messagebox"">
            <textarea runat="server" id="textareafield" class="code_input" cols="50" rows="10" wrap="logical"></textarea>
       </div> 
    </div>
    
    <asp:Button runat="server" Text="Create" OnClick="Submitcreate"/>
    <br />
    
    <hr width="100%" style="border: 2px dashed #C0C0C0" color="#FFFFFF" size="6"> 
    
    <article>
        <p>        
            Displays current/top threads that people are talking about.
        </p>
    </article>
</asp:Content>
