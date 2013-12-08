<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
        <h3>CrazyTrades Crazy methods and history</h3>
    </hgroup>

    <article>
        <p>        
            CrazyTrades was founded for a project for U of L's Software Engineering class in the Computer Engineering and Computer Science (CECS) department.
            It was designed to rival current trading sites currently on the market, but with one subtle difference.
            Instead of doing with your stocks what you please or just giving them to someone hoping they can give you the best return, we take the best of
            both worlds and allow you to manage your stocks as you see fit, as well as being able to sign up and talk to a professional broker to give you
            the best advice. You can pick and choose which broker seems best for you based on the reviews other satisfied CrazyTrades customers have given 
            from their experience. If ou don't feel like paying, or just have a simple quesiton, our forum page is the right place for you. Talk with other 
            CrazyTrades members to get their input or ideas, or just search the threads to find a solution to your answer if you don't feel like signing up.
        </p>

        <p>        
            This site also allows you to view current stock quotes and prices, get live streaming quotes on stocks of your choice, buy and sell stocks and securities,
            generate various types of reports, create and edit a portfolio, get feedback (from the forum or from licensed, reviewed brokers), and just kick back, 
            relax, and watch your investments grow.
        </p>

        <p>        
            This site is still in its infancy as it's still being developed so please email any bugs or issues you may find, or even if you have a question or comment
            about the site, to the site administrators on the <a runat="server" href="~/Contact.aspx">Contact</a> page.
        </p>
    </article>
</asp:Content>