<%@ Page Title="Forum" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Forum.aspx.cs" Inherits="Forum" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

        <h1><%: Title %></h1>
        <h3>Get Your Answers Today!</h3>
        <ol class="round">
            <li class ="one">
                <h5>Speak to the public by answering or asking a question</h5><br />
            </li>
            <li class="two">
                <h5>Head on over and 
                    <a id="A1" runat="server" href ="~/Account/Register.aspx">Create a New Account</a>
                    to speak to a professional today
                </h5><br />
            </li>
        </ol>


    <article>
        <p>        
            Displays current/top threads that people are talking about.
        </p>
    </article>
</asp:Content>
