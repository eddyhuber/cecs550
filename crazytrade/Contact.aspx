<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>

    <%--<section class="contact">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span>425.555.0100</span>
        </p>
        <p>
            <span class="label">After Hours:</span>
            <span>425.555.0199</span>
        </p>
    </section>--%>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">Eddy Huber:</span>
            <span><a href="mailto:eghube01@louisville.edu">eghube01@louisville.edu</a></span>
        </p>
        <p>
            <span class="label">Ranjini Subramanian:</span>
            <span><a href="mailto:r0subr05@louisville.edu">r0subr05@louisville.edu</a></span>
        </p>
        <p>
            <span class="label">Youssef Elhafyani:</span>
            <span><a href="mailto:elhafyani4@gmail.com">elhafyani4@gmail.com</a></span>
        </p>
        <p>
            <span class="label">Tu Nguyen:</span>
            <span><a href="mailto:starcraftcore@gmail.com">starcraftcore@gmail.com</a></span>
        </p>
    </section>

    <%--<section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            One Microsoft Way<br />
            Redmond, WA 98052-6399
        </p>
    </section>--%>
</asp:Content>