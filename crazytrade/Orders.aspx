<%@ Page Title="Buy/Sell/Orders" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <section id="buy" style="border:1px black solid; padding: 10px;">
        <h2 style="margin:0px; padding:0px;">BUY</h2>
        <p>
            This is where a user can choose stocks to buy
        </p>
    </section>
    <br />
    <section id="sell" style="border:1px black solid; padding: 10px;">
        <h2 style="margin:0px; padding:0px;">SELL</h2>
        <p>
            This is where a user can choose which of your stocks to sell
    </section>
    <br />
    <section id="current-orders" style="border:1px black solid; padding: 10px;">
        <h2 style="margin:0px; padding:0px;">ORDER HISTORY</h2>
        <p>
            This is where a user can view their current open orders,
            as well as their past history of buys and sells. A user 
            can also cancel a current order from this page (eliminating
            the need for a separate page. Just call a Javascript function
            which has a window that pops up asking if user sure they
            want to cancel order, then another function which deletes
            order record from DB upon button click).
        </p>
    </section>

</asp:Content>